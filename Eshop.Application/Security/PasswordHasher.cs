using System.Security.Cryptography;

namespace Eshop.Application.Security
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int Iterations = 100_000;

        public static (string Hash, string Salt) Hash(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, KeySize);
            return (Convert.ToBase64String(hash), Convert.ToBase64String(salt));
        }

        public static bool Verify(string password, string hashBase64, string saltBase64)
        {
            var salt = Convert.FromBase64String(saltBase64);
            var expectedHash = Convert.FromBase64String(hashBase64);
            var computedHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, expectedHash.Length);
            return CryptographicOperations.FixedTimeEquals(computedHash, expectedHash);
        }
    }
}
