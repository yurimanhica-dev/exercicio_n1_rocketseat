namespace Exercicios_nivel1;

using exercicio_1;
using exercicio_2;
using Exercicios_nivel1.exercicio_3;
using Exercicios_nivel1.exercicio_4;
using Exercicios_nivel1.exercicio_5;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o exercício:");
        Console.WriteLine("1 - Mensagem de Boas-Vindas");
        Console.WriteLine("2 - Juntar Nome e Sobrenome");
        Console.WriteLine("3 - Calcular Decimal");
        Console.WriteLine("4 - Contar Letras de Palavras");
        Console.WriteLine("5 - Verificar Placa de Carro");
        Console.WriteLine("6 - Formatar Data");
        Console.WriteLine("0 - Sair");

        string? option = Console.ReadLine();

        switch (option)
        {
            case "1":
                var exercicio1 = new printWelcomeMessage();
                exercicio1.Print();
                break;

            case "2":
                var exercicio2 = new joinUserNameWithLastName();
                exercicio2.Print();
                break;
            
            case "3":
                var exercicio3 = new CalculateDouble();
                exercicio3.Calculate();
                break;

            case "4":
                var exercicio4 = new pintWordsLength();
                exercicio4.Print();
                break;

            case "5":
                var exercicio5 = new verifyCarLicensePlate();
                if (exercicio5.Verify())
                    Console.WriteLine("Verdadeiro.");
                else
                    Console.WriteLine("Falso.");
                break;

            case "6":
                var exercicio6 = new dateFomat();
                exercicio6.GetInputs();
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
