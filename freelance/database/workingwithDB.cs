using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Principal;
using Microsoft.VisualBasic.Logging;
namespace freelance
{
    public static class workingwithDB
    {
        /// <summary>
        /// метож, для авторизации
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passw"></param>
        /// <returns></returns>
        public static bool LogIn(string login, string passw)
        {
            using (var db = new DBcontext())
            {
                var elog = hashing.hash(login);
                var user = db.users.Where(user => user.uLogin == elog).FirstOrDefault();
                if (user != null)
                {
                    if (user.uPasswordHash == hashing.hash(passw))
                    {
                        Program.LogInInfo(true, user.uId);
                        return true;
                    }
                }
                return false;
            }
        }
        /// <summary>
        /// метод для загрузки данных о пользователях
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static string[]? clientsloaddata(int userId)
        {
            using (var db=  new DBcontext())
            {
                var client = db.clients.Where(client => client.userID == userId).FirstOrDefault();
                if (client != null)
                {
                    return [client.ID.ToString(), client.clientName, client.clientSurname,
                            client.clientPatronomic, client.email];
                }
                return null;
            }
        }
        public static bool IsUsernameUnique(string login)
        {
            using (var context = new DBcontext())
            {

                var elog = hashing.hash(login);
                return !context.users.Any(u => u.uLogin == elog);
            }
        }
        public static void AddUserAndClient(string uLogin, string uPassword, string email, string clientName, string clientSurname, string clientPatronomic)
        {
            if (IsUsernameUnique(uLogin))
            {
                using (var context = new DBcontext())
                {
                    var elog = hashing.hash(uLogin);
                    var epassw = hashing.hash(uPassword);
                    var user = new user { uLogin = elog, uPasswordHash = epassw, email = email };
                    context.users.Add(user);
                    context.SaveChanges();

                    var client = new client { userID = user.uId, clientName = clientName, clientSurname = clientSurname, clientPatronomic = clientPatronomic, NumberInUsersTable = user, email = email };
                    context.clients.Add(client);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("пользователь с таким логином уже существует");
            }
        }
    }
}
