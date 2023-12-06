using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //hace que en el swagger se vean las string y no los numeros
    public enum RpgClass //enum que va a tener las clases disponibles para un personaje
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
        Necromancer = 4,
        Archer = 5
    }
}