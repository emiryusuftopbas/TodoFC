using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoFC
{
    class TodoDal
    {
        static string filePath;
        public static void CreateDb()
        {
            string username= System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            if (!File.Exists(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list"))
            {
             
                FileStream fs = File.Create(@"C:/users/"+username.Split('\\')[1] + @"/documents/todo.list");
                filePath = @"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list";
                fs.Close();
            }
        }

        public void Add(TodoItem todo)
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            FileStream fs = new FileStream(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(todo.ToString());

            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void Delete(int id)
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            FileStream fs = File.Open(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
 
            List<string> todos = new List<string>();

            string line = sr.ReadLine();

            while (line != null)
            {
                string[] parts = line.Split('|');
                int idAtFile = Convert.ToInt32(parts[0]);
                
                if(id != idAtFile)
                {
                    todos.Add(line);
                   
                }
               
                line = sr.ReadLine();
            }


            string changedText = "";
            for (int i = 0; i < todos.Count; i++)
            {
                string nl = "";
                if (i <= todos.Count)
                {
                    nl = "\n";
                }
                changedText += todos[i] + nl;
            }
            
            sr.Close();
            fs.Close();
            UpdateFile(changedText);
        }

        public void MarkStatus(int id,string status)
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            FileStream fs = File.Open(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            List<TodoItem> todos = new List<TodoItem>();

            string line = sr.ReadLine();

            while (line != null)
            {
                string[] parts = line.Split('|');
                int idAtFile = Convert.ToInt32(parts[0]);
                if (id == idAtFile)
                {
                    TodoItem todoItem = new TodoItem(int.Parse(parts[0]),parts[1],parts[2],parts[3],status);
                    todos.Add(todoItem);
                }
                else
                {
                    TodoItem todoItem = new TodoItem(int.Parse(parts[0]), parts[1], parts[2], parts[3],parts[4]);
                    todos.Add(todoItem);
                }
                line = sr.ReadLine();
            }
            string changedText = "";
            for (int i = 0; i < todos.Count; i++)
            {
                string nl = "";
                if (i <= todos.Count)
                {
                    nl = "\n";
                }
                changedText += todos[i] + nl;
            }
            sr.Close();
            fs.Close();
            UpdateFile(changedText);
        }

        private void UpdateFile(string text)
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            File.WriteAllText(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list", "");
            FileStream fs = new FileStream(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list", FileMode.Open, FileAccess.Write);
            
            TextWriter sw = new StreamWriter(fs);
            sw.Write(text);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static int IdGenerator()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            FileStream fs = File.Open(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            List<int> max = new List<int>();
            while (line != null)
            {
                String[] parcalar = line.Split('|');
                int id = Convert.ToInt32(parcalar[0]);
                max.Add(id);
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();

            int[] arr_max = max.ToArray();
            if (arr_max.Length == 0)
            {
                return 1;
            }
            
            return arr_max.Max() + 1;

        }
        public List<TodoItem> GetTodos(string status)
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            FileStream fs = File.Open(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<TodoItem> todos = new List<TodoItem>();
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split('|');
                if(parts[4] == status)
                {
                    TodoItem todoItem = new TodoItem(int.Parse(parts[0]), parts[1], parts[2], parts[3], parts[4]);
                    todos.Add(todoItem);
                }
                
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return todos;
        }
        public List<TodoItem> GetAllTodos()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            FileStream fs = File.Open(@"C:/users/" + username.Split('\\')[1] + @"/documents/todo.list", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<TodoItem> todos = new List<TodoItem>();
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split('|');
                    TodoItem todoItem = new TodoItem(int.Parse(parts[0]), parts[1], parts[2], parts[3], parts[4]);
                    todos.Add(todoItem);    
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return todos;
        }
    }
}
