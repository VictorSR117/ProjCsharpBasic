using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
             Pessoa p1 = new Pessoa();

             p1.Nome = "Bob";
             p1.Idade = 20;

             p1.Apresentar();
            
             Retangulo r = new Retangulo();
             r.DefinirMedidas(30, 30);
             System.Console.WriteLine($"Área: {r.ObterArea()}");
            
             Retangulo r2 = new Retangulo();
             r2.DefinirMedidas(0, 0);
             System.Console.WriteLine($"Área: {r2.ObterArea()}");

             Aluno a1 = new Aluno();

             a1.Nome = "Luiz";
             a1.Idade = 20;
             a1.Nota = 8;
             a1.Documento = "batata";

             a1.Apresentar();

             Professor pr1 = new Professor();

             pr1.Nome = "Roberto";
             pr1.Idade = 40;
             pr1.Salario = 1149;
             pr1.Documento = "teste";

             pr1.Apresentar();

             Aluno a2 = new Aluno();

             a2.Nome = "Luiz";
             a2.Idade = 20;
             a2.Nota = 8;
             a2.Documento = "batata";
             a2.Apresentar();

             Professor pr2 = new Professor();

             pr2.Nome = "Roberto";
             pr2.Idade = 40;
             pr2.Salario = 1149;
             pr2.Documento = "teste";
             pr2.Apresentar();
            
             Calculadora calc = new Calculadora();
             Console.WriteLine("Resultado da 1° soma: " + calc.Somar(10, 10));
             Console.WriteLine("Resultado da 2º soma: " + calc.Somar(10, 10, 10));

             Corrente c = new Corrente();
             c.Creditar(100);
             c.ExibirSaldo();

             Computador comp = new Computador();
             Console.WriteLine(comp.ToString());

             ICalculadora calc = new Calculadora();
             Console.WriteLine(calc.Somar(20, 20));

            var caminho = "D:\Users\victo\OneDrive - Fatec Centro Paula Souza\cursos e certificados\Cursos\DIO\C#\Programando com Orientação a Objeto com C#\Projeto\TrabalhandoComArquivos";
             var caminho = "D:\\TrabalhandoComArquivos";

             FileHelper helper = new FileHelper();
             helper.ListarDiretorios(caminho);

             FileHelper helper = new FileHelper();
             helper.ListarArquivosDiretorios(caminho);

             FileHelper helper = new FileHelper();
             caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "SubPastaTeste3"); D:\\TrabalhandoComArquivos\\Pasta Teste 3\\SubPastaTeste3
             Console.WriteLine("Criando diretório: " + caminhoPathCombine);
             helper.CriarDiretorios(caminhoPathCombine);
            
             FileHelper helper = new FileHelper();
             caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
             helper.ApagarDiretorios(caminhoPathCombine, true);

             FileHelper helper = new FileHelper();
             caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
             helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            
             FileHelper helper = new FileHelper();
             var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3"};
             caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
             helper.CriarArquivoTextoStream(caminhoArquivo, listaString);

             FileHelper helper = new FileHelper();
             caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
             var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6"};
             helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            
             FileHelper helper = new FileHelper();
             caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
             helper.LerArquivoStream(caminhoArquivo);
            
             FileHelper helper = new FileHelper();
             caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
             novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
             novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream-alterado.txt");
             helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);

             FileHelper helper = new FileHelper();
             CaminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
             CaminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
             helper.CopiarArquivo(CaminhoArquivoTeste, CaminhoArquivoTesteCopia, false);
            
            FileHelper helper = new FileHelper();
            CaminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            helper.DeletarArquivo(CaminhoArquivoTesteCopia);
        }
    }
}
