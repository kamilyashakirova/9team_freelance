using freelance.forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
namespace freelance
{
    public static class workingwithDB
    {
        private static string message1_work = "Пользователь с таким логином уже существует";
        private static string message2_work = "Пользователь не существует";
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
                    return [interest.ID.ToString(), interest.ISpecialization, interest.IExperience, interest.ITime, interest.ILanguage, interest.IProduct];
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
                    return [performer.ClientID.ToString(), performer.ID.ToString(), performer.PName, 
                        performer.PSpecialization,performer.PTime, performer.PLanguage,performer.PExperience,
                        performer.PProduct, performer.PPicture];
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
                using (var db = new DBcontext())
                {
                    using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                    {
                        lock(db)
                        try
                        {
                            var epassw = Hashing.hash(uPassword);
                            var user = new User { ULogin = uLogin, UPasswordHash = epassw, Email = email };
                            db.Users.Add(user);
                            db.SaveChanges();

                            var client = new Client
                            {
                                UserID = user.UId,
                                ClientName = clientName,
                                ClientSurname = clientSurname,
                                ClientPatronomic = clientPatronomic,
                                InUsers = user,
                                Email = email,
                                ClientPicture = String.Empty
                            };
                            db.Clients.Add(client);
                            db.SaveChanges();
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            transaction.Rollback();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(message1_work);
            }
        }
        public static void AddLike(int ClientID, int performerID)
        {
            using (var db = new DBcontext())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    try
                    {
                        var liked = new LikedPerformers { ClientID = ClientID, PerformerID = performerID };
                        db.LikedPerformers.Add(liked);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        transaction.Rollback();
                    }
                }
            }
        }
        public static void AddDislike(int ClientID, int performerID)
        {
            using (var db = new DBcontext())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    try
                    {
                        var disliked = new DislikedPerformers { ClientID = ClientID, PerformerID = performerID };
                        db.DislikedPerformers.Add(disliked);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        transaction.Rollback();
                    }
                }
            }
        }
        public static void AddInterest(int clientID, string ISpecialization, string ITime, string IExperience,
            string ILanguage, string IProduct)
        {
            using (var db = new DBcontext())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    try
                    {
                        var client = db.Clients.FirstOrDefault(u => u.ID == clientID);
                        if (client != null)
                        {
                            var interest = new Interest { ClientID = clientID, ISpecialization = ISpecialization, ITime = ITime,
                                IExperience = IExperience, ILanguage = ILanguage, IProduct = IProduct };
                            db.Interests.Add(interest);
                            db.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            MessageBox.Show(message2_work);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        transaction.Rollback();
                    }
                }  
            }
        }
        public static void AddPerformer(int clientID, string MyName, string MySpecialization, string MyTime, string MyExperience,
            string MyLanguage, string MyProduct, string MyPicture)
        {
            using (var db = new DBcontext())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    try
                    {
                        var client = db.Clients.FirstOrDefault(u => u.ID == clientID);
                        if (client != null)
                        {
                            var performer = new Performer
                            {
                                ClientID = clientID,
                                PName = MyName,
                                PSpecialization = MySpecialization,
                                PTime = MyTime,
                                PExperience = MyExperience,
                                PLanguage = MyLanguage,
                                PProduct = MyProduct,
                                PPicture = MyPicture,
                                InClients = client
                            };
                            db.Performers.Add(performer);
                            db.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            MessageBox.Show(message2_work);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
