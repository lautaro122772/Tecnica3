using System;
using System.IO;
public class LeerArchivoTexto
{
    public static void Main(string[] args)
    {
        string linea;
        string nombreArchivo = "c:\\Users\\joriz\\source\\repos\\Tecnica3\\LeerArchivoTexto\\input.txt";

        StreamReader sr = new StreamReader(nombreArchivo);
        linea = sr.ReadLine();

        while (linea != null)
        {
            Console.WriteLine(linea);
            linea = sr.ReadLine();
        }
        sr.Close();
        Console.ReadKey();
    }
}

/*
 * Cree un programa en C# que lea un archivo de texto y muestre todas sus lineas en pantalla. Puede utilizar el objeto StreamReader para leer un archivo.
*/