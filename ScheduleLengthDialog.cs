/*Author Preston Rottinghaus
 * file: ScheduleLengthDialog.cs
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.Scheduler
{
    /// <summary>
    /// gives us the ability to set the output
    /// </summary>
    public partial class ScheduleLengthDialog : Form
    {
        /// <summary>
        /// gets/sets the length value
        /// </summary>
        public decimal Length { get => uxSetLength.Value; set => uxSetLength.Value = value; }

        /// <summary>
        /// creates compunet
        /// </summary>
        public ScheduleLengthDialog()
        {
            InitializeComponent();
        }
    }
}
