using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
namespace freelance
{
    /// <summary>
    /// Класс для работы с БД
    /// </summary>
    public static class workingwithDB
    {
        private static string message1_work = "Пользователь с таким логином уже существует";
        private static string message2_work = "Пользователь не существует";
        /// <summary>
        /// Метод для авторизации
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
        /// Проверка уникальности логина
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
        /// Метод для добавления в БД новых пользователей и клиентов
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
                        lock (db);
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
                                    ClientPicture = String.Empty, 
                                    VkUserID = String.Empty
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
        /// <summary>
        /// Метод для добавления фрилансера в Избранное 
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="performerID"></param>
        public static void AddLike(Guid clientID, Guid performerID)
        {
            using (var db = new DBcontext())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    lock(db)
                    try
                    {
                            if (!db.LikedPerformers.Any(u => u.PerformerID == performerID))
                            {
                                var liked = new LikedPerformers { ClientID = clientID, PerformerID = performerID };
                                db.LikedPerformers.Add(liked);
                                db.SaveChanges();
                                var u = db.DislikedPerformers.FirstOrDefault(u => u.PerformerID == liked.PerformerID);
                                if (u != null)
                                {
                                    db.DislikedPerformers.Remove(u);
                                    db.SaveChanges();
                                }
                                transaction.Commit();
                                MessageBox.Show("Добавлен в избранное");
                            }
                            else
                            {
                                MessageBox.Show("Вы уже добавляли фрилансера в 'Избранное'");
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
        /// <summary>
        /// Метод для добавления фрилансера в Скрытое
        /// </summary>
        /// <param name="ClientID"></param>
        /// <param name="performerID"></param>
        public static void AddDislike(Guid ClientID, Guid performerID)
        {
            using (var db = new DBcontext())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    lock (db)
                    try
                    {
                        if (!db.DislikedPerformers.Any(u => u.PerformerID == performerID))
                        {
                            var disliked = new DislikedPerformers { ClientID = ClientID, PerformerID = performerID };
                            db.DislikedPerformers.Add(disliked);
                            db.SaveChanges();
                            var u = db.LikedPerformers.FirstOrDefault(u => u.PerformerID == disliked.PerformerID);
                            if (u != null)
                            {
                                db.LikedPerformers.Remove(u);
                                db.SaveChanges();
                            }
                            transaction.Commit();
                            MessageBox.Show("Добавлен в скрытое");
                        }
                        else
                        {
                            MessageBox.Show("Вы уже добавляли фрилансера в 'Скрытое'");
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
        /// <summary>
        /// Метод для добавления предпочтений заказчика в БД
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="ISpecialization"></param>
        /// <param name="ITime"></param>
        /// <param name="IExperience"></param>
        /// <param name="ILanguage"></param>
        /// <param name="IProduct"></param>
        public static void AddInterest(Guid clientID, string ISpecialization, string ITime, string IExperience,
            string ILanguage, string IProduct)
        {
            using (var db = new DBcontext())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    lock (db)
                        try
                    {
                        var client = db.Clients.FirstOrDefault(u => u.ID == clientID);
                        if (client != null)
                        {
                            var interest = new Interest
                            {
                                ClientID = clientID,
                                InterestSpecialization = ISpecialization,
                                InterestTime = ITime,
                                InterestExperience = IExperience,
                                InterestLanguage = ILanguage,
                                InterestProduct = IProduct
                            };
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
        /// <summary>
        /// Метод для добавления фрилансера в БД
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="MyName"></param>
        /// <param name="MySpecialization"></param>
        /// <param name="MyTime"></param>
        /// <param name="MyExperience"></param>
        /// <param name="MyLanguage"></param>
        /// <param name="MyProduct"></param>
        /// <param name="MyPicture"></param>
        public static void AddPerformer(Guid clientID, string MyName, string MySpecialization, string MyTime, string MyExperience,
            string MyLanguage, string MyProduct, string MyPicture)
        {
            using (var db = new DBcontext())
            {
                using (IDbContextTransaction transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
                {
                    lock(db)
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
