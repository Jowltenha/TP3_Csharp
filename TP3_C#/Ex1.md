# Conceitos Fundamentais
1. ***Classe:*** É o molde. Ela define quais características e comportamentos um objeto do seu tipo terá, mas não é o objeto em si.

2. ***Objeto:*** É a instância real criada a partir do molde. Se a classe é a planta de uma casa, o objeto é a casa construída na rua.

3. ***Campos (ou Atributos):*** São as características ou dados que a classe armazena (ex: cor, nome, preço).

4. ***Métodos:*** São as ações ou comportamentos que a classe pode realizar (ex: acelerar, salvar, calcular).

## Exemplo Prático (C#)
    using System;
    
    // 1. Classe 
    public class Livro
    {
        // 2. Campos/Atributos
        public string Titulo;
        public string Autor;
        public int TotalPaginas;
        public int PaginasLidas;
    
        // 3. Método 
        public void ExibirProgresso()
        {
            double porcentagem = (double)PaginasLidas / TotalPaginas * 100;
            Console.WriteLine($"Livro: {Titulo}");
            Console.WriteLine($"Progresso de leitura: {porcentagem}% concluído.");
        }
    }
    
    class Program
    {
        static void Main()
        {
            // 4. Criação de um Objeto 
            Livro meuLivro = new Livro();
            
            // Atribuindo valores aos campos do objeto
            meuLivro.Titulo = "Dom Casmurro";
            meuLivro.Autor = "Machado de Assis";
            meuLivro.TotalPaginas = 256;
            meuLivro.PaginasLidas = 64;
    
            // Chamando o método do objeto
            meuLivro.ExibirProgresso();
        }
    }
## Relação entre Teoria e Exemplo
1. ***Classe:*** public class Livro define a estrutura que todo livro no sistema deve seguir.

2. ***Atributos:*** Titulo e PaginasLidas representam o estado do livro (os dados que ele carrega).

3. ***Método:*** ExibirProgresso() é a funcionalidade que utiliza os dados internos (PaginasLidas e TotalPaginas) para realizar um cálculo e exibir uma informação.

4. ***Objeto:*** meuLivro é o item específico criado na memória. Enquanto a classe Livro é genérica, meuLivro possui dados específicos como "Dom Casmurro".