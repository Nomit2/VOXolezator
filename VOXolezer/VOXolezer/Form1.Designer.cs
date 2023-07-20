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
            this.labelHelp = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTop = new System.Windows.Forms.Label();
            this.panelAll = new System.Windows.Forms.Panel();
            this.labelAll = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.labelSide = new System.Windows.Forms.Label();
            this.panelFront = new System.Windows.Forms.Panel();
            this.labelFront = new System.Windows.Forms.Label();
            this.panelPallete = new System.Windows.Forms.Panel();
            this.labelPalette = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelHelp.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelHelp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelAll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSide, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelFront, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelPallete, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 682);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonSelect);
            this.panelButtons.Controls.Add(this.buttonConvert);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 2);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(222, 213);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(16, 67);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSelect.Size = new System.Drawing.Size(186, 32);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select image";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Enabled = false;
            this.buttonConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.buttonConvert.Location = new System.Drawing.Point(16, 104);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(186, 32);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.labelHelp);
            this.panelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHelp.Location = new System.Drawing.Point(231, 2);
            this.panelHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(222, 213);
            this.panelHelp.TabIndex = 1;
            // 
            // labelHelp
            // 
            this.labelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp.AutoSize = true;
            this.labelHelp.Location = new System.Drawing.Point(47, 59);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(0, 17);
            this.labelHelp.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 219);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(222, 201);
            this.panelTop.TabIndex = 2;
            // 
            // labelTop
            // 
            this.labelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(189, 182);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(33, 17);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Top";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAll
            // 
            this.panelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAll.Controls.Add(this.labelAll);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(231, 219);
            this.panelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(222, 201);
            this.panelAll.TabIndex = 3;
            // 
            // labelAll
            // 
            this.labelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAll.AutoSize = true;
            this.labelAll.Location = new System.Drawing.Point(195, 182);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(23, 17);
            this.labelAll.TabIndex = 1;
            this.labelAll.Text = "All";
            this.labelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSide
            // 
            this.panelSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSide.Controls.Add(this.labelSide);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSide.Location = new System.Drawing.Point(3, 424);
            this.panelSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(222, 201);
            this.panelSide.TabIndex = 4;
            // 
            // labelSide
            // 
            this.labelSide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSide.AutoSize = true;
            this.labelSide.Location = new System.Drawing.Point(181, 182);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(41, 17);
            this.labelSide.TabIndex = 1;
            this.labelSide.Text = "Front";
            this.labelSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSide.Click += new System.EventHandler(this.labelSide_Click);
            // 
            // panelFront
            // 
            this.panelFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFront.Controls.Add(this.labelFront);
            this.panelFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFront.Location = new System.Drawing.Point(231, 424);
            this.panelFront.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(222, 201);
            this.panelFront.TabIndex = 5;
            // 
            // labelFront
            // 
            this.labelFront.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFront.AutoSize = true;
            this.labelFront.Location = new System.Drawing.Point(176, 182);
            this.labelFront.Name = "labelFront";
            this.labelFront.Size = new System.Drawing.Size(36, 17);
            this.labelFront.TabIndex = 1;
            this.labelFront.Text = "Side";
            this.labelFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPallete
            // 
            this.panelPallete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPallete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.panelPallete, 2);
            this.panelPallete.Controls.Add(this.labelPalette);
            this.panelPallete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPallete.Location = new System.Drawing.Point(3, 629);
            this.panelPallete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPallete.Name = "panelPallete";
            this.panelPallete.Size = new System.Drawing.Size(450, 51);
            this.panelPallete.TabIndex = 6;
            // 
            // labelPalette
            // 
            this.labelPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPalette.AutoSize = true;
            this.labelPalette.Location = new System.Drawing.Point(208, 16);
            this.labelPalette.Name = "labelPalette";
            this.labelPalette.Size = new System.Drawing.Size(52, 17);
            this.labelPalette.TabIndex = 1;
            this.labelPalette.Text = "Palette";
            this.labelPalette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 702);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "VOXolizer 0.1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
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
        private System.Windows.Forms.Label labelHelp;
    }
}

