using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void NombreVacio() 
        {
            Person p1 = new Person("Augusto", "5.461.645-1");
            p1.Name = "";
            Assert.AreEqual("Augusto",p1.Name);
        }

        [Test]
        public void NombreNull() 
        {
            Person p1 = new Person("Augusto", "5.461.645-1");
            p1.Name = null;
            Assert.AreEqual("Augusto",p1.Name);
        }

        [Test]
        public void NombreNormal() 
        {
            Person p1 = new Person("Augusto", "5.461.645-1");
            p1.Name = "Normal";
            Assert.AreEqual("Normal",p1.Name);
        }
        
        [Test]
        public void IdIncorrecta() 
        {
            Person p1 = new Person("Augusto", "5.461.645-1");
            p1.ID = "4.334.434-3";
            Assert.AreEqual("5.461.645-1",p1.ID);
        }

        [Test]
        public void IdSinPuntosNiGuiones() 
        {
            Person p1 = new Person("Augusto", "5.461.645-1");
            p1.ID = "54616451";
            Assert.AreEqual("54616451",p1.ID);
        }

        [Test]
        public void IdLetras() 
        {
            Person p1 = new Person("Augusto", "5.461.645-1");
            p1.ID = "kdsjdksjkdsj";
            Assert.AreEqual("5.461.645-1",p1.ID);
        }

    }
}