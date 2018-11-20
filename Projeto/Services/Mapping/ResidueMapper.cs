namespace Projeto.Services.Mapping
{
    public static class ResidueMapper
    {
        public static Db.Residue MapFrom(Domain.Residue residueDto)
        {
            return new Db.Residue()
            {
                ResidueId = residueDto.Id,
                ResidueName = residueDto.Name
            };
        }

        public static Domain.Residue MapFrom(Db.Residue residue)
        {
            return new Domain.Residue()
            {
                Id = residue.ResidueId,
                Name = residue.ResidueName
            };
        }
    }
}