﻿// See https://aka.ms/new-console-template for more information
Menu();

static void Menu() {
    Console.Clear();
    Console.WriteLine("Escolha uma operação:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("---------------------");
    Console.WriteLine("Selecione uma opção: ");

    short res = short.Parse(Console.ReadLine());

    switch(res) {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: Environment.Exit(0); break;
        default: Console.WriteLine("Opção inválida. Tente novamente."); Console.ReadKey(); Menu(); break;
    }

}

static void Soma() {
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2;
    Console.WriteLine($"O resultado da soma é {resultado}");
    Console.ReadKey();
}

static void Subtracao() {
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.ReadKey();
}

static void Divisao() {
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 / v2;
    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.ReadKey();
}

static void Multiplicacao() {
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.ReadKey();
}