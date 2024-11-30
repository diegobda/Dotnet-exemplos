// Diego dos santos gonçalves
// exemplos de tipagem de variaveis
// Criardo com comando dotnet new console -n <Variaveis2>
// Para executar use dotnet run // para copilar dotnet build

/*
var myString = $"123 abc";
var myInt = 123;
var myDateTime = DateTime.Now;
var myBool = false;

Console.WriteLine(myInt);
Console.WriteLine(myDateTime);
Console.WriteLine(myBool);

Console.WriteLine(myString);

*/

/*
// Calcular a idade
var myName = "Diego";
var myAge2 = 10;
var myAge3 = 50;
var myAge = myAge2 + myAge3;


Console.WriteLine(myName);
Console.WriteLine(myAge2 + myAge3);
Console.WriteLine(myAge);

Console.ReadKey();

*/

// nesta parte ler a idade digitada pelo usuario
using HelloWorld;

var age1 = int.Parse(Console.ReadLine());
var myAge2 = int.Parse(Console.ReadLine());
var op = Console.ReadLine();


//chamando o metodo criado Calculator
Calculator calculator = new Calculator();

Console.WriteLine(calculator.Calculate(op, age1, myAge2));

// Assim nao funciona pois os valores sao strings 
// Console.WriteLine(age1 / myAge2);


Console.WriteLine();

// sCalculator calculator= int.Parse(age1) / int.Parse(myAge2);