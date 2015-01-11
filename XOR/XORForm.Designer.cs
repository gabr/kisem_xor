namespace XOR
{
    partial class XORForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XORForm));
            this.button_Train = new System.Windows.Forms.Button();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.button_RandomWeight = new System.Windows.Forms.Button();
            this.textBox_n2s = new System.Windows.Forms.TextBox();
            this.textBox_n1s = new System.Windows.Forms.TextBox();
            this.textBox_n0s = new System.Windows.Forms.TextBox();
            this.textBox_n2out = new System.Windows.Forms.TextBox();
            this.textBox_n1out = new System.Windows.Forms.TextBox();
            this.textBox_n0out = new System.Windows.Forms.TextBox();
            this.textBox_in1 = new System.Windows.Forms.TextBox();
            this.textBox_in0 = new System.Windows.Forms.TextBox();
            this.textBox_n2w2 = new System.Windows.Forms.TextBox();
            this.textBox_n2w1 = new System.Windows.Forms.TextBox();
            this.textBox_n2s2 = new System.Windows.Forms.TextBox();
            this.textBox_n2s1 = new System.Windows.Forms.TextBox();
            this.textBox_n2s0 = new System.Windows.Forms.TextBox();
            this.textBox_n2w0 = new System.Windows.Forms.TextBox();
            this.textBox_n1w2 = new System.Windows.Forms.TextBox();
            this.textBox_n1w1 = new System.Windows.Forms.TextBox();
            this.textBox_n1s2 = new System.Windows.Forms.TextBox();
            this.textBox_n1s1 = new System.Windows.Forms.TextBox();
            this.textBox_n1s0 = new System.Windows.Forms.TextBox();
            this.textBox_n1w0 = new System.Windows.Forms.TextBox();
            this.textBox_n0w2 = new System.Windows.Forms.TextBox();
            this.textBox_n0w1 = new System.Windows.Forms.TextBox();
            this.textBox_n0s2 = new System.Windows.Forms.TextBox();
            this.textBox_n0s1 = new System.Windows.Forms.TextBox();
            this.textBox_n0s0 = new System.Windows.Forms.TextBox();
            this.textBox_n0w0 = new System.Windows.Forms.TextBox();
            this.pictureBoxNetwork = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetwork)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Train
            // 
            this.button_Train.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Train.Location = new System.Drawing.Point(880, 454);
            this.button_Train.Name = "button_Train";
            this.button_Train.Size = new System.Drawing.Size(179, 41);
            this.button_Train.TabIndex = 33;
            this.button_Train.Text = "Train";
            this.button_Train.UseVisualStyleBackColor = true;
            this.button_Train.Click += new System.EventHandler(this.button_Train_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Calculate.Location = new System.Drawing.Point(1065, 454);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(179, 41);
            this.button_Calculate.TabIndex = 32;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // button_RandomWeight
            // 
            this.button_RandomWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_RandomWeight.Location = new System.Drawing.Point(1065, 407);
            this.button_RandomWeight.Name = "button_RandomWeight";
            this.button_RandomWeight.Size = new System.Drawing.Size(179, 41);
            this.button_RandomWeight.TabIndex = 31;
            this.button_RandomWeight.Text = "Random weight";
            this.button_RandomWeight.UseVisualStyleBackColor = true;
            this.button_RandomWeight.Click += new System.EventHandler(this.button_RandomWeight_Click);
            // 
            // textBox_n2s
            // 
            this.textBox_n2s.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2s.Location = new System.Drawing.Point(890, 224);
            this.textBox_n2s.Name = "textBox_n2s";
            this.textBox_n2s.ReadOnly = true;
            this.textBox_n2s.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2s.TabIndex = 30;
            // 
            // textBox_n1s
            // 
            this.textBox_n1s.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1s.Location = new System.Drawing.Point(334, 367);
            this.textBox_n1s.Name = "textBox_n1s";
            this.textBox_n1s.ReadOnly = true;
            this.textBox_n1s.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1s.TabIndex = 29;
            // 
            // textBox_n0s
            // 
            this.textBox_n0s.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0s.Location = new System.Drawing.Point(334, 117);
            this.textBox_n0s.Name = "textBox_n0s";
            this.textBox_n0s.ReadOnly = true;
            this.textBox_n0s.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0s.TabIndex = 28;
            // 
            // textBox_n2out
            // 
            this.textBox_n2out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2out.Location = new System.Drawing.Point(1149, 224);
            this.textBox_n2out.Name = "textBox_n2out";
            this.textBox_n2out.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2out.TabIndex = 27;
            // 
            // textBox_n1out
            // 
            this.textBox_n1out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1out.Location = new System.Drawing.Point(537, 348);
            this.textBox_n1out.Name = "textBox_n1out";
            this.textBox_n1out.ReadOnly = true;
            this.textBox_n1out.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1out.TabIndex = 26;
            // 
            // textBox_n0out
            // 
            this.textBox_n0out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0out.Location = new System.Drawing.Point(537, 98);
            this.textBox_n0out.Name = "textBox_n0out";
            this.textBox_n0out.ReadOnly = true;
            this.textBox_n0out.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0out.TabIndex = 25;
            // 
            // textBox_in1
            // 
            this.textBox_in1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_in1.Location = new System.Drawing.Point(59, 148);
            this.textBox_in1.Name = "textBox_in1";
            this.textBox_in1.Size = new System.Drawing.Size(57, 27);
            this.textBox_in1.TabIndex = 21;
            // 
            // textBox_in0
            // 
            this.textBox_in0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_in0.Location = new System.Drawing.Point(59, 97);
            this.textBox_in0.Name = "textBox_in0";
            this.textBox_in0.Size = new System.Drawing.Size(57, 27);
            this.textBox_in0.TabIndex = 20;
            // 
            // textBox_n2w2
            // 
            this.textBox_n2w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2w2.Location = new System.Drawing.Point(712, 256);
            this.textBox_n2w2.Name = "textBox_n2w2";
            this.textBox_n2w2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2w2.TabIndex = 18;
            // 
            // textBox_n2w1
            // 
            this.textBox_n2w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2w1.Location = new System.Drawing.Point(712, 205);
            this.textBox_n2w1.Name = "textBox_n2w1";
            this.textBox_n2w1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2w1.TabIndex = 17;
            // 
            // textBox_n2s2
            // 
            this.textBox_n2s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2s2.Location = new System.Drawing.Point(801, 274);
            this.textBox_n2s2.Name = "textBox_n2s2";
            this.textBox_n2s2.ReadOnly = true;
            this.textBox_n2s2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2s2.TabIndex = 16;
            // 
            // textBox_n2s1
            // 
            this.textBox_n2s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2s1.Location = new System.Drawing.Point(801, 224);
            this.textBox_n2s1.Name = "textBox_n2s1";
            this.textBox_n2s1.ReadOnly = true;
            this.textBox_n2s1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2s1.TabIndex = 15;
            // 
            // textBox_n2s0
            // 
            this.textBox_n2s0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2s0.Location = new System.Drawing.Point(801, 173);
            this.textBox_n2s0.Name = "textBox_n2s0";
            this.textBox_n2s0.ReadOnly = true;
            this.textBox_n2s0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2s0.TabIndex = 14;
            // 
            // textBox_n2w0
            // 
            this.textBox_n2w0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2w0.Location = new System.Drawing.Point(712, 152);
            this.textBox_n2w0.Name = "textBox_n2w0";
            this.textBox_n2w0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2w0.TabIndex = 13;
            // 
            // textBox_n1w2
            // 
            this.textBox_n1w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1w2.Location = new System.Drawing.Point(169, 400);
            this.textBox_n1w2.Name = "textBox_n1w2";
            this.textBox_n1w2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1w2.TabIndex = 12;
            // 
            // textBox_n1w1
            // 
            this.textBox_n1w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1w1.Location = new System.Drawing.Point(169, 349);
            this.textBox_n1w1.Name = "textBox_n1w1";
            this.textBox_n1w1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1w1.TabIndex = 11;
            // 
            // textBox_n1s2
            // 
            this.textBox_n1s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1s2.Location = new System.Drawing.Point(246, 417);
            this.textBox_n1s2.Name = "textBox_n1s2";
            this.textBox_n1s2.ReadOnly = true;
            this.textBox_n1s2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1s2.TabIndex = 10;
            // 
            // textBox_n1s1
            // 
            this.textBox_n1s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1s1.Location = new System.Drawing.Point(246, 367);
            this.textBox_n1s1.Name = "textBox_n1s1";
            this.textBox_n1s1.ReadOnly = true;
            this.textBox_n1s1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1s1.TabIndex = 9;
            // 
            // textBox_n1s0
            // 
            this.textBox_n1s0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1s0.Location = new System.Drawing.Point(246, 316);
            this.textBox_n1s0.Name = "textBox_n1s0";
            this.textBox_n1s0.ReadOnly = true;
            this.textBox_n1s0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1s0.TabIndex = 8;
            // 
            // textBox_n1w0
            // 
            this.textBox_n1w0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1w0.Location = new System.Drawing.Point(169, 296);
            this.textBox_n1w0.Name = "textBox_n1w0";
            this.textBox_n1w0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1w0.TabIndex = 7;
            // 
            // textBox_n0w2
            // 
            this.textBox_n0w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0w2.Location = new System.Drawing.Point(169, 150);
            this.textBox_n0w2.Name = "textBox_n0w2";
            this.textBox_n0w2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0w2.TabIndex = 6;
            // 
            // textBox_n0w1
            // 
            this.textBox_n0w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0w1.Location = new System.Drawing.Point(169, 99);
            this.textBox_n0w1.Name = "textBox_n0w1";
            this.textBox_n0w1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0w1.TabIndex = 5;
            // 
            // textBox_n0s2
            // 
            this.textBox_n0s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0s2.Location = new System.Drawing.Point(246, 167);
            this.textBox_n0s2.Name = "textBox_n0s2";
            this.textBox_n0s2.ReadOnly = true;
            this.textBox_n0s2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0s2.TabIndex = 4;
            // 
            // textBox_n0s1
            // 
            this.textBox_n0s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0s1.Location = new System.Drawing.Point(246, 117);
            this.textBox_n0s1.Name = "textBox_n0s1";
            this.textBox_n0s1.ReadOnly = true;
            this.textBox_n0s1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0s1.TabIndex = 3;
            // 
            // textBox_n0s0
            // 
            this.textBox_n0s0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0s0.Location = new System.Drawing.Point(246, 66);
            this.textBox_n0s0.Name = "textBox_n0s0";
            this.textBox_n0s0.ReadOnly = true;
            this.textBox_n0s0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0s0.TabIndex = 2;
            // 
            // textBox_n0w0
            // 
            this.textBox_n0w0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0w0.Location = new System.Drawing.Point(169, 46);
            this.textBox_n0w0.Name = "textBox_n0w0";
            this.textBox_n0w0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0w0.TabIndex = 1;
            // 
            // pictureBoxNetwork
            // 
            this.pictureBoxNetwork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNetwork.BackgroundImage")));
            this.pictureBoxNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNetwork.InitialImage = null;
            this.pictureBoxNetwork.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxNetwork.Name = "pictureBoxNetwork";
            this.pictureBoxNetwork.Size = new System.Drawing.Size(1256, 483);
            this.pictureBoxNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNetwork.TabIndex = 0;
            this.pictureBoxNetwork.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1256, 24);
            this.menuStrip.TabIndex = 34;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // XORForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 507);
            this.Controls.Add(this.textBox_n2s);
            this.Controls.Add(this.button_Train);
            this.Controls.Add(this.textBox_n1s);
            this.Controls.Add(this.textBox_n0s);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.textBox_n2out);
            this.Controls.Add(this.button_RandomWeight);
            this.Controls.Add(this.textBox_n1out);
            this.Controls.Add(this.textBox_n0out);
            this.Controls.Add(this.textBox_n0s0);
            this.Controls.Add(this.textBox_in1);
            this.Controls.Add(this.textBox_n0w0);
            this.Controls.Add(this.textBox_in0);
            this.Controls.Add(this.textBox_n0s1);
            this.Controls.Add(this.textBox_n2w2);
            this.Controls.Add(this.textBox_n0s2);
            this.Controls.Add(this.textBox_n2w1);
            this.Controls.Add(this.textBox_n0w1);
            this.Controls.Add(this.textBox_n2s2);
            this.Controls.Add(this.textBox_n0w2);
            this.Controls.Add(this.textBox_n2s1);
            this.Controls.Add(this.textBox_n1w0);
            this.Controls.Add(this.textBox_n2s0);
            this.Controls.Add(this.textBox_n1s0);
            this.Controls.Add(this.textBox_n2w0);
            this.Controls.Add(this.textBox_n1s1);
            this.Controls.Add(this.textBox_n1w2);
            this.Controls.Add(this.textBox_n1s2);
            this.Controls.Add(this.textBox_n1w1);
            this.Controls.Add(this.pictureBoxNetwork);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "XORForm";
            this.Text = "Multilayer perceptron - XOR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetwork)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNetwork;
        private System.Windows.Forms.TextBox textBox_n2out;
        private System.Windows.Forms.TextBox textBox_n1out;
        private System.Windows.Forms.TextBox textBox_n0out;
        private System.Windows.Forms.TextBox textBox_in1;
        private System.Windows.Forms.TextBox textBox_in0;
        private System.Windows.Forms.TextBox textBox_n2w2;
        private System.Windows.Forms.TextBox textBox_n2w1;
        private System.Windows.Forms.TextBox textBox_n2s2;
        private System.Windows.Forms.TextBox textBox_n2s1;
        private System.Windows.Forms.TextBox textBox_n2s0;
        private System.Windows.Forms.TextBox textBox_n2w0;
        private System.Windows.Forms.TextBox textBox_n1w2;
        private System.Windows.Forms.TextBox textBox_n1w1;
        private System.Windows.Forms.TextBox textBox_n1s2;
        private System.Windows.Forms.TextBox textBox_n1s1;
        private System.Windows.Forms.TextBox textBox_n1s0;
        private System.Windows.Forms.TextBox textBox_n1w0;
        private System.Windows.Forms.TextBox textBox_n0w2;
        private System.Windows.Forms.TextBox textBox_n0w1;
        private System.Windows.Forms.TextBox textBox_n0s2;
        private System.Windows.Forms.TextBox textBox_n0s1;
        private System.Windows.Forms.TextBox textBox_n0s0;
        private System.Windows.Forms.TextBox textBox_n0w0;
        private System.Windows.Forms.TextBox textBox_n2s;
        private System.Windows.Forms.TextBox textBox_n1s;
        private System.Windows.Forms.TextBox textBox_n0s;
        private System.Windows.Forms.Button button_RandomWeight;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Button button_Train;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

