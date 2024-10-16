namespace CaueG.Models;

public class Folha
{
    public int FolhaId { get; set; }
    public double Valor { get; set; }
    public double Quantidade { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public int FuncionarioId { get; set; } 
    public double SalarioBruto
    {
        get { return Valor * Quantidade; }
    }

    public double ImpostoIrrf
    {
        get
        {
            if (SalarioBruto <= 1903.98)
            {
                return SalarioBruto; 
            }
            else if((SalarioBruto >1903.98) || (SalarioBruto < 2826.65))
            {
                
                return (SalarioBruto - 1903.98) * 0.075;
            }
            else if((SalarioBruto >2826.65) || (SalarioBruto < 3751.05)){
                return (SalarioBruto - 1903.98) * 0.15;
            }
            else if((SalarioBruto >3751.05) || (SalarioBruto < 4664.68)){
                return (SalarioBruto - 1903.98) * 0.22;
            }
            else{
                return (SalarioBruto - 1903.98) * 0.27;
            }
        }
    }

    public double ImpostoInss {
        get
        {
            if (SalarioBruto <= 1693.72)
            {
                return SalarioBruto * 0.08; 
            }
            else if((SalarioBruto >1693.72) || (SalarioBruto < 2822.90))
            {
                
                return SalarioBruto * 0.09;
            }
            else if((SalarioBruto >2822.90) || (SalarioBruto < 5645.80)){
                return SalarioBruto *0.11;
            }
            else {
                return 621.03;
            }
            
        }
    }
    
    
    public double ImpostoFgts 
    {
        get { return SalarioBruto * 0.08;}
    }
    public double SalarioLiquido { 
        get { return SalarioBruto - ImpostoIrrf - ImpostoInss; }
    }
    public Funcionario? Funcionario { get; set; } 
}

