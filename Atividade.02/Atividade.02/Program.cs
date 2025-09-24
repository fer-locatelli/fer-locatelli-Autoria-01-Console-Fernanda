// See https://aka.ms/new-console-template for more information

          // CALCULANDO IDADE //
Console.WriteLine("Digite o ano em que você nasceu:");
int anoNascimento = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano atual:");
int anoAtual = int.Parse(Console.ReadLine());

int idade = anoAtual - anoNascimento;

Console.WriteLine("Você tem aproximadamente " + idade + " anos.");
