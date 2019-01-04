using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Employee : IEmployee   //Employee class implements IEmployee interface
    {
        private object Person;
        public int empId { get; set; }
        public string empName { get; set; }
        public int empAge { get; set; }
        public Employee(string empName, int empAge)   //parameterised constructor of employee class
        {
            this.empName = empName;
            this.empAge = empAge;
        }

        public Employee(object Person)
        {
            this.Person = Person;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain()); 
        }
    }
}

