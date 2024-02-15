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
using System.Reflection.Metadata.Ecma335;
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
                if (RectangleXTextBox.Text == string.Empty || RectangleYTextBox.Text == string.Empty || RectangleHTextBox.Text == string.Empty || RectangleWTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Введите данные!!!");
                    return;
                }
                if (int.Parse(RectangleXTextBox.Text) > Init.pictureBox.Width || int.Parse(RectangleYTextBox.Text) > Init.pictureBox.Height
                    || int.Parse(RectangleXTextBox.Text) + int.Parse(RectangleWTextBox.Text) > Init.pictureBox.Width || int.Parse(RectangleHTextBox.Text) + int.Parse(RectangleYTextBox.Text) > Init.pictureBox.Height)
                {
                    MessageBox.Show("Выход за границы!");
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
            else if (SquareRadioButton.Checked)
            {
                if (RectangleXTextBox.Text == string.Empty || RectangleYTextBox.Text == string.Empty || RectangleWTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Введите данные!!!");
                    return;
                }
                if (int.Parse(RectangleXTextBox.Text) > Init.pictureBox.Width || int.Parse(RectangleYTextBox.Text) > Init.pictureBox.Height
                    || int.Parse(RectangleXTextBox.Text) + int.Parse(RectangleWTextBox.Text) > Init.pictureBox.Width || int.Parse(RectangleWTextBox.Text) + int.Parse(RectangleXTextBox.Text) > Init.pictureBox.Height)
                {
                    MessageBox.Show("Выход за границы!");
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
                MessageBox.Show("Выберите фигуру!");
            }
            RectangleXTextBox.Clear();
            RectangleYTextBox.Clear();
            RectangleWTextBox.Clear();
            RectangleHTextBox.Clear();
        }
        private void EllipsBoxButton_Click(object sender, EventArgs e)
        {
            if (EllipsRadioButton.Checked)
            {
                if (EllipsXTextBox.Text == string.Empty || EllipsYTextBox.Text == string.Empty || EllipsWTextBox.Text == string.Empty || EllipsHTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Введите данные!!!");
                    return;
                }
                if (int.Parse(EllipsXTextBox.Text) > Init.pictureBox.Width || int.Parse(EllipsYTextBox.Text) > Init.pictureBox.Height
                    || int.Parse(EllipsXTextBox.Text) + int.Parse(EllipsWTextBox.Text) > Init.pictureBox.Width || int.Parse(EllipsWTextBox.Text) + int.Parse(EllipsXTextBox.Text) > Init.pictureBox.Height)
                {
                    MessageBox.Show("Выход за границы!");
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
            else if (CircleRadioButton.Checked)
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
                MessageBox.Show("Выберите фигуру!");
            }
            EllipsXTextBox.Clear();
            EllipsYTextBox.Clear();
            EllipsWTextBox.Clear();
            EllipsHTextBox.Clear();
        }
        private void TriangleBoxButton_Click(object sender, EventArgs e)
        {
            if (TriangleX1TextBox.Text == string.Empty || TriangleX2TextBox.Text == string.Empty || TriangleX3TextBox.Text == string.Empty
                || TriangleY1TextBox.Text == string.Empty || TriangleY2TextBox.Text == string.Empty || TriangleY3TextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите данные!!!");
                return;
            }
            if (int.Parse(TriangleX1TextBox.Text) > Init.pictureBox.Width || int.Parse(TriangleX2TextBox.Text) > Init.pictureBox.Width || int.Parse(TriangleX3TextBox.Text) > Init.pictureBox.Width
                || int.Parse(TriangleY1TextBox.Text) > Init.pictureBox.Height || int.Parse(TriangleY2TextBox.Text) > Init.pictureBox.Height || int.Parse(TriangleY3TextBox.Text) > Init.pictureBox.Height)
            {
                MessageBox.Show("Выход за границы!");
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
            TriangleX1TextBox.Clear();
            TriangleY1TextBox.Clear();
            TriangleX2TextBox.Clear();
            TriangleY2TextBox.Clear();
            TriangleX3TextBox.Clear();
            TriangleY3TextBox.Clear();
        }
        private int i = 0;
        private PolygonClass polygon = new PolygonClass();
        private void PolygonBoxButton_Click(object sender, EventArgs e)
        {
            if (polygon.count == 0)
            {
                if (PolygonCountTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Введите данные!!!");
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
                    MessageBox.Show("Введите данные!!!");
                    return;
                }
                polygon.polygonPoints[i] = new Point(int.Parse(PolygonXTextBox.Text), int.Parse(PolygonYTextBox.Text));
                if (polygon.polygonPoints[i].X > Init.pictureBox.Width || polygon.polygonPoints[i].Y > Init.pictureBox.Height)
                {
                    MessageBox.Show("Выход за границы!");
                    return;
                }
                PolygonXTextBox.Clear();
                PolygonYTextBox.Clear();
                if (i + 1 == polygon.count)
                {
                    PolygonBoxButton.Text = "Создать";
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
                PolygonClass newPolygon = new PolygonClass(polygon.count, polygon.polygonPoints);
                ShapeContainer.AddFigure(newPolygon);
                FigureComboBox.Items.Add(newPolygon);
                polygon.Draw();
                PolygonBoxButton.Text = "ОК";
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
        private void OwnBoxButton_Click(object sender, EventArgs e)
        {
            if (OwnXTextBox.Text == string.Empty || OwnYTextBox.Text == string.Empty || OwnHTextBox.Text == string.Empty || OwnWTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите данные!!!");
                return;
            }
            if (int.Parse(OwnXTextBox.Text) > Init.pictureBox.Width || int.Parse(OwnYTextBox.Text) > Init.pictureBox.Height
                || int.Parse(OwnXTextBox.Text) + int.Parse(OwnWTextBox.Text) > Init.pictureBox.Width || int.Parse(OwnHTextBox.Text) + int.Parse(OwnYTextBox.Text) > Init.pictureBox.Height)
            {
                MessageBox.Show("Выход за границы!");
                return;
            }
            OwnFigureClass ownFigure = new OwnFigureClass(int.Parse(OwnXTextBox.Text),
                                                    int.Parse(OwnYTextBox.Text),
                                                    int.Parse(OwnWTextBox.Text),
                                                    int.Parse(OwnHTextBox.Text));
            ShapeContainer.AddFigure(ownFigure);
            ownFigure.Draw();
            FigureComboBox.Items.Add(ownFigure);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FigureComboBox.Items.Count == 0)
            {
                MessageBox.Show("Список фигур пуст");
                return;
            }
            else if (FigureComboBox.SelectedItem == null)
            {
                MessageBox.Show("Фигура не выбрана");
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
                MessageBox.Show("Список фигур пуст");
            }
            else if (FigureComboBox.SelectedItem == null)
            {
                MessageBox.Show("Фигура не выбрана");
            }
            else if (!minusOnFirstOrOne(MoveXTextBox) || !minusOnFirstOrOne(MoveYTextBox))
            {
                MessageBox.Show("Некорректный ввод значений для перемещения");
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
        private bool minusOnFirstOrOne(TextBox textBox)
        {
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] == '-' && i != 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void MoveXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void MoveYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace,-
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
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
            EllipsWLabel.Text = "Ширина";
        }

        private void CircleRadioButton_Click(object sender, EventArgs e)
        {
            EllipsHTextBox.Visible = false;
            EllipsHLabel.Visible = false;
            EllipsWLabel.Text = "Диаметр:";
        }
    }
}
