namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
    
        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller s)
        {
            Sellers.Add(s);
        }

        public void RemoveSeller(Seller s)
        {
            Sellers.Remove(s);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(s => s.TotalSales(initial, final));
        }
    }
}
