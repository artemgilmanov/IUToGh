using UIWpfApp.ViewModel;
using Grasshopper;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using UIWpfApp;
using UIWpfApp.Model;
using UIWpfApp.View;

namespace UIComponent
{
    public class UIComponent : GH_Component
    {
        private MainWindow _mainUIPanel;

        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public UIComponent()
          : base("UIComponent", "UIC",
            "Description",
            "Extra", "UI")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddBooleanParameter("GroupOneOptionOne", "G1O1", "GroupOneOptionOne", GH_ParamAccess.item);
            pManager.AddBooleanParameter("GroupOneOptionTwo", "G1O2", "GroupOneOptionTwo", GH_ParamAccess.item);
            pManager.AddBooleanParameter("GroupOneOptionThree", "G1O3", "GroupOneOptionThree", GH_ParamAccess.item);

            pManager.AddBooleanParameter("GroupTwoOptionOne", "G2O1", "GroupTwoOptionOne", GH_ParamAccess.item);
            pManager.AddBooleanParameter("GroupTwiOptionTwo", "G2O2", "GroupTwoOptionTwo", GH_ParamAccess.item);

            pManager.AddTextParameter("StringOutput", "SO", "StringOutput", GH_ParamAccess.item);



        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            if (!(_mainUIPanel?.DataContext is MainViewModel mp)) return;
            DA.SetData(0, mp.GroupOneOptionOne);
            DA.SetData(1, mp.GroupOneOptionTwo);
            DA.SetData(2, mp.GroupOneOptionThree);

            DA.SetData(3, mp.GroupTwoOptionOne);
            DA.SetData(4, mp.GroupTwoOptionTwo);

            DA.SetData(5, mp.ValuesString);


            mp.UpdateDefinition(() => ExpireSolution(true));
        }

        public override void CreateAttributes()
        {
            m_attributes = new UIComponentAttributes(this);
        }

        public void DisplayWindows()
        {
            _mainUIPanel = new MainWindow();
            _mainUIPanel.Show();
            if (!(_mainUIPanel.DataContext is MainViewModel mp)) return;
            mp.UpdateDefinition(() => ExpireSolution(true));
        }

        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// You can add image files to your project resources and access them like this:
        /// return Resources.IconForThisComponent;
        /// </summary>
        protected override System.Drawing.Bitmap Icon => null;

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f317021b-1327-4f2a-8332-a317628bfb7e");
    }
}