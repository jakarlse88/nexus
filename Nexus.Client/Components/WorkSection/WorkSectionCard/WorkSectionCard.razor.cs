using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Nexus.Client.Components.WorkSection.WorkSectionCard
{
    public class WorkSectionCardBase : ComponentBase
    {
        [Parameter] public string Heading { get; set; }
        [Parameter] public string Text { get; set; }
        [Parameter] public string Image { get; set; }
        [Parameter] public string GitHubProjectLink { get; set; }
        [Parameter] public string TagOne { get; set; }
        [Parameter] public string TagTwo { get; set; }
        [Parameter] public string TagThree { get; set; }
    }
}