namespace MyApp;

public class LumberjackRight : ILamberjack
{
    private EnumPlace _place;
    public EnumPlace LamberjackInSpace()
    {
        _place = EnumPlace.Right;
        Console.WriteLine("Дровосек справа");
        return _place;
    }
}