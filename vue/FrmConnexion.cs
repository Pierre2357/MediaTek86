using MediaTek86.contoleur;
using MediaTek86.modele;
using MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
{
    /// <summary>
    /// Frame de connexion
    /// </summary>
    public partial class FrmConnexion : Form
    {
        /// <summary>
        /// Controlleur de la frame
        /// </summary>
        private FrmConnexionController controller;

        /// <summary>
        /// Construcion des composants grapiques et appel des autres initialisatios
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new FrmConnexionController();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pwd = txtPwd.Text;
            if(String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ContoroleAuthentification(responsable))
                {
                    FrmPersonnel frm = new FrmPersonnel();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas responsable", "Alerte");
                }
            }
        }
    }
}
