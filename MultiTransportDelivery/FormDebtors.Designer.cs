namespace MultiTransportDelivery
{
    partial class FormDebtors
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
            listViewDebtors = new ListView();
            columnHeaderDebtor = new ColumnHeader();
            columnHeaderDebtAmount = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 25);
            label1.TabIndex = 45;
            label1.Text = "Сведения о должниках";
            // 
            // listViewDebtors
            // 
            listViewDebtors.Columns.AddRange(new ColumnHeader[] { columnHeaderDebtor, columnHeaderDebtAmount });
            listViewDebtors.FullRowSelect = true;
            listViewDebtors.Location = new Point(12, 58);
            listViewDebtors.Name = "listViewDebtors";
            listViewDebtors.Size = new Size(440, 191);
            listViewDebtors.TabIndex = 46;
            listViewDebtors.UseCompatibleStateImageBehavior = false;
            listViewDebtors.View = View.Details;
            // 
            // columnHeaderDebtor
            // 
            columnHeaderDebtor.Text = "Должник";
            columnHeaderDebtor.Width = 220;
            // 
            // columnHeaderDebtAmount
            // 
            columnHeaderDebtAmount.Text = "Долг";
            columnHeaderDebtAmount.Width = 215;
            // 
            // FormDebtors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 261);
            Controls.Add(listViewDebtors);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormDebtors";
            Text = "Debtors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewDebtors;
        private ColumnHeader columnHeaderDebtor;
        private ColumnHeader columnHeaderDebtAmount;
    }
}