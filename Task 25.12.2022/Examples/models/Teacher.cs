using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Teacher : Person
    {
        public override void Method()
        {
            throw new NotImplementedException();
        }

        public sealed override void Sum()
        {
            Console.WriteLine(1000);
        }
    }

}
