using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_05.Controllers;


[ApiController]
[Route("api/challenge")]
public class ChallengeMethodController : ControllerBase
{
    [HttpGet(Name = "ChallengeMethod")]
    public string Get()
    {
        string name = "OpenShift DevSpaces";
        return ChallengeMethod(name);
    }

    public string ChallengeMethod(string name)
    {
        if (name.Length > 4)
        {
            // Zero-based index system
            char fifthCharacter = name[4];
            return $"The Fifth Character in \"{name}\" is [{fifthCharacter}]\n";
        }

        return "String is shorter than length 5 \n";
    }

    // Overloaded method
    public string ChallengeMethod(string name, int index)
    {
        if (index >= 0 && index < name.Length)
        {
            char character = name[index];
            return $"The Character at index [{index}] in \"{name}\" is [{character}]\n";
        }
        return $"Index [{index}] is out of bounds for \"{name}\"\n";
    }
}