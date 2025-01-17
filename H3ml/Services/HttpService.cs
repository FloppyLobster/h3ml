using System.IO;
using System.Net.Http;

namespace H3ml.Services
{
    public class HttpService
    {
        readonly static HttpClient _client = new HttpClient();
        string _url;

        public Stream load_file(string url)
        {
            if (url.IndexOf("://") == -1)
                url = "https://" + url;
            _url = url;
            return _client.GetStreamAsync(url).Result;
        }

        public string url => _url;

        //static size_t curlWriteFunction(void* ptr, size_t size, size_t nmemb, void* stream)
        //{
        //    Glib::RefPtr<Gio::MemoryInputStream>* s = (Glib::RefPtr<Gio::MemoryInputStream>*)stream;
        //    (*s)->add_data(ptr, size * nmemb);
        //    return size * nmemb;
        //}
    }
}