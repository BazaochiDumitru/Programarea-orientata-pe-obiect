using System.Drawing;
using System.Windows.Forms;

namespace PaintApplication
{
    class ChangePen
    {
        public void ChangePenWeight(Pen pen, int width)
        {
            pen.Width = width;
        }

        public void ChangePenColor(ColorDialog colorDialog, Pen pen, ToolStripButton btn)
        {
            colorDialog.ShowDialog();
            Color color = colorDialog.Color;
            pen.Color = color;
            btn.BackColor = color;
        }

    }
}
