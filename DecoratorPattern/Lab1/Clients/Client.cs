using DecoratorPattern.Lab1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab1.Clients
{
    public class Client
    {
        public static void Display(string text, IBilesen bilesen)
        {
            Console.WriteLine(text + bilesen.Operasyon());
        }
    }
}
