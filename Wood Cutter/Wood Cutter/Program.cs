using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            
            int height = 6;
            int lenght = 7;
            
            EnumMoveKey moveKey = EnumMoveKey.Left;
            EnumPlace place = EnumPlace.Left;
            ConsoleKeyInfo key;
            bool Alive = true;
            var score = new Score();
            
            var lumberjack = new SelectionPlace(place);
            var lumberjackInfo = new Lumberjack(lumberjack.SelectedPosition());
            var tree = new Tree(height, lenght, moveKey, lumberjackInfo.Symbol());
            
            tree.ShowTree();
            
            while (Alive == true)
            {
                score.PrintScore();
                lumberjackInfo.ShowInfo();
                key = Console.ReadKey();
                moveKey = (EnumMoveKey)key.Key;
                tree.Move(moveKey);
                tree.DeleteLog();
                Alive = tree.CheckDeath();
                score.AddScore();
                Console.Clear();
                tree.AddLog();
            }
            score.LoseScore();
        }
    }
}