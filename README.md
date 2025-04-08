# 💱 Conversor de Moedas em C#

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![Status](https://img.shields.io/badge/status-Em%20Desenvolvimento-yellow)

Um conversor de moedas simples, feito em C#, que permite ao usuário inserir um valor em Reais (BRL) e escolher entre mais de 10 moedas diferentes para conversão, com base nas cotações do dia **07/04/2025**.

---

## 📸 Demonstração

```bash
============================
 CONVERSOR DE MOEDAS
============================
Digite o valor em BRL: 100
Escolha a moeda:
1. USD - Dólar Americano
2. EUR - Euro
3. ARS - Peso Argentino
...
Resultado: 💵 100 BRL = 19.45 USD (Cotação de 07/04/2025)

Deseja realizar outra conversão? (s/n): s
📖 Descrição Estendida
Este projeto foi estruturado com base em princípios de boas práticas de programação:

✅ Separação entre lógica e execução (Models e Program.cs)

✅ Comentários explicativos em primeira pessoa, facilitando o aprendizado

✅ Histórico das 5 últimas conversões

✅ Utilização de cotações fixas para controle e testes

✅ Preparado para futura integração com APIs de câmbio reais

🚀 Tecnologias Utilizadas
.NET 6

C# (console app)

📂 Estrutura do Projeto
Copiar
Editar
ConversorDeMoedas/
├── Models/
│   └── Conversor.cs
├── Program.cs
├── .gitignore
└── README.md
🧪 Como Executar
Clone este repositório:

bash
Copiar
Editar
git clone https://github.com/Godoyzera659/ConversorDeMoedasCSharp.git
Acesse a pasta do projeto:

bash
Copiar
Editar
cd ConversorDeMoedasCSharp
Execute com o .NET CLI:

bash
Copiar
Editar
dotnet run
🔧 Funcionalidades
Inserção de valor em BRL

Escolha da moeda de destino (USD, EUR, ARS, GBP, CAD, AUD, CNY, JPY, CHF, BTC, etc)

Exibição do valor convertido

Exibição da cotação usada (07/04/2025)

Histórico das últimas 5 conversões

📅 Cotações Utilizadas (07/04/2025)
Moeda	Nome	Cotação (1 BRL = ?)
USD	Dólar Americano	0.1945
EUR	Euro	0.1792
ARS	Peso Argentino	173.33
GBP	Libra Esterlina	0.1533
CAD	Dólar Canadense	0.2667
AUD	Dólar Australiano	0.2950
CNY	Yuan Renminbi	1.4100
JPY	Iene Japonês	29.98
CHF	Franco Suíço	0.1770
BTC	Bitcoin	0.000003
✅ Melhorias Futuras
 Integração com API de câmbio em tempo real (ex: ExchangeRate API)

 Interface gráfica (WinForms ou WPF)

 Suporte a mais moedas e exportação de histórico

⚖️ Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

🙋‍♂️ Autor
Desenvolvido por Pedro Godoy 🚀

