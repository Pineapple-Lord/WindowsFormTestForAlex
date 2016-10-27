using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class FormManager
    {
        Form1 f1;
        Retail f2;
        Time f3;
        public void initialize()
        {
            f2 = new Retail();
            f3 = new Time();
            f2.SetFM(this);
            f3.SetFM(this);
        }

        public void SetMenuForm(Form1 f)
        {
            f1 = f;
        }
        public void ShowMenu()
        {
            f2.Show();
            f3.Hide();
            f1.Hide();
        }

        public void ShowTime()
        {
            f1.Show();
            f2.Hide();
            f3.Hide();
        }

        public void ShowRetail()
        {
            f3.Show();
            f2.Hide();
            f1.Hide();
        }
    }
}
