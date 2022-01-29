using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klikMe
{
    public partial class KlikMeForm : Form
    {
        public KlikMeForm()
        {
            InitializeComponent();
            
            // Custom Settings for Form
            //
            this.Icon = Properties.Resources.icon;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.Height = 500;
            this.Width = 500;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            //
            //imgBG
            //
            this.picBg.Width = this.ClientSize.Width;
            this.picBg.Height = this.ClientSize.Height;
            //Border Enable/Disable
            //this.picBg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBg.Image = global::klikMe.Properties.Resources.em;
            this.picBg.SizeMode = PictureBoxSizeMode.Zoom;
            this.picBg.Size = new Size(500, 500);
            this.picBg.Visible = false;

            //
            //btnKlikMe
            //
            this.btnKlikMe.Size = new Size(300, 100);
            this.btnKlikMe.FlatStyle = FlatStyle.Flat;
            this.btnKlikMe.BackColor = Color.White;
            this.btnKlikMe.FlatAppearance.BorderSize = 0;
            int btnW = (this.ClientSize.Width - this.btnKlikMe.Width) / 2;
            int btnH = (this.ClientSize.Height - this.btnKlikMe.Height) / 2;
            this.btnKlikMe.Location = new Point(btnW,btnH);
            //Font
            this.btnKlikMe.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //
            //lblMsg
            //
            this.lblMsg.Visible = false;
            this.lblMsg.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void KlikMeForm_Load(object sender, EventArgs e)
        {
            
        }
        public static int i = 0;
        private void btnKlikMe_Click(object sender, EventArgs e)
        {
            this.btnKlikMe.Visible = false;
            this.picBg.Visible = true;
            this.lblMsg.Visible = true;
            this.lblMsg.Text = "Fuck You!\nHave a good day.";
            this.lblMsg.Location = new Point((this.ClientSize.Width - this.lblMsg.Width) / 2, this.lblMsg.Top + 10);
            i++;

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
            
            global::klikMe.KlikMeForm.ActiveForm.Close();
        }
    }
}
