using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;
using EventMaker.Model;

namespace EventMaker.Persistency
{
    class PersistencyService
    {
        public PersistencyService()
        { }
        const String fileName = "savedFile.json";
        public static async void SaveEventAsJsonAsync(ObservableCollection<Model.Event> events)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            string JsonData = JsonConvert.SerializeObject(EventCatalogSingleton.Instance.Events);
            await FileIO.WriteTextAsync(localFile, JsonData);

        }

        public static async Task<List<Model.Event>> LoadEventsFromJsonAsync()
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
            String jsonData = await FileIO.ReadTextAsync(localFile);
            return JsonConvert.DeserializeObject<List<Event>>(jsonData);
        }

        private static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {
        }

        private static async Task<string> DeSerializeEventsFileAsync(String filename)
        {
            return filename;
        }
    }
}
