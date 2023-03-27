using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormDepartment : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FormDepartment()
        {
            InitializeComponent();
            random = new Random();
        }

        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    //DisableButton();
                    //Color color = SelectThemeColor();
                    currentButton = (Button)buttonSender;
                    //currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //this.panel1.Controls.Add(childForm);
            //this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonDepartmentSedRedBg_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSED(), sender);
            /*this.Hide();
            FormSED form_SedDept = new FormSED();
            form_SedDept.Show();*/
        }

        private void buttonDepartmentIbedRedBg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIBED form_IbedDept = new FormIBED();
            form_IbedDept.Show();
        }

        private void buttonDepartmentVioletBg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIBED form_IbedDept = new FormIBED();
            form_IbedDept.Show();
        }

        private void buttonDepartmentOrangeBg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSED form_SedDept = new FormSED();
            form_SedDept.Show();
        }

        private void buttonDepartmentAspRedBg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormASP form_AspDept = new FormASP();
            form_AspDept.Show();
        }

        private void buttonDepartmentBlueBg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormASP form_AspDept = new FormASP();
            form_AspDept.Show();
        }
    }
}
