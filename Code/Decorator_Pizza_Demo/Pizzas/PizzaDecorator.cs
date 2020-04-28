namespace Decorator_Pizza_Demo.Pizzas
{
    public class PizzaDecorator : Pizza
    {
        private Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Name => _pizza.Name;
        public override double Price => _pizza.Price;
    }
}
