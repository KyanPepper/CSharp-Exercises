// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

int i = 0;

changeI(i);
Console.WriteLine( i.ToString() );

changeIRef(ref i);

    Console.WriteLine( i.ToString() ); 

void changeI(int i)
{

    Console.WriteLine("Changing I value");
    i = 5;

}

void changeIRef(ref int i)
{
    i = 1;

    Console.WriteLine(
         "change i  value ref "
        );
}




