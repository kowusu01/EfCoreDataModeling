using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDataModeling
{

    [Table("account_holder")]
    public class AccountHolder
    {
        
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("is_primary")]
        public bool IsPrimary { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("is_vip")]
        public bool IsVIP { get; set; }

    }
}