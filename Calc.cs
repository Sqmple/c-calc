using System;

namespace Learn_c_
{
    class Calculator{
        public void Add(int a,int b){
            int result = a + b;
            Console.WriteLine($"Ответ: {result}");
        }
        public void Add(int a,int b,int c){
            int result = a + b + c;
            Console.WriteLine($"Ответ: {result}");
        }
        public int Add(int a,int b,int c,int d ){
            int result = a + b + c +d;
            Console.WriteLine($"Ответ: {result}");
            return result;
        }
        public void Add(double a,double b){
            double result = a + b;
            Console.WriteLine($"Ответ: {result}");
        }
        class Program{
            static void Main(){
                var calculator = new Calculator();
                calculator.Add(1,2);
                calculator.Add(1,2,3);
                calculator.Add(1,2,3,4);
                calculator.Add(3.1,2.3);
                Console.ReadKey();
            }
        }

    }
}