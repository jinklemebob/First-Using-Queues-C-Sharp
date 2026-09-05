using System.Collections;

namespace QueuingCashier
{
    public partial class QueuingForm : Form
    {
        CashierClass cashier = new CashierClass();

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            openWindowForm();
        }
        public void openWindowForm()
        {
            CashierWindowQueueForm form1 = new CashierWindowQueueForm();
            form1.Show();
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
