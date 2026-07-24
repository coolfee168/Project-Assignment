namespace ProjectAssignment
{
    partial class FormLogin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 480F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(898, 554);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 1, 4);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 3);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 5);
            tableLayoutPanel2.Controls.Add(checkBox1, 1, 6);
            tableLayoutPanel2.Controls.Add(button1, 1, 7);
            tableLayoutPanel2.Controls.Add(linkLabel1, 1, 8);
            tableLayoutPanel2.Location = new Point(99, 37);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(350, 480);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe Fluent Icons", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 72);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(38, 105);
            label2.Name = "label2";
            label2.Size = new Size(274, 38);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(38, 200);
            label3.Name = "label3";
            label3.Size = new Size(274, 38);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(38, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(38, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 27);
            textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(38, 298);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Pasword";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(45, 343);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(260, 37);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Fill;
            linkLabel1.Location = new Point(38, 390);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(274, 38);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(label4, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(449, 37);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(350, 480);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 200);
            label4.Margin = new Padding(3, 40, 3, 0);
            label4.Name = "label4";
            tableLayoutPanel3.SetRowSpan(label4, 2);
            label4.Size = new Size(274, 150);
            label4.TabIndex = 2;
            label4.Text = "PC Sale Management System";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 554);
            Controls.Add(tableLayoutPanel1);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}