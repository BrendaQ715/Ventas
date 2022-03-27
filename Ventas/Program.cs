using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ventas
{
    internal class Program
    {
        static string NombreProducto;
        
        static int Nocliente;
        static int cantidad;
        static double precio;
        static double total;
        
        
        
        
        static string[] campos = new string[5];
        
        static void Main(string[] args)

        {    //AgregarTexto();
            //LeerDocumento();
            Menu();
            CrearCompra();
            RegistroCompra();
         
           


        }
        static void Menu()
        { byte  opcion;
            opcion = 0;
           
            do
                {
                Console.WriteLine("---------------PRODUCTOS E INPORTACIONES---------------");
                    Console.WriteLine("Menu de opciones ");
                    Console.WriteLine("1. Venta nueva  ");
                    Console.WriteLine("2. Registro de ventas ");    
                    Console.WriteLine("3.Salir");
                    Console.WriteLine("Que  opcion deseas realizar...");
                    opcion=Convert.ToByte(Console.ReadLine());
                    switch (opcion)
                    {
                    case 1:
                        CrearCompra();

                            break;
                    case 2:
                        RegistroCompra();

                        break;

                    case 3:
                            Console.WriteLine("-------Operacion finalizada-------");
                            break;
                            default:
                            Console.WriteLine("------La opcion no es correcta -------");
                            break;
                    }


            }
            while (opcion != 5);
           

        
        
        }

        public static void CrearCompra()
        {

            StreamWriter venta;


            string ventas = "C:\\Users\\qbren\\Documents\\Ventas\\Registroventas.txt"  ;

            venta = File.AppendText(ventas);
            venta.WriteLine();

           
            Console.WriteLine("Ingresa n° de cliente");
            Nocliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre del producto");
            NombreProducto = Console.ReadLine();

            Console.WriteLine("Cantidad de productos");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("precio de los productos");
            precio = Convert.ToDouble(Console.ReadLine());

            total = precio * cantidad;
            Console.WriteLine("El total de la compra es de:" + total);


            venta.WriteLine("NoCliente:" + Nocliente
                + "Producto:" + NombreProducto 
                + "Cantidad de productos:" + cantidad 
                + "$"+precio  +
                " Total:"+"$" + total );
                Console.WriteLine("Registro de venta relizado...");


            venta.Close();
        }
        public static void RegistroCompra()
        {
            Console.WriteLine("Fecha:");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("----------"+DateTime.Now.ToShortDateString());


            StreamReader venta;
            string ventas = "C:\\Users\\qbren\\Documents\\Ventas\\Registroventas.txt"  ;
            string linea;
            venta = File.OpenText(ventas);
            do
            {
                linea = venta.ReadLine();
                Console.WriteLine(linea);
            }
            while
            
                (linea != null);
            venta.Close();
            Console.WriteLine();
            
            

        }

    
            



        }









    }

