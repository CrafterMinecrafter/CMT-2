using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace CMT_2.BS
{
    public class AesEncryptor
    {

        AesEncryptor()
        {
            aes.BlockSize = 128;
        }


        public byte[] GenerateIV()
        {
            aes.GenerateIV();
            return aes.IV;
        }


        public byte[] Encrypt(byte[] buffer)
        {
            aes.GenerateIV();
            byte[] result;
            using (ICryptoTransform cryptoTransform = aes.CreateEncryptor())
            {
                byte[] second = cryptoTransform.TransformFinalBlock(buffer, 0, buffer.Length);
                result = aes.IV.Concat(second).ToArray<byte>();
            }
            return result;
        }


        public byte[] Decrypt(byte[] buffer)
        {
            byte[] rgbIV = buffer.Take(16).ToArray<byte>();
            byte[] result;
            using (ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, rgbIV))
            {
                result = cryptoTransform.TransformFinalBlock(buffer, 16, buffer.Length - 16);
            }
            return result;
        }


        public byte[] EncryptIV(byte[] buffer, byte[] IV)
        {
            return EncryptKeyIV(buffer, aes.Key, IV);
        }


        public byte[] DecryptIV(byte[] buffer, byte[] IV)
        {
            return DecryptKeyIV(buffer, aes.Key, IV);
        }


        public byte[] EncryptKeyIV(byte[] buffer, byte[] key, byte[] IV)
        {
            byte[] result;
            using (ICryptoTransform cryptoTransform = aes.CreateEncryptor(key, IV))
            {
                result = cryptoTransform.TransformFinalBlock(buffer, 0, buffer.Length);
            }
            return result;
        }


        public byte[] DecryptKeyIV(byte[] buffer, byte[] key, byte[] IV)
        {
            byte[] result;
            using (ICryptoTransform cryptoTransform = aes.CreateDecryptor(key, IV))
            {
                result = cryptoTransform.TransformFinalBlock(buffer, 0, buffer.Length);
            }
            return result;
        }


        public string Encrypt(string unencrypted)
        {
            return Convert.ToBase64String(Encrypt(encoder.GetBytes(unencrypted)));
        }


        [Obsolete("Decrypt(string) has been made obsolete. Please use the DecryptString(string).")]
        public string Decrypt(string encrypted)
        {
            return DecryptString(encrypted);
        }


        public string DecryptString(string encrypted)
        {
            return DecryptString(Convert.FromBase64String(encrypted));
        }


        public string DecryptString(byte[] encrypted)
        {
            byte[] array = Decrypt(encrypted);
            return encoder.GetString(array, 0, array.Length);
        }


        public string EncryptIV(string unencrypted, byte[] vector)
        {
            return Convert.ToBase64String(EncryptIV(encoder.GetBytes(unencrypted), vector));
        }


        public string DecryptIV(string encrypted, byte[] vector)
        {
            byte[] array = DecryptIV(Convert.FromBase64String(encrypted), vector);
            return encoder.GetString(array, 0, array.Length);
        }


        public string Encrypt(bool unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public bool DecryptBool(string encrypted)
        {
            return DecryptBool(Convert.FromBase64String(encrypted));
        }


        public bool DecryptBool(byte[] encrypted)
        {
            return BitConverter.ToBoolean(Decrypt(encrypted), 0);
        }


        public string Encrypt(char unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public char DecryptChar(string encrypted)
        {
            return DecryptChar(Convert.FromBase64String(encrypted));
        }


        public char DecryptChar(byte[] encrypted)
        {
            return BitConverter.ToChar(Decrypt(encrypted), 0);
        }


        public string Encrypt(double unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public double DecryptDouble(string encrypted)
        {
            return DecryptDouble(Convert.FromBase64String(encrypted));
        }


        public double DecryptDouble(byte[] encrypted)
        {
            return BitConverter.ToDouble(Decrypt(encrypted), 0);
        }


        public string Encrypt(float unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public float DecryptFloat(string encrypted)
        {
            return DecryptFloat(Convert.FromBase64String(encrypted));
        }


        public float DecryptFloat(byte[] encrypted)
        {
            return BitConverter.ToSingle(Decrypt(encrypted), 0);
        }


        public string Encrypt(int unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public int DecryptInt(string encrypted)
        {
            return DecryptInt(Convert.FromBase64String(encrypted));
        }


        public int DecryptInt(byte[] encrypted)
        {
            return BitConverter.ToInt32(Decrypt(encrypted), 0);
        }


        public string Encrypt(long unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public long DecryptLong(string encrypted)
        {
            return DecryptLong(Convert.FromBase64String(encrypted));
        }


        public long DecryptLong(byte[] encrypted)
        {
            return BitConverter.ToInt64(Decrypt(encrypted), 0);
        }


        public string Encrypt(short unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public short DecryptShort(string encrypted)
        {
            return DecryptShort(Convert.FromBase64String(encrypted));
        }


        public short DecryptShort(byte[] encrypted)
        {
            return BitConverter.ToInt16(Decrypt(encrypted), 0);
        }


        public string Encrypt(uint unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public uint DecryptUInt(string encrypted)
        {
            return DecryptUInt(Convert.FromBase64String(encrypted));
        }


        public uint DecryptUInt(byte[] encrypted)
        {
            return BitConverter.ToUInt32(Decrypt(encrypted), 0);
        }


        public string Encrypt(ulong unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public ulong DecryptULong(string encrypted)
        {
            return DecryptULong(Convert.FromBase64String(encrypted));
        }


        public ulong DecryptULong(byte[] encrypted)
        {
            return BitConverter.ToUInt64(Decrypt(encrypted), 0);
        }


        public string Encrypt(ushort unencrypted)
        {
            return Convert.ToBase64String(Encrypt(BitConverter.GetBytes(unencrypted)));
        }


        public ushort DecryptUShort(string encrypted)
        {
            return DecryptUShort(Convert.FromBase64String(encrypted));
        }


        public ushort DecryptUShort(byte[] encrypted)
        {
            return BitConverter.ToUInt16(Decrypt(encrypted), 0);
        }


        private const int keySize = 16;


        private const string keyString = "defaultKeyString";


        private const int IvLength = 16;


        private static UTF8Encoding encoder = new UTF8Encoding();


        private AesManaged aes = new AesManaged
        {
            Key = encoder.GetBytes("defaultKeyString").Take(16).ToArray<byte>()
        };
    }

}
