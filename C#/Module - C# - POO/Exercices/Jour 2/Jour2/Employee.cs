using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour2
{

    class Employee
    {
        public struct StructEmployee
        {
            public String Name;
            public int Age;
        }

        private String Nom;
        private int Age;

        public Employee(Employee Employee)
        {
            this.Nom = Employee.Nom;
            this.Age = Employee.Age;
        }
    }
}
