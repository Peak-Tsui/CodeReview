namespace CodeReview.View
{
    partial class RecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordForm));
            this.txtCodeContent = new System.Windows.Forms.TextBox();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuggest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFixer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFixTime = new System.Windows.Forms.DateTimePicker();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodeContent
            // 
            this.txtCodeContent.Location = new System.Drawing.Point(46, 44);
            this.txtCodeContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeContent.Multiline = true;
            this.txtCodeContent.Name = "txtCodeContent";
            this.txtCodeContent.Size = new System.Drawing.Size(577, 197);
            this.txtCodeContent.TabIndex = 0;
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(46, 4);
            this.txtMethodName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(577, 21);
            this.txtMethodName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "函数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "代码:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(46, 259);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(577, 66);
            this.txtQuestion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "问题:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "建议:";
            // 
            // txtSuggest
            // 
            this.txtSuggest.Location = new System.Drawing.Point(46, 340);
            this.txtSuggest.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuggest.Multiline = true;
            this.txtSuggest.Name = "txtSuggest";
            this.txtSuggest.Size = new System.Drawing.Size(577, 66);
            this.txtSuggest.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "修改人:";
            // 
            // txtFixer
            // 
            this.txtFixer.Location = new System.Drawing.Point(48, 424);
            this.txtFixer.Margin = new System.Windows.Forms.Padding(2);
            this.txtFixer.Name = "txtFixer";
            this.txtFixer.Size = new System.Drawing.Size(93, 21);
            this.txtFixer.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 428);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "修改时间:";
            // 
            // dateFixTime
            // 
            this.dateFixTime.Location = new System.Drawing.Point(263, 424);
            this.dateFixTime.Margin = new System.Windows.Forms.Padding(2);
            this.dateFixTime.Name = "dateFixTime";
            this.dateFixTime.Size = new System.Drawing.Size(151, 21);
            this.dateFixTime.TabIndex = 8;
            // 
            // btnSure
            // 
            this.btnSure.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSure.Location = new System.Drawing.Point(194, 466);
            this.btnSure.Margin = new System.Windows.Forms.Padding(2);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(70, 34);
            this.btnSure.TabIndex = 9;
            this.btnSure.Text = "确认";
            this.btnSure.UseVisualStyleBackColor = false;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(330, 466);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RecordForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 511);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.dateFixTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFixer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSuggest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMethodName);
            this.Controls.Add(this.txtCodeContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RecordForm";
            this.Text = "RecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodeContent;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuggest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFixer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFixTime;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnCancel;
    }
}