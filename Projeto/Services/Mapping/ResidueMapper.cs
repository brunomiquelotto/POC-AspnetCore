using Domain;
using Db;

namespace Projeto.Services.Mapping
{
    public static class ResidueMapper
    {
        public static Residue MapFrom(ResidueDto residueDto)
        {
            return new Residue()
            {
                ResidueId = residueDto.Id,
                ResidueName = residueDto.Name
            };
        }

        public static ResidueDto MapFrom(Db.Residue residue)
        {
            return new ResidueDto()
            {
                Id = residue.ResidueId,
                Name = residue.ResidueName
            };
        }
    }
}