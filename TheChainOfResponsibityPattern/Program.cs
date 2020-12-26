using System;

using TheChainOfResponsibityPattern.Lab1.Abstract;
using TheChainOfResponsibityPattern.Lab1.Concrete;
using TheChainOfResponsibityPattern.Lab2.Concrete;
using TheChainOfResponsibityPattern.Lab2.Model;


namespace TheChainOfResponsibityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab1
            //Zincirin halkalarını tanımla
            PlayerHandler aviPlayer = new HandlerAvi();
            PlayerHandler mp3Palyer = new HandlerMp3();
            PlayerHandler mp4Palyer = new HandlerMp4();

            //İlk request zincirin halkalarından sıralyarak tırmansı
            mp3Palyer.NextHandler = mp4Palyer;
            mp4Palyer.NextHandler = aviPlayer;

            mp3Palyer.Player("video.mpg");
            mp3Palyer.Player("video.avi");
            mp3Palyer.Player("video.mp4");
            mp3Palyer.Player("video.swf");
            mp3Palyer.Player("video.mp3");
            #endregion

            #region Lab2
            Manager manager = new Manager();
            VicePresendent vicePresedent = new VicePresendent();
            President presedent = new President();

            manager.SetHandler(vicePresedent);
            vicePresedent.SetHandler(presedent);

            Expense officeStuff = new Expense { Amount = 980, Details = "Office stuff" };
            manager.HandleExpense(officeStuff);

            Expense course = new Expense { Amount = 2500, Details = "Course" };
            manager.HandleExpense(course);

            Expense expense = new Expense { Amount = 5500, Details = "Expense" };
            manager.HandleExpense(expense);

            #endregion

            Console.ReadKey();
        }
    }
}
