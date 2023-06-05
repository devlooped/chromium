using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Devlooped.Chromium;

[DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
class SponsorLinker : SponsorLink
{
    public SponsorLinker() : base("devlooped", "chromium")
    { }
}