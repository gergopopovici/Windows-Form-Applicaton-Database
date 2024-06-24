namespace adatbazis
{
    partial class Modosit
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            VendegID = new DataGridViewTextBoxColumn();
            Nev = new DataGridViewTextBoxColumn();
            Kor = new DataGridViewTextBoxColumn();
            Telefonszam = new DataGridViewTextBoxColumn();
            AsztalID = new DataGridViewTextBoxColumn();
            Kapacitas = new DataGridViewTextBoxColumn();
            AsztalSzam = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            KezdIdo = new DataGridViewTextBoxColumn();
            VegIdo = new DataGridViewTextBoxColumn();
            VendegSzam = new DataGridViewTextBoxColumn();
            VegOsszeg = new DataGridViewTextBoxColumn();
            label1 = new Label();
            UpdateBox1 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, VendegID, Nev, Kor, Telefonszam, AsztalID, Kapacitas, AsztalSzam, Datum, KezdIdo, VegIdo, VendegSzam, VegOsszeg });
            dataGridView1.Location = new Point(67, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(864, 252);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Visible = false;
            id.Width = 150;
            // 
            // VendegID
            // 
            VendegID.HeaderText = "VendegID";
            VendegID.MinimumWidth = 8;
            VendegID.Name = "VendegID";
            VendegID.Visible = false;
            VendegID.Width = 150;
            // 
            // Nev
            // 
            Nev.HeaderText = "Nev";
            Nev.MinimumWidth = 8;
            Nev.Name = "Nev";
            Nev.Width = 150;
            // 
            // Kor
            // 
            Kor.HeaderText = "Kor";
            Kor.MinimumWidth = 8;
            Kor.Name = "Kor";
            Kor.Width = 150;
            // 
            // Telefonszam
            // 
            Telefonszam.HeaderText = "TelefonSzam";
            Telefonszam.MinimumWidth = 8;
            Telefonszam.Name = "Telefonszam";
            Telefonszam.Width = 150;
            // 
            // AsztalID
            // 
            AsztalID.HeaderText = "AsztalID";
            AsztalID.MinimumWidth = 8;
            AsztalID.Name = "AsztalID";
            AsztalID.Visible = false;
            AsztalID.Width = 150;
            // 
            // Kapacitas
            // 
            Kapacitas.HeaderText = "Kapacitas";
            Kapacitas.MinimumWidth = 8;
            Kapacitas.Name = "Kapacitas";
            Kapacitas.Visible = false;
            Kapacitas.Width = 150;
            // 
            // AsztalSzam
            // 
            AsztalSzam.HeaderText = "AsztalSzam";
            AsztalSzam.MinimumWidth = 8;
            AsztalSzam.Name = "AsztalSzam";
            AsztalSzam.Width = 150;
            // 
            // Datum
            // 
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 8;
            Datum.Name = "Datum";
            Datum.Width = 150;
            // 
            // KezdIdo
            // 
            KezdIdo.HeaderText = "KezdIdo";
            KezdIdo.MinimumWidth = 8;
            KezdIdo.Name = "KezdIdo";
            KezdIdo.Width = 150;
            // 
            // VegIdo
            // 
            VegIdo.HeaderText = "VegIdo";
            VegIdo.MinimumWidth = 8;
            VegIdo.Name = "VegIdo";
            VegIdo.Width = 150;
            // 
            // VendegSzam
            // 
            VendegSzam.HeaderText = "VendegSzam";
            VendegSzam.MinimumWidth = 8;
            VendegSzam.Name = "VendegSzam";
            VendegSzam.Width = 150;
            // 
            // VegOsszeg
            // 
            VegOsszeg.HeaderText = "VegOsszeg";
            VegOsszeg.MinimumWidth = 8;
            VegOsszeg.Name = "VegOsszeg";
            VegOsszeg.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 344);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 12;
            label1.Text = "VegOsszeg";
            // 
            // UpdateBox1
            // 
            UpdateBox1.Location = new Point(208, 338);
            UpdateBox1.Name = "UpdateBox1";
            UpdateBox1.Size = new Size(150, 31);
            UpdateBox1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(413, 335);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "Modosit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 387);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 17;
            label3.Text = "Regi ertek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 387);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 18;
            label2.Text = "Uj ertek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 387);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 19;
            label4.Text = "Aktualis Ertek";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(67, 415);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(244, 415);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(413, 415);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 22;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(782, 297);
            button1.Name = "button1";
            button1.Size = new Size(160, 141);
            button1.TabIndex = 23;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(616, 297);
            button3.Name = "button3";
            button3.Size = new Size(160, 141);
            button3.TabIndex = 24;
            button3.Text = "Vissza";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Modosit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(UpdateBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Modosit";
            Text = "Modosit";
            Load += Modosit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn VendegID;
        private DataGridViewTextBoxColumn Nev;
        private DataGridViewTextBoxColumn Kor;
        private DataGridViewTextBoxColumn Telefonszam;
        private DataGridViewTextBoxColumn AsztalID;
        private DataGridViewTextBoxColumn Kapacitas;
        private DataGridViewTextBoxColumn AsztalSzam;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn KezdIdo;
        private DataGridViewTextBoxColumn VegIdo;
        private DataGridViewTextBoxColumn VendegSzam;
        private DataGridViewTextBoxColumn VegOsszeg;
        private Label label1;
        private TextBox UpdateBox1;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Button button3;
    }
}