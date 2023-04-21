using PBL5.Domain.Item_3.Pessoa;
using PBL5.Domain;
using PBL5.Domain.Item_4;


#region Item 3
Console.WriteLine("---------------------Item 3---------------------");
Pessoa pessoa1 = new Pessoa()
{
    Conta = new ContaPoupança(1302m)
};

Pessoa pessoa2 = new Pessoa()
{
    Conta = new ContaCorrente(1320m)
};

pessoa1.GetConta();
pessoa2.GetConta();

pessoa1.Conta.Depositar(1000.50m);
pessoa2.Conta.Depositar(1000.50m);

pessoa1.GetConta();
pessoa2.GetConta();
Console.WriteLine("-------------------Fim item 3-------------------");
#endregion

#region Item 4
Console.WriteLine("---------------------Item 4---------------------");
Calculadora calculadora = new();

Console.WriteLine(calculadora.Somar(2, 3));
Console.WriteLine(calculadora.Somar(new List<int>() { 2, 3, 4 }));

Console.WriteLine(calculadora.Subtrair(2, 3));
Console.WriteLine(calculadora.Subtrair(new List<int>() { 3, 5, 4 }));

Console.WriteLine(calculadora.Multiplicar(2, 3));
Console.WriteLine(string.Join(", ", calculadora.Multiplicar(new List<int>() { 3, 5, 4 }, 3)));

Console.WriteLine(calculadora.Dividir(1, 2));
Console.WriteLine(calculadora.Dividir(new List<int>() { 3, 5, 4 }));
Console.WriteLine("-------------------Fim item 4-------------------");
#endregion