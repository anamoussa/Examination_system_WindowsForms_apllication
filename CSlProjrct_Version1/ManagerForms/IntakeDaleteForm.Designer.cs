namespace CSlProjrct_Version1
{
    partial class IntakeDaleteForm
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DelByName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DelByNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNumber.Location = new System.Drawing.Point(580, 106);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(448, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Intake Number :";
            // 
            // btn_DelByName
            // 
            this.btn_DelByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_DelByName.Location = new System.Drawing.Point(526, 159);
            this.btn_DelByName.Name = "btn_DelByName";
            this.btn_DelByName.Size = new System.Drawing.Size(101, 41);
            this.btn_DelByName.TabIndex = 31;
            this.btn_DelByName.Text = "Delete by Name";
            this.btn_DelByName.UseVisualStyleBackColor = true;
            this.btn_DelByName.Click += new System.EventHandler(this.btn_DelByName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(381, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "OR";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtId.Location = new System.Drawing.Point(219, 106);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(87, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Intake ID :";
            // 
            // btn_DelByNum
            // 
            this.btn_DelByNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_DelByNum.Location = new System.Drawing.Point(165, 159);
            this.btn_DelByNum.Name = "btn_DelByNum";
            this.btn_DelByNum.Size = new System.Drawing.Size(101, 41);
            this.btn_DelByNum.TabIndex = 27;
            this.btn_DelByNum.Text = "Delete by ID";
            this.btn_DelByNum.UseVisualStyleBackColor = true;
            this.btn_DelByNum.Click += new System.EventHandler(this.btn_DelByNum_Click);
            // 
            // IntakeDaleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DelByName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DelByNum);
            this.Name = "IntakeDaleteForm";
            this.Text = "IntakeDaleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DelByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DelByNum;
    }
}