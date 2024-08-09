using System;
using System.Globalization;

namespace aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: DetalharData / 2: CalcularDescontoINSS");
            Console.Write("Digite a opção: ");
            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    DetalharData();
                    break;
                case 2:
                    CalcularDescontoINSS();
                    break;
                default:
                    Console.WriteLine("Opção errada!");
                    break;
            }
        }
        public static void DetalharData()
        {
            Console.Write("Digite uma data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            string semana = string.Format($"\nSemana: { data.ToString(@"dddd", new CultureInfo("PT-pt")) }");
            Console.WriteLine(semana);

            string mes = string.Format($"Mês: { data.ToString(@"MMMM", new CultureInfo("PT-pt")) }");
            Console.WriteLine(mes);

            if(data.DayOfWeek == DayOfWeek.Sunday)
            {
                string horas = string.Format("É Domingo! Horas: {0:HH:mm}", DateTime.Now);
                Console.WriteLine(horas);
            }
        }
        public static void CalcularDescontoINSS()
        {
            Console.Write("Salário: ");
            double Salário = double.Parse(Console.ReadLine());

            if(Salário <= 1212)
            {
                double desconto = Salário * 0.075;
                double final = Salário - desconto;
                Console.WriteLine($"Inss: {desconto}");
                Console.WriteLine($"Inss Descontado: {final}");
                //7,5%
            }
            else
            {
                if(Salário <= 2427.36)
                {
                double desconto = Salário * 0.09;
                double final = Salário - desconto;
                Console.WriteLine($"Inss: {desconto}");
                Console.WriteLine($"Inss Descontado: {final}");
                    //9%
                }  
                else
                {
                    if(Salário <= 3641.03)
                    {
                    double desconto = Salário * 0.12;
                    double final = Salário - desconto;
                    Console.WriteLine($"Inss: {desconto}");
                    Console.WriteLine($"Inss Descontado: {final}");
                        //12%
                    }
                    else
                    {
                        if(Salário <= 7087.22)
                        {
                        double desconto = Salário * 0.15;
                        double final = Salário - desconto;
                        Console.WriteLine($"Inss: {desconto}");
                        Console.WriteLine($"Inss Descontado: {final}");
                            //15%
                        }
                    }
                }
            } 
        }
    }
}