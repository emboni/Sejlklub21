using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class Blog : IBlogPost
    {
        private string _title;
        private string _content;
        private string _picture;
        private int _id;
        private DateTime _date;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public string Picture
        {
            get {return _picture; }
            set { _picture = value; }
        }

        public int Id
        {
            get {return _id; }
            set { _id = value; }        }

        public DateTime Date
        {
            get {return _date; }
            set { _date = value; }
        }

        public Blog()
        {
            
        }

        public Blog(string title, string content, string picture, int id, DateTime date)
        {
            _title = title;
            _content = content;
            _picture = picture;
            _id = id;
            _date = date;
        }

        public override string ToString()
        {
            return $"id {_id} title {_title} date {_date} content {_content} picture {_picture}";
        }
    }
}
