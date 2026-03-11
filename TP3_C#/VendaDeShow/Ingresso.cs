using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_C_.VendaDeShow;

internal class Ingresso
{
    // ---- Exercício 2 Criando a Classe "Ingresso" ----
    // É o identificador visual para o cliente.
    public string nomeDoShow;
    // Define o valor monetário da transação.
    public double preco;
    // É o controle de inventário (estoque).
    public int quantidadeDisponivel;


    // ---- Exercício 3 Métodos Básicos da Classe "Ingresso" ----
    public void alterarPreco(double NovoPreco) { preco = NovoPreco; }
    public void alterarQuantidade(int NovaQuantidade) { quantidadeDisponivel =  NovaQuantidade; }

    public void ExibirInformacoes() {
        Console.WriteLine("\n--- Registro de Ingresso ---");
        Console.WriteLine($"Nome do Show: {nomeDoShow} \nPreço do Show: R${preco} \nQuantidade de ingresso disponivel: {quantidadeDisponivel}.");
        Console.WriteLine("----------------------------\n");
    }

    // ---- Exercício 5 Criando Métodos de Propriedade (Getters e Setters) ----
    public string GetNomeShow() { return nomeDoShow;}
    public double GetPreco() { return preco;}
    public int GetQuantidadeDisponivel() { return quantidadeDisponivel;}

    public void setNome(string novoSNome) { nomeDoShow = novoSNome;}
    public void SetPreco(double novoSPreco) { preco = novoSPreco; }
    public void SetQuantidade(int NovaQuantidade) { quantidadeDisponivel = NovaQuantidade; }

    // --- Exercício 6 Adicionando Construtores à Classe "Ingresso" ----
    public Ingresso(string nomeInicial, double precoInicial, int qtdInicial)
    {
        nomeDoShow = nomeInicial;
        preco = precoInicial;
        quantidadeDisponivel = qtdInicial;
    }
}
