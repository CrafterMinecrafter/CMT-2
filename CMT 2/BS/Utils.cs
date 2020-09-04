using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace CMT_2.BS
{

    public class Utils
    {
        #region MD5
        public string MD5(string text)
        {
            UTF8Encoding utf8Encoding = new UTF8Encoding();
            byte[] bytes = utf8Encoding.GetBytes(text);
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] array = md5CryptoServiceProvider.ComputeHash(bytes);
            string text2 = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                text2 += Convert.ToString(array[i], 16).PadLeft(2, '0');
            }
            return text2.PadLeft(32, '0');
          
        }
        public string MD5File(string FilePath)
        {
            byte[] bytes = File.ReadAllBytes(FilePath);
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] array = md5CryptoServiceProvider.ComputeHash(bytes);
            string text2 = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                text2 += Convert.ToString(array[i], 16).PadLeft(2, '0');
            }
            return text2.PadLeft(32, '0');
        }
  #endregion
        #region XOR
        public string XOR(string text, string key, bool encrypt)
        {
            if (encrypt)
            {
                return Convert.ToBase64String(EncryptDecrypt(Encoding.UTF8.GetBytes(text), Encoding.UTF8.GetBytes(key)));
            }
            return Encoding.UTF8.GetString(EncryptDecrypt(Convert.FromBase64String(text), Encoding.UTF8.GetBytes(key)));
        }
        public string XORFile(string FilePath, string key, bool encrypt)
        {
            if (encrypt)
            {
                return Convert.ToBase64String(EncryptDecrypt(File.ReadAllBytes(FilePath), Encoding.UTF8.GetBytes(key)));
            }
            return Encoding.UTF8.GetString(EncryptDecrypt(Convert.FromBase64String(File.ReadAllText(FilePath)), Encoding.UTF8.GetBytes(key)));
        }


        private byte[] EncryptDecrypt(byte[] data, byte[] key)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            byte[] array = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                array[i] = (byte)i;
            }
            for (int j = 0; j < 256; j++)
            {
                num3 = (num3 + (int)array[j] + (int)key[j % key.Length]) % 256;
                byte b = array[j];
                array[j] = array[num3];
                array[num3] = b;
            }
            byte[] array2 = new byte[data.Length];
            for (int k = 0; k < data.Length; k++)
            {
                num = (num + 1) % 256;
                num2 = (num2 + (int)array[num]) % 256;
                byte b = array[num];
                array[num] = array[num2];
                array[num2] = b;
                array2[k] = (byte)(data[k] ^ array[(int)(array[num] + array[num2]) % 256]);
            }
            return array2;
        }
        #endregion
    }

}
