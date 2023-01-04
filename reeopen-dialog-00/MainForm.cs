using System.DirectoryServices.ActiveDirectory;
using System.Numerics;
using System.Windows.Forms;

namespace reeopen_dialog_00
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            sort();
            settingsMenu.Click += onClickSettingsMenu;
            Disposed += (sender, e) => _settings.Dispose();
        }
        SettingsForm _settings = new SettingsForm();
        private void onClickSettingsMenu(object? sender, EventArgs e)
        {
            if(DialogResult.OK.Equals(_settings.ShowDialog(this)))
            {
                sort();
            }
        }

        // This method is always able to access the member properties of SettingsForm
        private void sort()
        {
            switch (_settings.SortType)
            {
                case SortType.None:
                    textBoxMultiline.Text =
                        string.Join(
                            Environment.NewLine,
                            _testData);
                    break;
                case SortType.Alphanumeric:
                    textBoxMultiline.Text =
                        string.Join(
                            Environment.NewLine,
                            _testData.OrderBy(_=>_));
                    break;
            }
            textBoxMultiline.Select(0,0);
        }
        List<string> _testData = new List<string>
        { 
            "occasion", 
            "twin", 
            "intention",
            "arrow", 
            "draw", 
            "forest", 
            "please", 
            "shell",
            "momentum",
            "coalition",
        };
    }
}