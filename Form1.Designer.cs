
namespace RS232ReadandWriteApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.port_printer = new System.IO.Ports.SerialPort(this.components);
            this.btn_connect = new System.Windows.Forms.Button();
            this.txtbx_portlist = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.txtbx_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_list = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // port_printer
            // 
            this.port_printer.Handshake = System.IO.Ports.Handshake.RequestToSend;
            this.port_printer.PortName = "COM3";
            this.port_printer.ReadTimeout = 500;
            this.port_printer.RtsEnable = true;
            this.port_printer.WriteTimeout = 500;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(495, 370);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(85, 39);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "連線";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txtbx_portlist
            // 
            this.txtbx_portlist.Location = new System.Drawing.Point(495, 94);
            this.txtbx_portlist.Multiline = true;
            this.txtbx_portlist.Name = "txtbx_portlist";
            this.txtbx_portlist.ReadOnly = true;
            this.txtbx_portlist.Size = new System.Drawing.Size(183, 173);
            this.txtbx_portlist.TabIndex = 1;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(276, 383);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(85, 41);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "列印";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txtbx_
            // 
            this.txtbx_.Location = new System.Drawing.Point(49, 28);
            this.txtbx_.Name = "txtbx_";
            this.txtbx_.ReadOnly = true;
            this.txtbx_.Size = new System.Drawing.Size(123, 25);
            this.txtbx_.TabIndex = 3;
            this.txtbx_.Text = "阿立圓山運轉所";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "店面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "地址";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(270, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "台北市大同區承德路三段225巷18號3樓";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "電話";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(94, 25);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "02-2592-9000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "日期時間";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(94, 25);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "細項";
            // 
            // txtbx_list
            // 
            this.txtbx_list.Location = new System.Drawing.Point(9, 192);
            this.txtbx_list.Multiline = true;
            this.txtbx_list.Name = "txtbx_list";
            this.txtbx_list.Size = new System.Drawing.Size(324, 144);
            this.txtbx_list.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbx_);
            this.groupBox1.Controls.Add(this.txtbx_list);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 355);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txtbx_portlist);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "TP-7688 Printer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port_printer;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txtbx_portlist;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox txtbx_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_list;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

