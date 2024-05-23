
namespace DenGiaoThong
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
            this.components = new System.ComponentModel.Container();
            this.cbxComList = new System.Windows.Forms.ComboBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.lbConnectionState = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_R1 = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.lbDataReceive2 = new System.Windows.Forms.Label();
            this.lbDataReceive1 = new System.Windows.Forms.Label();
            this.lbTextE = new System.Windows.Forms.Label();
            this.lbTextD = new System.Windows.Forms.Label();
            this.btn_Y1 = new System.Windows.Forms.Button();
            this.btn_G1 = new System.Windows.Forms.Button();
            this.btn_G2 = new System.Windows.Forms.Button();
            this.btn_Y2 = new System.Windows.Forms.Button();
            this.btn_R2 = new System.Windows.Forms.Button();
            this.lbDataReceive0 = new System.Windows.Forms.Label();
            this.btn_Sang = new System.Windows.Forms.Button();
            this.btn_Toi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_G2x = new System.Windows.Forms.Button();
            this.btn_Y2x = new System.Windows.Forms.Button();
            this.btn_R2x = new System.Windows.Forms.Button();
            this.lbTextEx = new System.Windows.Forms.Label();
            this.lbTextDx = new System.Windows.Forms.Label();
            this.btn_G1x = new System.Windows.Forms.Button();
            this.btn_Y1x = new System.Windows.Forms.Button();
            this.btn_R1x = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxComList
            // 
            this.cbxComList.FormattingEnabled = true;
            this.cbxComList.Location = new System.Drawing.Point(22, 25);
            this.cbxComList.Margin = new System.Windows.Forms.Padding(4);
            this.cbxComList.Name = "cbxComList";
            this.cbxComList.Size = new System.Drawing.Size(180, 26);
            this.cbxComList.TabIndex = 0;
            this.cbxComList.DropDown += new System.EventHandler(this.cbxComList_DropDown);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.AutoSize = true;
            this.btnKetNoi.Enabled = false;
            this.btnKetNoi.Location = new System.Drawing.Point(222, 21);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(77, 35);
            this.btnKetNoi.TabIndex = 1;
            this.btnKetNoi.Text = "Connect";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbConnectionState
            // 
            this.lbConnectionState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbConnectionState.Location = new System.Drawing.Point(0, 858);
            this.lbConnectionState.Name = "lbConnectionState";
            this.lbConnectionState.Size = new System.Drawing.Size(889, 18);
            this.lbConnectionState.TabIndex = 2;
            this.lbConnectionState.Text = "Loading";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_R1
            // 
            this.btn_R1.Location = new System.Drawing.Point(236, 18);
            this.btn_R1.Name = "btn_R1";
            this.btn_R1.Size = new System.Drawing.Size(69, 65);
            this.btn_R1.TabIndex = 3;
            this.btn_R1.UseVisualStyleBackColor = true;
            this.btn_R1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(519, 18);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(95, 41);
            this.btnOFF.TabIndex = 3;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // lbDataReceive2
            // 
            this.lbDataReceive2.AutoSize = true;
            this.lbDataReceive2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDataReceive2.Location = new System.Drawing.Point(0, 840);
            this.lbDataReceive2.Name = "lbDataReceive2";
            this.lbDataReceive2.Size = new System.Drawing.Size(43, 18);
            this.lbDataReceive2.TabIndex = 4;
            this.lbDataReceive2.Text = "Data:";
            // 
            // lbDataReceive1
            // 
            this.lbDataReceive1.AutoSize = true;
            this.lbDataReceive1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDataReceive1.Location = new System.Drawing.Point(0, 822);
            this.lbDataReceive1.Name = "lbDataReceive1";
            this.lbDataReceive1.Size = new System.Drawing.Size(43, 18);
            this.lbDataReceive1.TabIndex = 5;
            this.lbDataReceive1.Text = "Data:";
            // 
            // lbTextE
            // 
            this.lbTextE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTextE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTextE.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextE.ForeColor = System.Drawing.Color.Red;
            this.lbTextE.Location = new System.Drawing.Point(556, 76);
            this.lbTextE.Name = "lbTextE";
            this.lbTextE.Size = new System.Drawing.Size(115, 72);
            this.lbTextE.TabIndex = 6;
            this.lbTextE.Text = "--";
            this.lbTextE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTextD
            // 
            this.lbTextD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTextD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTextD.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextD.ForeColor = System.Drawing.Color.Red;
            this.lbTextD.Location = new System.Drawing.Point(72, 158);
            this.lbTextD.Name = "lbTextD";
            this.lbTextD.Size = new System.Drawing.Size(115, 72);
            this.lbTextD.TabIndex = 6;
            this.lbTextD.Text = "--";
            this.lbTextD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Y1
            // 
            this.btn_Y1.Location = new System.Drawing.Point(236, 98);
            this.btn_Y1.Name = "btn_Y1";
            this.btn_Y1.Size = new System.Drawing.Size(69, 65);
            this.btn_Y1.TabIndex = 3;
            this.btn_Y1.UseVisualStyleBackColor = true;
            this.btn_Y1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_G1
            // 
            this.btn_G1.Location = new System.Drawing.Point(236, 178);
            this.btn_G1.Name = "btn_G1";
            this.btn_G1.Size = new System.Drawing.Size(69, 65);
            this.btn_G1.TabIndex = 3;
            this.btn_G1.UseVisualStyleBackColor = true;
            this.btn_G1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_G2
            // 
            this.btn_G2.Location = new System.Drawing.Point(722, 178);
            this.btn_G2.Name = "btn_G2";
            this.btn_G2.Size = new System.Drawing.Size(69, 65);
            this.btn_G2.TabIndex = 7;
            this.btn_G2.UseVisualStyleBackColor = true;
            // 
            // btn_Y2
            // 
            this.btn_Y2.Location = new System.Drawing.Point(628, 178);
            this.btn_Y2.Name = "btn_Y2";
            this.btn_Y2.Size = new System.Drawing.Size(69, 65);
            this.btn_Y2.TabIndex = 8;
            this.btn_Y2.UseVisualStyleBackColor = true;
            // 
            // btn_R2
            // 
            this.btn_R2.Location = new System.Drawing.Point(534, 178);
            this.btn_R2.Name = "btn_R2";
            this.btn_R2.Size = new System.Drawing.Size(69, 65);
            this.btn_R2.TabIndex = 9;
            this.btn_R2.UseVisualStyleBackColor = true;
            // 
            // lbDataReceive0
            // 
            this.lbDataReceive0.AutoSize = true;
            this.lbDataReceive0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDataReceive0.Location = new System.Drawing.Point(0, 804);
            this.lbDataReceive0.Name = "lbDataReceive0";
            this.lbDataReceive0.Size = new System.Drawing.Size(43, 18);
            this.lbDataReceive0.TabIndex = 11;
            this.lbDataReceive0.Text = "Data:";
            // 
            // btn_Sang
            // 
            this.btn_Sang.Location = new System.Drawing.Point(646, 18);
            this.btn_Sang.Name = "btn_Sang";
            this.btn_Sang.Size = new System.Drawing.Size(95, 41);
            this.btn_Sang.TabIndex = 3;
            this.btn_Sang.Text = "Sáng";
            this.btn_Sang.UseVisualStyleBackColor = true;
            this.btn_Sang.Click += new System.EventHandler(this.btn_Sang_Click);
            // 
            // btn_Toi
            // 
            this.btn_Toi.Location = new System.Drawing.Point(773, 18);
            this.btn_Toi.Name = "btn_Toi";
            this.btn_Toi.Size = new System.Drawing.Size(95, 41);
            this.btn_Toi.TabIndex = 3;
            this.btn_Toi.Text = "Tối";
            this.btn_Toi.UseVisualStyleBackColor = true;
            this.btn_Toi.Click += new System.EventHandler(this.btn_Toi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_G2x);
            this.panel1.Controls.Add(this.btn_Y2x);
            this.panel1.Controls.Add(this.btn_R2x);
            this.panel1.Controls.Add(this.lbTextEx);
            this.panel1.Controls.Add(this.lbTextDx);
            this.panel1.Controls.Add(this.btn_G1x);
            this.panel1.Controls.Add(this.btn_Y1x);
            this.panel1.Controls.Add(this.btn_R1x);
            this.panel1.Controls.Add(this.btn_G2);
            this.panel1.Controls.Add(this.btn_Y2);
            this.panel1.Controls.Add(this.btn_R2);
            this.panel1.Controls.Add(this.lbTextD);
            this.panel1.Controls.Add(this.lbTextE);
            this.panel1.Controls.Add(this.btn_G1);
            this.panel1.Controls.Add(this.btn_Y1);
            this.panel1.Controls.Add(this.btn_R1);
            this.panel1.Location = new System.Drawing.Point(23, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 728);
            this.panel1.TabIndex = 12;
            // 
            // btn_G2x
            // 
            this.btn_G2x.Location = new System.Drawing.Point(242, 468);
            this.btn_G2x.Name = "btn_G2x";
            this.btn_G2x.Size = new System.Drawing.Size(69, 65);
            this.btn_G2x.TabIndex = 15;
            this.btn_G2x.UseVisualStyleBackColor = true;
            // 
            // btn_Y2x
            // 
            this.btn_Y2x.Location = new System.Drawing.Point(148, 468);
            this.btn_Y2x.Name = "btn_Y2x";
            this.btn_Y2x.Size = new System.Drawing.Size(69, 65);
            this.btn_Y2x.TabIndex = 16;
            this.btn_Y2x.UseVisualStyleBackColor = true;
            // 
            // btn_R2x
            // 
            this.btn_R2x.Location = new System.Drawing.Point(54, 468);
            this.btn_R2x.Name = "btn_R2x";
            this.btn_R2x.Size = new System.Drawing.Size(69, 65);
            this.btn_R2x.TabIndex = 17;
            this.btn_R2x.UseVisualStyleBackColor = true;
            // 
            // lbTextEx
            // 
            this.lbTextEx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTextEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTextEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextEx.ForeColor = System.Drawing.Color.Red;
            this.lbTextEx.Location = new System.Drawing.Point(196, 568);
            this.lbTextEx.Name = "lbTextEx";
            this.lbTextEx.Size = new System.Drawing.Size(115, 72);
            this.lbTextEx.TabIndex = 14;
            this.lbTextEx.Text = "--";
            this.lbTextEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTextDx
            // 
            this.lbTextDx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTextDx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTextDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextDx.ForeColor = System.Drawing.Color.Red;
            this.lbTextDx.Location = new System.Drawing.Point(636, 482);
            this.lbTextDx.Name = "lbTextDx";
            this.lbTextDx.Size = new System.Drawing.Size(115, 72);
            this.lbTextDx.TabIndex = 13;
            this.lbTextDx.Text = "--";
            this.lbTextDx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_G1x
            // 
            this.btn_G1x.Location = new System.Drawing.Point(540, 628);
            this.btn_G1x.Name = "btn_G1x";
            this.btn_G1x.Size = new System.Drawing.Size(69, 65);
            this.btn_G1x.TabIndex = 10;
            this.btn_G1x.UseVisualStyleBackColor = true;
            // 
            // btn_Y1x
            // 
            this.btn_Y1x.Location = new System.Drawing.Point(540, 548);
            this.btn_Y1x.Name = "btn_Y1x";
            this.btn_Y1x.Size = new System.Drawing.Size(69, 65);
            this.btn_Y1x.TabIndex = 11;
            this.btn_Y1x.UseVisualStyleBackColor = true;
            // 
            // btn_R1x
            // 
            this.btn_R1x.Location = new System.Drawing.Point(540, 468);
            this.btn_R1x.Name = "btn_R1x";
            this.btn_R1x.Size = new System.Drawing.Size(69, 65);
            this.btn_R1x.TabIndex = 12;
            this.btn_R1x.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(889, 876);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDataReceive0);
            this.Controls.Add(this.lbDataReceive1);
            this.Controls.Add(this.lbDataReceive2);
            this.Controls.Add(this.btn_Toi);
            this.Controls.Add(this.btn_Sang);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.lbConnectionState);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.cbxComList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxComList;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Label lbConnectionState;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_R1;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Label lbDataReceive2;
        private System.Windows.Forms.Label lbDataReceive1;
        private System.Windows.Forms.Label lbTextE;
        private System.Windows.Forms.Label lbTextD;
        private System.Windows.Forms.Button btn_Y1;
        private System.Windows.Forms.Button btn_G1;
        private System.Windows.Forms.Button btn_G2;
        private System.Windows.Forms.Button btn_Y2;
        private System.Windows.Forms.Button btn_R2;
        private System.Windows.Forms.Label lbDataReceive0;
        private System.Windows.Forms.Button btn_Sang;
        private System.Windows.Forms.Button btn_Toi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTextDx;
        private System.Windows.Forms.Button btn_G1x;
        private System.Windows.Forms.Button btn_Y1x;
        private System.Windows.Forms.Button btn_R1x;
        private System.Windows.Forms.Button btn_G2x;
        private System.Windows.Forms.Button btn_Y2x;
        private System.Windows.Forms.Button btn_R2x;
        private System.Windows.Forms.Label lbTextEx;
    }
}

