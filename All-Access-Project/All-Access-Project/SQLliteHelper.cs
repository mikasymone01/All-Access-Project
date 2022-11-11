using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;


namespace All_Access_Project
{
    public class SQLliteHelper
    {
        private readonly SQLiteAsyncConnection db;
        public SQLliteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<UserAccounts>();
            db.CreateTableAsync<BuildingInformationTable>();
        }

        public Task<int> CreateAccount(UserAccounts account)
        {
            return db.InsertAsync(account);
        }

        public Task<int> CreateBuilding(BuildingInformationTable building)
        {
            return db.InsertAsync(building);
        }

        public Task<List<UserAccounts>>ReadAccounts()
        {
            return db.Table<UserAccounts>().ToListAsync();
        }

        public Task<List<BuildingInformationTable>>ReadBuildings()
        {
            return db.Table<BuildingInformationTable>().ToListAsync();
        }

        public Task<int> UpdateAccount(UserAccounts accounts)
        {
            return db.UpdateAsync(accounts);
        }

        public Task<int> UpdateBuilding(BuildingInformationTable building)
        {
            return db.UpdateAsync(building);
        }

        public Task<int> DeleteAccount(UserAccounts account)
        {
            return db.DeleteAsync(account);
        }

        public Task<int> DeleteBuilding(BuildingInformationTable building)
        {
            return db.DeleteAsync(building);
        }
    }
    
}

/*To use the database go to the page where you want to use the database. Then have to create a protected function
 * use this under the initialize component method
 * protected overide async void OnAppearing()
 * {
 * try
 * {
 *  base.OnAppearing();
 *  myCollectionView.ItemSource = await App.All_Access_Database.ReadAccounts(); This will return a list of things thats in the database
 *  }
 *  catch
 *  {}
 */  
