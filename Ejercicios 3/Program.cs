using System;

namespace SistemaProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto();
            producto.Nombre = "Laptop";
            producto.Precio = 45000;

            Console.WriteLine("=== Encapsulamiento ===");
            Console.WriteLine("Nombre: " + producto.Nombre);
            Console.WriteLine("Precio: RD$" + producto.Precio);

            Console.WriteLine();

            ProductoElectronico electronico = new ProductoElectronico();
            electronico.Nombre = "Laptop HP";
            electronico.Marca = "HP";

            ProductoAlimenticio alimento = new ProductoAlimenticio();
            alimento.Nombre = "Leche";
            alimento.FechaVencimiento = "15/12/2026";

            Inventario inventario = new Inventario();

            Console.WriteLine("=== Polimorfismo ===");
            inventario.MostrarProducto(electronico);

            Console.WriteLine();

            inventario.MostrarProducto(alimento);

            Console.ReadKey();
        }
    }

    public class Producto
    {
        private string nombre = "";
        private double precio;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
            }
        }
    }

    public abstract class ProductoBase
    {
        public string Nombre { get; set; } = "";

        public abstract void MostrarInformacion();
    }

    public class ProductoElectronico : ProductoBase
    {
        public string Marca { get; set; } = "";

        public override void MostrarInformacion()
        {
            Console.WriteLine("Producto Electrónico");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Marca: " + Marca);
        }
    }

    public class ProductoAlimenticio : ProductoBase
    {
        public string FechaVencimiento { get; set; } = "";

        public override void MostrarInformacion()
        {
            Console.WriteLine("Producto Alimenticio");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Fecha de vencimiento: " + FechaVencimiento);
        }
    }

    public class Inventario
    {
        public void MostrarProducto(ProductoBase producto)
        {
            producto.MostrarInformacion();
        }
    }
}