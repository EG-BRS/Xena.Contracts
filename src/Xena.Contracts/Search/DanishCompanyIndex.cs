using System.ComponentModel;

namespace Xena.Contracts.Search
{
    public class DanishCompanyIndex
    {
        public string CompanyName { get; set; }
        public string CoName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string PlaceName { get; set; }
        public string CVRNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        private string _id = null;
        [ReadOnly(true)]
        public string Id
        {
            get { return _id ?? CVRNumber; }
            set { _id = value; }
        }
    }
}