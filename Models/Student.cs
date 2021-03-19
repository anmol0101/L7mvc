////////////////////////////////////
//CHANGE HISTORY////////////////////////////
//date             Developer             Description 
//2021-03-10       Anmol                 Created the student menu entries
//2021-03-10       Anmol                 adding the keys such as ID and the EnrollmentDate 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContosoUniversity.Models
{
    public class Student
    {
        //tinfo200:[2021-03-13-anmol01-dykstra2]- Created the primary key for the students for ID  for the database column
        //tinfo200:[2021-03-13-anmol01-dykstra2]- that should corresponds to the class.
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        //tinfo200:[2021-03-13-anmol01-dykstra2]- created the property for the students for the enrollment date 
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments{ get; set; }
    }
}
