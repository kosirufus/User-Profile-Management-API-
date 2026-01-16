using Microsoft.AspNetCore.Identity;  //alows me to use or inherit from "IdentityUser"
using System.ComponentModel.DataAnnotations;  //referenced in order to use [Required] attribute at line 8

namespace User_Profile_Management_API.Models
{
    public class User : IdentityUser
    {

        [Required]
        public string Name { get; set;  } = string.Empty;   //string.Empty is used to initialize Name property with an empty string instead of null

        public DateTime DateOfBirth { get; set; }

        public byte[]? ProfilePicture { get; set; }  //byte array to store binary data of profile picture, nullable to allow users without a profile picture

        [Required]
        public string ShortDescription { get; set; } = string.Empty;
    }
}
