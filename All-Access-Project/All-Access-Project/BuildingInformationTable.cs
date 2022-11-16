using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace All_Access_Project
{
    public class BuildingInformationTable
    {
        [PrimaryKey, AutoIncrement]
        public string BuildingName { get; set; }
        public string BuildingDescription { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentHead { get; set; }
        public string DepartmentContact { get; set; }

    }
}
