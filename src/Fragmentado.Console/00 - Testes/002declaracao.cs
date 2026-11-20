namespace Fragmentado._00___Testes
{
    class Protagonista
    {
        static void Main(string[] args)
        {
            string nome = "Loki";
            int energia = 100;
            decimal dinheiro = 250.50m;
            double bonusCarisma = 1.5;
            char teclaAcao = 'T';
            long experienciaMMO = 5000000;
            bool temEstagio = false;

            sbyte maxSByte = sbyte.MaxValue;
            byte maxByte = byte.MaxValue;
            short maxShort = short.MaxValue;
            long maxLong = long.MaxValue;

            System.Console.WriteLine("=== FICHA DO PROTAGONISTA ===");
            System.Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Energia: {energia}");
            System.Console.WriteLine($"Dinheiro: {dinheiro}");
            System.Console.WriteLine($"Bônus de carisma: {bonusCarisma}");
            System.Console.WriteLine($"Tecla de ação: {teclaAcao}");
            System.Console.WriteLine($"Experiência MMO: {experienciaMMO}");
            System.Console.WriteLine($"Tem estágio: {temEstagio}");

            System.Console.WriteLine("\n=== VALORES MÁXIMOS ===");
            System.Console.WriteLine($"sbyte.MaxValue: {maxSByte}");
            System.Console.WriteLine($"byte.MaxValue: {maxByte}");
            System.Console.WriteLine($"short.MaxValue: {maxShort}");
            System.Console.WriteLine($"long.MaxValue: {maxLong}");
        }
    }
}