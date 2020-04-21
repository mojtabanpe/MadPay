using System;
using System.ComponentModel.DataAnnotations;

namespace MadPay724.Data.Models
{
    public class Photo : BaseEntity<string>
    {
        public Photo()
        {
            ID = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string URL { get; set; }
        public string Description { get; set; }
        [Required]
        public string Alt { get; set; }
        [Required]
        public bool IsMain { get; set; }
        public User User { get; set; }
        [Required]
        public string UserID { get; set; }

    }
}