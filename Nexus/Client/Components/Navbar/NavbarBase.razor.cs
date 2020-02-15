using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Nexus.Client.Components.Navbar
{
    public class NavbarBase : ComponentBase
    { 
        [Inject] private IJSRuntime JsRuntime { get; set; }
        protected string NavbarHeading { get; }
        
        public NavbarBase()
        {
            NavbarHeading = "Jon Karlsen";
        }
        
        public async Task ScrollToSection(string sectionId)
        {
            await JsRuntime
                .InvokeVoidAsync(
                    "linkToPageSection",
                    sectionId);
        }
    }
}