namespace Seraph
{
    partial class FormSeraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeraph));
            this.m_lName = new System.Windows.Forms.Label();
            this.m_tbName = new System.Windows.Forms.TextBox();
            this.m_bHandle = new System.Windows.Forms.Button();
            this.m_dgvHandler = new System.Windows.Forms.DataGridView();
            this.m_bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lName
            // 
            this.m_lName.AutoSize = true;
            this.m_lName.Location = new System.Drawing.Point(12, 17);
            this.m_lName.Name = "m_lName";
            this.m_lName.Size = new System.Drawing.Size(35, 13);
            this.m_lName.TabIndex = 0;
            this.m_lName.Text = "Name";
            // 
            // m_tbName
            // 
            this.m_tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tbName.Location = new System.Drawing.Point(53, 14);
            this.m_tbName.Name = "m_tbName";
            this.m_tbName.Size = new System.Drawing.Size(521, 20);
            this.m_tbName.TabIndex = 1;
            this.m_tbName.Text = " ";
            this.m_tbName.TextChanged += new System.EventHandler(this.m_tbName_TextChanged);
            // 
            // m_bHandle
            // 
            this.m_bHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_bHandle.Location = new System.Drawing.Point(580, 12);
            this.m_bHandle.Name = "m_bHandle";
            this.m_bHandle.Size = new System.Drawing.Size(75, 23);
            this.m_bHandle.TabIndex = 2;
            this.m_bHandle.Text = "Handle";
            this.m_bHandle.UseVisualStyleBackColor = true;
            this.m_bHandle.Click += new System.EventHandler(this.m_bHandle_Click);
            // 
            // m_dgvHandler
            // 
            this.m_dgvHandler.AllowUserToAddRows = false;
            this.m_dgvHandler.AllowUserToDeleteRows = false;
            this.m_dgvHandler.AllowUserToResizeRows = false;
            this.m_dgvHandler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dgvHandler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvHandler.Location = new System.Drawing.Point(12, 40);
            this.m_dgvHandler.MultiSelect = false;
            this.m_dgvHandler.Name = "m_dgvHandler";
            this.m_dgvHandler.RowHeadersVisible = false;
            this.m_dgvHandler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvHandler.Size = new System.Drawing.Size(643, 252);
            this.m_dgvHandler.TabIndex = 3;
            this.m_dgvHandler.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.m_dgvHandler_DataBindingComplete);
            // 
            // m_bClose
            // 
            this.m_bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_bClose.Location = new System.Drawing.Point(580, 298);
            this.m_bClose.Name = "m_bClose";
            this.m_bClose.Size = new System.Drawing.Size(75, 23);
            this.m_bClose.TabIndex = 4;
            this.m_bClose.Text = "Close";
            this.m_bClose.UseVisualStyleBackColor = true;
            this.m_bClose.Click += new System.EventHandler(this.m_bClose_Click);
            // 
            // FormSeraph
            // 
            this.AcceptButton = this.m_bHandle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 333);
            this.Controls.Add(this.m_bClose);
            this.Controls.Add(this.m_dgvHandler);
            this.Controls.Add(this.m_bHandle);
            this.Controls.Add(this.m_tbName);
            this.Controls.Add(this.m_lName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSeraph";
            this.Text = "Seraph";
            this.Load += new System.EventHandler(this.FormSeraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lName;
        private System.Windows.Forms.TextBox m_tbName;
        private System.Windows.Forms.Button m_bHandle;
        private System.Windows.Forms.DataGridView m_dgvHandler;
        private System.Windows.Forms.Button m_bClose;
    }
}

