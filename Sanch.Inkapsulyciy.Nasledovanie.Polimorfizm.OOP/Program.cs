using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Inkapsulyciy.Nasledovanie.Polimorfizm.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инкапсуляция - микроволновка(пример) доступ к самому необходимому - скрытый класс - черный ящик
            //Наследование - врач(фио и специализация)(наследник) <- человек(Фио)(база)( на все наследники перенесется )
            //Полиморфизм - наследника в базовый класс (преобразуем) оставляем только базовый класс - врача в человека

            //Абстракция - выкинуть все ненужное, и взять то что необходимо в классе(человек)
            //Посылка сообщений - подпись на событие ( как подписка на уведомление на ютубе) 
            //Повторное использование кода - существующие инструкции - дублировать удобное( создание библиотеки)
           
            int i = 0; // 1
            Int32 j = new Int32(); //2 тоже самое что 1

            Person person = new Person();//3 тоже самое что 2 и ( 3 и 4 тоже самое)
            person.FirstName = "Вадим";
            person.LastName = "Шведанский";

            Person p2 = new Person();//4 тоже самое что 2 и ( 3 и 4 тоже самое)
            p2.FirstName = "Саша";
            p2.LastName = "Петров";

            var d = new Doctor(); // есть те же самые что и у Человека но те что написаны с public. С private нету (Money). 
            d.FirstName = "Ваня";
            d.LastName = "Иванов";
            d.Spec = "Хирург";

            Console.WriteLine(d.FirstName);
            Console.WriteLine(d.LastName);


            Person p = d; // полифорфизм

            Console.WriteLine(p.FirstName);// могу вызвать
            //Console.WriteLine(p.Spec);// не могу потому что отбросили

            //p.FirstName - есть а специализации нет
             Doctor dd = (Doctor)p;// обратное приведение

            Console.WriteLine(dd.Spec); //Могу потому что вернули в доктора // Это и есть полиморфизм

            Console.ReadKey();// все работает

        }
    }
}
