// using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
// using Microsoft.JSInterop;

namespace Nexus.Components
{
    public class NavbarBase : ComponentBase 
    {
        // private readonly IJSRuntime _jsRuntime;
        protected readonly string _lambda;
        protected readonly string _brandTitle;
        protected ElementReference _about;

        public NavbarBase()
        {
            _brandTitle = "Jon Karlsen";
        }

        // public NavbarBase(IJSRuntime jsRuntime)
        // {
        //     _brandTitle = "Jon Karlsen";
        //     _jsRuntime = jsRuntime;
        // }

        // public async Task ScrollToSection()
        // {
        //     await _jsRuntime.InvokeVoidAsync("linkToPageSection");
        // }
    }
}