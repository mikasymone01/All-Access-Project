using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace All_Access_Project
{
    public class BuildingItem
    {
        public string BuildingName { get; set; }
        public string BuildingDescription { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentHead { get; set; }
        public string DepartmentContact { get; set; }

        //public BuildingTemplate ReviewPage { get; set; }

        public BuildingItem(string BuildingName, string BuildingDescription, string DepartmentName, string DepartmentHead,
            string DepartmentContact)
        {
            this.BuildingName = BuildingName;
            this.BuildingDescription = BuildingDescription;
            this.DepartmentName = DepartmentName;
            this.DepartmentHead = DepartmentHead;
            this.DepartmentContact = DepartmentContact;
        }

    }
}
