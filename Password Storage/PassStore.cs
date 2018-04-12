/*
User: jusgarofolo
Date: 4/12/2018
Time: 7:34 AM
*/
using System;
using System.Collections.Generic;
using System.IO;

namespace Password_Storage
{
	/// <summary>
	/// Description of PassStore.
	/// </summary>
	public class PassStore {
		
		private const string splitter = ":::";
		private string password;
		private string dataPath;
		List<PassStoreAccount> accountList;	
		
		
			
		public PassStore(string dataPath, string password) {
			this.password = password;
			this.dataPath = dataPath;
			UpdateAccounts(); // part of initialization
		}
		
		public void UpdateAccounts() {
			accountList = new List<PassStoreAccount>();
			string data = GetData();
			// split by line break
			string[] lines = data.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in lines) {
				string[] accountData = line.Split(new[] { splitter });
				PassStoreAccount account = new PassStoreAccount(accountData[0], accountData[1], accountData[2]);
				accountList.Add(account);
			}
		}
		
		public void AddAccount(string description, string username, string password) {
			PassStoreAccount account = new PassStoreAccount(description, username, password);
			accountList.Add(accountList);
		}
		
		// get data from datapath and decrypt it
		public string GetData() {
			if (!File.Exists(dataPath)) return string.Empty;
			string encryptedData = File.ReadAllText(dataPath);
			string data = encryptedData.DecryptString(password);
			return data;
		}
		
		public void SaveData() {
			if (!File.Exists(dataPath)) 
				File.Create(dataPath);
			string data;
			foreach (PassStoreAccount account in accountList) {
				string description = account.GetDescription();
				string username = account.GetUsername();
				string password = account.GetPassword();
				string line = description + splitter + username + splitter + password;
				data += line + Environment.NewLine;
			}
			File.WriteAllText(dataPath, data);
		}
		
	}
	
	public class PassStoreAccount {
		
		private string description;
		private string username;
		private string password;
		
		public PassStoreAccount(string description, string username, string password) {
			this.description = description;
			this.username = username;
			this.password = password;
		}
		
		public string GetDescription() { return description; }
		public string GetUsername() { return username; }
		public string GetPassword() { return password; }
		
	}
	
}
