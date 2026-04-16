using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_event_app
{
    public partial class ecranIntegration : Form
    {
        public ecranIntegration()
        {
            InitializeComponent();
        }

        public delegate double fctAIntegrer(double x);



        private double AireTrapeze(fctAIntegrer f, double x1, double x2)
        {
            double h = x2 - x1;
            return (f(x1) + f(x2)) * h / 2.0;
        }

       
        double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroit, int nInterval)
        {
            double sommeAire = 0;
            double deltaX = (xDroit - xGauche) / nInterval;

            for (int i = 0; i < nInterval; i++)
            {
                double x1 = xGauche + (i * deltaX);
                double x2 = x1 + deltaX;
                sommeAire += AireTrapeze(f, x1, x2); 
            }
            return sommeAire;
        }

        private void bPolynome_Click(object sender, EventArgs e)
        {
            
            if (!double.TryParse(tbGauche.Text, out double a)) return;
            if (!double.TryParse(tbDroit.Text, out double b)) return;
            if (!int.TryParse(tbNbInt.Text, out int nBase)) nBase = 1;

            lbResultats.Items.Clear();
            lbResultats.Items.Add("Méthode des trapèzes");
            lbResultats.Items.Add("   Polynôme : x*x + 2");

 
            for (int m = 1; m <= 16; m *= 2)
            {
                int nActuel = nBase * m;
                double deltaX = (b - a) / nActuel;
                double aireTotale = 0;

                for (int i = 0; i < nActuel; i++)
                {
                    double x1 = a + i * deltaX;
                    double x2 = x1 + deltaX;

          
                    double f1 = (x1 * x1) + 2;
                    double f2 = (x2 * x2) + 2;
                    aireTotale += (f1 + f2) * deltaX / 2.0;
                }

          
                lbResultats.Items.Add($"      Nb Int : {nActuel} => {aireTotale}");
            }
        }
        double MonPolynome(double x) => (x * x) + 2;
        double MaTrigo(double x) => Math.Sin(x);

        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
 
    if (!double.TryParse(tbGauche.Text, out double a)) return;
            if (!double.TryParse(tbDroit.Text, out double b)) return;
            if (!int.TryParse(tbNbInt.Text, out int nBase)) nBase = 1;

            lbResultats.Items.Clear();
            lbResultats.Items.Add("Méthode des trapèzes");
            lbResultats.Items.Add("   Sinus : sin(x)"); ;

    
            for (int m = 1; m <= 16; m *= 2)
            {
                int nActuel = nBase * m;
                double deltaX = (b - a) / nActuel;
                double aireTotale = 0;

         
                for (int i = 0; i < nActuel; i++)
                {
                    double x1 = a + i * deltaX;
                    double x2 = x1 + deltaX;

             
                    double f1 = Math.Sin(x1);
                    double f2 = Math.Sin(x2);
                    aireTotale += (f1 + f2) * deltaX / 2.0;
                }

       
                lbResultats.Items.Add($"      Nb Int : {nActuel} => {aireTotale}");
            }
        }

        private void bPointeurTrigonometrique_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroit.Text);
            int n = int.Parse(tbNbInt.Text);

     
            double resultat = IntegrationTrapeze(Math.Sin, a, b, n);

            MessageBox.Show($"Résultat Sinus : {resultat}");
        }

        private void bPointeurPolynome_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroit.Text);
            int n = int.Parse(tbNbInt.Text);


            double resultat = IntegrationTrapeze(MonPolynome, a, b, n);

            MessageBox.Show($"Résultat (n={n}) : {resultat}");
        }
    }
}
