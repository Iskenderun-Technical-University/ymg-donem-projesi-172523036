﻿namespace WinForms_UI.Discount
{
    partial class FormDiscount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnly0 = new System.Windows.Forms.Button();
            this.btnOnly1 = new System.Windows.Forms.Button();
            this.btnChangeState = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbbTypeOfDiscount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbTypeOfDiscount);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 162);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İndirim";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(75, 98);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miktar :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(366, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "İndirim Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(298, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 50);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(75, 62);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(133, 20);
            this.txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kod :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // btnOnly0
            // 
            this.btnOnly0.Location = new System.Drawing.Point(689, 349);
            this.btnOnly0.Name = "btnOnly0";
            this.btnOnly0.Size = new System.Drawing.Size(224, 78);
            this.btnOnly0.TabIndex = 33;
            this.btnOnly0.Text = "Sadece Pasifleri Listele";
            this.btnOnly0.UseVisualStyleBackColor = true;
            // 
            // btnOnly1
            // 
            this.btnOnly1.Location = new System.Drawing.Point(689, 265);
            this.btnOnly1.Name = "btnOnly1";
            this.btnOnly1.Size = new System.Drawing.Size(224, 78);
            this.btnOnly1.TabIndex = 32;
            this.btnOnly1.Text = "Sadece Aktifleri Listele";
            this.btnOnly1.UseVisualStyleBackColor = true;
            // 
            // btnChangeState
            // 
            this.btnChangeState.Location = new System.Drawing.Point(689, 181);
            this.btnChangeState.Name = "btnChangeState";
            this.btnChangeState.Size = new System.Drawing.Size(224, 78);
            this.btnChangeState.TabIndex = 31;
            this.btnChangeState.Text = "Seçili İndirim Durumunu Değiştir";
            this.btnChangeState.UseVisualStyleBackColor = true;
            this.btnChangeState.Click += new System.EventHandler(this.btnChangeState_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(689, 97);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 78);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Seçili İndirimi Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(689, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(224, 78);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Seçili İndirimi Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(919, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 1056);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(689, 990);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 78);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbbTypeOfDiscount
            // 
            this.cbbTypeOfDiscount.FormattingEnabled = true;
            this.cbbTypeOfDiscount.Location = new System.Drawing.Point(75, 129);
            this.cbbTypeOfDiscount.Name = "cbbTypeOfDiscount";
            this.cbbTypeOfDiscount.Size = new System.Drawing.Size(133, 21);
            this.cbbTypeOfDiscount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "İndirim Tür :";
            // 
            // FormDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOnly0);
            this.Controls.Add(this.btnOnly1);
            this.Controls.Add(this.btnChangeState);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiscount";
            this.Text = "FormDiscount";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormDiscount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnly0;
        private System.Windows.Forms.Button btnOnly1;
        private System.Windows.Forms.Button btnChangeState;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTypeOfDiscount;
    }
}