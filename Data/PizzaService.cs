
namespace BlazingPizza.Data
{
    public class PizzaService
    {
        public async Task<Pizza[]> GetPizzasAsync()
        {
            List<Pizza> pizzaList=new List<Pizza>(){
            new Pizza { Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon"},
                new Pizza { Name = "Buffalo chicken", Price =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up"},
                new Pizza { Name = "Veggie Delight", Price =  11.5M, Description = "It's like salad, but on a pizza"},
                new Pizza { Name = "Margherita", Price =  9.99M, Description = "Traditional Italian pizza with tomatoes and basil"},
                new Pizza { Name = "Basic Cheese Pizza", Price =  11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?"},
                new Pizza { Name = "Classic pepperoni", Price =  10.5M, Description = "It's the pizza you grew up with, but Blazing hot!" }               
        
            };
            var myTask = Task.Run( () => pizzaList.ToArray());
            return await myTask;
        }
    }
}