namespace Exercicios_nivel1.exercicio_3;

public class CalculateDouble
{
    private double ReadNumber(string message)
    {
        Console.WriteLine(message);
        return Convert.ToDouble(Console.ReadLine());
    }

    public void Calculate()
    {
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Média");

        string? option = Console.ReadLine();

        double number1 = ReadNumber("Digite o primeiro número:");
        double number2 = ReadNumber("Digite o segundo número:");
        double result = 0;

        switch (option)
        {
            case "1":
                result = number1 + number2;
                Console.WriteLine($"Resultado da adição: {result}");
                break;

            case "2":
                result = number1 - number2;
                Console.WriteLine($"Resultado da subtração: {result}");
                break;

            case "3":
                result = number1 * number2;
                Console.WriteLine($"Resultado: {result}");
                break;

            case "4":
                if (number2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    return;
                }
                result = number1 / number2;
                Console.WriteLine($"Resultado da divisão: {result}");
                break;

            case "5":
                result = (number1 + number2) / 2;
                Console.WriteLine($"Resultado da média: {result}");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
