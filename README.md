# Projeto Web .NET MVC - Clínica Veterinária LH-Pet

Este projeto é o início do desenvolvimento de uma aplicação web .NET com arquitetura MVC para a clínica veterinária LH-Pet. Inicialmente, a aplicação não utilizará banco de dados, mas será estruturada de forma a facilitar a futura migração da base de dados da empresa para o novo sistema.

## Estrutura do Projeto

* **Models:**
    * `Cliente.cs`: Representa os clientes da clínica.
    * `Fornecedor.cs`: Representa os fornecedores da clínica.
* **Controllers:**
    * `HomeController.cs`: Controller padrão do projeto, onde os objetos Cliente e Fornecedor são criados e populados.
* **Views:**
    * `Index.cshtml`: Template da página inicial, desenvolvido pela equipe front-end da empresa, onde as listas de Clientes e Fornecedores são exibidas.

## Como Executar o Projeto

1.  Certifique-se de ter o .NET SDK instalado em sua máquina.
2.  Clone este repositório.
3.  Abra o projeto no Visual Studio ou em outro editor de código compatível com .NET.
4.  Restaure os pacotes NuGet necessários.
5.  Execute o projeto.

## Implementação

### Models

Os models `Cliente.cs` e `Fornecedor.cs` foram criados com os atributos relevantes para cada entidade. Por exemplo:

```csharp
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
}

public class Fornecedor
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public string Email { get; set; }
}
