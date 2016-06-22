using System;

namespace easypost
{
	public class KeyGenerator
	{
		public KeyGenerator ()
		{
		}

		public KeySet Generate()
		{
			var keys = new KeySet ();
			//keys.DeviceId = GenerateKey (); // TODO: Remove if not needed
			keys.SecurityKey = GenerateKey ();
			keys.FolderId = GenerateKey ();

			return keys;
		}

		string GenerateKey()
		{
			var key = "";
			using (var e = System.Security.Cryptography.RijndaelManaged.Create())
			{
				e.GenerateKey();
				key = Convert.ToBase64String(e.Key).Replace("/", "").Replace("+", "").Trim('=').Trim('-');
			}
			return key.Substring(0, 10);
		}
	}
}

