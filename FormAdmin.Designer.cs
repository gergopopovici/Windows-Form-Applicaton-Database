namespace adatbazis
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            button1 = new Button();
            FilterBox1 = new ComboBox();
            Label1 = new Label();
            Filterbutton = new Button();
            textSzuro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            FilterBox2 = new ComboBox();
            label4 = new Label();
            TorolButton = new Button();
            UpdateBox1 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, VendegID, Nev, Kor, Telefonszam, AsztalID, Kapacitas, AsztalSzam, Datum, KezdIdo, VegIdo, VendegSzam, VegOsszeg });
            dataGridView1.Location = new Point(80, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(864, 252);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
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
            // button1
            // 
            button1.Location = new Point(933, 448);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FilterBox1
            // 
            FilterBox1.FormattingEnabled = true;
            FilterBox1.Location = new Point(162, 40);
            FilterBox1.Name = "FilterBox1";
            FilterBox1.Size = new Size(182, 33);
            FilterBox1.TabIndex = 2;
            FilterBox1.SelectedIndexChanged += FilterBox1_SelectedIndexChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(42, 48);
            Label1.Name = "Label1";
            Label1.Size = new Size(101, 25);
            Label1.TabIndex = 3;
            Label1.Text = "AsztalSzam";
            Label1.Click += label1_Click;
            // 
            // Filterbutton
            // 
            Filterbutton.Location = new Point(408, 38);
            Filterbutton.Name = "Filterbutton";
            Filterbutton.Size = new Size(112, 34);
            Filterbutton.TabIndex = 4;
            Filterbutton.Text = "filter";
            Filterbutton.UseVisualStyleBackColor = true;
            Filterbutton.Click += Filterbutton_Click;
            // 
            // textSzuro
            // 
            textSzuro.Location = new Point(162, 86);
            textSzuro.Name = "textSzuro";
            textSzuro.Size = new Size(150, 31);
            textSzuro.TabIndex = 5;
            textSzuro.TextChanged += textSzuro_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 89);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 6;
            label3.Text = "Nev";
            // 
            // FilterBox2
            // 
            FilterBox2.FormattingEnabled = true;
            FilterBox2.Location = new Point(752, 39);
            FilterBox2.Name = "FilterBox2";
            FilterBox2.Size = new Size(182, 33);
            FilterBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(666, 43);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 8;
            label4.Text = "Nevek";
            // 
            // TorolButton
            // 
            TorolButton.Location = new Point(752, 84);
            TorolButton.Name = "TorolButton";
            TorolButton.Size = new Size(112, 34);
            TorolButton.TabIndex = 9;
            TorolButton.Text = "Torles";
            TorolButton.UseVisualStyleBackColor = true;
            TorolButton.Click += TorolButton_Click;
            // 
            // UpdateBox1
            // 
            UpdateBox1.Location = new Point(182, 420);
            UpdateBox1.Name = "UpdateBox1";
            UpdateBox1.Size = new Size(150, 31);
            UpdateBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 426);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 11;
            label5.Text = "VegOsszeg";
            // 
            // button2
            // 
            button2.Location = new Point(360, 417);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "Modosit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(42, 479);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(203, 479);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(379, 479);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 457);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 16;
            label6.Text = "Regi ertek";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(233, 460);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 17;
            label7.Text = "Uj ertek";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(408, 457);
            label8.Name = "label8";
            label8.Size = new Size(118, 25);
            label8.TabIndex = 18;
            label8.Text = "Aktualis Ertek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 518);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(UpdateBox1);
            Controls.Add(TorolButton);
            Controls.Add(label4);
            Controls.Add(FilterBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textSzuro);
            Controls.Add(Filterbutton);
            Controls.Add(Label1);
            Controls.Add(FilterBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Etterem";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox FilterBox1;
        private Label Label1;
        private Button Filterbutton;
        private TextBox textSzuro;
        private Label label2;
        private Label label3;
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
        private ComboBox FilterBox2;
        private Label label4;
        private Button TorolButton;
        private TextBox UpdateBox1;
        private Label label5;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}