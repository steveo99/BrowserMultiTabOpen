﻿namespace BrowserMultiTabOpen
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pageListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.investmentStockResearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageListsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pageListsToolStripMenuItem
            // 
            this.pageListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.investmentStockResearchToolStripMenuItem});
            this.pageListsToolStripMenuItem.Name = "pageListsToolStripMenuItem";
            this.pageListsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.pageListsToolStripMenuItem.Text = "Page Lists";
            // 
            // investmentStockResearchToolStripMenuItem
            // 
            this.investmentStockResearchToolStripMenuItem.Name = "investmentStockResearchToolStripMenuItem";
            this.investmentStockResearchToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.investmentStockResearchToolStripMenuItem.Text = "Investment Stock Research";
            this.investmentStockResearchToolStripMenuItem.Click += new System.EventHandler(this.InvestmentStockResearchToolStripMenuItemClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 387);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pageListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem investmentStockResearchToolStripMenuItem;
    }
}

