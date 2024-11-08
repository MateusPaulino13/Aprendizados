using System;
using System.Collections.Generic;

public class Funcionario
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salario { get; set; }

    public Funcionario(int id, string name, double salario)
    {
        id = Id;
        Name = name;
        Salario = salario;
    }

    void AumentoSalario(double aumento)
    {
        Salario *= aumento;
    }
}
