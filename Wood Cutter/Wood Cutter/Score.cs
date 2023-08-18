namespace MyApp;

public class Score
{
    private int _score;
    
    public Score()
    {
        _score = 0;
    }

    public void PrintScore()
    {
        Console.SetCursorPosition(10, 4);
        Console.WriteLine("Ваш счёт: " + _score);
        Console.SetCursorPosition(default,default);
    }

    public void AddScore()
    {
        _score++;
    }

    public void LoseScore()
    {
        Console.Clear();
        Console.WriteLine("Увы, но вы проиграли!" + "\n" + "Ваш итоговый счёт: " + _score);
    }
    
}