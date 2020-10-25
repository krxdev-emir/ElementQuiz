namespace Elements
{
    partial class ElementTest
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementTest));
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.numCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.nameIn = new MaterialSkin.Controls.MaterialTextBox();
            this.numIn = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameScore = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.DrawShadows = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(53, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Depth = 0;
            this.button2.DrawShadows = true;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(53, 329);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "H";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 236);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameCheck
            // 
            this.nameCheck.AutoSize = true;
            this.nameCheck.Depth = 0;
            this.nameCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameCheck.Location = new System.Drawing.Point(212, 98);
            this.nameCheck.Margin = new System.Windows.Forms.Padding(0);
            this.nameCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.nameCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameCheck.Name = "nameCheck";
            this.nameCheck.Ripple = true;
            this.nameCheck.Size = new System.Drawing.Size(112, 37);
            this.nameCheck.TabIndex = 5;
            this.nameCheck.Text = "Name Test";
            this.nameCheck.UseVisualStyleBackColor = true;
            // 
            // numCheck
            // 
            this.numCheck.AutoSize = true;
            this.numCheck.Depth = 0;
            this.numCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numCheck.Location = new System.Drawing.Point(212, 128);
            this.numCheck.Margin = new System.Windows.Forms.Padding(0);
            this.numCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.numCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.numCheck.Name = "numCheck";
            this.numCheck.Ripple = true;
            this.numCheck.Size = new System.Drawing.Size(180, 37);
            this.numCheck.TabIndex = 6;
            this.numCheck.Text = "Atomic Number Test";
            this.numCheck.UseVisualStyleBackColor = true;
            // 
            // nameIn
            // 
            this.nameIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameIn.Depth = 0;
            this.nameIn.Font = new System.Drawing.Font("Roboto", 12F);
            this.nameIn.Location = new System.Drawing.Point(267, 187);
            this.nameIn.MaxLength = 50;
            this.nameIn.MouseState = MaterialSkin.MouseState.OUT;
            this.nameIn.Multiline = false;
            this.nameIn.Name = "nameIn";
            this.nameIn.Size = new System.Drawing.Size(133, 36);
            this.nameIn.TabIndex = 7;
            this.nameIn.Text = "";
            this.nameIn.UseTallSize = false;
            // 
            // numIn
            // 
            this.numIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numIn.Depth = 0;
            this.numIn.Font = new System.Drawing.Font("Roboto", 12F);
            this.numIn.Location = new System.Drawing.Point(267, 229);
            this.numIn.MaxLength = 50;
            this.numIn.MouseState = MaterialSkin.MouseState.OUT;
            this.numIn.Multiline = false;
            this.numIn.Name = "numIn";
            this.numIn.Size = new System.Drawing.Size(133, 36);
            this.numIn.TabIndex = 8;
            this.numIn.Text = "";
            this.numIn.UseTallSize = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(207, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(206, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "A. Num:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(206, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(207, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "A. Num Score:";
            // 
            // nameScore
            // 
            this.nameScore.AutoSize = true;
            this.nameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameScore.Location = new System.Drawing.Point(324, 285);
            this.nameScore.Name = "nameScore";
            this.nameScore.Size = new System.Drawing.Size(18, 20);
            this.nameScore.TabIndex = 13;
            this.nameScore.Text = "0";
            // 
            // numScore
            // 
            this.numScore.AutoSize = true;
            this.numScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numScore.Location = new System.Drawing.Point(324, 315);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(18, 20);
            this.numScore.TabIndex = 14;
            this.numScore.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Question Interval:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "to";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(302, 378);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            118,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(378, 378);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            118,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            118,
            0,
            0,
            0});
            // 
            // ElementTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 410);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.nameScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numIn);
            this.Controls.Add(this.nameIn);
            this.Controls.Add(this.numCheck);
            this.Controls.Add(this.nameCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElementTest";
            this.Text = "ElementTest";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCheckbox nameCheck;
        private MaterialSkin.Controls.MaterialCheckbox numCheck;
        private MaterialSkin.Controls.MaterialTextBox nameIn;
        private MaterialSkin.Controls.MaterialTextBox numIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nameScore;
        private System.Windows.Forms.Label numScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

