using System.Security.Cryptography.X509Certificates;

namespace CochranMottLab2
{
    public partial class Lab2 : Form
    {

        public Lab2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //sets txt boxs as intgers
            int Number = Convert.ToInt32(txtBoxNum.Text);
            int Multiplier = Convert.ToInt32(txtBoxMulti.Text);
            int Answer = Number * Multiplier;
            lblAnswerBox.Text = Answer.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Empties this label
            lblAnswerBox.Text = String.Empty;
            //Empties this text box
            txtBoxNum.Text = String.Empty;
            //Empties this text box
            txtBoxMulti.Text = String.Empty;
            //Focuses cursor on empty text box
            txtBoxNum.Focus();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //This is to show the picture box
         picBox.Show();
         txtHobby.Hide();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            // This is to show the text box
            txtHobby.Show();
            picBox.Hide();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            // This is to hide both the text box and picture box
            txtHobby.Hide();
            picBox.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This is to close the form
            this.Close();
        }
    }
}