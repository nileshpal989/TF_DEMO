using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDCORE.Models
{
    public class Cust_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Customer ID")]
        public int id { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        public string Cust_Name { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Cust_Address { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Cust_Email { get; set; }

        [Required]
        [DisplayName("Contact No.")]
        public int Cust_MOBILE { get; set; }
    }
    public class Products
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Qty { get; set; }
    }
    public class EmpDetails
    {
        [Key]
        public int Empid { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public string EMPNAME { get; set; }
        [Required]
        [DisplayName("Employee Address")]
        public string EMPADDRESS { get; set; }
        [Required]
        public int SALARY { get; set; }
    }
    public class EmpDetails1223
    {
        [Key]
        public int Empid { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public string EMPNAME { get; set; }
        [Required]
        [DisplayName("Employee Address")]
        public string EMPADDRESS { get; set; }
        [Required]
        public int SALARY { get; set; }
    }
}
