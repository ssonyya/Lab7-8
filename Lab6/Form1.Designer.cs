
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.triangle = new System.Windows.Forms.PictureBox();
            this.square = new System.Windows.Forms.PictureBox();
            this.circle = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sticky = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_ungroop = new System.Windows.Forms.Button();
            this.btn_groop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 615);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(24, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 181);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.triangle);
            this.panel2.Controls.Add(this.square);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Controls.Add(this.red);
            this.panel2.Controls.Add(this.green);
            this.panel2.Controls.Add(this.blue);
            this.panel2.Controls.Add(this.black);
            this.panel2.Location = new System.Drawing.Point(787, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 360);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите цвет и нажмите F5";
            // 
            // triangle
            // 
            this.triangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangle.Image = global::Lab6.Properties.Resources.треугольник;
            this.triangle.Location = new System.Drawing.Point(229, 218);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(85, 85);
            this.triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangle.TabIndex = 8;
            this.triangle.TabStop = false;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // square
            // 
            this.square.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square.Image = global::Lab6.Properties.Resources.квадрат;
            this.square.Location = new System.Drawing.Point(120, 218);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(85, 85);
            this.square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.square.TabIndex = 7;
            this.square.TabStop = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circle.Image = global::Lab6.Properties.Resources.круг;
            this.circle.Location = new System.Drawing.Point(13, 218);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(85, 85);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circle.TabIndex = 4;
            this.circle.TabStop = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.red.Location = new System.Drawing.Point(94, 28);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(55, 50);
            this.red.TabIndex = 3;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green.Location = new System.Drawing.Point(258, 28);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(55, 50);
            this.green.TabIndex = 2;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blue.Location = new System.Drawing.Point(176, 28);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(55, 50);
            this.blue.TabIndex = 1;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.black.Location = new System.Drawing.Point(12, 28);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(55, 50);
            this.black.TabIndex = 0;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(739, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Для перемещения фигур используйте WASD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(739, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Для изменения размера используйте \"+\" и \"-\"";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_sticky);
            this.panel3.Controls.Add(this.btn_load);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_ungroop);
            this.panel3.Controls.Add(this.btn_groop);
            this.panel3.Location = new System.Drawing.Point(787, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 117);
            this.panel3.TabIndex = 12;
            // 
            // btn_sticky
            // 
            this.btn_sticky.Location = new System.Drawing.Point(239, 14);
            this.btn_sticky.Name = "btn_sticky";
            this.btn_sticky.Size = new System.Drawing.Size(75, 23);
            this.btn_sticky.TabIndex = 4;
            this.btn_sticky.Text = "Липкий";
            this.btn_sticky.UseVisualStyleBackColor = true;
            this.btn_sticky.Click += new System.EventHandler(this.btn_sticky_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(144, 69);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Загрузить";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(144, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_ungroop
            // 
            this.btn_ungroop.Location = new System.Drawing.Point(15, 69);
            this.btn_ungroop.Name = "btn_ungroop";
            this.btn_ungroop.Size = new System.Drawing.Size(105, 23);
            this.btn_ungroop.TabIndex = 1;
            this.btn_ungroop.Text = "Разгруппировать";
            this.btn_ungroop.UseVisualStyleBackColor = true;
            this.btn_ungroop.Click += new System.EventHandler(this.btn_ungroop_Click);
            // 
            // btn_groop
            // 
            this.btn_groop.Location = new System.Drawing.Point(15, 14);
            this.btn_groop.Name = "btn_groop";
            this.btn_groop.Size = new System.Drawing.Size(105, 23);
            this.btn_groop.TabIndex = 0;
            this.btn_groop.Text = "Сгруппировать";
            this.btn_groop.UseVisualStyleBackColor = true;
            this.btn_groop.Click += new System.EventHandler(this.btn_groop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.PictureBox triangle;
        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.PictureBox square;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_sticky;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_ungroop;
        private System.Windows.Forms.Button btn_groop;
    }
}

