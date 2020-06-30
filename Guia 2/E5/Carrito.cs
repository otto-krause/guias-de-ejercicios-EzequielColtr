using System.Collections.Generic;
using System;

namespace E5
{
    public class Carrito
    {
        List<Producto> carrito = new List<Producto>();

        public Carrito(List<Producto> carrito)
        {
            this.carrito = carrito;
        }

        public List<Producto> productosDelCarrito { get => carrito;}
    }
}