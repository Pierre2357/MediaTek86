using MediaTek86.contoleur;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    /// <summary>
    /// Frame permettant l'affichage et la modification du personnel
    /// </summary>
    public partial class FrmPersonnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des affectations
        /// </summary>
        private BindingSource bdgAffectation = new BindingSource();
        /// <summary>
        /// Controlleur de la frame
        /// </summary>
        private FrmPersonnelController controller;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation : Création du controlleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListePersonnel();
            RemplirListeAffectations();
            EnCoursDeModifPersonnel(false);
        }

        /// <summary>
        /// Méthode pour remplir la liste du personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Méthode pour replire le combo box des affectations
        /// </summary>
        private void RemplirListeAffectations()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgAffectation.DataSource = lesServices;
            cboAffectation.DataSource = bdgAffectation;
        }

        /// <summary>
        /// Méthode d'affichage selon si on est ou non en cours de modification d'un membre du personnel 
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grbPersonnel.Enabled = !modif;
            if (modif)
            {
                grbAjoutPersonnel.Text = "modifier personnel";
            }
            else
            {
                grbAjoutPersonnel.Text = "ajouter personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrePersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboAffectation.SelectedIndex != -1)
            {
                Service service = (Service)bdgAffectation.List[bdgAffectation.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AjoutPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursDeModifPersonnel(false);
            }
        }

        private void btnSupprPersonnel_Click(object sender, EventArgs e)
        {
            if(dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Information");
            }
        }

        private void btnAnnulAjoutPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifPersonnel(false);
            }
        }

        private void btnModifPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursDeModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboAffectation.SelectedIndex = cboAffectation.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Information");
            }
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            if(dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                FrmAbsences frm = new FrmAbsences(personnel);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Information");
            }
        }
    }
}
