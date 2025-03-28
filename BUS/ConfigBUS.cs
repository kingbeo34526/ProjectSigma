using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ConfigBUS
    {
        public static void EnsureConfigFileExists()
        {
            ConfigDAL.EnsureConfigFileExists();
        }
        public static string GetConnectionString()
        {
            return ConfigDAL.GetConnectionString();
        }

        public static void SaveConnectionString(string connectionString)
        {
            ConfigDAL.SaveConnectionString(connectionString);
        }
    }
}
