using NUnit.Framework;
using Ejercicio;
using System;

namespace Testing
{
    public class Tests
    {

        private Niño Pepe;
        private Niño Juan;
        private Adulto PapáPepe;
        private Adulto PapáJuan;

        private Legion LegionTerror;

        [SetUp]
        public void Setup()
        {
            Pepe = new Niño(5,"Tierno");
            Juan = new Niño(4,"Terrorificos");

            PapáJuan = new Adulto(30,5,"Comun");
            PapáPepe = new Adulto(25,3,"Abuelo");

            LegionTerror = new Legion(Pepe,Juan);
        }

        [Test]
        public void ObtenerLaCapacidadDeAsustarNiño()
        {
            Assert.AreEqual(32,Juan.CapacidadAsustar);
        }

        [Test]
        public void PepeAsustaAsuPapaYobtieneCaramelos()
        {
            Pepe.asustar(PapáPepe);
            Assert.AreEqual(15,Pepe.Caramelos);
        }

        [Test]
        public void CrearUnaLegionYasustarAlPapáDeJuan()
        {
            LegionTerror.asustar(PapáJuan);
        }
    }
}