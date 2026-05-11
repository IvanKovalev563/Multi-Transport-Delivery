namespace MultiTransportDelivery
{
    partial class FormEditClient
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
            maskedTextBoxPhone = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxPersAccount = new TextBox();
            label3 = new Label();
            textBoxAddress = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            buttonCancel = new Button();
            buttonAccept = new Button();
            SuspendLayout();
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBoxPhone.Location = new Point(153, 167);
            maskedTextBoxPhone.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxPhone.Mask = "+7 (999) 999-99-99";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(233, 21);
            maskedTextBoxPhone.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(16, 167);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 23;
            label5.Text = "Ном. тел.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(16, 137);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 22;
            label4.Text = "Лицевой счет:";
            // 
            // textBoxPersAccount
            // 
            textBoxPersAccount.Location = new Point(153, 137);
            textBoxPersAccount.Margin = new Padding(4, 3, 4, 3);
            textBoxPersAccount.MaxLength = 45;
            textBoxPersAccount.Name = "textBoxPersAccount";
            textBoxPersAccount.Size = new Size(233, 23);
            textBoxPersAccount.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(16, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 20;
            label3.Text = "Адрес:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(153, 107);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.MaxLength = 45;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(233, 23);
            textBoxAddress.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(16, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 18;
            label2.Text = "Имя (ФИО/Навание):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 17;
            label1.Text = "Редактирование клиента";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(153, 77);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.MaxLength = 45;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 23);
            textBoxName.TabIndex = 16;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(129, 228);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 30);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(262, 228);
            buttonAccept.Margin = new Padding(4, 3, 4, 3);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(125, 30);
            buttonAccept.TabIndex = 14;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // FormEditClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 280);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxPersAccount);
            Controls.Add(label3);
            Controls.Add(textBoxAddress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormEditClient";
            Text = "Client edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxPhone;
        private Label label5;
        private Label label4;
        private TextBox textBoxPersAccount;
        private Label label3;
        private TextBox textBoxAddress;
        private Label label2;
        private Label label1;
        private TextBox textBoxName;
        private Button buttonCancel;
        private Button buttonAccept;
    }
}