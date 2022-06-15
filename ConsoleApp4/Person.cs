using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Person

    {

        public abstract string Name { get; }
        public abstract string Surname { get; }
        public abstract string Patronymic { get; }
        abstract public void Income();
    }
    }


