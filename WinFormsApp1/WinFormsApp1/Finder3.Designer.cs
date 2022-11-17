namespace HelperForm
{
    partial class Finder3
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.find = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете форму обучения :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(500, 330);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(190, 39);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Бесплатная";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new EventHandler(RadioButton1_CheckChanges);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(500, 380);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(153, 39);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Платная";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new EventHandler(RadioButton2_CheckChanges);
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.RosyBrown;
            this.find.Location = new System.Drawing.Point(1000, 650);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(150, 50);
            this.find.TabIndex = 3;
            this.find.Text = "Найти";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // last
            // 
            this.last.BackColor = System.Drawing.Color.RosyBrown;
            this.last.Location = new System.Drawing.Point(500, 650);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(150, 50);
            this.last.TabIndex = 4;
            this.last.Text = "Назад";
            this.last.UseVisualStyleBackColor = false;
            this.last.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RosyBrown;
            this.menu.Location = new System.Drawing.Point(50, 650);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(150, 50);
            this.menu.TabIndex = 5;
            this.menu.Text = "Меню";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Finder3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.last);
            this.Controls.Add(this.find);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Finder3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finder3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button find;
        private Button last;
        private Button menu;
    }
}