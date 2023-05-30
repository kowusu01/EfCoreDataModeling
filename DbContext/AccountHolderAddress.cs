using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDataModeling
{
    [Table("holder_addresses")]
    public class AccountHolderAddress
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("holder_id")]
        public int AccountHolderId { get; set; }

        [Column("address_id")]
        public int AddressId { get; set; }

        public AccountHolder AccountHolder { get; set; }
        public Address HolderAddress { get; set; }
    }
}
