// See https://aka.ms/new-console-template for more information

// AND - &&
// hand us true if the value on the left and right of the && are both true, hand us false otherwise
// acts like an and gate.

//or - ||
// like an or gate

// not -!
//like a not gate
//!true -> false

// if(condition){
//    code we run if conition is true 
// }
// else if(consition){
//         code ww run if prevu=ious conditions are false
// }
// else {
// code we run if previous conditions are false
// }
int num = 3;
int num2 = 17;
bool isCold = true;
bool isSunny = true;
bool isRainy = true;

if (isRainy){
    Console.WriteLine("it's rainy tody!");
}
else if (isSunny){
    Console.WriteLine("don't look at rhe sun");
}
else{
    Console.WriteLine("there are no clouds in the sky");
}

// equivalence operaators ==
if(num == 3){
    Console.WriteLine("our number is 3!");
}

// inequality operator !=
if(num2 != 17){
    Console.WriteLine("num2 is not equal to 17!");
}

// comparison operators (>,<,<=,>=)

// user input example
Console.WriteLine("Is today you birthday? Y/N");
string condInput = Console.ReadLine();
condInput = condInput.ToUpper();
if (condInput == "Y"){
    Console.WriteLine("Happy Birthday!");
}
else{
    Console.WriteLine("Maybe tomorrow!");
}
