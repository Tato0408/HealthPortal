using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HealthPortal.Model.DTO
{
     class DTOSectionAdministration : dbContext
    {
        private int sectionID;
        private string technicalGroup;
        private string grade;
        private int gradeID;
        private string academicSection;
        private string specialty;
        private int specialtyID;
        private int academicSectionID;

        public int SectionID { get => sectionID; set => sectionID = value; }
        public string TechnicalGroup { get => technicalGroup; set => technicalGroup = value; }
        public string Grade { get => grade; set => grade = value; }
        public int GradeID { get => gradeID; set => gradeID = value; }
        public string AcademicSection { get => academicSection; set => academicSection = value; }
        public string Specialty { get => specialty; set => specialty = value; }
        public int SpecialtyID { get => specialtyID; set => specialtyID = value; }
        public int AcademicSectionID { get => academicSectionID; set => academicSectionID = value; }
    }
}
