// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {

    }
}
/*var x = 2;
var y = 5;
Console.WriteLine($"x + y ={x + y}");
Console.WriteLine($"x - y ={x - y}");
Console.WriteLine($"x * y = {x * y}");
Console.WriteLine($"x / y = {x / y }");
string s1 = null;
Console.WriteLine(s1);
var s2 = s1?.ToUpper();
    var s3= s1 is null ? null : s1.ToUpper();
Console.WriteLine(s3);*/
/*var amountJOD = 100;
var currType = "USD";
var output = 0d;
var JODTOUSD = 1.41d;
var JODTOEUR = 1.19d;
var JODTOCAD = 1.78d;
switch(currType)
{
    case "USD":
        output = amountJOD*JODTOUSD;
        Console.WriteLine($"{amountJOD} JOD = {output}USD");
        break;
    case "EUR":
        output = amountJOD*JODTOEUR;
        Console.WriteLine($"{amountJOD} JOD = {output}EUR");
        break;
    case "CAD":
        output = amountJOD*JODTOCAD;
        Console.WriteLine($"{amountJOD} JOD = {output}CAD");
        break;
    default:
        Console.WriteLine("unkown currency type");
        break;
}*/
/*var num = 3;
switch(num)
{
    case 1:
    case 3:
    case 5:
    case 7:
        Console.WriteLine("odd");
        break;
    case 2:
    case 4:
    case 6:
    case 8:
        Console.WriteLine("even");
        break;

}*/
/*object o = "rand";
switch(o)
{
    case int i: Console.WriteLine($"it's a int , sqr of {i} = {i * i}");
        break;
    case string i:
        Console.WriteLine($"it's string , capitalization of {i}= {i.ToUpper()}");
        break;
}*/
/*bool isVip = true;
switch (isVip)
{
    case bool i when i == true:
        Console.WriteLine("YES");
        break;
    case bool i:
        Console.WriteLine("NO");
        break;


}
*/
/*var cardNo = 13;
string carName = cardNo switch
{
   1 => "ACE",
    13 => "KING",
    12 => "QUEEN",
    10 => "JACK",
    _ => cardNo.ToString()
};
Console.WriteLine(carName);*/
/*var counter = 0;
while (counter<10)
{
    Console.Write(counter+" ");
    ++counter;
}
Console.WriteLine();
counter = 0;
do
{
    Console.Write(counter + " ");
    ++counter;
} while (counter < 10);*/
/*for(int count=0,prev=0,current=1;count<10; ++count)
{
    Console.Write(prev + " ");
    int newFib = prev + current;
    prev = current;
    current = newFib;
   
}
*/
/*var arr = new int[] { 1, 2, 4 };
foreach (var n in arr)
{
    Console.Write
        (n+ " ");
}
Console.WriteLine ();
for(var i=0;i<arr.Length; i++)
{
    Console.Write(arr[i]+" ");
}*/
/*

for(int i=0; i <10;i++)
{
    if (i%2==0)
        continue;
    Console.Write(i+" ");
    ++i;
}
*/
/*var i = 0; 
start:
if(i<=5)
{
    Console.Write(i + " ");
    i++;
        goto start;
    Console.WriteLine("rand");
}*/
/*var input = .44m;
var result = AsPercentage(input);
Console.WriteLine(result);
static decimal AsPercentage(decimal amount )
{
    return amount * 100;
}*/