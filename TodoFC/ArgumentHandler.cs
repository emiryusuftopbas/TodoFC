using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoFC
{
    class ArgumentHandler
    {
        public void Handle(string[] args)
        {
            int argsLength = args.Length;
            TodoOperator todoOperator = new TodoOperator();
            if (argsLength <= 0)
            { 
                todoOperator.Show();
            }
            else if (args[0] == "add" )
            {
                todoOperator.Add();
            }
            else if(args[0] == "del" && argsLength == 2)
            {
                todoOperator.Delete(args[1]);
            }
            else if (args[0] == "mark-as-completed" && argsLength == 2)
            {
                todoOperator.MarkAsCompleted(args[1]);
            }
            else if (args[0] == "mark-as-uncompleted" && argsLength == 2)
            {
                todoOperator.MarkAsUncompleted(args[1]);
            }
            else if(args[0] == "show-completed" )
            {
                todoOperator.ShowCompleted();
            }
            else if (args[0] == "show-all")
            {
                todoOperator.ShowAll();
            }

        }
    }
}
