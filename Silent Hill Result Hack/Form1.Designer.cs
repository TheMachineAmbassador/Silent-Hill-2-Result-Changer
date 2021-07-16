
namespace Silent_Hill_Result_Hack
{
    partial class frm_firstOpen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_StartHack = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StartHack
            // 
            this.btn_StartHack.Location = new System.Drawing.Point(12, 91);
            this.btn_StartHack.Name = "btn_StartHack";
            this.btn_StartHack.Size = new System.Drawing.Size(133, 23);
            this.btn_StartHack.TabIndex = 0;
            this.btn_StartHack.Text = "Start Result Hack";
            this.btn_StartHack.UseVisualStyleBackColor = true;
            this.btn_StartHack.Click += new System.EventHandler(this.btn_StartHack_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(163, 91);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(109, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Status.Location = new System.Drawing.Point(9, 49);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(43, 13);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "label1";
            this.lbl_Status.Visible = false;
            // 
            // frm_firstOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_StartHack);
            this.Name = "frm_firstOpen";
            this.Text = "Silent Hill 2 Game Result Hack";
            this.Load += new System.EventHandler(this.frm_firstOpen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartHack;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Status;
    }
}

