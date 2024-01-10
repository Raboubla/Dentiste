using System;
using MySql.Data.MySqlClient;

class Connexion
{
    public void ConnectMysql(){
        string connectionString = "Server=localhost;Database=c;Uid=root;Pwd=;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try{
            connection.Open();
            Console.WriteLine("Connexion à la base de données MySQL réussie.");
        }
        catch (Exception ex){
            Console.WriteLine("Erreur de connexion à la base de données: " + ex.Message);
        }
        finally{
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Connexion à la base de données MySQL fermée.");
            }
        }
    }

    public void connecteMysql(){
        string connectionString = "Server=localhost;Database=c;Uid=root;Pwd=;";
        MySqlConnection connection = new MySqlConnection(connectionString);
                try{
            connection.Open();

        }        catch (Exception ex){
            Console.WriteLine("Erreur de connexion à la base de données: " + ex.Message);
        }
    }

    public void traitementNote(){
        
    }

    public void manomeNote(){

    }
}
