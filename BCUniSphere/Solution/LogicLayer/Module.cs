using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCUniSphere.LogicLayer
{
    internal class Module
    {
        public Module(string moduleCode, string moduleName, string moduleDescription, string moduleLinks)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            ModuleDescription = moduleDescription;
            ModuleLinks = moduleLinks;
        }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public string ModuleLinks { get; set; }

        public Module()
        {

        }
    }
}
