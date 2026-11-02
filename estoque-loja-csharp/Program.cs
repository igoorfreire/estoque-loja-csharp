Produto produto1 = new Produto();
Produto produto2 = new Produto();
Produto produto3 = new Produto();
Produto produto4 = new Produto();
Produto produto5 = new Produto();


produto1.Nome = "Pc Gamer";
produto1.Preco = 3999.99m;
produto1.Estoque = 10;

produto2.Nome = "Head-set";
produto2.Preco = 499.99m;
produto2.Estoque = 15;

produto3.Nome = "Mouse";
produto3.Preco = 299.99m;
produto3.Estoque = 5;

produto4.Nome = "Teclado";
produto4.Preco = 799.99m;
produto4.Estoque = 30;

produto5.Nome = "MousePad";
produto5.Preco = 99.99m;
produto5.Estoque = 15;

List<Produto> produtos = new List<Produto>();
produtos.Add(produto1);
produtos.Add(produto2);
produtos.Add(produto3);
produtos.Add(produto4);
produtos.Add(produto5);

Produto ProdutoMaisCaro(List<Produto> produtos)
{
    Produto maisCaro = produtos[0];
    foreach (Produto produto in produtos)
    {
        if (produto.Preco > maisCaro.Preco)
        {
            maisCaro = produto;
        }
    }
    return maisCaro;

}
Produto maisCaro = ProdutoMaisCaro(produtos);
Console.WriteLine("-----------Item Mais Caro da Loja-----------");
Console.WriteLine($"Preço do produto mais caro : {maisCaro.Nome} - R${maisCaro.Preco}");
Console.WriteLine("\n-----------Produtos com estoque menor que 10-----------");
foreach (Produto produto in produtos)
{
    if (produto.Estoque < 10)
    {
        Console.WriteLine($"Produto - {produto.Nome} - quantidade em estoque : {produto.Estoque}");
    }
}
decimal ValorTotalDeEstoque(List<Produto> produtos)
{
    decimal somaDoEstoque = 0;
    foreach (Produto produto in produtos)
    {
        somaDoEstoque += produto.ValorDeEstoque();
    }
    return somaDoEstoque;
}
Console.WriteLine("\n-----------Valor total do estoque da loja-----------");
Console.WriteLine($"Valor do estoque R${ValorTotalDeEstoque(produtos)}");

Console.WriteLine("\n-----------Valor de cada item do estoque-----------");
foreach (Produto produto in produtos)
{
    Console.WriteLine($"Produto - {produto.Nome} - Valor - R${produto.ValorDeEstoque()}");
}

decimal ValorDeCompraDosItens(List<Produto> produtos)
{
    decimal soma = 0;
    foreach (Produto produto in produtos)
    {
        soma += produto.Preco;
    }
    return soma;
}
Console.WriteLine("\n-----------Valor gasto na compra de cada item da loja-----------");
Console.WriteLine($"Valor - R${ValorDeCompraDosItens(produtos)}");


class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }

    public decimal ValorDeEstoque()
    {
        return Estoque * Preco;
    }
}