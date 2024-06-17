
namespace Incercare_licenta.FormDetinuti
{
    partial class UserControlDetinuti_Acasa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDetinuti_Acasa));
            this.dETINUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Incercare_licenta.DataSet2();
            this.cELULABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Incercare_licenta.DataSet1();
            this.cELULATableAdapter = new Incercare_licenta.DataSet1TableAdapters.CELULATableAdapter();
            this.dETINUTTableAdapter = new Incercare_licenta.DataSet2TableAdapters.DETINUTTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelDetinutiLiberi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelDetinutiTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelDetinutiInCelule = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelDetinutiInArest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dETINUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cELULABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dETINUTBindingSource
            // 
            this.dETINUTBindingSource.DataMember = "DETINUT";
            this.dETINUTBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cELULABindingSource
            // 
            this.cELULABindingSource.DataMember = "CELULA";
            this.cELULABindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cELULATableAdapter
            // 
            this.cELULATableAdapter.ClearBeforeFill = true;
            // 
            // dETINUTTableAdapter
            // 
            this.dETINUTTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(244, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 47);
            this.label2.TabIndex = 12;
            this.label2.Text = "Deținuti liberi";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(90, 279);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(688, 69);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            // 
            // labelDetinutiLiberi
            // 
            this.labelDetinutiLiberi.AutoSize = true;
            this.labelDetinutiLiberi.BackColor = System.Drawing.Color.Transparent;
            this.labelDetinutiLiberi.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetinutiLiberi.ForeColor = System.Drawing.Color.Black;
            this.labelDetinutiLiberi.Location = new System.Drawing.Point(853, 288);
            this.labelDetinutiLiberi.Name = "labelDetinutiLiberi";
            this.labelDetinutiLiberi.Size = new System.Drawing.Size(142, 47);
            this.labelDetinutiLiberi.TabIndex = 11;
            this.labelDetinutiLiberi.Text = "Detalii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(244, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Număr total deținuți";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(90, 130);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(688, 69);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 16;
            this.guna2PictureBox2.TabStop = false;
            // 
            // labelDetinutiTotal
            // 
            this.labelDetinutiTotal.AutoSize = true;
            this.labelDetinutiTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelDetinutiTotal.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetinutiTotal.ForeColor = System.Drawing.Color.Black;
            this.labelDetinutiTotal.Location = new System.Drawing.Point(853, 139);
            this.labelDetinutiTotal.Name = "labelDetinutiTotal";
            this.labelDetinutiTotal.Size = new System.Drawing.Size(142, 47);
            this.labelDetinutiTotal.TabIndex = 14;
            this.labelDetinutiTotal.Text = "Detalii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(244, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 47);
            this.label4.TabIndex = 18;
            this.label4.Text = "Deținuți în celule";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(90, 433);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(688, 69);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 19;
            this.guna2PictureBox3.TabStop = false;
            // 
            // labelDetinutiInCelule
            // 
            this.labelDetinutiInCelule.AutoSize = true;
            this.labelDetinutiInCelule.BackColor = System.Drawing.Color.Transparent;
            this.labelDetinutiInCelule.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetinutiInCelule.ForeColor = System.Drawing.Color.Black;
            this.labelDetinutiInCelule.Location = new System.Drawing.Point(853, 442);
            this.labelDetinutiInCelule.Name = "labelDetinutiInCelule";
            this.labelDetinutiInCelule.Size = new System.Drawing.Size(142, 47);
            this.labelDetinutiInCelule.TabIndex = 17;
            this.labelDetinutiInCelule.Text = "Detalii";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(244, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 47);
            this.label6.TabIndex = 21;
            this.label6.Text = "Deținuți în arest";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(90, 588);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(688, 69);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 22;
            this.guna2PictureBox4.TabStop = false;
            // 
            // labelDetinutiInArest
            // 
            this.labelDetinutiInArest.AutoSize = true;
            this.labelDetinutiInArest.BackColor = System.Drawing.Color.Transparent;
            this.labelDetinutiInArest.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetinutiInArest.ForeColor = System.Drawing.Color.Black;
            this.labelDetinutiInArest.Location = new System.Drawing.Point(853, 597);
            this.labelDetinutiInArest.Name = "labelDetinutiInArest";
            this.labelDetinutiInArest.Size = new System.Drawing.Size(142, 47);
            this.labelDetinutiInArest.TabIndex = 20;
            this.labelDetinutiInArest.Text = "Detalii";
            // 
            // UserControlDetinuti_Acasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2PictureBox4);
            this.Controls.Add(this.labelDetinutiInArest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.labelDetinutiInCelule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.labelDetinutiTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.labelDetinutiLiberi);
            this.Name = "UserControlDetinuti_Acasa";
            this.Size = new System.Drawing.Size(1335, 934);
            this.Load += new System.EventHandler(this.UserControlDetinuti_Acasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dETINUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cELULABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cELULABindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CELULATableAdapter cELULATableAdapter;
        private System.Windows.Forms.BindingSource dETINUTBindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.DETINUTTableAdapter dETINUTTableAdapter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label labelDetinutiLiberi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label labelDetinutiTotal;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label labelDetinutiInCelule;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label labelDetinutiInArest;
    }
}
