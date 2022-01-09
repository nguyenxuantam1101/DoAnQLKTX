
namespace QLKTX.GUI
{
    partial class frmNV_KyLuat
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
            this.dgvKyLuat = new System.Windows.Forms.DataGridView();
            this.txtMaKyLuat = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKyLuat
            // 
            this.dgvKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyLuat.Location = new System.Drawing.Point(12, 233);
            this.dgvKyLuat.Name = "dgvKyLuat";
            this.dgvKyLuat.Size = new System.Drawing.Size(776, 205);
            this.dgvKyLuat.TabIndex = 0;
            // 
            // txtMaKyLuat
            // 
            this.txtMaKyLuat.Location = new System.Drawing.Point(74, 37);
            this.txtMaKyLuat.Name = "txtMaKyLuat";
            this.txtMaKyLuat.Size = new System.Drawing.Size(100, 20);
            this.txtMaKyLuat.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // frmNV_KyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtMaKyLuat);
            this.Controls.Add(this.dgvKyLuat);
            this.Name = "frmNV_KyLuat";
            this.Text = "frmNV_KyLuat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyLuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKyLuat;
        private System.Windows.Forms.TextBox txtMaKyLuat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}