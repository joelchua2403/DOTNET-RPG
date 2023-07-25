using System.Text.Json.Serialization;

namespace DOTNET_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        GuardPlayer = 1,
        Wrestler = 2,
        GuardPasser = 3,
        Scrambler = 4
    }
}