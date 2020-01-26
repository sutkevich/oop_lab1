namespace oop1
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
            this.LetItSnow = new System.Windows.Forms.Button();
            this.pB_withPicture = new System.Windows.Forms.PictureBox();
            this.PushMe = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cB_withShapes = new System.Windows.Forms.ComboBox();
            this.gB_withColors = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rB_green = new System.Windows.Forms.RadioButton();
            this.rB_blue = new System.Windows.Forms.RadioButton();
            this.rB_red = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pB_withShapes = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelForWhistler = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelForWhistler2 = new System.Windows.Forms.Label();
            this.labelForProgBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_withPicture)).BeginInit();
            this.gB_withColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_withShapes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LetItSnow
            // 
            this.LetItSnow.BackgroundImage = global::oop1.Properties.Resources.snow;
            this.LetItSnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LetItSnow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LetItSnow.Location = new System.Drawing.Point(12, 141);
            this.LetItSnow.Name = "LetItSnow";
            this.LetItSnow.Size = new System.Drawing.Size(167, 42);
            this.LetItSnow.TabIndex = 0;
            this.LetItSnow.Text = "Let it snow";
            this.LetItSnow.UseVisualStyleBackColor = true;
            this.LetItSnow.Click += new System.EventHandler(this.LetItSnow_Click);
            // 
            // pB_withPicture
            // 
            this.pB_withPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pB_withPicture.Location = new System.Drawing.Point(0, 0);
            this.pB_withPicture.Name = "pB_withPicture";
            this.pB_withPicture.Size = new System.Drawing.Size(532, 348);
            this.pB_withPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_withPicture.TabIndex = 1;
            this.pB_withPicture.TabStop = false;
            this.pB_withPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pB_withPicture_MouseDown);
            // 
            // PushMe
            // 
            this.PushMe.BackColor = System.Drawing.SystemColors.Control;
            this.PushMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PushMe.Location = new System.Drawing.Point(12, 12);
            this.PushMe.Name = "PushMe";
            this.PushMe.Size = new System.Drawing.Size(167, 62);
            this.PushMe.TabIndex = 2;
            this.PushMe.Text = "Push me";
            this.PushMe.UseVisualStyleBackColor = false;
            this.PushMe.Click += new System.EventHandler(this.PushMe_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 13);
            this.textBox2.TabIndex = 4;
            // 
            // cB_withShapes
            // 
            this.cB_withShapes.FormattingEnabled = true;
            this.cB_withShapes.Items.AddRange(new object[] {
            "ellips",
            "rectangle"});
            this.cB_withShapes.Location = new System.Drawing.Point(359, 12);
            this.cB_withShapes.Name = "cB_withShapes";
            this.cB_withShapes.Size = new System.Drawing.Size(160, 21);
            this.cB_withShapes.TabIndex = 5;
            this.cB_withShapes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gB_withColors
            // 
            this.gB_withColors.Controls.Add(this.checkBox1);
            this.gB_withColors.Controls.Add(this.rB_green);
            this.gB_withColors.Controls.Add(this.rB_blue);
            this.gB_withColors.Controls.Add(this.rB_red);
            this.gB_withColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gB_withColors.Location = new System.Drawing.Point(196, 12);
            this.gB_withColors.Name = "gB_withColors";
            this.gB_withColors.Size = new System.Drawing.Size(145, 145);
            this.gB_withColors.TabIndex = 6;
            this.gB_withColors.TabStop = false;
            this.gB_withColors.Text = "Pick the color";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "fill the shape";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rB_green
            // 
            this.rB_green.AutoSize = true;
            this.rB_green.ForeColor = System.Drawing.Color.Green;
            this.rB_green.Location = new System.Drawing.Point(23, 68);
            this.rB_green.Name = "rB_green";
            this.rB_green.Size = new System.Drawing.Size(66, 20);
            this.rB_green.TabIndex = 2;
            this.rB_green.TabStop = true;
            this.rB_green.Text = "green";
            this.rB_green.UseVisualStyleBackColor = true;
            // 
            // rB_blue
            // 
            this.rB_blue.AutoSize = true;
            this.rB_blue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rB_blue.Location = new System.Drawing.Point(23, 44);
            this.rB_blue.Name = "rB_blue";
            this.rB_blue.Size = new System.Drawing.Size(56, 20);
            this.rB_blue.TabIndex = 1;
            this.rB_blue.TabStop = true;
            this.rB_blue.Text = "blue";
            this.rB_blue.UseVisualStyleBackColor = true;
            // 
            // rB_red
            // 
            this.rB_red.AutoSize = true;
            this.rB_red.ForeColor = System.Drawing.Color.Red;
            this.rB_red.Location = new System.Drawing.Point(23, 20);
            this.rB_red.Name = "rB_red";
            this.rB_red.Size = new System.Drawing.Size(49, 20);
            this.rB_red.TabIndex = 0;
            this.rB_red.TabStop = true;
            this.rB_red.Text = "red";
            this.rB_red.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 320);
            this.progressBar.Maximum = 20;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(507, 16);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 7;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // pB_withShapes
            // 
            this.pB_withShapes.Location = new System.Drawing.Point(359, 39);
            this.pB_withShapes.Name = "pB_withShapes";
            this.pB_withShapes.Size = new System.Drawing.Size(160, 186);
            this.pB_withShapes.TabIndex = 8;
            this.pB_withShapes.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(196, 212);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelForWhistler
            // 
            this.labelForWhistler.AutoSize = true;
            this.labelForWhistler.Location = new System.Drawing.Point(12, 212);
            this.labelForWhistler.Name = "labelForWhistler";
            this.labelForWhistler.Size = new System.Drawing.Size(168, 13);
            this.labelForWhistler.TabIndex = 10;
            this.labelForWhistler.Text = "Count to 3 and see what happend";
            this.labelForWhistler.Click += new System.EventHandler(this.labelForWhistler_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 265);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(214, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "You probably understand, what\'s going on...";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelForWhistler2
            // 
            this.labelForWhistler2.AutoSize = true;
            this.labelForWhistler2.Location = new System.Drawing.Point(12, 239);
            this.labelForWhistler2.Name = "labelForWhistler2";
            this.labelForWhistler2.Size = new System.Drawing.Size(80, 13);
            this.labelForWhistler2.TabIndex = 12;
            this.labelForWhistler2.Text = "Now count to 6";
            this.labelForWhistler2.Visible = false;
            // 
            // labelForProgBar
            // 
            this.labelForProgBar.AutoSize = true;
            this.labelForProgBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForProgBar.Location = new System.Drawing.Point(131, 301);
            this.labelForProgBar.Name = "labelForProgBar";
            this.labelForProgBar.Size = new System.Drawing.Size(268, 16);
            this.labelForProgBar.TabIndex = 13;
            this.labelForProgBar.Text = "You clicked 20 times, maybe enough?";
            this.labelForProgBar.Visible = false;
            this.labelForProgBar.VisibleChanged += new System.EventHandler(this.labelForProgBar_VisibleChanged);
            this.labelForProgBar.Click += new System.EventHandler(this.labelForProgBar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 348);
            this.Controls.Add(this.labelForProgBar);
            this.Controls.Add(this.labelForWhistler2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelForWhistler);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pB_withShapes);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.gB_withColors);
            this.Controls.Add(this.cB_withShapes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PushMe);
            this.Controls.Add(this.LetItSnow);
            this.Controls.Add(this.pB_withPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB_withPicture)).EndInit();
            this.gB_withColors.ResumeLayout(false);
            this.gB_withColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_withShapes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LetItSnow;
        private System.Windows.Forms.PictureBox pB_withPicture;
        private System.Windows.Forms.Button PushMe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cB_withShapes;
        private System.Windows.Forms.GroupBox gB_withColors;
        private System.Windows.Forms.RadioButton rB_green;
        private System.Windows.Forms.RadioButton rB_blue;
        private System.Windows.Forms.RadioButton rB_red;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pB_withShapes;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelForWhistler;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelForWhistler2;
        private System.Windows.Forms.Label labelForProgBar;
    }
}

