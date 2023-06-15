using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Personaje
{
    public string Nombre { get; set; }
    public string Clase { get; set; }
    public int Nivel { get; set; }
    public string Arma { get; set; }
    public string Armadura { get; set; }

    public override string ToString()
    {
        return $"Personaje - Nombre: {Nombre}, Clase: {Clase}, Nivel: {Nivel}, Arma: {Arma}, Armadura: {Armadura}";
    }
}

public interface IPersonajeBuilder
{
    void ConstruirNombre(string nombre);
    void ConstruirClase(string clase);
    void ConstruirNivel(int nivel);
    void ConstruirArma(string arma);
    void ConstruirArmadura(string armadura);
    Personaje ObtenerPersonaje();
}

