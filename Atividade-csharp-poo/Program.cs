using ClassesObjetos;

Produto p1 = new Produto(); //instanciando um objeto da classe produto

p1.Nome = "Notebook";
p1.Preco = 3500m;

p1.Exibir();

p1.AlterarPreco(100);


Produto p2 = new Produto();
p2.Nome = "Mouse";
p2.Preco = 100m;

p2.Exibir();

// Classe e métodos static



int resultado = Calculadora.Somar(10, 20);

Console.WriteLine($"O resultado é: {resultado}!");


// Utilizando a classe static;
// Conta.Depositar(100m);
// Conta.Depositar(50m);

Conta conta_corrente = new Conta();
Conta conta_poupanca = new Conta();

conta_corrente.Depositar(100m);

conta_poupanca.Depositar(50m);

Console.WriteLine(Math.Round(10.567, 2));
Console.WriteLine(DateTime.Now);

Pessoa pessoa1 = new Pessoa();
Console.WriteLine($"Nome: {pessoa1.Nome} - Idade: {pessoa1.Idade}");

Pessoa pessoa2 = new Pessoa("Samuel", 20);
Console.WriteLine($"Nome: {pessoa2.Nome} - Idade: {pessoa2.Idade}");

Produto p3 = new Produto
{
    Nome = "PS5", Preco = 5000m
};