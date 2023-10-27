using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToolBox.Model
{
    class ConfigFileCreate
    {
        /// <summary>
        /// 文件夹创建函数
        /// </summary>
        /// <param name="path">目标文件你家路径</param>
        /// <returns>创建是否成功</returns>
        public static bool CreateDir(string path)
        {
            //检查文件夹结构
            if (!Directory.Exists(path))
            {
                try
                {
                    //不存在文件夹则创建
                    Directory.CreateDirectory(path);
                    return true;
                }
                catch { }
            }
            return false;
        }

        public static ImageSource Icon2ImgSource(Icon icon)
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(icon.Handle,
            new System.Windows.Int32Rect(0, 0, icon.Width, icon.Height),
                BitmapSizeOptions.FromEmptyOptions());
        }

        /// <summary>
        /// 通过路径获取icon图标
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static ImageSource GetIcon(string path)
        {
            Icon icon = Icon.ExtractAssociatedIcon(path);
            return Icon2ImgSource(icon);
        }
    }
}
