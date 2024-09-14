using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Directives

namespace MyFirstDapper.Model
{

    [Table("Student")]
    public class StudentModel
    {
        [Key]
       
        //Pwedeng di na isama kapag parehas ang attribute sa db
        public int Id { get; set; }
        [Column("First_Name")]
        public string First_Name { get; set; }
        [Column("Last_Name")]
        public string Last_Name { get; set; }
    }
}
