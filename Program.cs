// See https://aka.ms/new-console-template for more information


using System.Data.SqlClient;

string stringaConnessione = "Data Source=localhost;Initial Catalog=biblioteca-db;Integrated Security=True";

SqlConnection connessioneSql = new SqlConnection(stringaConnessione);


//INSERT
//try
//{
//    connessioneSql.Open();

//    string insertQuery = "INSERT INTO documenti (codice, titolo, anno, settore, stato, scaffale, autore, tipo) VALUES (@codice, @titolo, @anno, @settore, @stato, @scaffale, @autore, @tipo)";

//    SqlCommand insertCommand = new SqlCommand(insertQuery, connessioneSql);

//    int codice = new Random().Next(10000, 100000);
//    Console.WriteLine("inserisci titolo documento");
//    string titolo = Console.ReadLine();
//    Console.WriteLine("inserisci anno di pubblicazione");
//    DateTime anno = Convert.ToDateTime(Console.ReadLine());
//    Console.WriteLine("inserisci settore documento");
//    string settore = Console.ReadLine();
//    Console.WriteLine("inserisci scaffale");
//    int scaffale = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("inserisci autore documento");
//    string autore = Console.ReadLine();
//    Console.WriteLine("inserisci tipo di documento");
//    string tipo = Console.ReadLine();

//    insertCommand.Parameters.Add(new SqlParameter("@codice", codice));
//    insertCommand.Parameters.Add(new SqlParameter("@titolo", titolo));
//    insertCommand.Parameters.Add(new SqlParameter("@anno", anno));
//    insertCommand.Parameters.Add(new SqlParameter("@settore", settore));
//    insertCommand.Parameters.Add(new SqlParameter("@stato", true));
//    insertCommand.Parameters.Add(new SqlParameter("@scaffale", scaffale));
//    insertCommand.Parameters.Add(new SqlParameter("@autore", autore));
//    insertCommand.Parameters.Add(new SqlParameter("@tipo", tipo));

//    int affectedRows = insertCommand.ExecuteNonQuery();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//} finally
//{
//    connessioneSql.Close();
//}


//UPDATE

//try
//{
//    connessioneSql.Open();

//    Console.WriteLine("inserisci il titolo del documento:");
//    string titolo = Console.ReadLine();

//    Console.WriteLine("il documento è disponibile? (si/no)");
//    string input = Console.ReadLine();
//    bool stato = true;
//    switch (input)
//    {
//        case "si":
//            stato = true;
//            break;
//        case "no":
//            stato = false;
//            break;
//    }
//    string query = "UPDATE documenti SET stato=@stato where titolo=@titolo";
    
//    // creo il comando ed eseguo la query
//    SqlCommand cmd = new SqlCommand(query, connessioneSql);
//    cmd.Parameters.Add(new SqlParameter("@stato", stato));
//    cmd.Parameters.Add(new SqlParameter("@titolo", titolo));


//    int affectedRows = cmd.ExecuteNonQuery();


//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    connessioneSql.Close();
//}


//DELETE

//try
//{
//    connessioneSql.Open();

//    Console.WriteLine("inserisci il titolo del documento:");
//    string titolo = Console.ReadLine();

//    string query = "DELETE FROM documenti where titolo=@titolo";

//    // creo il comando ed eseguo la query
//    SqlCommand cmd = new SqlCommand(query, connessioneSql);
//    cmd.Parameters.Add(new SqlParameter("@titolo", titolo));


//    int affectedRows = cmd.ExecuteNonQuery();


//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    connessioneSql.Close();
//}


//RICERCA
try
{
    connessioneSql.Open();

    Console.WriteLine("inserisci il titolo del documento:");
    string titolo = Console.ReadLine();

    string query = "SELECT * FROM documenti where titolo=@titolo";

    // creo il comando ed eseguo la query
    SqlCommand cmd = new SqlCommand(query, connessioneSql);
    cmd.Parameters.Add(new SqlParameter("@titolo", titolo));

    //reader 
    SqlDataReader reader = cmd.ExecuteReader();

    while (reader.Read())
    {
        int codice = reader.GetInt32(1);
        Console.WriteLine(codice);
        string nome = reader.GetString(2);
        Console.WriteLine(nome);
        string autore = reader.GetString(7);
        Console.WriteLine(autore);
        bool disponibile = reader.GetBoolean(5);
        Console.WriteLine(disponibile == true ? "disponibile" : "non disponibile");
        int scaffale = reader.GetInt32(6);
        Console.WriteLine(scaffale);
    }


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    connessioneSql.Close();
}