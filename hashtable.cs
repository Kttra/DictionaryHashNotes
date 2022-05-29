using System;
using System.Collections; //needed for hashtable
/*	A Program showing the use of hashtables
	
	Why use hashtables?
	Near constant O(1) lookup times on massively scale collections.
*/

namespace HashTableProject
{
	//User struct
	struct UserInfo
	{
		public int userID;
		public string userName;
		public UserInfo(int id, string name)
		{
			userID = id;
			userName = name;
		}
	}
	public class Program
	{
		public static void Main()
		{
			Hashtable userInfoHash = new Hashtable();
			List<UserInfo> userInfoList = new();

			//Adding elements
			for (int i = 0; i < 10; i++)
			{
				//Key - User
				userInfoHash.Add(i, "user" + i);
				userInfoList.Add(new UserInfo(i, "user" + i));
			}



			//Removing element 0 from hashtable
			//First check if the key exists
			if (userInfoHash.ContainsKey(0))
			{
				userInfoHash.Remove(0); //Remove key 0
			}

			//Modifying a key
			if (userInfoHash.ContainsKey(1))
			{
				userInfoHash[1] = "newUser";
			}

			//Looping through hashtable
			foreach (DictionaryEntry entry in userInfoHash)
			{
				Console.WriteLine($"Key: {entry.Key} | Value: {entry.Value}");
			}
		}
	}
}
