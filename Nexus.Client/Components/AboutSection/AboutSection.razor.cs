using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace Nexus.Client.Components
{
    public class AboutSectionBase : ComponentBase
    {
        [Inject] 
        private HttpClient HttpClient { get; set; }
        protected AboutSectionData AboutSectionData { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AboutSectionData = 
                await HttpClient.GetJsonAsync<AboutSectionData>("https://localhost:5003/personaldetails/1");
        }
    }

    public class AboutSectionData
    {
        public string Heading { get; set; }
        public string Text { get; set; }
    }
}