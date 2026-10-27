using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Model;

namespace HealthPortal.Model.DTO
{
    internal class DTOPatientAdministration : dbContext
    {
        //Atributos

        //Paciente
        private int idPatient;
        private string name;
        private string lastName;
        private int role;
        private string addRole;



        //Estudiante
        private string code;
        private int idGradeSection;

        //Grade seccion
        private string technicalGroup;
        private int specialty;
        private int grade;
        private int academicSection;


        //Visita
        private DateTime date;
        private string time;
        private int medicine;
        private string observation;
        private int idPersona;
        private string personName;
        private string username;
        private int idVisit;

        //Inventario
        private int idInventary;
        private int quantityPackage;
        private int newQuantity;
        private int Package;

        //Admin
        private string usernameAdmin;
        private string password;
        private bool delete;

        //Metodos
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Role { get => role; set => role = value; }
        public string Code { get => code; set => code = value; }
        public int IdGradeSection { get => idGradeSection; set => idGradeSection = value; }
        public string TechnicalGroup { get => technicalGroup; set => technicalGroup = value; }
        public int Specialty { get => specialty; set => specialty = value; }
        public int Grade { get => grade; set => grade = value; }
        public int AcademicSection { get => academicSection; set => academicSection = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public int Medicine { get => medicine; set => medicine = value; }
        public string Observation { get => observation; set => observation = value; }
        public int IdPatient { get => idPatient; set => idPatient = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string PersonName { get => personName; set => personName = value; }
        public string Username { get => username; set => username = value; }
        public int IdInventary { get => idInventary; set => idInventary = value; }
        public int QuantityPackage { get => quantityPackage; set => quantityPackage = value; }
        public int NewQuantity { get => newQuantity; set => newQuantity = value; }
        public int IdVisit { get => idVisit; set => idVisit = value; }
        public int Package1 { get => Package; set => Package = value; }
        public string AddRole { get => addRole; set => addRole = value; }
        public string Password { get => password; set => password = value; }
        public string UsernameAdmin { get => usernameAdmin; set => usernameAdmin = value; }
        public bool Delete { get => delete; set => delete = value; }
    }
}