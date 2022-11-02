using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;


namespace All_Access_Project
{
    internal class SQLliteHelper
    {
        private readonly SQLiteAsyncConnection db;
        public SQLliteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<UserAccounts>();
        }

        public Task<int> CreateAccount(UserAccounts account)
        {
            return db.InsertAsync(account);
        }

        public Task<List<UserAccounts>>ReadAccounts()
        {
            return db.Table<UserAccounts>().ToListAsync();
        }

        public Task<int> UpdateAccount(UserAccounts accounts)
        {
            return db.UpdateAsync(accounts);
        }

        public Task<int> DeleteAccount(UserAccounts account)
        {
            return db.DeleteAsync(account);
        }
    }
    
}
