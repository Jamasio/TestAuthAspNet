using Microsoft.AspNetCore.Authorization;

namespace TestAuthAspNet.Authorization;

public class HRManagerProbationRequirement : IAuthorizationRequirement
{
    public HRManagerProbationRequirement(int probationMonths)
    {
        ProbationMonths = probationMonths;
    }
    public int ProbationMonths { get; set; }
}
