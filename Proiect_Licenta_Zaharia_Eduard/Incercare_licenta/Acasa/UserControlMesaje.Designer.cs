
namespace Incercare_licenta.Acasa
{
    partial class UserControlMesaje
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butonExit = new Guna.UI2.WinForms.Guna2Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.listBoxCoduri1 = new System.Windows.Forms.ListBox();
            this.listBoxCoduri = new System.Windows.Forms.CheckedListBox();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // butonExit
            // 
            this.butonExit.BackColor = System.Drawing.Color.Silver;
            this.butonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonExit.FillColor = System.Drawing.Color.Silver;
            this.butonExit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonExit.ForeColor = System.Drawing.Color.White;
            this.butonExit.Location = new System.Drawing.Point(1497, 34);
            this.butonExit.Name = "butonExit";
            this.butonExit.Size = new System.Drawing.Size(177, 55);
            this.butonExit.TabIndex = 2;
            this.butonExit.Text = "Spre Status";
            this.butonExit.Click += new System.EventHandler(this.butonExit_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.listBoxCoduri1);
            this.panelCentral.Controls.Add(this.listBoxCoduri);
            this.panelCentral.Controls.Add(this.butonExit);
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1976, 808);
            this.panelCentral.TabIndex = 3;
            // 
            // listBoxCoduri1
            // 
            this.listBoxCoduri1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCoduri1.FormattingEnabled = true;
            this.listBoxCoduri1.ItemHeight = 27;
            this.listBoxCoduri1.Location = new System.Drawing.Point(212, 80);
            this.listBoxCoduri1.Name = "listBoxCoduri1";
            this.listBoxCoduri1.Size = new System.Drawing.Size(1057, 490);
            this.listBoxCoduri1.TabIndex = 4;
            // 
            // listBoxCoduri
            // 
            this.listBoxCoduri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCoduri.FormattingEnabled = true;
            this.listBoxCoduri.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.listBoxCoduri.Location = new System.Drawing.Point(25, 107);
            this.listBoxCoduri.Name = "listBoxCoduri";
            this.listBoxCoduri.Size = new System.Drawing.Size(388, 274);
            this.listBoxCoduri.TabIndex = 3;
            this.listBoxCoduri.Visible = false;
            // 
            // UserControlMesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCentral);
            this.Name = "UserControlMesaje";
            this.Size = new System.Drawing.Size(1976, 808);
            this.panelCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button butonExit;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.ListBox listBoxCoduri1;
        private System.Windows.Forms.CheckedListBox listBoxCoduri;
    }
}
