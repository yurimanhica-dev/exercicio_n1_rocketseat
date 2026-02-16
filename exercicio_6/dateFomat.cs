namespace Exercicios_nivel1.exercicio_5;

public class dateFomat
{
    string? day, monthday, month, year, hour, minute, second;
    public void GetInputs()
    {
        Console.WriteLine("Digite o dia da semana");
        day = Console.ReadLine();
        Console.WriteLine("Digite o dia do mês");
        monthday = Console.ReadLine();
        Console.WriteLine("Digite o mês");
        month = Console.ReadLine();
        Console.WriteLine("Digite o ano");
        year = Console.ReadLine();
        Console.WriteLine("Digite o hora");
        hour = Console.ReadLine();
        Console.WriteLine("Digite o minuto");
        minute = Console.ReadLine();
        Console.WriteLine("Digite o segundo");
        second = Console.ReadLine();

        
        Console.WriteLine($"Data no Formato (dia, mês, ano): {day}/{month}/{year}");
        Console.WriteLine($"Hora no formato 24 horas: {hour}:{minute}:{second}");
        Console.WriteLine($"Data com mes por extenso: {monthday} de {month} de {year}");
    }
}