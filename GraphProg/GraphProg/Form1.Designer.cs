namespace GraphProg
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.item1 = new System.Windows.Forms.Label();
            this.item2 = new System.Windows.Forms.Label();
            this.itemCombo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboPicture = new System.Windows.Forms.PictureBox();
            this.youGotLabel = new System.Windows.Forms.Label();
            this.firstItemPic = new System.Windows.Forms.PictureBox();
            this.secondItemPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.comboPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstItemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondItemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(767, 937);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Combine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // item1
            // 
            this.item1.AutoSize = true;
            this.item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.item1.Location = new System.Drawing.Point(253, 937);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(120, 29);
            this.item1.TabIndex = 8;
            this.item1.Text = "Pick item";
            this.item1.Click += new System.EventHandler(this.item1_Click);
            // 
            // item2
            // 
            this.item2.AutoSize = true;
            this.item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.item2.Location = new System.Drawing.Point(1377, 937);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(120, 29);
            this.item2.TabIndex = 9;
            this.item2.Text = "Pick item";
            // 
            // itemCombo
            // 
            this.itemCombo.AutoSize = true;
            this.itemCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.itemCombo.ForeColor = System.Drawing.Color.Green;
            this.itemCombo.Location = new System.Drawing.Point(761, 644);
            this.itemCombo.Name = "itemCombo";
            this.itemCombo.Size = new System.Drawing.Size(115, 36);
            this.itemCombo.TabIndex = 10;
            this.itemCombo.Text = "Combo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1847, 565);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // comboPicture
            // 
            this.comboPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comboPicture.Location = new System.Drawing.Point(767, 696);
            this.comboPicture.Name = "comboPicture";
            this.comboPicture.Size = new System.Drawing.Size(352, 218);
            this.comboPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comboPicture.TabIndex = 12;
            this.comboPicture.TabStop = false;
            this.comboPicture.Click += new System.EventHandler(this.comboPicture_Click);
            // 
            // youGotLabel
            // 
            this.youGotLabel.AutoSize = true;
            this.youGotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.youGotLabel.Location = new System.Drawing.Point(763, 620);
            this.youGotLabel.Name = "youGotLabel";
            this.youGotLabel.Size = new System.Drawing.Size(75, 24);
            this.youGotLabel.TabIndex = 13;
            this.youGotLabel.Text = "You got";
            this.youGotLabel.Visible = false;
            // 
            // firstItemPic
            // 
            this.firstItemPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstItemPic.Location = new System.Drawing.Point(259, 746);
            this.firstItemPic.Name = "firstItemPic";
            this.firstItemPic.Size = new System.Drawing.Size(250, 168);
            this.firstItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstItemPic.TabIndex = 14;
            this.firstItemPic.TabStop = false;
            // 
            // secondItemPic
            // 
            this.secondItemPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondItemPic.Location = new System.Drawing.Point(1383, 746);
            this.secondItemPic.Name = "secondItemPic";
            this.secondItemPic.Size = new System.Drawing.Size(250, 168);
            this.secondItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondItemPic.TabIndex = 15;
            this.secondItemPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 583);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1847, 10);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 1030);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.secondItemPic);
            this.Controls.Add(this.firstItemPic);
            this.Controls.Add(this.youGotLabel);
            this.Controls.Add(this.comboPicture);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.itemCombo);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.comboPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstItemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondItemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label item1;
        private System.Windows.Forms.Label item2;
        private System.Windows.Forms.Label itemCombo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox comboPicture;
        private System.Windows.Forms.Label youGotLabel;
        private System.Windows.Forms.PictureBox firstItemPic;
        private System.Windows.Forms.PictureBox secondItemPic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

