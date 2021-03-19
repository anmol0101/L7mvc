////////////////////////////////////
//CHANGE HISTORY////////////////////////////
//date             Developer             Description 
//2021-03-12        Anmol               created the course class for the student database 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversity.Models
{
    //tinfo[2021-03-04-anmol01-dykstra]- this class is 
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
