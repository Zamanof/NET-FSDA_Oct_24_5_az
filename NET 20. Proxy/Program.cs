// Proxy pattern - proksi, vekil, komekchi, katib

/*
    1. Protection Proxy
    2. Virtual Proxy (Lazy initialization)
    3. Remote Proxy (CDN)
    4. Logging Proxy
    5. Cashing Proxy 
*/


// Protection Proxy Example
OperationProxy operationProxy = new(new RealOperationSubject(), 1);
operationProxy.Request();


interface IOperation
{
    void Request();
}

// Real subject (Real Service)

class RealOperationSubject : IOperation
{
    public void Request()
    {
        Console.WriteLine("Some real operations"); 
    }
}

// Proxy (Proxy Server)

class OperationProxy : IOperation
{
    private IOperation _operation { get; set; }
    private int _role;

    public OperationProxy(IOperation operation, int role)
    {
        _operation = operation;
        _role = role;
    }

    public void Request()
    {
        if(_role == 1)
        {
            _operation.Request();
        }
        else
        {
            Console.WriteLine("401 unauthorized");
        }
    }
}
