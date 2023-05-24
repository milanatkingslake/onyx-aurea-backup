using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.IntDomainData" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IntDomainDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IntDomainData" />)
        /// </summary>
        public IntDomainDataTest() : base(typeof(IntDomainData))
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

        #region General Initializer : Class (IntDomainData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _intDomainDataInstanceType;
        private IntDomainData _intDomainDataInstance;
        private IntDomainData _intDomainDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IntDomainData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _intDomainDataInstanceType = typeof(IntDomainData);
            _intDomainDataInstanceFixture = this.Create<IntDomainData>(false);
            _intDomainDataInstance = _intDomainDataInstanceFixture ?? this.Create<IntDomainData>(true);
            CurrentInstance = _intDomainDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IntDomainData) Initializer

        #region Fields

        private const string FieldId = "Id";
        private const string FieldDescription = "Description";

        #endregion

        #endregion

        #region General Initializer : Class (IntDomainData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="IntDomainData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IntDomainData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (IntDomainData)

        #region General Initializer : Class (IntDomainData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="IntDomainData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldId)]
        [TestCase(FieldDescription)]
        [Category("AUT Fields")]
        public void AUT_IntDomainData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (IntDomainData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IntDomainData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IntDomainData_Is_Instance_Present_Test()
        {
            // Assert
            _intDomainDataInstanceType.ShouldNotBeNull();
            _intDomainDataInstance.ShouldNotBeNull();
            _intDomainDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IntDomainData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IntDomainData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IntDomainData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _intDomainDataInstance.ShouldBeAssignableTo<IntDomainData>();
            _intDomainDataInstanceFixture.ShouldBeAssignableTo<IntDomainData>();
            CurrentInstance.ShouldBeAssignableTo<IntDomainData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (IntDomainData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IntDomainData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            IntDomainData instance = null;

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