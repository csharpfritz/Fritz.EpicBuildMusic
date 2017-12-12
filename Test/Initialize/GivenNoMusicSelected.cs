using Fritz.EpicBuildMusic.Core;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Initialize
{

  [TestFixture]
  public class GivenNoMusicSelected
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

  }


}
