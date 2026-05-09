namespace MultiTransportDelivery
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            listViewOrders = new ListView();
            columnHeaderClient = new ColumnHeader();
            columnHeaderTransport = new ColumnHeader();
            columnHeaderDirection = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderWeight = new ColumnHeader();
            columnHeaderCost = new ColumnHeader();
            columnHeaderStatus = new ColumnHeader();
            buttonAddOrder = new Button();
            buttonEditOrder = new Button();
            buttonDelOrder = new Button();
            labelEmptyOrders = new Label();
            buttonClients = new Button();
            buttonTransport = new Button();
            buttonDirections = new Button();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { справкаToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(149, 22);
            AboutToolStripMenuItem.Text = "О программе";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // listViewOrders
            // 
            listViewOrders.Alignment = ListViewAlignment.Left;
            listViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { columnHeaderClient, columnHeaderTransport, columnHeaderDirection, columnHeaderDate, columnHeaderWeight, columnHeaderCost, columnHeaderStatus });
            listViewOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listViewOrders.FullRowSelect = true;
            listViewOrders.Location = new Point(183, 24);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(605, 414);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            // 
            // columnHeaderClient
            // 
            columnHeaderClient.Text = "Клиент";
            // 
            // columnHeaderTransport
            // 
            columnHeaderTransport.Text = "Транспорт";
            // 
            // columnHeaderDirection
            // 
            columnHeaderDirection.Text = "Направление";
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Дата";
            // 
            // columnHeaderWeight
            // 
            columnHeaderWeight.Text = "Вес груза";
            // 
            // columnHeaderCost
            // 
            columnHeaderCost.Text = "Стоимость";
            // 
            // columnHeaderStatus
            // 
            columnHeaderStatus.Text = "Статус";
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddOrder.Location = new Point(12, 27);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(165, 27);
            buttonAddOrder.TabIndex = 2;
            buttonAddOrder.Text = "Создать заказ";
            buttonAddOrder.UseVisualStyleBackColor = true;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditOrder.Location = new Point(12, 60);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(165, 27);
            buttonEditOrder.TabIndex = 3;
            buttonEditOrder.Text = "Редактировать заказ";
            buttonEditOrder.UseVisualStyleBackColor = true;
            // 
            // buttonDelOrder
            // 
            buttonDelOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelOrder.Location = new Point(12, 93);
            buttonDelOrder.Name = "buttonDelOrder";
            buttonDelOrder.Size = new Size(165, 27);
            buttonDelOrder.TabIndex = 4;
            buttonDelOrder.Text = "Удалить заказ";
            buttonDelOrder.UseVisualStyleBackColor = true;
            // 
            // labelEmptyOrders
            // 
            labelEmptyOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmptyOrders.AutoSize = true;
            labelEmptyOrders.Location = new Point(448, 230);
            labelEmptyOrders.Name = "labelEmptyOrders";
            labelEmptyOrders.Size = new Size(86, 15);
            labelEmptyOrders.TabIndex = 5;
            labelEmptyOrders.Text = "Таблица пуста";
            // 
            // buttonClients
            // 
            buttonClients.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClients.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClients.Location = new Point(12, 411);
            buttonClients.Name = "buttonClients";
            buttonClients.Size = new Size(165, 27);
            buttonClients.TabIndex = 6;
            buttonClients.Text = "Клиенты";
            buttonClients.UseVisualStyleBackColor = true;
            buttonClients.Click += buttonClients_Click;
            // 
            // buttonTransport
            // 
            buttonTransport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTransport.Location = new Point(12, 378);
            buttonTransport.Name = "buttonTransport";
            buttonTransport.Size = new Size(165, 27);
            buttonTransport.TabIndex = 7;
            buttonTransport.Text = "Транспорт";
            buttonTransport.UseVisualStyleBackColor = true;
            // 
            // buttonDirections
            // 
            buttonDirections.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDirections.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDirections.Location = new Point(12, 345);
            buttonDirections.Name = "buttonDirections";
            buttonDirections.Size = new Size(165, 27);
            buttonDirections.TabIndex = 8;
            buttonDirections.Text = "Направления";
            buttonDirections.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDirections);
            Controls.Add(buttonTransport);
            Controls.Add(buttonClients);
            Controls.Add(labelEmptyOrders);
            Controls.Add(buttonDelOrder);
            Controls.Add(buttonEditOrder);
            Controls.Add(buttonAddOrder);
            Controls.Add(listViewOrders);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multi Transport Delivery";
            Load += FormMain_Load;
            ResizeEnd += FormMain_ResizeEnd;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ListView listViewOrders;
        private Button buttonAddOrder;
        private Button buttonEditOrder;
        private Button buttonDelOrder;
        private ColumnHeader columnHeaderClient;
        private ColumnHeader columnHeaderTransport;
        private ColumnHeader columnHeaderDirection;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderWeight;
        private ColumnHeader columnHeaderCost;
        private ColumnHeader columnHeaderStatus;
        private Label labelEmptyOrders;
        private Button buttonClients;
        private Button buttonTransport;
        private Button buttonDirections;
    }
}
