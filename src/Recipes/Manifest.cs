using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Sample Recipes",
    Author = "Antoine Griffard",
    Website = "http://antoinegriffard.com",
    Version = "2.0.0",
    Description = "Provides sample recipes.",
    Dependencies = new[] { "OrchardCore.Recipes" },
    Category = "Recipes"
)]
