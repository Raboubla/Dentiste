using System;
using System.Windows.Forms;


class Fenetre : Form
{

    public void creeFenetre()
    {

        Form maFenetre = new Form();

        maFenetre.Text = "Ma Fenêtre";
        maFenetre.Size = new System.Drawing.Size(400, 300);
        Application.Run(maFenetre);
    }
}