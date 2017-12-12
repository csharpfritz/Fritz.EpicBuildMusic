using Fritz.EpicBuildMusic.Core;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.GivenTheOptionsDialog
{

  [TestFixture]
  public class WhenDefaultDuringBuildMusicSelected
  {

    private MockRepository _Mockery;
    private Mock<IBuildMusicOptions> _BuildMusicOptions;
    private GeneralOptionsUserControl _Control;

    [SetUp]
    public void TestSetup()
    {

      _Mockery = new MockRepository(MockBehavior.Loose);
      _BuildMusicOptions = _Mockery.Create<IBuildMusicOptions>();
      _BuildMusicOptions.SetupAllProperties();
      _BuildMusicOptions.Object.DuringBuildMusic = "somethingAlreadySet.mp3";
      _Control = new GeneralOptionsUserControl();

    }

    [Test]
    public void ThenShouldClearOtherDuringBuildMusic() {

      // arrange
      _Control.Initialize(_BuildMusicOptions.Object);
      _Control.DefaultMusicDuringBuild = true;

      // act
      _Control.PersistDuringMusicSelection();

      // assert
      Assert.AreEqual(MusicPlayer.DefaultFileName, _BuildMusicOptions.Object.DuringBuildMusic, "Did not clear out the during build music setting");


    }

  }

}
