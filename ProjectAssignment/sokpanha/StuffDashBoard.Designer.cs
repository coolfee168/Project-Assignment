namespace ProjectAssignment.sokpanha
{
    partial class StuffDashBoard
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
            panelSidebar = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            btnProduct = new Button();
            btnSupply = new Button();
            btnOrder = new Button();
            panelTop = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            panelSidebar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(255, 128, 128);
            panelSidebar.Controls.Add(tableLayoutPanel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(166, 696);
            panelSidebar.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(20, 351);
            button2.Name = "button2";
            button2.Size = new Size(123, 44);
            button2.TabIndex = 7;
            button2.Text = "Management";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(20, 301);
            button1.Name = "button1";
            button1.Size = new Size(123, 44);
            button1.TabIndex = 6;
            button1.Text = "Analyze";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 598);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 5;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 548);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 4;
            label1.Text = "User";
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(20, 201);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(123, 44);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnSupply
            // 
            btnSupply.Location = new Point(20, 251);
            btnSupply.Name = "btnSupply";
            btnSupply.Size = new Size(123, 44);
            btnSupply.TabIndex = 2;
            btnSupply.Text = "Supply";
            btnSupply.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(20, 151);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(123, 44);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Red;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(166, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1027, 138);
            panelTop.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 696);
            panel3.Name = "panel3";
            panel3.Size = new Size(1193, 23);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1193, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(27, 719);
            panel4.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(166, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 558);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.86486F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.13514F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 2, 3);
            tableLayoutPanel1.Controls.Add(btnOrder, 2, 6);
            tableLayoutPanel1.Controls.Add(btnLogout, 2, 16);
            tableLayoutPanel1.Controls.Add(button2, 2, 10);
            tableLayoutPanel1.Controls.Add(btnProduct, 2, 7);
            tableLayoutPanel1.Controls.Add(btnSupply, 2, 8);
            tableLayoutPanel1.Controls.Add(button1, 2, 9);
            tableLayoutPanel1.Controls.Add(label1, 2, 14);
            tableLayoutPanel1.Controls.Add(label2, 2, 15);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(166, 696);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(20, 651);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 44);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Order";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._695f5b45dae6e6d3504909f75b6ff11c;
            pictureBox1.Location = new Point(20, 1);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 3);
            pictureBox1.Size = new Size(123, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StuffDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 719);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Controls.Add(panelSidebar);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "StuffDashBoard";
            Text = "Management";
            Load += StuffDashBoard_Load;
            Resize += Management_Resize;
            panelSidebar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelTop;
        private Panel panel3;
        private Panel panel4;
        private Button btnProduct;
        private Button btnSupply;
        private Button btnOrder;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Button btnLogout;
    }
}