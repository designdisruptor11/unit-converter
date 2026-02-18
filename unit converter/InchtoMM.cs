using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace unit_converter
{
    public class InchtoMM : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the InchtoMM class.
        /// </summary>
        public InchtoMM()
          : base("InchtoMM", "In->MM",
              "Converts inches into MM",
              "UnitConvertor", "Utilities")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("Inches", "In", "Value in Inches", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Millimeters ", "MM", "Converted values in millimeters", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            double inch = 0.0;
            if (!DA.GetData(0, ref inch)) 
                return;
            double MM = inch * 25.4;
            DA.SetData(0, MM);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("ECA118F8-5AC5-4EE9-8BC6-4A184BE78488"); }
        }
    }
}