namespace ToolsProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg (.jpg)|*.jpg|Png (.png)|*.png";
            ofd.ShowDialog();
            string str = ofd.FileName;
            label1.Text = ofd.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "12345";
            lvi.SubItems.Add("Ahmet");
            lvi.SubItems.Add("Yýlmaz");
            lvi.SubItems.Add("ay@bilge.com");

            ListViewItem lvi2 = new ListViewItem();
            lvi2.Text = "12345";
            lvi2.SubItems.Add("Ahmet");
            lvi2.SubItems.Add("Yýlmaz");
            lvi2.SubItems.Add("ay@bilge.com");

            lvBilgiler.Items.Add(lvi);
            lvBilgiler.Items.Add(lvi2);
        }

        private void lvBilgiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBilgiler.SelectedItems.Count > 0)
            {
                int index = lvBilgiler.FocusedItem.Index;
            }
        }
    }
}