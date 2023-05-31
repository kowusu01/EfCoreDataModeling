using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDataModeling
{
    [Table("holder_address")]
    public class AccountHolderAddress
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("holder_id")]
        public int AccountHolderId { get; set; }

        [Column("address_id")]
        public int AddressId { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        // one-to-one
        public AccountHolder AccountHolder { get; set; }

        //one-to-one
        public Address HolderAddress { get; set; }
    }
}
