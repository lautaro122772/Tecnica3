using System;
using System.IO;
public class LeerArchivoTextoUsingFile
{
    public static void Main(string[] args)
    {
        string nombreArchivo = "c:\\Users\\joriz\\source\\repos\\Tecnica3\\LeerArchivoTexto\\input.txt";
        string textoArchivo = File.ReadAllText(nombreArchivo);

        Console.WriteLine(textoArchivo);
    }
}




/*
 * Cree un programa C # que lea un archivo de texto y muestre todas sus líneas en la pantalla.

Utilice la clase File para leer el archivo de texto.
*/
