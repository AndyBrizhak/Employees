using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Брижак Андрей Домашнее задание по курсу C# уровень 2 урок 2
namespace Employees
{
    // Salespeople need to know their number of sales.
    class FixedEmployee : Employee
    {
        public int Fixed { get; set; }

        #region Contructors 
        // As a general rule, all subclasses should explicitly call an appropriate
        // base class constructor.
        public FixedEmployee( string fullName, int age, int empID,
          float currPay, string ssn, int FixedMonth )
            : base(fullName, age, empID, currPay, ssn)
        {
            // This belongs with us!
            Fixed = FixedMonth;
        }

        public FixedEmployee() { }
        #endregion

        #region Methods
        public override sealed void GiveBonus( float amount )
        {
            base.GiveBonus(Fixed + amount);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Fixed: {0}", Fixed);
        }
        #endregion

    }
}
