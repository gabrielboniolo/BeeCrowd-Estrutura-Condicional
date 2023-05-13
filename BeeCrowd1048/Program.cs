using System.Globalization;
namespace BeeCrowd1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste;
            int percentual;
            reajuste = 0.0;
            percentual = 0;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario < 400.01) {
                percentual = 15;
                reajuste = (15.0 / 100.0) * salario;
                salario += reajuste;
            }
            else if (salario < 800.01) {
                percentual = 12;
                reajuste = (12.0 / 100.0) * salario;
                salario += reajuste;
            }
            else if (salario < 1200.01) {
                percentual = 10;
                reajuste = (10.0 / 100.0) * salario;
                salario += reajuste;
            }
            else if (salario < 2000.01) {
                percentual = 7;
                reajuste = (7.0 / 100.0) * salario;
                salario += reajuste;
            }
            else {
                percentual = 4;
                reajuste = (4.0 / 100.0) * salario;
                salario += reajuste;
            }

            Console.WriteLine("Novo salario: {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0}%", percentual);

        }
    }
}