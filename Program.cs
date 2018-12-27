using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    static class Program
    {
        /// Assignment #2
        /// Course CO7518 – Business Information Systems
        /// Student #169042233
        /// 
        /// Loan Calculator 
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
