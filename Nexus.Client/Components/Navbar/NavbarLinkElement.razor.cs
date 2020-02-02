using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace Nexus.Client.Components
{
    public class NavbarLinkElementBase : ComponentBase 
    {
        [Parameter] public EventCallback<string> OnClick { get; set; }
        [Parameter] public string SectionLinkId { get; set; }
        [Parameter] public string LinkText { get; set; }
    }
}