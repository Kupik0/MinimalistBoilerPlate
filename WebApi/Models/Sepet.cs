using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WebApi.Models
{
    public class Sepet : BaseEntity
    {

        public int UserId { get; set; }
        public User User { get; set; }
        public bool OnaylandiMi { get; set; } = false;
        public IEnumerable<Kutu> EklenenKutular { get; set; }
    }
}
