using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabCSharp.Networking.Class;

namespace LabCSharp.Networking.View
{
    public partial class gesEmail : Form
    {
        public gesEmail()
        {
            InitializeComponent();
        }

        private void BtnEmailEnviar_Click(object sender, EventArgs e)
        {
            string emailusuario = txtEmailUsuario.Text;
            string emailpassword = txtEmailPassword.Text;
            int emailport = (int)nmpEmailPuerto.Value;
            string emailhost = txtEmailSMTP.Text;
            string emaildestinatario = txtEmailDestinatario.Text;
            string emailasunto = txtEmailasunto.Text;
            string emailbody = rtxtEmailBody.Text;

            claseEmail miClaseEmail = new claseEmail();
            miClaseEmail.enviarMailSMTP(emaildestinatario, emailusuario, emailusuario, emailpassword, emailhost, emailport, emailasunto, emailbody);

            
        }


    }
}
