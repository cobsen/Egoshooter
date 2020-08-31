// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class Shooter1 : ModuleRules
{
	public Shooter1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
        if (Target.Platform == UnrealTargetPlatform.HTML5)
        {
            string path = System.IO.Path.Combine(ModuleDirectory, "SampleHTML5.js").Replace("\\", "/");
            System.Console.WriteLine("Include {0}", path);
            PublicAdditionalLibraries.Add(path);
        }
    }
}
