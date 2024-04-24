// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite sua idade");
var idade = Convert.ToInt32(Console.ReadLine());

while(idade>=130 || idade<0){
    Console.WriteLine("Por favor, digite uma idade válida");
    idade = Convert.ToInt32(Console.ReadLine());
}

if (idade<18){
    Console.WriteLine("Você não pode dirigir");
}
else if (idade>=18){
    Console.WriteLine("Parabéns, você pode dirigir!");
}

Console.ReadKey();
