namespace EjerciciosEric20Estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstructuraControl control1 = new EstructuraControl();



            Console.WriteLine("Ingresa el dia que quieres saber");
            int dia= Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(control1.DiaSemana(dia));
        }
    }
}