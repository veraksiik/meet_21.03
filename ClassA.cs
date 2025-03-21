using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meet_21._03
{
    internal class ClassA
    {
        public void MethodA(ClassB classB)
        {
            classB.MethodB(this);
        }
        public void Add(ref int a)
        {
            a++;
        }
    }
    internal class ClassB
    {
        public void MethodB(ClassA classA)
        {
            Console.WriteLine("Hiiii");
        }
    }

}

namespace Engine
{
    namespace Renderer 
    {
        class Vector3D { }
    }
    namespace Phisics
    {
        class Vector3D { }

    }
}





