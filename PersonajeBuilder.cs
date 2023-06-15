using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder
{
    public class PersonajeBuilder : IPersonajeBuilder
    {
        private Personaje personaje = new Personaje();

        public void ConstruirNombre(string nombre)
        {
            personaje.Nombre = nombre;
        }

        public void ConstruirClase(string clase)
        {
            personaje.Clase = clase;
        }

        public void ConstruirNivel(int nivel)
        {
            personaje.Nivel = nivel;
        }

        public void ConstruirArma(string arma)
        {
            personaje.Arma = arma;
        }

        public void ConstruirArmadura(string armadura)
        {
            personaje.Armadura = armadura;
        }

        public Personaje ObtenerPersonaje()
        {
            return personaje;
        }
    }


    public class Director
    {
        public Personaje ConstruirPersonaje(IPersonajeBuilder builder)
        {
            builder.ConstruirNombre("Ejemplo");
            builder.ConstruirClase("Guerrero");
            builder.ConstruirNivel(10);
            builder.ConstruirArma("Espada");
            builder.ConstruirArmadura("Peto de hierro");

            return builder.ObtenerPersonaje();
        }
    }


}
