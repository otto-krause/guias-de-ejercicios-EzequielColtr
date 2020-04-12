using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;

            CamFrontal camFrontal = new CamFrontal(8, 10);
            CamTrasera camTrasera = new CamTrasera(12, 40);

            Celular Pixel3a = new Celular(true, true, 64000, 11);
            
            

            Console.WriteLine(" [1] Para saber el peso por foto\n [2] Para saber el peso total de las fotos\n [3] Para saber la memoria disponible\n [4] Para saber si puede cargar la sube");
            id = Int32.Parse(Console.ReadLine());


            switch(id)
            {
                case 1:
                {
                    Console.WriteLine("Una foto frontal pesa: " + camFrontal.PesoPorFoto() + "MB");
                    Console.WriteLine("Una foto trasera pesa: " + camTrasera.PesoPorFoto() + "MB");

                    break;
                }
                case 2:
                {
                    Console.WriteLine("Todas las fotos de la camara frontal pesan: " + camFrontal.PesoTotalDeFotos() + "MB");
                    Console.WriteLine("Todas las fotos de la camara trasera pesan: " + camTrasera.PesoTotalDeFotos() + "MB");

                    break;
                }
                case 3:
                {
                    Console.WriteLine("Memoria disponible en el celular: " + Pixel3a.MemoriaDisponible(camFrontal.PesoTotalDeFotos(), camTrasera.PesoTotalDeFotos()) + "MB");
                    break;
                }
                case 4:
                {
                    if(Pixel3a.TeCargaLaSUBE())
                    {
                        Console.WriteLine("Te carga la sube el celular");
                    }
                    break;
                }
            }


        }
    }
}
