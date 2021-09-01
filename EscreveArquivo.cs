using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace TRAB03{

    public class EscreveArq : Emprestimo
    {
       
        
        private string ArqDir {get;set;}

        public EscreveArq(string arqDir)
        {
            ArqDir = arqDir;
        }

         public EscreveArq()
        {
            ArqDir = @"INSIRA O DIRETÓRIO DO ARQUIVO";
        }

        public void Data(Emprestimo emprs){
            //Cria arquivo no diretório
            FileStream fs = new FileStream("INSIRA O DIRETÓRIO DO ARQUIVO", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            //Ler input do usuário
            //Emprestimo criaEmp = new Emprestimo();
            sw.WriteLine(emprs);

            sw.Flush();

            sw.Close();

            fs.Close();

        }

       
       
        //FUNÇÃO DE LEITURA NÃO FUNCIONA POR ENQUANTO
        public void readArq(Emprestimo empr1){
                
                List<string> linhas = new List<string>();
                List<Emprestimo> lstEmp = new List<Emprestimo>();

                FileStream fs = new FileStream(ArqDir, FileMode.Open, FileAccess.Read);  
                StreamReader sr = new StreamReader(fs);  
                Console.WriteLine("Lista dos empréstimos feitos:");  
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                linhas = File.ReadAllLines(ArqDir).ToList();

               // string str = sr.ReadLine();
                while (linhas != null)  
                {  
                    Console.WriteLine(linhas);  
                    linhas = File.ReadAllLines(ArqDir).ToList();
                }  
                Console.ReadLine();  
                sr.Close();  
                fs.Close(); 
        }

        // public void ReadFile(Emprestimo emps){

        // List<Emprestimo> lstEmp = new List<Emprestimo>();
        // List<Livros> lstLivr = new List<Livros>();
        // List<string> linhas  = new List<string>();

        // linhas = File.ReadAllLines(ArqDir).ToList();

        // foreach(string linha in linhas)
        // {
        //     string[] item = linha.Split("\n");
        //     Emprestimo e = new Emprestimo(int.Parse(item[0]), item[1], item[2], item[3],item[4]);
        //     lstEmp.Add(e);
        // }
        //     for (int i = 0; i < lstEmp.Count; i++)
        //     {
        //         Emprestimo emprestimo = lstEmp[i];
        //         Emprestimo x = emprestimo;
        //         Console.WriteLine(x);
        // }



        // }
    }





    }