using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Брижак Андрей Домашнее задание по курсу C# уровень 2 урок 2
namespace Employees
{
    class Program 
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            // Give each employee a bonus?
            TimeEmployee chucky = new TimeEmployee("Chucky", 50, 92, 100000, "333-23-2322", 9);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            FixedEmployee fran = new FixedEmployee("Fran", 43, 93, 3000, "932-32-3232", 6010);
            fran.GiveBonus(200);
            fran.DisplayStats();

            Console.WriteLine();
            CastingExamples();

            //Создать на базе абстрактного класса массив сотрудников и заполнить его.
            Employee[] Workers =
            { new TimeEmployee("Frank Zappa", 19, 300, 40000, "111-11-1111", 5),
              new TimeEmployee("MoonUnit Zappa", 22, 301, 20000, "101-11-1321", 6),
              new FixedEmployee("Jill", 34, 308, 100000, "111-12-1119", 800),
              new TimeEmployee("Chucky", 50, 92, 100000, "333-23-2322", 9),
              new FixedEmployee("Fran", 43, 93, 3000, "932-32-3232", 6010)
            };

            // Отобразить содержимое текущего массива.
            Console.WriteLine("Here is the unordered set of Employee:");
            foreach (Employee i in Workers)
                Console.WriteLine("{0} {1}", i.Name, i.ID );
            //**Реализовать интерфейсы для возможности сортировки массива используя Array.Sort()
            Array.Sort(Workers);
            Console.WriteLine();
            // Отобразить содержимое отсортированного массива.
            Console.WriteLine("Here is the ordered set of Employee:");
            foreach (Employee i in Workers)
                Console.WriteLine("{0} {1}", i.Name, i.ID);

            //Создать класс содержащий массив сотрудников и реализовать возможность вывода
            //данных с использованием foreach.
            Console.WriteLine("***** Fun with lEnumerable / IEnumerator *****\n");
            WorkersAr ListWorkers = new WorkersAr();
            foreach (Employee i in ListWorkers)
            {
                Console.WriteLine("Name ...{0}   EmpID ...{1}", i.Name, i.ID);

            }
           


            Console.ReadLine();
        }

        #region Helper methods
        static void CastingExamples()
        {
            // A TimeEmployee "is-a" System.Object, so we can 
            // store a TimeEmployee reference in an object variable just fine.
            object frank = new TimeEmployee("Frank Zappa", 19, 3000, 40000, "111-11-1111", 5);
            // OK!
            GivePromotion((TimeEmployee)frank);

            // A TimeEmployee "is-an" Employee too.
            Employee moonUnit = new TimeEmployee("MoonUnit Zappa", 22, 3001, 20000, "101-11-1321", 6);  
            GivePromotion(moonUnit);

            // A FixedEmployee "is-a" Employee.
            FixedEmployee jill = new FixedEmployee("Jill", 34, 3002, 100000, "111-12-1119", 800);
            GivePromotion(jill);

        }
        static void GivePromotion( Employee emp )
        {
            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is FixedEmployee)
            {
                Console.WriteLine("{0} had {1} Fixed Payment without Bonus...", emp.Name,
                  ((FixedEmployee)emp).Fixed);
                Console.WriteLine();
            }
            if (emp is TimeEmployee)
            {
                Console.WriteLine("{0} had {1} Time Payment without Bonus...", emp.Name,
                  ((TimeEmployee)emp).TimePayment);
                Console.WriteLine();
            }
        }
        #endregion
        //Создать на базе абстрактного класса массив сотрудников и заполнить его.
        Employee[] Workers =
            { new TimeEmployee("Frank Zappa", 19, 3000, 40000, "111-11-1111", 5),
              new TimeEmployee("MoonUnit Zappa", 22, 3001, 20000, "101-11-1321", 6),
              new FixedEmployee("Jill", 34, 3002, 100000, "111-12-1119", 800),
              new TimeEmployee("Chucky", 50, 92, 100000, "333-23-2322", 9),
              new FixedEmployee("Fran", 43, 93, 3000, "932-32-3232", 6010)
             };

       

        


    }
}
