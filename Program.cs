using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace TRAB03
{


    class Program
    {



        static void Main(string[] args)
        {
            //DateTime dateTime = Convert.ToDateTime("dd-MM-yyyy");
            //DateTime aDate = aDate.ToLocalTime();
            string dt1 = null, dt2 = null, dt3 = null, titulo, autor, edt, desc, material;
            DateTime dRetirada, dDevolucao, dEfetiva;
            string email;
            int escolhe,ano;

            //string dirArq = @"\\Lista_Emp.txt";
            EscreveArq escreve = new EscreveArq();
            List<Emprestimo> LstEmprestimos = new List<Emprestimo>();
            Emprestimo objEmp = new Emprestimo();
            GeraBinario gBin = new GeraBinario();


            Livros lvr1 = new Livros("O Monge e o Executivo", "James Hunter", "Sextante", 2004, 1, "3/1/2014", "3/2/2014", "1/2/2014", "pessoa@email.com");
            Emprestimo emp1 = new Utensilios(2, "23/12/2013", "27/12/2013", "29/12/2014", "util@hotmail.com", "Frigideira", "Teflon");



            do
            {
                Console.WriteLine("1. Empréstimo de livro\n2. Empréstimo de utensílio\n3. Listar empréstimos atrasados\n4. Listar todos os empréstimos\n5.Sair");
                escolhe = int.Parse(Console.ReadLine());


                switch (escolhe)
                {
                    case 1:

                        
                        Console.WriteLine("Título: ");
                        titulo = Console.ReadLine();
                        Console.WriteLine("Autor: ");
                        autor = Console.ReadLine();
                        Console.WriteLine("Editora: ");
                        edt = Console.ReadLine();
                        Console.WriteLine("Ano: ");
                        ano = int.Parse(Console.ReadLine());
                        Console.WriteLine("E-mail: ");
                        email = Console.ReadLine();
                        Console.WriteLine("Data de Retirada: ");
                        dt1 = Console.ReadLine();
                        Console.WriteLine("Data de Devolução: ");
                        dt2 = Console.ReadLine();
                        Console.WriteLine("Data de Devolução Efetiva: ");
                        dt3 = Console.ReadLine();

                        Emprestimo emp2 = new Livros(titulo, autor, edt, ano, 1, dt1, dt2, dt3, email);
                        //gBin.escreveArquivo(1,dt1,dt2,dt3,email,titulo,autor,edt,ano);
                        LstEmprestimos.Add(emp2);
                        escreve.Data(emp2);
                        //Console.ReadKey();
                        //LstEmprestimos = File.ReadAllLines(dirArq).ToList();

                        Console.WriteLine("Empréstimo cadastrado com sucesso!\nTecle <ENTER> para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:

                        //tipoEmp=2;
                        Console.WriteLine("Descrição do utensílio: ");
                        desc = Console.ReadLine();
                        Console.WriteLine("Material do utensílio: ");
                        material = Console.ReadLine();
                        Console.WriteLine("E-mail: ");
                        email = Console.ReadLine();
                        Console.WriteLine("Data de Retirada: ");
                        dt1 = Console.ReadLine();
                        Console.WriteLine("Data de Devolução: ");
                        dt2 = Console.ReadLine();
                        Console.WriteLine("Data de Devolução Efetiva: ");
                        dt3 = Console.ReadLine();
                        Emprestimo emp3 = new Utensilios(2, dt1, dt2, dt3, email, desc, material);
                        LstEmprestimos.Add(emp3);
                        escreve.Data(emp3);

                        Console.WriteLine("Empréstimo cadastrado com sucesso!");
                        // Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        foreach (Emprestimo l in LstEmprestimos)
                        {
                            dRetirada = Convert.ToDateTime(dt1);
                            dDevolucao = Convert.ToDateTime(dt2);
                            dEfetiva = Convert.ToDateTime(dt3);

                            DateTime dat1 = new DateTime(dDevolucao.Year, dDevolucao.Month, dDevolucao.Day);
                            DateTime dat2 = new DateTime(dEfetiva.Year, dEfetiva.Month, dEfetiva.Day);

                            Console.WriteLine("Empréstimos atrasados: ");
                            if (dat2 > dat1)
                            {
                                Console.WriteLine(l);
                            }


                        }
                        // escreve.readArq(objEmp);
                        Console.ReadKey();
                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("Empréstimos feitos: \n");
                        foreach (Emprestimo l in LstEmprestimos)
                        {
                            Console.WriteLine(l);
                        }
                        Console.ReadKey();
                        break;
                    
                    case 5:
                        Console.WriteLine("Tecle <ENTER> para sair...");
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("Valor inválido!");
                        Console.Error.Close();
                        break;
                }


            } while (escolhe >= 1 && escolhe <= 4);




            Console.WriteLine("Empréstimos feitos: \n");
            foreach (Emprestimo l in LstEmprestimos)
            {
                Console.WriteLine("Empréstimos: \n" + l);
            }

        }
    }
}
