namespace _06._04
{
    partial class Form1
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
            this.tabBox = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.tabAuthors = new System.Windows.Forms.TabPage();
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.tabPublishers = new System.Windows.Forms.TabPage();
            this.dataGridPublishers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabBox.SuspendLayout();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.tabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            this.tabPublishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.tabBooks);
            this.tabBox.Controls.Add(this.tabAuthors);
            this.tabBox.Controls.Add(this.tabPublishers);
            this.tabBox.Location = new System.Drawing.Point(12, 12);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(366, 239);
            this.tabBox.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.dataGridBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(358, 213);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.Size = new System.Drawing.Size(358, 213);
            this.dataGridBooks.TabIndex = 0;
            // 
            // tabAuthors
            // 
            this.tabAuthors.Controls.Add(this.dataGridAuthors);
            this.tabAuthors.Location = new System.Drawing.Point(4, 22);
            this.tabAuthors.Name = "tabAuthors";
            this.tabAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuthors.Size = new System.Drawing.Size(358, 213);
            this.tabAuthors.TabIndex = 1;
            this.tabAuthors.Text = "Authors";
            this.tabAuthors.UseVisualStyleBackColor = true;
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Location = new System.Drawing.Point(0, 0);
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.Size = new System.Drawing.Size(358, 213);
            this.dataGridAuthors.TabIndex = 0;
            // 
            // tabPublishers
            // 
            this.tabPublishers.Controls.Add(this.dataGridPublishers);
            this.tabPublishers.Location = new System.Drawing.Point(4, 22);
            this.tabPublishers.Name = "tabPublishers";
            this.tabPublishers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublishers.Size = new System.Drawing.Size(358, 213);
            this.tabPublishers.TabIndex = 2;
            this.tabPublishers.Text = "Publishers";
            this.tabPublishers.UseVisualStyleBackColor = true;
            // 
            // dataGridPublishers
            // 
            this.dataGridPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublishers.Location = new System.Drawing.Point(0, 0);
            this.dataGridPublishers.Name = "dataGridPublishers";
            this.dataGridPublishers.Size = new System.Drawing.Size(358, 213);
            this.dataGridPublishers.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(408, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(408, 72);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(408, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 304);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabBox.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.tabAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            this.tabPublishers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBox;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.TabPage tabAuthors;
        private System.Windows.Forms.TabPage tabPublishers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridAuthors;
        private System.Windows.Forms.DataGridView dataGridPublishers;
    }
}

