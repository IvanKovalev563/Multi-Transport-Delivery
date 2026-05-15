namespace Order_Manager
{
    partial class FormAddClient
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
            buttonAccept = new Button();
            buttonCancel = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxPersAccount = new TextBox();
            label5 = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            comboBoxRegion = new ComboBox();
            comboBoxCity = new ComboBox();
            comboBoxStreet = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            textBoxHouse = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(264, 304);
            buttonAccept.Margin = new Padding(4, 3, 4, 3);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(125, 30);
            buttonAccept.TabIndex = 0;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(131, 304);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 30);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(155, 83);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.MaxLength = 45;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 23);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 3;
            label1.Text = "Добавление клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(18, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 4;
            label2.Text = "Имя (ФИО/Навание):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(18, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Регион:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(19, 226);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 8;
            label4.Text = "Лицевой счет:";
            // 
            // textBoxPersAccount
            // 
            textBoxPersAccount.Location = new Point(156, 226);
            textBoxPersAccount.Margin = new Padding(4, 3, 4, 3);
            textBoxPersAccount.MaxLength = 20;
            textBoxPersAccount.Name = "textBoxPersAccount";
            textBoxPersAccount.Size = new Size(233, 23);
            textBoxPersAccount.TabIndex = 7;
            textBoxPersAccount.KeyPress += textBoxPersAccount_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(19, 256);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 10;
            label5.Text = "Ном. телефона:";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBoxPhone.Location = new Point(156, 256);
            maskedTextBoxPhone.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxPhone.Mask = "+7 (999) 999-99-99";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(233, 21);
            maskedTextBoxPhone.TabIndex = 13;
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(73, 112);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(315, 23);
            comboBoxRegion.TabIndex = 14;
            comboBoxRegion.SelectedIndexChanged += comboBoxRegion_SelectedIndexChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(73, 141);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(315, 23);
            comboBoxCity.TabIndex = 15;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Location = new Point(73, 168);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(315, 23);
            comboBoxStreet.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(18, 143);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 17;
            label6.Text = "Город:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(18, 170);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 18;
            label7.Text = "Улица:";
            // 
            // textBoxHouse
            // 
            textBoxHouse.Location = new Point(72, 197);
            textBoxHouse.Margin = new Padding(4, 3, 4, 3);
            textBoxHouse.MaxLength = 45;
            textBoxHouse.Name = "textBoxHouse";
            textBoxHouse.Size = new Size(316, 23);
            textBoxHouse.TabIndex = 19;
            textBoxHouse.KeyPress += textBoxHouse_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(18, 199);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 20;
            label8.Text = "Дом:";
            // 
            // FormAddClient
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
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormAddClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client add";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPersAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private ComboBox comboBoxRegion;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxStreet;
        private Label label6;
        private Label label7;
        private TextBox textBoxHouse;
        private Label label8;
    }
}