using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace unit_converter
{
    public class unit_converterInfo : GH_AssemblyInfo
    {
        public override string Name => "unit converter";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("53707bab-d886-40fc-bf0e-199f3e368c9a");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}