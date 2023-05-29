using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WinformsAPIConnection.Models
{
    public class JM_User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }

        public string ProfilePhotoMIMEType { get; set; }

        public string ProfilePhotoURL { get; set; }
    }
}
