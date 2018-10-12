using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel.Model
{
    [Table("Membership")]
    public class Membership : IdentityUser<Guid>
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }
        [MaxLength(256)]
        public string Avatar { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime DateModified { get; set; }

    }
}
