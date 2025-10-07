// A classe Estagiario herda de Funcionario usando ':'
public class Estagiario : Funcionario
{
    // 1. Construtor
    // Chamada ao construtor da classe base (Funcionario) com ': base(...)'
    public Estagiario(string nome, double salarioBase)
        : base(nome, salarioBase)
    {
        // Corpo do construtor vazio
    }

    // 2. Sobrescrita do Método Abstrato
    // Usamos a palavra-chave 'override'
    public override double CalcularSalario()
    {
        // Simplesmente retorna o SalarioBase (acessado via Propriedade da classe pai).
        return SalarioBase;
    }
}