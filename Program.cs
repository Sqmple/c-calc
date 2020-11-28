using System;

namespace Learn_c_
{
  
class Person
{
    public string name{get; set;} = "";
    public int age {get; set;} = 0;

}
     
class Program
{
  static void Main(){
    Person person = new Person();
    Console.WriteLine("Введите ваше имя: ");
    person.name = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Введите ваш возраст: ");
    person.age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Имя:{person.name}");
    Console.WriteLine($"Возраст:{person.age}");

  }

  
  }
}