namespace AspNetMvc.Domain.Entities
{
    public class Product
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public decimal value { get; set; }
        public bool avaliable { get; set; }
        public int idClient { get; set; }
        public virtual Client client { get; set; }
    }
}
