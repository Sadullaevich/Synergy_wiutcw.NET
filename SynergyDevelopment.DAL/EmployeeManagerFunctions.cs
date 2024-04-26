using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergyDevelopment.DAL
{
    public partial class EmployeeManager
    {
        //sort by Name, inactive,active employees and all employees
        public List<Employee> Sort(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAll().OrderBy(a => a.Name).ToList();
                case ByAttribute.All:
                    var alllist = from a in GetAll() select a;
                    return alllist.ToList();
                case ByAttribute.InActive:
                    var inactivelist = from a in GetAll() where a.IsActive == false select a;
                    return inactivelist.ToList();
                case ByAttribute.Active:
                    var activelist = from a in GetAll() where a.IsActive == true select a;
                    return activelist.ToList();
            }

            return null;
        }
        //search by name
        public List<Employee> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    var result = from a in GetAll() where a.Name.ToUpper().Contains(value.ToUpper()) select a;
                    return result.ToList();
            }

            return null;
        }
    }
}
