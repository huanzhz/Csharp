// https://www.youtube.com/watch?v=KT2VR7m19So&list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN&index=2

// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/hello-world?WT.mc_id=Educationalcsharp-c9-scottha&tutorial-step=1


/* overview string foo
foo.Length  |   foo.Trim()  |   foo.Replace()   |   foo.ToUpper()   |   foo.ToLower()
foo.Contains()  |

int |  double  |  decimal |  long  |  short  |
Math.PI
*/

Console.WriteLine("Hello World!");
//output-> Hello World!


//---------------------------------------------
string aFriend = "Bill";
Console.WriteLine(aFriend);
//output-> Bill

Console.WriteLine("Hello " + aFriend);
//output-> Hello Bill

Console.WriteLine($"Hello {aFriend}");
// add $ can include varibles
//output-> Hello Bill
//---------------------------------------------

//---------------------------------------------     foo.Length
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
//output-> My friends are Maria and Sage

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
/*output-> 
My friends are Maria and Sage
The name Maria has 5 letters.
The name Sage has 4 letters.
*/

//---------------------------------------------

//---------------------------------------------     foo.Trim()
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

/*output-> 
[      Hello World!       ]
[Hello World!       ]
[      Hello World!]
[Hello World!]
*/
//---------------------------------------------

//---------------------------------------------     foo.Replace(), foo.ToUpper(), foo.ToLower()
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

/*output-> 
Hello World!
Greetings World!
*/

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
/*output-> 
Hello World!
Greetings World!
GREETINGS WORLD!
greetings world!
*/
//---------------------------------------------

//---------------------------------------------     foo.Contains()
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

/*output-> 
True
False
*/

//---------------------------------------------

//=============================================================================
//---------------------------------------------     integers,int
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
Console.WriteLine(d);

//output-> 3

//---------------------------------------------

//---------------------------------------------     2147483647
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

/*output-> 
The range of integers is -2147483648 to 2147483647
An example of overflow: -2147483646
*/

//---------------------------------------------

//---------------------------------------------     double
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

/*output-> 
The range of double is -1.79769313486232E+308 to 1.79769313486232E+308
The number to the left of the E is the significand. The number to the right is the exponent, as a power of 10.
*/
//---------------------------------------------

//---------------------------------------------     decimal, short, long
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

/*output-> 
The range of the decimal type is -79228162514264337593543950335 to 79228162514264337593543950335.
*/

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
//The M suffix on the numbers is how you indicate that a constant should use the decimal type.
/*output-> 
0.333333333333333
0.3333333333333333333333333333
*/

short min = short.MinValue;
short max = short.MaxValue;
Console.WriteLine($"The range of the short type is {min} to {max}");
/*output-> 
The range of the short type is -32768 to 32767
*/

long min = long.MinValue;
long max = long.MaxValue;
Console.WriteLine($"The range of the long type is {min} to {max}");
/*output-> 
The range of the long type is -9223372036854775808 to 9223372036854775807
*/

//---------------------------------------------     

//---------------------------------------------     Math.PI
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);
Console.WriteLine($"Math.PI: {Math.PI}");
/*output-> 
19.6349540849362
Math.PI: 3.14159265358979
*/

//---------------------------------------------     
//=============================================================================



