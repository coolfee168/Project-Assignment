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
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(255, 128, 128);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnProduct);
            panelSidebar.Controls.Add(btnSupply);
            panelSidebar.Controls.Add(btnOrder);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(166, 696);
            panelSidebar.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(12, 411);
            button2.Name = "button2";
            button2.Size = new Size(135, 56);
            button2.TabIndex = 7;
            button2.Text = "Management";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 349);
            button1.Name = "button1";
            button1.Size = new Size(135, 56);
            button1.TabIndex = 6;
            button1.Text = "Analyze";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 639);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 5;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 606);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "User";
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(12, 225);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(135, 56);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnSupply
            // 
            btnSupply.Location = new Point(12, 287);
            btnSupply.Name = "btnSupply";
            btnSupply.Size = new Size(135, 56);
            btnSupply.TabIndex = 2;
            btnSupply.Text = "Supply";
            btnSupply.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(12, 163);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(135, 56);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
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
            Resize += Management_Resize;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
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
    }
}