namespace FrendlyPractice
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameKana = new System.Windows.Forms.Label();
            this.txtNameKana = new System.Windows.Forms.TextBox();
            this.flpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(409, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // flpMain
            // 
            this.flpMain.Controls.Add(this.btnClose);
            this.flpMain.Controls.Add(this.btnRegister);
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpMain.Location = new System.Drawing.Point(0, 153);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(512, 50);
            this.flpMain.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(303, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 40);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "氏名";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(205, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 31);
            this.txtName.TabIndex = 4;
            // 
            // lblNameKana
            // 
            this.lblNameKana.AutoSize = true;
            this.lblNameKana.Location = new System.Drawing.Point(39, 101);
            this.lblNameKana.Name = "lblNameKana";
            this.lblNameKana.Size = new System.Drawing.Size(140, 24);
            this.lblNameKana.TabIndex = 5;
            this.lblNameKana.Text = "氏名(フリガナ)";
            // 
            // txtNameKana
            // 
            this.txtNameKana.Location = new System.Drawing.Point(205, 101);
            this.txtNameKana.Name = "txtNameKana";
            this.txtNameKana.Size = new System.Drawing.Size(262, 31);
            this.txtNameKana.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 203);
            this.Controls.Add(this.txtNameKana);
            this.Controls.Add(this.lblNameKana);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.flpMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flpMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameKana;
        private System.Windows.Forms.TextBox txtNameKana;
    }
}

