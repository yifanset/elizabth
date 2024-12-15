using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сериализует и десериализует данные товаров и покупателей.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Возвращает путь до файла сериализации.
        /// </summary>
        private static string FilePath { get; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ObjectOrientedPractics\\Serialization.json");

        /// <summary>
        /// Возвращает и задает данные о товарах и покупателях в JSON формате.
        /// </summary>
        private static string StoreJson { get; set; } = string.Empty;

        /// <summary>
        /// Выгружает данные о товарах и покупателях из файла сериализации, если он есть.
        /// </summary>
        static Serializer()
        {
            var directory = Path.GetDirectoryName(FilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Dispose(); // Создаем пустой файл, если его нет
                StoreJson = string.Empty;
            }
            else
            {
                try
                {
                    StoreJson = File.ReadAllText(FilePath);
                }
                catch
                {
                    StoreJson = string.Empty;
                }
            }
        }

        /// <summary>
        /// Десериализует данные о товарах и покупателях.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Store"/>.</returns>
        public static Store GetStore()
        {
            if (string.IsNullOrEmpty(StoreJson))
            {
                return new Store();
            }
            try
            {
                return JsonSerializer.Deserialize<Store>(
                    StoreJson,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true, // Игнорировать регистр имен свойств
                        WriteIndented = true
                    });
            }
            catch
            {
                StoreJson = string.Empty;
                MessageBox.Show("Data is corrupted.\nSave files have been cleared.");
                return new Store();
            }
        }

        /// <summary>
        /// Сериализует данные о товарах и покупателях и сохраняет изменения.
        /// </summary>
        /// <param name="store">Экземпляр класса <see cref="Store"/>.</param>
        public static void SetStore(Store store)
        {
            try
            {
                StoreJson = JsonSerializer.Serialize(
                    store,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                SaveFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving data: {ex.Message}");
            }
        }

        /// <summary>
        /// Сохраняет изменения данных о товарах и покупателях в файл сериализации.
        /// </summary>
        private static void SaveFile()
        {
            try
            {
                File.WriteAllText(FilePath, StoreJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
            }
        }
    }
}
