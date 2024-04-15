namespace freelance
{
    public static class workingwithDB
    {
        /// <summary>
        /// метод для авторизации
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
        /// загрузка данных о "клиентах"
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
                    return [client.ID.ToString(), client.clientName, client.clientSurname, client.clientPatronomic, client.email];
                }
                return null;
            }
        }
        /// <summary>
        /// метод для загрузки данных об интересах клиентов
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public static string[]? interestsloaddata(int clientId)
        {
            using (var db = new DBcontext())
            {
                var interest = db.interests.Where(i => i.clientID == clientId).FirstOrDefault();
                if (interest != null)
                {
                    return [interest.ID.ToString(), interest.ispecialization, interest.itime,interest.ipriceofwork,
                            interest.iExperience, interest.irating];
                }
                return null;
            }
        }
        /// <summary>
        /// метод для загрузки данных об исполнителях
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string[]? performersloaddata(string name)
        {
            using (var db = new DBcontext())
            {
                var performer = db.performers.Where(p => p.pname == name).FirstOrDefault();
                if (performer != null)
                {
                    return [performer.ID.ToString(), performer.pstatus,performer.pname, performer.pstatus, performer.pspecialization,
                            performer.ptime,performer.ppriceofwork, performer.pExperience, performer.prating, performer.ppicture];
                }
                return null;
            }
        }
        /// <summary>
        /// проверка уникальности логина
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static bool IsUsernameUnique(string login)
        {
            using (var context = new DBcontext())
            {

                var elog = hashing.hash(login);
                return !context.users.Any(u => u.uLogin == elog);
            }
        }
        /// <summary>
        /// метод для добавления в бд новых пользователей и клиентов
        /// </summary>
        /// <param name="uLogin"></param>
        /// <param name="uPassword"></param>
        /// <param name="email"></param>
        /// <param name="clientName"></param>
        /// <param name="clientSurname"></param>
        /// <param name="clientPatronomic"></param>
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

                    var client = new client { userID = user.uId, clientName = clientName, clientSurname = clientSurname, clientPatronomic = clientPatronomic,InUsers = user, email = email };
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
