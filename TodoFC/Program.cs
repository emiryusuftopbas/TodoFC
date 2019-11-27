using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TodoFC";
            TodoDal.CreateDb();
            ArgumentHandler argumentHandler = new ArgumentHandler();
            argumentHandler.Handle(args);
        }
    }
}
