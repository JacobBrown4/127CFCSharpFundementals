int iterator = 0;
// Like a while loop,  but runs at least one time
// No matter the condition
do
{
    Console.WriteLine("Hello!");
    iterator++;
}
while (iterator < 5);


do{
    Console.WriteLine("My condition is false!");
}
while(false);

while(false){
    Console.WriteLine("My condition is false!");
}