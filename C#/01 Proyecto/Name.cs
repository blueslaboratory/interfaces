// 2/12/2022

/*
Correr el program desde VSCode: CTRL +SHIFT+`
$ export DOTNET_ROOT=$HOME/.dotnet
$ export PATH=$PATH:$HOME/.dotnet:$HOME/.dotnet/tools

$ dotnet run
*/

using System;

internal class Name{
    
    private static void Main(){

        //esto es un entero anulable
        int? x; 

        x = null;
        x = 5;

        // si x es nulo vale 0, si no vale x
        var y = x ?? 0;


        Console.Write("Dime tu nombre: ");

        var nombre = Console.ReadLine();
        Saludar.Saluda(nombre);

        Console.Write("Pulsa cualquier tecla...");
        Console.ReadKey();

        /*
        Console.writeLine($"Hola, {nombre}!");
        Console.writeLine("Hello, " + nombre "!");
        */
    }
}