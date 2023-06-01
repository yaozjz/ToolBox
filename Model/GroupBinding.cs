using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ToolBox.Model
{
    class GroupBinding
    {
        public string Icon { get; set; }
        public string GroupName { get; set; }
    }

    class ToolsBinding
    {
        public ImageSource Icon { get; set; }
        public string Name { get; set; }
        public string ToolPath { get; set; }
        public string Time { get; set; }
    }
}
