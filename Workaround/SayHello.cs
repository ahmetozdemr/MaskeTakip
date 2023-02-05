using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    public class SayHello
    {
        public void SayHelloMethod()
        {
            Console.WriteLine("**********************************");

            Console.Write("Selam vermek istediğin vatandaşı yaz :");
            string personName = Console.ReadLine();
            Console.WriteLine("Selam Verdiğin Vatandaşın İsmi: " + personName);
        }

    }
}
