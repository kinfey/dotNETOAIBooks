using Microsoft.SemanticKernel.SkillDefinition;
using Microsoft.SemanticKernel.Orchestration;
public class CompanySearchSkill
{
    [SKFunction("search employee infomation")]
    public string EmployeeSearch(string input)
    {
        return "欢迎了解社保相关内容";
    }

    [SKFunction("search weather")]
    public string WeatherSearch(string text)
    {
        return "Guangzhou, 2 degree,rainy";
    }
}