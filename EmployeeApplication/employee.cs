using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class employee
    {
        //setter and getter
        public string EmployeeID {  get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public String Position { get; set; }

        //setter
        public employee(string emID, string fn, string sn, string pt) {

            EmployeeID = emID;
            FirstName = fn;
            Surname = sn;
            Position = pt;
        }
    }

}
