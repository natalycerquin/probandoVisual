using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1
{
    public class Jugador
    {
        public string VerGanador(jugadorClass jugador1, jugadorClass jugador2)
        {

            var eleccion1 = jugador1.Eleccion;
            var eleccion2 = jugador2.Eleccion;


            if (eleccion1.Equals("Tijera") && eleccion2.Equals("Papel"))
            {
                return jugador1.Nombre;
            }
             
            if (eleccion1.Equals("Papel") && eleccion2.Equals("Tijera"))
            {
                return jugador2.Nombre;
            }



            if (eleccion1.Equals("Tijera") && eleccion2.Equals("Piedra"))
            {
                return jugador2.Nombre;
            }

            if (eleccion1.Equals("Piedra") && eleccion2.Equals("Tijera"))
            {
                return jugador1.Nombre;
            }



            if (eleccion1.Equals("Papel") && eleccion2.Equals("Piedra"))
            {
                return jugador1.Nombre;
            }
            if (eleccion1.Equals("Piedra") && eleccion2.Equals("Papel"))
            {
                return jugador2.Nombre;
            }




            if (eleccion1.Equals("Papel") && eleccion2.Equals("Papel"))
                return "Empate";

            if (eleccion1.Equals("Tijera") && eleccion2.Equals("Tijera"))
                return "Empate";

            if (eleccion1.Equals("Piedra") && eleccion2.Equals("Piedra"))
                return "Empate";

            return "Empate";

        }
    }
}
