namespace _101._30._30
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView231 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxReadN = new System.Windows.Forms.TextBox();
            this.textBoxReadS = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nroom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scook1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView231)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView231
            // 
            this.dataGridView231.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView231.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Nroom,
            this.Smax,
            this.Scook,
            this.Price});
            this.dataGridView231.Location = new System.Drawing.Point(13, 13);
            this.dataGridView231.Name = "dataGridView231";
            this.dataGridView231.RowTemplate.Height = 24;
            this.dataGridView231.Size = new System.Drawing.Size(542, 213);
            this.dataGridView231.TabIndex = 0;
            this.dataGridView231.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView231.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // Name
            // 
            this.Name.HeaderText = "Развание района";
            this.Name.Name = "Name";
            // 
            // Nroom
            // 
            this.Nroom.HeaderText = "Количество комнат";
            this.Nroom.Name = "Nroom";
            // 
            // Smax
            // 
            this.Smax.HeaderText = "Общая площадь";
            this.Smax.Name = "Smax";
            // 
            // Scook
            // 
            this.Scook.HeaderText = "Площадь кухни";
            this.Scook.Name = "Scook";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // textBoxReadN
            // 
            this.textBoxReadN.Location = new System.Drawing.Point(32, 233);
            this.textBoxReadN.Name = "textBoxReadN";
            this.textBoxReadN.Size = new System.Drawing.Size(100, 22);
            this.textBoxReadN.TabIndex = 1;
            // 
            // textBoxReadS
            // 
            this.textBoxReadS.Location = new System.Drawing.Point(32, 262);
            this.textBoxReadS.Name = "textBoxReadS";
            this.textBoxReadS.Size = new System.Drawing.Size(100, 22);
            this.textBoxReadS.TabIndex = 2;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(139, 233);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(98, 51);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Nroom1,
            this.Smax1,
            this.Scook1,
            this.Price1});
            this.dataGridView1.Location = new System.Drawing.Point(13, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 210);
            this.dataGridView1.TabIndex = 4;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Название района";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // Nroom1
            // 
            this.Nroom1.HeaderText = "Количество комнат";
            this.Nroom1.Name = "Nroom1";
            this.Nroom1.ReadOnly = true;
            // 
            // Smax1
            // 
            this.Smax1.HeaderText = "Общая площадь";
            this.Smax1.Name = "Smax1";
            this.Smax1.ReadOnly = true;
            // 
            // Scook1
            // 
            this.Scook1.HeaderText = "Площадь кухни";
            this.Scook1.Name = "Scook1";
            this.Scook1.ReadOnly = true;
            // 
            // Price1
            // 
            this.Price1.HeaderText = "Цена";
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxReadS);
            this.Controls.Add(this.textBoxReadN);
            this.Controls.Add(this.dataGridView231);
            //this.Name = "Form1";
            this.Text = "MyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView231)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView231;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Smax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.TextBox textBoxReadN;
        private System.Windows.Forms.TextBox textBoxReadS;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nroom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Smax1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scook1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
    }
}

