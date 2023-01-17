using NttData.FileManagement.Business.Logic.Contracts;
using System;
using NttData.FileManagement.Common.Model;
using NttData.FileManagement.Business.Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NttData.FileManagement.Business.Logic.Implementations;

namespace NTTData.FileManagement.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IStudentService studentService = new StudentService();
            Student student =new Student();
            student.Name=txtName.Text;
              
             
            studentService.Add(student);
            MessageBox.Show("Student saved");   
        }
    }
}
