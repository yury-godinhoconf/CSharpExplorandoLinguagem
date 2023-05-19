using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio de IR\n");
        double salario = 1900.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("Seu IR é de 7.5%");
            Console.WriteLine("Sua dedução é de R$ 142");
        }
        else if (salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("Seu IR é de 15%");
            Console.WriteLine("Sua dedução é de R$ 350");
        }
        else if(salario >= 3751.01 && salario <= 4664.00)
        {
            Console.WriteLine("Seu IR é de 22.5%");
            Console.WriteLine("Sua dedução é de R$ 636");
        }
        else
        {
            Console.WriteLine("Sem dedução disponível");
        }

        Console.WriteLine("\nPressione enter para finalizar.");
        Console.ReadLine(); 
    }
}