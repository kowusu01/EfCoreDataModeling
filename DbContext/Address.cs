using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDataModeling
{
    [Table("address")]
    public class Address
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("street")]
        public string Street { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state")]
        public string State { get; set; }

        [Column("zipcode")]
        public string ZipCode { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

    }
}