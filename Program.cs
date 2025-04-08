using System;
using ConversorDeMoedasCSharp;
using ConversorDeMoedasCSharp.models; // Importo o namespace onde está a classe Conversor

class Program
{
    static void Main()
    {
        // Instancio a classe Conversor para usar seus métodos
        var conversor = new Conversor();

        // Uso essa variável para controlar o loop do programa
        bool continuar = true;

        while (continuar)
        {
            // Mostro o título do programa
            Console.WriteLine("\n=== Conversor de Moeda ===");

            // Solicito ao usuário o valor em reais que será convertido
            Console.Write("Digite o valor em reais (R$): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                // Se o usuário digitar algo que não seja número, aviso e volto ao início do loop
                Console.WriteLine("Valor inválido.");
                continue;
            }

            // Exibo a lista de opções de moedas disponíveis
            Console.WriteLine("Escolha a moeda para converter:");
            var opcoes = conversor.ObterOpcoes(); // Chamo o método para obter as moedas
            for (int i = 0; i < opcoes.Count; i++)
            {
                // Mostro as moedas com numeração
                Console.WriteLine($"{i + 1} - {opcoes[i]}");
            }

            // Peço que o usuário selecione a moeda
            Console.Write("Opção: ");
            if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > opcoes.Count)
            {
                // Se o número digitado for inválido, aviso e recomeço
                Console.WriteLine("Opção inválida.");
                continue;
            }

            // Pego o código da moeda que o usuário escolheu
            string moedaSelecionada = opcoes[escolha - 1];

            // Faço a conversão e exibo o resultado
            string resultado = conversor.Converter(valor, moedaSelecionada);
            Console.WriteLine(resultado);

            // Pergunto ao usuário o que ele deseja fazer em seguida
            Console.WriteLine("\nDeseja:");
            Console.WriteLine("1 - Fazer outra conversão");
            Console.WriteLine("2 - Ver as 5 últimas conversões");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção: ");
            string acao = Console.ReadLine();

            if (acao == "2")
            {
                // Se o usuário quiser ver o histórico, eu exibo as últimas 5 conversões
                Console.WriteLine("\n=== Últimas 5 Conversões ===");
                foreach (var item in conversor.ObterHistorico())
                    Console.WriteLine(item);
            }
            else if (acao == "3")
            {
                // Se ele quiser sair, altero a variável de controle para encerrar o loop
                continuar = false;
            }
        }

        // Mensagem final após sair do loop
        Console.WriteLine("Programa encerrado.");
    }
}