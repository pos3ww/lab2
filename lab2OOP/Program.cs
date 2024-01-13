using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace lab2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFactory gameFactory = new GameFactory();
            
            StandartGameAccount player1 = new StandartGameAccount("Vova", 0, 0);
            WinStreakGameAccount player2 = new WinStreakGameAccount("Vika", 0, 0);
            HalvedRatingLossGameAccount player3 = new HalvedRatingLossGameAccount("Vlad", 0, 0);
            gameFactory.CreateGame(player1, player2, "Standart", 2.0);
            gameFactory.CreateGame(player1, player2, "Training", 12.0);
            gameFactory.CreateGame(player2, player3, "OnePlayerRatingChange", 3.0);
            gameFactory.CreateGame(player2, player2, "Training", 7.0);
            player1.GetStats();
            player2.GetStats();
            player3.GetStats();
            
            
        }

    }
}