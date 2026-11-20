namespace Fragmentado._00___Testes
{
    class Protagonista3
    {
        static void Main(string[] args)
        {
            System.Console.Write("Nome do protagonista: ");
            string nome = System.Console.ReadLine() ?? "";

            System.Console.Write("Energia inicial: ");
            int energia = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Dinheiro inicial: ");
            decimal dinheiro = Convert.ToDecimal(System.Console.ReadLine());

            System.Console.Write("Tem estágio ? ");
            bool temEstagio = Convert.ToBoolean(System.Console.ReadLine());

            System.Console.WriteLine("\n=== FICHA DO PROTAGONISTA ===");
            System.Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Energia: {energia}");
            System.Console.WriteLine($"Dinheiro: {dinheiro:F2}");
            System.Console.WriteLine($"Tem estágio: {temEstagio}");
        }
    }
}