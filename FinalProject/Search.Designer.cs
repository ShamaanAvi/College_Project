
namespace FinalProject
{
    partial class fSearch
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgQuery = new System.Windows.Forms.DataGridView();
            this.txtUsernameID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(21, 155);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(72, 22);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgQuery
            // 
            this.dgQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuery.Location = new System.Drawing.Point(191, 23);
            this.dgQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgQuery.Name = "dgQuery";
            this.dgQuery.RowHeadersWidth = 62;
            this.dgQuery.RowTemplate.Height = 28;
            this.dgQuery.Size = new System.Drawing.Size(274, 164);
            this.dgQuery.TabIndex = 1;
            // 
            // txtUsernameID
            // 
            this.txtUsernameID.Location = new System.Drawing.Point(21, 45);
            this.txtUsernameID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsernameID.Name = "txtUsernameID";
            this.txtUsernameID.Size = new System.Drawing.Size(153, 20);
            this.txtUsernameID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Username or ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(21, 181);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 22);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(477, 211);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsernameID);
            this.Controls.Add(this.dgQuery);
            this.Controls.Add(this.btnQuery);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fSearch";
            this.Text = "Advanced";
            this.Load += new System.EventHandler(this.fSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgQuery;
        private System.Windows.Forms.TextBox txtUsernameID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}