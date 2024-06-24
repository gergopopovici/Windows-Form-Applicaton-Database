namespace adatbazis
{
    partial class Kezdo
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
            label2 = new Label();
            FilterBox1 = new ComboBox();
            label3 = new Label();
            Filterbutton = new Button();
            textSzuro = new TextBox();
            menuStrip1 = new MenuStrip();
            müveltekToolStripMenuItem = new ToolStripMenuItem();
            hozzáadToolStripMenuItem = new ToolStripMenuItem();
            törölToolStripMenuItem = new ToolStripMenuItem();
            modositToolStripMenuItem = new ToolStripMenuItem();
            kilépToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, VendegID, Nev, Kor, Telefonszam, AsztalID, Kapacitas, AsztalSzam, Datum, KezdIdo, VegIdo, VendegSzam, VegOsszeg });
            dataGridView1.Location = new Point(43, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(864, 252);
            dataGridView1.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 45);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 5;
            label2.Text = "AsztalSzam";
            // 
            // FilterBox1
            // 
            FilterBox1.FormattingEnabled = true;
            FilterBox1.Location = new Point(327, 37);
            FilterBox1.Name = "FilterBox1";
            FilterBox1.Size = new Size(182, 33);
            FilterBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 87);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 7;
            label3.Text = "Nev";
            label3.Click += label3_Click;
            // 
            // Filterbutton
            // 
            Filterbutton.Location = new Point(559, 78);
            Filterbutton.Name = "Filterbutton";
            Filterbutton.Size = new Size(112, 34);
            Filterbutton.TabIndex = 8;
            Filterbutton.Text = "filter";
            Filterbutton.UseVisualStyleBackColor = true;
            Filterbutton.Click += Filterbutton_Click;
            // 
            // textSzuro
            // 
            textSzuro.Location = new Point(327, 83);
            textSzuro.Name = "textSzuro";
            textSzuro.Size = new Size(150, 31);
            textSzuro.TabIndex = 9;
            textSzuro.TextChanged += textSzuro_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { müveltekToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(965, 33);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // müveltekToolStripMenuItem
            // 
            müveltekToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hozzáadToolStripMenuItem, törölToolStripMenuItem, modositToolStripMenuItem, kilépToolStripMenuItem });
            müveltekToolStripMenuItem.Name = "müveltekToolStripMenuItem";
            müveltekToolStripMenuItem.Size = new Size(100, 29);
            müveltekToolStripMenuItem.Text = "Müveltek";
            müveltekToolStripMenuItem.Click += müveltekToolStripMenuItem_Click;
            // 
            // hozzáadToolStripMenuItem
            // 
            hozzáadToolStripMenuItem.Name = "hozzáadToolStripMenuItem";
            hozzáadToolStripMenuItem.Size = new Size(270, 34);
            hozzáadToolStripMenuItem.Text = "Hozzáad";
            hozzáadToolStripMenuItem.Click += hozzáadToolStripMenuItem_Click;
            // 
            // törölToolStripMenuItem
            // 
            törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            törölToolStripMenuItem.Size = new Size(270, 34);
            törölToolStripMenuItem.Text = "Töröl";
            törölToolStripMenuItem.Click += törölToolStripMenuItem_Click;
            // 
            // modositToolStripMenuItem
            // 
            modositToolStripMenuItem.Name = "modositToolStripMenuItem";
            modositToolStripMenuItem.Size = new Size(270, 34);
            modositToolStripMenuItem.Text = "Modosit";
            modositToolStripMenuItem.Click += modositToolStripMenuItem_Click;
            // 
            // kilépToolStripMenuItem
            // 
            kilépToolStripMenuItem.Name = "kilépToolStripMenuItem";
            kilépToolStripMenuItem.Size = new Size(270, 34);
            kilépToolStripMenuItem.Text = "Kilép";
            kilépToolStripMenuItem.Click += kilépToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(722, 408);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Kezdo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 471);
            Controls.Add(button1);
            Controls.Add(textSzuro);
            Controls.Add(Filterbutton);
            Controls.Add(label3);
            Controls.Add(FilterBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Kezdo";
            Text = "Kezdo";
            Load += Kezdo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label label2;
        private ComboBox FilterBox1;
        private Label label3;
        private Button Filterbutton;
        private TextBox textSzuro;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem müveltekToolStripMenuItem;
        private ToolStripMenuItem hozzáadToolStripMenuItem;
        private ToolStripMenuItem törölToolStripMenuItem;
        private ToolStripMenuItem kilépToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem modositToolStripMenuItem;
    }
}