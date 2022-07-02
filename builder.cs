abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();

}

class Product
{
    private List<string> _parts = new List<string>();
    public void Add(string part)
    {
        _parts.Add(part);
    }
    public void Show()
    {
        Console.WriteLine("\nProduct Parts -------");
        foreach (string part in _parts)
            Console.WriteLine(part);
    }
}

class Director
{
    public void Construct(Builder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }
}
class ConcreteBuilder_1 : Builder
{
    private Product _product = new Product();
    public override void BuildPartA()
    {
        _product.Add("PartA");
    }
    public override void BuildPartB()
    {
        _product.Add("PartB");
    }
    public override Product GetResult()
    {
        return _product;
    }
}
class ConcreteBuilder_2 : Builder
{
    private Product _product = new Product();
    public override void BuildPartA()
    {
        _product.Add("PartX");
    }
    public override void BuildPartB()
    {
        _product.Add("PartY");
    }
    public override Product GetResult()
    {
        return _product;
    }
}