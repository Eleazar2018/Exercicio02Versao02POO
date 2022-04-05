using System;
using System.Globalization;

class DoLoop { 
    public static void Main() 
    { string myChoice;
        
        do { 
            Console.WriteLine("Cálculo das áreas das figuras geométricas\n"); 
            Console.WriteLine("T - Cálcular a área de um Triângulo"); 
            Console.WriteLine("C - Cálcular a área de um Circulo"); 
            Console.WriteLine("Z - Cálcular a área de um Trapézio"); 
            Console.WriteLine("Q - Cálcular a área de um Quadrado");
            Console.WriteLine("R - Cálcular a área de um Retângulo");
            Console.WriteLine("S - Sair\n"); 
            Console.WriteLine("Escolha a opção (T,C,Z,Q, ou S para sair): "); 
            
            myChoice = Console.ReadLine();
            switch(myChoice) 
            { case "T": 
                case "t":
                    double A, C;
                    Console.WriteLine("Entre com a medida de A (cm): ");
                    A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Console.WriteLine("Entre com a medida de B (cm): ");
                    //B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Entre com a medida de C (cm): ");
                    C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    double area = A * C / 2;
                    Console.WriteLine("Área do triângulo é = " + area.ToString("F2", CultureInfo.InvariantCulture) + " cm2");
                    break; 
              case "C": 
                case "c":
                    double C1;
                    //Console.WriteLine("Entre com a medida de A (cm): ");
                    //A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Console.WriteLine("Entre com a medida de B (cm): ");
                    //B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Entre com a medida de C (cm): ");
                    C1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double area1 = 3.141516 * C1;
                    Console.WriteLine("Área do circulo é = " + area1.ToString("F2", CultureInfo.InvariantCulture) + " cm2");
                    break; 
                case "Z": 
                case "z":
                    double A2, B2, C2;
                    Console.WriteLine("Entre com a medida de A (cm): ");
                    A2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Entre com a medida de B (cm): ");
                    B2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Entre com a medida de C (cm): ");
                    C2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double area2 = ((A2 + B2 )/ 2) * C2;
                    Console.WriteLine("Área do trapézio é = " + area2.ToString("F2", CultureInfo.InvariantCulture) + " cm2");
                    break; 
                case "Q": 
                case "q":
                    double B3;
                    //Console.WriteLine("Entre com a medida de A (cm): ");
                    //A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Entre com a medida de B (cm): ");
                    B3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Console.WriteLine("Entre com a medida de C (cm): ");
                    //C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double area3 = B3 * B3 ;
                    Console.WriteLine("Área do quadrado é = " + area3.ToString("F2", CultureInfo.InvariantCulture) + " cm2");
                    break;
                case "R":
                case "r":
                    double A4, B4;
                    Console.WriteLine("Entre com a medida de A (cm): ");
                    A4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Entre com a medida de B (cm): ");
                    B4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Console.WriteLine("Entre com a medida de C (cm): ");
                    //C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double area4 = A4 * B4;
                    Console.WriteLine("Área do retângulo é = " + area4.ToString("F2", CultureInfo.InvariantCulture) + " cm2");
                    break;

                case "S": 
                case "s": 
                    Console.WriteLine("Tchau."); 
                    break; 
                default: 
                    Console.WriteLine("{0} não é uma opção válida", myChoice); 
                    break; 
            } 
            Console.Write("Pressione ENTER para continuar..."); 
            Console.ReadLine(); 
            Console.WriteLine(); 
        } while (myChoice != "S" && myChoice != "s"); 
        } 
}