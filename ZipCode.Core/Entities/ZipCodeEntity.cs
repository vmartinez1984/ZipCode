using System.ComponentModel.DataAnnotations;

namespace ZipCode.Core.Entities
{
    public class ZipCodeEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(5)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(250)]
        public string Municipality { get; set; }

         [StringLength(50)]
        public string City { get; set; }

         [StringLength(50)]
        public string SettementType { get; set; }

         [StringLength(100)]
        public string Settement { get; set; }
    }
}