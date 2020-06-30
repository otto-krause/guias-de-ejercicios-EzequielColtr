using System.Collections.Generic;
using System;

namespace E5
{
    public class SuperMercado
    {
        List<Carrito> supermercado = new List<Carrito>();

        
        public int Ganancias()
        {
            int ganaciasDia = 0;

            foreach (var i in supermercado)
            {
                foreach (var j in i.productosDelCarrito)
                {
                    ganaciasDia += j.Precio;
                }
                
                
            }

            return ganaciasDia;
        }
    
    }

}