using freelance.classes;

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
                var user = db.Users.FirstOrDefault(user => user.ULogin == login);
                if (user != null)
                {
                    if (user.UPasswordHash == Hashing.hash(passw))
                    {
                        Program.LogInInfo(true, user.UId);
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
                var client = db.Clients.FirstOrDefault(client => client.UserID == userId);
                if (client != null)
                {
                    return [client.ID.ToString(), client.ClientName, client.ClientSurname, client.ClientPatronomic,
                        client.Email, client.ClientPicture.ToString()];
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
                var interest = db.Interests.FirstOrDefault(i => i.ClientID == clientId);
                if (interest != null)
                {
                    return [interest.ID.ToString(), interest.IName, interest.IsLiked];
                }
                return null;
            }
        }
        /// <summary>
        /// метод для загрузки данных об исполнителях
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string[]? performersloaddata(int ID)
        {
            using (var db = new DBcontext())
            {
                var performer = db.Performers.FirstOrDefault(p => p.ID == ID);
                if (performer != null)
                {
                    return [performer.ID.ToString(), performer.PName, 
                        performer.PSpecialization,performer.PTime,performer.PPriceofwork, performer.PExperience,
                        performer.PRating, performer.PPicture];
                }
                return null;
            }
        }
        /// <summary>
        /// метод для загрузки данных о понравившихся фрилансерах
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static string[]? Likedperformersloaddata(int clientId)
        {
            using (var db = new DBcontext())
            {
                var liked = db.LikedPerformers.FirstOrDefault(p => p.ClientID == clientId);
                if (liked != null)
                {
                    return [liked.ID.ToString(), liked.ClientID.ToString(),
                        liked.PerformerID.ToString()];
                }
                return null;
            }
        }
        /// <summary>
        /// метод для загрузки данных о не понравившихся фрилансерах
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static string[]?Dislikedperformersloaddata(int clientId)
        {
            using (var db = new DBcontext())
            {
                var disliked = db.DislikedPerformers.FirstOrDefault(p => p.ClientID == clientId);
                if (disliked != null)
                {
                    return [disliked.ID.ToString(), disliked.ClientID.ToString(),
                        disliked.PerformerID.ToString()];
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
                return !context.Users.Any(u => u.ULogin == login);
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
        public static void AddUserAndClient(string uLogin, string uPassword, string email, string clientName,
            string clientSurname, string clientPatronomic)
        {
            if (IsUsernameUnique(uLogin))
            {
                using (var context = new DBcontext())
                {
                    var epassw = Hashing.hash(uPassword);
                    var user = new User { ULogin = uLogin, UPasswordHash = epassw, Email = email };
                    context.Users.Add(user);
                    context.SaveChanges();

                    var client = new Client { UserID = user.UId, ClientName = clientName, ClientSurname = clientSurname,
                    ClientPatronomic = clientPatronomic,InUsers = user, Email = email , ClientPicture = String.Empty};
                    context.Clients.Add(client);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
            }
        }
        public static void AddLike(int ClientID, int performerID)
        {
            using (var context = new DBcontext())
            {
                var liked = new LikedPerformers { ClientID = ClientID, PerformerID = performerID };
                context.LikedPerformers.Add(liked);
                context.SaveChanges();
            }
        }
        public static void AddDislike(int ClientID, int performerID)
        {
            using (var context = new DBcontext())
            {
                var disliked = new DislikedPerformers { ClientID = ClientID, PerformerID = performerID };
                context.DislikedPerformers.Add(disliked);
                context.SaveChanges();
            }
        }
    }
}
