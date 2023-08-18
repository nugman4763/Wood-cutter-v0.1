namespace MyApp;

public class Move
{
    private EnumPlace _place;
    private EnumMoveKey _moveKey;

    public Move(EnumMoveKey moveKey)
    {
        _moveKey = moveKey;
    }
    
    public EnumPlace MovingInSpace(EnumMoveKey moveKey)
    {
       
        switch (moveKey)
        {
            case EnumMoveKey.Right:
                _place = EnumPlace.Right;
                return _place;
                break;
            case EnumMoveKey.Left :
                _place = EnumPlace.Left;
                return _place;
                break;
            default:
                Console.WriteLine("Неверная кнопка, давай другую!");
                return _place;
                break;
        }
    }
}