using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace Nexus.Client.Components
{
    public class HeroButtonBase : ComponentBase
    {
        [Parameter] public string ButtonText { get; set; }
        [Parameter] public string SectionLinkId { get; set; }
        [Parameter] public EventCallback<string> OnClick { get; set; }
    }
}