using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace CMT_2.BS
{
    public static class AesEncryptor
    {

        static AesEncryptor()
        {
            AesEncryptor.aes.BlockSize = 128;
        }


        public static byte[] GenerateIV()
        {
            AesEncryptor.aes.GenerateIV();
            return AesEncryptor.aes.IV;
        }


        public static byte[] Encrypt(byte[] buffer)
        {
            AesEncryptor.aes.GenerateIV();
            byte[] result;
            using (ICryptoTransform cryptoTransform = AesEncryptor.aes.CreateEncryptor())
            {
                byte[] second = cryptoTransform.TransformFinalBlock(buffer, 0, buffer.Length);
                result = AesEncryptor.aes.IV.Concat(second).ToArray<byte>();
            }
            return result;
        }


        public static byte[] Decrypt(byte[] buffer)
        {
            byte[] rgbIV = buffer.Take(16).ToArray<byte>();
            byte[] result;
            using (ICryptoTransform cryptoTransform = AesEncryptor.aes.CreateDecryptor(AesEncryptor.aes.Key, rgbIV))
            {
                result = cryptoTransform.TransformFinalBlock(buffer, 16, buffer.Length - 16);
            }
            return result;
        }


        public static byte[] EncryptIV(byte[] buffer, byte[] IV)
        {
            return AesEncryptor.EncryptKeyIV(buffer, AesEncryptor.aes.Key, IV);
        }


        public static byte[] DecryptIV(byte[] buffer, byte[] IV)
        {
            return AesEncryptor.DecryptKeyIV(buffer, AesEncryptor.aes.Key, IV);
        }


        public static byte[] EncryptKeyIV(byte[] buffer, byte[] key, byte[] IV)
        {
            byte[] result;
            using (ICryptoTransform cryptoTransform = AesEncryptor.aes.CreateEncryptor(key, IV))
            {
                result = cryptoTransform.TransformFinalBlock(buffer, 0, buffer.Length);
            }
            return result;
        }


        public static byte[] DecryptKeyIV(byte[] buffer, byte[] key, byte[] IV)
        {
            byte[] result;
            using (ICryptoTransform cryptoTransform = AesEncryptor.aes.CreateDecryptor(key, IV))
            {
                result = cryptoTransform.TransformFinalBlock(buffer, 0, buffer.Length);
            }
            return result;
        }


        public static string Encrypt(string unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(AesEncryptor.encoder.GetBytes(unencrypted)));
        }


        [Obsolete("Decrypt(string) has been made obsolete. Please use the DecryptString(string).")]
        public static string Decrypt(string encrypted)
        {
            return AesEncryptor.DecryptString(encrypted);
        }


        public static string DecryptString(string encrypted)
        {
            return AesEncryptor.DecryptString(Convert.FromBase64String(encrypted));
        }


        public static string DecryptString(byte[] encrypted)
        {
            byte[] array = AesEncryptor.Decrypt(encrypted);
            return AesEncryptor.encoder.GetString(array, 0, array.Length);
        }


        public static string EncryptIV(string unencrypted, byte[] vector)
        {
            return Convert.ToBase64String(AesEncryptor.EncryptIV(AesEncryptor.encoder.GetBytes(unencrypted), vector));
        }


        public static string DecryptIV(string encrypted, byte[] vector)
        {
            byte[] array = AesEncryptor.DecryptIV(Convert.FromBase64String(encrypted), vector);
            return AesEncryptor.encoder.GetString(array, 0, array.Length);
        }


        public static string Encrypt(bool unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static bool DecryptBool(string encrypted)
        {
            return AesEncryptor.DecryptBool(Convert.FromBase64String(encrypted));
        }


        public static bool DecryptBool(byte[] encrypted)
        {
            return BitConverter.ToBoolean(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(char unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static char DecryptChar(string encrypted)
        {
            return AesEncryptor.DecryptChar(Convert.FromBase64String(encrypted));
        }


        public static char DecryptChar(byte[] encrypted)
        {
            return BitConverter.ToChar(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(double unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static double DecryptDouble(string encrypted)
        {
            return AesEncryptor.DecryptDouble(Convert.FromBase64String(encrypted));
        }


        public static double DecryptDouble(byte[] encrypted)
        {
            return BitConverter.ToDouble(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(float unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static float DecryptFloat(string encrypted)
        {
            return AesEncryptor.DecryptFloat(Convert.FromBase64String(encrypted));
        }


        public static float DecryptFloat(byte[] encrypted)
        {
            return BitConverter.ToSingle(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(int unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static int DecryptInt(string encrypted)
        {
            return AesEncryptor.DecryptInt(Convert.FromBase64String(encrypted));
        }


        public static int DecryptInt(byte[] encrypted)
        {
            return BitConverter.ToInt32(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(long unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static long DecryptLong(string encrypted)
        {
            return AesEncryptor.DecryptLong(Convert.FromBase64String(encrypted));
        }


        public static long DecryptLong(byte[] encrypted)
        {
            return BitConverter.ToInt64(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(short unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static short DecryptShort(string encrypted)
        {
            return AesEncryptor.DecryptShort(Convert.FromBase64String(encrypted));
        }


        public static short DecryptShort(byte[] encrypted)
        {
            return BitConverter.ToInt16(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(uint unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static uint DecryptUInt(string encrypted)
        {
            return AesEncryptor.DecryptUInt(Convert.FromBase64String(encrypted));
        }


        public static uint DecryptUInt(byte[] encrypted)
        {
            return BitConverter.ToUInt32(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(ulong unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static ulong DecryptULong(string encrypted)
        {
            return AesEncryptor.DecryptULong(Convert.FromBase64String(encrypted));
        }


        public static ulong DecryptULong(byte[] encrypted)
        {
            return BitConverter.ToUInt64(AesEncryptor.Decrypt(encrypted), 0);
        }


        public static string Encrypt(ushort unencrypted)
        {
            return Convert.ToBase64String(AesEncryptor.Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public static ushort DecryptUShort(string encrypted)
        {
            return AesEncryptor.DecryptUShort(Convert.FromBase64String(encrypted));
        }


        public static ushort DecryptUShort(byte[] encrypted)
        {
            return BitConverter.ToUInt16(AesEncryptor.Decrypt(encrypted), 0);
        }


        private const int keySize = 16;


        private const string keyString = "defaultKeyString";


        private const int IvLength = 16;


        private static UTF8Encoding encoder = new UTF8Encoding();


        private static AesManaged aes = new AesManaged
        {
            Key = AesEncryptor.encoder.GetBytes("testKey").Take(16).ToArray<byte>()
        };
    }

}
