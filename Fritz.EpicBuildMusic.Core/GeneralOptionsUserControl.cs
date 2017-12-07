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
    internal bool _IsInitializing = true;

    public GeneralOptionsUserControl()
    {
      InitializeComponent();
    }

    public void Initialize(IBuildMusicOptions options)
    {

      _IsInitializing = true;

      OptionPage = options;
      InitializeDuringBuildControls();

      _IsInitializing = false;

    }

    private void InitializeDuringBuildControls()
    {

      DefaultMusicDuringBuild = (string.IsNullOrEmpty(OptionPage.DuringBuildMusic) || OptionPage.DuringBuildMusic == MusicPlayer.DefaultFileName);
      if (OptionPage.DuringBuildMusic != MusicPlayer.DefaultFileName)
      {
        MusicDuringBuildTextbox.Text = OptionPage.DuringBuildMusic;
      }

    }

    private void SetDuringBuildControlsState(bool state)
    {
      MusicDuringBuildTextbox.Enabled = state;
      MusicDuringBuildOpenButton.Enabled = state;
    }

    private void PersistDuringMusicSelection()
    {

      if (_IsInitializing) return;

      if (DefaultMusicDuringBuildCheckbox.Checked)
      {
        OptionPage.DuringBuildMusic = MusicPlayer.DefaultFileName;
      }
      else
      {
        if (File.Exists(MusicDuringBuildTextbox.Text))
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
      SetDuringBuildControlsState(!DefaultMusicDuringBuildCheckbox.Checked);
      if (DefaultMusicDuringBuildCheckbox.Checked)
      {
        MusicDuringBuildTextbox.Text = string.Empty;
      }
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
        SetDuringBuildControlsState(!this.DefaultMusicDuringBuild);

      }
    }

    #endregion

  }
}
