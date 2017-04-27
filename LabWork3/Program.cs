using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3
{
    class Program
    {
       private static int firstRowNum = 2;
       private static int secandRowNum = 3;

        /*{
            {book, book2},
            {book3,book4,book5}
        }*/

       static  Katalog[][] arr = { new Katalog[firstRowNum], new Katalog[secandRowNum] };

        static void Main(string[] args)
        {

            Katalog book = new Katalog("Block","the best",1);
            Katalog book2 = new Katalog("Shindler", "the best", 5);

            Katalog book3 = new Katalog("Gugo ", "Notre-Dame de Paris", 5);
            Katalog book4 = new Katalog("Goethe's", "Faust", 3);

            // first row
            arr[0][0] = book;
            arr[0][1] = book2;

            //second row 
            arr[1][0] = book3;
            arr[1][1] = book4;

            // arr[1][1] = book4;
            arr[1][2] = new Katalog();

            print();
            arr[1][2] = createKetalogItem();
            print();

            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();

        }

        private static void  print(){

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} row", i + 1);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j].ToString());
                }
            }
        }

        private static Katalog createKetalogItem()
        {          

            String author;
            String bookName;
            String countStr; 
            int count;
            Console.WriteLine("Enter the book name");
            bookName = Console.ReadLine();

            Console.WriteLine("Enter the autor name");
            author = Console.ReadLine();

            Console.WriteLine("Enter the count");
            countStr = Console.ReadLine();
            Int32.TryParse(countStr,out  count);

            Katalog katalog = new Katalog(bookName, author, count);

            return katalog;
        }

    }
}
