namespace OknoDrugie
{
    partial class Form1
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
            SuspendLayout();
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(68, 109);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(125, 27);
            textBoxImie.TabIndex = 0;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(68, 180);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(125, 27);
            textBoxNazwisko.TabIndex = 1;
            // 
            // textBoxWiek
            // 
            textBoxWiek.Location = new Point(68, 252);
            textBoxWiek.Name = "textBoxWiek";
            textBoxWiek.Size = new Size(125, 27);
            textBoxWiek.TabIndex = 2;
            // 
            // comboBoxStanowisko
            // 
            comboBoxStanowisko.FormattingEnabled = true;
            comboBoxStanowisko.Location = new Point(68, 320);
            comboBoxStanowisko.Name = "comboBoxStanowisko";
            comboBoxStanowisko.Size = new Size(151, 28);
            comboBoxStanowisko.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(414, 319);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Zatwierdz";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(606, 319);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxStanowisko);
            Controls.Add(textBoxWiek);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxImie);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
