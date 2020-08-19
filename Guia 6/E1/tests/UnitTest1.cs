using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;

namespace tests
{
    public class Tests
    {
        //ROBIN
        private Arma bastonDeMetal;
        private Arma bombasDeHumo;
        private Robin robin;
        List<Arma> arsenal;

        //RAVEN
        List<string> pensamientos;
        private Raven raven;
        
        //CHICOBESTIA
        private ChicoBestia chicobestia;

        [SetUp]
        public void Setup()
        {
            //ROBIN
            bastonDeMetal = new Arma(10,15);
            bombasDeHumo = new Arma(89,14);
            arsenal = new List<Arma> {bastonDeMetal,bombasDeHumo};
            robin = new Robin(arsenal,10);

            //RAVEN
            pensamientos = new List<string> {"Extraño a mi Papi","Me quedé sin MANTECA","Perdí a Pipo","Voy a comprar pilas para Robocop","¿Donde esta Pipo?"};
            raven = new Raven(2,pensamientos,0);

            //CHICOBESTIA
            chicobestia = new ChicoBestia("Verde",2);

        }

        [Test]
        public void TestRavenSeCome4PizzasYsiEstaTriste()
        {
            raven.comePizza(4);
            Assert.True(raven.estaTriste());
        }

        [Test]
        public void TestBestiaComePizzaYconocerPoder()
        {
            chicobestia.comePizza(0);
            Assert.AreEqual(871,chicobestia.poder());
        }

        [Test]
        public void TestConocerElPoderDeBastonDeMetal()
        {
            Assert.AreEqual(620,bastonDeMetal.Fuerza());
        }

        [Test]
        public void TestBestiaComePizzaPoderDeRavenMayorAlResto()
        {
            chicobestia.comePizza(0);

            Assert.False(raven.poder() > chicobestia.poder());
            Assert.False(raven.poder() > robin.poder());
        }

        [Test]
        public void TestBestiaLloraPorRobocopNivelDeTristeza0()
        {
            chicobestia.llorarPorRobocop();

            Assert.AreEqual(0,chicobestia.Tristeza);
        }

        [Test]
        public void TestRobinLlora2vecesCalcularPoder()
        {
            robin.llorarPorRobocop();
            robin.llorarPorRobocop();

            Assert.AreEqual(598,robin.poder());
        }

        public void TestRavenLloraYverSiEstaTriste()
        {
            raven.llorarPorRobocop();

            Assert.False(raven.estaTriste());
        }
    }
}