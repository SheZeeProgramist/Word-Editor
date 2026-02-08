namespace WordEditor
{
    partial class EditorForm
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
            this.panelFields = new System.Windows.Forms.Panel();
            this.btnLoadDraft = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.lblSavePath = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // panelFields
            // 
            this.panelFields.AutoScroll = true;
            this.panelFields.Location = new System.Drawing.Point(6, 67);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(560, 364);
            this.panelFields.TabIndex = 0;
            // 
            // btnLoadDraft
            // 
            this.btnLoadDraft.AutoSize = false;
            this.btnLoadDraft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadDraft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadDraft.Depth = 0;
            this.btnLoadDraft.HighEmphasis = true;
            this.btnLoadDraft.Icon = null;
            this.btnLoadDraft.Location = new System.Drawing.Point(573, 347);
            this.btnLoadDraft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadDraft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadDraft.Name = "btnLoadDraft";
            this.btnLoadDraft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoadDraft.Size = new System.Drawing.Size(220, 36);
            this.btnLoadDraft.TabIndex = 1;
            this.btnLoadDraft.Text = "Открыть прошлый файл";
            this.btnLoadDraft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadDraft.UseAccentColor = false;
            this.btnLoadDraft.UseVisualStyleBackColor = true;
            this.btnLoadDraft.Click += new System.EventHandler(this.btnLoadDraft_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(573, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(220, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(573, 70);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(220, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "В Меню";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSavePath.Depth = 0;
            this.lblSavePath.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSavePath.Location = new System.Drawing.Point(581, 322);
            this.lblSavePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(86, 19);
            this.lblSavePath.TabIndex = 4;
            this.lblSavePath.Text = "lblSavePath";
            this.lblSavePath.Click += new System.EventHandler(this.lblSavePath_Click_1);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadDraft);
            this.Controls.Add(this.panelFields);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFields;
        private MaterialSkin.Controls.MaterialButton btnLoadDraft;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialLabel lblSavePath;
    }
}