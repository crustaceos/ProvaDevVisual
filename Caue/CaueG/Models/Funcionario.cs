﻿namespace CaueG.Models;

public class Funcionario
{
    public int FuncionarioId { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public List<Folha>? Folhas { get; set; } 
}
