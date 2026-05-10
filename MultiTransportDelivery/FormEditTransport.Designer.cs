namespace MultiTransportDelivery
{
    partial class FormEditTransport
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
            textBoxPrice = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            buttonCancel = new Button();
            buttonAccept = new Button();
            SuspendLayout();
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(180, 107);
            textBoxPrice.Margin = new Padding(4, 3, 4, 3);
            textBoxPrice.MaxLength = 12;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(213, 23);
            textBoxPrice.TabIndex = 31;
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(16, 109);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 30;
            label5.Text = "Стоимость (1 км/тонна):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(16, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 29;
            label2.Text = "Название:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 25);
            label1.TabIndex = 28;
            label1.Text = "Добавление транспорта";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(180, 77);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.MaxLength = 45;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(213, 23);
            textBoxName.TabIndex = 27;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(135, 220);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 30);
            buttonCancel.TabIndex = 26;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(268, 220);
            buttonAccept.Margin = new Padding(4, 3, 4, 3);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(125, 30);
            buttonAccept.TabIndex = 25;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // FormEditTransport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 266);
            Controls.Add(textBoxPrice);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormEditTransport";
            Text = "FormEditTransport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrice;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox textBoxName;
        private Button buttonCancel;
        private Button buttonAccept;
    }
}