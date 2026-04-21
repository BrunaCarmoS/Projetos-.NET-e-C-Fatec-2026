namespace CrudCarrosFabricantes.Models;

public class Carro
{
    public int CarroId { get; set; }

    public string Nome { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public string Cor { get; set; } = string.Empty;
    public string Placa { get; set; } = string.Empty;

    // RELAÇÃO
    public int FabricanteId { get; set; }
    public Fabricante? Fabricante { get; set; }
}