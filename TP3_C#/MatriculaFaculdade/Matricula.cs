using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_C_.MatriculaFaculdade;

// ---- Exercício 7 Modelando uma Matrícula ----
internal class Matricula
{
    public string nomeDoAluno;
    public string curso;
    public int numMatricula;
    public string situacao;
    public string dataInicial;

    public Matricula(string nomeDoAlunoIni, string cursoIni, int numMatriculaIni, string dataInicialIni)
    {
        nomeDoAluno = nomeDoAlunoIni;
        curso = cursoIni;
        numMatricula = numMatriculaIni;
        dataInicial = dataInicialIni;
        situacao = "Ativa";

    }

    // ---- Exercício 8 Criando Métodos na Classe de Matrícula ---
    public void Trancar() { situacao = "Trancada"; Console.WriteLine($"A matrícula de {nomeDoAluno} foi trancada."); }
    public void Reativar()
    {
        situacao = "Ativa";
        Console.WriteLine($"A matrícula de {nomeDoAluno} foi REATIVADA.");
    }

    // Exibe o relatório acadêmico
    public void ExibirInformacoes()
    {
        Console.WriteLine("\n======= DADOS DA MATRÍCULA =======");
        Console.WriteLine($"Aluno: {nomeDoAluno}, \nNúmero: {numMatricula}, \nCurso: {curso}, \nData de Início: {dataInicial}, \nSituação Atual: {situacao}");
        Console.WriteLine("==================================\n");
    }
}
