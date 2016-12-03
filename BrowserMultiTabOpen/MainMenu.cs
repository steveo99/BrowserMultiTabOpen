using System.Windows.Forms;

namespace BrowserMultiTabOpen
{
    public partial class MainMenu : Form
    {
        public MainMenu() {
            InitializeComponent();
        }

        private void InvestmentStockResearchToolStripMenuItemClick(object sender, System.EventArgs e) {
            var frm = new InvestmentStockReasearch();
            frm.Show();
        }
    }
}
