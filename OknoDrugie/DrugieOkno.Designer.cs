namespace Lab3
{ 
    partial class OknoDodawania
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
            textBoxImie = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxWiek = new TextBox();
            comboBoxStanowisko = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(68, 54);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(235, 27);
            textBoxImie.TabIndex = 0;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(68, 136);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(235, 27);
            textBoxNazwisko.TabIndex = 1;
            // 
            // textBoxWiek
            // 
            textBoxWiek.Location = new Point(68, 217);
            textBoxWiek.Name = "textBoxWiek";
            textBoxWiek.Size = new Size(235, 27);
            textBoxWiek.TabIndex = 2;
            // 
            // comboBoxStanowisko
            // 
            comboBoxStanowisko.FormattingEnabled = true;
            comboBoxStanowisko.Location = new Point(68, 300);
            comboBoxStanowisko.Name = "comboBoxStanowisko";
            comboBoxStanowisko.Size = new Size(235, 28);
            comboBoxStanowisko.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(115, 356);
            button1.Name = "button1";
            button1.Size = new Size(154, 52);
            button1.TabIndex = 4;
            button1.Text = "Zatwierdz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(394, 356);
            button2.Name = "button2";
            button2.Size = new Size(146, 52);
            button2.TabIndex = 5;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 57);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 6;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 139);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 220);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 303);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Stanowisko";
            // 
            // OknoDodawania
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxStanowisko);
            Controls.Add(textBoxWiek);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxImie);
            Name = "OknoDodawania";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxImie;
        private TextBox textBoxNazwisko;
        private TextBox textBoxWiek;
        private ComboBox comboBoxStanowisko;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
