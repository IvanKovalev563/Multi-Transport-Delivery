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
            заказыToolStripMenuItem = new ToolStripMenuItem();
            сведенияОЗаказахToolStripMenuItem = new ToolStripMenuItem();
            сведенияОToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            listViewOrders = new ListView();
            columnHeaderClient = new ColumnHeader();
            columnHeaderTransport = new ColumnHeader();
            columnHeaderDirection = new ColumnHeader();
            columnHeaderDistance = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderWeight = new ColumnHeader();
            columnHeaderCost = new ColumnHeader();
            columnHeaderPayAmount = new ColumnHeader();
            columnHeaderStatus = new ColumnHeader();
            buttonAddOrder = new Button();
            buttonEditOrder = new Button();
            buttonDelOrder = new Button();
            labelEmptyOrders = new Label();
            buttonClients = new Button();
            buttonTransport = new Button();
            buttonPayOrder = new Button();
            dateTimePickerSearch = new DateTimePicker();
            checkBoxDateSearch = new CheckBox();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { заказыToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(914, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // заказыToolStripMenuItem
            // 
            заказыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сведенияОЗаказахToolStripMenuItem, сведенияОToolStripMenuItem });
            заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            заказыToolStripMenuItem.Size = new Size(72, 24);
            заказыToolStripMenuItem.Text = "Заказы";
            // 
            // сведенияОЗаказахToolStripMenuItem
            // 
            сведенияОЗаказахToolStripMenuItem.Name = "сведенияОЗаказахToolStripMenuItem";
            сведенияОЗаказахToolStripMenuItem.Size = new Size(252, 26);
            сведенияОЗаказахToolStripMenuItem.Text = "Сведения о заказах";
            сведенияОЗаказахToolStripMenuItem.Click += сведенияОЗаказахToolStripMenuItem_Click;
            // 
            // сведенияОToolStripMenuItem
            // 
            сведенияОToolStripMenuItem.Name = "сведенияОToolStripMenuItem";
            сведенияОToolStripMenuItem.Size = new Size(252, 26);
            сведенияОToolStripMenuItem.Text = "Сведения о должниках";
            сведенияОToolStripMenuItem.Click += сведенияОToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(187, 26);
            AboutToolStripMenuItem.Text = "О программе";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // listViewOrders
            // 
            listViewOrders.Alignment = ListViewAlignment.Left;
            listViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { columnHeaderClient, columnHeaderTransport, columnHeaderDirection, columnHeaderDistance, columnHeaderDate, columnHeaderWeight, columnHeaderCost, columnHeaderPayAmount, columnHeaderStatus });
            listViewOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listViewOrders.FullRowSelect = true;
            listViewOrders.Location = new Point(209, 32);
            listViewOrders.Margin = new Padding(3, 4, 3, 4);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(691, 551);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.SelectedIndexChanged += listViewOrders_SelectedIndexChanged;
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
            // columnHeaderDistance
            // 
            columnHeaderDistance.Text = "Растояние";
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
            columnHeaderCost.Text = "Стоимость (руб.)";
            // 
            // columnHeaderPayAmount
            // 
            columnHeaderPayAmount.Text = "Оплачено (руб.)";
            // 
            // columnHeaderStatus
            // 
            columnHeaderStatus.Text = "Статус";
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddOrder.Location = new Point(14, 36);
            buttonAddOrder.Margin = new Padding(3, 4, 3, 4);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(189, 36);
            buttonAddOrder.TabIndex = 2;
            buttonAddOrder.Text = "Создать заказ";
            buttonAddOrder.UseVisualStyleBackColor = true;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditOrder.Location = new Point(14, 80);
            buttonEditOrder.Margin = new Padding(3, 4, 3, 4);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(189, 36);
            buttonEditOrder.TabIndex = 3;
            buttonEditOrder.Text = "Редактировать заказ";
            buttonEditOrder.UseVisualStyleBackColor = true;
            buttonEditOrder.Click += buttonEditOrder_Click;
            // 
            // buttonDelOrder
            // 
            buttonDelOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelOrder.Location = new Point(14, 124);
            buttonDelOrder.Margin = new Padding(3, 4, 3, 4);
            buttonDelOrder.Name = "buttonDelOrder";
            buttonDelOrder.Size = new Size(189, 36);
            buttonDelOrder.TabIndex = 4;
            buttonDelOrder.Text = "Удалить заказ";
            buttonDelOrder.UseVisualStyleBackColor = true;
            buttonDelOrder.Click += buttonDelOrder_Click;
            // 
            // labelEmptyOrders
            // 
            labelEmptyOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmptyOrders.AutoSize = true;
            labelEmptyOrders.Location = new Point(512, 307);
            labelEmptyOrders.Name = "labelEmptyOrders";
            labelEmptyOrders.Size = new Size(109, 20);
            labelEmptyOrders.TabIndex = 5;
            labelEmptyOrders.Text = "Таблица пуста";
            // 
            // buttonClients
            // 
            buttonClients.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClients.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClients.Location = new Point(14, 548);
            buttonClients.Margin = new Padding(3, 4, 3, 4);
            buttonClients.Name = "buttonClients";
            buttonClients.Size = new Size(189, 36);
            buttonClients.TabIndex = 6;
            buttonClients.Text = "Клиенты";
            buttonClients.UseVisualStyleBackColor = true;
            buttonClients.Click += buttonClients_Click;
            // 
            // buttonTransport
            // 
            buttonTransport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTransport.Location = new Point(14, 504);
            buttonTransport.Margin = new Padding(3, 4, 3, 4);
            buttonTransport.Name = "buttonTransport";
            buttonTransport.Size = new Size(189, 36);
            buttonTransport.TabIndex = 7;
            buttonTransport.Text = "Транспорт";
            buttonTransport.UseVisualStyleBackColor = true;
            buttonTransport.Click += buttonTransport_Click;
            // 
            // buttonPayOrder
            // 
            buttonPayOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPayOrder.Location = new Point(14, 168);
            buttonPayOrder.Margin = new Padding(3, 4, 3, 4);
            buttonPayOrder.Name = "buttonPayOrder";
            buttonPayOrder.Size = new Size(189, 36);
            buttonPayOrder.TabIndex = 9;
            buttonPayOrder.Text = "Оплатить заказ";
            buttonPayOrder.UseVisualStyleBackColor = true;
            buttonPayOrder.Click += buttonPayOrder_Click;
            // 
            // dateTimePickerSearch
            // 
            dateTimePickerSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerSearch.Location = new Point(14, 335);
            dateTimePickerSearch.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerSearch.Name = "dateTimePickerSearch";
            dateTimePickerSearch.Size = new Size(188, 29);
            dateTimePickerSearch.TabIndex = 10;
            dateTimePickerSearch.ValueChanged += dateTimePickerSearch_ValueChanged;
            // 
            // checkBoxDateSearch
            // 
            checkBoxDateSearch.AutoSize = true;
            checkBoxDateSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxDateSearch.Location = new Point(14, 299);
            checkBoxDateSearch.Margin = new Padding(3, 4, 3, 4);
            checkBoxDateSearch.Name = "checkBoxDateSearch";
            checkBoxDateSearch.Size = new Size(143, 27);
            checkBoxDateSearch.TabIndex = 11;
            checkBoxDateSearch.Text = "Поиск до дате";
            checkBoxDateSearch.UseVisualStyleBackColor = true;
            checkBoxDateSearch.CheckedChanged += checkBoxDateSearch_CheckedChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(checkBoxDateSearch);
            Controls.Add(dateTimePickerSearch);
            Controls.Add(buttonPayOrder);
            Controls.Add(buttonTransport);
            Controls.Add(buttonClients);
            Controls.Add(labelEmptyOrders);
            Controls.Add(buttonDelOrder);
            Controls.Add(buttonEditOrder);
            Controls.Add(buttonAddOrder);
            Controls.Add(listViewOrders);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multi Transport Delivery";
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
        private ColumnHeader columnHeaderDistance;
        private ToolStripMenuItem заказыToolStripMenuItem;
        private ToolStripMenuItem сведенияОЗаказахToolStripMenuItem;
        private Button buttonPayOrder;
        private ToolStripMenuItem сведенияОToolStripMenuItem;
        private ColumnHeader columnHeaderPayAmount;
        private DateTimePicker dateTimePickerSearch;
        private CheckBox checkBoxDateSearch;
    }
}
