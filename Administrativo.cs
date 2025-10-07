// Herança em C# é com ':'
public class Administrativo : Funcionario
{
    // O campo 'salarioTotal' não é necessário em C#, pois o valor é calculado e retornado 
    // diretamente pelo método CalcularSalario.

    // 1. Construtor
    // O 'super()' do Java é substituído por ': base(...)' em C#.
    public Administrativo(string nome, double salarioBase)
        : base(nome, salarioBase)
    {
        // O C# não tem o TODO auto-gerado aqui, podemos deixar o corpo vazio
    }

    // 2. Sobrescrita do Método Abstrato
    // O '@Override' do Java é substituído pela palavra-chave 'override' em C#.
    public override double CalcularSalario()
    {
        // Em C#, acessamos SalarioBase através da propriedade herdada.
        // O cálculo pode ser feito diretamente na instrução de retorno.
        return SalarioBase + (SalarioBase * 0.5);
    }
}