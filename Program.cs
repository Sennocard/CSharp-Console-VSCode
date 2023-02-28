// See https://aka.ms/new-console-template for more information
int age;
int drink;
Console.Write("Olá, como se chama? ");
string name = Console.ReadLine();


Console.WriteLine($"Oi {name} muito prazer te conhecer.");
Console.Write("Quantos Anos você tem? ");
int.TryParse(Console.ReadLine(),out age);

Console.WriteLine($"Você gostaria de beber:");
Console.WriteLine($"1 - chá");
Console.WriteLine($"2 - café");

if ( age < 18 )
  Console.WriteLine($"3 - fanta");
else 
  Console.WriteLine($"3 - guaraná");

int.TryParse(Console.ReadLine(),out drink);

switch (drink)
{
    case 1:  
        Console.WriteLine($"chá será então.");
        break;
    case 2:  
        Console.WriteLine($"café será então.");
        break;
    default:
        Console.WriteLine($"será um refrigerante então.");
        break;
}

  Console.WriteLine($"Xau {name} até a próxima!!");