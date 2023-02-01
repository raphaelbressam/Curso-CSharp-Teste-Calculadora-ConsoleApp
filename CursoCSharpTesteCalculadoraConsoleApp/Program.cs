Console.WriteLine("Seja Bem Vindo a Calculadora");

do
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    string? primeiroValorString = Console.ReadLine();
    double primeiroValor = Convert.ToDouble(primeiroValorString);

    Console.WriteLine("Digite o segundo valor:");
    string? segundoValorString = Console.ReadLine();
    double segundoValor = Convert.ToDouble(segundoValorString);

    Console.WriteLine("Selecione a operacao:");
    Console.WriteLine("+");
    Console.WriteLine("-");
    Console.WriteLine("*");
    Console.WriteLine("/");

    var operacaoSelecionada = Console.ReadLine();

    double? resultadoOperacao;
    switch (operacaoSelecionada)
    {
        case "+":
            resultadoOperacao = primeiroValor + segundoValor;
            break;
        case "-":
            resultadoOperacao = primeiroValor - segundoValor;
            break;
        case "*":
            resultadoOperacao = primeiroValor * segundoValor;
            break;
        case "/":
            resultadoOperacao = primeiroValor / segundoValor;
            break;
        default:
            resultadoOperacao = null;
            break;
    }

    Console.WriteLine();
    var mensagem = resultadoOperacao.HasValue ? $"Resultado da operacao: {resultadoOperacao}" : "Operacao invalida!";
    Console.WriteLine(mensagem);

    //if (resultadoOperacao.HasValue)
    //    Console.WriteLine($"Resultado da operacao: {resultadoOperacao}");
    //else
    //    Console.WriteLine("Operacao invalida!");

    Console.WriteLine();
    Console.WriteLine("Deseja realizar outra operacao?");
    Console.WriteLine("(S) Sim (N) Nao");
} while (Console.ReadKey().Key == ConsoleKey.S);

Console.WriteLine();
Console.WriteLine("Ate logo!!");

Console.ReadKey();