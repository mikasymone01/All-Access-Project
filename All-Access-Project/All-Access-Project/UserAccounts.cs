using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace All_Access_Project
{
    public class UserAccounts
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
