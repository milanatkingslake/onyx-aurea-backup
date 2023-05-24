using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Group" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ModelClasses.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GroupTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Group" />)
        /// </summary>
        public GroupTest() : base(typeof(Group))
        { }

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

        #region General Initializer : Class (Group) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _groupInstanceType;
        private Group _groupInstance;
        private Group _groupInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Group" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _groupInstanceType = typeof(Group);
            _groupInstanceFixture = this.Create<Group>(false);
            _groupInstance = _groupInstanceFixture ?? this.Create<Group>(true);
            CurrentInstance = _groupInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Group) Initializer

        #region Fields

        private const string FieldRow = "Row";

        #endregion

        #endregion

        #region General Initializer : Class (Group) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Group" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Group_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Group)

        #region General Initializer : Class (Group) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Group" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldRow)]
        [Category("AUT Fields")]
        public void AUT_Group_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Group) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Group" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Group_Is_Instance_Present_Test()
        {
            // Assert
            _groupInstanceType.ShouldNotBeNull();
            _groupInstance.ShouldNotBeNull();
            _groupInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Group) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Group" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Group_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _groupInstance.ShouldBeAssignableTo<Group>();
            _groupInstanceFixture.ShouldBeAssignableTo<Group>();
            CurrentInstance.ShouldBeAssignableTo<Group>();
        }

        #endregion

        #region General Constructor : Class (Group) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Group_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Group instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

    }
}