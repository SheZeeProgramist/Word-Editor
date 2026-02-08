namespace WordEditor
{
    partial class MenuForm
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
            this.switchTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitchLang = new MaterialSkin.Controls.MaterialSwitch();
            this.btnExplanation = new MaterialSkin.Controls.MaterialButton();
            this.btnReport = new MaterialSkin.Controls.MaterialButton();
            this.btnStatement = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // switchTheme
            // 
            this.switchTheme.AutoSize = true;
            this.switchTheme.Depth = 0;
            this.switchTheme.Location = new System.Drawing.Point(13, 75);
            this.switchTheme.Margin = new System.Windows.Forms.Padding(0);
            this.switchTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchTheme.Name = "switchTheme";
            this.switchTheme.Ripple = true;
            this.switchTheme.Size = new System.Drawing.Size(97, 37);
            this.switchTheme.TabIndex = 3;
            this.switchTheme.Text = "Тема";
            this.switchTheme.UseVisualStyleBackColor = true;
            this.switchTheme.CheckedChanged += new System.EventHandler(this.switchTheme_CheckedChanged_1);
            // 
            // materialSwitchLang
            // 
            this.materialSwitchLang.AutoSize = true;
            this.materialSwitchLang.Depth = 0;
            this.materialSwitchLang.Location = new System.Drawing.Point(13, 112);
            this.materialSwitchLang.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitchLang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchLang.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchLang.Name = "materialSwitchLang";
            this.materialSwitchLang.Ripple = true;
            this.materialSwitchLang.Size = new System.Drawing.Size(97, 37);
            this.materialSwitchLang.TabIndex = 4;
            this.materialSwitchLang.Text = "Язык";
            this.materialSwitchLang.UseVisualStyleBackColor = true;
            this.materialSwitchLang.CheckedChanged += new System.EventHandler(this.materialSwitchLang_CheckedChanged);
            // 
            // btnExplanation
            // 
            this.btnExplanation.AutoSize = false;
            this.btnExplanation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExplanation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExplanation.Depth = 0;
            this.btnExplanation.HighEmphasis = true;
            this.btnExplanation.Icon = null;
            this.btnExplanation.Location = new System.Drawing.Point(23, 155);
            this.btnExplanation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExplanation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExplanation.Name = "btnExplanation";
            this.btnExplanation.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExplanation.Size = new System.Drawing.Size(158, 36);
            this.btnExplanation.TabIndex = 5;
            this.btnExplanation.Text = "Объяснительная";
            this.btnExplanation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExplanation.UseAccentColor = false;
            this.btnExplanation.UseVisualStyleBackColor = true;
            this.btnExplanation.Click += new System.EventHandler(this.btnExplanation_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = false;
            this.btnReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReport.Depth = 0;
            this.btnReport.HighEmphasis = true;
            this.btnReport.Icon = null;
            this.btnReport.Location = new System.Drawing.Point(23, 251);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport.Name = "btnReport";
            this.btnReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReport.Size = new System.Drawing.Size(158, 36);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Докладная";
            this.btnReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReport.UseAccentColor = false;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // btnStatement
            // 
            this.btnStatement.AutoSize = false;
            this.btnStatement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatement.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatement.Depth = 0;
            this.btnStatement.HighEmphasis = true;
            this.btnStatement.Icon = null;
            this.btnStatement.Location = new System.Drawing.Point(23, 203);
            this.btnStatement.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatement.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatement.Size = new System.Drawing.Size(158, 36);
            this.btnStatement.TabIndex = 7;
            this.btnStatement.Text = "Заявление";
            this.btnStatement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatement.UseAccentColor = false;
            this.btnStatement.UseVisualStyleBackColor = true;
            this.btnStatement.Click += new System.EventHandler(this.btnStatement_Click_1);
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 310);
            this.Controls.Add(this.btnStatement);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExplanation);
            this.Controls.Add(this.materialSwitchLang);
            this.Controls.Add(this.switchTheme);
            this.Name = "MenuForm";
            this.Text = "Word Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch switchTheme;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchLang;
        private MaterialSkin.Controls.MaterialButton btnExplanation;
        private MaterialSkin.Controls.MaterialButton btnReport;
        private MaterialSkin.Controls.MaterialButton btnStatement;
    }
}