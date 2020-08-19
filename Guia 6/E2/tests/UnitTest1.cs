using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace tests
{
    public class Tests
    {

        //HARRY
        VaritaMagica VaritaDeHarry;

        List<string> pasosHarry;
        List<Ingrediente> ingredientesHarry;
        List<string> pasosHarry1;
        List<Ingrediente> ingredientesHarry1;
        List<Receta> recetasHarry;
        

        Mago Harry;

        [SetUp]
        public void Setup()
        {
            VaritaDeHarry = new VaritaMagica("Carpe",0);

            ingredientesHarry = new List<Ingrediente>();
            ingredientesHarry.Add(new Ingrediente(400));
            ingredientesHarry.Add(new Ingrediente(400));
            ingredientesHarry.Add(new Ingrediente(400));

            pasosHarry = new List<string>{"Prender el fuego", "Poner Agua", "Comer"};

            ingredientesHarry1 = new List<Ingrediente>();
            ingredientesHarry1.Add(new Ingrediente(400));
            ingredientesHarry1.Add(new Ingrediente(400));
            ingredientesHarry1.Add(new Ingrediente(400));

            pasosHarry1 = new List<string>{"Prender el Agua", "Poner Fuego", "Bailar"};

            recetasHarry = new List<Receta>();
            recetasHarry.Add(new Receta(ingredientesHarry1, pasosHarry1));
        }

        [Test]
        public void TestSaberSiTodasLasRecetasSonDeGordo()
        {
            recetasHarry.ForEach(Receta => Assert.True(Receta.esDeGordo()));
        }
    }
}