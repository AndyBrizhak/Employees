using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Брижак Андрей Домашнее задание по курсу C# уровень 2 урок 2
namespace Employees
{
    // Managers need to know their number of stock options.
    class TimeEmployee : Employee
    {
        public int TimePayment { get; set; }

        public TimeEmployee( string fullName, int age, int empID,
                       float currPay, string ssn, int hourlyRate )
            : base(fullName, age, empID, currPay, ssn)
        {
            // This property is defined by the TimeEmployee class.
            TimePayment = (int)(20.8 * 8 * hourlyRate);    //«среднемесячная заработная
                                         //плата = 20.8 * 8 * почасовую ставку»
        }

        public TimeEmployee(){}

        public override void GiveBonus( float amount)  //метод для расчёта среднемесячной заработной платы c бонусом

        {
            base.GiveBonus(amount + TimePayment);
           
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("TimePayment: {0}", TimePayment);
        }

    }
}
