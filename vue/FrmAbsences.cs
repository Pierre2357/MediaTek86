using MediaTek86.contoleur;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    /// <summary>
    /// Frame permettant l'affichage et la modification des absences
    /// </summary>
    public partial class FrmAbsences : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotif = new BindingSource();
        /// <summary>
        /// Controlleur de la frame
        /// </summary>
        private FrmAbsencesController controller;
        /// <summary>
        /// Membre du personnel dont on veut voir et gérer les absences
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// Liste des absences du membre du personnel sélectionné
        /// </summary>
        private List<Absence> lesAbsences;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        /// <param name="personnel">membre du personnel dont on veut voir et gérer les absences</param>
        public FrmAbsences(Personnel personnel)
        {
            InitializeComponent();
            Init(personnel);
        }

        /// <summary>
        /// Initialisation : 
        /// Valorisation de la propriété personnel, création du controlleur et remplissage des listes
        /// </summary>
        /// <param name="personnel">membre du personnel dont on veut voir et gérer les absences</param>
        private void Init(Personnel personnel)
        {
            this.personnel = personnel;
            this.controller = new FrmAbsencesController();
            RemplirListeAbsences();
            RemplirListeMotifs();
            EnCoursDeModifAbsence(false);
        }

        /// <summary>
        /// Méthode pour remplir la liste des absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            lesAbsences = controller.GetLesAbsences(personnel);
            if (lesAbsences.Count > 0)
            {
                bdgAbsences.DataSource = lesAbsences;
                dgvAbsences.DataSource = bdgAbsences;
                dgvAbsences.Columns["personnel"].Visible = false;
                dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        /// <summary>
        /// Méthode pour remplir la liste des motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cboMotifAbsence.DataSource = bdgMotif;
        }

        /// <summary>
        /// Méthode pour gérer si oui ou non on est en cours de modification d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grbAbsences.Enabled = !modif;
            if (modif)
            {
                grbAjoutAbsences.Text = "modifier absence";
            }
            else
            {
                grbAjoutAbsences.Text = "ajouter absence";
            }
        }

        /// <summary>
        /// Méthode pour demander la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAbsences_Click(object sender, EventArgs e)
        {
            if(dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursDeModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpDebutAbsence.Value = absence.Datedebut;
                dtpFinAbsence.Value = absence.Datefin;
                cboMotifAbsence.SelectedIndex = cboMotifAbsence.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Méthode pour confirmer l'ajout ou la modification du'une absence, si elle pose pas de problème
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmAjoutAbsence_Click(object sender, EventArgs e)
        {
            if(dtpDebutAbsence.Value != null && dtpFinAbsence.Value != null && cboMotifAbsence.SelectedIndex != -1)
            {
                if (dtpDebutAbsence.Value < dtpFinAbsence.Value)
                {
                    Boolean disponible = true;
                    foreach (Absence absence in lesAbsences)
                    {
                        if (absence != (Absence)bdgAbsences.List[bdgAbsences.Position])
                        {
                            if (!(dtpFinAbsence.Value < absence.Datedebut || dtpDebutAbsence.Value > absence.Datefin))
                            {
                                disponible = false;
                                break;
                            }
                        }
                    }

                    if (disponible)
                    {
                        Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                        if (enCoursDeModifAbsence)
                        {
                            if (MessageBox.Show("Voulez-vous vraiment modifier l'absence?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Absence oldAbsence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                                Absence newAbsence = new Absence(personnel, dtpDebutAbsence.Value, dtpFinAbsence.Value, motif);
                                controller.UpdateAbsence(oldAbsence, newAbsence);
                            }
                        }
                        else
                        {
                            Absence absence = new Absence(personnel, dtpDebutAbsence.Value, dtpFinAbsence.Value, motif);
                            controller.AjoutAbsence(absence);
                        }
                        RemplirListeAbsences();
                        EnCoursDeModifAbsence(false);
                    }
                    else
                    {
                        MessageBox.Show("Une absence est déjà programmée dans ce créneau.", "Information");
                    }

                }
                else
                {
                    MessageBox.Show("La date de début doit être antérieure à la date de fin.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Méthode pour arrêter la modification ou l'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulAjoutAbsence_Click(object sender, EventArgs e)
        {
            EnCoursDeModifAbsence(false);
        }

        private void btnSupprAbsences_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence de " + personnel.Nom + " " + personnel.Prenom + " du " + absence.Datedebut.ToString() + " au " + absence.Datefin.ToString() + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Information");
            }
        }
    }
}
