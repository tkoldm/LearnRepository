namespace ChocoHolic;

public class ChocolateBoiler
{
    private bool _isEmpty;
    private bool _isBoiled;
    private readonly Guid _boilerId;

    private static readonly ChocolateBoiler ChocolateBoilerInstance = new();

    private ChocolateBoiler()
    {
        _isEmpty = true;
        _isBoiled = true;
        _boilerId = Guid.NewGuid();
    }

    public static ChocolateBoiler GetInstance() => ChocolateBoilerInstance;

    public void Fill()
    {
        if (_isEmpty)
        {
            _isEmpty = false;
            _isBoiled = false;
            
            Console.WriteLine($"{_boilerId} - Filling boiler with milk and chocolate");
        }
        else
        {
            Console.WriteLine($"{_boilerId} - Already fill");
        }
    }

    public void Drain()
    {
        if (!_isEmpty && _isBoiled)
        {
            _isEmpty = true;
            Console.WriteLine($"{_boilerId} - Draining boiled chocolate and milk");
        }
        else
        {
            Console.WriteLine($"{_boilerId} - Already drain");
        }
    }

    public void Boil()
    {
        if (!_isEmpty && !_isBoiled)
        {
            _isBoiled = true;
            Console.WriteLine($"{_boilerId} - Boil milk with chocolate");
        }
        else
        {
            Console.WriteLine($"{_boilerId} - Already boil");
        }
    }
}