using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DzMathLibrary;


namespace DzWebForm
{
    public partial class DzMath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnResult.Click += BtnResult_Click;
        }
        private void BtnResult_Click(object sender, EventArgs e)
        {
            double.TryParse(tbA.Text, out double A);
            double.TryParse(tbB.Text, out double B);
            double.TryParse(tbC.Text, out double C);

            if (A == 0 && B == 0 && C == 0)
            {
                LabeltText.Text = "Введите переменные";
                return;
            }

            Dictionary<string, object> result =Equation.Parameters(A, B, C);

            LabeltText.Text = result["Comment"].ToString();
            LabeltD.Text = result["D"].ToString();
            LabeltX1.Text = result["X1"].ToString();
            LabeltX2.Text = result["X2"].ToString();



        }
    }
}