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
            label8 = new Label();
            textBoxHouse = new TextBox();
            label7 = new Label();
            label6 = new Label();
            comboBoxStreet = new ComboBox();
            comboBoxCity = new ComboBox();
            comboBoxRegion = new ComboBox();
            maskedTextBoxPhone = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxPersAccount = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            buttonCancel = new Button();
            buttonAccept = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(16, 193);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 37;
            label8.Text = "Дом:";
            // 
            // textBoxHouse
            // 
            textBoxHouse.Location = new Point(70, 191);
            textBoxHouse.Margin = new Padding(4, 3, 4, 3);
            textBoxHouse.MaxLength = 45;
            textBoxHouse.Name = "textBoxHouse";
            textBoxHouse.Size = new Size(316, 23);
            textBoxHouse.TabIndex = 36;
            textBoxHouse.KeyPress += textBoxHouse_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(16, 164);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 35;
            label7.Text = "Улица:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(16, 137);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 34;
            label6.Text = "Город:";
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Location = new Point(71, 162);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(315, 23);
            comboBoxStreet.TabIndex = 33;
            // 
            // comboBoxCity
            // 
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(71, 135);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(315, 23);
            comboBoxCity.TabIndex = 32;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(71, 106);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(315, 23);
            comboBoxRegion.TabIndex = 31;
            comboBoxRegion.SelectedIndexChanged += comboBoxRegion_SelectedIndexChanged;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBoxPhone.Location = new Point(154, 250);
            maskedTextBoxPhone.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxPhone.Mask = "+7 (999) 999-99-99";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(233, 21);
            maskedTextBoxPhone.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(17, 250);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 29;
            label5.Text = "Ном. телефона:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(17, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 28;
            label4.Text = "Лицевой счет:";
            // 
            // textBoxPersAccount
            // 
            textBoxPersAccount.Location = new Point(154, 220);
            textBoxPersAccount.Margin = new Padding(4, 3, 4, 3);
            textBoxPersAccount.MaxLength = 20;
            textBoxPersAccount.Name = "textBoxPersAccount";
            textBoxPersAccount.Size = new Size(233, 23);
            textBoxPersAccount.TabIndex = 27;
            textBoxPersAccount.KeyPress += textBoxPersAccount_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(16, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 26;
            label3.Text = "Регион:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(16, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 25;
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
            label1.TabIndex = 24;
            label1.Text = "Редактирование клиента";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(153, 77);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.MaxLength = 45;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 23);
            textBoxName.TabIndex = 23;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(129, 298);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 30);
            buttonCancel.TabIndex = 22;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(262, 298);
            buttonAccept.Margin = new Padding(4, 3, 4, 3);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(125, 30);
            buttonAccept.TabIndex = 21;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // FormEditClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 346);
            Controls.Add(label8);
            Controls.Add(textBoxHouse);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxStreet);
            Controls.Add(comboBoxCity);
            Controls.Add(comboBoxRegion);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxPersAccount);
            Controls.Add(label3);
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

        private Label label8;
        private TextBox textBoxHouse;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxStreet;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxRegion;
        private MaskedTextBox maskedTextBoxPhone;
        private Label label5;
        private Label label4;
        private TextBox textBoxPersAccount;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxName;
        private Button buttonCancel;
        private Button buttonAccept;
    }
}