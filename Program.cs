using PatronBuilder;

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();
        IPersonajeBuilder builder = new PersonajeBuilder();

        Personaje personaje = director.ConstruirPersonaje(builder);
        Console.WriteLine(personaje);

        Console.ReadLine();
    }
}