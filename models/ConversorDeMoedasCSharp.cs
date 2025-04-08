using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversorDeMoedasCSharp.models

{
    public class Conversor
    {
        // Aqui eu defino um dicionário com as taxas de câmbio fixas do dia 07/04/2025
        private readonly Dictionary<string, decimal> _taxas = new Dictionary<string, decimal>
        {
            { "USD", 5.7322m },
            { "EUR", 6.2051m },
            { "GBP", 7.4255m },
            { "JPY", 0.0382m },
            { "CNY", 0.7897m },
            { "CHF", 6.5050m },
            { "AUD", 3.6238m },
            { "CAD", 4.0139m },
            { "MXN", 0.2866m },
            { "SEK", 0.5747m }
        };

        // Criei uma lista para guardar as últimas 5 conversões feitas
        private readonly List<string> _historico = new List<string>();

        // Este método retorna a lista com o nome das moedas disponíveis
        public List<string> ObterOpcoes()
        {
            // Retorno apenas as chaves do dicionário, que são os códigos das moedas
            return new List<string>(_taxas.Keys);
        }

        // Este método faz a conversão e retorna a string com o resultado formatado
        public string Converter(decimal valor, string moeda)
        {
            // Verifico se a moeda está no dicionário, se não estiver retorno uma mensagem de erro
            if (!_taxas.ContainsKey(moeda))
                return "Moeda inválida.";

            // Faço a conversão dividindo o valor pela taxa da moeda
            decimal resultado = valor / _taxas[moeda];

            // Formato a string com o valor convertido e a cotação usada
            string conversao = $"R$ {valor:F2} = {resultado:F2} {moeda} (Cotação: {_taxas[moeda]} em 07/04/2025)";

            // Adiciono a conversão ao histórico
            _historico.Add(conversao);

            // Se o histórico passar de 5 entradas, removo a mais antiga
            if (_historico.Count > 5)
                _historico.RemoveAt(0);

            // Retorno o resultado da conversão
            return conversao;
        }

        // Este método retorna uma cópia do histórico de conversões
        public List<string> ObterHistorico()
        {
            return new List<string>(_historico);
        }
    }
}