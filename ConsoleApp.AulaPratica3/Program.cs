using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.AulaPratica3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula Prática de C# 3!");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Lambda Functions");
            Console.WriteLine("---------------------------------------");

            PraticaComLambdas praticaComLambdas = new PraticaComLambdas();
            //praticaComLambdas.Exercicio1();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Pratica com LINQ 1");
            Console.WriteLine("---------------------------------------");

            PraticaComLinq praticaComLinq = new PraticaComLinq();
            //praticaComLinq.Exercicio1();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Pratica com LINQ 2");
            Console.WriteLine("---------------------------------------");

            PraticaExecucaoTardia praticaComLinq2 = new PraticaExecucaoTardia();
            praticaComLinq2.Exercicio1();

        }

        public void Listas1()
        {
            var arrayBase = new int[50];
            for (int i = 0; i < arrayBase.Length; i++)
            {
                arrayBase[i] = i;
            }

            IEnumerable<int> enumerable = arrayBase;
            IList<int> lista = arrayBase;
            ICollection<int> collection = arrayBase;
        
        }

        public void Listas2() 
        {
            var pessoas = new List<Pessoa>(5000);
            var pagamentos = new Dictionary<Guid, Pagamento>(50000);
            var rand = new Random();

            for (int i = 0; i < 5000; i++)
            {
                pessoas.Add(new Pessoa
                {
                    Id = i,
                    Nome = $"Pessoa {i}"
                });
            }

            for (int i = 0; i < 50000; i++)
            {
                var pagador = pessoas[rand.Next(0, 5001)];
                var recebedor = pessoas[rand.Next(0, 5001)];
                var idTransacao = Guid.NewGuid();

                pagamentos.Add(idTransacao, new Pagamento
                {
                    Pagador = pagador,
                    Recebedor = recebedor,
                    IdTransacao = idTransacao,
                    Valor = decimal.Parse($"{rand.Next(1, 10000)}.{rand.Next(0, 99)}")
                });
            }

            //1. Liste as Top 5 pessoas que receberam mais dinheiro

            //2. Liste as Top 5 transações mais altas (por valor) 

            //3. Liste as Top 5 pessoas que mais pagaram e quanto elas pagaram para cada recebedor

        }


        public class Pessoa
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        public class Pagamento
        {
            public Guid IdTransacao { get; set; }
            public Pessoa Pagador { get; set; }
            public Pessoa Recebedor { get; set; }
            public decimal Valor { get; set; }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public List<int> ExamScores { get; set; }
        }

    //    // These data files are defined in How to join content from
    //    // dissimilar files (LINQ).

    //    // Each line of names.csv consists of a last name, a first name, and an
    //    // ID number, separated by commas. For example, Omelchenko,Svetlana,111
    //    string[] names = System.IO.File.ReadAllLines(@"../../../names.csv");

    //    // Each line of scores.csv consists of an ID number and four test
    //    // scores, separated by commas. For example, 111, 97, 92, 81, 60
    //    string[] scores = System.IO.File.ReadAllLines(@"../../../scores.csv");

    //    // Merge the data sources using a named type.
    //    // var could be used instead of an explicit type. Note the dynamic
    //    // creation of a list of ints for the ExamScores member. The first item
    //    // is skipped in the split string because it is the student ID,
    //    // not an exam score.
    //    IEnumerable<Student> queryNamesScores =
    //        from nameLine in names
    //        let splitName = nameLine.Split(',')
    //        from scoreLine in scores
    //        let splitScoreLine = scoreLine.Split(',')
    //        where Convert.ToInt32(splitName[2]) == Convert.ToInt32(splitScoreLine[0])
    //        select new Student()
    //        {
    //            FirstName = splitName[0],
    //            LastName = splitName[1],
    //            ID = Convert.ToInt32(splitName[2]),
    //            ExamScores = (from scoreAsText in splitScoreLine.Skip(1)
    //                          select Convert.ToInt32(scoreAsText)).
    //                          ToList()
    //        };

    //    // Optional. Store the newly created student objects in memory
    //    // for faster access in future queries. This could be useful with
    //    // very large data files.
    //    List<Student> students = queryNamesScores.ToList();

    //    // Display each student's name and exam score average.
    //    foreach (var student in students)
    //    {
    //        Console.WriteLine("The average score of {0} {1} is {2}.",
    //            student.FirstName, student.LastName,
    //            student.ExamScores.Average());
    //    }

    ////Keep console window open in debug mode
    //Console.WriteLine("Press any key to exit.");
    //    Console.ReadKey();
    }
}
/* Output:
    The average score of Omelchenko Svetlana is 82.5.
    The average score of O'Donnell Claire is 72.25.
    The average score of Mortensen Sven is 84.5.
    The average score of Garcia Cesar is 88.25.
    The average score of Garcia Debra is 67.
    The average score of Fakhouri Fadi is 92.25.
    The average score of Feng Hanying is 88.
    The average score of Garcia Hugo is 85.75.
    The average score of Tucker Lance is 81.75.
    The average score of Adams Terry is 85.25.
    The average score of Zabokritski Eugene is 83.
    The average score of Tucker Michael is 92.
 */