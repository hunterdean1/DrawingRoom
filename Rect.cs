﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapesAndInheritance
{
	class Rect : Shape
	{				
		public Rect(float x, float y, float w, float h, Color c, Color o, int r, Brush i) : base(x, y, w, h, c, o, r, i)
		{
			this.type = Type.Rect;
		}

        // Draws a rectangle
		public override void DrawShape(Graphics g)
		{
			using (Brush b = new SolidBrush(this.fill))
			{
				g.FillRectangle(b, new RectangleF(this.loc, this.size));
			}
			using (Pen p = new Pen(this.outline))
			{
				Point point = new Point((int)this.loc.X, (int)this.loc.Y);
				Size size = new Size((int)this.size.Width, (int)this.size.Height);
				g.DrawRectangle(p, new Rectangle(point, size));
			}			
		}
	}
}
