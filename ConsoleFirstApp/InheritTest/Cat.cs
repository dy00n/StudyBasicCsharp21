using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Cat : Animal
    {
        //특성 -> 속성
    
        //기본생성자
        public Cat() { this.Age = 0; }

        //액션 -> 매서드
        public void Meow()
        {
            Console.WriteLine("야옹!");
        }
    }
}
