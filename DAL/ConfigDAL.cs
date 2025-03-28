using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConfigDAL
    {
        private static string filePath = "settings.json";

        public static string GetConnectionString()
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Không tìm thấy file cấu hình: {filePath}");

            string json = File.ReadAllText(filePath);
            JObject config = JObject.Parse(json);

            string connectionString = config["Database"]?["ConnectionString"]?.ToString();

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new Exception("Chuỗi kết nối trong settings.json bị rỗng hoặc không hợp lệ!");

            return connectionString;
        }
        // Hàm kiểm tra và tạo file settings.json nếu chưa có
        public static void EnsureConfigFileExists()
        {
            if (!File.Exists(filePath))
            {
                JObject defaultConfig = new JObject
                {
                    ["Database"] = new JObject
                    {
                        ["ConnectionString"] = "Data Source=N/A;Initial Catalog=N/A;Integrated Security=True"
                    }
                };

                File.WriteAllText(filePath, defaultConfig.ToString(Formatting.Indented));
            }
        }
        public static void SaveConnectionString(string connectionString)
        {
            JObject config;
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                config = JObject.Parse(json);
            }
            else
            {
                config = new JObject();
            }

            if (config["Database"] == null)
                config["Database"] = new JObject();

            config["Database"]["ConnectionString"] = connectionString;

            File.WriteAllText(filePath, config.ToString(Formatting.Indented));
        }
    }
}
