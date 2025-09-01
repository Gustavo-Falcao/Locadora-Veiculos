class Program
{

    public static double CalcularAluguel(int dia, double valorDiaria)
    {
        return dia * valorDiaria;
    }
    public static List<Veiculo> IniciarVeiculos(List<Veiculo> veiculos)
    {
        veiculos.Add(new Carro("azs1407", 5.2, 6));
        veiculos.Add(new Moto("apw1234", 4.3, 14));
        veiculos.Add(new Carro("qwtw456", 5.2, 10));
        veiculos.Add(new Moto("ppol900", 2.4, 21));
        return veiculos;
    }
    public static void Main()
    {
        List<Veiculo> veiculos = [];
        veiculos = IniciarVeiculos(veiculos);
        int i = 0;
        foreach (Veiculo veiculo in veiculos)
        {
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine($"Veiculo {i += 1}");
            Console.WriteLine($"Placa: {veiculo.Placa}");
            Console.WriteLine($"Diária: {veiculo.ValorDiaria}");
            Console.WriteLine($"Dias alugado: {veiculo.DiasAluguel}");
            Console.WriteLine($"Valor do aluguel: {CalcularAluguel(veiculo.DiasAluguel, veiculo.ValorDiaria):F2}");
        }
        i = 0;
    }
}