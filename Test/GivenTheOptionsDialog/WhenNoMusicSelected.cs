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
  public class WhenNoMusicSelected
  {
    private MockRepository _Mockery;
    private Mock<IBuildMusicOptions> _EmptyBuildMusicOptions;
    private GeneralOptionsUserControl _Control;

    [SetUp]
    public void TestSetup() {

      _Mockery = new MockRepository(MockBehavior.Loose);
      _EmptyBuildMusicOptions = _Mockery.Create<IBuildMusicOptions>();
      _Control = new GeneralOptionsUserControl();

    }

    [Test]
    public void ShouldCheckDefaultMusicCheckbox()
    {

      // arrange


      // act
      _Control.Initialize(_EmptyBuildMusicOptions.Object);

      // assert
      Assert.IsTrue(_Control.DefaultMusicDuringBuild, "No music was selected, but the DefaultMusicDuringBuild checkbox was not checked");


    }

    [Test]
    public void ShouldEmptyDefaultMusicTextbox()
    {

      // arrange


      // act
      _Control.Initialize(_EmptyBuildMusicOptions.Object);

      // assert
      Assert.IsEmpty(_Control.OtherMusicDuringBuild, "No music was selected, but the DefaultMusicDuringBuild textbox had content");


    }
  }


}
