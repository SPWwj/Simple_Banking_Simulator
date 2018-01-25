namespace MiniProj
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccPin = new System.Windows.Forms.TextBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.groupReg = new System.Windows.Forms.GroupBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnRegClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegAccDeposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegPin = new System.Windows.Forms.TextBox();
            this.txtRegAccNo = new System.Windows.Forms.TextBox();
            this.panelKeypad = new System.Windows.Forms.Panel();
            this.groupKeyPad = new System.Windows.Forms.GroupBox();
            this.btnOverdraft = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelKeypad = new System.Windows.Forms.Label();
            this.groupCustomerNavi = new System.Windows.Forms.GroupBox();
            this.btnInterest = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegAccName = new System.Windows.Forms.TextBox();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.groupReg.SuspendLayout();
            this.panelKeypad.SuspendLayout();
            this.groupKeyPad.SuspendLayout();
            this.groupCustomerNavi.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAccPin);
            this.panel1.Controls.Add(this.txtAccNo);
            this.panel1.Location = new System.Drawing.Point(37, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 358);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registry";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(244, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 39);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 39);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account Number";
            // 
            // txtAccPin
            // 
            this.txtAccPin.Location = new System.Drawing.Point(155, 185);
            this.txtAccPin.Name = "txtAccPin";
            this.txtAccPin.Size = new System.Drawing.Size(100, 26);
            this.txtAccPin.TabIndex = 2;
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(155, 153);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(100, 26);
            this.txtAccNo.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.groupReg);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(848, 421);
            this.panelLogin.TabIndex = 2;
            // 
            // groupReg
            // 
            this.groupReg.Controls.Add(this.label7);
            this.groupReg.Controls.Add(this.cbAccType);
            this.groupReg.Controls.Add(this.label6);
            this.groupReg.Controls.Add(this.txtRegAccName);
            this.groupReg.Controls.Add(this.btnReg);
            this.groupReg.Controls.Add(this.btnRegClear);
            this.groupReg.Controls.Add(this.label5);
            this.groupReg.Controls.Add(this.txtRegAccDeposit);
            this.groupReg.Controls.Add(this.label1);
            this.groupReg.Controls.Add(this.label4);
            this.groupReg.Controls.Add(this.txtRegPin);
            this.groupReg.Controls.Add(this.txtRegAccNo);
            this.groupReg.Location = new System.Drawing.Point(435, 45);
            this.groupReg.Name = "groupReg";
            this.groupReg.Size = new System.Drawing.Size(359, 358);
            this.groupReg.TabIndex = 1;
            this.groupReg.TabStop = false;
            this.groupReg.Text = "Registry";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(72, 255);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(100, 39);
            this.btnReg.TabIndex = 13;
            this.btnReg.Text = "Registry";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnRegClear
            // 
            this.btnRegClear.Location = new System.Drawing.Point(208, 255);
            this.btnRegClear.Name = "btnRegClear";
            this.btnRegClear.Size = new System.Drawing.Size(100, 39);
            this.btnRegClear.TabIndex = 12;
            this.btnRegClear.Text = "Clear";
            this.btnRegClear.UseVisualStyleBackColor = true;
            this.btnRegClear.Click += new System.EventHandler(this.btnRegClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Account Deposit";
            // 
            // txtRegAccDeposit
            // 
            this.txtRegAccDeposit.Location = new System.Drawing.Point(208, 213);
            this.txtRegAccDeposit.Name = "txtRegAccDeposit";
            this.txtRegAccDeposit.Size = new System.Drawing.Size(100, 26);
            this.txtRegAccDeposit.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Account PIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Account Number";
            // 
            // txtRegPin
            // 
            this.txtRegPin.Location = new System.Drawing.Point(208, 179);
            this.txtRegPin.Name = "txtRegPin";
            this.txtRegPin.Size = new System.Drawing.Size(100, 26);
            this.txtRegPin.TabIndex = 7;
            // 
            // txtRegAccNo
            // 
            this.txtRegAccNo.Location = new System.Drawing.Point(208, 147);
            this.txtRegAccNo.Name = "txtRegAccNo";
            this.txtRegAccNo.Size = new System.Drawing.Size(100, 26);
            this.txtRegAccNo.TabIndex = 6;
            // 
            // panelKeypad
            // 
            this.panelKeypad.Controls.Add(this.groupKeyPad);
            this.panelKeypad.Controls.Add(this.labelKeypad);
            this.panelKeypad.Controls.Add(this.groupCustomerNavi);
            this.panelKeypad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKeypad.Location = new System.Drawing.Point(0, 0);
            this.panelKeypad.Name = "panelKeypad";
            this.panelKeypad.Size = new System.Drawing.Size(848, 421);
            this.panelKeypad.TabIndex = 2;
            // 
            // groupKeyPad
            // 
            this.groupKeyPad.Controls.Add(this.btnOverdraft);
            this.groupKeyPad.Controls.Add(this.btn9);
            this.groupKeyPad.Controls.Add(this.btn7);
            this.groupKeyPad.Controls.Add(this.btn6);
            this.groupKeyPad.Controls.Add(this.button10);
            this.groupKeyPad.Controls.Add(this.btn8);
            this.groupKeyPad.Controls.Add(this.btn5);
            this.groupKeyPad.Controls.Add(this.btnEnter);
            this.groupKeyPad.Controls.Add(this.btn0);
            this.groupKeyPad.Controls.Add(this.btn1);
            this.groupKeyPad.Controls.Add(this.btn4);
            this.groupKeyPad.Controls.Add(this.btnCancel);
            this.groupKeyPad.Controls.Add(this.button12);
            this.groupKeyPad.Controls.Add(this.btn2);
            this.groupKeyPad.Controls.Add(this.btn3);
            this.groupKeyPad.Controls.Add(this.btnClear);
            this.groupKeyPad.Location = new System.Drawing.Point(37, 168);
            this.groupKeyPad.Name = "groupKeyPad";
            this.groupKeyPad.Size = new System.Drawing.Size(466, 241);
            this.groupKeyPad.TabIndex = 20;
            this.groupKeyPad.TabStop = false;
            this.groupKeyPad.Text = "KeyPad";
            // 
            // btnOverdraft
            // 
            this.btnOverdraft.Location = new System.Drawing.Point(350, 168);
            this.btnOverdraft.Name = "btnOverdraft";
            this.btnOverdraft.Size = new System.Drawing.Size(85, 40);
            this.btnOverdraft.TabIndex = 16;
            this.btnOverdraft.Text = "Overdraft ";
            this.btnOverdraft.UseVisualStyleBackColor = true;
            this.btnOverdraft.Click += new System.EventHandler(this.btnOverdraft_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(238, 30);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 40);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(21, 30);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 40);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(238, 76);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 40);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(21, 168);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(85, 40);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(127, 30);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 40);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(127, 76);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 40);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(350, 122);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(85, 40);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(127, 168);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 40);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(21, 122);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(21, 76);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 40);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 40);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(238, 168);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(85, 40);
            this.button12.TabIndex = 12;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(127, 122);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(238, 122);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelKeypad
            // 
            this.labelKeypad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelKeypad.Location = new System.Drawing.Point(58, 45);
            this.labelKeypad.Name = "labelKeypad";
            this.labelKeypad.Size = new System.Drawing.Size(413, 119);
            this.labelKeypad.TabIndex = 9;
            // 
            // groupCustomerNavi
            // 
            this.groupCustomerNavi.Controls.Add(this.btnInterest);
            this.groupCustomerNavi.Controls.Add(this.btnDeposit);
            this.groupCustomerNavi.Controls.Add(this.btnBalance);
            this.groupCustomerNavi.Controls.Add(this.btnWithdraw);
            this.groupCustomerNavi.Controls.Add(this.btnBack);
            this.groupCustomerNavi.Location = new System.Drawing.Point(577, 60);
            this.groupCustomerNavi.Name = "groupCustomerNavi";
            this.groupCustomerNavi.Size = new System.Drawing.Size(164, 349);
            this.groupCustomerNavi.TabIndex = 21;
            this.groupCustomerNavi.TabStop = false;
            this.groupCustomerNavi.Text = "Choose an Action";
            // 
            // btnInterest
            // 
            this.btnInterest.Location = new System.Drawing.Point(17, 108);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(131, 51);
            this.btnInterest.TabIndex = 20;
            this.btnInterest.Text = "Monthly Interest";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(17, 222);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(131, 51);
            this.btnDeposit.TabIndex = 19;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(17, 51);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(131, 51);
            this.btnBalance.TabIndex = 17;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(17, 165);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(131, 51);
            this.btnWithdraw.TabIndex = 18;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 279);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 51);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Account Name";
            // 
            // txtRegAccName
            // 
            this.txtRegAccName.Location = new System.Drawing.Point(208, 114);
            this.txtRegAccName.Name = "txtRegAccName";
            this.txtRegAccName.Size = new System.Drawing.Size(100, 26);
            this.txtRegAccName.TabIndex = 14;
            // 
            // cbAccType
            // 
            this.cbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Location = new System.Drawing.Point(208, 78);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(121, 28);
            this.cbAccType.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Account Name";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(848, 421);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelKeypad);
            this.Controls.Add(this.panelLogin);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.groupReg.ResumeLayout(false);
            this.groupReg.PerformLayout();
            this.panelKeypad.ResumeLayout(false);
            this.groupKeyPad.ResumeLayout(false);
            this.groupCustomerNavi.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccPin;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelKeypad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label labelKeypad;
        private System.Windows.Forms.GroupBox groupKeyPad;
        private System.Windows.Forms.Button btnOverdraft;
        private System.Windows.Forms.GroupBox groupCustomerNavi;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupReg;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnRegClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegAccDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegPin;
        private System.Windows.Forms.TextBox txtRegAccNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegAccName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAccType;
    }
}

