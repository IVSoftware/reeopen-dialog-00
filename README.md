Your code is showing the specific example of a "settings" form and one of the easier ways to implement this is to have a member field of your main form: `SettingsForm _settings = new SettingsForm()`. Doing it this way means that the app _always_ has access to its member properties and you can show it repeatedly without consequence. You _will_ need to finally dispose the `SettingsForm` when the app terminates.

For a minimal example, here is a main form with a settings menu:

[![screenshot][1]][1]

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            sort();
            settingsMenu.Click += onClickSettingsMenu;
            // Dispose the SettingsForm when the MainForm does.
            Disposed += (sender, e) => _settings.Dispose();
        }
        SettingsForm _settings = new SettingsForm();
        .
        .
        .
    }

***
The settings menu click is handled as follows:

    public partial class MainForm : Form
    {
        .
        .
        .
        private void onClickSettingsMenu(object? sender, EventArgs e)
        {
            if(DialogResult.OK.Equals(_settings.ShowDialog(this)))
            {
                sort();
            }
        }
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

Where

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

***
**Settings Form**

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
                    SortType = (SortType)Enum.Parse(
                         typeof(SortType), 
                         ((RadioButton)sender).Text);
                };
            }
            buttonApply.Click += (sender, e) => DialogResult = DialogResult.OK;
            AcceptButton = buttonApply;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
        public SortType SortType { get; set; }
    }




The Microsoft documentation for [ShowDialog](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.showdialog?view=windowsdesktop-7.0) explains how this works.

> When a form is displayed as a modal dialog box, clicking the Close button (the button with an X at the upper-right corner of the form) causes the form to be hidden and the DialogResult property to be set to DialogResult.Cancel. Unlike non-modal forms, the Close method is not called by the .NET Framework when the user clicks the close form button of a dialog box or sets the value of the DialogResult property. Instead the form is hidden and can be shown again without creating a new instance of the dialog box. Because a form displayed as a dialog box is hidden instead of closed, you must call the Dispose method of the form when the form is no longer needed by your application.


  [1]: https://i.stack.imgur.com/OlRvm.png