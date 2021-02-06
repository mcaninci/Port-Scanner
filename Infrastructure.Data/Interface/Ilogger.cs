using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infrastructure.Data.Interface
{
    public interface Ilogger
    {
       void SetTargetComp (RichTextBox richTextBox);
       void WriteLog(string message);
    }
}
