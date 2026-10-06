//using System.Threading.Channels;

//Console.WriteLine("=====SISTEMA DE CADASTRO=====");
//string nome;
//string nickname;
//string plataforma;
//int ano;
//double saldo;

//Console.Write("Digite seu nome:");
//nome = Console.ReadLine().ToLower();
//Console.Write("Digite seu NickName:");
//nickname = Console.ReadLine().ToLower();
//Console.Write("Digite a Plataforma (PS5 , PC, XBOX, ou Switch): ");
//plataforma = Console.ReadLine().ToLower();
//Console.Write("Digite o Ano que virou cliente:");
//ano = int.Parse(Console.ReadLine());
//Console.Write("Digite o saldo : ");
//saldo = double.Parse(Console.ReadLine());
//Console.WriteLine();
//Console.WriteLine("=====FICHA CLIENTE=====");
//Console.WriteLine($"Nome: {nome}");
//Console.WriteLine($"Nickname: {nickname}");
//Console.WriteLine($"Plataforma: {plataforma}");
//Console.WriteLine($"Cliente desde: {ano}");
//Console.WriteLine($"Saldo: R$ {saldo.ToString("F2")}");

//Console.WriteLine();
//Console.WriteLine("=====DADOS DO JOGO=====");

//string nomeDoJogo;
//double preçoDoJogo;

//Console.WriteLine("Digite o nome do jogo: ");
//nomeDoJogo = Console.ReadLine().ToLower();

//Console.WriteLine("Digite a plataforma do jogo: ");
//string plataformaJogo = Console.ReadLine().ToLower();

//Console.WriteLine("Digite o preço do jogo: ");
//preçoDoJogo = double.Parse(Console.ReadLine().ToLower());

//Console.Clear();

//Console.WriteLine($"Nome do jogo: {nomeDoJogo} ");
//Console.WriteLine($"Plataforma do jogo: {plataformaJogo} ");
//Console.WriteLine($"Preço: (R$) {preçoDoJogo:F2}");

//Console.Write("");
//if  (plataformaJogo == plataforma)
//{
//    if(preçoDoJogo > saldo)
//    {
//        Console.WriteLine($"Saldo insuficiente! Faltam R$ {preçoDoJogo - saldo}");
//    }
//    else
//    {
//        Console.WriteLine($"Pode comprar {nomeDoJogo}! Sobrariam {saldo - preçoDoJogo}");
//    }
//}
//else
//{
//    Console.WriteLine("AVISO! A Plataforma não e compativel!");
//}

//Solicita ao usuario a quantidade de jogos
using System.Runtime.Serialization;

Console.Write("Quantos jogos você ja tem? ");
int quantidade = int.Parse(Console.ReadLine());

// Faz uma validação para caso o usuario digite 0 ou um numero negativo
if (quantidade <= 0)
{
    quantidade = 1;
}

// Após armazenar a quantidade de jogos, você irá informar o nome dos jogos
string[] biblioteca = new string[quantidade];
//string[] nomeDoJogo = new string[quantidade];

for (int i = 0; i < biblioteca.Length; i++)
{
    Console.Write("Qual o nome do jogo?");
    biblioteca[i] = Console.ReadLine();
}

Console.WriteLine();

for (int i = 0; i < biblioteca.Length; i++)
{
    Console.WriteLine($"Nome do jogo {i + 1}: {biblioteca[i]}");

}
Console.WriteLine();

Console.WriteLine($"Total de jogos: {biblioteca.Length}");


Console.Write("Digite o nome do jogo:\n");
string nomeDoJogo = Console.ReadLine();

for (int i = 0; i <= biblioteca.Length; i++)
{
    if (nomeDoJogo == biblioteca[i])
    {
        Console.WriteLine($"Você já tem {nomeDoJogo}! Não precisa comprar de novo.");
        break;
    }
    else
    {
        Console.WriteLine($"{nomeDoJogo} Não está na sua biblioteca.");
        break;
    }
}
double somaTotal = 0;
double[] preco = new double[quantidade];

for (int j = 0; j < biblioteca.Length; j++)
{
    Console.WriteLine($"Quanto você pagou {biblioteca[j]}?");
    preco[j] = double.Parse(Console.ReadLine());
    somaTotal += preco[j];

}

for (int x = 0; x < preco.Length; x++)
{
    Console.WriteLine($"Quanto você pagou em {biblioteca[x]}? R$ {preco[x]:F2}");
}

Console.WriteLine($"Total Gasto:{somaTotal}");
Console.WriteLine($"Média por compra: {somaTotal / biblioteca.Length:F2}");
Console.WriteLine($"O jogo mais caro é {preco.Max()}");
int totalDeHoras = 0;

int[] horasJogadas = new int[quantidade];
for (int x = 0; x < biblioteca.Length; x++)
{
    Console.WriteLine($"Quantas horas você jogou {biblioteca[x]}");
    horasJogadas[x] = int.Parse(Console.ReadLine());
    totalDeHoras += horasJogadas[x];
}


string jogoMaisJogado = "";
int horasMaisJogadas = 0;
int indiceMaior = 0;
int horasMenosJogados = 0;
int indiceMenor = 0;
string jogoMenos = " ";

for (int x = 0; x < preco.Length; x++)
{
    Console.WriteLine($"Quantas horas você jogou {biblioteca[x]} ?  {horasJogadas[x]}h");
   
    //if (horasJogadas[x] > horasMaisJogadas)
    //{
    //    horasMaisJogadas = horasJogadas[x];
    //    jogoMaisJogado = biblioteca[x];
    //    indiceMaior = x;
    //}

    //if (horasJogadas[x] < horasMenosJogados)
    //{
    //    horasMenosJogados = horasJogadas[x];
    //    jogoMenos = biblioteca[x];
    //    indiceMenor = x;
  
    //}

}

for (int x = 0; x < preco.Length; x++)
{
  
    if (horasJogadas[x] > horasMaisJogadas)
    {
        horasMaisJogadas = horasJogadas[x];
        jogoMaisJogado = biblioteca[x];
        indiceMaior = x;
    }

    if (horasJogadas[x] < horasMenosJogados)
    {
        horasMenosJogados = horasJogadas[x];
        jogoMenos = biblioteca[x];
        indiceMenor = x;

    }
}


    Console.WriteLine($"Total de Horas: {totalDeHoras}h");
    Console.WriteLine($"Mais Jogado: {jogoMaisJogado} {horasMaisJogadas}h");
    Console.WriteLine($"Jogo Encostado {horasJogadas[indiceMenor]}: ");
    Console.WriteLine($"- {biblioteca[indiceMenor]}");


/*
 * Jose Henrique
 * Fábio Gomes
 * Lucas Santos
 * Nicolas Kronemberger
 * Washigton Willian
 * 
 */