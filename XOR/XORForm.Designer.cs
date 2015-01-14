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
            this.button_ManualTrain = new System.Windows.Forms.Button();
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
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.label_trainCoef = new System.Windows.Forms.Label();
            this.textBox_trainCoef = new System.Windows.Forms.TextBox();
            this.button_AutoTrain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_trainError = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_trainMaxSteps = new System.Windows.Forms.TextBox();
            this.textBox_trainData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetwork)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ManualTrain
            // 
            this.button_ManualTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ManualTrain.Location = new System.Drawing.Point(1065, 454);
            this.button_ManualTrain.Name = "button_ManualTrain";
            this.button_ManualTrain.Size = new System.Drawing.Size(179, 41);
            this.button_ManualTrain.TabIndex = 33;
            this.button_ManualTrain.Text = "Manual Train";
            this.button_ManualTrain.UseVisualStyleBackColor = true;
            this.button_ManualTrain.Click += new System.EventHandler(this.button_ManualTrain_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Calculate.Location = new System.Drawing.Point(1065, 91);
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
            this.button_RandomWeight.Location = new System.Drawing.Point(1065, 44);
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
            this.textBox_n2s.Location = new System.Drawing.Point(890, 236);
            this.textBox_n2s.Name = "textBox_n2s";
            this.textBox_n2s.ReadOnly = true;
            this.textBox_n2s.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2s.TabIndex = 30;
            // 
            // textBox_n1s
            // 
            this.textBox_n1s.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1s.Location = new System.Drawing.Point(334, 379);
            this.textBox_n1s.Name = "textBox_n1s";
            this.textBox_n1s.ReadOnly = true;
            this.textBox_n1s.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1s.TabIndex = 29;
            // 
            // textBox_n0s
            // 
            this.textBox_n0s.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0s.Location = new System.Drawing.Point(334, 129);
            this.textBox_n0s.Name = "textBox_n0s";
            this.textBox_n0s.ReadOnly = true;
            this.textBox_n0s.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0s.TabIndex = 28;
            // 
            // textBox_n2out
            // 
            this.textBox_n2out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2out.Location = new System.Drawing.Point(1149, 236);
            this.textBox_n2out.Name = "textBox_n2out";
            this.textBox_n2out.ReadOnly = true;
            this.textBox_n2out.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2out.TabIndex = 27;
            // 
            // textBox_n1out
            // 
            this.textBox_n1out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1out.Location = new System.Drawing.Point(537, 360);
            this.textBox_n1out.Name = "textBox_n1out";
            this.textBox_n1out.ReadOnly = true;
            this.textBox_n1out.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1out.TabIndex = 26;
            // 
            // textBox_n0out
            // 
            this.textBox_n0out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0out.Location = new System.Drawing.Point(537, 110);
            this.textBox_n0out.Name = "textBox_n0out";
            this.textBox_n0out.ReadOnly = true;
            this.textBox_n0out.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0out.TabIndex = 25;
            // 
            // textBox_in1
            // 
            this.textBox_in1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_in1.Location = new System.Drawing.Point(59, 160);
            this.textBox_in1.Name = "textBox_in1";
            this.textBox_in1.Size = new System.Drawing.Size(57, 27);
            this.textBox_in1.TabIndex = 21;
            // 
            // textBox_in0
            // 
            this.textBox_in0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_in0.Location = new System.Drawing.Point(59, 109);
            this.textBox_in0.Name = "textBox_in0";
            this.textBox_in0.Size = new System.Drawing.Size(57, 27);
            this.textBox_in0.TabIndex = 20;
            // 
            // textBox_n2w2
            // 
            this.textBox_n2w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2w2.Location = new System.Drawing.Point(712, 268);
            this.textBox_n2w2.Name = "textBox_n2w2";
            this.textBox_n2w2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2w2.TabIndex = 18;
            // 
            // textBox_n2w1
            // 
            this.textBox_n2w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2w1.Location = new System.Drawing.Point(712, 217);
            this.textBox_n2w1.Name = "textBox_n2w1";
            this.textBox_n2w1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2w1.TabIndex = 17;
            // 
            // textBox_n2s2
            // 
            this.textBox_n2s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2s2.Location = new System.Drawing.Point(801, 286);
            this.textBox_n2s2.Name = "textBox_n2s2";
            this.textBox_n2s2.ReadOnly = true;
            this.textBox_n2s2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2s2.TabIndex = 16;
            // 
            // textBox_n2s1
            // 
            this.textBox_n2s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2s1.Location = new System.Drawing.Point(801, 236);
            this.textBox_n2s1.Name = "textBox_n2s1";
            this.textBox_n2s1.ReadOnly = true;
            this.textBox_n2s1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2s1.TabIndex = 15;
            // 
            // textBox_n2s0
            // 
            this.textBox_n2s0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2s0.Location = new System.Drawing.Point(801, 185);
            this.textBox_n2s0.Name = "textBox_n2s0";
            this.textBox_n2s0.ReadOnly = true;
            this.textBox_n2s0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2s0.TabIndex = 14;
            // 
            // textBox_n2w0
            // 
            this.textBox_n2w0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n2w0.Location = new System.Drawing.Point(712, 164);
            this.textBox_n2w0.Name = "textBox_n2w0";
            this.textBox_n2w0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n2w0.TabIndex = 13;
            // 
            // textBox_n1w2
            // 
            this.textBox_n1w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1w2.Location = new System.Drawing.Point(169, 412);
            this.textBox_n1w2.Name = "textBox_n1w2";
            this.textBox_n1w2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1w2.TabIndex = 12;
            // 
            // textBox_n1w1
            // 
            this.textBox_n1w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1w1.Location = new System.Drawing.Point(169, 361);
            this.textBox_n1w1.Name = "textBox_n1w1";
            this.textBox_n1w1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1w1.TabIndex = 11;
            // 
            // textBox_n1s2
            // 
            this.textBox_n1s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1s2.Location = new System.Drawing.Point(246, 429);
            this.textBox_n1s2.Name = "textBox_n1s2";
            this.textBox_n1s2.ReadOnly = true;
            this.textBox_n1s2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1s2.TabIndex = 10;
            // 
            // textBox_n1s1
            // 
            this.textBox_n1s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1s1.Location = new System.Drawing.Point(246, 379);
            this.textBox_n1s1.Name = "textBox_n1s1";
            this.textBox_n1s1.ReadOnly = true;
            this.textBox_n1s1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1s1.TabIndex = 9;
            // 
            // textBox_n1s0
            // 
            this.textBox_n1s0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1s0.Location = new System.Drawing.Point(246, 328);
            this.textBox_n1s0.Name = "textBox_n1s0";
            this.textBox_n1s0.ReadOnly = true;
            this.textBox_n1s0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1s0.TabIndex = 8;
            // 
            // textBox_n1w0
            // 
            this.textBox_n1w0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n1w0.Location = new System.Drawing.Point(169, 308);
            this.textBox_n1w0.Name = "textBox_n1w0";
            this.textBox_n1w0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n1w0.TabIndex = 7;
            // 
            // textBox_n0w2
            // 
            this.textBox_n0w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0w2.Location = new System.Drawing.Point(169, 162);
            this.textBox_n0w2.Name = "textBox_n0w2";
            this.textBox_n0w2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0w2.TabIndex = 6;
            // 
            // textBox_n0w1
            // 
            this.textBox_n0w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0w1.Location = new System.Drawing.Point(169, 111);
            this.textBox_n0w1.Name = "textBox_n0w1";
            this.textBox_n0w1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0w1.TabIndex = 5;
            // 
            // textBox_n0s2
            // 
            this.textBox_n0s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0s2.Location = new System.Drawing.Point(246, 179);
            this.textBox_n0s2.Name = "textBox_n0s2";
            this.textBox_n0s2.ReadOnly = true;
            this.textBox_n0s2.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0s2.TabIndex = 4;
            // 
            // textBox_n0s1
            // 
            this.textBox_n0s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0s1.Location = new System.Drawing.Point(246, 129);
            this.textBox_n0s1.Name = "textBox_n0s1";
            this.textBox_n0s1.ReadOnly = true;
            this.textBox_n0s1.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0s1.TabIndex = 3;
            // 
            // textBox_n0s0
            // 
            this.textBox_n0s0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0s0.Location = new System.Drawing.Point(246, 78);
            this.textBox_n0s0.Name = "textBox_n0s0";
            this.textBox_n0s0.ReadOnly = true;
            this.textBox_n0s0.Size = new System.Drawing.Size(57, 27);
            this.textBox_n0s0.TabIndex = 2;
            // 
            // textBox_n0w0
            // 
            this.textBox_n0w0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_n0w0.Location = new System.Drawing.Point(169, 58);
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
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_result.Location = new System.Drawing.Point(1187, 421);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(57, 27);
            this.textBox_result.TabIndex = 35;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_result.Location = new System.Drawing.Point(1115, 424);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(66, 22);
            this.label_result.TabIndex = 36;
            this.label_result.Text = "Result:";
            // 
            // label_trainCoef
            // 
            this.label_trainCoef.AutoSize = true;
            this.label_trainCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_trainCoef.Location = new System.Drawing.Point(1085, 392);
            this.label_trainCoef.Name = "label_trainCoef";
            this.label_trainCoef.Size = new System.Drawing.Size(96, 22);
            this.label_trainCoef.TabIndex = 38;
            this.label_trainCoef.Text = "Train coef:";
            // 
            // textBox_trainCoef
            // 
            this.textBox_trainCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_trainCoef.Location = new System.Drawing.Point(1187, 389);
            this.textBox_trainCoef.Name = "textBox_trainCoef";
            this.textBox_trainCoef.Size = new System.Drawing.Size(57, 27);
            this.textBox_trainCoef.TabIndex = 37;
            // 
            // button_AutoTrain
            // 
            this.button_AutoTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AutoTrain.Location = new System.Drawing.Point(880, 454);
            this.button_AutoTrain.Name = "button_AutoTrain";
            this.button_AutoTrain.Size = new System.Drawing.Size(179, 41);
            this.button_AutoTrain.TabIndex = 39;
            this.button_AutoTrain.Text = "Auto Train";
            this.button_AutoTrain.UseVisualStyleBackColor = true;
            this.button_AutoTrain.Click += new System.EventHandler(this.button_AutoTrain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(930, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Error:";
            // 
            // textBox_trainError
            // 
            this.textBox_trainError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_trainError.Location = new System.Drawing.Point(1002, 389);
            this.textBox_trainError.Name = "textBox_trainError";
            this.textBox_trainError.Size = new System.Drawing.Size(57, 27);
            this.textBox_trainError.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(889, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Max steps:";
            // 
            // textBox_trainMaxSteps
            // 
            this.textBox_trainMaxSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_trainMaxSteps.Location = new System.Drawing.Point(1002, 421);
            this.textBox_trainMaxSteps.Name = "textBox_trainMaxSteps";
            this.textBox_trainMaxSteps.Size = new System.Drawing.Size(57, 27);
            this.textBox_trainMaxSteps.TabIndex = 40;
            // 
            // textBox_trainData
            // 
            this.textBox_trainData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_trainData.Location = new System.Drawing.Point(748, 386);
            this.textBox_trainData.Multiline = true;
            this.textBox_trainData.Name = "textBox_trainData";
            this.textBox_trainData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_trainData.Size = new System.Drawing.Size(126, 109);
            this.textBox_trainData.TabIndex = 44;
            // 
            // XORForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 507);
            this.Controls.Add(this.textBox_trainData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_trainError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_trainMaxSteps);
            this.Controls.Add(this.button_AutoTrain);
            this.Controls.Add(this.label_trainCoef);
            this.Controls.Add(this.textBox_trainCoef);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_n2s);
            this.Controls.Add(this.button_ManualTrain);
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
        private System.Windows.Forms.Button button_ManualTrain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_trainCoef;
        private System.Windows.Forms.TextBox textBox_trainCoef;
        private System.Windows.Forms.Button button_AutoTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_trainError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_trainMaxSteps;
        private System.Windows.Forms.TextBox textBox_trainData;
    }
}

