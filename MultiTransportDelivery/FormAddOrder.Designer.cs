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
            comboBoxDirection = new ComboBox();
            numericUpDownWeight = new NumericUpDown();
            label5 = new Label();
            buttonCancel = new Button();
            buttonAccept = new Button();
            labelCost = new Label();
            label6 = new Label();
            numericUpDownDistance = new NumericUpDown();
            comboBoxCurrency = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBoxSubtransport = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).BeginInit();
            SuspendLayout();
            // 
            // comboBoxClient
            // 
            comboBoxClient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(124, 83);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(449, 25);
            comboBoxClient.TabIndex = 0;
            comboBoxClient.SelectedIndexChanged += calculateCost;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 29;
            label1.Text = "Создание заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(13, 86);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 30;
            label2.Text = "Клиент:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(13, 117);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 32;
            label3.Text = "Транспорт:";
            // 
            // comboBoxTransport
            // 
            comboBoxTransport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTransport.FormattingEnabled = true;
            comboBoxTransport.Location = new Point(124, 114);
            comboBoxTransport.Name = "comboBoxTransport";
            comboBoxTransport.Size = new Size(183, 25);
            comboBoxTransport.TabIndex = 31;
            comboBoxTransport.SelectedIndexChanged += comboBoxTransport_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(13, 148);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 34;
            label4.Text = "Направление:";
            // 
            // comboBoxDirection
            // 
            comboBoxDirection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDirection.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxDirection.FormattingEnabled = true;
            comboBoxDirection.Location = new Point(124, 145);
            comboBoxDirection.Name = "comboBoxDirection";
            comboBoxDirection.Size = new Size(449, 25);
            comboBoxDirection.TabIndex = 33;
            comboBoxDirection.SelectedIndexChanged += calculateCost;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownWeight.DecimalPlaces = 1;
            numericUpDownWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownWeight.Location = new Point(124, 176);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(449, 25);
            numericUpDownWeight.TabIndex = 35;
            numericUpDownWeight.ValueChanged += calculateCost;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(13, 178);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 36;
            label5.Text = "Вес груза (кг):";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Right;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(314, 283);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 30);
            buttonCancel.TabIndex = 38;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Anchor = AnchorStyles.Right;
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(447, 283);
            buttonAccept.Margin = new Padding(4, 3, 4, 3);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(125, 30);
            buttonAccept.TabIndex = 37;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCost.Location = new Point(13, 286);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(140, 22);
            labelCost.TabIndex = 39;
            labelCost.Text = "10000 рублей";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(13, 209);
            label6.Name = "label6";
            label6.Size = new Size(105, 17);
            label6.TabIndex = 41;
            label6.Text = "Расстояние (км):";
            // 
            // numericUpDownDistance
            // 
            numericUpDownDistance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownDistance.DecimalPlaces = 1;
            numericUpDownDistance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownDistance.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownDistance.Location = new Point(124, 207);
            numericUpDownDistance.Maximum = new decimal(new int[] { 40075, 0, 0, 0 });
            numericUpDownDistance.Name = "numericUpDownDistance";
            numericUpDownDistance.Size = new Size(449, 25);
            numericUpDownDistance.TabIndex = 40;
            numericUpDownDistance.ValueChanged += calculateCost;
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Location = new Point(124, 238);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(448, 25);
            comboBoxCurrency.TabIndex = 42;
            comboBoxCurrency.SelectedIndexChanged += calculateCost;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(12, 241);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 43;
            label7.Text = "Валюта:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(313, 117);
            label8.Name = "label8";
            label8.Size = new Size(128, 17);
            label8.TabIndex = 45;
            label8.Text = "Подвид транспорта:";
            // 
            // comboBoxSubtransport
            // 
            comboBoxSubtransport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSubtransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubtransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxSubtransport.FormattingEnabled = true;
            comboBoxSubtransport.Location = new Point(447, 114);
            comboBoxSubtransport.Name = "comboBoxSubtransport";
            comboBoxSubtransport.Size = new Size(126, 25);
            comboBoxSubtransport.TabIndex = 44;
            // 
            // FormAddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 325);
            Controls.Add(label8);
            Controls.Add(comboBoxSubtransport);
            Controls.Add(label7);
            Controls.Add(comboBoxCurrency);
            Controls.Add(label6);
            Controls.Add(numericUpDownDistance);
            Controls.Add(labelCost);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            Controls.Add(label5);
            Controls.Add(numericUpDownWeight);
            Controls.Add(label4);
            Controls.Add(comboBoxDirection);
            Controls.Add(label3);
            Controls.Add(comboBoxTransport);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxClient);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormAddOrder";
            Text = "Order add";
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).EndInit();
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
        private ComboBox comboBoxDirection;
        private NumericUpDown numericUpDownWeight;
        private Label label5;
        private Button buttonCancel;
        private Button buttonAccept;
        private Label labelCost;
        private Label label6;
        private NumericUpDown numericUpDownDistance;
        private ComboBox comboBoxCurrency;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxSubtransport;
    }
}