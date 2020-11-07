using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Villano
    {
        List<Minion> minions = new List<Minion>();

        public Villano(List<Minion> minions)
        {
            this.minions = minions;
        }

        public void nuevoMinion(List<Arma> armas, int bananas, string estado)
        {
            Arma armaCongelante = new Arma("armaCongelante", 10);
            
            List<Arma> armasDelMinion = new List<Arma>();
            armasDelMinion.Add(armaCongelante);

            Minion minion = new Minion(armasDelMinion,5,"Amarillo");
            minions.Add(minion);
        }

        public void otorgarArma(Arma armaNueva, int idMinion)
        {
            minions[idMinion].Armas.Add(armaNueva);
        }

        public void alimentarMinion(int bananas, int idMinion)
        {
            minions[idMinion].Bananas += bananas;
        }

        public int devuelveConcentracion(int idMinion)
        {
            return minions[idMinion].Concentracion;
        }

        public bool esPeligroso(int idMinion)
        {
            if(minions[idMinion].Estado == "Amarillo")
                return minions[idMinion].Armas.Count > 2;
            else
                return true;
        }

        public void Congelar(List<int> MinionsAsignados, Ciudad ciudad)
        {
            bool todosEquipadosConArmasCongelates = false;
            int concentracionNecesaria = 0;
            
            //Revisa que todos los minions tengan armas congelantes
            foreach (var i in MinionsAsignados)
            {
                foreach (var j in minions[i].Armas)
                {
                    if(j.Nombre != "ArmaRayoCongelante")
                        todosEquipadosConArmasCongelates = true;
                }
            //Suma todas las concentraciones 
                concentracionNecesaria += minions[i].Concentracion;
            }

            if(todosEquipadosConArmasCongelates && concentracionNecesaria >= 500)
            {
                foreach (var i in MinionsAsignados)
                {
                
                    minions[i].Bananas += 10;
                    minions[i].MaldadesHechas += 1;
                
                }

                ciudad.Temperatura -= 30;; 
            }
        }

        public void Robar(List<int> MinionsAsignados, Ciudad ciudad, string Robo)
        {
            int concentracionNecesaria = 0;
            int bananasNecesarias = 0;

            switch(Robo)
            {
                case "Piramide":
                {
                    if(ciudad.ExistePiramide)
                    {
                        foreach (var i in MinionsAsignados)
                        {
                            concentracionNecesaria += minions[i].Concentracion;
                        }

                        if(concentracionNecesaria > ciudad.AlturaPiramide/2)
                        {
                            foreach (var i in MinionsAsignados)
                            {
                            
                                minions[i].Bananas += 10;
                                minions[i].MaldadesHechas += 1;
                            
                            }
                            
                            ciudad.ExistePiramide = false;
                        }
                    }
                    break;
                }
                case "SueroMutante":
                {
                    if(ciudad.ExisteSueroMutante)
                    {
                        foreach (var i in MinionsAsignados)
                        {
                            concentracionNecesaria += minions[i].Concentracion;
                            bananasNecesarias += minions[i].Bananas;
                        }

                        if(concentracionNecesaria >= 23 && bananasNecesarias >= 100)
                        {

                            ciudad.ExisteSueroMutante = false;

                            foreach (var i in MinionsAsignados)
                            {
                                minions[i].tomarSuero();
                                minions[i].MaldadesHechas += 1;
                            }
                        }
                    }
                    break;
                }
                case "Luna":
                {
                    bool todosEquipadosConArmasEncogedoras = false;

                    foreach (var i in MinionsAsignados)
                    {
                        foreach (var j in minions[i].Armas)
                        {
                            if(j.Nombre != "ArmaRayoEncongedor")
                                todosEquipadosConArmasEncogedoras = true;
                        }
                    }

                    if(todosEquipadosConArmasEncogedoras)
                    {
                        ciudad.ExisteLuna1 = false;

                        Arma ArmaRayoEncongedor = new Arma("ArmaRayoEncongedor", 10);

                        foreach (var i in minions)
                            i.Armas.Add(ArmaRayoEncongedor);

                        foreach (var i in MinionsAsignados)
                            minions[i].MaldadesHechas += 1;
                    }

                    break;

                }
            }
        }

        public Minion minionMasUtil()
        {
            return minions.OrderByDescending(Minion => Minion.MaldadesHechas).First();
        }

        public List<Minion> minionsInutiles()
        {
            return minions.Where(Minion => Minion.MaldadesHechas == 0).ToList();
        }

    }
}
