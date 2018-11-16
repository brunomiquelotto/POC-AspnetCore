namespace Db
{
    public class Derivation
    {
        public int DerivationId { get; set; }
        public string Description { get; set; }
        public int ResidueId { get; set; }
        public Residue Residue { get; set; }
    }
}