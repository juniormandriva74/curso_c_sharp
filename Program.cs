// Calcular a idade de uma pessoa.
Console.Write("Digite o seu nome: ");
string name = Console.ReadLine();

Console.Write("Digite o ano do seu nascimento: ");
int year = int.Parse(Console.ReadLine());

int age = 2022 - year;

Console.WriteLine($"Olá {name}, a sua idade é {age} anos.");

if (age > 17) Console.WriteLine("Você é maior de idade.");
else Console.WriteLine("Você é menor de idade.");


