
namespace Incercare_licenta.FormCelule
{
    partial class UserControlCelule_Celule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cELULABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Incercare_licenta.DataSet1();
            this.cELULATableAdapter = new Incercare_licenta.DataSet1TableAdapters.CELULATableAdapter();
            this.textBoxCautareCelula = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBoxCautare = new System.Windows.Forms.GroupBox();
            this.labelCautareCelula = new System.Windows.Forms.Label();
            this.groupBoxStergere = new System.Windows.Forms.GroupBox();
            this.butonStergere = new Guna.UI2.WinForms.Guna2Button();
            this.labelStergereCelula1 = new System.Windows.Forms.Label();
            this.textBoxStergere = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxIntroducereCapacitateMaxima = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxIntroducereDenumireCelula = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxIntroducereLocuriDisponibile = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBoxServicii = new System.Windows.Forms.GroupBox();
            this.groupBoxIntroducere = new System.Windows.Forms.GroupBox();
            this.butonResetare = new Guna.UI2.WinForms.Guna2Button();
            this.butonActualizareCelula = new Guna.UI2.WinForms.Guna2Button();
            this.butonAdaugareCelula = new Guna.UI2.WinForms.Guna2Button();
            this.labelCapacitateMaxima = new System.Windows.Forms.Label();
            this.labelLocuriLibere = new System.Windows.Forms.Label();
            this.LabelDenumire = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelCentralCelule = new System.Windows.Forms.Panel();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dENUMIREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCURILIBEREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCURIMAXIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cELULABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBoxCautare.SuspendLayout();
            this.groupBoxStergere.SuspendLayout();
            this.groupBoxServicii.SuspendLayout();
            this.groupBoxIntroducere.SuspendLayout();
            this.panelCentralCelule.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dENUMIREDataGridViewTextBoxColumn,
            this.lOCURILIBEREDataGridViewTextBoxColumn,
            this.lOCURIMAXIMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cELULABindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(115, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 268);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            // textBoxCautareCelula
            // 
            this.textBoxCautareCelula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCautareCelula.DefaultText = "";
            this.textBoxCautareCelula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCautareCelula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCautareCelula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCautareCelula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCautareCelula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCautareCelula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxCautareCelula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCautareCelula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCautareCelula.Location = new System.Drawing.Point(349, 80);
            this.textBoxCautareCelula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCautareCelula.Name = "textBoxCautareCelula";
            this.textBoxCautareCelula.PasswordChar = '\0';
            this.textBoxCautareCelula.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxCautareCelula.PlaceholderText = "";
            this.textBoxCautareCelula.SelectedText = "";
            this.textBoxCautareCelula.Size = new System.Drawing.Size(165, 40);
            this.textBoxCautareCelula.TabIndex = 3;
            this.textBoxCautareCelula.TextChanged += new System.EventHandler(this.textBoxCautareCelula_TextChanged);
            // 
            // groupBoxCautare
            // 
            this.groupBoxCautare.Controls.Add(this.labelCautareCelula);
            this.groupBoxCautare.Controls.Add(this.textBoxCautareCelula);
            this.groupBoxCautare.Location = new System.Drawing.Point(118, 32);
            this.groupBoxCautare.Name = "groupBoxCautare";
            this.groupBoxCautare.Size = new System.Drawing.Size(556, 165);
            this.groupBoxCautare.TabIndex = 5;
            this.groupBoxCautare.TabStop = false;
            this.groupBoxCautare.Text = "Căutare";
            // 
            // labelCautareCelula
            // 
            this.labelCautareCelula.AutoSize = true;
            this.labelCautareCelula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCautareCelula.Location = new System.Drawing.Point(16, 81);
            this.labelCautareCelula.Name = "labelCautareCelula";
            this.labelCautareCelula.Size = new System.Drawing.Size(256, 21);
            this.labelCautareCelula.TabIndex = 7;
            this.labelCautareCelula.Text = "Introduceți denumirea celulei:";
            // 
            // groupBoxStergere
            // 
            this.groupBoxStergere.Controls.Add(this.butonStergere);
            this.groupBoxStergere.Controls.Add(this.labelStergereCelula1);
            this.groupBoxStergere.Controls.Add(this.textBoxStergere);
            this.groupBoxStergere.Location = new System.Drawing.Point(719, 32);
            this.groupBoxStergere.Name = "groupBoxStergere";
            this.groupBoxStergere.Size = new System.Drawing.Size(619, 165);
            this.groupBoxStergere.TabIndex = 6;
            this.groupBoxStergere.TabStop = false;
            this.groupBoxStergere.Text = "Ștergere";
            // 
            // butonStergere
            // 
            this.butonStergere.BackColor = System.Drawing.Color.Transparent;
            this.butonStergere.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonStergere.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonStergere.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonStergere.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonStergere.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.butonStergere.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonStergere.ForeColor = System.Drawing.Color.White;
            this.butonStergere.Location = new System.Drawing.Point(358, 80);
            this.butonStergere.Name = "butonStergere";
            this.butonStergere.Size = new System.Drawing.Size(162, 39);
            this.butonStergere.TabIndex = 10;
            this.butonStergere.Text = "Ștergeți";
            this.butonStergere.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.butonStergere.Click += new System.EventHandler(this.butonStergere_Click);
            // 
            // labelStergereCelula1
            // 
            this.labelStergereCelula1.AutoSize = true;
            this.labelStergereCelula1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStergereCelula1.Location = new System.Drawing.Point(4, 32);
            this.labelStergereCelula1.Name = "labelStergereCelula1";
            this.labelStergereCelula1.Size = new System.Drawing.Size(479, 21);
            this.labelStergereCelula1.TabIndex = 9;
            this.labelStergereCelula1.Text = "Introduceți denumirea celulei pe care doriți să o ștergeți:";
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
            // textBoxIntroducereCapacitateMaxima
            // 
            this.textBoxIntroducereCapacitateMaxima.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIntroducereCapacitateMaxima.DefaultText = "";
            this.textBoxIntroducereCapacitateMaxima.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIntroducereCapacitateMaxima.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIntroducereCapacitateMaxima.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIntroducereCapacitateMaxima.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIntroducereCapacitateMaxima.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereCapacitateMaxima.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxIntroducereCapacitateMaxima.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIntroducereCapacitateMaxima.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereCapacitateMaxima.Location = new System.Drawing.Point(831, 52);
            this.textBoxIntroducereCapacitateMaxima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIntroducereCapacitateMaxima.Name = "textBoxIntroducereCapacitateMaxima";
            this.textBoxIntroducereCapacitateMaxima.PasswordChar = '\0';
            this.textBoxIntroducereCapacitateMaxima.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereCapacitateMaxima.PlaceholderText = "";
            this.textBoxIntroducereCapacitateMaxima.SelectedText = "";
            this.textBoxIntroducereCapacitateMaxima.Size = new System.Drawing.Size(150, 40);
            this.textBoxIntroducereCapacitateMaxima.TabIndex = 8;
            // 
            // textBoxIntroducereDenumireCelula
            // 
            this.textBoxIntroducereDenumireCelula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIntroducereDenumireCelula.DefaultText = "";
            this.textBoxIntroducereDenumireCelula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIntroducereDenumireCelula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIntroducereDenumireCelula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIntroducereDenumireCelula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIntroducereDenumireCelula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereDenumireCelula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxIntroducereDenumireCelula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIntroducereDenumireCelula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereDenumireCelula.Location = new System.Drawing.Point(292, 52);
            this.textBoxIntroducereDenumireCelula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIntroducereDenumireCelula.Name = "textBoxIntroducereDenumireCelula";
            this.textBoxIntroducereDenumireCelula.PasswordChar = '\0';
            this.textBoxIntroducereDenumireCelula.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereDenumireCelula.PlaceholderText = "";
            this.textBoxIntroducereDenumireCelula.SelectedText = "";
            this.textBoxIntroducereDenumireCelula.Size = new System.Drawing.Size(151, 40);
            this.textBoxIntroducereDenumireCelula.TabIndex = 9;
            // 
            // textBoxIntroducereLocuriDisponibile
            // 
            this.textBoxIntroducereLocuriDisponibile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIntroducereLocuriDisponibile.DefaultText = "";
            this.textBoxIntroducereLocuriDisponibile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIntroducereLocuriDisponibile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIntroducereLocuriDisponibile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIntroducereLocuriDisponibile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIntroducereLocuriDisponibile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereLocuriDisponibile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxIntroducereLocuriDisponibile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIntroducereLocuriDisponibile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereLocuriDisponibile.Location = new System.Drawing.Point(1012, 53);
            this.textBoxIntroducereLocuriDisponibile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIntroducereLocuriDisponibile.Name = "textBoxIntroducereLocuriDisponibile";
            this.textBoxIntroducereLocuriDisponibile.PasswordChar = '\0';
            this.textBoxIntroducereLocuriDisponibile.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxIntroducereLocuriDisponibile.PlaceholderText = "";
            this.textBoxIntroducereLocuriDisponibile.SelectedText = "";
            this.textBoxIntroducereLocuriDisponibile.Size = new System.Drawing.Size(155, 40);
            this.textBoxIntroducereLocuriDisponibile.TabIndex = 10;
            // 
            // groupBoxServicii
            // 
            this.groupBoxServicii.Controls.Add(this.groupBoxIntroducere);
            this.groupBoxServicii.Controls.Add(this.groupBoxCautare);
            this.groupBoxServicii.Controls.Add(this.groupBoxStergere);
            this.groupBoxServicii.Location = new System.Drawing.Point(3, 277);
            this.groupBoxServicii.Name = "groupBoxServicii";
            this.groupBoxServicii.Size = new System.Drawing.Size(1441, 522);
            this.groupBoxServicii.TabIndex = 7;
            this.groupBoxServicii.TabStop = false;
            // 
            // groupBoxIntroducere
            // 
            this.groupBoxIntroducere.Controls.Add(this.butonResetare);
            this.groupBoxIntroducere.Controls.Add(this.butonActualizareCelula);
            this.groupBoxIntroducere.Controls.Add(this.butonAdaugareCelula);
            this.groupBoxIntroducere.Controls.Add(this.labelCapacitateMaxima);
            this.groupBoxIntroducere.Controls.Add(this.labelLocuriLibere);
            this.groupBoxIntroducere.Controls.Add(this.LabelDenumire);
            this.groupBoxIntroducere.Controls.Add(this.textBoxIntroducereDenumireCelula);
            this.groupBoxIntroducere.Controls.Add(this.textBoxIntroducereLocuriDisponibile);
            this.groupBoxIntroducere.Controls.Add(this.textBoxIntroducereCapacitateMaxima);
            this.groupBoxIntroducere.Location = new System.Drawing.Point(118, 245);
            this.groupBoxIntroducere.Name = "groupBoxIntroducere";
            this.groupBoxIntroducere.Size = new System.Drawing.Size(1220, 214);
            this.groupBoxIntroducere.TabIndex = 11;
            this.groupBoxIntroducere.TabStop = false;
            this.groupBoxIntroducere.Text = "Introducere / Actualizare";
            // 
            // butonResetare
            // 
            this.butonResetare.BackColor = System.Drawing.Color.Transparent;
            this.butonResetare.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonResetare.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonResetare.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonResetare.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonResetare.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.butonResetare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.butonResetare.ForeColor = System.Drawing.Color.White;
            this.butonResetare.Location = new System.Drawing.Point(819, 134);
            this.butonResetare.Name = "butonResetare";
            this.butonResetare.Size = new System.Drawing.Size(162, 39);
            this.butonResetare.TabIndex = 15;
            this.butonResetare.Text = "Resetați";
            this.butonResetare.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.butonResetare.Click += new System.EventHandler(this.butonResetare_Click);
            // 
            // butonActualizareCelula
            // 
            this.butonActualizareCelula.BackColor = System.Drawing.Color.Transparent;
            this.butonActualizareCelula.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonActualizareCelula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonActualizareCelula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonActualizareCelula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonActualizareCelula.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.butonActualizareCelula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.butonActualizareCelula.ForeColor = System.Drawing.Color.White;
            this.butonActualizareCelula.Location = new System.Drawing.Point(474, 134);
            this.butonActualizareCelula.Name = "butonActualizareCelula";
            this.butonActualizareCelula.Size = new System.Drawing.Size(162, 39);
            this.butonActualizareCelula.TabIndex = 14;
            this.butonActualizareCelula.Text = "Actualizați";
            this.butonActualizareCelula.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.butonActualizareCelula.Click += new System.EventHandler(this.butonActualizareCelula_Click);
            // 
            // butonAdaugareCelula
            // 
            this.butonAdaugareCelula.BackColor = System.Drawing.Color.Transparent;
            this.butonAdaugareCelula.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonAdaugareCelula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonAdaugareCelula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonAdaugareCelula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonAdaugareCelula.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.butonAdaugareCelula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.butonAdaugareCelula.ForeColor = System.Drawing.Color.White;
            this.butonAdaugareCelula.Location = new System.Drawing.Point(102, 134);
            this.butonAdaugareCelula.Name = "butonAdaugareCelula";
            this.butonAdaugareCelula.Size = new System.Drawing.Size(162, 39);
            this.butonAdaugareCelula.TabIndex = 11;
            this.butonAdaugareCelula.Text = "Salvați";
            this.butonAdaugareCelula.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.butonAdaugareCelula.Click += new System.EventHandler(this.butonAdaugareCelula_Click);
            // 
            // labelCapacitateMaxima
            // 
            this.labelCapacitateMaxima.AutoSize = true;
            this.labelCapacitateMaxima.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacitateMaxima.Location = new System.Drawing.Point(522, 52);
            this.labelCapacitateMaxima.Name = "labelCapacitateMaxima";
            this.labelCapacitateMaxima.Size = new System.Drawing.Size(188, 21);
            this.labelCapacitateMaxima.TabIndex = 13;
            this.labelCapacitateMaxima.Text = "Capacitate Maximă:";
            // 
            // labelLocuriLibere
            // 
            this.labelLocuriLibere.AutoSize = true;
            this.labelLocuriLibere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocuriLibere.Location = new System.Drawing.Point(1008, 28);
            this.labelLocuriLibere.Name = "labelLocuriLibere";
            this.labelLocuriLibere.Size = new System.Drawing.Size(155, 21);
            this.labelLocuriLibere.TabIndex = 12;
            this.labelLocuriLibere.Text = "Locuri disponibile:";
            // 
            // LabelDenumire
            // 
            this.LabelDenumire.AutoSize = true;
            this.LabelDenumire.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDenumire.Location = new System.Drawing.Point(103, 61);
            this.LabelDenumire.Name = "LabelDenumire";
            this.LabelDenumire.Size = new System.Drawing.Size(93, 21);
            this.LabelDenumire.TabIndex = 11;
            this.LabelDenumire.Text = "Denumire:";
            // 
            // panelCentralCelule
            // 
            this.panelCentralCelule.BackColor = System.Drawing.Color.White;
            this.panelCentralCelule.Controls.Add(this.dataGridView1);
            this.panelCentralCelule.Controls.Add(this.groupBoxServicii);
            this.panelCentralCelule.Location = new System.Drawing.Point(0, 3);
            this.panelCentralCelule.Name = "panelCentralCelule";
            this.panelCentralCelule.Size = new System.Drawing.Size(1539, 850);
            this.panelCentralCelule.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 10.63799F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dENUMIREDataGridViewTextBoxColumn
            // 
            this.dENUMIREDataGridViewTextBoxColumn.DataPropertyName = "DENUMIRE";
            this.dENUMIREDataGridViewTextBoxColumn.FillWeight = 29.60908F;
            this.dENUMIREDataGridViewTextBoxColumn.HeaderText = "Denumire celulă";
            this.dENUMIREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dENUMIREDataGridViewTextBoxColumn.Name = "dENUMIREDataGridViewTextBoxColumn";
            this.dENUMIREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOCURILIBEREDataGridViewTextBoxColumn
            // 
            this.lOCURILIBEREDataGridViewTextBoxColumn.DataPropertyName = "LOCURI_LIBERE";
            this.lOCURILIBEREDataGridViewTextBoxColumn.FillWeight = 29.60908F;
            this.lOCURILIBEREDataGridViewTextBoxColumn.HeaderText = "Locuri disponibile";
            this.lOCURILIBEREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOCURILIBEREDataGridViewTextBoxColumn.Name = "lOCURILIBEREDataGridViewTextBoxColumn";
            this.lOCURILIBEREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOCURIMAXIMDataGridViewTextBoxColumn
            // 
            this.lOCURIMAXIMDataGridViewTextBoxColumn.DataPropertyName = "LOCURI_MAXIM";
            this.lOCURIMAXIMDataGridViewTextBoxColumn.FillWeight = 29.60908F;
            this.lOCURIMAXIMDataGridViewTextBoxColumn.HeaderText = "Capacitate maximă";
            this.lOCURIMAXIMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOCURIMAXIMDataGridViewTextBoxColumn.Name = "lOCURIMAXIMDataGridViewTextBoxColumn";
            this.lOCURIMAXIMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserControlCelule_Celule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCentralCelule);
            this.Name = "UserControlCelule_Celule";
            this.Size = new System.Drawing.Size(1539, 850);
            this.Load += new System.EventHandler(this.UserControlCelule_Acasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cELULABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBoxCautare.ResumeLayout(false);
            this.groupBoxCautare.PerformLayout();
            this.groupBoxStergere.ResumeLayout(false);
            this.groupBoxStergere.PerformLayout();
            this.groupBoxServicii.ResumeLayout(false);
            this.groupBoxIntroducere.ResumeLayout(false);
            this.groupBoxIntroducere.PerformLayout();
            this.panelCentralCelule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cELULABindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CELULATableAdapter cELULATableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCautareCelula;
        private System.Windows.Forms.GroupBox groupBoxCautare;
        private System.Windows.Forms.GroupBox groupBoxStergere;
        private System.Windows.Forms.Label labelCautareCelula;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIntroducereCapacitateMaxima;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIntroducereDenumireCelula;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIntroducereLocuriDisponibile;
        private System.Windows.Forms.Label labelStergereCelula1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStergere;
        private System.Windows.Forms.GroupBox groupBoxServicii;
        private Guna.UI2.WinForms.Guna2Button butonStergere;
        private System.Windows.Forms.GroupBox groupBoxIntroducere;
        private System.Windows.Forms.Label LabelDenumire;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelCapacitateMaxima;
        private System.Windows.Forms.Label labelLocuriLibere;
        private Guna.UI2.WinForms.Guna2Button butonResetare;
        private Guna.UI2.WinForms.Guna2Button butonActualizareCelula;
        private Guna.UI2.WinForms.Guna2Button butonAdaugareCelula;
        private System.Windows.Forms.Panel panelCentralCelule;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dENUMIREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCURILIBEREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCURIMAXIMDataGridViewTextBoxColumn;
    }
}
