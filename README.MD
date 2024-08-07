# Projeto de Testes Unitários com Moq

Este projeto demonstra como usar a biblioteca Moq para realizar testes unitários em um projeto C#. O foco é configurar diferentes cenários de retorno para métodos mockados, especialmente em situações onde múltiplas chamadas ao mesmo método devem retornar valores diferentes.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação.
- **Moq**: Biblioteca para criação de objetos mock.
- **NUnit**: Framework para Estrutura de testes para .NET.

## Requisitos

Certifique-se de que você tenha o .NET SDK instalado. Consulte a [documentação do .NET](https://dotnet.microsoft.com/pt-br/download) para obter instruções de instalação.

## Estrutura do Projeto

- **`docs/Joao_Pablo_atividade_1.pdf`**: A versão escrita do tutorial desta atividade.
- **`MoqReturnTest/Models`**: Diretório para classes de modelo usadas no projeto.
- **`MoqReturnTest/Extensions/MoqExtensions.cs`**: Arquivo contendo métodos de extensão para Moq.
- **`MoqReturnTest/Tests/UnitTest1.cs`**: Arquivo contendo os testes unitários.

## Configuração

1. Clone o repositório e navegue até o diretório do projeto.
   ```bash
   cd MoqReturnTest
   ```
2. Restaure as dependências usando o comando:
   ```bash
   dotnet restore
   ```
3. Para executar os testes, use o seguinte comando:
   ```bash
   dotnet test
   ```