namespace VOXolezer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.panelPallete = new System.Windows.Forms.Panel();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelSide = new System.Windows.Forms.Label();
            this.labelAll = new System.Windows.Forms.Label();
            this.labelFront = new System.Windows.Forms.Label();
            this.labelPalette = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelFront.SuspendLayout();
            this.panelPallete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelHelp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelAll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSide, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelFront, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelPallete, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 853);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonSelect);
            this.panelButtons.Controls.Add(this.buttonConvert);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(250, 266);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(18, 84);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSelect.Size = new System.Drawing.Size(209, 40);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select image";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Location = new System.Drawing.Point(18, 130);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(209, 40);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // panelHelp
            // 
            this.panelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHelp.Location = new System.Drawing.Point(259, 3);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(250, 266);
            this.panelHelp.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 275);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(250, 250);
            this.panelTop.TabIndex = 2;
            // 
            // panelAll
            // 
            this.panelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAll.Controls.Add(this.labelAll);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(259, 275);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(250, 250);
            this.panelAll.TabIndex = 3;
            // 
            // panelSide
            // 
            this.panelSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSide.Controls.Add(this.labelSide);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSide.Location = new System.Drawing.Point(3, 531);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(250, 250);
            this.panelSide.TabIndex = 4;
            // 
            // panelFront
            // 
            this.panelFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFront.Controls.Add(this.labelFront);
            this.panelFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFront.Location = new System.Drawing.Point(259, 531);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(250, 250);
            this.panelFront.TabIndex = 5;
            // 
            // panelPallete
            // 
            this.panelPallete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPallete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.panelPallete, 2);
            this.panelPallete.Controls.Add(this.labelPalette);
            this.panelPallete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPallete.Location = new System.Drawing.Point(3, 787);
            this.panelPallete.Name = "panelPallete";
            this.panelPallete.Size = new System.Drawing.Size(506, 63);
            this.panelPallete.TabIndex = 6;
            // 
            // labelTop
            // 
            this.labelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(213, 228);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(36, 20);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Top";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSide
            // 
            this.labelSide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSide.AutoSize = true;
            this.labelSide.Location = new System.Drawing.Point(204, 228);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(41, 20);
            this.labelSide.TabIndex = 1;
            this.labelSide.Text = "Side";
            this.labelSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAll
            // 
            this.labelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAll.AutoSize = true;
            this.labelAll.Location = new System.Drawing.Point(219, 228);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(26, 20);
            this.labelAll.TabIndex = 1;
            this.labelAll.Text = "All";
            this.labelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFront
            // 
            this.labelFront.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFront.AutoSize = true;
            this.labelFront.Location = new System.Drawing.Point(198, 228);
            this.labelFront.Name = "labelFront";
            this.labelFront.Size = new System.Drawing.Size(47, 20);
            this.labelFront.TabIndex = 1;
            this.labelFront.Text = "Front";
            this.labelFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPalette
            // 
            this.labelPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPalette.AutoSize = true;
            this.labelPalette.Location = new System.Drawing.Point(234, 20);
            this.labelPalette.Name = "labelPalette";
            this.labelPalette.Size = new System.Drawing.Size(59, 20);
            this.labelPalette.TabIndex = 1;
            this.labelPalette.Text = "Palette";
            this.labelPalette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 877);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "VOXolizer 0.1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelFront.ResumeLayout(false);
            this.panelFront.PerformLayout();
            this.panelPallete.ResumeLayout(false);
            this.panelPallete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Panel panelPallete;
        private System.Windows.Forms.Button buttonSelect;
        public System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Panel panelAll;
        public System.Windows.Forms.Panel panelSide;
        public System.Windows.Forms.Panel panelFront;
        public System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.Label labelSide;
        private System.Windows.Forms.Label labelFront;
        private System.Windows.Forms.Label labelPalette;
    }
}

