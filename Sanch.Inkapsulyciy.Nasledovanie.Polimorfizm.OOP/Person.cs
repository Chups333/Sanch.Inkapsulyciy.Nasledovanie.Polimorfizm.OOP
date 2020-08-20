using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Inkapsulyciy.Nasledovanie.Polimorfizm.OOP
{
    /*class Person
    {
        //Инкапсуляция 
        //public - открытый все везде всегда - можно обратиться - публичный 
        //internal - открытый в прелеоах проекта
        //protected - защищенный ( доступно только наследнику) 
        //private - закрытый( принадлежит только этому классу) только внутри класс и закрытая никому недоступно
    }*/

    public class Person
    {
        public string FirstName; // открыто для всех если private то только внутри класса
        public string LastName;

        //private decimal Money; // закрыто внутри класса 
        protected decimal Money; // В Main нельзя использовать, в Doctor можно потому что наследуем из человека его.
    }
}
