using System.Data.SQLite;
using System.IO;

public class CrearBaseDatosSQLite
{
    public static string nombreBaseDatos = "out.sqlite";

    public static void Main(string[] args)
    {
        CrearBaseDatosSiNoExiste();
        CrearTablasSiNoExisten();
    }

    public static void CrearBaseDatosSiNoExiste()
    {
        if (!File.Exists(nombreBaseDatos))
        {
            SQLiteConnection.CreateFile(nombreBaseDatos);
        }
    }

    public static void CrearTablasSiNoExisten()
    {
        using (SQLiteConnection cnx =
            new SQLiteConnection("Data Source=" + nombreBaseDatos + ";Version=3;"))
        {
            cnx.Open();

            string sqlTablaPersona = "create table if not exists person (name varchar(20), age int)";
            using (SQLiteCommand cmd = new SQLiteCommand(sqlTablaPersona, cnx))
            {
                cmd.ExecuteNonQuery();
            }

            string sqlTablaProfesor = "create table if not exists teacher (name varchar(20))";
            using (SQLiteCommand cmd = new SQLiteCommand(sqlTablaProfesor, cnx))
            {
                cmd.ExecuteNonQuery();

            }
        }
    }
}