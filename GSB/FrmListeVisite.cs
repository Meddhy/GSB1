using GSB.Properties;
using lesClasses;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class FrmListeVisite : FrmBase
    {
        private Visite laVisite;

        public FrmListeVisite()
        {
            InitializeComponent();
        }



        #region procédures événementielles

        private void FrmListeVisite_Load(object sender, EventArgs e)
        {
            parametreComposant();
        }


        private void dgvListeVisite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupérer la visite sélectionnée
            laVisite = (Visite)dgvListeVisite.Rows[e.RowIndex].Cells[0].Value;
            afficherVisite(laVisite);
        }
 



        #endregion


        #region methodes
        private void parametreComposant()
        {
            this.Text = "Laboratoire pharmaceutique Galaxy-Swiss Bourdin - Consultation des visites";
            this.grpboxInfoPraticien.Text = "Information du Praticien";
            parametrerDgv(dgvListeVisite);
            remplirdgvVisite();
        }

        private void afficherVisite(Visite uneVisite)
        {

            // Chargement des données de la visite selectionnée
            lblPraticien.Text = uneVisite.LePraticien.NomPrenom;
            lblEmail.Text = uneVisite.LePraticien.Email;
            lblNum.Text = uneVisite.LePraticien.Telephone;
            lblRue.Text = uneVisite.LePraticien.Rue;
            lblTypePraticien.Text = uneVisite.LePraticien.Type.Libelle;

            if (uneVisite.LePraticien.Specialite is null)
            {
                lblSpecialite.Text = "";
            } else
            {
                lblSpecialite.Text = uneVisite.LePraticien.Specialite.Libelle;
            }
               
        }



        private void parametrerDgv(DataGridView dgv)
        {
            #region paramètrage concernant le datagridview dans son ensemble

            // Accessibilité (doit être sur true si on veut pouvoir utiliser les barres de défilement)
            dgv.Enabled = true;

            // style de bordure
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // couleur de fond 
            dgv.BackgroundColor = Color.White;

            // couleur de texte  
            dgv.ForeColor = Color.Black;

            // police de caractères par défaut
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);

            // mode de sélection dans le composant : FullRowSelect, CellSelect ...
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // sélection multiple 
            dgv.MultiSelect = false;

            // l'utilisateur peut-il ajouter ou supprimer des lignes ?
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;

            // L'utilisateur peut-il modifier le contenu des cellules ou est-elle réservée à la programmation ?
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            // l'utilisateur peut-il redimensionner les colonnes et les lignes ?
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            // l'utilisateur peut-il modifier l'ordre des colonnes ?
            dgv.AllowUserToOrderColumns = false;

            // le composant accepte t'il le 'déposer' dans un Glisser - Déposer ?
            dgv.AllowDrop = false;


            #endregion

            #region paramètrage concernant la ligne d'entête 

            // visibilité
            dgv.ColumnHeadersVisible = true;

            // bordure
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // style  [à adapter] (ici : noir sur fond transparent sans mise en évidence de la sélection)
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;    // même couleur que backColor pour ne pas mettre en évidence la colonne sélectionnée
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);


            // hauteur 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            #endregion

            #region paramètrage concernant l'entête de ligne (la colonne d'entête ou le sélecteur)

            // visible 
            dgv.RowHeadersVisible = false;

            // style de bordure  
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


            #endregion

            #region paramètrage au niveau des lignes

            // Hauteur 
            dgv.RowTemplate.Height = 30;

            #endregion

            #region paramètrage au niveau des cellules

            // style de bordure 
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // couleur de fond, ne pas utiliser transparent car la couleur de la ligne sélectionnée restera après sélection
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // Couleur alternative appliquée une ligne sur deux
            // unDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 238, 238, 238);

            #endregion

            #region paramètrage au niveau de la zone sélectionnée

            // couleur de fond mettre la même que les cellules si on ne veut pas mettre la zone en évidence 
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;

            // couleur du texte
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            #endregion


            #region paramètrage des colonnes

            // Entête aux niveaux des colonnes 
            dgv.ColumnHeadersVisible = true;

            // Dimensionner la hauteur du DataGridview en fonction du nombre de lignes
            // unDgv.Height = Globale.LeVisiteur.getNbRendezVous() * (unDgv.RowTemplate.Height) + unDgv.ColumnHeadersHeight;

            // description de chaque colonne  [partie à personnaliser] : visibilité, largeur, alignement cellule et entête si ellene correspond pas à la valeur par défaut

            // colonne 0 masquée contenant l'objet Medicament
            DataGridViewTextBoxColumn colVisite = new DataGridViewTextBoxColumn();
            colVisite.Width = 0;
            dgv.Columns.Add(colVisite);


            // colonne 1 colonne affichant la date et l'heure du rendez-vous
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Programmée le";
            colDate.Width = 235;
            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns.Add(colDate);


            // colonne 2 colonne affichant le ville
            DataGridViewTextBoxColumn colVille = new DataGridViewTextBoxColumn();
            colVille.HeaderText = "Lieu";
            colVille.Width = 231;
            colVille.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns.Add(colVille);

            // faut-il désactiver le tri sur toutes les colonnes ? (commenter les lignes si non)
            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            #endregion
        }



        // remplir le datagridview dgvVisites
        private void remplirdgvVisite()
        {
            // récupérer les visites
            List<Visite> lesVisites = Globale.mesVisites.FindAll(x => x.DateEtHeure >= DateTime.Now);

            // vider le datagridView
            dgvListeVisite.Rows.Clear();

            // Parcourir ces visites pour les ajouter dans le datagridview
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            foreach (Visite uneVisite in lesVisites)
            {
                // mise en forme de la ville 
                string ville = ti.ToTitleCase(uneVisite.LePraticien.Ville.ToLower());
                dgvListeVisite.Rows.Add(uneVisite,uneVisite.DateEtHeure.ToString("dddd dd MMMM yyyy ' à ' hh:mm"), ville );
            }
            laVisite = (Visite)dgvListeVisite.Rows[0].Cells[0].Value;

            // adapter la hauteur du datagridView
            dgvListeVisite.Height = lesVisites.Count * (dgvListeVisite.RowTemplate.Height) + dgvListeVisite.ColumnHeadersHeight + 10;
            if (dgvListeVisite.Height > 800) dgvListeVisite.Height = 800;

        }


























        #endregion

        
    }
}
