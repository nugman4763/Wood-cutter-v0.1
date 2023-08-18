using System.Text;

namespace MyApp;

public class Lumberjack
{
    
    private ILamberjack _lumberjackPlace;

    public Lumberjack(ILamberjack lumberjackPlace)
    {
        _lumberjackPlace = lumberjackPlace;
    }

    
    public void ShowInfo()
    {
        _lumberjackPlace.LamberjackInSpace();
    }

    public char Symbol()
    {
        return '@';
    }
    

}