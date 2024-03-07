using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            Storage.observers += new System.EventHandler(this.UpdateFromStorage);
        }
        int figure = 0;
        int col = 0;
        MyStorage Storage = new MyStorage();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            if (Storage.IsClicked(e) == false)
            {
                Storage.AllNotChecked();
                if (figure == 1)
                {
                    Storage.AddObject(new Circle(e.X, e.Y, 40));
                }
                if (figure == 2)
                {
                    Storage.AddObject(new sqare(e.X, e.Y, 40));
                }
                if (figure == 3)
                {
                    Storage.AddObject(new triangle(e.X, e.Y, 40));
                }
            }
            else
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    Storage.Highlighting(e);
                }
                else
                {
                    Storage.AllNotChecked();
                    Storage.Highlighting(e);
                }
            }
            Storage.observers.Invoke(this, null);
            Refresh();
        }

        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Graphics g = panel1.CreateGraphics();
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        Storage.removeCheckedObject(Storage);
        //        g.Clear(Color.White);
        //    }

        //    if (e.KeyValue == 107 || e.KeyValue == 109)
        //    {
        //        g.Clear(Color.White);
        //        Storage.Size(e);
        //    }
        //    if (e.KeyValue == 37 || e.KeyValue == 38 || e.KeyValue == 39 || e.KeyValue == 40)
        //    {
        //        g.Clear(Color.White);
        //        Storage.Move(e);
        //    }
        //    if (e.KeyCode == Keys.F5)
        //    {
        //        g.Clear(Color.White);
        //        Storage.chooseColor(col);
        //    }
        //    Refresh();
        //}
        private void black_Click(object sender, EventArgs e)
        {
            col = 1;
        }

        private void red_Click(object sender, EventArgs e)
        {
            col = 2;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            col = 3;
        }

        private void green_Click(object sender, EventArgs e)
        {
            col = 4;
        }



        private void circle_Click(object sender, EventArgs e)
        {
            figure = 1;
        }

        private void square_Click(object sender, EventArgs e)
        {
            figure = 2;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            figure = 3;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            if (e.KeyCode == Keys.Delete)
            {
                Storage.removeCheckedObject(Storage);
                g.Clear(Color.White);
            }

            if (e.KeyValue == 187 || e.KeyValue == 189)
            {
                g.Clear(Color.White);
                Storage.Size(e);
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.A)
            {
                g.Clear(Color.White);
                Storage.Move(e);
            }
            if (e.KeyCode == Keys.F5)
            {
                g.Clear(Color.White);
                Storage.chooseColor(col);
            }
            Refresh();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Storage.Draww(panel1, g);
        }
        private void UpdateFromStorage(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            for (int i = 0; i < Storage.getCount(); i++)
            {
                TreeNode n = new TreeNode();
                treeView1.Nodes.Add(MakeNode(Storage.getObject(i), n));
            }
            Refresh();
        }
        TreeNode MakeNode(figure fig, TreeNode n)
        {
            if (fig.IsChecked() == true)
            {
                n.Checked = true;
            }
            int count = 0;
            if (fig is CGroup)
            {
                if (fig.IsChecked() == true)
                {
                    n.Checked = true;
                }
                n.Text = fig.Name();

                for (int j = 0; j < fig.getCount(); j++)
                {
                    TreeNode nn = new TreeNode();
                    count = n.Nodes.Add(MakeNode(fig.getObject(j), nn));
                }
                count++;
            }
            else
            {
                n.Text = fig.Name();
            }
            return n;
        }

        private void btn_groop_Click(object sender, EventArgs e)
        {
            Storage.createGroup();
            Storage.observers.Invoke(this, null);
        }

        private void btn_ungroop_Click(object sender, EventArgs e)
        {
            Storage.deleteGroup();
            Storage.observers.Invoke(this, null);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Storage.saveAll();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            Storage.loadAll();
            Storage.observers.Invoke(this, null);
            Refresh();
        }      
        private void btn_sticky_Click(object sender, EventArgs e)
        {
            Storage.MakeSticky();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                if (n.Checked)
                {
                    Storage.MakeCheckedbyIndex(n.Index);
                }
                else
                {
                    Storage.MakenotCheckedbyIndex(n.Index);
                }
            }
            Refresh();
        }
    }

}
