using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Nexus.Components 
{
    public class AboutSectionBase : ComponentBase 
    {
        private readonly HttpClient _httpClient;
        public AboutSectionData AboutSectionData { get; set; }
        
        public AboutSectionBase(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected override async Task OnInitializedAsync()
        {
            AboutSectionData = await _httpClient.GetJsonAsync<AboutSectionData>("sample-data/AboutSection.json");
        }
    }

    public class AboutSectionData
    {
        public string Heading { get; set; }
        public string Text { get; set; }
    }
}