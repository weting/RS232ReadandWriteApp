
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
            this.SuspendLayout();
            // 
            // port_printer
            // 
            this.port_printer.BaudRate = 4800;
            this.port_printer.PortName = "COM3";
            this.port_printer.ReadTimeout = 500;
            this.port_printer.WriteTimeout = 500;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(31, 26);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(85, 39);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "連線";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txtbx_portlist
            // 
            this.txtbx_portlist.Location = new System.Drawing.Point(361, 71);
            this.txtbx_portlist.Multiline = true;
            this.txtbx_portlist.Name = "txtbx_portlist";
            this.txtbx_portlist.ReadOnly = true;
            this.txtbx_portlist.Size = new System.Drawing.Size(183, 173);
            this.txtbx_portlist.TabIndex = 1;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(31, 97);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(85, 41);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "列印";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txtbx_portlist);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "RS232 Printer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port_printer;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txtbx_portlist;
        private System.Windows.Forms.Button btn_print;
    }
}

