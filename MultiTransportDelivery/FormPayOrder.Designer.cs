namespace MultiTransportDelivery
{
    partial class FormPayOrder
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
            label1 = new Label();
            buttonCancel = new Button();
            buttonAccept = new Button();
            numericUpDownPay = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 46;
            label1.Text = "Оплата заказа";
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(115, 155);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 30);
            buttonCancel.TabIndex = 54;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(248, 155);
            buttonAccept.Margin = new Padding(4, 3, 4, 3);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(125, 30);
            buttonAccept.TabIndex = 53;
            buttonAccept.Text = "Подтвердить";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // numericUpDownPay
            // 
            numericUpDownPay.DecimalPlaces = 2;
            numericUpDownPay.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownPay.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPay.Location = new Point(131, 60);
            numericUpDownPay.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPay.Name = "numericUpDownPay";
            numericUpDownPay.Size = new Size(242, 25);
            numericUpDownPay.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(13, 62);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 56;
            label2.Text = "Оплата на сумму:";
            // 
            // FormPayOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 197);
            Controls.Add(label2);
            Controls.Add(numericUpDownPay);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormPayOrder";
            Text = "Order payment";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCancel;
        private Button buttonAccept;
        private NumericUpDown numericUpDownPay;
        private Label label2;
    }
}