using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RichEditRibbonPerformanceBench {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {

        Stopwatch sw = new Stopwatch();
        public Form1() {
            sw.Start();
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            sw.Stop();
            labelControl1.Text = "<b>Elapsed time:</b><br>" + sw.ElapsedMilliseconds.ToString() + " ms";
            File.AppendAllText(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Results.txt", sw.ElapsedMilliseconds.ToString() + Environment.NewLine);
        }
    }
}
