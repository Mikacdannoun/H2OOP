using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesV10
{
    public class Employee
    {
        #region Properties
        public string? _Name { get; set; }
        public int _HoursPerWeek { get; set; }
        public string? _Profession { get; set; }

        public void _PrintInformation(string _Profession, string _Name, int _HoursPerWeek)
        {
            Console.WriteLine("Print Employee Information");
        }

        #endregion

        public Employee(string _Profession, string _Name, int _HoursPerWeek) {
            _PrintInformation(_Profession, _Name, _HoursPerWeek);

        }

        public Employee()
        {
        }
    }
}
