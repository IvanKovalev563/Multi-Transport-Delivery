namespace MultiTransportDelivery
{
    partial class FormClients
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
            listViewClients = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderAddress = new ColumnHeader();
            columnHeaderPersAccount = new ColumnHeader();
            columnHeaderPhone = new ColumnHeader();
            buttonAddClient = new Button();
            buttonEditClient = new Button();
            buttonDelClient = new Button();
            labelEmptyClients = new Label();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderAddress, columnHeaderPersAccount, columnHeaderPhone });
            listViewClients.FullRowSelect = true;
            listViewClients.Location = new Point(12, 12);
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(776, 393);
            listViewClients.TabIndex = 0;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            listViewClients.SelectedIndexChanged += listViewClients_SelectedIndexChanged;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Клиент";
            // 
            // columnHeaderAddress
            // 
            columnHeaderAddress.Text = "Адрес";
            // 
            // columnHeaderPersAccount
            // 
            columnHeaderPersAccount.Text = "Лицевой счет";
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.Text = "Номер телефона";
            // 
            // buttonAddClient
            // 
            buttonAddClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddClient.Location = new Point(623, 411);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(165, 27);
            buttonAddClient.TabIndex = 5;
            buttonAddClient.Text = "Добавить клиента";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonEditClient
            // 
            buttonEditClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEditClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditClient.Location = new Point(452, 411);
            buttonEditClient.Name = "buttonEditClient";
            buttonEditClient.Size = new Size(165, 27);
            buttonEditClient.TabIndex = 6;
            buttonEditClient.Text = "Редактировать клиента";
            buttonEditClient.UseVisualStyleBackColor = true;
            buttonEditClient.Click += buttonEditClient_Click;
            // 
            // buttonDelClient
            // 
            buttonDelClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelClient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelClient.Location = new Point(281, 411);
            buttonDelClient.Name = "buttonDelClient";
            buttonDelClient.Size = new Size(165, 27);
            buttonDelClient.TabIndex = 7;
            buttonDelClient.Text = "Удалить клиента";
            buttonDelClient.UseVisualStyleBackColor = true;
            buttonDelClient.Click += buttonDelClient_Click;
            // 
            // labelEmptyClients
            // 
            labelEmptyClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmptyClients.AutoSize = true;
            labelEmptyClients.Location = new Point(357, 218);
            labelEmptyClients.Name = "labelEmptyClients";
            labelEmptyClients.Size = new Size(86, 15);
            labelEmptyClients.TabIndex = 8;
            labelEmptyClients.Text = "Таблица пуста";
            // 
            // FormClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEmptyClients);
            Controls.Add(buttonDelClient);
            Controls.Add(buttonEditClient);
            Controls.Add(buttonAddClient);
            Controls.Add(listViewClients);
            Name = "FormClients";
            Text = "Clients";
            ResizeEnd += FormClients_ResizeEnd;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewClients;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderAddress;
        private ColumnHeader columnHeaderPersAccount;
        private ColumnHeader columnHeaderPhone;
        private Button buttonAddClient;
        private Button buttonEditClient;
        private Button buttonDelClient;
        private Label labelEmptyClients;
    }
}