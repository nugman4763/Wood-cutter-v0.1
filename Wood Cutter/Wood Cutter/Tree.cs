namespace MyApp;

public class Tree
{
    private char[,] _tree;
    private Move _move;
    private EnumPlace _place;
    private int _height;
    private int _lenght;
    private char _lumberjack;
    private IObjects _object;
    private Random _random;
    private EnumPlace _placeObject;
    private IObjects _log;
   

    public Tree(int height, int lenght, EnumMoveKey moveKey, char lumberjack)
    {
        _height = height;
        _lenght = lenght;
        _move = new Move(moveKey);
        _lumberjack = lumberjack;
        _placeObject = EnumPlace.Centre;
        _log = new Log();
        _random = new Random();
    }
    
    public void ShowTree()
    {
        CreateEmptyMap();
        for (int y = 0; y < _height ; y++)
        {
            GenerateTree();
            
            _tree[y, ((int)EnumPlace.Centre)] = _log.Symbol();

            for (int x = 0; x < _lenght; x++)
            {
                CreateOther(x,y);
                
                Console.Write(_tree[y, x]);
            }
            Console.WriteLine();
        }
    }

    public void DeleteLog()
    {
        for (int y = _height - 2; y > -1; y--)
        {
            for (int x = 0; x < _lenght; x++)
            {
                _tree[y + 1, x] = _tree[y, x];
            }
        }
    }

    public void AddLog()
    {
        int upLog = 0;
        for (int y = 0; y < _height ; y++)
        {
            if (y == 0)
            {
                GenerateTree();
            }
            
            _tree[y, ((int)EnumPlace.Centre)] = _log.Symbol();
            
            for (int x = 0; x < _lenght; x++)
            {
                CreateOther(x,y,upLog);
                Console.Write(_tree[y, x]);
            }
            Console.WriteLine();
        }
    }
    
    public void Move(EnumMoveKey moveKey)
    {
        _place = _move.MovingInSpace(moveKey);
    }

    public bool CheckDeath()
    {
        if (_tree[_height - 2, (int)_place] == _object.Symbol())
        {
            return _object.Alive();
        }
        else
        {
            return true;
        }
    }

    private void CreateEmptyMap()
    {
        _tree = new char[_height, _lenght];
        for (int y = 0; y < _height; y++)
        {
            for (int x = 0; x < _lenght; x++)
            {
                _tree[y, x] = ' ';
            }
        }
    }
    
    private void GenerateTree()
    {
        switch (_random.Next(0,3))
        {
            case 0 :
                _object = new Branch();
                _placeObject = EnumPlace.Left;
                break;
            case 1 :
                _object = new Branch();
                _placeObject = EnumPlace.Right;
                break;
            case 2 :
                _object = new Log();
                _placeObject = EnumPlace.Centre;
                break;
            default :
                _object = new Log();
                _placeObject = EnumPlace.Centre;
                break;
        }
    }

    private void CreateOther(int x, int y)
    {
        if (y == _height - 2)
        {
            _tree[y, (int)_place] = _lumberjack;
        }
        
        if (x == (int)_placeObject && y != _height - 2)
        {
            _tree[y, (int)_placeObject] = _object.Symbol();
        }
        
        if (y == _height - 1)
        {
            _tree[y, x] = '=';
        }
    }
    
    private void CreateOther(int x, int y ,int upLog)
    {
        if (y == _height - 2)
        {
            _tree[y, (int)_place] = _lumberjack;
        }
        
        if (x == (int)_placeObject && y != _height - 2)
        {
            _tree[upLog, (int)EnumPlace.Left] = ' ';
            _tree[upLog, (int)EnumPlace.Right] = ' ';
            _tree[upLog, (int)_placeObject] = _object.Symbol();
        }
        
        if (y == _height - 1)
        {
            _tree[y, x] = '=';
        }
    }

}