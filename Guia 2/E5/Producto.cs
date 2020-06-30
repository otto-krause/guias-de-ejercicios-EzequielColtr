using System.Collections.Generic;
using System;

namespace E5
{
    public class Producto
    {
        protected string nombre;
        protected int precio;

        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public int Precio { get => precio;}
    }
}