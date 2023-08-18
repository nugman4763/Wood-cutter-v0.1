namespace MyApp;

public class Log : IObjects
{

    public char Symbol()
    {
        return 'П';
    }

    public EnumPlace PlaceInTheSpace()
    {
        return EnumPlace.Centre;
    }
    
    public bool Alive()
    {
        return true;
    }
}