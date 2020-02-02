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

        // protected override async Task OnInitializedAsync()
        // {
        //     AboutSectionData = 
        //         await HttpClient.GetJsonAsync<AboutSectionData>("https://localhost:5003/api/personaldetails/1");
        // }
    }

    public class AboutSectionData
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Biography { get; set; }
    }
}