using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using BrightIdeasSoftware;

namespace Skyrim_Save_Editor.Forms.Main {
	class LineRenderer : TreeListView.TreeRenderer {
		protected override void DrawLines(System.Drawing.Graphics g, System.Drawing.Rectangle r, System.Drawing.Pen p, TreeListView.Branch br) {
			g.SmoothingMode = SmoothingMode.None;
			base.DrawLines(g, r, p, br);
		}
	}
}
