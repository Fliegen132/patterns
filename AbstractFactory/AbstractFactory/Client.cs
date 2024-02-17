using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;
using AbstractFactory.Figures;

public class Client
{
    private AbstractFactoryFigures _factory;
    public Client(AbstractFactoryFigures factory) 
    {
        _factory = factory;  
    }

    public AbstractCircle CreateCircle(int r) => _factory.CreateCircle(r);
    public AbstractSquare CreateSquare(int sz) => _factory.CreateSquare(sz);

    public bool ChangeFactory(AbstractFactoryFigures factory)
    {
        if (_factory != factory)
        {
            _factory = factory;
            return true;
        }
        return false;
    }

}
