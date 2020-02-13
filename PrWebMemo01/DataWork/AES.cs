using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using PasswordHelperForm01.DataSettings;

namespace PasswordHelperForm01
{
	class AES
	{
		public static string Encrypt(string src, string key)
		{
			byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
			while (keyArray.Length < 16)     // 128, 192, 256 bit = 16, 24, 32 bytes length
			{
				key += " ";
				keyArray = UTF8Encoding.UTF8.GetBytes(key);
			}
			byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(src);
			RijndaelManaged rDel = new RijndaelManaged();
			rDel.Key = keyArray;
			rDel.Mode = CipherMode.ECB;
			rDel.Padding = PaddingMode.PKCS7;
			ICryptoTransform cTransform = rDel.CreateEncryptor();
			byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

			return Convert.ToBase64String(resultArray, 0, resultArray.Length);
		}

		public static string Decrypt(string src, string key)
		{
			byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
			while (keyArray.Length < 16)
			{
				key += " ";
				keyArray = UTF8Encoding.UTF8.GetBytes(key);
			}
			byte[] toDecryptArray = Convert.FromBase64String(src);
			RijndaelManaged rDel = new RijndaelManaged();
			rDel.Key = keyArray;
			rDel.Mode = CipherMode.ECB;
			rDel.Padding = PaddingMode.PKCS7;
			ICryptoTransform cTransform = rDel.CreateDecryptor();
			byte[] resultArray = cTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);

			return UTF8Encoding.UTF8.GetString(resultArray);
		}
	}
}
