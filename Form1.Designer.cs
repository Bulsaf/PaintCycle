using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Art
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            FigureComboBox = new ComboBox();
            DeleteBox = new GroupBox();
            DeleteButton = new Button();
            MoveBox = new GroupBox();
            MoveButton = new Button();
            label24 = new Label();
            label25 = new Label();
            MoveYTextBox = new TextBox();
            MoveXTextBox = new TextBox();
            OwnBox = new GroupBox();
            label17 = new Label();
            OwnHTextBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            OwnYTextBox = new TextBox();
            OwnWTextBox = new TextBox();
            OwnXTextBox = new TextBox();
            OwnBoxButton = new Button();
            PolygonBox = new GroupBox();
            PolygonCountLabel = new Label();
            PolygonYLabel = new Label();
            PolygonXLabel = new Label();
            PolygonYTextBox = new TextBox();
            PolygonCountTextBox = new TextBox();
            PolygonXTextBox = new TextBox();
            PolygonBoxButton = new Button();
            TriangleBox = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            TriangleY3TextBox = new TextBox();
            TriangleX3TextBox = new TextBox();
            TriangleY2TextBox = new TextBox();
            TriangleX2TextBox = new TextBox();
            TriangleX1TextBox = new TextBox();
            TriangleY1TextBox = new TextBox();
            TriangleBoxButton = new Button();
            EllipsBox = new GroupBox();
            label20 = new Label();
            label21 = new Label();
            EllipsHLabel = new Label();
            EllipsWLabel = new Label();
            EllipsXTextBox = new TextBox();
            CircleRadioButton = new RadioButton();
            EllipsRadioButton = new RadioButton();
            EllipsYTextBox = new TextBox();
            EllipsHTextBox = new TextBox();
            EllipsWTextBox = new TextBox();
            EllipsBoxButton = new Button();
            RectangleBox = new GroupBox();
            label19 = new Label();
            label18 = new Label();
            RectangleXTextBox = new TextBox();
            RectangleLLabel = new Label();
            RectangleWLabel = new Label();
            SquareRadioButton = new RadioButton();
            RectangleRadioButton = new RadioButton();
            RectangleYTextBox = new TextBox();
            RectangleHTextBox = new TextBox();
            RectangleWTextBox = new TextBox();
            RectangleBoxButton = new Button();
            groupBox6 = new GroupBox();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            DeleteBox.SuspendLayout();
            MoveBox.SuspendLayout();
            OwnBox.SuspendLayout();
            PolygonBox.SuspendLayout();
            TriangleBox.SuspendLayout();
            EllipsBox.SuspendLayout();
            RectangleBox.SuspendLayout();
            ((ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(FigureComboBox);
            panel1.Controls.Add(DeleteBox);
            panel1.Controls.Add(MoveBox);
            panel1.Controls.Add(OwnBox);
            panel1.Controls.Add(PolygonBox);
            panel1.Controls.Add(TriangleBox);
            panel1.Controls.Add(EllipsBox);
            panel1.Controls.Add(RectangleBox);
            panel1.Controls.Add(groupBox6);
            panel1.Dock = DockStyle.Right;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(794, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 802);
            panel1.TabIndex = 0;
            // 
            // FigureComboBox
            // 
            FigureComboBox.FormattingEnabled = true;
            FigureComboBox.Location = new Point(443, 660);
            FigureComboBox.Name = "FigureComboBox";
            FigureComboBox.Size = new Size(105, 28);
            FigureComboBox.TabIndex = 1;
            FigureComboBox.Text = "Фигуры";
            // 
            // DeleteBox
            // 
            DeleteBox.BackColor = Color.WhiteSmoke;
            DeleteBox.Controls.Add(DeleteButton);
            DeleteBox.Location = new Point(443, 573);
            DeleteBox.Name = "DeleteBox";
            DeleteBox.Size = new Size(105, 84);
            DeleteBox.TabIndex = 7;
            DeleteBox.TabStop = false;
            DeleteBox.Text = "Удаление";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(6, 34);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(76, 27);
            DeleteButton.TabIndex = 19;
            DeleteButton.Text = "ОК";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // MoveBox
            // 
            MoveBox.BackColor = Color.WhiteSmoke;
            MoveBox.Controls.Add(MoveButton);
            MoveBox.Controls.Add(label24);
            MoveBox.Controls.Add(label25);
            MoveBox.Controls.Add(MoveYTextBox);
            MoveBox.Controls.Add(MoveXTextBox);
            MoveBox.Location = new Point(303, 573);
            MoveBox.Name = "MoveBox";
            MoveBox.Size = new Size(129, 184);
            MoveBox.TabIndex = 6;
            MoveBox.TabStop = false;
            MoveBox.Text = "Перемещение";
            // 
            // MoveButton
            // 
            MoveButton.Location = new Point(13, 133);
            MoveButton.Name = "MoveButton";
            MoveButton.Size = new Size(76, 27);
            MoveButton.TabIndex = 19;
            MoveButton.Text = "ОК";
            MoveButton.UseVisualStyleBackColor = true;
            MoveButton.Click += MoveButton_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(16, 75);
            label24.Name = "label24";
            label24.Size = new Size(20, 20);
            label24.TabIndex = 18;
            label24.Text = "Y:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(13, 22);
            label25.Name = "label25";
            label25.Size = new Size(21, 20);
            label25.TabIndex = 17;
            label25.Text = "X:";
            // 
            // MoveYTextBox
            // 
            MoveYTextBox.Location = new Point(16, 98);
            MoveYTextBox.Name = "MoveYTextBox";
            MoveYTextBox.Size = new Size(73, 27);
            MoveYTextBox.TabIndex = 16;
            MoveYTextBox.KeyPress += MoveYTextBox_KeyPress;
            // 
            // MoveXTextBox
            // 
            MoveXTextBox.Location = new Point(13, 45);
            MoveXTextBox.Name = "MoveXTextBox";
            MoveXTextBox.Size = new Size(76, 27);
            MoveXTextBox.TabIndex = 15;
            MoveXTextBox.KeyPress += MoveXTextBox_KeyPress;
            // 
            // OwnBox
            // 
            OwnBox.BackColor = Color.WhiteSmoke;
            OwnBox.Controls.Add(label17);
            OwnBox.Controls.Add(OwnHTextBox);
            OwnBox.Controls.Add(label14);
            OwnBox.Controls.Add(label15);
            OwnBox.Controls.Add(label16);
            OwnBox.Controls.Add(OwnYTextBox);
            OwnBox.Controls.Add(OwnWTextBox);
            OwnBox.Controls.Add(OwnXTextBox);
            OwnBox.Controls.Add(OwnBoxButton);
            OwnBox.Location = new Point(303, 383);
            OwnBox.Name = "OwnBox";
            OwnBox.Size = new Size(269, 184);
            OwnBox.TabIndex = 5;
            OwnBox.TabStop = false;
            OwnBox.Text = "Своя фигура";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 77);
            label17.Name = "label17";
            label17.Size = new Size(62, 20);
            label17.TabIndex = 16;
            label17.Text = "Высота:";
            // 
            // OwnHTextBox
            // 
            OwnHTextBox.Location = new Point(6, 100);
            OwnHTextBox.Name = "OwnHTextBox";
            OwnHTextBox.Size = new Size(145, 27);
            OwnHTextBox.TabIndex = 15;
            OwnHTextBox.KeyPress += OnlyDigit;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 23);
            label14.Name = "label14";
            label14.Size = new Size(70, 20);
            label14.TabIndex = 14;
            label14.Text = "Ширина:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(169, 77);
            label15.Name = "label15";
            label15.Size = new Size(20, 20);
            label15.TabIndex = 13;
            label15.Text = "Y:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(166, 24);
            label16.Name = "label16";
            label16.Size = new Size(21, 20);
            label16.TabIndex = 10;
            label16.Text = "X:";
            // 
            // OwnYTextBox
            // 
            OwnYTextBox.Location = new Point(169, 100);
            OwnYTextBox.Name = "OwnYTextBox";
            OwnYTextBox.Size = new Size(76, 27);
            OwnYTextBox.TabIndex = 6;
            OwnYTextBox.KeyPress += OnlyDigit;
            // 
            // OwnWTextBox
            // 
            OwnWTextBox.Location = new Point(3, 47);
            OwnWTextBox.Name = "OwnWTextBox";
            OwnWTextBox.Size = new Size(145, 27);
            OwnWTextBox.TabIndex = 4;
            OwnWTextBox.KeyPress += OnlyDigit;
            // 
            // OwnXTextBox
            // 
            OwnXTextBox.Location = new Point(166, 47);
            OwnXTextBox.Name = "OwnXTextBox";
            OwnXTextBox.Size = new Size(76, 27);
            OwnXTextBox.TabIndex = 3;
            OwnXTextBox.KeyPress += OnlyDigit;
            // 
            // OwnBoxButton
            // 
            OwnBoxButton.Location = new Point(3, 133);
            OwnBoxButton.Name = "OwnBoxButton";
            OwnBoxButton.Size = new Size(102, 27);
            OwnBoxButton.TabIndex = 0;
            OwnBoxButton.Text = "Создать";
            OwnBoxButton.UseVisualStyleBackColor = true;
            // 
            // PolygonBox
            // 
            PolygonBox.BackColor = Color.WhiteSmoke;
            PolygonBox.Controls.Add(PolygonCountLabel);
            PolygonBox.Controls.Add(PolygonYLabel);
            PolygonBox.Controls.Add(PolygonXLabel);
            PolygonBox.Controls.Add(PolygonYTextBox);
            PolygonBox.Controls.Add(PolygonCountTextBox);
            PolygonBox.Controls.Add(PolygonXTextBox);
            PolygonBox.Controls.Add(PolygonBoxButton);
            PolygonBox.Location = new Point(9, 573);
            PolygonBox.Name = "PolygonBox";
            PolygonBox.Size = new Size(291, 184);
            PolygonBox.TabIndex = 4;
            PolygonBox.TabStop = false;
            PolygonBox.Text = "Многоугольник";
            // 
            // PolygonCountLabel
            // 
            PolygonCountLabel.AutoSize = true;
            PolygonCountLabel.Location = new Point(3, 34);
            PolygonCountLabel.Name = "PolygonCountLabel";
            PolygonCountLabel.Size = new Size(152, 20);
            PolygonCountLabel.TabIndex = 14;
            PolygonCountLabel.Text = "Количество вершин:";
            // 
            // PolygonYLabel
            // 
            PolygonYLabel.AutoSize = true;
            PolygonYLabel.Location = new Point(169, 90);
            PolygonYLabel.Name = "PolygonYLabel";
            PolygonYLabel.Size = new Size(28, 20);
            PolygonYLabel.TabIndex = 13;
            PolygonYLabel.Text = "Y1:";
            // 
            // PolygonXLabel
            // 
            PolygonXLabel.AutoSize = true;
            PolygonXLabel.Location = new Point(166, 34);
            PolygonXLabel.Name = "PolygonXLabel";
            PolygonXLabel.Size = new Size(29, 20);
            PolygonXLabel.TabIndex = 10;
            PolygonXLabel.Text = "X1:";
            // 
            // PolygonYTextBox
            // 
            PolygonYTextBox.Location = new Point(169, 113);
            PolygonYTextBox.Name = "PolygonYTextBox";
            PolygonYTextBox.ReadOnly = true;
            PolygonYTextBox.Size = new Size(76, 27);
            PolygonYTextBox.TabIndex = 6;
            PolygonYTextBox.KeyPress += OnlyDigit;
            // 
            // PolygonCountTextBox
            // 
            PolygonCountTextBox.Location = new Point(3, 57);
            PolygonCountTextBox.Name = "PolygonCountTextBox";
            PolygonCountTextBox.Size = new Size(152, 27);
            PolygonCountTextBox.TabIndex = 4;
            PolygonCountTextBox.KeyPress += OnlyDigit;
            // 
            // PolygonXTextBox
            // 
            PolygonXTextBox.Location = new Point(167, 57);
            PolygonXTextBox.Name = "PolygonXTextBox";
            PolygonXTextBox.ReadOnly = true;
            PolygonXTextBox.Size = new Size(76, 27);
            PolygonXTextBox.TabIndex = 3;
            PolygonXTextBox.KeyPress += OnlyDigit;
            // 
            // PolygonBoxButton
            // 
            PolygonBoxButton.Location = new Point(3, 113);
            PolygonBoxButton.Name = "PolygonBoxButton";
            PolygonBoxButton.Size = new Size(111, 27);
            PolygonBoxButton.TabIndex = 0;
            PolygonBoxButton.Text = "ОК";
            PolygonBoxButton.UseVisualStyleBackColor = true;
            PolygonBoxButton.Click += PolygonBoxButton_Click;
            // 
            // TriangleBox
            // 
            TriangleBox.BackColor = Color.WhiteSmoke;
            TriangleBox.Controls.Add(label8);
            TriangleBox.Controls.Add(label9);
            TriangleBox.Controls.Add(label10);
            TriangleBox.Controls.Add(label7);
            TriangleBox.Controls.Add(label5);
            TriangleBox.Controls.Add(label6);
            TriangleBox.Controls.Add(TriangleY3TextBox);
            TriangleBox.Controls.Add(TriangleX3TextBox);
            TriangleBox.Controls.Add(TriangleY2TextBox);
            TriangleBox.Controls.Add(TriangleX2TextBox);
            TriangleBox.Controls.Add(TriangleX1TextBox);
            TriangleBox.Controls.Add(TriangleY1TextBox);
            TriangleBox.Controls.Add(TriangleBoxButton);
            TriangleBox.Location = new Point(9, 383);
            TriangleBox.Name = "TriangleBox";
            TriangleBox.Size = new Size(291, 184);
            TriangleBox.TabIndex = 3;
            TriangleBox.TabStop = false;
            TriangleBox.Text = "Треугольник";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(176, 76);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 14;
            label8.Text = "Y3:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(89, 76);
            label9.Name = "label9";
            label9.Size = new Size(28, 20);
            label9.TabIndex = 13;
            label9.Text = "Y2:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 76);
            label10.Name = "label10";
            label10.Size = new Size(28, 20);
            label10.TabIndex = 12;
            label10.Text = "Y1:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 23);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 11;
            label7.Text = "X3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 23);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 10;
            label5.Text = "X2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 9;
            label6.Text = "X1:";
            // 
            // TriangleY3TextBox
            // 
            TriangleY3TextBox.Location = new Point(176, 100);
            TriangleY3TextBox.Name = "TriangleY3TextBox";
            TriangleY3TextBox.Size = new Size(76, 27);
            TriangleY3TextBox.TabIndex = 8;
            TriangleY3TextBox.KeyPress += OnlyDigit;
            // 
            // TriangleX3TextBox
            // 
            TriangleX3TextBox.Location = new Point(176, 46);
            TriangleX3TextBox.Name = "TriangleX3TextBox";
            TriangleX3TextBox.Size = new Size(76, 27);
            TriangleX3TextBox.TabIndex = 7;
            TriangleX3TextBox.KeyPress += OnlyDigit;
            // 
            // TriangleY2TextBox
            // 
            TriangleY2TextBox.Location = new Point(89, 100);
            TriangleY2TextBox.Name = "TriangleY2TextBox";
            TriangleY2TextBox.Size = new Size(76, 27);
            TriangleY2TextBox.TabIndex = 6;
            TriangleY2TextBox.KeyPress += OnlyDigit;
            // 
            // TriangleX2TextBox
            // 
            TriangleX2TextBox.Location = new Point(89, 46);
            TriangleX2TextBox.Name = "TriangleX2TextBox";
            TriangleX2TextBox.Size = new Size(76, 27);
            TriangleX2TextBox.TabIndex = 5;
            TriangleX2TextBox.KeyPress += OnlyDigit;
            // 
            // TriangleX1TextBox
            // 
            TriangleX1TextBox.Location = new Point(3, 46);
            TriangleX1TextBox.Name = "TriangleX1TextBox";
            TriangleX1TextBox.Size = new Size(76, 27);
            TriangleX1TextBox.TabIndex = 4;
            TriangleX1TextBox.KeyPress += OnlyDigit;
            // 
            // TriangleY1TextBox
            // 
            TriangleY1TextBox.Location = new Point(3, 100);
            TriangleY1TextBox.Name = "TriangleY1TextBox";
            TriangleY1TextBox.Size = new Size(76, 27);
            TriangleY1TextBox.TabIndex = 3;
            TriangleY1TextBox.KeyPress += OnlyDigit;
            // 
            // TriangleBoxButton
            // 
            TriangleBoxButton.Location = new Point(3, 133);
            TriangleBoxButton.Name = "TriangleBoxButton";
            TriangleBoxButton.Size = new Size(111, 27);
            TriangleBoxButton.TabIndex = 0;
            TriangleBoxButton.Text = "Создать";
            TriangleBoxButton.UseVisualStyleBackColor = true;
            TriangleBoxButton.Click += TriangleBoxButton_Click;
            // 
            // EllipsBox
            // 
            EllipsBox.BackColor = Color.WhiteSmoke;
            EllipsBox.Controls.Add(label20);
            EllipsBox.Controls.Add(label21);
            EllipsBox.Controls.Add(EllipsHLabel);
            EllipsBox.Controls.Add(EllipsWLabel);
            EllipsBox.Controls.Add(EllipsXTextBox);
            EllipsBox.Controls.Add(CircleRadioButton);
            EllipsBox.Controls.Add(EllipsRadioButton);
            EllipsBox.Controls.Add(EllipsYTextBox);
            EllipsBox.Controls.Add(EllipsHTextBox);
            EllipsBox.Controls.Add(EllipsWTextBox);
            EllipsBox.Controls.Add(EllipsBoxButton);
            EllipsBox.Location = new Point(6, 193);
            EllipsBox.Name = "EllipsBox";
            EllipsBox.Size = new Size(566, 184);
            EllipsBox.TabIndex = 2;
            EllipsBox.TabStop = false;
            EllipsBox.Text = "Эллипс";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(221, 75);
            label20.Name = "label20";
            label20.Size = new Size(20, 20);
            label20.TabIndex = 16;
            label20.Text = "Y:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(55, 75);
            label21.Name = "label21";
            label21.Size = new Size(21, 20);
            label21.TabIndex = 15;
            label21.Text = "X:";
            // 
            // EllipsHLabel
            // 
            EllipsHLabel.AutoSize = true;
            EllipsHLabel.Location = new Point(170, 23);
            EllipsHLabel.Name = "EllipsHLabel";
            EllipsHLabel.Size = new Size(62, 20);
            EllipsHLabel.TabIndex = 9;
            EllipsHLabel.Text = "Высота:";
            // 
            // EllipsWLabel
            // 
            EllipsWLabel.AutoSize = true;
            EllipsWLabel.Location = new Point(6, 23);
            EllipsWLabel.Name = "EllipsWLabel";
            EllipsWLabel.Size = new Size(70, 20);
            EllipsWLabel.TabIndex = 8;
            EllipsWLabel.Text = "Ширина:";
            // 
            // EllipsXTextBox
            // 
            EllipsXTextBox.Location = new Point(55, 98);
            EllipsXTextBox.Name = "EllipsXTextBox";
            EllipsXTextBox.Size = new Size(76, 27);
            EllipsXTextBox.TabIndex = 6;
            EllipsXTextBox.KeyPress += OnlyDigit;
            // 
            // CircleRadioButton
            // 
            CircleRadioButton.AutoSize = true;
            CircleRadioButton.Location = new Point(365, 79);
            CircleRadioButton.Name = "CircleRadioButton";
            CircleRadioButton.Size = new Size(61, 24);
            CircleRadioButton.TabIndex = 5;
            CircleRadioButton.TabStop = true;
            CircleRadioButton.Text = "Круг";
            CircleRadioButton.UseVisualStyleBackColor = true;
            CircleRadioButton.Click += CircleRadioButton_Click;
            // 
            // EllipsRadioButton
            // 
            EllipsRadioButton.AutoSize = true;
            EllipsRadioButton.Location = new Point(365, 49);
            EllipsRadioButton.Name = "EllipsRadioButton";
            EllipsRadioButton.Size = new Size(80, 24);
            EllipsRadioButton.TabIndex = 2;
            EllipsRadioButton.TabStop = true;
            EllipsRadioButton.Text = "Эллипс";
            EllipsRadioButton.UseVisualStyleBackColor = true;
            EllipsRadioButton.Click += EllipsRadioButton_Click;
            // 
            // EllipsYTextBox
            // 
            EllipsYTextBox.Location = new Point(221, 98);
            EllipsYTextBox.Name = "EllipsYTextBox";
            EllipsYTextBox.Size = new Size(76, 27);
            EllipsYTextBox.TabIndex = 4;
            EllipsYTextBox.KeyPress += OnlyDigit;
            // 
            // EllipsHTextBox
            // 
            EllipsHTextBox.Location = new Point(172, 46);
            EllipsHTextBox.Name = "EllipsHTextBox";
            EllipsHTextBox.Size = new Size(125, 27);
            EllipsHTextBox.TabIndex = 2;
            EllipsHTextBox.KeyPress += OnlyDigit;
            // 
            // EllipsWTextBox
            // 
            EllipsWTextBox.Location = new Point(6, 46);
            EllipsWTextBox.Name = "EllipsWTextBox";
            EllipsWTextBox.Size = new Size(125, 27);
            EllipsWTextBox.TabIndex = 1;
            EllipsWTextBox.KeyPress += OnlyDigit;
            // 
            // EllipsBoxButton
            // 
            EllipsBoxButton.Location = new Point(365, 140);
            EllipsBoxButton.Name = "EllipsBoxButton";
            EllipsBoxButton.Size = new Size(111, 27);
            EllipsBoxButton.TabIndex = 0;
            EllipsBoxButton.Text = "Создать";
            EllipsBoxButton.UseVisualStyleBackColor = true;
            EllipsBoxButton.Click += EllipsBoxButton_Click;
            // 
            // RectangleBox
            // 
            RectangleBox.BackColor = Color.WhiteSmoke;
            RectangleBox.Controls.Add(label19);
            RectangleBox.Controls.Add(label18);
            RectangleBox.Controls.Add(RectangleXTextBox);
            RectangleBox.Controls.Add(RectangleLLabel);
            RectangleBox.Controls.Add(RectangleWLabel);
            RectangleBox.Controls.Add(SquareRadioButton);
            RectangleBox.Controls.Add(RectangleRadioButton);
            RectangleBox.Controls.Add(RectangleYTextBox);
            RectangleBox.Controls.Add(RectangleHTextBox);
            RectangleBox.Controls.Add(RectangleWTextBox);
            RectangleBox.Controls.Add(RectangleBoxButton);
            RectangleBox.Location = new Point(3, 3);
            RectangleBox.Name = "RectangleBox";
            RectangleBox.Size = new Size(566, 184);
            RectangleBox.TabIndex = 1;
            RectangleBox.TabStop = false;
            RectangleBox.Text = "Прямоугольник";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(224, 75);
            label19.Name = "label19";
            label19.Size = new Size(20, 20);
            label19.TabIndex = 14;
            label19.Text = "Y:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(58, 75);
            label18.Name = "label18";
            label18.Size = new Size(21, 20);
            label18.TabIndex = 11;
            label18.Text = "X:";
            // 
            // RectangleXTextBox
            // 
            RectangleXTextBox.Location = new Point(58, 98);
            RectangleXTextBox.Name = "RectangleXTextBox";
            RectangleXTextBox.Size = new Size(76, 27);
            RectangleXTextBox.TabIndex = 8;
            RectangleXTextBox.KeyPress += OnlyDigit;
            // 
            // RectangleLLabel
            // 
            RectangleLLabel.AutoSize = true;
            RectangleLLabel.Location = new Point(170, 23);
            RectangleLLabel.Name = "RectangleLLabel";
            RectangleLLabel.Size = new Size(62, 20);
            RectangleLLabel.TabIndex = 7;
            RectangleLLabel.Text = "Высота:";
            // 
            // RectangleWLabel
            // 
            RectangleWLabel.AutoSize = true;
            RectangleWLabel.Location = new Point(6, 23);
            RectangleWLabel.Name = "RectangleWLabel";
            RectangleWLabel.Size = new Size(70, 20);
            RectangleWLabel.TabIndex = 6;
            RectangleWLabel.Text = "Ширина:";
            // 
            // SquareRadioButton
            // 
            SquareRadioButton.AutoSize = true;
            SquareRadioButton.Location = new Point(365, 79);
            SquareRadioButton.Name = "SquareRadioButton";
            SquareRadioButton.Size = new Size(86, 24);
            SquareRadioButton.TabIndex = 5;
            SquareRadioButton.TabStop = true;
            SquareRadioButton.Text = "Квадрат";
            SquareRadioButton.UseVisualStyleBackColor = true;
            SquareRadioButton.Click += SquareRadioButton_Click;
            // 
            // RectangleRadioButton
            // 
            RectangleRadioButton.AutoSize = true;
            RectangleRadioButton.Location = new Point(365, 49);
            RectangleRadioButton.Name = "RectangleRadioButton";
            RectangleRadioButton.Size = new Size(141, 24);
            RectangleRadioButton.TabIndex = 2;
            RectangleRadioButton.TabStop = true;
            RectangleRadioButton.Text = "Прямоугольник";
            RectangleRadioButton.UseVisualStyleBackColor = true;
            RectangleRadioButton.Click += RectangleRadioButton_Click;
            // 
            // RectangleYTextBox
            // 
            RectangleYTextBox.Location = new Point(224, 98);
            RectangleYTextBox.Name = "RectangleYTextBox";
            RectangleYTextBox.Size = new Size(76, 27);
            RectangleYTextBox.TabIndex = 4;
            RectangleYTextBox.KeyPress += OnlyDigit;
            // 
            // RectangleHTextBox
            // 
            RectangleHTextBox.Location = new Point(172, 46);
            RectangleHTextBox.Name = "RectangleHTextBox";
            RectangleHTextBox.Size = new Size(125, 27);
            RectangleHTextBox.TabIndex = 2;
            RectangleHTextBox.KeyPress += OnlyDigit;
            // 
            // RectangleWTextBox
            // 
            RectangleWTextBox.Location = new Point(6, 46);
            RectangleWTextBox.Name = "RectangleWTextBox";
            RectangleWTextBox.Size = new Size(125, 27);
            RectangleWTextBox.TabIndex = 1;
            RectangleWTextBox.KeyPress += OnlyDigit;
            // 
            // RectangleBoxButton
            // 
            RectangleBoxButton.Location = new Point(365, 140);
            RectangleBoxButton.Name = "RectangleBoxButton";
            RectangleBoxButton.Size = new Size(111, 27);
            RectangleBoxButton.TabIndex = 0;
            RectangleBoxButton.Text = "Создать";
            RectangleBoxButton.UseVisualStyleBackColor = true;
            RectangleBoxButton.Click += RectangleBoxButton_Click;
            // 
            // groupBox6
            // 
            groupBox6.Location = new Point(303, 573);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(269, 184);
            groupBox6.TabIndex = 20;
            groupBox6.TabStop = false;
            groupBox6.Text = "groupBox6";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.WhiteSmoke;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(794, 802);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1393, 802);
            Controls.Add(pictureBox);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            DeleteBox.ResumeLayout(false);
            MoveBox.ResumeLayout(false);
            MoveBox.PerformLayout();
            OwnBox.ResumeLayout(false);
            OwnBox.PerformLayout();
            PolygonBox.ResumeLayout(false);
            PolygonBox.PerformLayout();
            TriangleBox.ResumeLayout(false);
            TriangleBox.PerformLayout();
            EllipsBox.ResumeLayout(false);
            EllipsBox.PerformLayout();
            RectangleBox.ResumeLayout(false);
            RectangleBox.PerformLayout();
            ((ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox RectangleBox;
        private Button RectangleBoxButton;
        private RadioButton RectangleRadioButton;
        private TextBox RectangleYTextBox;
        private TextBox RectangleHTextBox;
        private TextBox RectangleWTextBox;
        private GroupBox EllipsBox;
        private RadioButton CircleRadioButton;
        private RadioButton EllipsRadioButton;
        private TextBox EllipsYTextBox;
        private TextBox EllipsHTextBox;
        private TextBox EllipsWTextBox;
        private Button EllipsBoxButton;
        private RadioButton SquareRadioButton;
        private GroupBox TriangleBox;
        private TextBox TriangleX1TextBox;
        private TextBox TriangleY1TextBox;
        private Button TriangleBoxButton;
        private GroupBox PolygonBox;
        private TextBox PolygonYTextBox;
        private TextBox PolygonCountTextBox;
        private TextBox PolygonXTextBox;
        private Button PolygonBoxButton;
        private TextBox TriangleY3TextBox;
        private TextBox TriangleX3TextBox;
        private TextBox TriangleY2TextBox;
        private TextBox TriangleX2TextBox;
        private TextBox EllipsXTextBox;
        private Label RectangleLLabel;
        private Label RectangleWLabel;
        private Label EllipsHLabel;
        private Label EllipsWLabel;
        private TextBox RectangleXTextBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label PolygonCountLabel;
        private Label PolygonYLabel;
        private Label PolygonXLabel;
        private GroupBox OwnBox;
        private Label label17;
        private TextBox OwnHTextBox;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox OwnYTextBox;
        private TextBox OwnWTextBox;
        private TextBox OwnXTextBox;
        private Button OwnBoxButton;
        private Label label19;
        private Label label18;
        private GroupBox MoveBox;
        private Label label20;
        private Label label21;
        private Button MoveButton;
        private Label label24;
        private Label label25;
        private TextBox MoveYTextBox;
        private TextBox MoveXTextBox;
        private ComboBox FigureComboBox;
        private GroupBox DeleteBox;
        private Button DeleteButton;
        private GroupBox groupBox6;
        private PictureBox pictureBox;
    }
}
