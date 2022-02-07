// Create initial target
int number = 100;

// for (initializer; condition; iterator) {body}


//1     //2       //3       //4
for (int i = 1; i <= number; i++)
{
    // 5
    Console.WriteLine(i);
}

//1 - for Keyword
//2 - Declaration and initilization of iterator
//3 - Boolean expression for the loop
//4 - Increament the iterator at the eEND of the loop
//5 - Body, runs per iteration if the condition is true

int numberTwo = 200;
for (int i = 1; i <= numberTwo; i++){
    numberTwo = numberTwo - i;
    Console.WriteLine(numberTwo);
    Console.WriteLine($"i is {i}");
}