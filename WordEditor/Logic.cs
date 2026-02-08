using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Xceed.Words.NET;
using Newtonsoft.Json;

namespace WordEditor
{

    public enum DocType { Explanation, Statement, Report }

    public enum Language { RU, EN }

    public class TemplateConfig
    {
        public DocType Type { get; set; }
        public Language Lang { get; set; }
        public string FileName { get; set; }

        public Dictionary<string, string> Fields { get; set; }
    }

    public static class AppManager
    {
        public static Language CurrentLanguage { get; set; } = Language.RU;
        public static bool IsDarkTheme { get; set; } = false;

        public static List<TemplateConfig> Templates = new List<TemplateConfig>();

        public static void Initialize()
        {
            // --- ЗАЯВЛЕНИЕ (RU) ---
            Templates.Add(new TemplateConfig
            {
                Type = DocType.Statement,
                Lang = Language.RU,
                FileName = "statement_ru.docx",
                Fields = new Dictionary<string, string> {
                    { "<ORG>", "Кому." },
                    { "<FIO>", "От Кого." },
                    { "<PROF> ", "Работа/Вид деятельности." },
                    { "<DATE_FROM>", "Дата начала." },
                    { "<MONTHS>", "Срок." },
                    { "<SALARY>", "Оклад." },
                    { "<DATE>", "Дата." }

                }
            });

            // --- ЗАЯВЛЕНИЕ (EN) ---
            Templates.Add(new TemplateConfig
            {
                Type = DocType.Statement,
                Lang = Language.EN,
                FileName = "statement_en.docx",
                Fields = new Dictionary<string, string> {
                    { "<ORG>", "Whom." },
                    { "<FIO>", "From whom." },
                    { "<PROF> ", "Work/Type of activity." },
                    { "<DATE_FROM>", "Start date." },
                    { "<MONTHS>", "Term." },
                    { "<SALARY>", "Salary." },
                    { "<DATE>", "Date." }
                }
            });

            // --- ОБЪЯСНИТЕЛЬНАЯ (RU) ---
            Templates.Add(new TemplateConfig
            {
                Type = DocType.Explanation,
                Lang = Language.RU,
                FileName = "expl_ru.docx",
                Fields = new Dictionary<string, string> {
                    { "<ORG>", "Кому" },
                    { "<FIO>", "От Кого." },
                    { "<POYASNENIE>", "Обьяснительная записка." },
                    { "<DATE>", "Дата" }
                }
            });

            // --- ОБЪЯСНИТЕЛЬНАЯ (EN) ---
            Templates.Add(new TemplateConfig
            {
                Type = DocType.Explanation,
                Lang = Language.EN,
                FileName = "expl_en.docx",
                Fields = new Dictionary<string, string> {
                    { "<ORG>", "Whom." },
                    { "<FIO>", "From whom." },
                    { "<POYASNENIE>", "Explanatory note." },
                    { "<DATE>", "Date" }
                }
            });

            // --- ДОКЛАДНАЯ (RU) ---

            Templates.Add(new TemplateConfig
            {
                Type = DocType.Report,
                Lang = Language.RU,
                FileName = "report_ru.docx",
                Fields = new Dictionary<string, string> {
                    { "<ORG>", "Кому." },
                    { "<FIO>", "От Кого." },
                    { "<DOKLAD>", "Докладная записка." },
                    { "<DATE>", "Дата" }
                }
            });

            // --- ДОКЛАДНАЯ (EN) ---

            Templates.Add(new TemplateConfig
            {
                Type = DocType.Report,
                Lang = Language.EN,
                FileName = "report_en.docx",
                Fields = new Dictionary<string, string> {
                    { "<ORG>", "Whom." },
                    { "<FIO>", "From whom." },
                    { "<POYASNENIE>", "Report note." },
                    { "<DATE>", "Date" }
                }
            });
        }

        public static TemplateConfig GetTemplate(DocType type)
        {
            return Templates.Find(t => t.Type == type && t.Lang == CurrentLanguage);
        }
    }
    public class WordProcessor
    {
        public static void CreateDocument(string templatePath, Dictionary<string, string> data, string savePath)
        {
            using (var doc = DocX.Load(templatePath))
            {
                foreach (var item in data)
                {
                    doc.ReplaceText(item.Key, item.Value);
                }

                doc.SaveAs(savePath);
            }
        }
    }

    public class DraftData
    {
        public Dictionary<string, string> FieldValues { get; set; }
        public DocType Type { get; set; }
        public Language Lang { get; set; }

        public static void Save(string path, DraftData data)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(path, json);
        }

        public static DraftData Load(string path)
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<DraftData>(json);
        }
    }

    public static class UiText
    {
        public static string AppTitle => AppManager.CurrentLanguage == Language.RU ? "AutoWord Меню" : "AutoWord Menu";
        public static string Theme => AppManager.CurrentLanguage == Language.RU ? "Тема" : "Theme";
        public static string Lang => AppManager.CurrentLanguage == Language.RU ? "Язык" : "Language";

        public static string BtnExplanation => AppManager.CurrentLanguage == Language.RU ? "ОБЪЯСНИТЕЛЬНАЯ" : "EXPLANATION";
        public static string BtnStatement => AppManager.CurrentLanguage == Language.RU ? "ЗАЯВЛЕНИЕ" : "STATEMENT";
        public static string BtnReport => AppManager.CurrentLanguage == Language.RU ? "ДОКЛАДНАЯ" : "REPORT";

        public static string BtnBack => AppManager.CurrentLanguage == Language.RU ? "В МЕНЮ" : "BACK TO MENU";
        public static string BtnSave => AppManager.CurrentLanguage == Language.RU ? "СОХРАНИТЬ" : "SAVE";
        public static string BtnLoad => AppManager.CurrentLanguage == Language.RU ? "ОТКРЫТЬ ПРОШЛЫЙ ФАЙЛ" : "LOAD DRAFT";
        public static string LblSavePath => AppManager.CurrentLanguage == Language.RU ? "Путь сохранения: " : "Save path: ";

        public static string MsgSaved => AppManager.CurrentLanguage == Language.RU ? "Файл сохранен!" : "File saved!";
        public static string MsgUnsaved => AppManager.CurrentLanguage == Language.RU ? "Есть несохраненные данные. Выйти?" : "You have unsaved changes. Exit?";
    }
}