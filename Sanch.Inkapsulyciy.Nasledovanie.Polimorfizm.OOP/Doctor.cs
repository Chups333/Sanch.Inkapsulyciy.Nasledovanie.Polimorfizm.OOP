using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Inkapsulyciy.Nasledovanie.Polimorfizm.OOP
{
   /* class Doctor
    {
        //Наследование

       //public string FirstName; так нельзя с человека брать
       //public string LastName;
    }*/

    public class Doctor : Person // указываем базовый класс ( наследовать можно только от одного класса) 
    {
        /*void m()
         {
             var d = new Doctor();
             d.Money = 123; // можно использовать 
         }*/

        // Полиморфизм 
        public string Spec;
    }
}
