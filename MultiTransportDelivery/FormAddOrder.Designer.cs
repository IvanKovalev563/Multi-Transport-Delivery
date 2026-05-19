namespace MultiTransportDelivery
{
    partial class FormAddOrder
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
            comboBoxClient = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxTransport = new ComboBox();
            label4 = new Label();
            comboBoxRegionFrom = new ComboBox();
            numericUpDownWeight = new NumericUpDown();
            label5 = new Label();
            buttonCancel = new Button();
            buttonAccept = new Button();
            labelCost = new Label();
            labelDistance = new Label();
            comboBoxCurrency = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBoxSubtransport = new ComboBox();
            label9 = new Label();
            comboBoxCityFrom = new ComboBox();
            label10 = new Label();
            comboBoxCityTo = new ComboBox();
            label11 = new Label();
            comboBoxRegionTo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            SuspendLayout();
            // 
            // comboBoxClient
            // 
            comboBoxClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(197, 111);
            comboBoxClient.Margin = new Padding(3, 4, 3, 4);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(568, 29);
            comboBoxClient.TabIndex = 0;
            comboBoxClient.SelectedIndexChanged += calculateCost;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 31);
            label1.TabIndex = 29;
            label1.Text = "Создание заказа";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(15, 115);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 30;
            label2.Text = "Клиент:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(15, 156);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 32;
            label3.Text = "Транспорт:";
            // 
            // comboBoxTransport
            // 
            comboBoxTransport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxTransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTransport.FormattingEnabled = true;
            comboBoxTransport.Location = new Point(197, 152);
            comboBoxTransport.Margin = new Padding(3, 4, 3, 4);
            comboBoxTransport.Name = "comboBoxTransport";
            comboBoxTransport.Size = new Size(155, 29);
            comboBoxTransport.TabIndex = 31;
            comboBoxTransport.SelectedIndexChanged += comboBoxTransport_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(15, 197);
            label4.Name = "label4";
            label4.Size = new Size(177, 23);
            label4.TabIndex = 34;
            label4.Text = "Регион отправления:";
            // 
            // comboBoxRegionFrom
            // 
            comboBoxRegionFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxRegionFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegionFrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRegionFrom.FormattingEnabled = true;
            comboBoxRegionFrom.Location = new Point(197, 193);
            comboBoxRegionFrom.Margin = new Padding(3, 4, 3, 4);
            comboBoxRegionFrom.Name = "comboBoxRegionFrom";
            comboBoxRegionFrom.Size = new Size(281, 29);
            comboBoxRegionFrom.TabIndex = 33;
            comboBoxRegionFrom.SelectedIndexChanged += comboBoxRegionFrom_SelectedIndexChanged;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownWeight.DecimalPlaces = 1;
            numericUpDownWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownWeight.Location = new Point(196, 313);
            numericUpDownWeight.Margin = new Padding(3, 4, 3, 4);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(568, 29);
            numericUpDownWeight.TabIndex = 35;
            numericUpDownWeight.ValueChanged += calculateCost;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(16, 315);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 36;
            label5.Text = "Вес груза (кг):";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Right;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(470, 445);
            buttonCancel.Margin = new Padding(5, 4, 5, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(143, 40);
            buttonCancel.TabIndex = 38;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Anchor = AnchorStyles.Right;
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(622, 445);
            buttonAccept.Margin = new Padding(5, 4, 5, 4);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(143, 40);
            buttonAccept.TabIndex = 37;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCost.Location = new Point(12, 448);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(170, 29);
            labelCost.TabIndex = 39;
            labelCost.Text = "10000 рублей";
            // 
            // labelDistance
            // 
            labelDistance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDistance.AutoSize = true;
            labelDistance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDistance.Location = new Point(16, 279);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(139, 23);
            labelDistance.TabIndex = 41;
            labelDistance.Text = "Расстояние (км):";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Location = new Point(198, 350);
            comboBoxCurrency.Margin = new Padding(3, 4, 3, 4);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(565, 29);
            comboBoxCurrency.TabIndex = 42;
            comboBoxCurrency.SelectedIndexChanged += calculateCost;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(15, 353);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 43;
            label7.Text = "Валюта:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(358, 156);
            label8.Name = "label8";
            label8.Size = new Size(168, 23);
            label8.TabIndex = 45;
            label8.Text = "Подвид транспорта:";
            // 
            // comboBoxSubtransport
            // 
            comboBoxSubtransport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSubtransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubtransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxSubtransport.FormattingEnabled = true;
            comboBoxSubtransport.Location = new Point(532, 152);
            comboBoxSubtransport.Margin = new Padding(3, 4, 3, 4);
            comboBoxSubtransport.Name = "comboBoxSubtransport";
            comboBoxSubtransport.Size = new Size(232, 29);
            comboBoxSubtransport.TabIndex = 44;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(484, 197);
            label9.Name = "label9";
            label9.Size = new Size(61, 23);
            label9.TabIndex = 47;
            label9.Text = "Город:";
            // 
            // comboBoxCityFrom
            // 
            comboBoxCityFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCityFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCityFrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCityFrom.FormattingEnabled = true;
            comboBoxCityFrom.Location = new Point(551, 193);
            comboBoxCityFrom.Margin = new Padding(3, 4, 3, 4);
            comboBoxCityFrom.Name = "comboBoxCityFrom";
            comboBoxCityFrom.Size = new Size(211, 29);
            comboBoxCityFrom.TabIndex = 46;
            comboBoxCityFrom.SelectedIndexChanged += comboBoxCityFrom_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(485, 239);
            label10.Name = "label10";
            label10.Size = new Size(61, 23);
            label10.TabIndex = 51;
            label10.Text = "Город:";
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
            comboBoxCityTo.TabIndex = 50;
            comboBoxCityTo.SelectedIndexChanged += comboBoxCityTo_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(16, 239);
            label11.Name = "label11";
            label11.Size = new Size(169, 23);
            label11.TabIndex = 49;
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
            comboBoxRegionTo.TabIndex = 48;
            comboBoxRegionTo.SelectedIndexChanged += comboBoxRegionTo_SelectedIndexChanged;
            // 
            // FormAddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 498);
            Controls.Add(label10);
            Controls.Add(comboBoxCityTo);
            Controls.Add(label11);
            Controls.Add(comboBoxRegionTo);
            Controls.Add(label9);
            Controls.Add(comboBoxCityFrom);
            Controls.Add(label8);
            Controls.Add(comboBoxSubtransport);
            Controls.Add(label7);
            Controls.Add(comboBoxCurrency);
            Controls.Add(labelDistance);
            Controls.Add(labelCost);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            Controls.Add(label5);
            Controls.Add(numericUpDownWeight);
            Controls.Add(label4);
            Controls.Add(comboBoxRegionFrom);
            Controls.Add(label3);
            Controls.Add(comboBoxTransport);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxClient);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddOrder";
            Text = "Order add";
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClient;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxTransport;
        private Label label4;
        private ComboBox comboBoxRegionFrom;
        private NumericUpDown numericUpDownWeight;
        private Label label5;
        private Button buttonCancel;
        private Button buttonAccept;
        private Label labelCost;
        private Label labelDistance;
        private ComboBox comboBoxCurrency;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxSubtransport;
        private Label label9;
        private ComboBox comboBoxCityFrom;
        private Label label10;
        private ComboBox comboBoxCityTo;
        private Label label11;
        private ComboBox comboBoxRegionTo;
    }
}