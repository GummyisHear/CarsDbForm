namespace WinFormsApp1
{
    partial class OwnerSearchForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            searchTxt = new TextBox();
            confirmBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(493, 299);
            dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(248, 107);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 16;
            label3.Text = "Otsing";
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Segoe UI", 12F);
            searchTxt.Location = new Point(310, 104);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(195, 29);
            searchTxt.TabIndex = 15;
            searchTxt.TextChanged += searchTxt_TextChanged;
            // 
            // confirmBtn
            // 
            confirmBtn.Font = new Font("Segoe UI", 12F);
            confirmBtn.Location = new Point(12, 104);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(100, 29);
            confirmBtn.TabIndex = 14;
            confirmBtn.Text = "Vali";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(127, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 45);
            label1.TabIndex = 17;
            label1.Text = "Omaniku Otsing";
            // 
            // OwnerSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(searchTxt);
            Controls.Add(confirmBtn);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F);
            Name = "OwnerSearchForm";
            Text = "Omaniku Otsing";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private TextBox searchTxt;
        private Button confirmBtn;
        private Label label1;
    }
}