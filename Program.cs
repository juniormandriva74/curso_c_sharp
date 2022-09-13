class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("Junior", 200);
        BankAccount account2 = new BankAccount("Matheus", 500);

        account1.Deposito(-100);
        account2.Deposito(100);
    }
}

class BankAccount
{
    private string name;
    private decimal balance;

    // Definindo o construtor
    public BankAccount(string name, decimal balance)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Nome inválido.", nameof(name));
        }

        if(balance < 0)
        {
            throw new Exception("O saldo não pode ser negativo.");
        }

        this.name = name;
        this.balance = balance;
    }

    public void Deposito(decimal amount)
    {
        if(amount <= 0)
        {
            return;
        }
        balance = balance + amount;
    }
}





// Calcular a idade de uma pessoa.
/*Console.Write("Digite o seu nome: ");
string name = Console.ReadLine();

Console.Write("Digite o ano do seu nascimento: ");
int year = int.Parse(Console.ReadLine());

int age = 2022 - year;

Console.WriteLine($"Olá {name}, a sua idade é {age} anos.");

if (age > 17) {
    Console.WriteLine("Você é maior de idade.");
} 
else {
    Console.WriteLine("Você é menor de idade.");
} 
*/