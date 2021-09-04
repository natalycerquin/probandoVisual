using Examen1;
using NUnit.Framework;

namespace TestExamen
{
    public class JugarTest
    {
       

        [Test]
        public void Judada1()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Tijera";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Papel";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Nataly", result);

        }
        [Test]
        public void Judada2()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Tijera";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Piedra";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Pepito", result);

        }
        [Test]
        public void Judada3()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Tijera";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Tijera";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Empate", result);

        }
        [Test]
        public void Judada()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Papel";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Tijera";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Pepito", result);

        }
        [Test]
        public void Judada4()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Papel";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Piedra";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Nataly", result);

        }
        [Test]
        public void Judada5()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Papel";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Papel";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Empate", result);

        }
        [Test]
        public void Judada6()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Piedra";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Papel";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Pepito", result);

        }
          [Test]
        public void Judada7()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Piedra";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Tijera";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Nataly", result);

        }
        [Test]
        public void Judada8()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Piedra";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Piedra";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Empate", result);

        }
        [Test]
        public void Judada9()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Jose";
            jugador1.Eleccion = "Tijera";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Juan";
            jugador2.Eleccion = "Papel";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Jose", result);

        }
        [Test]
        public void Judada10()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Jose";
            jugador1.Eleccion = "Tijera";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Juan";
            jugador2.Eleccion = "Piedra";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Juan", result);

        }
        [Test]
        public void Judada11()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Jose";
            jugador1.Eleccion = "Tijera";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Juan";
            jugador2.Eleccion = "Tijera";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Empate", result);

        }
        [Test]
        public void Judada12()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Jose";
            jugador1.Eleccion = "Papel";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Tijera";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Pepito", result);

        }
        [Test]
        public void Judada13()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Jose";
            jugador1.Eleccion = "Papel";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Piedra";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Jose", result);

        }
        [Test]
        public void Judada14()
        {

            var ju = new Jugador();

            var jugador1 = new jugadorClass();
            jugador1.Nombre = "Nataly";
            jugador1.Eleccion = "Papel";

            var jugador2 = new jugadorClass();
            jugador2.Nombre = "Pepito";
            jugador2.Eleccion = "Papel";

            var result = ju.VerGanador(jugador1, jugador2);

            Assert.AreEqual("Empate", result);

        }
    }
}