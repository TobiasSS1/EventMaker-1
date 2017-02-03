using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace EventMaker.Persistency
{
    class PersistencyService
    {
        public static async void SaveEventAsJsonAsync(ObservableCollection<Model.Event> events)
        {
            string jsonText = Skema.GetJson();
            StorageFile file = await localfolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsonText);
        }

        public static async Task<List<Model.Event>> LoadEventsFromJsonAsync()
        {
            
        }

        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {
            
        }

        public static async Task<string> DeSerializeEventsFileAsync(String filename)
        {
            
        }
    }
}
