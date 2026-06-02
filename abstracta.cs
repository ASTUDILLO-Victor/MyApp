
Circulo circulo = new Circulo(5);
Rectangulo rectangulo = new Rectangulo(4, 6);
Console.WriteLine(circulo.MostrarInfo());
Console.WriteLine(rectangulo.MostrarInfo());

if (circulo.EsMasGrandeQue(rectangulo))
    Console.WriteLine("\nEl círculo es más grande");
else
    Console.WriteLine("\nEl rectángulo es más grande");

interface IComparable
{
    bool EsMasGrandeQue(Figura otra);
}

abstract class Figura 
{
    public string Color { get; set; } = "";
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
    public virtual string MostrarInfo()
    {
        double area = CalcularArea();
        double perimetro = CalcularPerimetro();
        string info = $"\nÁrea: {area}\nPerímetro: {perimetro}";
        return info;
    }

    
}

class Circulo : Figura, IComparable
{
    public double Radio { get; set; }

    public Circulo(double radio) { Radio = radio; }
    public override double CalcularArea()
    {
        double area = Math.Round(Math.PI * Radio * Radio, 2);
        return area;
    }
    public override double CalcularPerimetro()
    {
        double perimetro = Math.Round(2 * Math.PI * Radio, 2);
        return perimetro;
    }

    public override string MostrarInfo()
    {
        string infoBase = base.MostrarInfo();
        string info = $"=== Círculo ===\n{infoBase}";
        return info;
    }

    public bool EsMasGrandeQue(Figura otra)
    {
        return this.CalcularArea() > otra.CalcularArea();
    }
}

class Rectangulo : Figura, IComparable
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    // OBLIGATORIO implementar CalcularArea
    public override double CalcularArea()
    {
        double area = Math.Round(Ancho * Alto, 2);
        return area;
    }
    public override double CalcularPerimetro()
    {
        double perimetro = Math.Round(2 * (Ancho + Alto), 2);
        return perimetro;
    }
    public override string MostrarInfo()
    {
        string infoBase = base.MostrarInfo();
        string info = $"=== Rectángulo ===\n{infoBase}";
      
        return info;
    }

    public bool EsMasGrandeQue(Figura otra)
    {
        return this.CalcularArea() > otra.CalcularArea();
    }
}