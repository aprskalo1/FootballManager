using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class FileRepo : IRepo
    {
        public void SaveSettings(string language, string worldCupType, string settingsFilePath)
        {
            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {
                writer.WriteLine($"{language}:{worldCupType}");
            }
        }
    }
}
