using System.IO;

namespace Fritz.EpicBuildMusic.Core
{
  public interface IFileSystemHandler {

    bool FileExists(string file);

  }

  public class FileSystemHandler : IFileSystemHandler
  {
    public bool FileExists(string fileToCheck)
    {
      return File.Exists(fileToCheck);
    }
  }

}
