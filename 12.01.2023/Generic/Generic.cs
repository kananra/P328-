using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generic
{
    internal class Generic<T>
    {
        public void Print(T obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();


            for (int i = 0; i < props.Length; i++)
            {
                Console.WriteLine(props[i].GetValue(obj));
            }




        }
    }
}
