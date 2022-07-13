 
namespace ConsoleApp1
{
    internal class SampleOne
    {
        public string GetSamples()
        {
            return JsonConvert.SerializeObject(new List<int>());
        }
    }
}
