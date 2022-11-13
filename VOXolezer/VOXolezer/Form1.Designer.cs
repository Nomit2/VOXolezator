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
            this.panelHelp = new System.Windows.Forms.Panel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelPallete = new System.Windows.Forms.Panel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelHelp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFront, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSide, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelAll, 1, 2);
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
            // panelHelp
            // 
            this.panelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHelp.Location = new System.Drawing.Point(259, 3);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(250, 266);
            this.panelHelp.TabIndex = 1;
            // 
            // panelFront
            // 
            this.panelFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFront.Location = new System.Drawing.Point(3, 275);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(250, 250);
            this.panelFront.TabIndex = 2;
            // 
            // panelSide
            // 
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSide.Location = new System.Drawing.Point(259, 275);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(250, 250);
            this.panelSide.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 531);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(250, 250);
            this.panelTop.TabIndex = 4;
            // 
            // panelAll
            // 
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(259, 531);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(250, 250);
            this.panelAll.TabIndex = 5;
            // 
            // panelPallete
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelPallete, 2);
            this.panelPallete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPallete.Location = new System.Drawing.Point(3, 787);
            this.panelPallete.Name = "panelPallete";
            this.panelPallete.Size = new System.Drawing.Size(506, 63);
            this.panelPallete.TabIndex = 6;
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
            this.buttonConvert.Location = new System.Drawing.Point(18, 130);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(209, 40);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelPallete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonConvert;
    }
}

