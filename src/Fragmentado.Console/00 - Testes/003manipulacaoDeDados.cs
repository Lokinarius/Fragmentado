namespace Fragmentado._00___Testes
{
    class Protagonista2
    {
        static void Main(string[] args)
        {
            double bonusCarisma = 1.567;

            System.Console.Write("Nome do protagonista: ");
            string nome = System.Console.ReadLine() ?? "";

            System.Console.Write("Dinheiro inicial: ");
            decimal dinheiro = Convert.ToDecimal(System.Console.ReadLine());

            System.Console.WriteLine("\n=== FICHA ===");
            System.Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Tamanho do nome: {nome.Length}");
            System.Console.WriteLine($"Dinheiro: {dinheiro:F2}");
            System.Console.WriteLine($"Bônus de carisma: {bonusCarisma:F1}");

            System.Console.WriteLine("\n=== CONVERSÃO ===");

            string a = "10";
            string b = "20";

            System.Console.WriteLine(a + b);
            System.Console.WriteLine(Convert.ToInt32(a) + Convert.ToInt32(b));
        }
    }
}