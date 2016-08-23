using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Диаграмма_построения_качки
{
    class Fabric
    {
        static Manager g_Manager = new Manager();
        public static Manager Get()
        {
            return g_Manager;
        }
    }
}
