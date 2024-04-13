using System.Security.Cryptography;
using System.Text;
namespace freelance
{
    public static class hashing
    {
        public static string hash(string data)
        {
            StringBuilder hashed = new StringBuilder();
            byte[] inbytes = Encoding.ASCII.GetBytes(data);
            MD5 encryp = MD5.Create();
            byte[] res = encryp.ComputeHash(inbytes);
            foreach (var r in res)
            {
                hashed.Append(r.ToString("X2"));
            }
            return Convert.ToString(hashed)??String.Empty;
        }
    }
}

