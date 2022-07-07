

var r = new Random();
var favNumber = r.Next(1, 1000);

Console.WriteLine("Try to guess my favourite number:");

var userInput = int.Parse(Console.ReadLine());






if (favNumber < userInput)
{

    Console.WriteLine("too high");
}
else if (favNumber > userInput)
{

    Console.WriteLine("too low");

}

else
{

    Console.WriteLine("You guessed it!!!");
}