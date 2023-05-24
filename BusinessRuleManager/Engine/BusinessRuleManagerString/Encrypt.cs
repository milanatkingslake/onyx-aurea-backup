// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Encrypt a string value.
	/// </summary>
	public class Encrypt
		: GrammarBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Get value, key, vector, convert to bytes
			XmlNode childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);
			byte[] value = new ASCIIEncoding().GetBytes(StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager));

			childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:key", this.namespaceManager);
			byte[] key = new ASCIIEncoding().GetBytes(StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager));

			childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:vector", this.namespaceManager);
			byte[] vector = new ASCIIEncoding().GetBytes(StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager));

			// Use the Rijndael provider
			RijndaelManaged provider = new RijndaelManaged();
			provider.Key = key;
			provider.BlockSize = vector.Length * 8;
			provider.IV = vector;

			// Set up the stream that will hold the encrypted data
			MemoryStream encryptedStream = new MemoryStream();

			// Create the crypto stream to encrypt the data
			CryptoStream cryptoStream = new CryptoStream(encryptedStream, provider.CreateEncryptor(), CryptoStreamMode.Write);

			// Encrypt the data, write it to the memory stream.
			cryptoStream.Write(value, 0, value.Length);
			cryptoStream.FlushFinalBlock();
			cryptoStream.Close();

			// Clear the encryption provider
			provider.Clear();

			// Use Base64 encoding for encrypted string
			return Convert.ToBase64String(encryptedStream.ToArray());
		}
		#endregion
	}
}
