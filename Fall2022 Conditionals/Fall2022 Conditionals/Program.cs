// Conditionals:
// Conditionals allow us to create various paths within our code that we can take and perform different actions from 

// If/ Else Statement:
// Ask a question, Perform an action if true, and perform a different action if false.
// We will create boolean statements to represent our conditions, and then write some code that runs if any of those conditions are true

// if(Condition){
// Code we want to run if condition is true
//} else {
// code we want to run if condition is false
//}

var isSunny = true;
var isRaining = false;
var isCold = false;
int Temp = 72;

if (isSunny)
{
    Console.WriteLine("It's sunny outside");
} 
else if(isSunny && Temp >=65)
{
    Console.WriteLine("It's a lovely day!");
} 
else
{
    Console.WriteLine("It's not sunny outside");
}

// Else if / Else are both Optional. 'IF' block is the only one that is madatory 
// How do we expand this to unclude more conditions?
// else if blick allows us as a user o check for an additional condition in the event that the first one is false


//if (isSunny && Temp > 65)
//{
//    Console.WriteLine("It's sunny outside");
//}
//
//
//
//while (Temp >= 65)
//{
//    Console.WriteLine("It's sunny!!!");
//   Temp--;
//
//}
