
namespace FinalProject
{
    partial class fUserDetail
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
            this.btnStuView = new System.Windows.Forms.Button();
            this.btnStuUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStuUserDet = new System.Windows.Forms.TextBox();
            this.txtStuAddressDet = new System.Windows.Forms.RichTextBox();
            this.btnStuBack = new System.Windows.Forms.Button();
            this.dgStuUserDet = new System.Windows.Forms.DataGridView();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bgExtra = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgStuUserDet)).BeginInit();
            this.bgExtra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStuView
            // 
            this.btnStuView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStuView.Location = new System.Drawing.Point(4, 74);
            this.btnStuView.Margin = new System.Windows.Forms.Padding(2);
            this.btnStuView.Name = "btnStuView";
            this.btnStuView.Size = new System.Drawing.Size(55, 20);
            this.btnStuView.TabIndex = 0;
            this.btnStuView.Text = "View";
            this.btnStuView.UseVisualStyleBackColor = true;
            this.btnStuView.Click += new System.EventHandler(this.btnStuView_Click);
            // 
            // btnStuUpdate
            // 
            this.btnStuUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStuUpdate.Location = new System.Drawing.Point(5, 173);
            this.btnStuUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnStuUpdate.Name = "btnStuUpdate";
            this.btnStuUpdate.Size = new System.Drawing.Size(55, 20);
            this.btnStuUpdate.TabIndex = 1;
            this.btnStuUpdate.Text = "Update";
            this.btnStuUpdate.UseVisualStyleBackColor = true;
            this.btnStuUpdate.Click += new System.EventHandler(this.btnStuUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "View or update your details";
            // 
            // txtStuUserDet
            // 
            this.txtStuUserDet.Location = new System.Drawing.Point(139, 131);
            this.txtStuUserDet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStuUserDet.Name = "txtStuUserDet";
            this.txtStuUserDet.Size = new System.Drawing.Size(287, 20);
            this.txtStuUserDet.TabIndex = 3;
            // 
            // txtStuAddressDet
            // 
            this.txtStuAddressDet.Location = new System.Drawing.Point(139, 179);
            this.txtStuAddressDet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStuAddressDet.Name = "txtStuAddressDet";
            this.txtStuAddressDet.Size = new System.Drawing.Size(287, 41);
            this.txtStuAddressDet.TabIndex = 4;
            this.txtStuAddressDet.Text = "";
            // 
            // btnStuBack
            // 
            this.btnStuBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStuBack.Location = new System.Drawing.Point(463, 205);
            this.btnStuBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnStuBack.Name = "btnStuBack";
            this.btnStuBack.Size = new System.Drawing.Size(55, 20);
            this.btnStuBack.TabIndex = 5;
            this.btnStuBack.Text = "Back";
            this.btnStuBack.UseVisualStyleBackColor = true;
            this.btnStuBack.Click += new System.EventHandler(this.btnStuBack_Click);
            // 
            // dgStuUserDet
            // 
            this.dgStuUserDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStuUserDet.Location = new System.Drawing.Point(139, 29);
            this.dgStuUserDet.Margin = new System.Windows.Forms.Padding(2);
            this.dgStuUserDet.Name = "dgStuUserDet";
            this.dgStuUserDet.RowHeadersWidth = 62;
            this.dgStuUserDet.RowTemplate.Height = 28;
            this.dgStuUserDet.Size = new System.Drawing.Size(369, 86);
            this.dgStuUserDet.TabIndex = 6;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(139, 152);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(287, 20);
            this.txtNewPassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(68, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Name";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbpass.Location = new System.Drawing.Point(75, 156);
            this.lbpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(53, 13);
            this.lbpass.TabIndex = 9;
            this.lbpass.Text = "Password";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Address.Location = new System.Drawing.Point(82, 180);
            this.Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 10;
            this.Address.Text = "Address";
            // 
            // btnAdvance
            // 
            this.btnAdvance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdvance.Location = new System.Drawing.Point(458, 45);
            this.btnAdvance.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(61, 24);
            this.btnAdvance.TabIndex = 11;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(329, 45);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 24);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bgExtra
            // 
            this.bgExtra.BackgroundImage = global::FinalProject.Properties.Resources._2;
            this.bgExtra.Controls.Add(this.button1);
            this.bgExtra.Controls.Add(this.btnAdvance);
            this.bgExtra.Controls.Add(this.btnSearch);
            this.bgExtra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bgExtra.Location = new System.Drawing.Point(3, 242);
            this.bgExtra.Margin = new System.Windows.Forms.Padding(2);
            this.bgExtra.Name = "bgExtra";
            this.bgExtra.Padding = new System.Windows.Forms.Padding(2);
            this.bgExtra.Size = new System.Drawing.Size(523, 73);
            this.bgExtra.TabIndex = 13;
            this.bgExtra.TabStop = false;
            this.bgExtra.Text = "Extras";
            this.bgExtra.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(393, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Lend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::FinalProject.Properties.Resources._2;
            this.groupBox2.Controls.Add(this.Address);
            this.groupBox2.Controls.Add(this.lbpass);
            this.groupBox2.Controls.Add(this.btnStuBack);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNewPassword);
            this.groupBox2.Controls.Add(this.dgStuUserDet);
            this.groupBox2.Controls.Add(this.txtStuAddressDet);
            this.groupBox2.Controls.Add(this.txtStuUserDet);
            this.groupBox2.Controls.Add(this.btnStuUpdate);
            this.groupBox2.Controls.Add(this.btnStuView);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(523, 229);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View or update your details";
            // 
            // fUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bgExtra);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fUserDetail";
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.fStudentDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStuUserDet)).EndInit();
            this.bgExtra.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStuView;
        private System.Windows.Forms.Button btnStuUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStuUserDet;
        private System.Windows.Forms.RichTextBox txtStuAddressDet;
        private System.Windows.Forms.Button btnStuBack;
        private System.Windows.Forms.DataGridView dgStuUserDet;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox bgExtra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}