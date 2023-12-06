using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Character;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService //esta interfaz se va a usar para el characterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters(); //los dtos los creamos para que en los casos en los que queramos devlver ciertos modelos sin todas sus propiedades, en ves de devolver el modelo en si, devolvemos el modelo pero solo con las propiedades que necesitamos, eso es un dto, un modelo con ciertas propiedades. Su utilidad se basa en la optimizacion.

        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}