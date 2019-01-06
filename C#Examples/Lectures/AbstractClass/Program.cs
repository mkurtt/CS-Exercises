using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.ExampleMethod();

        }
    }

    abstract class Person
    {
        public abstract void RoamInCorridor();

        public string ExampleMethod()
        {
            return "Value";
        }
    }

    class Student : Person
    {
        public override void RoamInCorridor()
        {
            throw new NotImplementedException();
        }
    }

    class Teacher : Person
    {
        public override void RoamInCorridor()
        {
            throw new NotImplementedException();
        }
    }

    class Labor : Person
    {
        public override void RoamInCorridor()
        {
            throw new NotImplementedException();
        }
    }
}
