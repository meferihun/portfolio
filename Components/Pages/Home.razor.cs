namespace Portfolio_Page.Components.Pages;

public partial class Home
{
    private sealed record Skill(string Category, string[] Items);

    private sealed record TimelineEntry(string Period, string Title, string Org, string Description);

    private sealed record Project(string Title, string Description, string[] Tags, string? RepoUrl, string? DemoUrl);

    private static readonly Skill[] skillGroups =
    [
        new("Languages", ["C#", "Java", "JavaScript", "SQL", "Python", "HTML", "CSS"]),
        new("Frameworks", [".NET / ASP.NET Core", "Blazor WebAssembly", "Entity Framework Core", "Java Spring"]),
        new("Tools & Data", ["Git", "SQL Server", "Visual Studio"]),
        new("Practices", ["Agile (Scrum)", "Unit & Integration Testing", "Clean Code", "Code Review"]),
    ];

    private static readonly TimelineEntry[] timeline =
    [
        new("2025 — Present", "Junior Software Developer Intern", "evosoft Hungary Kft.",
            "Developing a large-scale enterprise web application using C#/.NET and Blazor WebAssembly. Collaborating daily within a 12-person Scrum team, participating in agile ceremonies, and writing unit/integration tests to ensure stable delivery."),
    
        new("2021 — 2026", "Computer Science Graduate", "University of Szeged",
            "Graduated with a strong foundation in OOP, algorithms, and agile software development. Created an interactive VR application for industrial automation systems as my thesis project."),
    ];
    private static readonly Project[] projects =
    [
        new(
            "Industrial VR Simulation",
            "An interactive Virtual Reality application built from scratch for exploring and connecting industrial drive systems, handling complex physics and user interactions.",
            ["C#", "Unity", "VR Development", "3D Modeling"],
            null,
            null),
        new(
            "News Aggregator API",
            "A backend service for a news aggregator web application, demonstrating practical application of MVC architecture and RESTful API endpoint creation.",
            ["Java", "Spring Boot", "REST API"],
            "https://github.com/meferihun/Hirkereso-Java-Spring",
            null),
        new(
            "Algorithmic Challenges",
            "A collection of solutions for Advent of Code and classic games (like Snake in WinForms), focusing on clean data structures and robust OOP principles.",
            ["C#", "OOP", "WinForms"],
            "https://github.com/meferihun/Advent-of-Code",
            null),
    ];
}
