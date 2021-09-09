using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLite_WinForms_NETFramework_CodeFirst.Entities
{
    public class Shift
    {
        public int Id { get; set; }

        [DisplayName("Номер смены")]
        public int Number { get; set; }
        
        [InverseProperty("Shift")]
        public virtual ICollection<CashVoucher> CashVouchers { get; set; }
    }
}