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
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).BeginInit();
            SuspendLayout();
            // 
            // comboBoxClient
            // 
            comboBoxClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(124, 83);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(363, 25);
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
            comboBoxTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTransport.FormattingEnabled = true;
            comboBoxTransport.Location = new Point(124, 114);
            comboBoxTransport.Name = "comboBoxTransport";
            comboBoxTransport.Size = new Size(363, 25);
            comboBoxTransport.TabIndex = 31;
            comboBoxTransport.SelectedIndexChanged += calculateCost;
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
            comboBoxDirection.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxDirection.FormattingEnabled = true;
            comboBoxDirection.Location = new Point(124, 145);
            comboBoxDirection.Name = "comboBoxDirection";
            comboBoxDirection.Size = new Size(363, 25);
            comboBoxDirection.TabIndex = 33;
            comboBoxDirection.SelectedIndexChanged += calculateCost;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.DecimalPlaces = 1;
            numericUpDownWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownWeight.Location = new Point(124, 176);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(363, 25);
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
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(228, 283);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 30);
            buttonCancel.TabIndex = 38;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click_1;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(361, 283);
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
            numericUpDownDistance.DecimalPlaces = 1;
            numericUpDownDistance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownDistance.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownDistance.Location = new Point(124, 207);
            numericUpDownDistance.Maximum = new decimal(new int[] { 40075, 0, 0, 0 });
            numericUpDownDistance.Name = "numericUpDownDistance";
            numericUpDownDistance.Size = new Size(363, 25);
            numericUpDownDistance.TabIndex = 40;
            numericUpDownDistance.ValueChanged += calculateCost;
            // 
            // FormAddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 325);
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
            Text = "FormAddOrder";
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
    }
}