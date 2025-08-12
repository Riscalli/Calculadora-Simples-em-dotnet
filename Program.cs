using System;

// O ponto de entrada do seu programa é a classe Program
class Program
{
    // O método 'Main' é onde a execução do seu programa começa.
    // Ele é o ponto de entrada padrão em aplicativos de console.
    static void Main(string[] args)
    {
        Console.WriteLine("Meu Primeiro Programa - Calculadora DotNet");
        Console.WriteLine("------------------------------------------");

        // Solicita e lê o primeiro número do usuário
        Console.Write("Digite o primeiro número: ");
        // Converte a entrada do usuário (uma string) para um tipo numérico (double)
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Solicita e lê o segundo número do usuário
        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Solicita a operação e armazena em uma string
        Console.Write("Escolha uma operação (+, -, *, /): ");
        string operacao = Console.ReadLine();

        double resultado = 0;

        // A estrutura 'switch' verifica qual operação o usuário escolheu
        switch (operacao)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                // Evita a divisão por zero para não gerar um erro no programa
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    // Retorna para encerrar o programa em caso de erro
                    return; 
                }
                break;

            default:
                Console.WriteLine("Operação inválida.");
                // Retorna para encerrar o programa em caso de erro
                return;
        }

        // Exibe o resultado final. O $ na string permite a interpolação,
        // ou seja, inserir o valor da variável 'resultado' diretamente no texto.
        Console.WriteLine($"O resultado da operação é: {resultado}");
    }
}