abstract class VehicleBuilder
{
    protected Vehicle vehicle=null!;

    public Vehicle Vehicle
    {
        get{return vehicle; }
    }
    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void Buildwheels();
    public abstract void BuildDoors();
}

class Vehicle
{
    private string _vehicleType;
    private Dictionary<string, string>_parts=
    new Dictionary<string, string>();
    public Vehicle(string vehicleType)
    {
        this._vehicleType=vehicleType;
    }
    public string this[string key]
    {
        get{return _parts[key];}
        set{_parts[key]=value ;}
    }
    public void Show()
    {
        Console.WriteLine("\n ------------------");
        Console.WriteLine("Vehicle type: {0}",_vehicleType);
        Console.WriteLine("Frame: {0}",_parts["frame"]);
        Console.WriteLine("Engine: {0}",_parts["engine"]);
        Console.WriteLine("Doors: {0}",_parts["doors"]);
        Console.WriteLine("Wheels: {0}",_parts["wheels"]);
    }
}

class Shop
{
    public void Construct(VehicleBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildFrame();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.Buildwheels();
        vehicleBuilder.BuildDoors();
    }
}
class BicycleBuilder : VehicleBuilder
{
    public BicycleBuilder()
    {
        vehicle= new Vehicle("Bicycle");
    }
    public override void BuildDoors()
    {
        vehicle["doors"]="0";
    }
        public override void BuildEngine()
    {
        vehicle["engine"]="0";
    }
        public override void BuildFrame()
    {
        vehicle["frame"]="Bicycle Frame";
    }    
    public override void Buildwheels()
    {
        vehicle["wheels"]="2";
    }
}
class CarBuilder : VehicleBuilder
{
    public CarBuilder()
    {
        vehicle= new Vehicle("Car");
    }
    public override void BuildDoors()
    {
        vehicle["doors"]="4";
    }
        public override void BuildEngine()
    {
        vehicle["engine"]="2500 cc";
    }
        public override void BuildFrame()
    {
        vehicle["frame"]="Car Frame";
    }    
    public override void Buildwheels()
    {
        vehicle["wheels"]="4";
    }
}