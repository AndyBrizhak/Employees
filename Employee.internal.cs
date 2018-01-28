﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Брижак Андрей Домашнее задание по курсу C# уровень 2 урок 2
namespace Employees
{
    partial class Employee : IComparable
    {
        #region Methods
        public virtual void GiveBonus( float amount )
        {
            currPay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }

        int IComparable.CompareTo(object obj)
        {
            Employee temp = obj as Employee;
            if (temp != null)
                return this.ID.CompareTo(temp.ID);
            else
                // Параметр не является объектом типа Employee!
                throw new ArgumentException("Parameter is not а Employee!");
        }


        #endregion

        #region Get / Set Method
        // Accessor (get method)
        public string GetName()
        {
            return empName;
        }

        // Mutator (set method)
        public void SetName( string name )
        {
            // Do a check on incoming value
            // before making assignment.
            if (name.Length > 15)
                Console.WriteLine("Error!  Name must be less than 15 characters!");
            else
                empName = name;
        }
        #endregion

        #region Properties
        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }

        // We could add additional business rules to the sets of these properties,
        // however there is no need to do so for this example.
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
            set { empSSN = value; }
        }
        #endregion
    }
}