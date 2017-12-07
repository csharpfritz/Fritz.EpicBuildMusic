using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows.Forms;
using Fritz.EpicBuildMusic.Core;

namespace Fritz.EpicBuildMusic
{
  /// <summary>
  /// This is the class that implements the package exposed by this assembly.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The minimum requirement for a class to be considered a valid package for Visual Studio
  /// is to implement the IVsPackage interface and register itself with the shell.
  /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
  /// to do it: it derives from the Package class that provides the implementation of the
  /// IVsPackage interface and uses the registration attributes defined in the framework to
  /// register itself and its components with the shell. These attributes tell the pkgdef creation
  /// utility what data to put into .pkgdef file.
  /// </para>
  /// <para>
  /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
  /// </para>
  /// </remarks>
  [PackageRegistration(UseManagedResourcesOnly = true)]
  [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
  [Guid(BuildMusicPackage.PackageGuidString)]
  [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
  [ProvideOptionPage(typeof(OptionPage), "Epic Build Music", "General", 0, 0, true)]
  [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
  public sealed class BuildMusicPackage : Package, IVsSolutionEvents, IVsUpdateSolutionEvents2
  {

    private IVsSolution2 solution;
    private IVsSolutionBuildManager2 sbm;
    private uint updateSolutionEventsCookie;
    private uint solutionEventsCookie;
    List<string> projects = new List<string>();

    /// <summary>
    /// BuildMusicPackage GUID string.
    /// </summary>
    public const string PackageGuidString = "661cc92b-55f5-447d-9d2c-d6abfb855180";

    /// <summary>
    /// Initializes a new instance of the <see cref="BuildMusicPackage"/> class.
    /// </summary>
    public BuildMusicPackage()
    {
      // Inside this method you can place any initialization code that does not require
      // any Visual Studio service because at this point the package object is created but
      // not sited yet inside Visual Studio environment. The place to do all the other
      // initialization is the Initialize method.
    }

    internal OptionPage Options
    {
      get
      {
        return (OptionPage)GetDialogPage(typeof(OptionPage));
      }
    }

    #region Package Members

    /// <summary>
    /// Initialization of the package; this method is called right after the package is sited, so this is the place
    /// where you can put all the initialization code that rely on services provided by VisualStudio.
    /// </summary>
    protected override void Initialize()
    {
      base.Initialize();

      // Get solution
      solution = ServiceProvider.GlobalProvider.GetService(typeof(SVsSolution)) as IVsSolution2;
      if (solution != null)
      {
        // Get count of any currently loaded projects
        object count;
        solution.GetProperty((int)__VSPROPID.VSPROPID_ProjectCount, out count);
        //totalProjects = (int)count;

        // Register for solution events
        solution.AdviseSolutionEvents(this, out solutionEventsCookie);
      }

      // Get solution build manager
      sbm = ServiceProvider.GlobalProvider.GetService(typeof(SVsSolutionBuildManager)) as IVsSolutionBuildManager2;
      if (sbm != null)
      {
        sbm.AdviseUpdateSolutionEvents(this, out updateSolutionEventsCookie);
      }

    }

    protected override void Dispose(bool disposing)
    {

      MusicPlayer.Instance.Dispose();

      base.Dispose(disposing);
    }

    public int OnAfterOpenProject(IVsHierarchy pHierarchy, int fAdded)
    {

      return VSConstants.S_OK;
    }

    public int OnQueryCloseProject(IVsHierarchy pHierarchy, int fRemoving, ref int pfCancel)
    {

      return VSConstants.S_OK;
    }

    public int OnBeforeCloseProject(IVsHierarchy pHierarchy, int fRemoved)
    {
      return VSConstants.S_OK;
    }

    public int OnAfterLoadProject(IVsHierarchy pStubHierarchy, IVsHierarchy pRealHierarchy)
    {

      return VSConstants.S_OK;
    }

    public int OnQueryUnloadProject(IVsHierarchy pRealHierarchy, ref int pfCancel)
    {
      return VSConstants.S_OK;
    }

    public int OnBeforeUnloadProject(IVsHierarchy pRealHierarchy, IVsHierarchy pStubHierarchy)
    {

      // Was trying to track projects here

      return VSConstants.S_OK;

    }

    public int OnAfterOpenSolution(object pUnkReserved, int fNewSolution)
    {
      return VSConstants.S_OK;
    }

    public int OnQueryCloseSolution(object pUnkReserved, ref int pfCancel)
    {
      return VSConstants.S_OK;
    }

    public int OnBeforeCloseSolution(object pUnkReserved)
    {
      return VSConstants.S_OK;
    }

    public int OnAfterCloseSolution(object pUnkReserved)
    {
      return VSConstants.S_OK;
    }

    public int UpdateSolution_Begin(ref int pfCancelUpdate)
    {

      MusicPlayer.Instance.Filename = Options.DuringBuildMusic;
      MusicPlayer.Instance.BeginPlaying();
      return VSConstants.S_OK;
    }

    public int UpdateSolution_Done(int fSucceeded, int fModified, int fCancelCommand)
    {

      MusicPlayer.Instance.StopPlaying();

      return VSConstants.S_OK;
    }

    public int UpdateSolution_StartUpdate(ref int pfCancelUpdate)
    {
      return VSConstants.S_OK;
    }

    public int UpdateSolution_Cancel()
    {
      // TODO: Investigate how we handle a cancelled build
      return VSConstants.S_OK;
    }

    public int OnActiveProjectCfgChange(IVsHierarchy pIVsHierarchy)
    {
      return VSConstants.S_OK;
    }

    public int UpdateProjectCfg_Begin(IVsHierarchy pHierProj, IVsCfg pCfgProj, IVsCfg pCfgSln, uint dwAction, ref int pfCancel)
    {

      return VSConstants.S_OK;

    }

    public int UpdateProjectCfg_Done(IVsHierarchy pHierProj, IVsCfg pCfgProj, IVsCfg pCfgSln, uint dwAction, int fSuccess, int fCancel)
    {

      return VSConstants.S_OK;

    }


    #endregion

  }

}
