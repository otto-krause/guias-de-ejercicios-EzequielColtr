using System.Collections.Generic;
using System;

namespace E7
{
    public class Argentina
    {
        List<Alfajores> alfajores = new List<Alfajores>();

        public Argentina()
        {
            alfajores.Add(new Alfajores("Triple de Fruta",20,"Waymayen"));
            alfajores.Add(new Alfajores("Chocolate blanco",35,"Jorgito"));
            alfajores.Add(new Alfajores("Dulce de leche",40,"Havanna"));
        }
    
        public void BajarElPrecioDelPetroleo()
        {
            foreach (var i in alfajores)
            {
                i.precio += 80;
            }
        }

        public void MillaiHabla()
        {
            foreach (var i in alfajores)
            {
                i.precio = i.precio * 2;
            }
        }

        public void CoronaVainas()
        {
            foreach (var i in alfajores)
            {
                if(i.nombreEmpresa != "Waymayen")
                {
                    i.precio += 1000;
                }
            }
        }

        public string EstadoDeInflacion()
        {
            int precioAlfajores = 0;

            foreach (var i in alfajores)
            {
                precioAlfajores += i.precio;
            }

            if(precioAlfajores < 500)
            {
                return "Normal";
            }
            else if(precioAlfajores > 500 && precioAlfajores < 1000)
            {
                return "Super";
            }
            else
            {
                return "Hyper";
            }
        }

        public bool EstadoDefault()
        {
            int precioAlfajores = 0;

            foreach (var i in alfajores)
            {
                precioAlfajores += i.precio;
            }

            foreach (var i in alfajores)
            {
                foreach (var j in alfajores)
                {
                    if(i.nombre != j.nombre)
                    {
                        return false;
                    }
                }
            }

           
            return precioAlfajores > 1000;
            

        }
    
    }

}