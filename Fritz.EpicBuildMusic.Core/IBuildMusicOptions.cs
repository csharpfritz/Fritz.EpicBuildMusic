using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fritz.EpicBuildMusic.Core
{
  public interface IBuildMusicOptions
  {

    /// <summary>
    /// The filename of the music to be played DURING a solution or project build
    /// </summary>
    string DuringBuildMusic { get; set; }

  }
}
