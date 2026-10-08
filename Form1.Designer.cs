namespace Laba16 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dgvRaw = new DataGridView();
            dgvSummary = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRaw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            SuspendLayout();
            // 
            // dgvRaw
            // 
            dgvRaw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaw.Location = new Point(33, 109);
            dgvRaw.Name = "dgvRaw";
            dgvRaw.RowHeadersWidth = 82;
            dgvRaw.Size = new Size(610, 641);
            dgvRaw.TabIndex = 0;
            // 
            // dgvSummary
            // 
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Location = new Point(710, 109);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.RowHeadersWidth = 82;
            dgvSummary.Size = new Size(500, 641);
            dgvSummary.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(33, 799);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(269, 46);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Загрузить данные";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 899);
            Controls.Add(btnLoad);
            Controls.Add(dgvSummary);
            Controls.Add(dgvRaw);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRaw).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRaw;
        private DataGridView dgvSummary;
        private Button btnLoad;
    }
}
