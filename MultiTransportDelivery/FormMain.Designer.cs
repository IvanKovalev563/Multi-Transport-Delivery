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
            buttonDirections = new Button();
            buttonPayOrder = new Button();
            dateTimePickerSearch = new DateTimePicker();
            checkBoxDateSearch = new CheckBox();
            comboBoxDirectionSearch = new ComboBox();
            label1 = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { заказыToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // заказыToolStripMenuItem
            // 
            заказыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сведенияОЗаказахToolStripMenuItem, сведенияОToolStripMenuItem });
            заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            заказыToolStripMenuItem.Size = new Size(58, 20);
            заказыToolStripMenuItem.Text = "Заказы";
            // 
            // сведенияОЗаказахToolStripMenuItem
            // 
            сведенияОЗаказахToolStripMenuItem.Name = "сведенияОЗаказахToolStripMenuItem";
            сведенияОЗаказахToolStripMenuItem.Size = new Size(200, 22);
            сведенияОЗаказахToolStripMenuItem.Text = "Сведения о заказах";
            сведенияОЗаказахToolStripMenuItem.Click += сведенияОЗаказахToolStripMenuItem_Click;
            // 
            // сведенияОToolStripMenuItem
            // 
            сведенияОToolStripMenuItem.Name = "сведенияОToolStripMenuItem";
            сведенияОToolStripMenuItem.Size = new Size(200, 22);
            сведенияОToolStripMenuItem.Text = "Сведения о должниках";
            сведенияОToolStripMenuItem.Click += сведенияОToolStripMenuItem_Click;
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
            listViewOrders.Columns.AddRange(new ColumnHeader[] { columnHeaderClient, columnHeaderTransport, columnHeaderDirection, columnHeaderDistance, columnHeaderDate, columnHeaderWeight, columnHeaderCost, columnHeaderPayAmount, columnHeaderStatus });
            listViewOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listViewOrders.FullRowSelect = true;
            listViewOrders.Location = new Point(183, 24);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(605, 414);
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
            buttonAddOrder.Location = new Point(12, 27);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(165, 27);
            buttonAddOrder.TabIndex = 2;
            buttonAddOrder.Text = "Создать заказ";
            buttonAddOrder.UseVisualStyleBackColor = true;
            buttonAddOrder.Click += buttonAddOrder_Click;
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
            buttonEditOrder.Click += buttonEditOrder_Click;
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
            buttonDelOrder.Click += buttonDelOrder_Click;
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
            buttonTransport.Click += buttonTransport_Click;
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
            buttonDirections.Click += buttonDirections_Click;
            // 
            // buttonPayOrder
            // 
            buttonPayOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPayOrder.Location = new Point(12, 126);
            buttonPayOrder.Name = "buttonPayOrder";
            buttonPayOrder.Size = new Size(165, 27);
            buttonPayOrder.TabIndex = 9;
            buttonPayOrder.Text = "Оплатить заказ";
            buttonPayOrder.UseVisualStyleBackColor = true;
            buttonPayOrder.Click += buttonPayOrder_Click;
            // 
            // dateTimePickerSearch
            // 
            dateTimePickerSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerSearch.Location = new Point(12, 251);
            dateTimePickerSearch.Name = "dateTimePickerSearch";
            dateTimePickerSearch.Size = new Size(165, 25);
            dateTimePickerSearch.TabIndex = 10;
            dateTimePickerSearch.ValueChanged += dateTimePickerSearch_ValueChanged;
            // 
            // checkBoxDateSearch
            // 
            checkBoxDateSearch.AutoSize = true;
            checkBoxDateSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxDateSearch.Location = new Point(12, 224);
            checkBoxDateSearch.Name = "checkBoxDateSearch";
            checkBoxDateSearch.Size = new Size(112, 21);
            checkBoxDateSearch.TabIndex = 11;
            checkBoxDateSearch.Text = "Поиск до дате";
            checkBoxDateSearch.UseVisualStyleBackColor = true;
            checkBoxDateSearch.CheckedChanged += checkBoxDateSearch_CheckedChanged;
            // 
            // comboBoxDirectionSearch
            // 
            comboBoxDirectionSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxDirectionSearch.FormattingEnabled = true;
            comboBoxDirectionSearch.Location = new Point(12, 193);
            comboBoxDirectionSearch.Name = "comboBoxDirectionSearch";
            comboBoxDirectionSearch.Size = new Size(165, 25);
            comboBoxDirectionSearch.TabIndex = 12;
            comboBoxDirectionSearch.SelectedIndexChanged += comboBoxDirectionSearch_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 173);
            label1.Name = "label1";
            label1.Size = new Size(136, 17);
            label1.TabIndex = 13;
            label1.Text = "Направление поиска:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBoxDirectionSearch);
            Controls.Add(checkBoxDateSearch);
            Controls.Add(dateTimePickerSearch);
            Controls.Add(buttonPayOrder);
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
        private ColumnHeader columnHeaderDistance;
        private ToolStripMenuItem заказыToolStripMenuItem;
        private ToolStripMenuItem сведенияОЗаказахToolStripMenuItem;
        private Button buttonPayOrder;
        private ToolStripMenuItem сведенияОToolStripMenuItem;
        private ColumnHeader columnHeaderPayAmount;
        private DateTimePicker dateTimePickerSearch;
        private CheckBox checkBoxDateSearch;
        private ComboBox comboBoxDirectionSearch;
        private Label label1;
    }
}
