// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.

using Flax.Build;
using Flax.Build.NativeCpp;

/// <summary>
/// https://github.com/adswerve/universal-analytics-c
/// </summary>
public class UniversalAnalytics : ThirdPartyModule
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        LicenseType = LicenseTypes.BSD3Clause;
    }

    /// <inheritdoc />
    public override void Setup(BuildOptions options)
    {
        base.Setup(options);

        options.PrivateDependencies.Add("curl");
    }
}
