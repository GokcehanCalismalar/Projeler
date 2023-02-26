using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _6._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list= new ArrayList();    

            list.Add(1);
            list.Add("naber");
            list.Add(798.89f);
            list.Add(875d);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
        }
    }
}
