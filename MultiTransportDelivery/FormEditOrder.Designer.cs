namespace MultiTransportDelivery
{
    partial class FormEditOrder
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
            labelCost = new Label();
            buttonCancel = new Button();
            buttonAccept = new Button();
            label5 = new Label();
            numericUpDownWeight = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxClient = new ComboBox();
            label7 = new Label();
            comboBoxStatus = new ComboBox();
            label8 = new Label();
            comboBoxCurrency = new ComboBox();
            label9 = new Label();
            comboBoxSubtransport = new ComboBox();
            comboBoxTransport = new ComboBox();
            label4 = new Label();
            comboBoxCityFrom = new ComboBox();
            label10 = new Label();
            comboBoxRegionFrom = new ComboBox();
            labelDistance = new Label();
            label6 = new Label();
            comboBoxCityTo = new ComboBox();
            label11 = new Label();
            comboBoxRegionTo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            SuspendLayout();
            // 
            // labelCost
            // 
            labelCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCost.Location = new Point(13, 334);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(140, 22);
            labelCost.TabIndex = 53;
            labelCost.Text = "10000 рублей";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(314, 332);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 30);
            buttonCancel.TabIndex = 52;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(447, 332);
            buttonAccept.Margin = new Padding(4, 3, 4, 3);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(125, 30);
            buttonAccept.TabIndex = 51;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(13, 236);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 50;
            label5.Text = "Вес груза (кг):";
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.DecimalPlaces = 1;
            numericUpDownWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownWeight.Location = new Point(172, 235);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(494, 25);
            numericUpDownWeight.TabIndex = 49;
            numericUpDownWeight.ValueChanged += calculateCost;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(13, 117);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 46;
            label3.Text = "Транспорт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(13, 86);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 44;
            label2.Text = "Клиент:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 43;
            label1.Text = "Редактирование заказа";
            // 
            // comboBoxClient
            // 
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(172, 83);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(496, 25);
            comboBoxClient.TabIndex = 42;
            comboBoxClient.SelectedIndexChanged += calculateCost;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(13, 266);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 57;
            label7.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Новый", "В сборке", "В пути", "Доставлен" });
            comboBoxStatus.Location = new Point(172, 263);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(494, 25);
            comboBoxStatus.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(12, 298);
            label8.Name = "label8";
            label8.Size = new Size(55, 17);
            label8.TabIndex = 59;
            label8.Text = "Валюта:";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Location = new Point(172, 295);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(494, 25);
            comboBoxCurrency.TabIndex = 58;
            comboBoxCurrency.SelectedIndexChanged += calculateCost;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(346, 117);
            label9.Name = "label9";
            label9.Size = new Size(128, 17);
            label9.TabIndex = 62;
            label9.Text = "Подвид транспорта:";
            // 
            // comboBoxSubtransport
            // 
            comboBoxSubtransport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSubtransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubtransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxSubtransport.FormattingEnabled = true;
            comboBoxSubtransport.Location = new Point(498, 115);
            comboBoxSubtransport.Name = "comboBoxSubtransport";
            comboBoxSubtransport.Size = new Size(170, 25);
            comboBoxSubtransport.TabIndex = 61;
            // 
            // comboBoxTransport
            // 
            comboBoxTransport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTransport.FormattingEnabled = true;
            comboBoxTransport.Location = new Point(172, 115);
            comboBoxTransport.Name = "comboBoxTransport";
            comboBoxTransport.Size = new Size(168, 25);
            comboBoxTransport.TabIndex = 60;
            comboBoxTransport.SelectedIndexChanged += comboBoxTransport_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(424, 149);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 66;
            label4.Text = "Город:";
            // 
            // comboBoxCityFrom
            // 
            comboBoxCityFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCityFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCityFrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCityFrom.FormattingEnabled = true;
            comboBoxCityFrom.Location = new Point(482, 146);
            comboBoxCityFrom.Name = "comboBoxCityFrom";
            comboBoxCityFrom.Size = new Size(186, 25);
            comboBoxCityFrom.TabIndex = 65;
            comboBoxCityFrom.SelectedIndexChanged += comboBoxCityFrom_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(13, 149);
            label10.Name = "label10";
            label10.Size = new Size(133, 17);
            label10.TabIndex = 64;
            label10.Text = "Регион отправления:";
            // 
            // comboBoxRegionFrom
            // 
            comboBoxRegionFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxRegionFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegionFrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRegionFrom.FormattingEnabled = true;
            comboBoxRegionFrom.Location = new Point(172, 146);
            comboBoxRegionFrom.Name = "comboBoxRegionFrom";
            comboBoxRegionFrom.Size = new Size(246, 25);
            comboBoxRegionFrom.TabIndex = 63;
            comboBoxRegionFrom.SelectedIndexChanged += comboBoxRegionFrom_SelectedIndexChanged;
            // 
            // labelDistance
            // 
            labelDistance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDistance.AutoSize = true;
            labelDistance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDistance.Location = new Point(12, 208);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(105, 17);
            labelDistance.TabIndex = 67;
            labelDistance.Text = "Расстояние (км):";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(424, 179);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 71;
            label6.Text = "Город:";
            // 
            // comboBoxCityTo
            // 
            comboBoxCityTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCityTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCityTo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCityTo.FormattingEnabled = true;
            comboBoxCityTo.Location = new Point(483, 176);
            comboBoxCityTo.Name = "comboBoxCityTo";
            comboBoxCityTo.Size = new Size(185, 25);
            comboBoxCityTo.TabIndex = 70;
            comboBoxCityTo.SelectedIndexChanged += comboBoxCityTo_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(14, 179);
            label11.Name = "label11";
            label11.Size = new Size(125, 17);
            label11.TabIndex = 69;
            label11.Text = "Регион назначения:";
            // 
            // comboBoxRegionTo
            // 
            comboBoxRegionTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxRegionTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegionTo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRegionTo.FormattingEnabled = true;
            comboBoxRegionTo.Location = new Point(173, 176);
            comboBoxRegionTo.Name = "comboBoxRegionTo";
            comboBoxRegionTo.Size = new Size(246, 25);
            comboBoxRegionTo.TabIndex = 68;
            comboBoxRegionTo.SelectedIndexChanged += comboBoxRegionTo_SelectedIndexChanged;
            // 
            // FormEditOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 374);
            Controls.Add(label6);
            Controls.Add(comboBoxCityTo);
            Controls.Add(label11);
            Controls.Add(comboBoxRegionTo);
            Controls.Add(labelDistance);
            Controls.Add(label4);
            Controls.Add(comboBoxCityFrom);
            Controls.Add(label10);
            Controls.Add(comboBoxRegionFrom);
            Controls.Add(label9);
            Controls.Add(comboBoxSubtransport);
            Controls.Add(comboBoxTransport);
            Controls.Add(label8);
            Controls.Add(comboBoxCurrency);
            Controls.Add(label7);
            Controls.Add(comboBoxStatus);
            Controls.Add(labelCost);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            Controls.Add(label5);
            Controls.Add(numericUpDownWeight);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxClient);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormEditOrder";
            Text = "Order edit";
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCost;
        private Button buttonCancel;
        private Button buttonAccept;
        private Label label5;
        private NumericUpDown numericUpDownWeight;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxClient;
        private Label label7;
        private ComboBox comboBoxStatus;
        private Label label8;
        private ComboBox comboBoxCurrency;
        private Label label9;
        private ComboBox comboBoxSubtransport;
        private ComboBox comboBoxTransport;
        private Label label4;
        private ComboBox comboBoxCityFrom;
        private Label label10;
        private ComboBox comboBoxRegionFrom;
        private Label labelDistance;
        private Label label6;
        private ComboBox comboBoxCityTo;
        private Label label11;
        private ComboBox comboBoxRegionTo;
    }
}