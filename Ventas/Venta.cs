using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    internal class Venta
    {
        public int cantidad { get; set; }
        public string Nombreventa { get; set; }
        public int Precio { get; set; }

        public Venta(int cantidad, string Nombreventa, int precio)
        {
            this.cantidad = cantidad;
            this.Nombreventa = Nombreventa;
            this.Precio = precio;

        }
        public void Pago(double precio, int cantidad)
        {
            double total = (cantidad * precio);
        }

    }

}
