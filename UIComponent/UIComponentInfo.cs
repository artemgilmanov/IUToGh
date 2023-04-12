using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace UIComponent
{
    public class UIComponentInfo : GH_AssemblyInfo
    {
        public override string Name => "UIComponent";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("de999d88-7127-4e69-82e4-f779a2504079");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}