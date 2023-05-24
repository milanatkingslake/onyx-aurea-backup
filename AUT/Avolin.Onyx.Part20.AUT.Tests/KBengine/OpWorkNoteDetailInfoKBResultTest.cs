using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using KBengine;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.KBengine
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.opWorkNoteDetailInfoKB_Result" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OpWorkNoteDetailInfoKBResultTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="opWorkNoteDetailInfoKB_Result" />)
        /// </summary>
        public OpWorkNoteDetailInfoKBResultTest() : base(typeof(opWorkNoteDetailInfoKB_Result))
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

        #region General Initializer : Class (opWorkNoteDetailInfoKB_Result) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _opWorkNoteDetailInfoKBResultInstanceType;
        private opWorkNoteDetailInfoKB_Result _opWorkNoteDetailInfoKBResultInstance;
        private opWorkNoteDetailInfoKB_Result _opWorkNoteDetailInfoKBResultInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="opWorkNoteDetailInfoKB_Result" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _opWorkNoteDetailInfoKBResultInstanceType = typeof(opWorkNoteDetailInfoKB_Result);
            _opWorkNoteDetailInfoKBResultInstanceFixture = this.Create<opWorkNoteDetailInfoKB_Result>(false);
            _opWorkNoteDetailInfoKBResultInstance = _opWorkNoteDetailInfoKBResultInstanceFixture ?? this.Create<opWorkNoteDetailInfoKB_Result>(true);
            CurrentInstance = _opWorkNoteDetailInfoKBResultInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (opWorkNoteDetailInfoKB_Result) Initializer

        #region Properties

        private const string PropertyvchInsertBy = "vchInsertBy";
        private const string PropertydtInsertDate = "dtInsertDate";
        private const string PropertyiPublishBitmask = "iPublishBitmask";

        #endregion

        #endregion

        #region General Initializer : Class (opWorkNoteDetailInfoKB_Result) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailInfoKB_Result" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (opWorkNoteDetailInfoKB_Result) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailInfoKB_Result" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (opWorkNoteDetailInfoKB_Result) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailInfoKB_Result" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (opWorkNoteDetailInfoKB_Result)

        #region General Initializer : Class (opWorkNoteDetailInfoKB_Result) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailInfoKB_Result" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyvchInsertBy)]
        [TestCase(PropertydtInsertDate)]
        [TestCase(PropertyiPublishBitmask)]
        [Category("AUT Property")]
        public void AUT_OpWorkNoteDetailInfoKBResult_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (opWorkNoteDetailInfoKB_Result) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailInfoKB_Result" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Is_Instance_Present_Test()
        {
            // Assert
            _opWorkNoteDetailInfoKBResultInstanceType.ShouldNotBeNull();
            _opWorkNoteDetailInfoKBResultInstance.ShouldNotBeNull();
            _opWorkNoteDetailInfoKBResultInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (opWorkNoteDetailInfoKB_Result) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailInfoKB_Result" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _opWorkNoteDetailInfoKBResultInstance.ShouldBeAssignableTo<opWorkNoteDetailInfoKB_Result>();
            _opWorkNoteDetailInfoKBResultInstanceFixture.ShouldBeAssignableTo<opWorkNoteDetailInfoKB_Result>();
            CurrentInstance.ShouldBeAssignableTo<opWorkNoteDetailInfoKB_Result>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (opWorkNoteDetailInfoKB_Result) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            opWorkNoteDetailInfoKB_Result instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (opWorkNoteDetailInfoKB_Result) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyvchInsertBy)]
        [TestCase(PropertydtInsertDate)]
        [TestCase(PropertyiPublishBitmask)]
        public void AUT_OpWorkNoteDetailInfoKBResult_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkNoteDetailInfoKB_Result) => Property (dtInsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkNoteDetailInfoKBResult_dtInsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydtInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertydtInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_opWorkNoteDetailInfoKBResultInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (opWorkNoteDetailInfoKB_Result) => Property (dtInsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Public_Class_dtInsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydtInsertDate);
            var propertyInfo = this.GetPropertyInfo(PropertydtInsertDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkNoteDetailInfoKB_Result) => Property (iPublishBitmask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Public_Class_iPublishBitmask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyiPublishBitmask);
            var propertyInfo = this.GetPropertyInfo(PropertyiPublishBitmask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkNoteDetailInfoKB_Result) => Property (vchInsertBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkNoteDetailInfoKBResult_Public_Class_vchInsertBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyvchInsertBy);
            var propertyInfo = this.GetPropertyInfo(PropertyvchInsertBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}