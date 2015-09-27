using Newtonsoft.Json;

namespace MyLibrary.Extension
{
    public class Bar
    {
        public string Title { get; set; }
        public Foo Foo { get; set; }

        public string Serialize(Foo foo)
        {
            return JsonConvert.SerializeObject(foo);
        }
    }
}
