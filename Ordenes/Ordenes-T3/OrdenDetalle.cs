public class OrdenDetalle
{
    public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public Producto Producto { get; set; }
    public int Subtotal {get; set;}
    public double Impuesto {get; set;}


    public OrdenDetalle(int codigo, int cantidad, Producto producto, int subtotal, double impuesto)
    {
        Codigo = codigo;
        Cantidad = cantidad;
        Producto = producto;
        Precio = producto.Precio;
        Subtotal = subtotal;
        Impuesto = impuesto;

    }
}