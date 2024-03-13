using System.Drawing;

namespace Task_11_PointAndMouse
{
    public partial class Form1 : Form
    {
        Point piste = new Point(0, 0);
        private string tbDefault = "Enter coordinates for x,y";

        public Form1()
        {
            InitializeComponent();
            textBox_Coordinates.Text = tbDefault;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;

            // - Pää 

            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,

            piste.X + 21, piste.Y + 131);

            // - Kädet 

            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,

            piste.X + 70, piste.Y + 60);

            // - Jalat 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X + 70, piste.Y + 181);

            // Kutsutaan DrawCoordinates()-metodia. 
            DrawCordinates(Graf);
        }

        private void DrawCordinates(Graphics Graf)
        {

            // Piirretään piirtokoordinaattien arvot näytölle. 

            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                            new SolidBrush(Color.Black), 8, 30);
        }

        private void button_EnterDesireXY_Click(object sender, EventArgs e)
        {
            string[] coordinates = textBox_Coordinates.Text.Split(',');
            if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int x) && int.TryParse(coordinates[1], out int y))
            {
                piste.X = x;
                piste.Y = y;
                // Trigger the form to redraw itself
                Invalidate();
            }
            else
            {
                MessageBox.Show("Invalid input format. Please enter coordinates in the format 'x,y'.");
            }
        }

        private void textBox_Coordinates_Enter(object sender, EventArgs e)
        {
            if (textBox_Coordinates.Text == tbDefault)
            {
                textBox_Coordinates.Text = "";
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    // Stores the current mouse location as the new coordinate point
                    piste = e.Location;

                    // Trigger the form to redraw itself
                    Invalidate();
                }
            }
        }
    }
}
