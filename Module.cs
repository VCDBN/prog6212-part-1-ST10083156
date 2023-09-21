using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6212_POE
{
    public class Module
    {
        //variables used to create properties for "Module" objects
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credits { get; set; }
        public int ClassHrs { get; set; }
        public static List<Module> Modules { get; set; }
            
       //empty constructor used to initialize static Modules List
        public Module() { Modules = new List<Module>(); }

        //overloaded constructor used to create modules objects
        public Module(string name, string code, int credits, int classHrs)
        {
            Name = name;
            Code = code;
            Credits = credits;
            ClassHrs = classHrs;
                    
        }
        public void AddModule(Module module)
        {
            Modules.Add(module);
        }
        public void RemoveModule(Module module)
        {
            Modules.Remove(module);
        }
    }
}
