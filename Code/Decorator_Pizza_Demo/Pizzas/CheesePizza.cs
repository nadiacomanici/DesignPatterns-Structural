namespace Decorator_Pizza_Demo.Pizzas
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza)
        {
        }

        public override string Name => $"{base.Name} with Cheese";
        public override double Price => base.Price + 3;
    }
}
