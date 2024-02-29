namespace DuAnNhom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            panel.Controls.Clear(); ;
            panel.Visible = true;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Size = childForm.Size;
            childForm.Show();
        }
        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form contactfrm = new contact();
            openChildForm(contactfrm);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutUsfrm = new aboutUS();
            openChildForm(aboutUsfrm);
        }
    }
}