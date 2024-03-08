namespace DuAnNhom
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            contactToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            panel = new Panel();
            bindingSource1 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 50);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, aboutUsToolStripMenuItem, contactToolStripMenuItem });
            menuStrip1.Location = new Point(700, 12);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(535, 102);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            homeToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            homeToolStripMenuItem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            homeToolStripMenuItem.ForeColor = SystemColors.Highlight;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(125, 98);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            aboutUsToolStripMenuItem.ForeColor = SystemColors.Highlight;
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(169, 98);
            aboutUsToolStripMenuItem.Text = "About us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // contactToolStripMenuItem
            // 
            contactToolStripMenuItem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            contactToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            contactToolStripMenuItem.Size = new Size(151, 98);
            contactToolStripMenuItem.Text = "Contact";
            contactToolStripMenuItem.Click += contactToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(592, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(4, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1190, 119);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.AutoScrollMinSize = new Size(50, 50);
            panel.AutoSize = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(5, 111);
            panel.Name = "panel";
            panel.Size = new Size(1159, 546);
            panel.TabIndex = 6;
            panel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1188, 658);
            Controls.Add(panel);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem contactToolStripMenuItem;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Panel panel;
        private BindingSource bindingSource1;
    }
}