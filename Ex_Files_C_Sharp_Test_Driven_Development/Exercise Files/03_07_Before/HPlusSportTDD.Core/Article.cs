using System.ComponentModel;

namespace HPlusSportTDD.Core
{
    public class Article
    {
        public Article()
        {
        }

        [DisplayName("SKU")]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}