using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Threading;
using System.Transactions;

Random random = new Random();
int randomNumber = random.Next(1, 10);
int UserNumber = 0;
Console.WriteLine("Hello, Let's play with the computer. Guess a random number from 1 to 10. You have three attempts.");
Console.Write("Enter number:");

UserNumber = int.Parse(Console.ReadLine());
if (UserNumber == randomNumber){

    Console.WriteLine("You won! The number was: " + randomNumber);

}else{

    Console.WriteLine("Your first Attempt Failed! Enter number again: ");
    UserNumber = int.Parse(Console.ReadLine());
   
    if (UserNumber == randomNumber){

        Console.WriteLine("You won! The number was: " + randomNumber);

    }else{

        Console.WriteLine("Your second Attempt Failed! Enter number again: ");
        UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == randomNumber) { 
            Console.WriteLine("You won! The number was: " + randomNumber);
        }else{
            Console.WriteLine("Game over! The number was: " + randomNumber);
        }

    }

}
