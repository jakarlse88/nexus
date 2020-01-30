using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Nexus.Components 
{
    public class HeroBase : ComponentBase
    {
        private readonly IJSRuntime _jsRuntime;
        public ElementReference _particles { get; set; }
        public string Title = "Jon Karlsen";
        public string Subtitle = "Developer // Black Belt";

        public HeroBase()
        {
        }

        public HeroBase(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        // protected override async Task OnAfterRenderAsync(bool firstRender){
        //     if (firstRender)
        //     {
        //         await _jsRuntime.InvokeVoidAsync("particlesLoad", _particles);
        //     }
        // }
    }
}