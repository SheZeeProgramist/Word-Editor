using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WordEditor;

namespace WordEditor
{
    public partial class EditorForm : MaterialForm
    {
        private DocType _currentType;
        private TemplateConfig _config;
        private string _currentSavePath;

        private Dictionary<string, MaterialTextBox> _inputs = new Dictionary<string, MaterialTextBox>();

        public EditorForm(DocType type, DraftData draft = null)
        {
            InitializeComponent();
            _currentType = type;

            var manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);

            _currentSavePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            lblSavePath.Text = "Путь сохранения: " + _currentSavePath;

            LoadInterface(draft);

            this.Text = "AutoWord Editor";
            btnBack.Text = UiText.BtnBack;
            btnSave.Text = UiText.BtnSave;
            btnLoadDraft.Text = UiText.BtnLoad;
            lblSavePath.Text = UiText.LblSavePath + _currentSavePath;

            LoadInterface(draft);
        }

        private void LoadInterface(DraftData draft)
        {
            panelFields.Controls.Clear();
            _inputs.Clear();
            _config = AppManager.GetTemplate(_currentType);
            this.Text = "Редактор: " + _config.FileName;

            int yPos = 10;

            foreach (var field in _config.Fields)
            {
                Label lbl = new Label();
                lbl.Text = field.Value;
                lbl.Location = new Point(20, yPos);
                lbl.AutoSize = true;
                lbl.Font = new Font("Roboto", 10);
                panelFields.Controls.Add(lbl);

                MaterialTextBox txt = new MaterialTextBox();
                txt.Hint = field.Value;
                txt.Location = new Point(20, yPos + 25);
                txt.Size = new Size(panelFields.Width - 60, 50);
                txt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                if (draft != null && draft.FieldValues.ContainsKey(field.Key))
                {
                    txt.Text = draft.FieldValues[field.Key];
                }

                panelFields.Controls.Add(txt);

                _inputs.Add(field.Key, txt);

                yPos += 90;
            }
        }

        private void btnLoadDraft_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "AutoWord Drafts (*.json)|*.json";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var draft = DraftData.Load(ofd.FileName);

                        panelFields.Controls.Clear();
                        _inputs.Clear();
                        _config.Type = draft.Type;

                        LoadInterface(draft);
                        MessageBox.Show("Данные загружены!");
                    }
                    catch { MessageBox.Show("Не удалось прочитать файл данных."); }
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dataToFill = new Dictionary<string, string>();
                foreach (var item in _inputs)
                {
                    dataToFill.Add(item.Key, item.Value.Text);
                }

                string templatePath = Path.GetFullPath(_config.FileName);
                if (!File.Exists(templatePath))
                {
                    MessageBox.Show($"Шаблон не найден: {templatePath}\nПоложите его рядом с программой.");
                    return;
                }

                string resultName = $"{_config.Type}_{DateTime.Now:yyyyMMdd_HHmmss}.docx";
                string fullSavePath = Path.Combine(_currentSavePath, resultName);

                WordProcessor.CreateDocument(templatePath, dataToFill, fullSavePath);

                string draftPath = fullSavePath + ".json";
                var draft = new DraftData { FieldValues = dataToFill, Type = _currentType, Lang = _config.Lang };
                DraftData.Save(draftPath, draft);

                MessageBox.Show("Готово! Файл сохранен:\n" + fullSavePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            bool естьТекст = false;
            foreach (var input in _inputs.Values) if (!string.IsNullOrEmpty(input.Text)) естьТекст = true;

            if (естьТекст)
            {
                var res = MessageBox.Show("Есть несохраненные данные. Выйти?", "Внимание", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) return;
            }

            this.Close();
        }

        private void lblSavePath_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    _currentSavePath = fbd.SelectedPath;
                    lblSavePath.Text = UiText.LblSavePath + _currentSavePath;
                }
            }
        }
    }
}