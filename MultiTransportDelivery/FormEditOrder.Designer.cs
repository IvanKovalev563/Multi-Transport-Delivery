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
            labelCost.Location = new Point(15, 446);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(170, 29);
            labelCost.TabIndex = 53;
            labelCost.Text = "10000 рублей";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(359, 442);
            buttonCancel.Margin = new Padding(5, 4, 5, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(143, 40);
            buttonCancel.TabIndex = 52;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(511, 442);
            buttonAccept.Margin = new Padding(5, 4, 5, 4);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(143, 40);
            buttonAccept.TabIndex = 51;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(15, 315);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 50;
            label5.Text = "Вес груза (кг):";
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.DecimalPlaces = 1;
            numericUpDownWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownWeight.Location = new Point(197, 313);
            numericUpDownWeight.Margin = new Padding(3, 4, 3, 4);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(565, 29);
            numericUpDownWeight.TabIndex = 49;
            numericUpDownWeight.ValueChanged += calculateCost;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(15, 156);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 46;
            label3.Text = "Транспорт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(15, 115);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 44;
            label2.Text = "Клиент:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 31);
            label1.TabIndex = 43;
            label1.Text = "Редактирование заказа";
            // 
            // comboBoxClient
            // 
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(197, 111);
            comboBoxClient.Margin = new Padding(3, 4, 3, 4);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(566, 29);
            comboBoxClient.TabIndex = 42;
            comboBoxClient.SelectedIndexChanged += calculateCost;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(15, 355);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 57;
            label7.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Новый", "В сборке", "В пути", "Доставлен" });
            comboBoxStatus.Location = new Point(197, 351);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(564, 29);
            comboBoxStatus.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(14, 397);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 59;
            label8.Text = "Валюта:";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Location = new Point(197, 393);
            comboBoxCurrency.Margin = new Padding(3, 4, 3, 4);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(564, 29);
            comboBoxCurrency.TabIndex = 58;
            comboBoxCurrency.SelectedIndexChanged += calculateCost;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(395, 156);
            label9.Name = "label9";
            label9.Size = new Size(168, 23);
            label9.TabIndex = 62;
            label9.Text = "Подвид транспорта:";
            // 
            // comboBoxSubtransport
            // 
            comboBoxSubtransport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSubtransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubtransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxSubtransport.FormattingEnabled = true;
            comboBoxSubtransport.Location = new Point(569, 153);
            comboBoxSubtransport.Margin = new Padding(3, 4, 3, 4);
            comboBoxSubtransport.Name = "comboBoxSubtransport";
            comboBoxSubtransport.Size = new Size(194, 29);
            comboBoxSubtransport.TabIndex = 61;
            // 
            // comboBoxTransport
            // 
            comboBoxTransport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTransport.FormattingEnabled = true;
            comboBoxTransport.Location = new Point(197, 153);
            comboBoxTransport.Margin = new Padding(3, 4, 3, 4);
            comboBoxTransport.Name = "comboBoxTransport";
            comboBoxTransport.Size = new Size(192, 29);
            comboBoxTransport.TabIndex = 60;
            comboBoxTransport.SelectedIndexChanged += comboBoxTransport_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(484, 199);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 66;
            label4.Text = "Город:";
            // 
            // comboBoxCityFrom
            // 
            comboBoxCityFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCityFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCityFrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCityFrom.FormattingEnabled = true;
            comboBoxCityFrom.Location = new Point(551, 195);
            comboBoxCityFrom.Margin = new Padding(3, 4, 3, 4);
            comboBoxCityFrom.Name = "comboBoxCityFrom";
            comboBoxCityFrom.Size = new Size(212, 29);
            comboBoxCityFrom.TabIndex = 65;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(15, 199);
            label10.Name = "label10";
            label10.Size = new Size(177, 23);
            label10.TabIndex = 64;
            label10.Text = "Регион отправления:";
            // 
            // comboBoxRegionFrom
            // 
            comboBoxRegionFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxRegionFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegionFrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRegionFrom.FormattingEnabled = true;
            comboBoxRegionFrom.Location = new Point(197, 195);
            comboBoxRegionFrom.Margin = new Padding(3, 4, 3, 4);
            comboBoxRegionFrom.Name = "comboBoxRegionFrom";
            comboBoxRegionFrom.Size = new Size(281, 29);
            comboBoxRegionFrom.TabIndex = 63;
            // 
            // labelDistance
            // 
            labelDistance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDistance.AutoSize = true;
            labelDistance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDistance.Location = new Point(14, 278);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(139, 23);
            labelDistance.TabIndex = 67;
            labelDistance.Text = "Расстояние (км):";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(485, 239);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 71;
            label6.Text = "Город:";
            // 
            // comboBoxCityTo
            // 
            comboBoxCityTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCityTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCityTo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCityTo.FormattingEnabled = true;
            comboBoxCityTo.Location = new Point(552, 235);
            comboBoxCityTo.Margin = new Padding(3, 4, 3, 4);
            comboBoxCityTo.Name = "comboBoxCityTo";
            comboBoxCityTo.Size = new Size(211, 29);
            comboBoxCityTo.TabIndex = 70;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(16, 239);
            label11.Name = "label11";
            label11.Size = new Size(169, 23);
            label11.TabIndex = 69;
            label11.Text = "Регион назначения:";
            // 
            // comboBoxRegionTo
            // 
            comboBoxRegionTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxRegionTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegionTo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRegionTo.FormattingEnabled = true;
            comboBoxRegionTo.Location = new Point(198, 235);
            comboBoxRegionTo.Margin = new Padding(3, 4, 3, 4);
            comboBoxRegionTo.Name = "comboBoxRegionTo";
            comboBoxRegionTo.Size = new Size(281, 29);
            comboBoxRegionTo.TabIndex = 68;
            // 
            // FormEditOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 498);
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
            Margin = new Padding(3, 4, 3, 4);
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