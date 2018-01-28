using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Брижак Андрей Домашнее задание по курсу C# уровень 2 урок 2
namespace Employees
{
    //Создать класс содержащий массив сотрудников и реализовать возможность вывода
    //данных с использованием foreach.
    // WorkersAr содержит набор объектов Employee. 
    public class WorkersAr : IEnumerable

    {
        private Employee[] Worker = new Employee[4];
        //Заполнить первоначально несколькими объектами 
        public WorkersAr()
        { 
         Worker[0] = new TimeEmployee("Frank Zappa", 19, 3000, 40000, "111-11-1111", 5);
         Worker[1] = new FixedEmployee("Jill", 34, 3002, 100000, "111-12-1119", 800);
         Worker[2] = new TimeEmployee("Chucky", 50, 92, 100000, "333-23-2322", 9);
         Worker[3] = new FixedEmployee("Fran", 43, 93, 3000, "932-32-3232", 6010);
        }

        public IEnumerator GetEnumerator()
        {
            // Возвратить IEnumerator объекта массива, 
            return Worker.GetEnumerator();
        }

    }
}
