namespace adatbazis
{
    partial class Torol
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
            FilterBox2 = new ComboBox();
            label4 = new Label();
            TorolButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // FilterBox2
            // 
            FilterBox2.FormattingEnabled = true;
            FilterBox2.Location = new Point(201, 91);
            FilterBox2.Name = "FilterBox2";
            FilterBox2.Size = new Size(372, 33);
            FilterBox2.TabIndex = 8;
            FilterBox2.SelectedIndexChanged += FilterBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 99);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 9;
            label4.Text = "Nevek";
            // 
            // TorolButton
            // 
            TorolButton.Location = new Point(226, 206);
            TorolButton.Name = "TorolButton";
            TorolButton.Size = new Size(285, 54);
            TorolButton.TabIndex = 10;
            TorolButton.Text = "Torles";
            TorolButton.UseVisualStyleBackColor = true;
            TorolButton.Click += TorolButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(226, 299);
            button1.Name = "button1";
            button1.Size = new Size(285, 54);
            button1.TabIndex = 11;
            button1.Text = "Vissza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Torol
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 413);
            Controls.Add(button1);
            Controls.Add(TorolButton);
            Controls.Add(label4);
            Controls.Add(FilterBox2);
            Name = "Torol";
            Text = "Torol";
            Load += Torol_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FilterBox2;
        private Label label4;
        private Button TorolButton;
        private Button button1;
    }
}