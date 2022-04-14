using System;
using System.Linq;
using System.Text;
using System.Net.Cache;
using ListMaster;

namespace ConsoleVS
{
    class Program
    {
        static public void Main(string[] args)
        {
            ArrayMaster am = new ArrayMaster();
            for (int i = 0; i < 10; i++)
            {
                am.Add(new Random().Next(1,5));
            }
            
            for (int i = 0; i < am.GetCount(); i++)
            {
                Console.WriteLine(am.GetValue(i));
            }
        }

    }   
}
