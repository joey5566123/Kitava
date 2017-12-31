namespace Kitava.GUI
{
    partial class KitavaForm
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
            this.MapsButton = new System.Windows.Forms.Button();
            this.PickitButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UpdateFilePage = new System.Windows.Forms.TabPage();
            this.CtrlShiftClickPage = new System.Windows.Forms.TabPage();
            this.TextLabel2 = new System.Windows.Forms.Label();
            this.TextLabel1 = new System.Windows.Forms.Label();
            this.InventoryPage = new System.Windows.Forms.TabPage();
            this.DelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.RowNumeric = new System.Windows.Forms.NumericUpDown();
            this.ColumnNumeric = new System.Windows.Forms.NumericUpDown();
            this.RowLabel = new System.Windows.Forms.Label();
            this.CoulumnLabel = new System.Windows.Forms.Label();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.UpdateFilePage.SuspendLayout();
            this.CtrlShiftClickPage.SuspendLayout();
            this.InventoryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // MapsButton
            // 
            this.MapsButton.Location = new System.Drawing.Point(20, 15);
            this.MapsButton.Name = "MapsButton";
            this.MapsButton.Size = new System.Drawing.Size(180, 30);
            this.MapsButton.TabIndex = 0;
            this.MapsButton.Text = "Update Maps";
            this.MapsButton.UseVisualStyleBackColor = true;
            this.MapsButton.Click += new System.EventHandler(this.MapsButtonClick);
            // 
            // PickitButton
            // 
            this.PickitButton.Location = new System.Drawing.Point(20, 56);
            this.PickitButton.Name = "PickitButton";
            this.PickitButton.Size = new System.Drawing.Size(180, 30);
            this.PickitButton.TabIndex = 1;
            this.PickitButton.Text = "Update Pickit";
            this.PickitButton.UseVisualStyleBackColor = true;
            this.PickitButton.Click += new System.EventHandler(this.PickitButtonClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UpdateFilePage);
            this.tabControl1.Controls.Add(this.CtrlShiftClickPage);
            this.tabControl1.Controls.Add(this.InventoryPage);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(225, 139);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabChange);
            // 
            // UpdateFilePage
            // 
            this.UpdateFilePage.BackColor = System.Drawing.Color.Transparent;
            this.UpdateFilePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdateFilePage.Controls.Add(this.MapsButton);
            this.UpdateFilePage.Controls.Add(this.PickitButton);
            this.UpdateFilePage.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UpdateFilePage.Location = new System.Drawing.Point(4, 26);
            this.UpdateFilePage.Name = "UpdateFilePage";
            this.UpdateFilePage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateFilePage.Size = new System.Drawing.Size(217, 109);
            this.UpdateFilePage.TabIndex = 0;
            this.UpdateFilePage.Text = "Updata File";
            // 
            // CtrlShiftClickPage
            // 
            this.CtrlShiftClickPage.BackColor = System.Drawing.Color.Transparent;
            this.CtrlShiftClickPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CtrlShiftClickPage.Controls.Add(this.TextLabel2);
            this.CtrlShiftClickPage.Controls.Add(this.TextLabel1);
            this.CtrlShiftClickPage.Location = new System.Drawing.Point(4, 26);
            this.CtrlShiftClickPage.Name = "CtrlShiftClickPage";
            this.CtrlShiftClickPage.Padding = new System.Windows.Forms.Padding(3);
            this.CtrlShiftClickPage.Size = new System.Drawing.Size(217, 109);
            this.CtrlShiftClickPage.TabIndex = 2;
            this.CtrlShiftClickPage.Text = "C&S Click";
            // 
            // TextLabel2
            // 
            this.TextLabel2.AutoSize = true;
            this.TextLabel2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextLabel2.Location = new System.Drawing.Point(17, 64);
            this.TextLabel2.Name = "TextLabel2";
            this.TextLabel2.Size = new System.Drawing.Size(184, 19);
            this.TextLabel2.TabIndex = 1;
            this.TextLabel2.Text = "F3 : 開始/暫停  Shift+連點";
            // 
            // TextLabel1
            // 
            this.TextLabel1.AutoSize = true;
            this.TextLabel1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextLabel1.Location = new System.Drawing.Point(18, 17);
            this.TextLabel1.Name = "TextLabel1";
            this.TextLabel1.Size = new System.Drawing.Size(177, 19);
            this.TextLabel1.TabIndex = 0;
            this.TextLabel1.Text = "F2 : 開始/暫停  Ctrl+連點";
            // 
            // InventoryPage
            // 
            this.InventoryPage.BackColor = System.Drawing.Color.Transparent;
            this.InventoryPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryPage.Controls.Add(this.DelayNumeric);
            this.InventoryPage.Controls.Add(this.RowNumeric);
            this.InventoryPage.Controls.Add(this.ColumnNumeric);
            this.InventoryPage.Controls.Add(this.RowLabel);
            this.InventoryPage.Controls.Add(this.CoulumnLabel);
            this.InventoryPage.Controls.Add(this.DelayLabel);
            this.InventoryPage.Location = new System.Drawing.Point(4, 26);
            this.InventoryPage.Name = "InventoryPage";
            this.InventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryPage.Size = new System.Drawing.Size(217, 109);
            this.InventoryPage.TabIndex = 1;
            this.InventoryPage.Text = "Inv. Click";
            // 
            // DelayNumeric
            // 
            this.DelayNumeric.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DelayNumeric.Location = new System.Drawing.Point(94, 74);
            this.DelayNumeric.Name = "DelayNumeric";
            this.DelayNumeric.Size = new System.Drawing.Size(44, 27);
            this.DelayNumeric.TabIndex = 5;
            this.DelayNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelayNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.DelayNumeric.ValueChanged += new System.EventHandler(this.DelayValueChange);
            // 
            // RowNumeric
            // 
            this.RowNumeric.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RowNumeric.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RowNumeric.Location = new System.Drawing.Point(127, 28);
            this.RowNumeric.Name = "RowNumeric";
            this.RowNumeric.Size = new System.Drawing.Size(55, 27);
            this.RowNumeric.TabIndex = 4;
            this.RowNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RowNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowNumeric.ValueChanged += new System.EventHandler(this.RowValueChanged);
            // 
            // ColumnNumeric
            // 
            this.ColumnNumeric.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ColumnNumeric.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ColumnNumeric.Location = new System.Drawing.Point(38, 28);
            this.ColumnNumeric.Name = "ColumnNumeric";
            this.ColumnNumeric.Size = new System.Drawing.Size(55, 27);
            this.ColumnNumeric.TabIndex = 3;
            this.ColumnNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnNumeric.ValueChanged += new System.EventHandler(this.ColumnValueChanged);
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RowLabel.Location = new System.Drawing.Point(132, 6);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(34, 17);
            this.RowLabel.TabIndex = 2;
            this.RowLabel.Text = "Row";
            // 
            // CoulumnLabel
            // 
            this.CoulumnLabel.AutoSize = true;
            this.CoulumnLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CoulumnLabel.Location = new System.Drawing.Point(34, 6);
            this.CoulumnLabel.Name = "CoulumnLabel";
            this.CoulumnLabel.Size = new System.Drawing.Size(56, 17);
            this.CoulumnLabel.TabIndex = 1;
            this.CoulumnLabel.Text = "Column";
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(43, 78);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(123, 17);
            this.DelayLabel.TabIndex = 6;
            this.DelayLabel.Text = "Delay :                   ms";
            // 
            // KitavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(228, 146);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KitavaForm";
            this.Opacity = 0.9D;
            this.Text = "Kitava_v0.3";
            this.tabControl1.ResumeLayout(false);
            this.UpdateFilePage.ResumeLayout(false);
            this.CtrlShiftClickPage.ResumeLayout(false);
            this.CtrlShiftClickPage.PerformLayout();
            this.InventoryPage.ResumeLayout(false);
            this.InventoryPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MapsButton;
        private System.Windows.Forms.Button PickitButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UpdateFilePage;
        private System.Windows.Forms.TabPage InventoryPage;
        private System.Windows.Forms.NumericUpDown RowNumeric;
        private System.Windows.Forms.NumericUpDown ColumnNumeric;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.Label CoulumnLabel;
        private System.Windows.Forms.TabPage CtrlShiftClickPage;
        private System.Windows.Forms.NumericUpDown DelayNumeric;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.Label TextLabel2;
        private System.Windows.Forms.Label TextLabel1;
    }
}