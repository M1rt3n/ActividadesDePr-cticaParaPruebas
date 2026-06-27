using ConsoleApp2;
internal class Program
{
    static void Main(string[] args)
    {
        List<Instrumento> equipo = new List<Instrumento>();
        equipo.Add(new Guitarra("Fender", 8));
        equipo.Add(new Piano("SteinWay", 2));
        equipo.Add(new Guitarra("Yamaha", 4));
        Console.WriteLine("\n--- Ensayo: ---");
        foreach (Instrumento v in equipo)
        {
            Console.WriteLine(v.TocarNota());
        }
    }
}