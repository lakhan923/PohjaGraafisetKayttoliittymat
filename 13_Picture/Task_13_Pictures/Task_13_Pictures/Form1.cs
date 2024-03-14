namespace Task_13_Pictures
{
    public partial class Form1 : Form
    {
        private Point mouseClickPoint;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Check if the mouse click point is valid
            if (mouseClickPoint != null)
            {
                // Load the image from resources
                Bitmap hessuImage = Properties.Resources.HessuHopo_png;

                // Make the background of the image transparent
                hessuImage.MakeTransparent(Color.Blue);

                // Draw the image at the mouse click point
                e.Graphics.DrawImage(hessuImage, mouseClickPoint.X, mouseClickPoint.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Capture the mouse click coordinates
            mouseClickPoint = e.Location;

            // Trigger the Paint event to redraw the form
            this.Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // Update the mouse click coordinates
                mouseClickPoint = e.Location;

                // Trigger the Paint event to redraw the form
                this.Invalidate();
            }
        }
    }
}
