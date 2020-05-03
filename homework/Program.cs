using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] arr2= new int[arr.Length];
            //int j = 0;

            //for (int i = arr.Length-1; i >= 0; i--)
            //{
            //    arr2[j] = arr[i];
            //    j++;
            //}

            //for (int i = 0; i <arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i] ); 
            //}


            //int[] arr = new int[] { 2, 3, 1, 8, 5, 6, 7, 4, 9 };
            //int max = arr[0];
            //int min = arr[0];
            //int max2 = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max2 = max;
            //        max = arr[i];
            //    }else if (max2 < arr[i])
            //    {
            //        max2 = arr[i];
            //    }

            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}

            //Console.WriteLine($"Max : {max2}  Min : {min}");




            //Book book = new Book();
            //book.Name= "book1";
            //book.AuthorName = "author1";
            //book.Title = "title1";
            //book.ShowInformation();

            //Book book2 = new Book();
            //book2.Name = "book2";
            //book2.AuthorName = "author2";
            //book2.Title = "title2";
            //book2.ShowInformation();

            //Book book3 = new Book("book3", "author3", "title3");
            //book3.ShowInformation();



            Converter converter = new Converter(1.7m, 2.8m);
            converter.ConverToUSD(170);
        }
    }


    class Book {

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public string Title { get; set; }

        public Book()
        {

        }

        public Book(string name,string author,string title)
        {
            this.Name = name;
            this.AuthorName = author;
            this.Title = title;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Name {Name}  Author: {AuthorName} Title : {Title}");
        }
    }


    class Converter
    {
        public decimal USD { get; set; }
        public decimal EUR { get; set; }
        public Converter( decimal USD , decimal EUR)
        {
            this.EUR = EUR;
            this.USD = USD;
        }
        public void ConverToEUR(decimal AZN)
        {
            Console.WriteLine(AZN/EUR);
        }

        public void ConverToUSD( decimal AZN)
        {
            Console.WriteLine(AZN /USD);
        }

        
    }
}
