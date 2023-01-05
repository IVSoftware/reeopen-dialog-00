using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reeopen_dialog_00
{
    public enum SortType
    {
        None,
        Alphanumeric,
    }
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            foreach (RadioButton radioButton in groupSort.Controls)
            {
                radioButton.CheckedChanged += (sender, e) =>
                {
                    SortType = (SortType)Enum.Parse(typeof(SortType), ((RadioButton)sender).Text);
                };
            }
            buttonApply.Click += (sender, e) => DialogResult = DialogResult.OK;
            AcceptButton = buttonApply;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
        public SortType SortType { get; set; }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            Location = new Point(Owner.Location.X + Owner.Width, Location.Y);
        }
    }
}
