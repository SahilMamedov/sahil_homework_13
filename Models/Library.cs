using System;
using System.Collections.Generic;

namespace Homework_13
{
    public class Library
    {
        public int _BookLimit { get; set; }

       
        public Library(int booklimit)
        {
            _BookLimit = booklimit;
        }


        List<Book> Books = new List<Book>();
        public void AddBook(Book book)
        {


            if (_BookLimit > 0)
            {
                Books.Add(book);
                Console.WriteLine($"Book Add olundu ID: {book.ID}");
                _BookLimit--;
                Console.WriteLine();
            }
            else
            {
                throw new CapacityLimitException("Sizin Capacity doludur");
            }

        }

        public Book GetBookById(int? id)
        {
            foreach (Book book in Books)
            {
                if (book.ID == id)
                {
                    book.ShowInfo();
                    return book;
                }
                else if (id == null)
                {
                    throw new NullReferenceException("ID-ni bosh gondermisiz");
                }


            }
            return null;
        }

        public Book RemoveById(int? id)
        {
            foreach (Book book in Books)
            {
                if (book.ID == id)
                {
                    Books.Remove(book);
                    Console.WriteLine($"ID: {book.ID}--Silindi");
                    return book;
                }
                else if (id == null)
                {
                    throw new NullReferenceException("Id-ni bosh gondermisiz");

                }

                //else if(id != book.ID)
                //{
                //    throw new NotFoundException("Bele bir kitabimiz yoxdur");
                //}

            }
            throw new NotFoundException("Bele bir kitabimiz yoxdur");
            //  return null;
        }




    }
}
