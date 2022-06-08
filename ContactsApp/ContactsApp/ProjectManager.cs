using System;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Сериализация Project
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Serializer
        /// </summary>
        private static readonly JsonSerializer _serializer = new JsonSerializer();

        /// <summary>
        /// Путь до папки "AppData" пользователя
        /// </summary>
        public static readonly string _myPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                                "/msukhushina/ContactsApp";

        public static DirectoryInfo directoryInfo = new DirectoryInfo(_myPath);

        /// <summary>
        /// Сохранение данных контактов в JSON-файл
        /// </summary>
        /// <param name="project">сериализуемый объект(список контактов)</param>
        /// <param name="fileName">Имя сохраняемого файла</param>
        public static void SaveToFile(Project project, string fileName)
        {
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            using (StreamWriter sw = new StreamWriter(_myPath + @fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                _serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Считывание данных контактов из файла
        /// Файл берется из папки "Мои документы"
        /// </summary>
        /// <param name="fileName">Имя JSON-файла с данными</param>
        /// <returns></returns>
        public static Project LoadFromFile(string path, string fileName)
        {
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                return new Project();
            }

            if (!File.Exists(path + fileName))
            {
                return new Project();
            }

            Project project = null;
            try
            {
                using (StreamReader sr = new StreamReader(_myPath + @fileName))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = (Project)_serializer.Deserialize<Project>(reader);
                }

                if (project == null)
                {
                    return new Project();
                }
            }
            catch (Exception e)
            {
                return new Project();
            }

            return project;
        }
    }
}
