bool isSnowing = true;
bool isGoingOutside = false;

if(isSnowing)
{
Console.WriteLine("It is snowing out!");
}

if(isSnowing && isGoingOutside)
{
Console.WriteLine("Better where some snow boots!!!");
}
if(!isSnowing || !isGoingOutside)
{
Console.WriteLine("I do not need any boots!!");
}
if(isSnowing ^ isGoingOutside)
{
Console.WriteLine("I will only go outside once the snow stops!!!");
}



if(!isSnowing){
    Console.WriteLine("There is no need to shovel snow!!");
}
else{
    Console.WriteLine("I guess I need to shovel the snow!");
}


if(isSnowing){
    Console.WriteLine("I guess I have to go clear off the wifes cars!!");
}
else if(!isSnowing){
    Console.WriteLine("I dont have to clear off the cars!!");
}
else{
    Console.WriteLine("I dont know what we are even talking about!!");
}