using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fritz.EpicBuildMusic.Core
{
  public partial class GeneralOptionsUserControl : UserControl
  {

    internal IBuildMusicOptions OptionPage { get; private set; }
    private IFileSystemHandler _FileSystemHandler;
    internal bool _IsInitializing = true;

    public GeneralOptionsUserControl()
    {
      InitializeComponent();
    }

    public void Initialize(IBuildMusicOptions options, IFileSystemHandler fileSystemHandler = null)
    {

      _FileSystemHandler = fileSystemHandler ?? new FileSystemHandler(); 

      _IsInitializing = true;

      OptionPage = options;
      InitializeDuringBuildControls();

      _IsInitializing = false;

    }

    /// <summary>
    /// Initialize the controls that define the music that will play during build
    /// </summary>
    private void InitializeDuringBuildControls()
    {

      DefaultMusicDuringBuild = (string.IsNullOrEmpty(OptionPage.DuringBuildMusic) || OptionPage.DuringBuildMusic == MusicPlayer.DefaultFileName);
      if (OptionPage.DuringBuildMusic != MusicPlayer.DefaultFileName)
      {
        OtherMusicDuringBuild = OptionPage.DuringBuildMusic;
      }

    }

    private void SetDuringBuildControlsState(bool isDefaultMusic)
    {
      MusicDuringBuildTextbox.Enabled = !isDefaultMusic;
      MusicDuringBuildOpenButton.Enabled = !isDefaultMusic;
      if (isDefaultMusic)
      {
        MusicDuringBuildTextbox.Text = string.Empty;
      }
    }

    public void PersistDuringMusicSelection()
    {

      if (_IsInitializing) return;

      if (DefaultMusicDuringBuildCheckbox.Checked)
      {
        OptionPage.DuringBuildMusic = MusicPlayer.DefaultFileName;
      }
      else
      {
        if (_FileSystemHandler.FileExists(MusicDuringBuildTextbox.Text))
        {
          OptionPage.DuringBuildMusic = MusicDuringBuildTextbox.Text;
        }
        else
        {
          MessageBox.Show($"During Build Music file {MusicDuringBuildTextbox.Text} does not exist.\n\nValue will not be used");
        }
      }

    }

    private void DefaultMusicDuringBuildCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      SetDuringBuildControlsState(DefaultMusicDuringBuildCheckbox.Checked);

      PersistDuringMusicSelection();
    }

    private void MusicDuringBuildOpenButton_Click(object sender, EventArgs e)
    {
      fileDialog.Title = "Choose a file to play during build";
      fileDialog.FileOk += FileDialog_FileOk;
      var result = fileDialog.ShowDialog();
    }

    private void FileDialog_FileOk(object sender, CancelEventArgs e)
    {

      if (!e.Cancel)
      {
        MusicDuringBuildTextbox.Text = fileDialog.FileName;
        PersistDuringMusicSelection();
      }
      fileDialog.FileOk -= FileDialog_FileOk;

    }

    private void MusicDuringBuildTextbox_Leave(object sender, EventArgs e)
    {
      PersistDuringMusicSelection();
    }

    #region Control UI Properties

    public bool DefaultMusicDuringBuild
    {
      get { return DefaultMusicDuringBuildCheckbox.Checked; }
      set
      {

        DefaultMusicDuringBuildCheckbox.Checked = value;
        SetDuringBuildControlsState(this.DefaultMusicDuringBuild);

      }
    }

    public string OtherMusicDuringBuild
    {
      get { return MusicDuringBuildTextbox.Text; }
      set { MusicDuringBuildTextbox.Text = value; }
    }

    #endregion

  }
}
