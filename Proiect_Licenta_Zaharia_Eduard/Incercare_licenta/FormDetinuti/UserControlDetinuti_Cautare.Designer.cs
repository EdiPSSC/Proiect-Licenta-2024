
namespace Incercare_licenta.FormDetinuti
{
    partial class UserControlDetinuti_Cautare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dETINUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Incercare_licenta.DataSet2();
            this.dETINUTTableAdapter = new Incercare_licenta.DataSet2TableAdapters.DETINUTTableAdapter();
            this.groupBoxServicii = new System.Windows.Forms.GroupBox();
            this.groupBoxCautare = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFapta = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCelula = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrenume = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCautareCelula = new System.Windows.Forms.Label();
            this.textBoxCautareDetinut = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBoxStergere = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butonStergere2 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.butonStergere = new Guna.UI2.WinForms.Guna2Button();
            this.labelStergereDetinut = new System.Windows.Forms.Label();
            this.textBoxStergere = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataSet3 = new Incercare_licenta.DataSet3();
            this.dETINUTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dETINUTTableAdapter1 = new Incercare_licenta.DataSet3TableAdapters.DETINUTTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dETINUTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panelContinutCentral = new System.Windows.Forms.Panel();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dETINUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.groupBoxServicii.SuspendLayout();
            this.groupBoxCautare.SuspendLayout();
            this.groupBoxStergere.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETINUTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETINUTBindingSource2)).BeginInit();
            this.panelContinutCentral.SuspendLayout();
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
            // dETINUTTableAdapter
            // 
            this.dETINUTTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxServicii
            // 
            this.groupBoxServicii.Controls.Add(this.groupBoxCautare);
            this.groupBoxServicii.Controls.Add(this.groupBoxStergere);
            this.groupBoxServicii.Location = new System.Drawing.Point(18, 339);
            this.groupBoxServicii.Name = "groupBoxServicii";
            this.groupBoxServicii.Size = new System.Drawing.Size(1409, 458);
            this.groupBoxServicii.TabIndex = 8;
            this.groupBoxServicii.TabStop = false;
            // 
            // groupBoxCautare
            // 
            this.groupBoxCautare.Controls.Add(this.label3);
            this.groupBoxCautare.Controls.Add(this.textBoxFapta);
            this.groupBoxCautare.Controls.Add(this.label4);
            this.groupBoxCautare.Controls.Add(this.textBoxCelula);
            this.groupBoxCautare.Controls.Add(this.label1);
            this.groupBoxCautare.Controls.Add(this.textBoxPrenume);
            this.groupBoxCautare.Controls.Add(this.labelCautareCelula);
            this.groupBoxCautare.Controls.Add(this.textBoxCautareDetinut);
            this.groupBoxCautare.Location = new System.Drawing.Point(118, 32);
            this.groupBoxCautare.Name = "groupBoxCautare";
            this.groupBoxCautare.Size = new System.Drawing.Size(556, 341);
            this.groupBoxCautare.TabIndex = 5;
            this.groupBoxCautare.TabStop = false;
            this.groupBoxCautare.Text = "Căutare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Introduceți fapta săvârșită:";
            // 
            // textBoxFapta
            // 
            this.textBoxFapta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFapta.DefaultText = "";
            this.textBoxFapta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFapta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFapta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFapta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFapta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFapta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxFapta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFapta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFapta.Location = new System.Drawing.Point(349, 246);
            this.textBoxFapta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFapta.Name = "textBoxFapta";
            this.textBoxFapta.PasswordChar = '\0';
            this.textBoxFapta.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxFapta.PlaceholderText = "";
            this.textBoxFapta.SelectedText = "";
            this.textBoxFapta.Size = new System.Drawing.Size(165, 40);
            this.textBoxFapta.TabIndex = 12;
            this.textBoxFapta.TextChanged += new System.EventHandler(this.textBoxFapta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Introduceți celula căutată:";
            // 
            // textBoxCelula
            // 
            this.textBoxCelula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCelula.DefaultText = "";
            this.textBoxCelula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCelula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCelula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCelula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCelula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCelula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxCelula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCelula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCelula.Location = new System.Drawing.Point(349, 173);
            this.textBoxCelula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCelula.Name = "textBoxCelula";
            this.textBoxCelula.PasswordChar = '\0';
            this.textBoxCelula.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxCelula.PlaceholderText = "";
            this.textBoxCelula.SelectedText = "";
            this.textBoxCelula.Size = new System.Drawing.Size(165, 40);
            this.textBoxCelula.TabIndex = 10;
            this.textBoxCelula.TextChanged += new System.EventHandler(this.textBoxCelula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Introduceți prenumele deținutului: ";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrenume.DefaultText = "";
            this.textBoxPrenume.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPrenume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPrenume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrenume.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrenume.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrenume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPrenume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPrenume.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrenume.Location = new System.Drawing.Point(349, 108);
            this.textBoxPrenume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.PasswordChar = '\0';
            this.textBoxPrenume.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxPrenume.PlaceholderText = "";
            this.textBoxPrenume.SelectedText = "";
            this.textBoxPrenume.Size = new System.Drawing.Size(165, 40);
            this.textBoxPrenume.TabIndex = 8;
            this.textBoxPrenume.TextChanged += new System.EventHandler(this.textBoxPrenume_TextChanged);
            // 
            // labelCautareCelula
            // 
            this.labelCautareCelula.AutoSize = true;
            this.labelCautareCelula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCautareCelula.Location = new System.Drawing.Point(16, 43);
            this.labelCautareCelula.Name = "labelCautareCelula";
            this.labelCautareCelula.Size = new System.Drawing.Size(264, 21);
            this.labelCautareCelula.TabIndex = 7;
            this.labelCautareCelula.Text = "Introduceți numele deținutului: ";
            // 
            // textBoxCautareDetinut
            // 
            this.textBoxCautareDetinut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCautareDetinut.DefaultText = "";
            this.textBoxCautareDetinut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCautareDetinut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCautareDetinut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCautareDetinut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCautareDetinut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCautareDetinut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxCautareDetinut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCautareDetinut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCautareDetinut.Location = new System.Drawing.Point(349, 42);
            this.textBoxCautareDetinut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCautareDetinut.Name = "textBoxCautareDetinut";
            this.textBoxCautareDetinut.PasswordChar = '\0';
            this.textBoxCautareDetinut.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxCautareDetinut.PlaceholderText = "";
            this.textBoxCautareDetinut.SelectedText = "";
            this.textBoxCautareDetinut.Size = new System.Drawing.Size(165, 40);
            this.textBoxCautareDetinut.TabIndex = 3;
            this.textBoxCautareDetinut.TextChanged += new System.EventHandler(this.textBoxCautareDetinut_TextChanged);
            // 
            // groupBoxStergere
            // 
            this.groupBoxStergere.Controls.Add(this.groupBox1);
            this.groupBoxStergere.Controls.Add(this.butonStergere);
            this.groupBoxStergere.Controls.Add(this.labelStergereDetinut);
            this.groupBoxStergere.Controls.Add(this.textBoxStergere);
            this.groupBoxStergere.Location = new System.Drawing.Point(719, 32);
            this.groupBoxStergere.Name = "groupBoxStergere";
            this.groupBoxStergere.Size = new System.Drawing.Size(619, 341);
            this.groupBoxStergere.TabIndex = 6;
            this.groupBoxStergere.TabStop = false;
            this.groupBoxStergere.Text = "Ștergere";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butonStergere2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ștergere prin Selecție";
            // 
            // butonStergere2
            // 
            this.butonStergere2.BackColor = System.Drawing.Color.Transparent;
            this.butonStergere2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonStergere2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonStergere2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonStergere2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonStergere2.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.butonStergere2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.butonStergere2.ForeColor = System.Drawing.Color.White;
            this.butonStergere2.Location = new System.Drawing.Point(94, 96);
            this.butonStergere2.Name = "butonStergere2";
            this.butonStergere2.Size = new System.Drawing.Size(162, 39);
            this.butonStergere2.TabIndex = 12;
            this.butonStergere2.Text = "Ștergeți";
            this.butonStergere2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.butonStergere2.Click += new System.EventHandler(this.butonStergere2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selectați deținutul pe care doriți să îl ștergeți:";
            // 
            // butonStergere
            // 
            this.butonStergere.BackColor = System.Drawing.Color.Transparent;
            this.butonStergere.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonStergere.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonStergere.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonStergere.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonStergere.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.butonStergere.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.butonStergere.ForeColor = System.Drawing.Color.White;
            this.butonStergere.Location = new System.Drawing.Point(358, 80);
            this.butonStergere.Name = "butonStergere";
            this.butonStergere.Size = new System.Drawing.Size(162, 39);
            this.butonStergere.TabIndex = 10;
            this.butonStergere.Text = "Ștergeți";
            this.butonStergere.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.butonStergere.Click += new System.EventHandler(this.butonStergere_Click);
            // 
            // labelStergereDetinut
            // 
            this.labelStergereDetinut.AutoSize = true;
            this.labelStergereDetinut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStergereDetinut.Location = new System.Drawing.Point(4, 32);
            this.labelStergereDetinut.Name = "labelStergereDetinut";
            this.labelStergereDetinut.Size = new System.Drawing.Size(473, 21);
            this.labelStergereDetinut.TabIndex = 9;
            this.labelStergereDetinut.Text = "Introduceți CNP-ul deținutului pe care doriți să îl ștergeți:";
            // 
            // textBoxStergere
            // 
            this.textBoxStergere.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxStergere.DefaultText = "";
            this.textBoxStergere.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxStergere.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxStergere.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStergere.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStergere.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStergere.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxStergere.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxStergere.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStergere.Location = new System.Drawing.Point(100, 80);
            this.textBoxStergere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStergere.Name = "textBoxStergere";
            this.textBoxStergere.PasswordChar = '\0';
            this.textBoxStergere.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxStergere.PlaceholderText = "";
            this.textBoxStergere.SelectedText = "";
            this.textBoxStergere.Size = new System.Drawing.Size(162, 40);
            this.textBoxStergere.TabIndex = 8;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dETINUTBindingSource1
            // 
            this.dETINUTBindingSource1.DataMember = "DETINUT";
            this.dETINUTBindingSource1.DataSource = this.dataSet3;
            // 
            // dETINUTTableAdapter1
            // 
            this.dETINUTTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeight = 25;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNP,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.CELULA});
            this.dataGridView2.DataSource = this.dETINUTBindingSource2;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(18, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1409, 313);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // dETINUTBindingSource2
            // 
            this.dETINUTBindingSource2.DataMember = "DETINUT";
            this.dETINUTBindingSource2.DataSource = this.dataSet3;
            // 
            // panelContinutCentral
            // 
            this.panelContinutCentral.Controls.Add(this.groupBoxServicii);
            this.panelContinutCentral.Controls.Add(this.dataGridView2);
            this.panelContinutCentral.Location = new System.Drawing.Point(0, 0);
            this.panelContinutCentral.Name = "panelContinutCentral";
            this.panelContinutCentral.Size = new System.Drawing.Size(1464, 931);
            this.panelContinutCentral.TabIndex = 11;
            // 
            // CNP
            // 
            this.CNP.DataPropertyName = "CNP";
            this.CNP.HeaderText = "CNP";
            this.CNP.MinimumWidth = 6;
            this.CNP.Name = "CNP";
            this.CNP.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NUME";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRENUME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FAPTA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fapta";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATA_INREGISTRARE";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dată înregistrare";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DATA_ELIBERARE";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dată eliberare";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "STARE";
            this.dataGridViewTextBoxColumn6.HeaderText = "Starea curentă";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // CELULA
            // 
            this.CELULA.DataPropertyName = "CELULA";
            this.CELULA.HeaderText = "Celula";
            this.CELULA.MinimumWidth = 6;
            this.CELULA.Name = "CELULA";
            this.CELULA.ReadOnly = true;
            // 
            // UserControlDetinuti_Cautare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContinutCentral);
            this.Name = "UserControlDetinuti_Cautare";
            this.Size = new System.Drawing.Size(1464, 931);
            ((System.ComponentModel.ISupportInitialize)(this.dETINUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.groupBoxServicii.ResumeLayout(false);
            this.groupBoxCautare.ResumeLayout(false);
            this.groupBoxCautare.PerformLayout();
            this.groupBoxStergere.ResumeLayout(false);
            this.groupBoxStergere.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETINUTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETINUTBindingSource2)).EndInit();
            this.panelContinutCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dETINUTBindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.DETINUTTableAdapter dETINUTTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxServicii;
        private System.Windows.Forms.GroupBox groupBoxCautare;
        private System.Windows.Forms.Label labelCautareCelula;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCautareDetinut;
        private System.Windows.Forms.GroupBox groupBoxStergere;
        private Guna.UI2.WinForms.Guna2Button butonStergere;
        private System.Windows.Forms.Label labelStergereDetinut;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStergere;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPrenume;
        private System.Windows.Forms.BindingSource dETINUTBindingSource1;
        private DataSet3 dataSet3;
        private DataSet3TableAdapters.DETINUTTableAdapter dETINUTTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dETINUTBindingSource2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button butonStergere2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFapta;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCelula;
        private System.Windows.Forms.Panel panelContinutCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULA;
    }
}
