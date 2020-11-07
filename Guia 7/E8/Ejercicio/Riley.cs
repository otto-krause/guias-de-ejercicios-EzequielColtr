using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Riley
    {
        int felicidad;

        string emocionDominante;

        List<Recuerdo> recuerdosDelDia;

        List<Recuerdo> pensamientosCentrales;

        List<Recuerdo> memoriaDeLargoPlazo;

        public Riley(string emocionDominante)
        {
            felicidad = 1000;
            this.emocionDominante = emocionDominante;
            recuerdosDelDia = new List<Recuerdo>();
            pensamientosCentrales = new List<Recuerdo>();
            memoriaDeLargoPlazo = new List<Recuerdo>();
        }

        public List<Recuerdo> recuerdosRecientes()
        {
            return recuerdosDelDia.Take(5).ToList();
        }

        /*public List<Recuerdo> pensamientosCentralesDificilesDeExplicar()
        {
            return recuerdosDelDia.Where(Recuerdo => Recuerdo.Descripcion.Split(" ").Length > 10);
        }*/

        public void vivirEvento(string descripcion, int fecha)
        {
            recuerdosDelDia.Add(new Recuerdo(descripcion,fecha,emocionDominante));
        }

        public void Dormir(int fechaIngresada, string palabraClaveIngresada)
        {
            AsentamientoDormido(fechaIngresada);
            AsentamientoSelectivoDormido(palabraClaveIngresada);
            Profundizacion();
            ControlHormonal();
            RestaruacionCognitiva();
            LiberacionDeRecuerdosDelDia();
        }

        private void asentarRecuerdo(int idRecuerdo)
        {
            if(recuerdosDelDia[idRecuerdo].EmocionDominanteActual == "Alegre" && felicidad > 500 && emocionDominante != "Triste")
            {
                pensamientosCentrales.Add(recuerdosDelDia[idRecuerdo]);
            }
            else if(recuerdosDelDia[idRecuerdo].EmocionDominanteActual == "Triste" && emocionDominante != "Alegre")
            {
                pensamientosCentrales.Add(recuerdosDelDia[idRecuerdo]);
                felicidad -= (felicidad*100)/10;
            }
        }

        private void AsentamientoDormido(int fechaActual)
        {
            int j = 0;
            foreach (var i in recuerdosDelDia)
            {
                asentarRecuerdo(j);
                j++;
            }
        }

        private void AsentamientoSelectivoDormido(string palabraClave)
        {
            int k = 0;
            foreach (var i in recuerdosDelDia)
            {
                foreach (var j in i.Descripcion.Split(" "))
                {
                    if(j == palabraClave)
                        asentarRecuerdo(k);
                }
                k++;
            }
        }

        private void Profundizacion()
        {
            if(emocionDominante == "Alegre")
            {
                foreach (var i in recuerdosDelDia)
                {
                    if(i.EmocionDominanteActual == "Alegre")
                        memoriaDeLargoPlazo.Add(i);
                }
            }
            else if(emocionDominante == "Triste")
            {
                foreach (var i in recuerdosDelDia)
                {
                    if(i.EmocionDominanteActual != "Alegre")
                        memoriaDeLargoPlazo.Add(i);
                }
            }
        }

        private void ControlHormonal()
        {

            bool todosLosRecuerdosDelDiaMismaEmocion = true;

            foreach (var i in recuerdosDelDia)
            {
                if(i.EmocionDominanteActual != recuerdosDelDia[0].EmocionDominanteActual)
                    todosLosRecuerdosDelDiaMismaEmocion = false;
            }

            foreach (var i in pensamientosCentrales)
            {
                foreach (var j in memoriaDeLargoPlazo)
                {
                    if(i.Descripcion == j.Descripcion || todosLosRecuerdosDelDiaMismaEmocion == true)
                        felicidad -= (felicidad*100)/15;
                        pensamientosCentrales.RemoveRange(pensamientosCentrales.Count - 3, pensamientosCentrales.Count);
                }
            }
        }
    
        private void RestaruacionCognitiva()
        {
            if(felicidad + 100 <= 1000)
                felicidad += 100;
        }

        private void LiberacionDeRecuerdosDelDia()
        {
            recuerdosDelDia.Clear();
        }

    }
}
