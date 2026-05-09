namespace Order_Manager
{
    partial class FormAbout
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
            labelName = new Label();
            labelAuthor = new Label();
            buttonOk = new Button();
            labelVersion = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(4, 3);
            labelName.Margin = new Padding(4, 3, 4, 3);
            labelName.Name = "labelName";
            labelName.Size = new Size(206, 24);
            labelName.TabIndex = 0;
            labelName.Text = "Multi Transport Delivery";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthor.Location = new Point(5, 74);
            labelAuthor.Margin = new Padding(4, 7, 4, 7);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(47, 16);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Автор";
            // 
            // buttonOk
            // 
            buttonOk.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOk.Location = new Point(223, 128);
            buttonOk.Margin = new Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(96, 29);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "Ок";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelVersion.Location = new Point(5, 42);
            labelVersion.Margin = new Padding(4, 7, 4, 7);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(54, 16);
            labelVersion.TabIndex = 3;
            labelVersion.Text = "Версия";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(labelVersion);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelAuthor);
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 107);
            panel1.TabIndex = 4;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 168);
            Controls.Add(panel1);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Panel panel1;
    }
}