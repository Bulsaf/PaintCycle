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
using Art.Figures;
namespace Art
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            Pen pen = new Pen(Color.Black, 5);
            Init.bitmap = bitmap;
            Init.pictureBox = pictureBox;
            Init.pen = pen;
        }
        private void RectangleBoxButton_Click(object sender, EventArgs e)
        {
            if (RectangleRadioButton.Checked)
            {
                if(RectangleXTextBox.Text == string.Empty || RectangleYTextBox.Text == string.Empty || RectangleHTextBox.Text == string.Empty || RectangleWTextBox.Text == string.Empty)
                {
                    MessageBox.Show("������� ������!!!");
                    return;
                }
                if (int.Parse(RectangleXTextBox.Text) > Init.pictureBox.Width || int.Parse(RectangleYTextBox.Text) > Init.pictureBox.Height 
                    || int.Parse(RectangleXTextBox.Text) + int.Parse(RectangleWTextBox.Text) > Init.pictureBox.Width || int.Parse(RectangleHTextBox.Text) + int.Parse(RectangleYTextBox.Text) > Init.pictureBox.Height)
                {
                    MessageBox.Show("����� �� �������!");
                    return;
                }
                RectangleClass rectangle = new RectangleClass(int.Parse(RectangleXTextBox.Text),
                                                    int.Parse(RectangleYTextBox.Text),
                                                    int.Parse(RectangleWTextBox.Text),
                                                    int.Parse(RectangleHTextBox.Text));
                ShapeContainer.AddFigure(rectangle);
                rectangle.Draw();
                FigureComboBox.Items.Add(rectangle);
            }
            else if(SquareRadioButton.Checked)
            {
                if (RectangleXTextBox.Text == string.Empty || RectangleYTextBox.Text == string.Empty || RectangleWTextBox.Text == string.Empty)
                {
                    MessageBox.Show("������� ������!!!");
                    return;
                }
                if (int.Parse(RectangleXTextBox.Text) > Init.pictureBox.Width || int.Parse(RectangleYTextBox.Text) > Init.pictureBox.Height
                    || int.Parse(RectangleXTextBox.Text) + int.Parse(RectangleWTextBox.Text) > Init.pictureBox.Width || int.Parse(RectangleWTextBox.Text) + int.Parse(RectangleXTextBox.Text) > Init.pictureBox.Height)
                {
                    MessageBox.Show("����� �� �������!");
                    return;
                }
                RectangleClass square = new SquareClass(int.Parse(RectangleXTextBox.Text),
                                                    int.Parse(RectangleYTextBox.Text),
                                                    int.Parse(RectangleWTextBox.Text));
                ShapeContainer.AddFigure(square);
                square.Draw();
                FigureComboBox.Items.Add(square);
            }
            else
            {
                MessageBox.Show("�������� ������!");
            }
        }
        private void EllipsBoxButton_Click(object sender, EventArgs e)
        {
            if (EllipsRadioButton.Checked)
            {
                if (EllipsXTextBox.Text == string.Empty || EllipsYTextBox.Text == string.Empty || EllipsWTextBox.Text == string.Empty|| EllipsHTextBox.Text == string.Empty)
                {
                    MessageBox.Show("������� ������!!!");
                    return;
                }
                if (int.Parse(EllipsXTextBox.Text) > Init.pictureBox.Width || int.Parse(EllipsYTextBox.Text) > Init.pictureBox.Height
                    || int.Parse(EllipsXTextBox.Text) + int.Parse(EllipsWTextBox.Text) > Init.pictureBox.Width || int.Parse(EllipsWTextBox.Text) + int.Parse(EllipsXTextBox.Text) > Init.pictureBox.Height)
                {
                    MessageBox.Show("����� �� �������!");
                    return;
                }
                EllipsClass ellips = new EllipsClass(int.Parse(EllipsXTextBox.Text),
                                                int.Parse(EllipsYTextBox.Text),
                                                int.Parse(EllipsWTextBox.Text),
                                                int.Parse(EllipsHTextBox.Text));
                ShapeContainer.AddFigure(ellips);
                ellips.Draw();
                FigureComboBox.Items.Add(ellips);
            }
            else if(CircleRadioButton.Checked)
            {
                EllipsClass circle = new CircleClass(int.Parse(EllipsXTextBox.Text),
                                                int.Parse(EllipsYTextBox.Text),
                                                int.Parse(EllipsWTextBox.Text));
                ShapeContainer.AddFigure(circle);
                circle.Draw();
                FigureComboBox.Items.Add(circle);
            }
            else
            {
                MessageBox.Show("�������� ������!");
            }
        }
        private void TriangleBoxButton_Click(object sender, EventArgs e)
        {
            if (TriangleX1TextBox.Text == string.Empty || TriangleX2TextBox.Text == string.Empty || TriangleX3TextBox.Text == string.Empty
                || TriangleY1TextBox.Text == string.Empty || TriangleY2TextBox.Text == string.Empty|| TriangleY3TextBox.Text == string.Empty)
            {
                MessageBox.Show("������� ������!!!");
                return;
            }
            if (int.Parse(TriangleX1TextBox.Text) > Init.pictureBox.Width || int.Parse(TriangleX2TextBox.Text) > Init.pictureBox.Width || int.Parse(TriangleX3TextBox.Text) > Init.pictureBox.Width
                || int.Parse(TriangleY1TextBox.Text) > Init.pictureBox.Height || int.Parse(TriangleY2TextBox.Text) > Init.pictureBox.Height || int.Parse(TriangleY3TextBox.Text) > Init.pictureBox.Height)
            {
                MessageBox.Show("����� �� �������!");
                return;
            }
            TriangleClass triangle = new TriangleClass(int.Parse(TriangleX1TextBox.Text),
                                                    int.Parse(TriangleY1TextBox.Text),
                                                    int.Parse(TriangleX2TextBox.Text),
                                                    int.Parse(TriangleY2TextBox.Text),
                                                    int.Parse(TriangleX3TextBox.Text),
                                                    int.Parse(TriangleY3TextBox.Text));
            ShapeContainer.AddFigure(triangle);
            triangle.Draw();
            FigureComboBox.Items.Add(triangle);
        }
        private int i = 0;
        private PolygonClass polygon = new PolygonClass();
        private void PolygonBoxButton_Click(object sender, EventArgs e)
        {
            if (polygon.count == 0)
            {
                if (PolygonCountTextBox.Text == string.Empty)
                {
                    MessageBox.Show("������� ������!!!");
                    return;
                }
                polygon.count = int.Parse(PolygonCountTextBox.Text);
                polygon.polygonPoints = new Point[polygon.count];
                PolygonCountTextBox.ReadOnly = true;
                PolygonXTextBox.ReadOnly = false;
                PolygonYTextBox.ReadOnly = false;
                return;
            }
            if (i < polygon.count)
            {
                if (PolygonXTextBox.Text == string.Empty || PolygonYTextBox.Text == string.Empty)
                {
                    MessageBox.Show("������� ������!!!");
                    return;
                }
                polygon.polygonPoints[i] = new Point(int.Parse(PolygonXTextBox.Text), int.Parse(PolygonYTextBox.Text));
                if (polygon.polygonPoints[i].X > Init.pictureBox.Width || polygon.polygonPoints[i].Y > Init.pictureBox.Height)
                {
                    MessageBox.Show("����� �� �������!");
                    return;
                }
                PolygonXTextBox.Clear();
                PolygonYTextBox.Clear();
                if (i + 1 == polygon.count)
                {
                    PolygonBoxButton.Text = "�������";
                    PolygonXTextBox.ReadOnly = true;
                    PolygonYTextBox.ReadOnly = true;
                    i++;
                    return;
                }
                i++;
                PolygonXLabel.Text = "X" + (i + 1) + ":";
                PolygonYLabel.Text = "Y" + (i + 1) + ":";
            }
            else
            {
                ShapeContainer.AddFigure(polygon);
                polygon.Draw();
                FigureComboBox.Items.Add(polygon);
                PolygonBoxButton.Text = "��";
                PolygonXLabel.Text = "X1:";
                PolygonYLabel.Text = "Y1:";
                PolygonCountTextBox.ReadOnly = false;
                PolygonXTextBox.Clear();
                PolygonYTextBox.Clear();
                PolygonCountTextBox.Clear();
                i = 0;
                polygon.count = 0;
                polygon.polygonPoints = null;

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FigureComboBox.Items.Count == 0)
            {
                MessageBox.Show("������ ����� ����");
                return;
            }
            else if (FigureComboBox.SelectedItem == null)
            {
                MessageBox.Show("������ �� �������");
            }
            else
            {
                ShapeContainer.shapeContainer[FigureComboBox.SelectedIndex].DeleteFigure(true);
                FigureComboBox.Items.RemoveAt(FigureComboBox.SelectedIndex);
                FigureComboBox.Text = string.Empty;
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (FigureComboBox.Items.Count == 0)
            {
                MessageBox.Show("������ ����� ����");
            }
            else if (FigureComboBox.SelectedItem == null)
            {
                MessageBox.Show("������ �� �������");
            }
            else
            {
                ShapeContainer.shapeContainer[FigureComboBox.SelectedIndex].MoveTo(int.Parse(MoveXTextBox.Text), int.Parse(MoveYTextBox.Text));
            }
        }
        private void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void MoveXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ���� � texBox ������ ���� � ������ Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void MoveYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ���� � texBox ������ ���� � ������ Backspace,-
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void PolygonCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void PolygonXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }
        private void PolygonYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void RectangleWTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void RectangleHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void RectangleXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void RectangleYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void EllipsWTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void EllipsHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void EllipsXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void EllipsYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TriangleX1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }
        private void TriangleX2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TriangleX3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TriangleY1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }
        private void TriangleY2TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }
        private void TriangleY3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void OwnWTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void OwnHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void OwnXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void OwnYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void RectangleRadioButton_Click(object sender, EventArgs e)
        {
            RectangleHTextBox.Visible = true;
            RectangleLLabel.Visible = true;
        }

        private void SquareRadioButton_Click(object sender, EventArgs e)
        {
            RectangleHTextBox.Visible = false;
            RectangleLLabel.Visible = false;
        }

        private void EllipsRadioButton_Click(object sender, EventArgs e)
        {
            EllipsHTextBox.Visible = true;
            EllipsHLabel.Visible = true;
            EllipsWLabel.Text = "������";
        }

        private void CircleRadioButton_Click(object sender, EventArgs e)
        {
            EllipsHTextBox.Visible = false;
            EllipsHLabel.Visible = false;
            EllipsWLabel.Text = "�������:";
        }
    }
}
