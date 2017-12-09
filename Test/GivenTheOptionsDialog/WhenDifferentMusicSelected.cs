using Fritz.EpicBuildMusic.Core;
using Moq;
using NUnit.Framework;

namespace Test.GivenTheOptionsDialog
{

  [TestFixture]
  public class WhenDifferentMusicSelected
  {


    private MockRepository _Mockery;
    private Mock<IBuildMusicOptions> _FullBuildMusicOptions;
    private GeneralOptionsUserControl _Control;

    [SetUp]
    public void TestSetup()
    {

      _Mockery = new MockRepository(MockBehavior.Loose);
      _FullBuildMusicOptions = _Mockery.Create<IBuildMusicOptions>();
      _FullBuildMusicOptions.SetupProperty(o => o.DuringBuildMusic);
      _FullBuildMusicOptions.Object.DuringBuildMusic = "someOther.mp3";
      _Control = new GeneralOptionsUserControl();

    }

    [Test]
    public void ShouldClearCheckDefaultMusicCheckbox()
    {

      // arrange


      // act
      _Control.Initialize(_FullBuildMusicOptions.Object);

      // assert
      Assert.IsFalse(_Control.DefaultMusicDuringBuild, "Music was selected, but the DefaultMusicDuringBuild checkbox was checked");


    }

    [Test]
    public void ShouldSetDuringBuildMusicTextbox()
    {

      // arrange


      // act
      _Control.Initialize(_FullBuildMusicOptions.Object);

      // assert
      Assert.IsNotEmpty(_Control.OtherMusicDuringBuild, "Music was selected, but the DefaultMusicDuringBuild textbox had no content");


    }


  }


}
