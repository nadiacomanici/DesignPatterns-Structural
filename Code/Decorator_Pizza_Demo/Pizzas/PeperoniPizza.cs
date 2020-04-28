namespace Decorator_Pizza_Demo.Pizzas
{
    public class PeperoniPizza : PizzaDecorator
    {
        public PeperoniPizza(Pizza pizza) : base(pizza)
        {
        }

        public override string Name => $"{base.Name} with Peperoni";
        public override double Price => base.Price + 5;
    }
}
