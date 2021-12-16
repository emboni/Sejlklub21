using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class Blog : IBlogPost
    {
        private int _id;
        private string _title;
        private DateTime _date;
        private string _content;
        private string _picture;

        [Required(ErrorMessage = "Titel kræves")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

       [Required(ErrorMessage = "Beskrivelse kræves")]
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

        [Required]
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
            _id = id;
            _title = title;
            _date = date;
            _picture = picture;
            _content = content;
        }

        public override string ToString()
        {
            return $"id {_id} title {_title} date {_date} content {_content} picture {_picture}";
        }

        //public List<Blog> GetAllBlogPost()
        //{
        //    return new List<Blog>();
        //}
    }
}
