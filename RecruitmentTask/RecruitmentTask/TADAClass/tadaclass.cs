using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RecruitmentTask.TADAClass
{
    class tadaclass
    {
        public string Date { get; set; }
        public string EmployeeName { get; set; }
        public int TravelCost { get; set; }
        public int LunchCost { get; set; }
        public int InstrumentCost { get; set; }
        public int TotalCost { get; set; }
        public string Paid { get; set; }

        static string myconnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
    }
}
