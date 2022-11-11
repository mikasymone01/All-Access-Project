using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace All_Access_Project
{
    public class BuildingInformationTable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Buildingname { get; set; }
        public string Department { get; set; }
        public string DepartmentHead { get; set; }
        public int departmentHeadNumber { get; set; }
        public int buildingRating { get; set; }

    }
}
