using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDataModeling
{

    [Table("bank_account")]
    public class BankAccount
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("account_type")]
        public string AccountType { get; set; }

        [Column("balance")]
        public double Balance { get; set; }

        [Column("[account_status")]
        public string AccountStatus { get; set; }
    }
}