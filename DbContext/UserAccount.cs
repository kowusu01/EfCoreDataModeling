using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDataModeling
{
    [Table("holder_account")]
    public class UserAccount
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("holder_id")]
        public int UserId { get; set; }

        [Column("account_id")]
        public int AccountId { get; set; }

        public AccountHolder PrimaryAccountHolder { get; set; }
        public BankAccount Account { get; set; }

    }
}