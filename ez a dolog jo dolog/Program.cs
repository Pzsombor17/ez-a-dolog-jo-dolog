using System.Diagnostics;

namespace ez_a_dolog_jo_dolog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Book book = new Book("Hobbit", "gandalf jeno", 310) {Price = 65000 };
            book.UpdatePrice(10);
            Console.WriteLine(book);
            Book dune = book with { Author = "kjhb", Title = "dfs", Pages = 444 };
            Console.WriteLine(dune);
            string fajl = @"C:\Users\Pap.Zsombor\Downloads\zsar_edit.mp4";

            Process.Start(new ProcessStartInfo
            {
                FileName = fajl,
                UseShellExecute = true
            });
            student anna = new student("Nagy Anna", "12.a", 2008);
            anna.UpdateAvarage(4.7);
            Console.WriteLine(anna);
            Console.WriteLine(anna.grading());
            student bence = new student("Kiss Bence", "12.B", 2007);
            bence.UpdateAvarage(3.8);
            Console.WriteLine(bence);
            Console.WriteLine(bence.grading());
            VideoGame cyberpunk = new VideoGame
                ("Cyberpunk 2077", "CD Projekt", 2020)
            { Rating = 8.6 };
            cyberpunk.UpdatePrice(190909);
            Console.WriteLine(cyberpunk);
            Console.WriteLine(cyberpunk.CanIbuy(14000));
            Console.WriteLine(cyberpunk.HowOld(DateTime.Now.Year));
            VideoGame Rd2 = new VideoGame
                ("Red Dead Redemption 2", "Rockstar Games", 2018)
            { Rating = 9.6 };
            cyberpunk.UpdatePrice(18990);
            Console.WriteLine(Rd2);
            Console.WriteLine(Rd2.CanIbuy(24000));
            Console.WriteLine(Rd2.HowOld(DateTime.Now.Year));
            Employee kovacs = new Employee("Kovacs Peter", "Developer");
            kovacs.UpdateWage(155);
            Console.WriteLine(kovacs.OverTimeWage());
            kovacs.UpdateWage(15);
            Console.WriteLine(kovacs);
        }   
    }
    
}
