using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Security.Cryptography;


namespace utils
{
	public class Base64Compressor
	{
		public static string Base64Encode(string plainText) {
			byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
			return System.Convert.ToBase64String(plainTextBytes);
		}
		public static string Base64Decode(string base64EncodedData) {
			byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
			return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
		}
		
		public static string GetMd5Hash(string input)
		{
			MD5 m = MD5.Create();
			// Convert the input string to a byte array and compute the hash. 
			byte[] data = m.ComputeHash(Encoding.UTF8.GetBytes(input));
			
			// Create a new Stringbuilder to collect the bytes 
			// and create a string.
			StringBuilder sBuilder = new StringBuilder();
			
			// Loop through each byte of the hashed data  
			// and format each one as a hexadecimal string. 
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}
			
			// Return the hexadecimal string. 
			return sBuilder.ToString();
		}
		
	}
}

