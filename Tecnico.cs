// A classe Tecnico herda de Funcionario usando ':'
public class Tecnico : Funcionario
{
    // 1. Construtor
    // Chamada ao construtor da classe base (Funcionario) com ': base(...)'
    public Tecnico(string nome, double salarioBase)
        : base(nome, salarioBase)
    {
        // Corpo do construtor vazio
    }

    // 2. Sobrescrita do Método Abstrato
    // Usamos a palavra-chave 'override'
    public override double CalcularSalario()
    {
        // Em C#, a expressão usa a propriedade 'SalarioBase'
        return SalarioBase + 500;
    }
}
