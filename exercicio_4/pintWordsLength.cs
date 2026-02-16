namespace Exercicios_nivel1.exercicio_4;

public class pintWordsLength
{
    public void Print()
    {
        Console.WriteLine("Digite uma frase:");
        string? sentence = Console.ReadLine();
        string[] words = sentence.Split(' '); 

        foreach (string word in words)
        {
            Console.WriteLine($"A palavra {word} tem {word.Length} letras");
        }
    }
}
