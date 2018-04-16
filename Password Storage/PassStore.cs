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
		private List<PassStoreAccount> accountList;	
		
		
			
		public PassStore(string dataPath, string password) {
			this.password = password;
			this.dataPath = dataPath;
			UpdateAccounts(); // part of initialization
		}
		
		public List<PassStoreAccount> GetAccounts() {
			return accountList;
		}
		
		public void UpdateAccounts() {
			accountList = new List<PassStoreAccount>();
			string data = GetData();
			if (string.IsNullOrEmpty(data)) return;
			// split by line break
			string[] lines = data.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string line in lines) {
				if (string.IsNullOrWhiteSpace(line)) continue;
				string[] accountData = line.Split(new[] { splitter }, StringSplitOptions.None);
				PassStoreAccount account = new PassStoreAccount(accountData[0], accountData[1], accountData[2]);
				accountList.Add(account);
			}
		}
		
		public void AddAccount(string description, string username, string password) {
			PassStoreAccount account = new PassStoreAccount(description, username, password);
			accountList.Insert(0, account);
			SaveData();
		}
		
		public void DeleteAccount(PassStoreAccount account) {
			accountList.Remove(account);
			SaveData();
		}
		
		// get data from datapath and decrypt it
		public string GetData() {
			try {
				string encryptedData = File.ReadAllText(dataPath);
				string data = encryptedData.DecryptString(password);
				return data;
			} catch (Exception) {
				return string.Empty;
			}
		}
		
		public void SaveData() {
			if (!File.Exists(dataPath)) 
				File.Create(dataPath);
			string data = string.Empty;
			foreach (PassStoreAccount account in accountList) {
				string line = account.GetDescription() + splitter + account.GetUsername() + splitter + account.GetPassword();
				data += line + Environment.NewLine;
			}
			data = data.EncryptString(password);
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
