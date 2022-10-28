// See https://aka.ms/new-console-template for more information
using ConsoleApp1;



CustomerCatalogue customerCatalogue = new CustomerCatalogue();
PizzaCatalogue pizzaCatalogue = new PizzaCatalogue();

//Test af AddBook

Console.WriteLine("Test af Add customer");
Customer bob = new Customer("bob", "123 bobford");
Console.WriteLine($"Antal Pizzaer inden add af Pizza {customerCatalogue.Count()}");
customerCatalogue.addCustomer(bob);
Customer lars = new Customer("lars", "345 fidusen");
Customer johnJohnJohnson = new Customer("johnJohnJohnson", "1 johnstead");
customerCatalogue.addCustomer(lars);
customerCatalogue.addCustomer(johnJohnJohnson);
Console.WriteLine($"Antal Customers efter add af 3 Customers {customerCatalogue.Count()}");

//Test af LookUpBook
Console.WriteLine("Test af LookUpCustomer");
Customer foundCustomer = customerCatalogue.LookUpCustomer(1);
if (foundCustomer != null)
{
    //Udskriv foundBook
    Console.WriteLine($"Customer fundet {foundCustomer.ToString()}");
}
else
{
    //Udskriv bog ikke fundet
    Console.WriteLine("Customer ikke fundet");
}
//Test af RemoveCustomers
Console.WriteLine("Test af RemoveCustomer");
Console.WriteLine($"Antal bøger inden remove customer {customerCatalogue.Count()}");

customerCatalogue.RemoveCustomer(1);
Console.WriteLine($"Antal Customer efter Remove customer {customerCatalogue.Count}");

//Test af PrintCustomers
Console.WriteLine("Print Customers");
customerCatalogue.PrintCustomers();

//Test af upDateCustomer
Customer upDatedlaura = new Customer("laura", "345 fidusen");
customerCatalogue.UpdateCustomer(2, upDatedlaura);
Console.WriteLine("Print Customers after update");
customerCatalogue.PrintCustomers();

Console.WriteLine("Test of PizzaCatalogue");

Console.WriteLine("adding Pizzas");
Pizza firstPizza = new Pizza(1, "potato", 20, "potatosause", "potatocheese");
Pizza secondPizza = new Pizza(2, "tomato", 90, "tomatosause", "cheese");
secondPizza.AddIngredient("ham");
Pizza thirdPizza = new Pizza(3, "salatPizza", 94, "tomatosauce", "cheese");
thirdPizza.AddIngredient("salat");
pizzaCatalogue.AddPizza(firstPizza);
pizzaCatalogue.AddPizza(secondPizza);
pizzaCatalogue.AddPizza(thirdPizza);
pizzaCatalogue.PrintPizzas();

Console.WriteLine("adding 4. pizza");
Pizza rthirdPizza = new Pizza(3, "salatPizza", 96, "tomatosauce", "cheese");
rthirdPizza.AddIngredient("kebab");
rthirdPizza.AddIngredient("salat");
Pizza newPizza = new Pizza(4, "boring", 60, "tomatosauce", "cheese");
pizzaCatalogue.AddPizza(newPizza);
pizzaCatalogue.PrintPizzas();

Console.WriteLine("removing firstPizza");
pizzaCatalogue.DeletePizza(1);
pizzaCatalogue.PrintPizzas();

Console.WriteLine("updating thirdPizza");
pizzaCatalogue.UpdatePizza(3, rthirdPizza);
pizzaCatalogue.PrintPizzas();

Console.WriteLine("ran out of ham for secondPizza");
secondPizza.RemoveIngredient("ham");
pizzaCatalogue.PrintPizzas();

