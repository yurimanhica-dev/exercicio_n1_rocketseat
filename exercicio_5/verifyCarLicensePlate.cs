namespace Exercicios_nivel1.exercicio_5;
using System.Text.RegularExpressions;

public class verifyCarLicensePlate
{
    public bool Verify()
    {
        Console.WriteLine("Digite a placa do carro:");
        string? licensePlate = Console.ReadLine();
        bool isValid = Regex.IsMatch(licensePlate, @"^[A-Za-z]{3}[0-9]{4}$");
        
        return isValid;
    }
}