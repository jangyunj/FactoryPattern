using FactoryPattern;

Console.WriteLine("How much money do you have ? ");
var userInput = decimal.Parse(Console.ReadLine());

var lunchMenu = CostcoFactory.GetLunch(userInput); //4. return type is interface 
lunchMenu.Order(); //5. stubbed out method - no implementation
