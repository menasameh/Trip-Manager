using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tripManager
{
    public partial class CreateGroup : Form
    {
        private static CreateGroup instance;

        public static CreateGroup getInstance()
        {
            if(instance == null){
                instance = new CreateGroup();
            }
            return instance;
        }
        private CreateGroup()
        {
            InitializeComponent();
        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
