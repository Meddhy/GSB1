using GSB.Properties;
using lesClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GSB
{
    public partial class FrmVisiteMaj : FrmBase
    {
        private Visite laVisite;
        
        public FrmVisiteMaj()
        {
            InitializeComponent();
        }
        #region procédures événementielles

        private void FrmVisiteMaj_Load(object sender, EventArgs e)
        {
            parametrerComposant();

        }

        private void btnVisiteMaj_Click(object sender, EventArgs e)
        {
            modification();
        }

        private void dgvVisiteMaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            suppression(e);
        }


        #endregion

        #region méthodes



        private void parametrerComposant()
        {
            this.Text = "Laboratoire pharmaceutique Galaxy-Swiss Bourdin - Modification de la planification d'un rendez-vous";
            this.grpBoxVisite.Text = "Sélectionner la visite afin de modifier la date du rendez-vous";

            parametrerDgv(dgvVisiteMaj);
            remplirdgvVisite();
            parametrerDate();

        }


        private void afficherVisiter(Visite uneVisite)
        {

            // Chargement des données de la visite selectionnée
            lblNom.Text = uneVisite.LePraticien.NomPrenom;
            lblDate.Text = uneVisite.DateEtHeure.ToLongDateString();
            dtpDate.Value = dtpDate.MinDate;

        }


        private void dgvVisiteMaj_SelectionChanged(object sender, EventArgs e)
        {
            
            // vider le datagridView déclenche cet événement 
            if (dgvVisiteMaj.SelectedRows.Count > 0)
            {
                laVisite = (Visite)dgvVisiteMaj.SelectedRows[0].Cells[0].Value;
                afficherVisiter(laVisite);
            }
        }


        private void parametrerDate()
        {
            // la prise de rendez vous s'effectue sur les deux mois à venir : propriétés MinDate et MaxDate
            // la valeur la plus petite (qui sera la valeur proposée par défaut) est dans 2 heures sans les minutes ou après demain 8 heure si demain est un dimanche
            // la valeur la plus grande possible est dans 60 jours à 19 heures

            DateTime dateMin = DateTime.Now.AddHours(2).AddMinutes(-DateTime.Now.Minute);
            if (dateMin.Hour >= 19) dateMin = DateTime.Today.AddDays(1).AddHours(8);
            if (dateMin.DayOfWeek == DayOfWeek.Sunday) dateMin = DateTime.Today.AddDays(1).AddHours(8);
            dtpDate.MinDate = dateMin;
            dtpDate.MaxDate = DateTime.Today.AddDays(60).AddHours(19);
            dtpDate.Value = dateMin;  // ne semble pas utile
                                      // Mise en forme de la date
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;

        }

        private void parametrerDgv(DataGridView dgv)
        {
            #region paramétrage concernant le datagridview dans son ensemble

            // style de bordure
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // couleur de fond 
            dgv.BackgroundColor = Color.White;

            // couleur de texte  
            dgv.ForeColor = Color.Black;

            // police de caractères par défaut
            dgv.DefaultCellStyle.Font = new Font("Garomond", 11);

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
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;

            // l'utilisateur peut-il modifier l'ordre des colonnes ?
            dgv.AllowUserToOrderColumns = false;

            // le composant accepte t'il le 'déposer' dans un Glisser - Déposer ?
            dgv.AllowDrop = false;

            // barre de défilement
            dgv.ScrollBars = ScrollBars.Both;

            #endregion

            #region paramétrage concernant la ligne d'entête (les entêtes de chaque colonnes)

            // accessibilité du composant
            dgv.Enabled = true;

            // permissions
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowDrop = false;
            dgv.AllowUserToOrderColumns = false;

            // Largeur : à contrôler avec la largeur des colonnes si elle est définie
            // dgv.Width = 754;

            //  bordures extérieures
            dgv.GridColor = Color.Black;
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // Bordure au niveau des cellules
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // bordure au niveau de la colonne d'entête
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // hauteur 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            #endregion

            #region paramètrage concernant l'entête de ligne (la colonne d'entête ou le sélecteur)

            // visibilité
            dgv.RowHeadersVisible = false;

            // style de bordure  
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            #endregion

            #region paramètrage au niveau des lignes

            // Hauteur 
            dgv.RowTemplate.Height = 30;

            #endregion

            #region paramètrage au niveau des cellules

            // couleur de fond, ne pas utiliser transparent car la couleur de la ligne sélectionnée restera après sélection
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // Couleur alternative appliquée une ligne sur deux
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 238, 238, 238);

            #endregion

            #region paramètrage au niveau de la zone sélectionnée

            // couleur de fond mettre la même que les cellules si on ne veut pas mettre la zone en évidence 
            // dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Lavender;

            // couleur du texte
            // dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            #endregion

            #region paramètrage des colonnes

            // Entête aux niveaux des colonnes 
            dgv.ColumnHeadersVisible = false;

            // Dimensionner la hauteur du DataGridview en fonction du nombre de lignes
            // unDgv.Height = Globale.LeVisiteur.getNbRendezVous() * (unDgv.RowTemplate.Height) + unDgv.ColumnHeadersHeight;

            // description de chaque colonne  [partie à personnaliser] : visibilité, largeur, alignement cellule et entête si ellene correspond pas à la valeur par défaut

            // colonne 0 masquée contenant l'objet Medicament
            DataGridViewTextBoxColumn colMedicament = new DataGridViewTextBoxColumn();
            colMedicament.Width = 0;
            dgv.Columns.Add(colMedicament);


            // colonne 1 colonne afficher l'image permettant la suppression
            DataGridViewImageColumn colSupprimer = new DataGridViewImageColumn();
            colSupprimer.HeaderText = "";
            colSupprimer.Image = Resources.supprimer;
            colSupprimer.Width = 40;
            colSupprimer.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns.Add(colSupprimer);

            // colonne 2 colonne affichant la date et l'heure du rendez-vous
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Date et heure du rendez-vous";
            colDate.Width = 250;
            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns.Add(colDate);


            // colonne 3 colonne affichant le praticien
            DataGridViewTextBoxColumn colPraticien = new DataGridViewTextBoxColumn();
            colPraticien.HeaderText = "Praticien";
            colPraticien.Width = 400;
            colPraticien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns.Add(colPraticien);

            // faut-il désactiver le tri sur toutes les colonnes ? (commenter les lignes si non)
            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            #endregion
        }


        // remplir le datagridview dgvVisites
        private void remplirdgvVisite()
        {
            // récupérer les rendez-vous
            List<Visite> lesRendezVous = Globale.mesVisites.FindAll(x => x.DateEtHeure >= DateTime.Now);

            // vider le datagridView
            dgvVisiteMaj.Rows.Clear();

            // Parcourir ces visites pour les ajouter dans le datagridview
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            foreach (Visite uneVisite in lesRendezVous)
            {
                // mise en forme de la ville 
                string ville = ti.ToTitleCase(uneVisite.LePraticien.Ville.ToLower());
                dgvVisiteMaj.Rows.Add(uneVisite, null, uneVisite.DateEtHeure.ToString("dddd dd MMMM yyyy ' à ' hh:mm"), uneVisite.LePraticien.NomPrenom + '(' + ville + ')');
            }
            laVisite = (Visite)dgvVisiteMaj.Rows[0].Cells[0].Value;

            // adapter la hauteur du datagridView
            dgvVisiteMaj.Height = lesRendezVous.Count * (dgvVisiteMaj.RowTemplate.Height) + dgvVisiteMaj.ColumnHeadersHeight + 10;
            if (dgvVisiteMaj.Height > 800) dgvVisiteMaj.Height = 800;

        }






        private void modification()
        {
            // récupérer l'id de la visite
            int id = laVisite.Id;

            // récupérer la date du rendez-vous
            DateTime uneDate = dtpDate.Value;

            // Appel de la méthode de modifierRendezVous
            string message;
            bool ok = Passerelle.modifierRendezVous(id, uneDate, out message);
            if (ok)
            {
                // mise à jour des données
                laVisite.deplacer(uneDate);
                Globale.mesVisites.Sort();

                // message de confirmation
                MessageBox.Show("La date du rendez-vous a été modifiée", "Modification de la date du rendez-vous", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Rafraichir le datagridview
                remplirdgvVisite();

            }
            else
            {
                // message d'erreur
                MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suppression(DataGridViewCellEventArgs e)
        {
            // si la colonne cliquée est la colonne de suppression 
            // Demander confirmation de la suppression 
            // si oui, on supprime la visite de la liste des visites
            // on rafraichit le datagridview
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce rendez-vous ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // récupérer l'id de la visite
                    int id = laVisite.Id;
                    Visite uneVisite = (Visite)dgvVisiteMaj.Rows[e.RowIndex].Cells[0].Value;
                    string message;
                    // Appel de la méthode de supprimerRendezVous
                    bool ok = Passerelle.supprimerRendezVous(uneVisite.Id, out message);
                    if (ok)
                    {
                        Globale.mesVisites.Remove(uneVisite);
                        remplirdgvVisite();
                    }
                    else
                    {
                        MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

            #endregion







        }
}
