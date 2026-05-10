namespace MultiTransportDelivery
{
    partial class FormOrdersInfo
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
            labelActiveOrders = new Label();
            labelOrders = new Label();
            listViewNeededTransport = new ListView();
            columnHeaderTransport = new ColumnHeader();
            columnHeaderCount = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 44;
            label1.Text = "Сведения о заказах";
            // 
            // labelActiveOrders
            // 
            labelActiveOrders.AutoSize = true;
            labelActiveOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelActiveOrders.Location = new Point(13, 93);
            labelActiveOrders.Name = "labelActiveOrders";
            labelActiveOrders.Size = new Size(111, 17);
            labelActiveOrders.TabIndex = 45;
            labelActiveOrders.Text = "labelActiveOrders";
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOrders.Location = new Point(13, 63);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(111, 17);
            labelOrders.TabIndex = 46;
            labelOrders.Text = "labelActiveOrders";
            // 
            // listViewNeededTransport
            // 
            listViewNeededTransport.Columns.AddRange(new ColumnHeader[] { columnHeaderTransport, columnHeaderCount });
            listViewNeededTransport.Location = new Point(157, 63);
            listViewNeededTransport.Name = "listViewNeededTransport";
            listViewNeededTransport.Size = new Size(300, 159);
            listViewNeededTransport.TabIndex = 47;
            listViewNeededTransport.UseCompatibleStateImageBehavior = false;
            listViewNeededTransport.View = View.Details;
            // 
            // columnHeaderTransport
            // 
            columnHeaderTransport.Text = "Транспорт";
            columnHeaderTransport.Width = 150;
            // 
            // columnHeaderCount
            // 
            columnHeaderCount.Text = "Требуемое кол-во";
            columnHeaderCount.Width = 145;
            // 
            // FormOrdersInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 234);
            Controls.Add(listViewNeededTransport);
            Controls.Add(labelOrders);
            Controls.Add(labelActiveOrders);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormOrdersInfo";
            Text = "FormOrdersInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelActiveOrders;
        private Label labelOrders;
        private ListView listViewNeededTransport;
        private ColumnHeader columnHeaderTransport;
        private ColumnHeader columnHeaderCount;
    }
}