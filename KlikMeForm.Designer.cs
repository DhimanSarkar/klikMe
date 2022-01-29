
namespace klikMe
{
    partial class KlikMeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBg = new System.Windows.Forms.PictureBox();
            this.btnKlikMe = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).BeginInit();
            this.SuspendLayout();
            // 
            // picBg
            // 
            this.picBg.Location = new System.Drawing.Point(0, 0);
            this.picBg.Margin = new System.Windows.Forms.Padding(0);
            this.picBg.Name = "picBg";
            this.picBg.Size = new System.Drawing.Size(500, 500);
            this.picBg.TabIndex = 0;
            this.picBg.TabStop = false;
            // 
            // btnKlikMe
            // 
            this.btnKlikMe.Location = new System.Drawing.Point(0, 0);
            this.btnKlikMe.Margin = new System.Windows.Forms.Padding(0);
            this.btnKlikMe.Name = "btnKlikMe";
            this.btnKlikMe.Size = new System.Drawing.Size(75, 23);
            this.btnKlikMe.TabIndex = 1;
            this.btnKlikMe.Text = "Klik Me!";
            this.btnKlikMe.UseVisualStyleBackColor = true;
            this.btnKlikMe.Click += new System.EventHandler(this.btnKlikMe_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMsg.AutoSize = true;
            this.lblMsg.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.lblMsg.Location = new System.Drawing.Point(0, 0);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(50, 13);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Message";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // KlikMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnKlikMe);
            this.Controls.Add(this.picBg);
            this.Name = "KlikMeForm";
            this.Text = "Klik Me!";
            this.Load += new System.EventHandler(this.KlikMeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBg;
        private System.Windows.Forms.Button btnKlikMe;
        private System.Windows.Forms.Label lblMsg;
    }
}