//Delaring the vairbale
int numberOfGuests;
int slicesPerGuest =3; //Assuming each guest eats 3 slices of zaa
int slicesPerPizza = 8; // Assuming the standard slice of pizza has 8 slices

//Prompt user tp enter the # of guest
Console.Write("Enter the number of guest: ");
//Call the parse function to turn the value the user entered into 
//an int
numberOfGuests = int.Parse(Console.ReadLine());

//calc the number of slices needed
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

//calc the number of pizzas reqiured
int reqiuredPizzas =(int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);
//takes our result and roounds it up to the next math interger

//Outputs the result to User
Console.WriteLine($"for {numberOfGuests}, you'll need {reqiuredPizzas} pizzas");