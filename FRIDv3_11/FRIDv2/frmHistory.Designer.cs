
namespace FRIDv2
{
    partial class frmHistory
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
            this.cbbIDCard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVao = new System.Windows.Forms.DataGridView();
            this.dgvRa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbIDCard
            // 
            this.cbbIDCard.FormattingEnabled = true;
            this.cbbIDCard.Items.AddRange(new object[] {
            "0903256196",
            "3305314201",
            "3305332624",
            "3305336533",
            "3305350594",
            "3305356597",
            "3305358913",
            "3305360172",
            "3305935531"});
            this.cbbIDCard.Location = new System.Drawing.Point(295, 57);
            this.cbbIDCard.Name = "cbbIDCard";
            this.cbbIDCard.Size = new System.Drawing.Size(170, 24);
            this.cbbIDCard.TabIndex = 0;
            this.cbbIDCard.SelectedIndexChanged += new System.EventHandler(this.cbbIDCard_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ID";
            // 
            // dgvVao
            // 
            this.dgvVao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVao.Location = new System.Drawing.Point(22, 118);
            this.dgvVao.Name = "dgvVao";
            this.dgvVao.RowHeadersWidth = 51;
            this.dgvVao.RowTemplate.Height = 24;
            this.dgvVao.Size = new System.Drawing.Size(345, 320);
            this.dgvVao.TabIndex = 2;
            // 
            // dgvRa
            // 
            this.dgvRa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRa.Location = new System.Drawing.Point(392, 118);
            this.dgvRa.Name = "dgvRa";
            this.dgvRa.RowHeadersWidth = 51;
            this.dgvRa.RowTemplate.Height = 24;
            this.dgvRa.Size = new System.Drawing.Size(347, 320);
            this.dgvRa.TabIndex = 3;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.dgvRa);
            this.Controls.Add(this.dgvVao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbIDCard);
            this.Name = "frmHistory";
            this.Text = "frmHistory";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbIDCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVao;
        private System.Windows.Forms.DataGridView dgvRa;
    }
}