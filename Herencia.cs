Producto producto1 = new Producto("Laptop", 999.99, 10);
producto1.Precio = -100;
producto1.Stock = -5;
producto1.Nombre = "";vvvv
vvv
Producto producto2 = new Producto("Smartphone", 499.99, 20);

Console.WriteLine("=== Producto 1 ===");
Console.WriteLine(producto1.MostrarInfo());
Console.WriteLine("\n=== Producto 2 ===");
Console.WriteLine(producto2.MostrarInfo());
class Producto
{
    public string Nombre { get;set;}="";

    private double _precio = 0;
    public double Precio
    {
        get{ return _precio; }
        set
        {
            if (value >= 0)
            {
                _precio = value;
            }
            else
            {
                Console.WriteLine("El precio no puede ser negativo.");
            }
        }
    }
    private int _stock = 0;
    public int Stock
    {
        get{ return _stock; }
        set
        {
            if (value >= 0)
            {
                _stock = value;
            }
            else
            {
                Console.WriteLine("El stock no puede ser negativo.");
            }
        }
    }

    public Producto(string nombre, double precio, int stock)
    {
        this.Nombre = nombre;
        this.Precio = precio;
        this.Stock = stock;
    }

    public string MostrarInfo()
    {
        string info = $"Producto: {Nombre}\nPrecio: ${Precio}\nStock: {Stock} unidades";
        return info;
    }

}