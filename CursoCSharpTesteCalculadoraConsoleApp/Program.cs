using CursoCSharpTesteCalculadoraConsoleApp;

Console.WriteLine("Seja Bem Vindo a Calculadora");

try
{
    Calculadora calculadora = new Calculadora();
    calculadora.Executar();
}
catch (Exception ex)
{
    Console.Clear();
    Console.WriteLine("Deu erro, nao consegui realizar o processo!!!");
}


Console.WriteLine();
Console.WriteLine("Ate logo!!");

Console.ReadKey();