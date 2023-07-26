using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNET_RPG.Controllers;
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Services
{
    public class CharacterService: ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character {Id = 1, Name = "Gordan Ryan" },
            new Character {Id = 2, Name = "Craig Jones" },
            new Character { Id = 3, Name = "Felipe Pena" }
        };

        


        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            var id = characters.Max(c => c.Id) + 1;
            newCharacter.Id = id;
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

      

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>
            {
                Data = characters
            };
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = character;
            return serviceResponse;
        }

   
    }
}