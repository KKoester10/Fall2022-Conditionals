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

if (isSunny){
    Console.WriteLine("It's sunny outside");
} 
else if(isSunny && Temp >=65){
    Console.WriteLine("It's a lovely day!");
} 
else{
    Console.WriteLine("It's not sunny outside");
}

// Else if / Else are both Optional. 'IF' block is the only one that is madatory 
// How do we expand this to unclude more conditions?
// else if blick allows us as a user o check for an additional condition in the event that the first one is false

//----------------------------------------------------------------------------------------------------------------------------------------------------------
// Switch Case Statement
// We can use Switch/Case with many other values instead of just booleans
// int,bool,enums,floats,string,characters...(Primitive types)
// You provide a value you want to 'Switch' on, and the code falls into a 'case' where the values match
// Essentially... this means a switch case is just a bunch of equality checks
var errorCode = 404;

switch (errorCode)
{
    case 404:
        Console.WriteLine("Page Not Found.");
        break;
    case 203:
        Console.WriteLine("Incorrect value");
        break ;
    case 502:
        Console.WriteLine("Incorrect value");
        break;
    case 505:
        Console.WriteLine("Incorrect value");
        goto case 404;
    default:
        Console.WriteLine("Unknown error occured");
        break;
}
// beak -> ends the switch case
// goto case x-> jumps over to another case
// goto default -> jumps to default
// we can put case labesls next to each other without code inbetween if we want them to perform the same action.

//---------------------------------------------------------------------------------------------------------------------------------------------------------------
//Ternary-(3 parts) Statements
// one of the main uses for ternay statements is shorthand for assigning values of some kind
var moodRating = 0;
var isHappy = false;
var isGald = true;

if (isHappy)
{
    moodRating = 100;
}
else
{
    moodRating = -100;
}

// moodRating = isHappy ? 100 : isGald ? 50 : -100; 
moodRating = isHappy ? 100 : -100; 




