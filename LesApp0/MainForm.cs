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

namespace LesApp0
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
            using (MyDatabaseEntities db = new MyDatabaseEntities())
            {
                // завантаження даних
                db.MyTable.Load();
                // передача даних на форму
                dataGrid.DataSource = db.MyTable.Local;
                //dataGrid.Refresh();
                dataGrid.Update();
            }
        }
    }
}
