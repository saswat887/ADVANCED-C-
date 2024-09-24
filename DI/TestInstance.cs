using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    internal class TestInstance
    {
        Guid obj;
        public TestInstance()
        {
            obj = Guid.NewGuid();
        }

        public void Show()
        {
            Console.WriteLine("Guid is " + obj.ToString());

        }
    }
}
