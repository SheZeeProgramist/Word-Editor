📄 WORD EDITOR
Word Editor — это удобное приложение на Windows Forms для автоматического создания и заполнения документов Microsoft Word по шаблонам.
Программа позволяет быстро генерировать заявления, объяснительные и докладные записки, подставляя данные пользователя в нужные места.

Главная особенность: Приложение работает автономно и не требует установленного Microsoft Word (Office) на компьютере!

🚀 Возможности (Features)
⚡ Автономность: Генерация .docx файлов без использования Microsoft Office Interop (используется библиотека DocX).

🎨 Современный UI: Приятный интерфейс в стиле Material Design (Google).

🌗 Темы: Поддержка Светлой и Темной темы с мгновенным переключением.

🌍 Мультиязычность: Полная локализация интерфейса и шаблонов (Русский / English).

💾 Система черновиков: Возможность сохранить введенные данные в JSON и продолжить редактирование позже ("Открыть прошлый файл").

📝 Шаблонизатор: Работает на основе тегов (например, <FIO>, <ORG>), которые можно легко менять в исходных файлах Word.

🛠 Технологический стек (Tech Stack)
Language: C# (.NET Framework)

GUI: Windows Forms + MaterialSkin.2

Word Processing: Xceed.Words.NET (DocX)

Data Serialization: Newtonsoft.Json

📂 Как это работает?
Выбор шаблона: Пользователь выбирает тип документа (Заявление, Объяснительная и т.д.).

Заполнение: Программа автоматически генерирует поля ввода на основе конфигурации шаблона.

Генерация: При нажатии "Сохранить", программа берет .docx шаблон, заменяет теги (напр. <NAME>) на текст и сохраняет новый файл.

Черновики: Вместе с документом сохраняется .json файл с данными полей для повторного использования.

📦 Установка и запуск
Скачайте проект или релиз.

Убедитесь, что в папке с .exe файлом находятся шаблоны (statement_ru.docx, expl_en.docx и т.д.).

Запустите AutoWord.exe.



📄 WORD EDITOR
Word Editor is a lightweight Windows Forms application designed to automate the creation of Word documents based on pre-defined templates.
It allows users to quickly generate official documents (Statements, Explanatory notes, Reports) by filling in a simple form.

Key Highlight: The application works standalone and does not require Microsoft Word (Office) to be installed!

🚀 Features
⚡ Standalone: Generates .docx files without Microsoft Office Interop (powered by DocX library).

🎨 Modern UI: Clean interface built with Material Design.

🌗 Theme Support: Instant switching between Dark and Light modes.

🌍 Localization: Full support for Russian and English languages (interface & templates).

💾 Draft System: Save your input data as JSON drafts and reload them later to edit previous documents.

📝 Flexible Templates: Uses tag-based replacement (e.g., <NAME>, <DATE>) inside standard Word files.

🛠 Tech Stack
C# (.NET Framework)

WinForms + MaterialSkin.2

Xceed.Words.NET (for docx manipulation)

Newtonsoft.Json (for saving drafts)

📂 How to use
Select the document type from the main menu.

Fill in the generated fields.

Click "Save". The app replaces tags in the template with your data.

Use "Load Draft" to restore data from previous sessions.
