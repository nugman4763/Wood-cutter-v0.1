namespace MyApp;

public class LumberjackLeft : ILamberjack
{
    private EnumPlace _place;
    public EnumPlace LamberjackInSpace()
    {
        _place = EnumPlace.Left;
        return _place;
    }
}