using System.Security.Cryptography;
namespace freelance
{
    /// <summary>
    /// Класс для хэширования данных
    /// </summary>
    public static class Hashing
    {
        /// <summary>
        /// Метод для хэштрования данных
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string hash(string data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data));
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

