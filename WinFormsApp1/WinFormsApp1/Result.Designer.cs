namespace HelperForm
{
    partial class Result
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
            this.find = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 140);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберете специальность";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(180, 250);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(800, 350);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.Font = new Font("Segoe UI", 15F,
                ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.SelectedIndexChanged += new EventHandler(checkedListBoxItem_ChechedChanges);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.last);
            this.Controls.Add(this.find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реузльтат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CheckedListBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button find;
        private Button last;
        private Button menu;
        private Label label1;
        private CheckedListBox checkedListBox1;
    }
}