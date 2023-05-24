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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.opWorkNoteDetailKB_Result" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OpWorkNoteDetailKBResultTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="opWorkNoteDetailKB_Result" />)
        /// </summary>
        public OpWorkNoteDetailKBResultTest() : base(typeof(opWorkNoteDetailKB_Result))
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

        #region General Initializer : Class (opWorkNoteDetailKB_Result) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _opWorkNoteDetailKBResultInstanceType;
        private opWorkNoteDetailKB_Result _opWorkNoteDetailKBResultInstance;
        private opWorkNoteDetailKB_Result _opWorkNoteDetailKBResultInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="opWorkNoteDetailKB_Result" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _opWorkNoteDetailKBResultInstanceType = typeof(opWorkNoteDetailKB_Result);
            _opWorkNoteDetailKBResultInstanceFixture = this.Create<opWorkNoteDetailKB_Result>(false);
            _opWorkNoteDetailKBResultInstance = _opWorkNoteDetailKBResultInstanceFixture ?? this.Create<opWorkNoteDetailKB_Result>(true);
            CurrentInstance = _opWorkNoteDetailKBResultInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (opWorkNoteDetailKB_Result) Initializer

        #region Properties

        private const string Propertyilogmark = "ilogmark";
        private const string Propertyisequencenumber = "isequencenumber";
        private const string Propertyuworknotedetailid = "uworknotedetailid";

        #endregion

        #endregion

        #region General Initializer : Class (opWorkNoteDetailKB_Result) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailKB_Result" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkNoteDetailKBResult_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (opWorkNoteDetailKB_Result) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailKB_Result" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkNoteDetailKBResult_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (opWorkNoteDetailKB_Result) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailKB_Result" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkNoteDetailKBResult_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (opWorkNoteDetailKB_Result)

        #region General Initializer : Class (opWorkNoteDetailKB_Result) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailKB_Result" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyilogmark)]
        [TestCase(Propertyisequencenumber)]
        [TestCase(Propertyuworknotedetailid)]
        [Category("AUT Property")]
        public void AUT_OpWorkNoteDetailKBResult_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (opWorkNoteDetailKB_Result) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailKB_Result" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OpWorkNoteDetailKBResult_Is_Instance_Present_Test()
        {
            // Assert
            _opWorkNoteDetailKBResultInstanceType.ShouldNotBeNull();
            _opWorkNoteDetailKBResultInstance.ShouldNotBeNull();
            _opWorkNoteDetailKBResultInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (opWorkNoteDetailKB_Result) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="opWorkNoteDetailKB_Result" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OpWorkNoteDetailKBResult_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _opWorkNoteDetailKBResultInstance.ShouldBeAssignableTo<opWorkNoteDetailKB_Result>();
            _opWorkNoteDetailKBResultInstanceFixture.ShouldBeAssignableTo<opWorkNoteDetailKB_Result>();
            CurrentInstance.ShouldBeAssignableTo<opWorkNoteDetailKB_Result>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (opWorkNoteDetailKB_Result) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OpWorkNoteDetailKBResult_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            opWorkNoteDetailKB_Result instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (opWorkNoteDetailKB_Result) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyilogmark)]
        [TestCase(Propertyisequencenumber)]
        [TestCase(Propertyuworknotedetailid)]
        public void AUT_OpWorkNoteDetailKBResult_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (opWorkNoteDetailKB_Result) => Property (ilogmark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkNoteDetailKBResult_Public_Class_ilogmark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyilogmark);
            var propertyInfo = this.GetPropertyInfo(Propertyilogmark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkNoteDetailKB_Result) => Property (isequencenumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkNoteDetailKBResult_Public_Class_isequencenumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyisequencenumber);
            var propertyInfo = this.GetPropertyInfo(Propertyisequencenumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkNoteDetailKB_Result) => Property (uworknotedetailid) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkNoteDetailKBResult_uworknotedetailid_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyuworknotedetailid);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyuworknotedetailid);
            Action currentAction = () => propertyInfo.SetValue(_opWorkNoteDetailKBResultInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (opWorkNoteDetailKB_Result) => Property (uworknotedetailid) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkNoteDetailKBResult_Public_Class_uworknotedetailid_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyuworknotedetailid);
            var propertyInfo = this.GetPropertyInfo(Propertyuworknotedetailid);

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