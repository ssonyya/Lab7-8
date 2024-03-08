using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    class figure
    {
        protected Color color = Color.White;
        public bool Sticky = false;
        virtual public void Draw(Panel panel1, Graphics g)
        {
        }

        virtual public bool IsChecked()
        {
            return true;
        }
        virtual public void ColoredTrue()
        {
        }
        virtual public void ColoredFalse()
        {
        }
        virtual public bool isClicked(MouseEventArgs e)
        {
            return true;
        }
        virtual public void chooseColor(int col)
        {
        }
        virtual public void Move(KeyEventArgs e)
        {
        }
        virtual public void Size(KeyEventArgs e)
        {
        }
        virtual public bool isSticky()
        {
            return true;
        }
        virtual public bool isShapeSticky()
        {
            return Sticky;
        }
        virtual public void Save(StreamWriter file)
        {
        }
        virtual public void Load(StreamReader file)
        {
        }
        virtual public string Name()
        {
            return "Shape";
        }
        virtual public int getCount()
        {
            return 1;
        }
        virtual public figure getObject(int i)
        {
            figure a = new figure();
            return a;
        }

        public int x, y, r;


    }

    class Circle : figure
    {
        private bool Colored;
        private Pen pen;
        private SolidBrush brush;
        Rectangle rec;
        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            brush = new SolidBrush(Color.White);
            pen = new Pen(Color.White);
        }
        override public void Draw(Panel panel1, Graphics g)
        {
            rec = new Rectangle(x - r, y - r, r * 2, r * 2);
            if (Colored == true)
            {
                pen.Color = Color.Red;
            }
            else
            {
                pen.Color = Color.Black;
            }
            g.FillEllipse(brush, rec);
            g.DrawEllipse(pen, rec);
        }

        override public bool IsChecked()
        {
            return Colored;
        }
        override public bool isSticky()
        {
            return Sticky;
        }
        override public bool isClicked(MouseEventArgs e)
        {
            if ((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y) <= r * r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void ColoredTrue()
        {
            Colored = true;
        }

        public override void ColoredFalse()
        {
            Colored = false;
        }

        public override void Size(KeyEventArgs e)
        {
            if (e.KeyValue == 187)
            {
                r = r + 10;
            }
            if (e.KeyValue == 189)
            {
                r = r - 10;
            }
        }
        override public void Move(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)//(e.KeyValue == 37)
            {
                if ((x-5) > r)
                    x = x - 5;
            }
            if (e.KeyCode == Keys.D)//(e.KeyValue == 39)
            {
                if ((x + 5) <720-r)
                    x = x + 5;
            }
            if (e.KeyCode == Keys.W)//(e.KeyValue == 38)
            {
                if ((y - 5) > r)
                    y = y - 5;
            }
            if (e.KeyCode == Keys.S)//(e.KeyValue == 40)
            {
                if ((y + 5) < 610 - r)
                    y = y + 5;
            }
        }

        public override void chooseColor(int col)
        {
            if (col == 1)
            {
                brush.Color = Color.Black;
                color = Color.Black;
            }
            if (col == 2)
            {
                brush.Color = Color.Red;
                color = Color.Red;
            }
            if (col == 3)
            {
                brush.Color = Color.Blue;
                color = Color.Blue;
            }
            if (col == 4)
            {
                brush.Color = Color.Green;
                color = Color.Green;
            }
        }
        public override void Save(StreamWriter file)
        {
            file.WriteLine("C");
            file.WriteLine(x);
            file.WriteLine(y);
            file.WriteLine(r);
            file.WriteLine(Sticky);
            file.WriteLine(color.ToKnownColor());
        }
        public override void Load(StreamReader file)
        {
            x = Convert.ToInt32(file.ReadLine());
            y = Convert.ToInt32(file.ReadLine());
            r = Convert.ToInt32(file.ReadLine());
            Sticky = Convert.ToBoolean(file.ReadLine());
            color = Color.FromName(file.ReadLine());
            brush = new SolidBrush(color);
        }
        public override string Name()
        {
            return "Circle";
        }
    }

    class sqare : figure
    {
        private bool Colored;
        private SolidBrush brush;
        private Pen pen;
        public sqare(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            brush = new SolidBrush(Color.White);
        }
        override public void Draw(Panel panel1, Graphics g)
        {
            Rectangle rec = new Rectangle(x - r, y - r, r * 2, r * 2);
            if (Colored == true)
            {
                pen = new Pen(Color.Red);
            }
            else
            {
                pen = new Pen(Color.Black);
            }
            g.FillRectangle(brush, rec);
            g.DrawRectangle(pen, rec);
        }
        override public bool isSticky()
        {
            return Sticky;
        }
        public override void Size(KeyEventArgs e)
        {
            if (e.KeyValue == 187)
            {
                r = r + 10;
            }
            if (e.KeyValue == 189)
            {
                r = r - 10;
            }
        }
        override public void Move(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (x-5 > r)
                    x = x - 5;
            }
            if (e.KeyCode == Keys.D)
            {
                if (x + 5 < 720 - r)
                    x = x + 5;
            }
            if (e.KeyCode == Keys.W)
            {
                if (y - 5 > r)
                    y = y - 5;
            }
            if (e.KeyCode == Keys.S)
            {
                if (y + 5 < 610 - r)
                    y = y + 5;
            }
        }
        public override void chooseColor(int col)
        {

            if (col == 1)
            {
                brush.Color = Color.Black;
                color = Color.Black;
            }
            if (col == 2)
            {
                brush.Color = Color.Red;
                color = Color.Red;
            }
            if (col == 3)
            {
                brush.Color = Color.Blue;
                color = Color.Blue;
            }
            if (col == 4)
            {
                brush.Color = Color.Green;
                color = Color.Green;
            }
        }
        public override void Save(StreamWriter file)
        {
            file.WriteLine("S");
            file.WriteLine(x);
            file.WriteLine(y);
            file.WriteLine(r);
            file.WriteLine(Sticky);
            file.WriteLine(color.ToKnownColor());
        }

        public override void Load(StreamReader file)
        {
            x = Convert.ToInt32(file.ReadLine());
            y = Convert.ToInt32(file.ReadLine());
            r = Convert.ToInt32(file.ReadLine());
            Sticky = Convert.ToBoolean(file.ReadLine());
            color = Color.FromName(file.ReadLine());
            brush = new SolidBrush(color);
        }
        public override string Name()
        {
            return "sqare";
        }
        public override bool IsChecked()
        {
            return Colored;
        }

        public override bool isClicked(MouseEventArgs e)
        {
            if (e.X >= x - r && e.Y >= y - r && e.X <= x + r && e.Y <= y + r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void ColoredFalse()
        {
            Colored = false;
        }
        public override void ColoredTrue()
        {
            Colored = true;
        }
    }

    class triangle : figure
    {
        private Point[] points;
        private bool Colored;
        private Pen pen;
        private SolidBrush brush;
        public triangle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            brush = new SolidBrush(Color.White);
            points = new Point[3];
            points[0].X = x; points[0].Y = y - r;
            points[1].X = x - r; points[1].Y = y + r;
            points[2].X = x + r; points[2].Y = y + r;
        }

        override public void Draw(Panel panel1, Graphics g)
        {
            if (Colored == true)
            {
                pen = new Pen(Color.Red);
            }
            else
            {
                pen = new Pen(Color.Black);
            }
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }
        public override void Size(KeyEventArgs e)
        {
            if (e.KeyValue == 187)
            {
                points[0].X = points[0].X; points[0].Y = points[0].Y - 10;
                points[1].X = points[1].X - 10; points[1].Y = points[1].Y + 10;
                points[2].X = points[2].X + 10; points[2].Y = points[2].Y + 10;
            }
            if (e.KeyValue == 189)
            {
                points[0].X = points[0].X; points[0].Y = points[0].Y + 10;
                points[1].X = points[1].X + 10; points[1].Y = points[1].Y - 10;
                points[2].X = points[2].X - 10; points[2].Y = points[2].Y - 10;
            }
        }
        override public void Move(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (points[0].X - 5 > r)
                {
                    points[0].X = points[0].X - 5; points[0].Y = points[0].Y;
                    points[1].X = points[1].X - 5; points[1].Y = points[1].Y;
                    points[2].X = points[2].X - 5; points[2].Y = points[2].Y;
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (points[2].X + 5 < 720)
                {
                    points[0].X = points[0].X + 5; points[0].Y = points[0].Y;
                    points[1].X = points[1].X + 5; points[1].Y = points[1].Y;
                    points[2].X = points[2].X + 5; points[2].Y = points[2].Y;
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (points[0].Y - 5 > 0)
                {
                    points[0].X = points[0].X; points[0].Y = points[0].Y - 5;
                    points[1].X = points[1].X; points[1].Y = points[1].Y - 5;
                    points[2].X = points[2].X; points[2].Y = points[2].Y - 5;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (points[2].Y + 5 < 610)
                {
                    points[0].X = points[0].X; points[0].Y = points[0].Y + 5;
                    points[1].X = points[1].X; points[1].Y = points[1].Y + 5;
                    points[2].X = points[2].X; points[2].Y = points[2].Y + 5;
                }
            }
        }
        public override void chooseColor(int col)
        {
            if (col == 1)
            {
                brush.Color = Color.Black;
                color = Color.Black;
            }
            if (col == 2)
            {
                brush.Color = Color.Red;
                color = Color.Red;
            }
            if (col == 3)
            {
                brush.Color = Color.Blue;
                color = Color.Blue;
            }
            if (col == 4)
            {
                brush.Color = Color.Green;
                color = Color.Green;
            }
        }
        public override void Save(StreamWriter file)
        {
            file.WriteLine("T");
            file.WriteLine(x);
            file.WriteLine(y);
            file.WriteLine(r);
            file.WriteLine(Sticky);
            file.WriteLine(color.ToKnownColor());
        }

        public override void Load(StreamReader file)
        {
            x = Convert.ToInt32(file.ReadLine());
            y = Convert.ToInt32(file.ReadLine());
            r = Convert.ToInt32(file.ReadLine());
            points[0].X = x; points[0].Y = y - r;
            points[1].X = x - r; points[1].Y = y + r;
            points[2].X = x + r; points[2].Y = y + r;
            Sticky = Convert.ToBoolean(file.ReadLine());
            color = Color.FromName(file.ReadLine());
            brush = new SolidBrush(color);
        }
        public override string Name()
        {
            return "triangle";
        }

        override public bool isSticky()
        {
            return Sticky;
        }
        public override bool IsChecked()
        {
            return Colored;
        }
        public override bool isClicked(MouseEventArgs e)
        {
            if (e.X >= x - r && e.Y >= y - r && e.X <= x + r && e.Y <= y + r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void ColoredFalse()
        {
            Colored = false;
        }
        public override void ColoredTrue()
        {
            Colored = true;
        }

    }
    class Factory
    {
        public figure createShape(char name)
        {
            figure obj = null;
            switch (name)
            {
                case 'C':
                    obj = new Circle(0, 0, 0);
                    break;
                case 'S':
                    obj = new sqare(0, 0, 0);
                    break;
                case 'T':
                    obj = new triangle(0, 0, 0);
                    break;
                case 'G':
                    obj = new CGroup(0);
                    break;

                default:
                    break;
            }
            return obj;
        }
    }

    class MyStorage
    {
        private int size;
        public figure[] storage;
        public System.EventHandler observers;

        public MyStorage()
        {
            size = 0;
        }
        public MyStorage(int size)
        {
            this.size = size;
            storage = new figure[size];
        }
        public void SetObject(int size, figure Obj)
        {
            storage[size] = Obj;
        }
        public int getCount()
        {
            return size;
        }
        public bool IsClicked(MouseEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].isClicked(e) == true)
                {
                    storage[i].ColoredTrue();
                    return true;
                }
            }
            return false;
        }
        public void AddObject(figure Obj)
        {
            figure[] storage2 = new figure[size + 1];
            if (size != 0)
            {
                for (int i = 0; i < size; i++)
                {
                    storage2[i] = storage[i];
                }
            }
            storage = storage2;
            storage[size] = Obj;
            size++;
        }
        public void Size(KeyEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsChecked() == true)
                {
                    storage[i].Size(e);
                }
            }
        }
        public void Move(KeyEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsChecked() == true)
                {
                    if (storage[i].isSticky() == true)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i != j)
                            {
                                if (Math.Sqrt(Math.Pow(storage[i].x - storage[j].x, 2) + Math.Pow(storage[i].y - storage[j].y, 2)) <= (storage[i].r + storage[j].r))
                                {
                                    storage[j].Move(e);
                                }
                            }
                        }
                    }
                    storage[i].Move(e);
                }
            }
        }
        public void chooseColor(int col)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsChecked() == true)
                {
                    storage[i].chooseColor(col);
                }
            }
        }

        public figure getObject(int i)
        {
            return storage[i];
        }

        public void createGroup()
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsChecked() == true)
                    count++;
            }
            if (count >= 2)
            {
                CGroup group = new CGroup(count);
                for (int i = size - 1; i >= 0; i--)
                {
                    if (storage[i].IsChecked() == true)
                    {
                        group.addShape(storage[i]);
                        RemoveObject(i);
                    }
                }
                AddObject(group);
            }

        }



        public void deleteGroup()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                if (storage[i] is CGroup && storage[i].IsChecked())
                {
                    CGroup group = (CGroup)storage[i];
                    for (int j = group.getCount() - 1; j >= 0; j--)
                    {
                        AddObject(group._shapes[j]);
                    }
                    RemoveObject(i);
                }
            }
        }

        public void saveAll()
        {
            string way = @"save.txt";
            StreamWriter file = new StreamWriter(way, false);
            file.WriteLine(size);

            for (int i = 0; i < size; i++)
            {
                storage[i].Save(file);
            }
            file.Close();
        }

        public void loadAll()
        {
            string way = @"save.txt";
            Factory factory = new Factory();
            StreamReader file = new StreamReader(way);
            int count = Convert.ToInt32(file.ReadLine());
            char name;
            for (int i = 0; i < count; i++)
            {
                name = Convert.ToChar(file.ReadLine());
                AddObject(factory.createShape(name));
                if (storage[i] != null)
                {
                    storage[i].Load(file);
                }
            }
            file.Close();
        }

        public void MakeSticky()
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsChecked() == true)
                {
                    storage[i].Sticky = true;
                }
            }
        }

        public void MakeCheckedbyIndex(int i)
        {
            storage[i].ColoredTrue();
        }
        public void MakenotCheckedbyIndex(int i)
        {
            storage[i].ColoredFalse();
        }
        public void RemoveObject(int i)
        {
            figure[] storage2 = new figure[size - 1];
            for (int j = 0; j < i; j++)
            {
                storage2[j] = storage[j];
            }
            for (int j = i; j < size - 1; j++)
            {
                storage2[j] = storage[j + 1];
            }
            size = size - 1;
            storage = storage2;
        }
        public void removeCheckedObject(MyStorage storage)
        {
            for (int i = 0; i < size; i++)
            {
                if (this.storage[i].IsChecked() == true)
                {
                    storage.RemoveObject(i);
                    i = i - 1;
                }
            }
        }

        public void Draww(Panel panel1, Graphics g)
        {
            for (int i = 0; i < size; i++)
            {
                storage[i].Draw(panel1, g);
            }
        }


        public void Highlighting(MouseEventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].isClicked(e) == true)
                {
                    storage[i].ColoredTrue();
                    break;
                }
            }

        }
        public void AllNotChecked()
        {
            for (int i = 0; i < size; i++)
            {
                storage[i].ColoredFalse();
            }
        }
    }

    class CGroup : figure
    {
        private int _count;
        private int _maxcount;
        public figure[] _shapes;
        //private bool Checked;
        private bool Colored;
        //public MyStorage storage = new MyStorage();

        public CGroup(int maxcount)
        {
            Colored = true;
            _maxcount = maxcount; _count = 0;
            _shapes = new figure[_maxcount];
            for (int i = 0; i < _maxcount; ++i)
            {
                //_shapes = null;
            }
        }
        ~CGroup()
        {
            for (int i = 0; i < _maxcount; ++i)
            {
                _shapes = null;
            }
            _shapes = null;
        }

        public bool addShape(figure obj)
        {
            if (_count >= _maxcount)
                return false;

            _count++;
            _shapes[_count - 1] = obj;
            return true;
        }

        public override void Move(KeyEventArgs e)
        {
            for (int i = 0; i < _count; i++)
            {
                _shapes[i].Move(e);
            }

        }
        public override void ColoredFalse()
        {
            Colored = false;
            for (int i = 0; i < _count; i++)
            {
                _shapes[i].ColoredFalse();
            }

        }
        public override void Draw(Panel panel1, Graphics g)
        {
            for (int i = 0; i < _count; i++)
            {
                _shapes[i].Draw(panel1, g);
            }
        }

        public override void Size(KeyEventArgs e)
        {
            for (int i = 0; i < _count; i++)
            {
                _shapes[i].Size(e);
            }
        }

        public override void ColoredTrue()
        {
            for (int i = 0; i < _count; i++)
            {
                _shapes[i].ColoredTrue();
            }
        }



        public override bool isClicked(MouseEventArgs e)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_shapes[i].isClicked(e) == true)
                {
                    Colored = true;
                    return true;
                }
            }
            return false;
        }

        public override bool IsChecked()
        {
            return Colored;
        }

        public override void chooseColor(int col)
        {
            for (int i = 0; i < _count; i++)
            {
                _shapes[i].chooseColor(col);
            }
        }

        public override int getCount()
        {
            return _count;
        }

        public override figure getObject(int i)
        {
            return _shapes[i];
        }

        public override void Save(StreamWriter file)
        {
            file.WriteLine("G");
            file.WriteLine(_count);
            for (int i = 0; i < _count; i++)
            {
                _shapes[i].Save(file);
            }
        }

        public override void Load(StreamReader file)
        {
            _maxcount = Convert.ToInt32(file.ReadLine());
            _count = 0;
            char name;
            Factory factory = new Factory();
            _shapes = new figure[_maxcount];
            for (int i = 0; i < _maxcount; i++)
            {
                name = Convert.ToChar(file.ReadLine());
                addShape(factory.createShape(name));
                _shapes[i].Load(file);
            }
        }
        public override string Name()
        {
            return "CGroup";
        }



    }
}
