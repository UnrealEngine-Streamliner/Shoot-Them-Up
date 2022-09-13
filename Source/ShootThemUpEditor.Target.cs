// Shoot Them Up Game, All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootThemUpEditorTarget : TargetRules
{
	public ShootThemUpEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		bOverrideBuildEnvironment = true;
		AdditionalCompilerArguments = "-Wno-unused-but-set-variable";
		ExtraModuleNames.AddRange( new string[] { "ShootThemUp" } );
	}
}
