namespace NMCT.Resto.Core.Model
{
    public class Location
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }

        public override string ToString()
        {
            return Address + " " + City + " " + Locality;
        }
    }
}
