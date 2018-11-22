namespace Projeto.Services.Mapping
{
    public static class CompanyMapper
    {
        public static Db.Company MapFrom(Domain.Company companyDto)
        {
            return new Db.Company()
            {
                CompanyId = companyDto.Id,
                Name = companyDto.Name
            };
        }

        public static Domain.Company MapFrom(Db.Company company)
        {
            return new Domain.Company()
            {
                Id = company.CompanyId,
                Name = company.Name
            };
        }
    }
}