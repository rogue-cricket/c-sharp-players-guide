using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetAuthor()
        {
            return this.author;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void AssignWordCountFromText(string text)
        {
            this.wordCount = text.Split(' ').Length;
        }
    }
}
