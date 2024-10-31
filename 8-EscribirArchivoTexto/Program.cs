using System;
using System.IO;
public class EscribirArchivoTexto
{
    public static void Main(string[] args)
    {
        string nombreArchivo = "c:\\Users\\joriz\\source\\repos\\Tecnica3\\LeerArchivoTexto\\out.txt";
        using (StreamWriter archivo = File.CreateText(nombreArchivo))
        {
            string linea;
            do
            {
                linea = Console.ReadLine();

                if (linea.Length != 0)
                {
                    archivo.WriteLine(linea);
                }
            }
            while (linea.Length != 0);
        }
    }
}

/*
Crea un programa en C# que solicite lineas al usuario y las escriba en un fichero de texto.

Escriba las lineas hasta que el usuario presione Intro.
*/