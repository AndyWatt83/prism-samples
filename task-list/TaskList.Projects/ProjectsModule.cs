using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Projects
{
    [ModuleExport(typeof(ProjectsModule))]
    public class ProjectsModule : IModule
    {
        [Import(typeof(IRegionManager))]
        public IRegionManager RegionManager { get; set; }

        public void Initialize()
        {
            RegionManager.RegisterViewWithRegion("ProjectsRegion", typeof(Projects));
        }
    }
}
