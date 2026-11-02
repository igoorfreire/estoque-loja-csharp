# Estoque da Loja (C#)

Programa de console em C# que gerencia o estoque de uma loja com cinco produtos cadastrados.

## O que o programa faz

- Mostra o produto mais caro da loja
- Lista os produtos com estoque menor que 10 unidades
- Calcula o valor total do estoque (preço x quantidade de cada produto)
- Mostra o valor em estoque de cada produto
- Calcula quanto custa comprar uma unidade de cada produto

## Como rodar

Requisitos: [.NET SDK](https://dotnet.microsoft.com/download) instalado (projeto feito com .NET 10).

```bash
git clone https://github.com/igoorfreire/estoque-loja-csharp.git
cd estoque-loja-csharp
dotnet run
```

## Conceitos praticados

- Classe `Produto` com propriedades (`get; set;`) e método próprio
- `List<T>` para guardar os produtos
- `foreach` para percorrer a lista
- Métodos com retorno (`decimal`, `Produto`)
- Padrão do acumulador (somar valores dentro de um laço)
- Tipo `decimal` para valores monetários

## Autor

Igor Freire, estudante de Análise e Desenvolvimento de Sistemas.
[LinkedIn](https://www.linkedin.com/in/igoor-freire/) | [GitHub](https://github.com/igoorfreire)
