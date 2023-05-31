using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDataModeling
{
    /// <summary>
    /// Relationship table
    /// </summary>

    [Table("holder_account")]
    public class UserAccount
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("holder_id")]
        public int UserId { get; set; }

        [Column("account_id")]
        public int AccountId { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        // one-to-one
        public AccountHolder AccountHolder { get; set; }

        // one-to-one
        public BankAccount Account { get; set; }

    }
}