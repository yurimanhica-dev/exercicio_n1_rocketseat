namespace Exercicios_nivel1.exercicio_1;

public class printWelcomeMessage
{
    public void Print()
    {
        Console.WriteLine("Digite seu nome:");
        string? name = Console.ReadLine();
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }
}