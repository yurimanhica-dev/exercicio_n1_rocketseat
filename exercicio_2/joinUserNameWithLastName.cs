namespace Exercicios_nivel1.exercicio_2;

    public class joinUserNameWithLastName
    {
        public void Print()
        {
            Console.WriteLine("Digite seu primeiro nome:");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            string? lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
