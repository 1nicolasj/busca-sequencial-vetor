char continuar;
Random valorAleatorio = new Random();

Console.WriteLine("Qual será o tamanho do vetor?");
int tamanhoVetor = int.Parse(Console.ReadLine()!);
int[] vetor = new int[tamanhoVetor];

do
{
    CriaVetorAleatorio();

    Console.WriteLine("Pesquise por um número no vetor: ");
    int numeroPesquisado = int.Parse(Console.ReadLine()!);

    int resultado = BuscaSequencial(vetor, numeroPesquisado);

    if (resultado == -1)
    {
        Console.WriteLine($"O número {numeroPesquisado} NÃO foi encontrado no vetor.");
        Console.Write("Vetor:");
        foreach (int valor in vetor)
        {
            Console.Write($" {valor} ");
        }
    }
    else
    {
        Console.WriteLine($"O número {numeroPesquisado} foi encontrado no vetor, no índice {resultado}");
        Console.Write("Vetor:");
        foreach (int valor in vetor)
        {
            Console.Write($" {valor} ");
        }
    }

    Console.WriteLine("\n\nDeseja continuar? (s/n)");
    continuar = char.Parse(Console.ReadLine()!);
    Console.Clear();
} while (continuar == 's' || continuar == 'S');

int BuscaSequencial(int[] vetor, int numeroPesquisado)
{
    int indice = 0;
    foreach (int valor in vetor)
    {
        if (valor == numeroPesquisado)
        {
            return indice;
        }
        indice++;
    }
    return -1;
}

void CriaVetorAleatorio()
{
    Console.WriteLine("Informe o intervalo dos números aleatórios gerados");
    Console.WriteLine("Informe o menor valor:");
    int intervaloAleatoriosNum1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Informe o maior valor:");
    int intervaloAleatoriosNum2 = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < vetor.Length; i++)
    {
        vetor[i] = valorAleatorio.Next(intervaloAleatoriosNum1, intervaloAleatoriosNum2);
    }
}
