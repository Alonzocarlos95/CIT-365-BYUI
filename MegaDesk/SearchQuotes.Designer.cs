﻿namespace MegaDesk
{
    partial class SearchQuotes
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
            this.backMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backMenu
            // 
            this.backMenu.AutoSize = true;
            this.backMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenu.Location = new System.Drawing.Point(427, 370);
            this.backMenu.Name = "backMenu";
            this.backMenu.Padding = new System.Windows.Forms.Padding(5);
            this.backMenu.Size = new System.Drawing.Size(75, 40);
            this.backMenu.TabIndex = 0;
            this.backMenu.Text = "Menu";
            this.backMenu.UseVisualStyleBackColor = true;
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 444);
            this.Controls.Add(this.backMenu);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMenu;
    }
}