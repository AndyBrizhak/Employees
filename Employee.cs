using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Брижак Андрей Домашнее задание по курсу C# уровень 2 урок 2
namespace Employees 
{
    abstract partial class Employee : IComparable
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;



        #region Nested type
        #endregion

        #region Constructors
        public Employee() { }
        public Employee( string name, int id, float pay )
            : this(name, 0, id, pay, "") { }

        public Employee( string name, int age, int id, float pay, string ssn )
        {
            // Better!  Use properties when setting class data.
            // This reduces the amount of duplicate error checks.
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            SocialSecurityNumber = ssn;
        }
        #endregion
    }
}
