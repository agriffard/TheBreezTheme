using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace TheBreezTheme;

public sealed class TheBreezThemeResourceOptions : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest = new();

    static TheBreezThemeResourceOptions()
    {
        _manifest
            .DefineStyle("TheBreezTheme")
            .SetUrl("~/TheBreezTheme/css/site.css")
            .SetVersion("1.0.0");
    }

    public void Configure(ResourceManagementOptions options)
        => options.ResourceManifests.Add(_manifest);
}
