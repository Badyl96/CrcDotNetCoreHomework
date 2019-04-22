using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrcDotNetCoreHomeworkWebApi.Model
{
    public class Library
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [MaxLength(13,ErrorMessage = "Isbn cannot be greater than 13"),MinLength(13, ErrorMessage = "Isbn cannot be less than 13")]
        public string Isbn { get; set; }

        [Required]
        public DateTime Year { get; set; }
    }
}
