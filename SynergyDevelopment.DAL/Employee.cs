using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergyDevelopment.DAL
{
    public class Employee
    {
        private string name;

        public int Id { get; set; }
        //Name validating
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name can not be empty!");
                name = value;
            }
        }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
