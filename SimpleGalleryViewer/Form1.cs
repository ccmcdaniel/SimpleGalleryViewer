namespace SimpleGalleryViewer
{
    public partial class Form1 : Form
    {
        int current_picture = 1;

        public Form1()
        {
            InitializeComponent();

            picViewer.Image = Properties.Resources.flowers_1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            current_picture -= 1;

            if (current_picture < 1)
                current_picture = 3;

            setPicture();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current_picture += 1;

            if (current_picture > 3)
                current_picture = 1;

            setPicture();
        }        
        
        private void setPicture()
        {
            Image pic = current_picture switch
            {
                1 => Properties.Resources.flowers_1,
                2 => Properties.Resources.flowers_2,
                3 => Properties.Resources.flowers_3
            };

            picViewer.Image = pic;
        }
    }
}