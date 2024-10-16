namespace CaueG;
public class FolhaDto
{
    public int FolhaId { get; set; }
    public double SalarioBruto { get; set; }
    public double SalarioLiquido { get; set; }
    public string? FuncionarioNome { get; set; }
    public string? FuncionarioCpf { get; set; }
    public double ImpostoIrrf { get; set; }
    public double ImpostoInss { get; set; }
    public double ImpostoFgts { get; set; }
}