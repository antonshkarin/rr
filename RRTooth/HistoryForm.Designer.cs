namespace RRTooth
{
    partial class HistoryForm
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(17, 70);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(57, 13);
            this.labelLastName.TabIndex = 13;
            this.labelLastName.Text = "Отчество:";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(17, 12);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(59, 13);
            this.labelSecondName.TabIndex = 12;
            this.labelSecondName.Text = "Фамилия:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(17, 44);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(32, 13);
            this.labelFirstName.TabIndex = 11;
            this.labelFirstName.Text = "Имя:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(100, 70);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(100, 12);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondName.TabIndex = 9;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(100, 41);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "HistoryForm";
            this.Text = "История";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button button1;
    }
}