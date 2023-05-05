
namespace ContactsApp.Model
{
    using Newtonsoft.Json;
    using System.IO;
    using System;

    /// <summary>
    /// Описывает сериализатор проекта, реализующий сохранение объекта <see cref="Project"/>
    /// в файл и метод загрузки проекта из файла.
    /// </summary>
    public class ProjectSerializer
    {
        /// <summary>
        /// Имя файла.
        /// </summary>
        private string _fileName;

        /// <summary>
        /// Директория, которую не задаёт пользователь.
        /// </summary>
        private readonly string _defaultDirectory;

        /// <summary>
        /// Возвращает или задаёт имя файла.
        /// </summary>
        public string Filename
        {
            get
            {
                return _fileName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Filename cannot be null or whitespace", nameof(Filename));
                }
                _fileName = value;
            }
        }

        /// <summary>
        /// Сохраняет объект класса <see cref="Project"/> в файл.
        /// </summary>
        /// <param name="project"></param>
        /// <exception cref="ApplicationException"></exception>
        public void SaveToFile(Project project)
        {
            try
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Manakov", "ContactsApp");
                Directory.CreateDirectory(path);

                var json = JsonConvert.SerializeObject(project, Formatting.Indented);
                var filepath = Path.Combine(path, "userdata.json");
                File.WriteAllText(filepath, json);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Failed to save file {_fileName}: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Загружает объект из файла формата .json
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        public Project LoadFromFile()
        {
            try
            {
                if (File.Exists(_fileName))
                {
                    var json = File.ReadAllText(_fileName);
                    return JsonConvert.DeserializeObject<Project>(json);
                }
                else
                {
                    return new Project();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Failed to load file {_fileName}: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ProjectSerializer"/>.
        /// </summary>
        public ProjectSerializer()
        {
            _defaultDirectory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Manakov", "ContactsApp");
            if (!Directory.Exists(_defaultDirectory))
            {
                Directory.CreateDirectory(_defaultDirectory);
            }
            _fileName = Path.Combine(_defaultDirectory, "userdata.json");
        }

    }
}
