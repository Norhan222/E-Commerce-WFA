using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.PL
{
    internal class TransparentPanel :Panel
    {
        public TransparentPanel()
        {
            this.SetStyle(ControlStyles.Opaque, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // ارسم مستطيل أسود بشفافية 120 فوق الخلفية
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, Color.Black)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
