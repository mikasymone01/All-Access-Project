using System;
using System.Collections.Generic;
using System.Text;

namespace All_Access_Project
{
    class BuildingItem
    {
        public string BuildingName { get; set; }
        public string BuildingDescription { get; set; }
        public string Department { get; set; }
        public string DepartmentHead { get; set; }
        public string DepartmentContact { get; set; }

        //public BuildingTemplate ReviewPage { get; set; }

        public BuildingItem(string BuildingName, string BuildingDescription, string Department, string DepartmentHead,
            string DepartmentContact)
        {
            this.BuildingName = BuildingName;
            this.BuildingDescription = BuildingDescription;
            this.Department = Department;
            this.DepartmentHead = DepartmentHead;
            this.DepartmentContact = DepartmentContact;
        }

    }
}
