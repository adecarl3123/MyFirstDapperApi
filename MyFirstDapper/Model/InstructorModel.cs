using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MyFirstDapper.Model
{
    [Table("Instructor")]
    public class InstructorModel
    {
        [Key]
        [Column ("Id")]
        public int Id{ get; set;}
        [Column ("FirstName")]
        public string FirstName
        {
            get; set;
        }
        [Column ("LastName")]
        public string LastName
        {
            get; set;
        }
    }
}
