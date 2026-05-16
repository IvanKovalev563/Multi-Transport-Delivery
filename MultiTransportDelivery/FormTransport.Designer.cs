namespace MultiTransportDelivery
{
    partial class FormTransport
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
            listViewTransport = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderCost = new ColumnHeader();
            buttonDelTransport = new Button();
            buttonEditTransport = new Button();
            buttonAddTransport = new Button();
            labelEmptyTransport = new Label();
            textBoxSearch = new TextBox();
            SuspendLayout();
            // 
            // listViewTransport
            // 
            listViewTransport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewTransport.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderCost });
            listViewTransport.FullRowSelect = true;
            listViewTransport.Location = new Point(12, 12);
            listViewTransport.Name = "listViewTransport";
            listViewTransport.Size = new Size(805, 244);
            listViewTransport.TabIndex = 0;
            listViewTransport.UseCompatibleStateImageBehavior = false;
            listViewTransport.View = View.Details;
            listViewTransport.SelectedIndexChanged += listViewTransport_SelectedIndexChanged;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Транспорт";
            // 
            // columnHeaderCost
            // 
            columnHeaderCost.Text = "Стоимость (1 км/тонна)";
            // 
            // buttonDelTransport
            // 
            buttonDelTransport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelTransport.Location = new Point(238, 262);
            buttonDelTransport.Name = "buttonDelTransport";
            buttonDelTransport.Size = new Size(189, 27);
            buttonDelTransport.TabIndex = 10;
            buttonDelTransport.Text = "Удалить транспорт";
            buttonDelTransport.UseVisualStyleBackColor = true;
            buttonDelTransport.Click += buttonDelTransport_Click;
            // 
            // buttonEditTransport
            // 
            buttonEditTransport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEditTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditTransport.Location = new Point(433, 262);
            buttonEditTransport.Name = "buttonEditTransport";
            buttonEditTransport.Size = new Size(189, 27);
            buttonEditTransport.TabIndex = 9;
            buttonEditTransport.Text = "Редактировать транспорт";
            buttonEditTransport.UseVisualStyleBackColor = true;
            buttonEditTransport.Click += buttonEditTransport_Click;
            // 
            // buttonAddTransport
            // 
            buttonAddTransport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddTransport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddTransport.Location = new Point(628, 262);
            buttonAddTransport.Name = "buttonAddTransport";
            buttonAddTransport.Size = new Size(189, 27);
            buttonAddTransport.TabIndex = 8;
            buttonAddTransport.Text = "Добавить транспорт";
            buttonAddTransport.UseVisualStyleBackColor = true;
            buttonAddTransport.Click += buttonAddTransport_Click;
            // 
            // labelEmptyTransport
            // 
            labelEmptyTransport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmptyTransport.AutoSize = true;
            labelEmptyTransport.Location = new Point(258, 143);
            labelEmptyTransport.Name = "labelEmptyTransport";
            labelEmptyTransport.Size = new Size(86, 15);
            labelEmptyTransport.TabIndex = 11;
            labelEmptyTransport.Text = "Таблица пуста";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch.Location = new Point(12, 264);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(220, 25);
            textBoxSearch.TabIndex = 18;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // FormTransport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 301);
            Controls.Add(textBoxSearch);
            Controls.Add(labelEmptyTransport);
            Controls.Add(buttonDelTransport);
            Controls.Add(buttonEditTransport);
            Controls.Add(buttonAddTransport);
            Controls.Add(listViewTransport);
            Name = "FormTransport";
            Text = "Transport";
            ResizeEnd += FormTransport_ResizeEnd;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewTransport;
        private Button buttonDelTransport;
        private Button buttonEditTransport;
        private Button buttonAddTransport;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderCost;
        private Label labelEmptyTransport;
        private TextBox textBoxSearch;
    }
}