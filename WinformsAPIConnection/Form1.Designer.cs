namespace WinformsAPIConnection
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
            JobCardTabs = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            JobsGridView = new System.Windows.Forms.DataGridView();
            vehiclesTab = new System.Windows.Forms.TabPage();
            vehiclesGridView = new System.Windows.Forms.DataGridView();
            JobCardTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JobsGridView).BeginInit();
            vehiclesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vehiclesGridView).BeginInit();
            SuspendLayout();
            // 
            // JobCardTabs
            // 
            JobCardTabs.Controls.Add(tabPage1);
            JobCardTabs.Controls.Add(vehiclesTab);
            JobCardTabs.Location = new System.Drawing.Point(12, 12);
            JobCardTabs.Name = "JobCardTabs";
            JobCardTabs.SelectedIndex = 0;
            JobCardTabs.Size = new System.Drawing.Size(744, 426);
            JobCardTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(JobsGridView);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(736, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Jobs";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // JobsGridView
            // 
            JobsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JobsGridView.Location = new System.Drawing.Point(6, 124);
            JobsGridView.Name = "JobsGridView";
            JobsGridView.RowTemplate.Height = 25;
            JobsGridView.Size = new System.Drawing.Size(724, 150);
            JobsGridView.TabIndex = 0;
            // 
            // vehiclesTab
            // 
            vehiclesTab.Controls.Add(vehiclesGridView);
            vehiclesTab.Location = new System.Drawing.Point(4, 24);
            vehiclesTab.Name = "vehiclesTab";
            vehiclesTab.Padding = new System.Windows.Forms.Padding(3);
            vehiclesTab.Size = new System.Drawing.Size(736, 398);
            vehiclesTab.TabIndex = 1;
            vehiclesTab.Text = "Vehicles";
            vehiclesTab.UseVisualStyleBackColor = true;
            // 
            // vehiclesGridView
            // 
            vehiclesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehiclesGridView.Location = new System.Drawing.Point(3, 117);
            vehiclesGridView.Name = "vehiclesGridView";
            vehiclesGridView.RowTemplate.Height = 25;
            vehiclesGridView.Size = new System.Drawing.Size(730, 150);
            vehiclesGridView.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(JobCardTabs);
            Name = "Form1";
            Text = "Form1";
            JobCardTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)JobsGridView).EndInit();
            vehiclesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vehiclesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl JobCardTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage vehiclesTab;
        private System.Windows.Forms.DataGridView JobsGridView;
        private System.Windows.Forms.DataGridView vehiclesGridView;
    }
}
