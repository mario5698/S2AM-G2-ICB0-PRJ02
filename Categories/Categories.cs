using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categories
{
    public partial class Categories : Form
    {
        RankEntities db;
        List<UserRank> rn;
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            Carregar_Dades();
        }
        private void Carregar_Dades()
        {
            db = new RankEntities();
            rn = db.UserRanks.ToList();
            dtgUsers.DataSource = rn;
        }

    }
}
