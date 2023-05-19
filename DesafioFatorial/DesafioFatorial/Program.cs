
Console.WriteLine("Desafio Fatorial\n");
int numeroFatorial = 1;

for(int fatorial = 1; fatorial <= 10; fatorial++)
{
    numeroFatorial *= fatorial;
    Console.WriteLine("O Fatorial de " + fatorial + " é " +  numeroFatorial);
}
Console.WriteLine("\nPressione enter para finalizar.");
Console.ReadLine(); 
