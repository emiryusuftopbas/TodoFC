using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoFC
{
    class TodoOperator
    {
        public void Add()
        {
            Console.Write("Title : ");
            string title = Console.ReadLine();
            Console.Write("Content : ");
            string content = Console.ReadLine();
            string date = DateTime.Now.GetDateTimeFormats('d')[0];
            string state = "-";

            TodoItem todoItem = new TodoItem(TodoDal.IdGenerator(),title,content,date,state);
            TodoDal todoDal = new TodoDal();
            todoDal.Add(todoItem);
            Console.WriteLine("Successfully added" );


            


        }
        public void Delete(string id)
        {
            int todoId;
            bool tryConvert = int.TryParse(id,out todoId);
            if (!tryConvert)
            {
                Console.WriteLine("Please type valid id");
            }
            else
            {
                TodoDal todoDal = new TodoDal();
                todoDal.Delete(todoId);
                Console.WriteLine("successfully deleted");

            }
        }
        public void MarkAsCompleted(string id)
        {
            int todoId;
            bool tryConvert = int.TryParse(id, out todoId);
            if (!tryConvert)
            {
                Console.WriteLine("Please type valid id");
            }
            else
            {
                TodoDal todoDal = new TodoDal();
                todoDal.MarkStatus(todoId,"+");
                Console.WriteLine("Todo " + todoId + " marked as completed ");
            }

        }
        public void MarkAsUncompleted(string id)
        {
            int todoId;
            bool tryConvert = int.TryParse(id, out todoId);
            if (!tryConvert)
            {
                Console.WriteLine("Please type valid id");
            }
            else
            {
                TodoDal todoDal = new TodoDal();
                todoDal.MarkStatus(todoId, "-");
                Console.WriteLine("Todo " + todoId +  " marked as uncompleted ");
            }
        }

        public void Show()
        {
            TodoDal todoDal = new TodoDal();

            if (todoDal.GetTodos("-").Count == 0)
            {
                Console.WriteLine("There is nothing to show");
            }
            else
            {
                foreach (var todo in todoDal.GetTodos("-"))
                {
                    Console.WriteLine("==TO DO== ");
                    Console.WriteLine("- ID : " + todo.Id);
                    Console.WriteLine("- " + todo.Title.ToUpper());
                    Console.WriteLine("- " + todo.Content);
                    Console.WriteLine("- " + todo.Date);
                    PrintLine();
                }
            }

            
        }
        public void ShowCompleted()
        {
            TodoDal todoDal = new TodoDal();
            if (todoDal.GetTodos("+").Count == 0)
            {
                Console.WriteLine("There is nothing to show");
            }
            else
            {
                foreach (var todo in todoDal.GetTodos("+"))
                {
                    Console.WriteLine("==TO DO== ");
                    Console.WriteLine("- ID : " + todo.Id);

                    Console.WriteLine("- " + todo.Title.ToUpper());
                    Console.WriteLine("- " + todo.Content);
                    Console.WriteLine(todo.Status + " Completed");
                    PrintLine();
                }
            }
            
        }
        public void ShowAll()
        {
            TodoDal todoDal = new TodoDal();

            if (todoDal.GetAllTodos().Count == 0)
            {
                Console.WriteLine("There is nothing to show");
            }
            else
            {
                foreach (var todo in todoDal.GetAllTodos())
                {
                    Console.WriteLine("==TO DO== ");
                    Console.WriteLine("- ID : " + todo.Id);
                    Console.WriteLine("- " + todo.Title.ToUpper());
                    Console.WriteLine("- " + todo.Content);
                    Console.WriteLine("- " + (todo.Status == "+" ? "Completed" : "Uncompleted"));
                    PrintLine();
                }
            }

        }

        private void PrintLine()
        {
            for(int i = 0; i< Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.Beep();
        }
        
    }
}
