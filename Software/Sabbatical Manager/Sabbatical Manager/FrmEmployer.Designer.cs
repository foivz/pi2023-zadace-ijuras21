namespace Sabbatical_Manager {
    partial class FrmEmployer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnRequest = new System.Windows.Forms.Button();
            this.dgvZahtjev = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(656, 23);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(109, 36);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Kreiraj novi zahtjev";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // dgvZahtjev
            // 
            this.dgvZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZahtjev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjev.Location = new System.Drawing.Point(50, 116);
            this.dgvZahtjev.Name = "dgvZahtjev";
            this.dgvZahtjev.Size = new System.Drawing.Size(714, 304);
            this.dgvZahtjev.TabIndex = 1;
            this.dgvZahtjev.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(803, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(50, 23);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(104, 36);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(173, 23);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(104, 36);
            this.btnObriši.TabIndex = 4;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            // 
            // FrmEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgvZahtjev);
            this.Controls.Add(this.btnRequest);
            this.Name = "FrmEmployer";
            this.Text = "Početna stranica - Djelatnik";
            this.Load += new System.EventHandler(this.FrmEmployer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView dgvZahtjev;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObriši;
    }
}