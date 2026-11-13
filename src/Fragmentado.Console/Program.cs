Console.WriteLine("=== Fragmentado");
Console.WriteLine("Dia 1 - Segunda-feira, manhã");


// VARIÁVEIS E TIPOS DE DADOS
string nome = "Protagonista";
int energia = 100;
int sanidade = 70;
decimal dinheiro = 50.0m;

Console.WriteLine(0.1 + 0.2); // double
Console.WriteLine(0.1m + 0.2m); // decimal

// A primeira imprime 0.30000000000000004 e a segunda 0.3. O double guarda aproximações em binário, enquanto o decimal guarda números em base 10 com exatidão. Por isso dinheiro é sempre decimal.

// INTERPOLAÇÃO DE STRINGS
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Energia: {energia}");
Console.WriteLine($"Sanidade: {sanidade}");
Console.WriteLine($"Dinheiro: R${dinheiro:F2}"); // F2 formata o decimal com 2 casas

// OPERAÇÕES ARITIMETICAS
energia -= 10;
sanidade -= 5;
dinheiro += 20.5m;

Console.WriteLine($"Energia: {energia}");
Console.WriteLine($"Sanidade: {sanidade}");
Console.WriteLine($"Dinheiro: R${dinheiro:F2}");

// OPERADORES DE COMPARAÇÃO
bool cansado = energia <= 0;
bool esgotado = energia <= 0 || sanidade <= 0;
bool fragmentado = sanidade <= 0;
bool quebrado = dinheiro <= 0;
Console.WriteLine($"Esgotado? {esgotado} | Fragmentado? {fragmentado} | Quebrado? {quebrado}");

// Declaração de atributos


// STATUS SOCIAIS
int disciplina = 1; // 1 = vagabundo, 2 = preguiçoso, 3 = esforçado, 4 = dedicado, 5 = perfeccionista
int carisma = 1; // 1 = timido, 2 = desajeitado, 3 = simpatico, 4 = carismatico, 5 = encantador
int autoestima = 1; // 1 = inseguro, 2 = temeroso, 3 = corajoso, 4 = confiante, 5 = orgulhoso
int reputacao = 1; // 1 = desprezado, 2 = ignorado, 3 = reconhecido, 4 = respeitado, 5 = admirado
int empatia = 1; // 1 = insensivel, 2 = indiferente, 3 = compreensivo, 4 = solidario, 5 = altruista



int[] atributos = new int[5] { disciplina, carisma, autoestima, reputacao, empatia };

Console.WriteLine($"Disciplina: {atributos[0]} | Carisma: {atributos[1]} | Autoestima: {atributos[2]} | Reputacao: {atributos[3]} | Empatia: {atributos[4]}");

// TURNOS DE AÇÃO
Console.WriteLine("=== Turno estudando ===");
energia -= 20;
disciplina += 1;
autoestima += 1;
