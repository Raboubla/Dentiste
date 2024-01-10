using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        Connexion cc = new Connexion();
        cc.ConnectMysql();

        Fenetre ff = new Fenetre();
        ff.creeFenetre();

    }
}
