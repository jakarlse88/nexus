using Microsoft.AspNetCore.Components;

namespace Nexus.Client.Components.SkillSection.SkillSectionCard
{
    public class SkillSectionCardBase : ComponentBase 
    {
        [Parameter] public string Heading { get; set; }
        [Parameter] public string Text { get; set; }
    }
}