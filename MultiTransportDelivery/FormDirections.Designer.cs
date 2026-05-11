namespace MultiTransportDelivery
{
    partial class FormDirections
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
            labelEmptyDirections = new Label();
            buttonDelDirection = new Button();
            buttonEditDirection = new Button();
            buttonAddDirection = new Button();
            listViewDirections = new ListView();
            columnHeaderName = new ColumnHeader();
            SuspendLayout();
            // 
            // labelEmptyDirections
            // 
            labelEmptyDirections.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmptyDirections.AutoSize = true;
            labelEmptyDirections.Location = new Point(259, 143);
            labelEmptyDirections.Name = "labelEmptyDirections";
            labelEmptyDirections.Size = new Size(86, 15);
            labelEmptyDirections.TabIndex = 16;
            labelEmptyDirections.Text = "Таблица пуста";
            // 
            // buttonDelDirection
            // 
            buttonDelDirection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelDirection.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelDirection.Location = new Point(12, 262);
            buttonDelDirection.Name = "buttonDelDirection";
            buttonDelDirection.Size = new Size(189, 27);
            buttonDelDirection.TabIndex = 15;
            buttonDelDirection.Text = "Удалить направление";
            buttonDelDirection.UseVisualStyleBackColor = true;
            buttonDelDirection.Click += buttonDelDirection_Click;
            // 
            // buttonEditDirection
            // 
            buttonEditDirection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEditDirection.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditDirection.Location = new Point(207, 262);
            buttonEditDirection.Name = "buttonEditDirection";
            buttonEditDirection.Size = new Size(189, 27);
            buttonEditDirection.TabIndex = 14;
            buttonEditDirection.Text = "Редактировать направление";
            buttonEditDirection.UseVisualStyleBackColor = true;
            buttonEditDirection.Click += buttonEditDirection_Click;
            // 
            // buttonAddDirection
            // 
            buttonAddDirection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddDirection.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddDirection.Location = new Point(402, 262);
            buttonAddDirection.Name = "buttonAddDirection";
            buttonAddDirection.Size = new Size(189, 27);
            buttonAddDirection.TabIndex = 13;
            buttonAddDirection.Text = "Добавить направление";
            buttonAddDirection.UseVisualStyleBackColor = true;
            buttonAddDirection.Click += buttonAddDirection_Click;
            // 
            // listViewDirections
            // 
            listViewDirections.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewDirections.Columns.AddRange(new ColumnHeader[] { columnHeaderName });
            listViewDirections.FullRowSelect = true;
            listViewDirections.Location = new Point(13, 12);
            listViewDirections.Name = "listViewDirections";
            listViewDirections.Size = new Size(578, 244);
            listViewDirections.TabIndex = 12;
            listViewDirections.UseCompatibleStateImageBehavior = false;
            listViewDirections.View = View.Details;
            listViewDirections.SelectedIndexChanged += listViewDirections_SelectedIndexChanged;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Направление";
            // 
            // FormDirections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 301);
            Controls.Add(labelEmptyDirections);
            Controls.Add(buttonDelDirection);
            Controls.Add(buttonEditDirection);
            Controls.Add(buttonAddDirection);
            Controls.Add(listViewDirections);
            Name = "FormDirections";
            Text = "Directions";
            ResizeEnd += FormDirections_ResizeEnd;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmptyDirections;
        private Button buttonDelDirection;
        private Button buttonEditDirection;
        private Button buttonAddDirection;
        private ListView listViewDirections;
        private ColumnHeader columnHeaderName;
    }
}