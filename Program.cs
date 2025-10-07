using System;
// Em C#, não precisamos da estrutura 'package' como no Java
// As classes podem ser definidas diretamente no namespace, ou, como abaixo, 
// sem um namespace explícito se for um projeto simples de console.

public class Program
{
    public static void Main(string[] args)
    {
        // Em C#, as variáveis são declaradas com o tipo específico ou com 'var' para inferência.
        // A sintaxe de instanciação é a mesma.

        // Supondo que as classes Administrativo, Tecnico e Estagiario herdam de Funcionario
        Funcionario gerente1 = new Administrativo("Carlos", 4000);
        Funcionario gerente2 = new Administrativo("Fernanda", 5000);

        Funcionario tecnico1 = new Tecnico("Ana", 2000);
        Funcionario tecnico2 = new Tecnico("João", 2500);

        Funcionario estagiario1 = new Estagiario("Maria", 1200);
        Funcionario estagiario2 = new Estagiario("Jose", 1000);

        // Em C#, usamos Console.WriteLine() para imprimir.
        gerente1.ExibirDados(); // Convenção em C# é PascalCase para métodos
        Console.WriteLine("--------------------");
        gerente2.ExibirDados();
        Console.WriteLine("--------------------");
        tecnico1.ExibirDados();
        Console.WriteLine("--------------------");
        tecnico2.ExibirDados();
        Console.WriteLine("--------------------");
        estagiario1.ExibirDados();
        Console.WriteLine("--------------------");
        estagiario2.ExibirDados();
    }
}