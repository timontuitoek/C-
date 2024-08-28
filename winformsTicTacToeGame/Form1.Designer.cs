namespace winformsTicTacToeGame
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
            A1 = new Button();
            A3 = new Button();
            A2 = new Button();
            B2 = new Button();
            B3 = new Button();
            B1 = new Button();
            C3 = new Button();
            C2 = new Button();
            C1 = new Button();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // A1
            // 
            A1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A1.Location = new Point(0, 27);
            A1.Name = "A1";
            A1.Size = new Size(75, 75);
            A1.TabIndex = 0;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_click;
            // 
            // A3
            // 
            A3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A3.Location = new Point(162, 27);
            A3.Name = "A3";
            A3.Size = new Size(75, 75);
            A3.TabIndex = 1;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_click;
            // 
            // A2
            // 
            A2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A2.Location = new Point(81, 27);
            A2.Name = "A2";
            A2.Size = new Size(75, 75);
            A2.TabIndex = 2;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_click;
            // 
            // B2
            // 
            B2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B2.Location = new Point(81, 108);
            B2.Name = "B2";
            B2.Size = new Size(75, 75);
            B2.TabIndex = 3;
            B2.UseVisualStyleBackColor = true;
            B2.Click += button_click;
            // 
            // B3
            // 
            B3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B3.Location = new Point(162, 108);
            B3.Name = "B3";
            B3.Size = new Size(75, 75);
            B3.TabIndex = 4;
            B3.UseVisualStyleBackColor = true;
            B3.Click += button_click;
            // 
            // B1
            // 
            B1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B1.Location = new Point(0, 108);
            B1.Name = "B1";
            B1.Size = new Size(75, 75);
            B1.TabIndex = 5;
            B1.UseVisualStyleBackColor = true;
            B1.Click += button_click;
            // 
            // C3
            // 
            C3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            C3.Location = new Point(162, 189);
            C3.Name = "C3";
            C3.Size = new Size(75, 75);
            C3.TabIndex = 6;
            C3.UseVisualStyleBackColor = true;
            C3.Click += button_click;
            // 
            // C2
            // 
            C2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            C2.Location = new Point(81, 189);
            C2.Name = "C2";
            C2.Size = new Size(75, 75);
            C2.TabIndex = 7;
            C2.UseVisualStyleBackColor = true;
            C2.Click += button_click;
            // 
            // C1
            // 
            C1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            C1.Location = new Point(0, 189);
            C1.Name = "C1";
            C1.Size = new Size(75, 75);
            C1.TabIndex = 8;
            C1.UseVisualStyleBackColor = true;
            C1.Click += button_click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(241, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(241, 24);
            menuStrip2.TabIndex = 10;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(180, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 266);
            Controls.Add(C1);
            Controls.Add(C2);
            Controls.Add(C3);
            Controls.Add(B1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(A2);
            Controls.Add(A3);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button A1;
        private Button A3;
        private Button A2;
        private Button B2;
        private Button B3;
        private Button B1;
        private Button C3;
        private Button C2;
        private Button C1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}
