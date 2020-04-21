using System;
using System.ComponentModel.DataAnnotations;

namespace MadPay724.Data.Models
{
    public class BaseEntity<T>
    {
        public BaseEntity()
        {
        }

        [Key]
        public T ID { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime DateModified { get; set; }
    }
}
