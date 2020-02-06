using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace Nexus.Client.Components
{
    public class AboutSectionButtonBase : ComponentBase
    {
        [Parameter] public EventCallback OnClick { get; set; }
        [Parameter] public string ButtonText { get; set; }
        [Parameter] public string Icon { get; set; }
        protected string FontAwesomeIconString { get; set; }

        public AboutSectionButtonBase()
        {
            FontAwesomeIconString = $"fas fa-{Icon}";
        }
    }
}