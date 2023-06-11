using gestionCommerciale.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static gestionCommerciale.Models.AchatRepository;

namespace gestionCommerciale.Forms
{
    public partial class acheter_produit : Form
    {
        private ArticleRepository articleRepository;
        private FournisseurRepository fournisseurRepository;
        public acheter_produit()
        {
            InitializeComponent();
            articleRepository = new ArticleRepository();
            List<Article> produits = articleRepository.GetAllArticles();

            fournisseurRepository = new FournisseurRepository();
            List<Fournisseur> fournisseurs = fournisseurRepository.GetAllFournisseurs();

            // Ajouter les produits au ComboBox
            comboBox_produit.DataSource = produits;
            comboBox_produit.DisplayMember = "Nom"; // Afficher le nom du produit
            comboBox_produit.ValueMember = "Id"; // Utiliser l'ID du produit comme valeur

            comboBox_fournisseur.DataSource = fournisseurs;
            comboBox_fournisseur.DisplayMember = "Nom"; // Afficher le nom du produit
            comboBox_fournisseur.ValueMember = "Id"; // Utiliser l'ID du produit comme valeur

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ajouter_commande_Click(object sender, EventArgs e)
        {
            int fournisseurId = Convert.ToInt32(comboBox_fournisseur.SelectedValue);
            int articleId = Convert.ToInt32(comboBox_produit.SelectedValue);
            int quantite = Convert.ToInt32(quantité.Text);

            AchatRepository achatRepository = new AchatRepository();
            achatRepository.AjouterAchat(fournisseurId, articleId, quantite);
        }
    }
}
