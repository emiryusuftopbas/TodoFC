using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoFC
{
    class TodoItem
    {
        int _id;
        string _title;
        string _content;
        string _date;
        string _status;

        public int Id
        {
            get { return _id; }
        }
        public string Title
        {
            get { return _title; }
        }
        public string Content
        {
            get { return _content; }
        }
        public string Date
        {
            get { return _date; }
        }
        public string Status
        {
            get { return _status; }
        }


        public TodoItem(int id , string title, string content ,string date ,  string status)
        {
            _id = id;
            _title = title;
            _content = content;
            _date = date;
            _status = status;
        }

        public override string ToString()
        {
           return  String.Format($"{Id}|{Title}|{Content}|{Date}|{Status}");
        }

    }
}
