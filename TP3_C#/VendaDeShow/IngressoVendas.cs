using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_C_.VendaDeShow;

internal class IngressoVendas
{
// Exercício 4 Testando a Classe "Ingresso"

    static void Main()
    {
        Ingresso ingressoShow = new Ingresso("Festival do Forró", 40.00, 1000);

        ingressoShow.nomeDoShow = "Festival do Forró";
        ingressoShow.preco = 40.00;
        ingressoShow.quantidadeDisponivel = 1000;

        Console.WriteLine("Dados Iniciais");
        ingressoShow.ExibirInformacoes();

        ingressoShow.alterarPreco(60.00);
        ingressoShow.alterarQuantidade(800);

        Console.WriteLine("Dados Atualizados:");
        ingressoShow.ExibirInformacoes();

        ingressoShow.setNome("Festival do Forró on Nit");
        ingressoShow.SetPreco(100.00);

        Console.WriteLine("---- Atualizando o preço ----");
        double precoA = ingressoShow.GetPreco();
        string showA = ingressoShow.GetNomeShow();

        Console.WriteLine($"O novo valor para o show {showA} é: R${precoA}");
    }
}
