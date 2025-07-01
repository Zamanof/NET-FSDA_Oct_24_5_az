// Facade

ComputerFacade computerFacade = new ComputerFacade(
    new Motherboard { Vendor = "ASUS", Model = "ROG Strix" },
    new RAM { Vendor = "Corsair", Model = "Vengeance LPX" },
    new CPU { Vendor = "Intel", Model = "Core i9" },
    new GPU { Vendor = "NVIDIA", Model = "RTX 3080" },
    new SSD { Vendor = "Samsung", Model = "970 EVO Plus" },
    new PowerSupply { Vendor = "Corsair", Model = "RM850x" },
    new Case { Vendor = "NZXT", Model = "H510" }
);
computerFacade.StartComputer();

interface IDevice
{
    string Vendor { get; set; }
    string Model { get; set; }
    void Start();
}

class CPU : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("CPU Started");
    }
}

class GPU : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("GPU Started");
    }
}

class RAM : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("RAM Started");
    }
}

class SSD : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("SSD Started");
    }
}

class Motherboard : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("Motherboard Started");
    }
}

class PowerSupply : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("PowerSupply Started");
    }
}

class Case : IDevice
{
    List<IDevice> devices = new List<IDevice>();
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        devices.ForEach(d => d.Start());
        Console.WriteLine("PC Started");
    }
    public void AddDevice(IDevice device)
    {
        devices.Add(device);
    }
}

class ComputerFacade
{
    private Motherboard motherboard;
    private RAM RAM;
    private CPU CPU;
    private GPU GPU;
    private SSD SSD;
    private PowerSupply powerSupply;
    private Case computerCase;

    public ComputerFacade(Motherboard motherboard, RAM rAM, CPU cPU, GPU gPU, SSD sSD, PowerSupply powerSupply, Case computerCase)
    {
        this.motherboard = motherboard;
        RAM = rAM;
        CPU = cPU;
        GPU = gPU;
        SSD = sSD;
        this.powerSupply = powerSupply;
        this.computerCase = computerCase;
    }
    public void StartComputer()
    {
      
        computerCase.AddDevice(motherboard);
        computerCase.AddDevice(powerSupply);
        computerCase.AddDevice(CPU);
        computerCase.AddDevice(GPU);
        computerCase.AddDevice(RAM);
        computerCase.AddDevice(SSD);

        computerCase.Start();
    }
}