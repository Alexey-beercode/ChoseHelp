namespace HelperForm
{
    sealed partial class Finder
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
            this.SuspendLayout();
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Size = new Size(1200, 800);
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Finder3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finder3";
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.RosyBrown;
            this.next.Location = new System.Drawing.Point(1000, 650);
            this.next.Name = "find";
            this.next.Size = new System.Drawing.Size(150, 50);
            this.next.TabIndex = 3;
            this.next.Text = "Найти";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.ButtonNext_Click);
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
            //lanel1
            //
            this.label1.Text = "Выберете направление";
            this.label1.AutoSize= true;
            this.label1.Location = new Point(200,100);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold |
                System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);



        }

        #endregion

        private Label label1;
        private Button next;
        private Button menu;
        private Button last;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private Panel panel1;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private RadioButton radioButton19;
        private RadioButton radioButton20;
    }
}