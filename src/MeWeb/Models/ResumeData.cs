namespace MeWeb.Models;

public record PersonInfo(
    string Name,
    string Title,
    string Location,
    string Email,
    string Phone,
    string LinkedIn,
    string GitHub,
    string Permit
);

public record SkillCategory(string Name, string[] Tags);

public record Experience(
    string Title,
    string Company,
    string Period,
    string Location,
    string[] Bullets
);

public record Hackathon(
    string Name,
    string Subtitle,
    string Year,
    string[] Tags,
    string Description
);

public record Education(string Degree, string School, string Period);

public record LanguageItem(string Language, string Level, int Percent);

public record ResumeData(
    PersonInfo Person,
    string Summary,
    SkillCategory[] Skills,
    Experience[] Experiences,
    Hackathon[] Hackathons,
    Education Education,
    LanguageItem[] Languages
);
