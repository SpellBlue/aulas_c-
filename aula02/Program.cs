// See https://aka.ms/new-console-template for more information
decimal num1,num2;
char recomecar;
//
Iniciar:
Console.WriteLine("Informe um número:");
num1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Agora informe outro número:");
num2 = Convert.ToDecimal(Console.ReadLine());
//
Console.WriteLine($"Somando estes números dá:{num1+num2}");
Console.WriteLine($"Subtraindo {num2} de {num1} dá:{num1-num2}");
Console.WriteLine($"Multiplicando estes números dá:{num1*num2}");
Console.WriteLine($"Dividindo {num1} por {num2} dá:{num1/num2}");
Console.WriteLine("Gostaria de escolher outros números?(s/n)");
//
recomecar = Console.ReadKey().KeyChar;
if (recomecar == 's' || recomecar =='S'){
    Console.Clear();
    goto Iniciar;
}
else{
    return;
}