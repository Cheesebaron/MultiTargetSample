using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace MultiTargetLib
{
    public class CommonClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public async Task DoStuffAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://blog.ostebaronen.dk").ConfigureAwait(false);
        }
    }
}
