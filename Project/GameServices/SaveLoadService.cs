using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Project.Entities;

namespace Project.GameServices
{
    public class SaveLoadService
    {
        string path = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            @"..\..\Saves\user.json"));

        private static readonly JsonSerializerOptions option =
            new JsonSerializerOptions()
            {
                WriteIndented = true
            };

        public void Save(Player player)
        {
            string json = JsonSerializer.Serialize(player, option);

            string directory = Path.GetDirectoryName(path);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllText(path, json);
        }

        public Player Load()
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Файл збереження не знайдено");
                return null;
            }

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<Player>(json, option);
        }
        public bool HasSave()
        {
            return File.Exists(path);
        }
        public void DeleteSave()
        {
            if (File.Exists(path))
                File.Delete(path);
        }
    }
}