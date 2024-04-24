// See https://aka.ms/new-console-template for more information

int num,divisor;
bool primo;

Console.WriteLine("Lista dos primeiros 100 números primos");
Console.WriteLine("2");

for (num=3; num<=100; num++){
    primo=true;
    for (divisor=2; divisor<num; divisor++){
        if (num%divisor==0){
            primo=false;
            break;
        }
    }
    if (primo){
        Console.WriteLine(num);
    }
}

Console.ReadKey();