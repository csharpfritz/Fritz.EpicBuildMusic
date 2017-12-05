using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell;

namespace Fritz.EpicBuildMusic
{
  [Guid("D5433C78-D167-4C12-B5ED-179B5E3BB23C")]
  public class OptionPage : DialogPage
  {

    public string DuringBuildMusic { get; set; } = "build_over_dialup.mp3";

    protected override IWin32Window Window
    {
      get
      {
        var page = new GeneralOptionsUserControl();
        page.OptionPage = this;
        page.Initialize();
        return page;
      }
    }

  }

}
