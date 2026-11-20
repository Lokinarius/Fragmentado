// Exercício 4 (aula01tiposprimitivo/ex04soma e aula02manipulacaodedados/ex01conversao): ganhos do dia. Leia o que o protagonista ganhou trabalhando e o que ganhou num bico. Primeiro some como texto e veja o erro; depois converta, some de verdade e mostre o total.
//Etapa 4: Conceito novo, operadores aritméticos, atribuição composta e casting. Os operadores são os do Java: + - * / % e os atalhos +=, -=, *=, /= e ++.
//csharp
// Turno de "Trabalhar" (valores provisórios)
//energia -= 30;
//sanidade -= 5;
//dinheiro += 80m;
//Cole abaixo as linhas de saída da etapa 2 e preveja os valores antes de rodar. Nada impede a Energia de ficar negativa, e as condicionais resolvem isso no próximo módulo.
//A divisão entre inteiros descarta a parte decimal: 7 / 2 dá 3, e 7 % 2 dá 1. E, como no Java, o C# converte sozinho para o tipo maior (int com double vira double), mas para voltar exige o cast explícito, que também descarta a parte decimal:
//csharp
//int danoBase = 40;
//int caos = 35;                                    // 0 a 100 (%)
//double multiplicador = 1 + caos / 100.0;          // implícito: int / double dá double
//int danoFinal = (int)(danoBase * multiplicador);  // explícito: perde a parte decimal
//A fórmula é provisória: quanto mais Caos do Mago Negro, mais dano.

