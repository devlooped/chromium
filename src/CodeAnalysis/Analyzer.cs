using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Devlooped.Chromium;

[DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
class SponsorLinker : SponsorLink
{
    static readonly SponsorLinkSettings settings = SponsorLinkSettings.Create("devlooped", "chromium", 
        quietDays: ThisAssembly.Project.RepositoryBranch == "main" ? 0 : null);

    public SponsorLinker() : base(settings)
    { }
}