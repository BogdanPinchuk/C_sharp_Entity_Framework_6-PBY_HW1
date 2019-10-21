using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При натисканні кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_Click(object sender, EventArgs e)
        {
            using (MyModelContainer db = new MyModelContainer())
            {
                // завантаження даних
                db.Entity1Set.Load();
                // передача даних на форму
                dataGrid.DataSource = db.Entity1Set.Local;
                //dataGrid.Refresh();
                dataGrid.Update();
            }
        }
    }
}
