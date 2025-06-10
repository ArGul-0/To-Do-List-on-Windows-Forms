using Newtonsoft.Json;
using System.ComponentModel;

namespace To_Do_List_on_Windows_Forms
{
    public class NoteStorage
    {
        private string jsonContent;
        private string jsonFilePath;
        public NoteStorage()
        {
            // 1. Получаем путь к папке AppData\Roaming
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            // 2. Формируем путь к вашей папке (например, "MyProject")
            string myFolder = Path.Combine(appData, "To-Do List on Windows Forms");
            // 3. Создаём папку, если её нет
            Directory.CreateDirectory(myFolder);
            // 4. Формируем полный путь к файлу Tasks.json
            jsonFilePath = Path.Combine(myFolder, "Tasks.json");
        }
        public void Save(BindingList<string> list)
        {
            // Сериализация списка задач в JSON
            jsonContent = JsonConvert.SerializeObject(list, Formatting.Indented);
            // Запись JSON в файл
            File.WriteAllText(jsonFilePath, jsonContent);
        }
        public BindingList<string> Load()
        {
            // Десериализация JSON из файла в список задач
            try
            {
                // Десериализация JSON из файла в список задач
                return JsonConvert.DeserializeObject<BindingList<string>>(File.ReadAllText(jsonFilePath));
            }
            catch
            {
                // Если файл не найден или пуст, возвращаем новый список
                return new BindingList<string>();
            }
        }
    }
}
