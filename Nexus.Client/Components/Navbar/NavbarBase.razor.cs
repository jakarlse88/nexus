using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

// ReSharper disable once CheckNamespace
namespace Nexus.Client.Components
{
    public class NavbarBase : ComponentBase
    {
        [Inject] private IJSRuntime JsRuntime { get; set; }
        protected string NavbarHeading { get; }
        
        public NavbarBase()
        {
            NavbarHeading = "Jon Karlsen";
        }
        
        protected async Task ScrollToSection(string sectionId)
        {
            await JsRuntime
                .InvokeVoidAsync(
                    "linkToPageSection",
                    sectionId);
        }
    }
}