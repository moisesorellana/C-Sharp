using System;
using System.Collections.Generic;

public class Orden
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeOrden { get; set; }
    public Cliente Cliente { get; set; }
    public Vendedor Vendedor { get; set; }
     public int Subtotal {get; set;}
    public double Impuesto { get; set;}

    public List<OrdenDetalle> ListaOrdenDetalle { get; set; }
    public double Total { get; set; }

    public Orden(int codigo, DateTime fecha, string numeroOrden, Cliente cliente, Vendedor vendedor, int subtotal, double impuesto)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = numeroOrden;
        Cliente = cliente;
        Vendedor = vendedor;
        Subtotal = subtotal;
        Impuesto = impuesto;
        ListaOrdenDetalle = new List<OrdenDetalle>();
    }

    public void AgregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaOrdenDetalle.Count + 1;
        int cantidad = 1;

        OrdenDetalle o = new OrdenDetalle(nuevoCodigo, 1, producto, Subtotal, Impuesto);
        ListaOrdenDetalle.Add(o);

        Total += cantidad * (producto.Precio*Impuesto);
        Impuesto+= (cantidad * producto.Precio*0.25); 
    }
}