using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Model
{
    [Table("Subjects")]
    public class SubjectsModel
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("SubjectName")]
        public string SubjectName { get; set; }
        [Column("Description")]
        public string Description { get; set; }
    }
}
