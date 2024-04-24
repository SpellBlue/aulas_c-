// See https://aka.ms/new-console-template for more information

int[,] matriz = { 
    {10, 50, 35, 40, 63},
    {92, 66, 33, 91, 11},
    {8, 3, 0, 14, 27},
    {44, 76, 81, 22, 17},
    };

    matriz[0,1]*=10;
    Console.WriteLine(matriz[0,1]);
    Console.ReadKey();
