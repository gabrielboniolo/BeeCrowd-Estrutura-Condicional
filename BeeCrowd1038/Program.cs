using System.Globalization;
namespace BeeCrowd1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double total;
            string[] pedido = Console.ReadLine().Split(' ');
            cod = int.Parse(pedido[0]);
            qtd = int.Parse(pedido[1]);

            switch(cod)
            {
                case 1:
                    total = qtd * 4.00;
                    Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    total = qtd * 4.50;
                    Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    total = qtd * 5.00;
                    Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    total = qtd * 2.00;
                    Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    total = qtd * 1.50;
                    Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }
        }
    }
}