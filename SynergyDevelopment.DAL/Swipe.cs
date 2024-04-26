using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SynergyDevelopment.DAL
{
    public class Swipe
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime Date { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
       
    }
}
