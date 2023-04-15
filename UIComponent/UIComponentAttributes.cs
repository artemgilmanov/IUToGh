using Grasshopper.GUI.Canvas;
using Grasshopper.GUI;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIComponent
{
    public class UIComponentAttributes : GH_ComponentAttributes
    {
        public UIComponentAttributes(IGH_Component component) : base(component)
        {
        }

        public override GH_ObjectResponse RespondToMouseDoubleClick(GH_Canvas sender, GH_CanvasMouseEvent e)
        {
            (Owner as UIComponent)?.DisplayWindows();
            return GH_ObjectResponse.Handled;
        }
    }
}
