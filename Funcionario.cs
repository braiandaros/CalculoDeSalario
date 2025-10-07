// Em C#, a herança e o conceito de classes abstratas são muito semelhantes.
// O C# utiliza 'abstract' e não exige a sintaxe 'package'.
public abstract class Funcionario
{
    // 1. Propriedades (Substituindo Campos e Getters/Setters em Java)
    // Usaremos propriedades autoimplementadas para Nome e SalarioBase.
    // A convenção em C# é usar PascalCase para propriedades.

    public string Nome { get; set; }

    public double SalarioBase { get; set; }

    // SalarioTotal não é estritamente necessário como campo, pois será calculado e retornado pelo método.
    // Em C#, muitas vezes o valor calculado é exposto diretamente através de um método ou de uma propriedade "Calculada"

    // 2. Construtor
    // A sintaxe é idêntica ao Java.
    public Funcionario(string nome, double salarioBase)
    {
        this.Nome = nome; // Usamos as propriedades aqui
        this.SalarioBase = salarioBase;
    }

    // 3. Método Abstrato
    // O modificador 'abstract' é o mesmo. A convenção é PascalCase.
    public abstract double CalcularSalario();

    // 4. Método Concreto (Final)
    // Console.WriteLine substitui System.out.println
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {this.Nome}"); // Usando interpolação de string ($"...")
        Console.WriteLine($"Salario líquido: R$ {this.CalcularSalario():F2}"); // :F2 para formatar com 2 casas decimais
    }
}