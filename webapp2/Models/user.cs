//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public string UserId { get; set; } = Guid.NewGuid() + "";
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre es requerido")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Correo requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        public string Password { get; set; }
        public string Gender { get; set; } = "M";
        public string GenderType {
            get {
                string gender = Gender;
                if (gender.Equals("M"))
                {
                    return "Masculino";
                }
                return "Femenino";
            }
            set
            {
                if (value.Equals("Masculino"))
                {
                    Gender = "M";
                } else
                {
                    Gender = "F";
                }
            }
        }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public Nullable<System.DateTime> RefactoringDate {
            get { return BirthDate; }
            set { BirthDate = value; }
        }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> UsingDate
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }
        public Nullable<System.DateTime> CreatedAt { get; set; } = DateTime.Now;
        public Nullable<System.DateTime> UpdatedAt { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Cui requerido")]
        public string Cui { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public Nullable<int> RolId { get; set; }
        public Nullable<bool> Enabled { get; set; } = true;

        public string isEnabled
        {
            get {
                if (Enabled != null)
                {
                    return (Enabled != false) ? "Si" : "No";
                } else
                {
                    return "";
                }
            }
        }
    
        public virtual rol rol { get; set; }
    }
}
