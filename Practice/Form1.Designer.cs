namespace Practice
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
            this.Aradius = new System.Windows.Forms.NumericUpDown();
            this.Aangle = new System.Windows.Forms.NumericUpDown();
            this.Bradius = new System.Windows.Forms.NumericUpDown();
            this.Bangle = new System.Windows.Forms.NumericUpDown();
            this.Cradius = new System.Windows.Forms.NumericUpDown();
            this.Cangle = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Aradius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bradius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cradius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cangle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aradius
            // 
            this.Aradius.DecimalPlaces = 5;
            this.Aradius.Location = new System.Drawing.Point(6, 17);
            this.Aradius.Name = "Aradius";
            this.Aradius.Size = new System.Drawing.Size(120, 22);
            this.Aradius.TabIndex = 0;
            // 
            // Aangle
            // 
            this.Aangle.DecimalPlaces = 5;
            this.Aangle.Location = new System.Drawing.Point(6, 45);
            this.Aangle.Name = "Aangle";
            this.Aangle.Size = new System.Drawing.Size(120, 22);
            this.Aangle.TabIndex = 1;
            // 
            // Bradius
            // 
            this.Bradius.DecimalPlaces = 5;
            this.Bradius.Location = new System.Drawing.Point(6, 17);
            this.Bradius.Name = "Bradius";
            this.Bradius.Size = new System.Drawing.Size(120, 22);
            this.Bradius.TabIndex = 3;
            // 
            // Bangle
            // 
            this.Bangle.DecimalPlaces = 5;
            this.Bangle.Location = new System.Drawing.Point(6, 45);
            this.Bangle.Name = "Bangle";
            this.Bangle.Size = new System.Drawing.Size(120, 22);
            this.Bangle.TabIndex = 4;
            // 
            // Cradius
            // 
            this.Cradius.DecimalPlaces = 5;
            this.Cradius.Location = new System.Drawing.Point(0, 17);
            this.Cradius.Name = "Cradius";
            this.Cradius.Size = new System.Drawing.Size(120, 22);
            this.Cradius.TabIndex = 6;
            // 
            // Cangle
            // 
            this.Cangle.DecimalPlaces = 5;
            this.Cangle.Location = new System.Drawing.Point(0, 45);
            this.Cangle.Name = "Cangle";
            this.Cangle.Size = new System.Drawing.Size(120, 22);
            this.Cangle.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ответ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Aangle);
            this.groupBox1.Controls.Add(this.Aradius);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 78);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bangle);
            this.groupBox2.Controls.Add(this.Bradius);
            this.groupBox2.Location = new System.Drawing.Point(190, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 78);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cangle);
            this.groupBox3.Controls.Add(this.Cradius);
            this.groupBox3.Location = new System.Drawing.Point(358, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 78);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "C";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(605, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 444);
            this.panel1.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(196, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Визуализация.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Aradius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bradius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cradius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cangle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Aradius;
        private System.Windows.Forms.NumericUpDown Aangle;
        private System.Windows.Forms.NumericUpDown Bradius;
        private System.Windows.Forms.NumericUpDown Bangle;
        private System.Windows.Forms.NumericUpDown Cradius;
        private System.Windows.Forms.NumericUpDown Cangle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}

