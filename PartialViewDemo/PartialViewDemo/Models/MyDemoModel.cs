using System.Collections.Generic;

namespace PartialViewDemo.Models
{
    /// <summary>
    /// model class 
    /// </summary>
    public class Department
    {
        public string DepartmentName { get; set; }
        public string DepartmentRule { get; set; }
        public string AdminComment { get; set; }
    }

    public class Company
    {
        public List<Department>  Department { get; set; }
    }
}