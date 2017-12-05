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

namespace Fritz.EpicBuildMusic
{
  public partial class GeneralOptionsUserControl : UserControl
  {

    internal OptionPage OptionPage { get; set; }

    public GeneralOptionsUserControl()
    {
      InitializeComponent();
    }

    public void Initialize()
    {

      SetDuringBuildDefaultCheckbox();

    }

    private void SetDuringBuildDefaultCheckbox()
    {

      DefaultMusicDuringBuildCheckbox.Checked = (OptionPage.DuringBuildMusic == MusicPlayer.DefaultFileName);
      SetDuringBuildControlsState(!DefaultMusicDuringBuildCheckbox.Checked);

    }

    private void SetDuringBuildControlsState(bool state) {
      MusicDuringBuildTextbox.Enabled = state;
      MusicDuringBuildOpenButton.Enabled = state;
    }

    private void GeneralOptionsUserControl_Leave(object sender, EventArgs e)
    {

      if (DefaultMusicDuringBuildCheckbox.Checked)
      {
        OptionPage.DuringBuildMusic = MusicPlayer.DefaultFileName;
      } else {
        if (File.Exists(MusicDuringBuildTextbox.Text))
        {
          OptionPage.DuringBuildMusic = MusicDuringBuildTextbox.Text;
        } else {
          MessageBox.Show($"During Build Music file {MusicDuringBuildTextbox.Text} does not exist.\n\nValue will not be used");
        }
      }
    }

    private void DefaultMusicDuringBuildCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      SetDuringBuildControlsState(!DefaultMusicDuringBuildCheckbox.Checked);
    }

    private void MusicDuringBuildOpenButton_Click(object sender, EventArgs e)
    {
      fileDialog.Title = "Choose a file to play during build";
      var result = fileDialog.ShowDialog();
      fileDialog.FileOk += FileDialog_FileOk;
    }

    private void FileDialog_FileOk(object sender, CancelEventArgs e)
    {

      if (!e.Cancel)
      {
        MusicDuringBuildTextbox.Text = fileDialog.FileName;
      }
      fileDialog.FileOk -= FileDialog_FileOk;

    }
  }
}
