namespace MyApp;

public class SelectionPlace
{
    private ILamberjack _lamberjackPlace;
    private EnumPlace _place;

    public SelectionPlace(EnumPlace place)
    {
        _place = place;
        _lamberjackPlace = new LumberjackLeft();
    }

    public ILamberjack SelectedPosition()
    {
        switch (_place)
        {
            case EnumPlace.Left :
                _lamberjackPlace = new LumberjackLeft();
                break;
            case EnumPlace.Right :
                _lamberjackPlace = new LumberjackRight();
                break;
            default:
                Console.WriteLine("Что-то тут не так!!");
                break;
        }
        
        return _lamberjackPlace;
    }
}