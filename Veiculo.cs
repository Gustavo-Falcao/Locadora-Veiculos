public abstract class Veiculo
{
    public string Placa { get; set; }
    public double ValorDiaria { get; set; }

    public int DiasAluguel { get; set; }

    public Veiculo(string placa, double valorDiaria, int diasAluguel)
    {
        Placa = placa;
        ValorDiaria = valorDiaria;
        DiasAluguel = diasAluguel;
    }

    
}