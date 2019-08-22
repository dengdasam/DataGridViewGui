namespace DataGridView
{
    partial class alterForm
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
            this.lblCourID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCourName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCourCredit = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCourRemark = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourID
            // 
            this.lblCourID.AutoSize = true;
            this.lblCourID.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCourID.Location = new System.Drawing.Point(22, 39);
            this.lblCourID.Name = "lblCourID";
            this.lblCourID.Size = new System.Drawing.Size(88, 25);
            this.lblCourID.TabIndex = 0;
            this.lblCourID.Text = "课程编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblCourName
            // 
            this.lblCourName.AutoSize = true;
            this.lblCourName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCourName.Location = new System.Drawing.Point(22, 93);
            this.lblCourName.Name = "lblCourName";
            this.lblCourName.Size = new System.Drawing.Size(88, 25);
            this.lblCourName.TabIndex = 0;
            this.lblCourName.Text = "课程名称";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 25);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblCourCredit
            // 
            this.lblCourCredit.AutoSize = true;
            this.lblCourCredit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCourCredit.Location = new System.Drawing.Point(22, 153);
            this.lblCourCredit.Name = "lblCourCredit";
            this.lblCourCredit.Size = new System.Drawing.Size(50, 25);
            this.lblCourCredit.TabIndex = 0;
            this.lblCourCredit.Text = "学分";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 25);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblCourRemark
            // 
            this.lblCourRemark.AutoSize = true;
            this.lblCourRemark.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCourRemark.Location = new System.Drawing.Point(22, 211);
            this.lblCourRemark.Name = "lblCourRemark";
            this.lblCourRemark.Size = new System.Drawing.Size(50, 25);
            this.lblCourRemark.TabIndex = 0;
            this.lblCourRemark.Text = "备注";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 211);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(259, 118);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(121, 374);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(282, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // alterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCourRemark);
            this.Controls.Add(this.lblCourCredit);
            this.Controls.Add(this.lblCourName);
            this.Controls.Add(this.lblCourID);
            this.Name = "alterForm";
            this.Text = "alterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCourName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCourCredit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCourRemark;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}