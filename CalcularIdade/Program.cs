Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Ola {name} Bem vindo");

Console.WriteLine("Digite seu ano de nascimento:");
int year = int.Parse(Console.ReadLine());
int age = 2022- year;
Console.WriteLine($"você tem {age} anos");


/*

// uso do cifrão para interpolar
if (age >= 18) {
    Console.WriteLine($"Voce e maior de idade {age} anos");
    }else if (age == 12) {
    Console.WriteLine($"voce tem {age} e menor de idade");
    } else { 
    Console.WriteLine($"Você tem {age} e criança");
}
*/


// uso mais completo e possivel tambem
if (age >= 18 ||name == "Diego"){
    Console.WriteLine($"Voce e maior de idade {age} anos");
}else if (age == 12) {
    Console.WriteLine($"voce tem {age} e menor de idade");
} else { 
    Console.WriteLine($"Você tem {age} criança");
}

