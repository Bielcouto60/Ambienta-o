class exc01
{
    static void Main(string[] args)
    {
        // Solicita ao usuário que insira a altura do retângulo
        Console.Write("Insira a altura do retângulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário que insira a largura do retângulo
        Console.Write("Insira a largura do retângulo: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        // Calcula a área do retângulo
        double area = CalcularAreaRetangulo(altura, largura);

        // Exibe a área calculada
        Console.WriteLine($"A área do retângulo é: [area]");
    }

    // Método para calcular a área do retângulo
    static double CalcularAreaRetangulo(double altura, double largura)
    {
        // Área = altura * largura
        double area = altura * largura;
        return area;
    }
}