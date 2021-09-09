using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SQLite_WinForms_NETFramework_CodeFirst.Entities;

namespace SQLite_WinForms_NETFramework_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butAddShift_Click(object sender, EventArgs e)
        {
            using (var context = new TestContext())
            {
                if (int.TryParse(tBoxNumberShift.Text, out int numberShift))
                {
                    var shift = new Shift() { Number = numberShift };

                    context.Shifts.AddRange(shift);

                    context.SaveChanges();

                    tBoxNumberShift.Text = "";
                }
                else
                {
                    tBoxNumberShift.Text = "Вы должны ввести число!!!";
                }
            }
        }

        private void butAddCashVoucher_Click(object sender, EventArgs e)
        {
            using (var context = new TestContext())
            {
                if (int.TryParse(tBoxCashVoucherNumber.Text, out int numberCashVoucher))
                {
                    if (int.TryParse(tBoxShiftId.Text, out int shiftId))
                    {
                        var cashVoucher = new CashVoucher() { Number = numberCashVoucher, Shift = context.Shifts.Single(p => p.Id == shiftId) };

                        context.CashVouchers.AddRange(cashVoucher);

                        context.SaveChanges();

                        tBoxCashVoucherNumber.Text = "";
                        tBoxShiftId.Text = "";
                    }
                    else
                    {
                        tBoxShiftId.Text = "Вы должны ввести число!!!";
                    }
                }
                else
                {
                    tBoxCashVoucherNumber.Text = "Вы должны ввести число!!!";
                }
            }
        }

        private void butGetAllCashVoucher_Click(object sender, EventArgs e)
        {
            using (var context = new TestContext())
            {
                var cashVouchers = context.CashVouchers.Include(shift => shift.Shift).ToList();

                foreach (var cashVoucher in cashVouchers)
                {
                    tBoxConsole.Text = $"{tBoxConsole.Text}Номер чека - {cashVoucher.Number} в смене номер - {cashVoucher.Shift.Number}{Environment.NewLine}";
                }
            }
        }
    }
}
