using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WordEditor;

namespace WordEditor
{
    public partial class MenuForm : MaterialForm
    {
        public MenuForm()
        {
            InitializeComponent();
            AppManager.Initialize();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);

            UpdateText();
        }
        private void OpenEditor(DocType type, DraftData draft = null)
        {
            this.Hide();

            var editor = new EditorForm(type, draft);

            editor.FormClosed += (s, args) => this.Show();

            editor.Show();
        }

        private void UpdateText()
        {
            this.Text = UiText.AppTitle;
            switchTheme.Text = UiText.Theme;
            materialSwitchLang.Text = UiText.Lang;

            btnExplanation.Text = UiText.BtnExplanation;
            btnStatement.Text = UiText.BtnStatement;
            btnReport.Text = UiText.BtnReport;

            this.Refresh();
        }
        private void switchTheme_CheckedChanged_1(object sender, EventArgs e)
        {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = manager.Theme == MaterialSkinManager.Themes.LIGHT ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            AppManager.IsDarkTheme = (manager.Theme == MaterialSkinManager.Themes.DARK);
        }

        private void materialSwitchLang_CheckedChanged(object sender, EventArgs e)
        {
            AppManager.CurrentLanguage = materialSwitchLang.Checked ? Language.EN : Language.RU;

            UpdateText();
        }

        private void btnExplanation_Click_1(object sender, EventArgs e)
        {
            OpenEditor(DocType.Explanation);
        }

        private void btnStatement_Click_1(object sender, EventArgs e)
        {
            OpenEditor(DocType.Statement);
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            OpenEditor(DocType.Report);
        }
    }
}