using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee : Person
    {
        public override string Name => throw new NotImplementedException();

        public override string Surname => throw new NotImplementedException();

        public override string Patronymic => throw new NotImplementedException();

        public override void Income()
        {
            throw new NotImplementedException();
        }
    }
}
