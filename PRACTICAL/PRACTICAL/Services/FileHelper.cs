using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using PRACTICAL.Models;
using System.Net.Http;
using Newtonsoft.Json;
namespace PRACTICAL.Services
{
    class FileHelper
    {
        public static async Task<string> ReadFile(string fileName)
        {
            var storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var demoFile = await storageFolder.CreateFileAsync(fileName, Windows.Storage.CreationCollisionOption.OpenIfExists);
            return await FileIO.ReadTextAsync(demoFile);
        }
        public async Task<Root> todaySpecial()
        {
            string stringContent = await ReadFile("employee.json");
            return JsonConvert.DeserializeObject<Root>(stringContent);   
        }
        public static async void WriteFile(string fileName, string content)
        {
            var storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var demoFile = await storageFolder.CreateFileAsync(fileName, Windows.Storage.CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(demoFile, content);
        }
    }
}
