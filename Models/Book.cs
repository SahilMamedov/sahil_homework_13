using System;

namespace Homework_13
{
    public class Book : Product
    {
        public string _AuthorName { get; set; }
        public int _PageCount { get; set; }

        public override void Sell()
        {
            if (_Count != 0)
            {

                _Count--;

                _TotallnCome = _TotallnCome + _Price;
                Console.WriteLine($"Satildi: \n" +
                    $"ID: {ID} \n" +
                    $"Name: {_Name} \n" +
                    $"Price: {_Price} \n" +
                    $"Bu qeder qaldi: {_Count} \n " +
                    $"TotalSumma: {_TotallnCome}");
                Console.WriteLine();
                Console.WriteLine("*****************");
                Console.WriteLine();



            }
            else
            {
                throw new ProductCountlsZeroException("Bu kitabimizdan qalmayib");
            }

        }
        public Book(string name, double price, string authorname, int pagecount, int count) : base(name, price, count)
        {


            _AuthorName = authorname;
            _PageCount = pagecount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {ID} \n" +
                $"Name: {_Name} \n" +
                $"Price: {_Price} \n" +
                $"Count: {_Count} \n" +
                $"AuthorName: {_AuthorName} \n" +
                $"PageCount: {_PageCount}");
            Console.WriteLine("-------------------");
        }
    }
}
