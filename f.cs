using System;
using System.Windows.Forms;


class Fenetre : Form
{

    public void creeFenetre()
    {
        Form maFenetre = new Form();
        maFenetre.Text = "Ma Fenêtre";
        maFenetre.Size = new System.Drawing.Size(400, 300);

        // Liste déroulante
        Label labelListe = new Label();
        labelListe.Text = "Choisir :";
        ComboBox listeDeroulante = new ComboBox();
        listeDeroulante.Items.AddRange(new object[] { "Salama", "Jejo" });
        listeDeroulante.Location = new System.Drawing.Point(40, 20);
        maFenetre.Controls.Add(listeDeroulante);
        maFenetre.Controls.Add(labelListe);


        // Input de date
        Label labelListe1 = new Label();
        labelListe1.Text = "Date :";
        DateTimePicker inputDate = new DateTimePicker();
        inputDate.Location = new System.Drawing.Point(40, 60);
        maFenetre.Controls.Add(inputDate);
        maFenetre.Controls.Add(labelListe1);


        // Input d'argent
        Label labelListe2 = new Label();
        labelListe2.Text = "Argent :";
        TextBox inputArgent = new TextBox();
        inputArgent.Location = new System.Drawing.Point(40, 100);
        maFenetre.Controls.Add(inputArgent);
        maFenetre.Controls.Add(labelListe2);


        // Bouton Valider
        Button boutonValider = new Button();
        boutonValider.Text = "Valider";
        boutonValider.Location = new System.Drawing.Point(80, 140);
        boutonValider.Click += BoutonValider_Click;
        maFenetre.Controls.Add(boutonValider);

        Application.Run(maFenetre);
    }

    private void BoutonValider_Click(object sender, EventArgs e)
    {
        // Code à exécuter lorsque le bouton Valider est cliqué
        MessageBox.Show("Validation en cours...");
    }
}