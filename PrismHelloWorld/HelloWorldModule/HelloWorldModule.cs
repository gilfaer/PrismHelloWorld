using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;

namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public HelloWorldModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(HelloWorldView));
        }
    }
}
