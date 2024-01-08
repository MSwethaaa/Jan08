using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jan08
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Assembly ourIoAss = Assembly.LoadFile("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\system.dll");
            foreach (Type t in ourIoAss.GetTypes()) { Console.WriteLine(t.Name); }
            // Type[] allClassNames = ourIoAss.GetTypes();
            //Type is class , about each class or data type 
            //  foreach (Type t in allClassNames) { Console.WriteLine(t.FullName); }
        }
    }
}
