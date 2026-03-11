using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_C_.MatriculaFaculdade;

internal class MatriculaTeste
{
// --- Exercício 9 Testando a Classe de Matrícula ----

    static void Main()
    {
        // Criando a matrícula
        Matricula matricula = new Matricula("João Pedro", "Engenharia de Computação", 202601, "10/06/2025");

        // Exibindo estado inicial
        matricula.ExibirInformacoes();

        // Alterando estados
        matricula.Trancar();
        matricula.ExibirInformacoes();

        matricula.Reativar();
        matricula.ExibirInformacoes();
    }
}
