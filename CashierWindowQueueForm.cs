using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {

        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {

            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Dequeue();
        }
    }
}
