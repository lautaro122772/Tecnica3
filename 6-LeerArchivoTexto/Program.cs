using System;
using System.IO;
public class LeerArchivoTextoUsing
{
    public static void Main(string[] args)
    {
        string linea;
        string nombreArchivo = "c:\\Users\\joriz\\source\\repos\\Tecnica3\\LeerArchivoTexto\\input.txt";

        using (StreamReader sr = new StreamReader(nombreArchivo))
        {
            linea = sr.ReadLine();

            while (linea != null)
            {
                Console.WriteLine(linea);
                linea = sr.ReadLine();
            }
        }
    }
}

/*
 * Cree un programa en C# que lea un archivo de texto y muestre todas sus lineas en pantalla.

Utilice using para gestionar la memoria del lector.
*/