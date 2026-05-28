namespace MeWeb.Models;

public class ResumeDataProvider
{
    public ResumeData Resume { get; } =
        new (
            Person: new PersonInfo(
                Name: "Dmitrii Ordenov",
                Title: "Senior/Lead .NET Developer",
                Location: "Luxembourg",
                Email: "dima.ordenov@gmail.com",
                Phone: "+352 661 150 491",
                LinkedIn: "linkedin.com/in/daordenov",
                GitHub: "github.com/DimaOrdenov",
                Permit: "EU Work Permit"
            ),
            Summary:
            "Senior .NET Engineer and Team Lead with 8+ years of experience, having grown from individual contributor to leading a cross-functional mobile team at Artec 3D. Deep technical expertise in C#, .NET iOS/Android, and full-stack development – from native hardware integration and 3D rendering to REST API design, database management, and CI/CD infrastructure. As a team lead, define architectural standards, mentor engineers, own delivery pipelines, and ship under tight deadlines. Regularly build full-stack solutions at hackathons (Blazor WASM, .NET Core, PostgreSQL, Docker), combining hands-on engineering with a product mindset.",
            Skills:
            [
                new ("Programming languages", ["C#", "HTML/CSS", "Kotlin/Java", "Swift", "Python"]),
                new ("Mobile", [".NET iOS/Android", "ReactiveUI", "Firebase", "Filament", "SceneKit", "Polly"]),
                new ("Backend / Web", [".NET Core", "ASP.NET Core", "Blazor WASM", "REST API", "SignalR", "Serilog", "Swagger / OpenAPI"]),
                new ("Databases", ["EF Core", "PostgreSQL", "MSSQL", "SQLite", "MySQL", "Redis"]),
                new ("Tests", ["XUnit", "Moq", "Integration Tests"]),
                new ("DevOps", ["Docker", "Jenkins", "GitHub Actions", "Bitbucket Pipelines", "CI/CD"]),
                new ("Project management", ["Jira", "Confluence", "Figma", "UML diagrams", "Other illustration tools"]),
                new ("Architecture", ["MVVM", "MVC", "Rx", "Clean Architecture", "SOLID", "DI"]),
            ],
            Experiences:
            [
                new (
                    Title: "Team Lead of Mobile Development",
                    Company: "Artec 3D",
                    Period: "Feb 2024 – Present",
                    Location: "Luxembourg",
                    Bullets:
                    [
                        "Lead a cross-functional team (engineer, 2 QA, UX/UI, Product Owner) delivering 3D scanning mobile applications.",
                        "Own mobile CI/CD infrastructure on Jenkins/Bitbucket; define coding standards and architectural guidelines.",
                        "Shipped the Artec Photogrammetry app for FormNext exhibition within a 1-month deadline; implemented automated Camera API exposure control.",
                        "Led the full migration from Xamarin Native to .NET iOS/Android.",
                    ],
                    AppLinks:
                    [
                        new ("Artec Remote", "https://apps.apple.com/us/app/artec-remote/id1398067054", "ios"),
                        new ("Artec Remote", "https://play.google.com/store/apps/details?id=com.artec3d.ArtecRemote&hl=en_US", "android"),
                        new ("Artec Photogrammetry", "https://apps.apple.com/us/app/artec-photogrammetry/id6751812137", "ios"),
                        new ("Artec Photogrammetry", "https://play.google.com/store/apps/details?id=com.artec3d.photogrammetry&hl=en_US", "android"),
                    ]
                ),
                new (
                    Title: "Mobile Developer (.NET)",
                    Company: "Artec 3D",
                    Period: "Jul 2021 – Feb 2024",
                    Location: "Hybrid / Montenegro",
                    Bullets:
                    [
                        "Built high-performance point cloud visualization using Filament (Android) and SceneKit (iOS): 3D Orbital, Panorama, and 3D Map view modes.",
                        "Engineered scanner control modules over Wi-Fi using native SDKs and SOAP protocols.",
                        "Integrated Zendesk support module, multi-channel auth (Social, Login/Password, App Links), and custom push-tap notification flow.",
                        "Stack: .NET iOS/Android, C#, Filament, SceneKit, Jenkins, Bitbucket.",
                    ]
                ),
                new (
                    Title: ".NET Developer",
                    Company: "MTS Group",
                    Period: "Aug 2019 – Jun 2021",
                    Location: "Moscow, Russia",
                    Bullets:
                    [
                        "Developed a corporate employee app (news feed, org chart, Helpdesk ticketing) using .NET mobile stack.",
                        "Built .NET Core REST APIs and managed MSSQL databases for backend services.",
                        "Created Windows background services for data synchronization; initiated a candidate onboarding app.",
                        "Stack: .NET, C#, MSSQL.",
                    ],
                    AppLinks:
                    [
                        new ("Our MTS", "https://apps.apple.com/ru/app/%D0%BD%D0%B0%D1%88-%D0%BC%D1%82%D1%81/id1555264079", "ios"),
                        new ("Our MTS", "https://play.google.com/store/apps/details?id=ru.mts.ourmts&hl=ru&pli=1", "android"),
                    ]
                ),
                new (
                    Title: "Mobile & Web Developer",
                    Company: "smartseeds.ru",
                    Period: "Aug 2017 – Jul 2019",
                    Location: "Moscow, Russia",
                    Bullets:
                    [
                        "Built the company's first mobile app from scratch (.NET mobile): auth, order tracking, route mapping.",
                        "Created native C# bindings for Android/iOS push notification libraries; built a Wi-Fi PDF printing module.",
                        "Maintained backend features in PHP (Symfony) + MySQL.",
                    ],
                    AppLinks:
                    [
                        new ("Smartseeds", "https://apps.apple.com/us/app/smartseeds-2-0/id1581400249", "ios"),
                        new ("Smartseeds", "https://play.google.com/store/apps/details?id=com.smartseeds.cargoowners", "android"),
                    ]
                ),
            ],
            Hackathons:
            [
                new (
                    Name: "LCT 2025",
                    Subtitle: "Leaders of Change Technology",
                    Year: "2025",
                    Tags: ["Blazor WASM (PWA)", ".NET Core API", "PostgreSQL", "Docker", "nginx"],
                    Description: "Full-stack gamification platform",
                    GitHubUrl: "https://github.com/NoTryCatchTeam/Lct2025"
                ),
                new (
                    Name: "NASA Space Apps Challenge",
                    Subtitle: "International Hackathon",
                    Year: "2024",
                    Tags: ["Blazor", "HTML/JS", "three.js"],
                    Description: "Interactive space data visualization",
                    GitHubUrl: "https://github.com/NoTryCatchTeam/NasaChallenge2024"
                ),
                new (
                    Name: "LCT 2023",
                    Subtitle: "Leaders of Change Technology",
                    Year: "2023",
                    Tags: [".NET iOS/Android", ".NET Core API", "PostgreSQL", "Docker"],
                    Description: "Art education mobile app",
                    GitHubUrl: "https://github.com/NoTryCatchTeam/Lct2023"
                ),
                new (
                    Name: "Leaders of Digital",
                    Subtitle: "Federal Hackathon Finals",
                    Year: "2020 – 2022",
                    Tags: ["C#", ".NET"],
                    Description: "Multiple federal hackathon finals"
                ),
            ],
            Education: new (
                Degree: "Engineer-Specialist, CAD/CAM/CAE & Engineering IT",
                School: "Moscow State Technical University (BMSTU)",
                Period: "2010 – 2016"
            ),
            Languages:
            [
                new ("English", "C1", 85),
                new ("French", "B1", 50),
                new ("Russian", "Native", 100),
            ]
        );
}
