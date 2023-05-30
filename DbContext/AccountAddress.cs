using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDataModeling
{
    [Table("account_address")]
    public class AccountAddress
    {
        public int Id { get; set; }
        public int AccountId { get; set; }  
        public int AddressId { get; set; }

        public BankAccount Account { get; set; }
        public Address PrimaryAddress { get; set; }
    }
}
