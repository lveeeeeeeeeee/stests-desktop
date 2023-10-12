namespace Stests.LoginLogic
{
    using System.Security.Cryptography;
    using System.Text;

    public static class LoginHelper
    {
        public static string ConvertPasswordToHash(string password)
        {
            // Convert password to byte array. 
            byte[] passwordByteArray = password.ToCharArray()
            .Select(x => (byte)x)
            .ToArray();
            // Encode the password with SHA-256 algorythm.
            string passwordHash = "";
            using (SHA256 cypherSHA256 = SHA256.Create())
            {
                byte[] hashValue = cypherSHA256.ComputeHash(passwordByteArray);
                passwordHash = Encoding.Default.GetString(hashValue);
            }

            return password;
        }
    }
}
