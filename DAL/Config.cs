using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Config
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
    }
}
