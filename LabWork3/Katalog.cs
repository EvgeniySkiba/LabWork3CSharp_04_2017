using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3
{
    class Katalog
    {
        private String bookName;

        public String BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private String author;

        public String Author
        {
            get { return author; }
            set { author = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        /// <summary>
        /// default konstructor 
        /// </summary>
        public Katalog()
        {

        }

        /// <summary>
        /// constructor whit params 
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="author"></param>
        /// <param name="count"></param>
        public Katalog(String bookName, String author, int count)
        {
            this.bookName = bookName;
            this.author = author;
            this.count = count;
        }

        public override string ToString()
        {
            String result = String.Format("BookName: {0}; Author: {1}  count : {2};",bookName,author,count);  
            return result;
        }
    }

}
