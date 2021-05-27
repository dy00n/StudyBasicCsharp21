using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    //Acess Modifier : public, protected, private
    class Animal
    {
        protected int Age { get; set; }

        protected Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("먹습니다"); }

        public void Sleep() { Console.WriteLine("잡니다"); }
    }
}
