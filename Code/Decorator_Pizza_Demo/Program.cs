using System;
using Decorator_Pizza_Demo.Pizzas;

namespace Decorator_Pizza_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza smallPizza = new SmallPizza();
            Console.WriteLine($"{smallPizza.Name} - {smallPizza.Price} ron");

            Pizza mediumPizza = new MediumPizza();
            Console.WriteLine($"{mediumPizza.Name} - {mediumPizza.Price} ron");

            Pizza largePizza = new LargePizza();
            Console.WriteLine($"{largePizza.Name} - {largePizza.Price} ron");
        }
    }
}
