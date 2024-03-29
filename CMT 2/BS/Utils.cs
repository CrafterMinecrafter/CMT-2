﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CMT_2.BS
{

    public static class Utils
    {
        #region BASE64
        public static string ToBase64(string Text)
        {
            return Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(Text));
        }
        public static string FromBase64(string Text)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(Text));
        }
        public static byte[] FromBase64File(string Path)
        {
            return Convert.FromBase64String(File.ReadAllText(Path));
        }
        public static string ToBase64File(string Path)
        {
            return Convert.ToBase64String(File.ReadAllBytes(Path));
        }
        #endregion
        #region Hashes
        public static string AllHashes(string text, string HashName)
        {
            UTF8Encoding utf8Encoding = new UTF8Encoding();
            byte[] bytes = utf8Encoding.GetBytes(text);
            var alg = HashAlgorithm.Create(HashName);
            byte[] HashBytes = alg.ComputeHash(bytes);
            string StringOutput = string.Empty;
            for (int a = 0, b = HashBytes.Length; a < b;)
            {
                StringOutput += Convert.ToString(HashBytes[a], 16).PadLeft(2, '0');
                a++;
            }
            return StringOutput.PadLeft(32, '0');
        }

        public static string AllHashesFile(string FilePath, string HashName)
        {
            byte[] bytes = File.ReadAllBytes(FilePath);
            var alg = HashAlgorithm.Create(HashName);
            byte[] HashBytes = alg.ComputeHash(bytes);
            string StringOutput = string.Empty;
            for (int a = 0, b = HashBytes.Length; a < b;)
            {
                StringOutput += Convert.ToString(HashBytes[a], 16).PadLeft(2, '0');
                a++;
            }
            return StringOutput.PadLeft(32, '0');
        }

        public static string MD5(string text)
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
        public static string MD5File(string FilePath)
        {
            byte[] array = MD5FileV(FilePath);
            string text2 = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                text2 += Convert.ToString(array[i], 16).PadLeft(2, '0');
            }
            return text2.PadLeft(32, '0');
        }
        public static byte[] MD5FileV(string FilePath)
        {
            byte[] bytes;
            try
            {
                bytes = File.ReadAllBytes(FilePath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                bytes = new byte[16];
            }
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            return md5CryptoServiceProvider.ComputeHash(bytes);

        }
        #endregion
        #region XOR
        public static string XOR(string text, string key, bool encrypt)
        {
            if (encrypt)
            {
                return Convert.ToBase64String(XOREncryptDecrypt(Encoding.UTF8.GetBytes(text), Encoding.UTF8.GetBytes(key)));
            }
            return Encoding.UTF8.GetString(XOREncryptDecrypt(Convert.FromBase64String(text), Encoding.UTF8.GetBytes(key)));
        }
        public static string XORascii(string text, string key, bool encrypt)
        {
            if (encrypt)
            {
                return Convert.ToBase64String(XOREncryptDecrypt(Encoding.ASCII.GetBytes(text), Encoding.ASCII.GetBytes(key)));
            }
            return Encoding.UTF8.GetString(XOREncryptDecrypt(Convert.FromBase64String(text), Encoding.ASCII.GetBytes(key)));
        }
        public static string XORv(string text, string key)
        {
            //if (encrypt)
            //{
            return BytesToString(XOREncryptDecrypt(Encoding.ASCII.GetBytes(text), Encoding.ASCII.GetBytes(key)));
            //}
            //return StringBytesToString(XOREncryptDecrypt(Convert.FromBase64String(text), Encoding.UTF8.GetBytes(key)));
        }
        public static string XORFile(string FilePath, string key, bool encrypt)
        {
            if (encrypt)
            {
                return Convert.ToBase64String(XOREncryptDecrypt(File.ReadAllBytes(FilePath), Encoding.UTF8.GetBytes(key)));
            }
            return Encoding.UTF8.GetString(XOREncryptDecrypt(Convert.FromBase64String(File.ReadAllText(FilePath)), Encoding.UTF8.GetBytes(key)));
        }


        private static byte[] XOREncryptDecrypt(byte[] data, byte[] key)
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
                num3 = (num3 + array[j] + key[j % key.Length]) % 256;
                byte b = array[j];
                array[j] = array[num3];
                array[num3] = b;
            }
            byte[] array2 = new byte[data.Length];
            for (int k = 0; k < data.Length; k++)
            {
                num = (num + 1) % 256;
                num2 = (num2 + array[num]) % 256;
                byte b = array[num];
                array[num] = array[num2];
                array[num2] = b;
                array2[k] = (byte)(data[k] ^ array[(array[num] + array[num2]) % 256]);
            }
            return array2;
        }
        #endregion
        #region Other Tools
        public static string FileToCodeArray(string Path)
        {
            return ByteArrayToCodeArray(File.ReadAllBytes(Path));
        }
        public static string ByteArrayToCodeArray(byte[] array)
        {
            string buffer = "{";
            for (int a = 0, b = array.Length; a < b;)
            {
                buffer += "0x" + Convert.ToString(array[a], 16).PadLeft(2, '0') + ',';
                a++;
            }
            return buffer.Substring(0, buffer.Length - 1).ToUpper().Replace('X', 'x') + '}';
        }
        public static string BytesToString(byte[] array)
        {
            string buffer = "";
            for (int a = 0, b = array.Length; a < b;)
            {
                buffer += Convert.ToString(array[a], 16).PadLeft(2, '0');
                a++;
            }
            return buffer.Substring(0, buffer.Length - 1);
        }

        public static string StringBytesToString(string array)
        {
            string buffer = "";
            for (int a = 0, b = array.Length; a < b;)
            {
                buffer += char.ConvertFromUtf32(Convert.ToInt32(array[a].ToString() + array[a + 1], 16));
                a += 2;
            }
            return buffer.Substring(0, buffer.Length - 1);
        }

        #endregion
    }

}
