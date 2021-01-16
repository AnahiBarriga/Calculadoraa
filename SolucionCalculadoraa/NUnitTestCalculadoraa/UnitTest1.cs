using NUnit.Framework;
using WebCalculadoraa.Properties.Controllers;

namespace NUnitTestCalculadoraa
{
    public class TestCalculadoraa
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumaPost1()
        {
            //Arrange=preparacion
            int a = 5;
            int b = 7;
            int esperado = 12;
            CalculadoraaController calc = new CalculadoraaController();


            //Act=ejecucion
            int resultado = calc.sumapost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

           [Test]
            public void TestSumaPost2()
            {
                //Arrange=preparacion
                int a = 4;
                int b = 4;
                int esperado = 8;
                CalculadoraaController calc = new CalculadoraaController();


                //Act=ejecucion
                int resultado = calc.sumapost(a, b);

                //Assert=verificacion
                Assert.AreEqual(esperado, resultado);

            }

        [Test]
        public void TestSumaPost3()
        {
            //Arrange=preparacion
            int a = 7;
            int b = 9;
            int esperado = 16;
            CalculadoraaController calc = new CalculadoraaController();


            //Act=ejecucion
            int resultado = calc.sumapost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaGet1()
        {
            //Arrange=preparacion
            int a = 5;
            int b = 7;
            int esperado = 12;
            CalculadoraaController calc = new CalculadoraaController();


            //Act=ejecucion
            int resultado = calc.sumaget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestSumaGet2()
        {
            //Arrange=preparacion
            int a = 63;
            int b = 7;
            int esperado = 70;
            CalculadoraaController calc = new CalculadoraaController();


            //Act=ejecucion
            int resultado = calc.sumaget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestSumaGet3()
        {
            //Arrange=preparacion
            int a = 5;
            int b = 5;
            int esperado = 10;
            CalculadoraaController calc = new CalculadoraaController();


            //Act=ejecucion
            int resultado = calc.sumaget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }



        [Test]
        public void TestRestaPost1()
        {
            //Arrange=preparacion
            int a = 5;
            int b = 4;
            int esperado = 1;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.restapost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestRestaPost2()
        {
            //Arrange=preparacion
            int a = 5;
            int b = 4;
            int esperado = 1;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.restapost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestRestaPost3()
        {
            //Arrange=preparacion
            int a = 9;
            int b = 4;
            int esperado = 5;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.restapost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestRestaGet1()
        {
            //Arrange=preparacion
            int a = 5;
            int b = 1;
            int esperado = 4;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.restaget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestRestaGet2()
        {
            //Arrange=preparacion
            int a = 9;
            int b = 4;
            int esperado = 5;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.restaget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestRestaGet3()
        {
            //Arrange=preparacion
            int a = 45;
            int b = 1;
            int esperado = 44;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.restaget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestMultiPost1()
        {
            //Arrange=preparacion
            int a = 3;
            int b = 4;
            int esperado = 12;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.multipost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

       

        [Test]
        public void TestMultiPost2()
        {
            //Arrange=preparacion
            int a = 6;
            int b = 3;
            int esperado = 18;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.multipost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestMultiPost3()
        {
            //Arrange=preparacion
            int a = 9;
            int b = 9;
            int esperado = 81;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.multipost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestMultiGet1()
        {
            //Arrange=preparacion
            int a = 6;
            int b = 4;
            int esperado = 24;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.multiget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestMultiGet2()
        {
            //Arrange=preparacion
            int a = 7;
            int b = 4;
            int esperado = 28;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.multiget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestMultiGet3()
        {
            //Arrange=preparacion
            int a = 6;
            int b = 9;
            int esperado = 54;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            int resultado = calc.multiget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }



        [Test]
        public void TestDivisionPost1()
        {
            //Arrange=preparacion
            float a = 8;
            float b = 4;
            float esperado = 2;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            float resultado = calc.divisionpost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestDivisionPost2()
        {
            //Arrange=preparacion
            float a = 40;
            float b = 5;
            float esperado = 8;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            float resultado = calc.divisionpost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestDivisionPost3()
        {
            //Arrange=preparacion
            float a = 60;
            float b = 10;
            float esperado = 6;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            float resultado = calc.divisionpost(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestDivisionGet1()
        {
            //Arrange=preparacion
            float a = 20;
            float b = 5;
            float esperado = 4;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            float resultado = calc.divget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestDivisionGet2()
        {
            //Arrange=preparacion
            float a = 18;
            float b = 6;
            float esperado = 3;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            float resultado = calc.divget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestDivisionGet3()
        {
            //Arrange=preparacion
            float a = 200;
            float b = 5;
            float esperado = 40;
            CalculadoraaController calc = new CalculadoraaController();

            //Act=ejecucion
            float resultado = calc.divget(a, b);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
















    }
}
