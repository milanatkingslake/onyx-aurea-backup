using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.Global" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GlobalTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Global" />)
        /// </summary>
        public GlobalTest() : base(typeof(Global))
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Global) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _globalInstanceType;
        private Global _globalInstance;
        private Global _globalInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Global" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _globalInstanceType = typeof(Global);
            _globalInstanceFixture = this.Create<Global>(false);
            _globalInstance = _globalInstanceFixture ?? this.Create<Global>(true);
            CurrentInstance = _globalInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Global) Initializer

        #region Fields

        private const string FieldCommonType = "CommonType";

        #endregion

        #endregion

        #region General Initializer : Class (Global) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Global" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Global_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Global)

        #region General Initializer : Class (Global) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Global" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldCommonType)]
        [Category("AUT Fields")]
        public void AUT_Global_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (Global) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Global" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Global_Is_Instance_Present_Test()
        {
            // Assert
            _globalInstanceType.ShouldNotBeNull();
            _globalInstance.ShouldNotBeNull();
            _globalInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Global) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Global" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Global_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _globalInstance.ShouldBeAssignableTo<Global>();
            _globalInstanceFixture.ShouldBeAssignableTo<Global>();
            CurrentInstance.ShouldBeAssignableTo<Global>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Global) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Global_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Global instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}