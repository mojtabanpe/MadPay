using System;
using System.ComponentModel.DataAnnotations;

namespace MadPay724.Data.Models
{
    public class BankCard : BaseEntity<string>
    {
        public BankCard()
        {
            ID = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string Sheba { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string ExpiredDateMonth { get; set; }
        [StringLength(2,MinimumLength = 2)]
        [Required]
        public string ExpiredDateYear { get; set; }
        public User User { get; set; }
        [Required]
        public string UserID { get; set; }

    }
}
