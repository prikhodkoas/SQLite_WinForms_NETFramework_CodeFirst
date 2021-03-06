using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLite_WinForms_NETFramework_CodeFirst.Entities
{
    public class CashVoucher
    {
        public int Id { get; set; }

        [DisplayName("Номер чека")]
        public int Number { get; set; }

        [DisplayName("ID смены")]
        public int? ShiftId { get; set; }
        
        [InverseProperty("CashVouchers")]
        public virtual Shift Shift { get; set; }
    }
}