/*Людина загадує число, компьютер відгадує*/

Console.WriteLine("Hello, enter a number from 1 to 5 ");

int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 1 || userNumber > 5)
{
    Console.WriteLine("Write the number correctly");
    return;
}
while (true) 
{
    int randomNumber = new Random().Next(1, 6);
    if (userNumber == randomNumber)
    {
        Console.WriteLine($"I guessed this number {userNumber}");
        break;
    } else { 
        Console.WriteLine($"I guessed wrong my number {randomNumber} you number {userNumber}, let's try again [y/n]");
        string text = Console.ReadLine();
        if (text == "y")
        {
            continue;
        } else
            Console.WriteLine("Ok,Good bye");
        break;
    }
}


    
   





