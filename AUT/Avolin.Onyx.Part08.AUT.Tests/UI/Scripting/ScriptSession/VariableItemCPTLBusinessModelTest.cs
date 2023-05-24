using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.ScriptSession;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.ScriptSession
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.VariableItemCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class VariableItemCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="VariableItemCPTLBusinessModel" />)
        /// </summary>
        public VariableItemCPTLBusinessModelTest() : base(typeof(VariableItemCPTLBusinessModel))
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

        #region General Initializer : Class (VariableItemCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _variableItemCPTLBusinessModelInstanceType;
        private VariableItemCPTLBusinessModel _variableItemCPTLBusinessModelInstance;
        private VariableItemCPTLBusinessModel _variableItemCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="VariableItemCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _variableItemCPTLBusinessModelInstanceType = typeof(VariableItemCPTLBusinessModel);
            _variableItemCPTLBusinessModelInstanceFixture = this.Create<VariableItemCPTLBusinessModel>(false);
            _variableItemCPTLBusinessModelInstance = _variableItemCPTLBusinessModelInstanceFixture ?? this.Create<VariableItemCPTLBusinessModel>(true);
            CurrentInstance = _variableItemCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (VariableItemCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyText = "Text";
        private const string PropertyCode = "Code";

        #endregion

        #endregion

        #region General Initializer : Class (VariableItemCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="VariableItemCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_VariableItemCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (VariableItemCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="VariableItemCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_VariableItemCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (VariableItemCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="VariableItemCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_VariableItemCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (VariableItemCPTLBusinessModel)

        #region General Initializer : Class (VariableItemCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="VariableItemCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyText)]
        [TestCase(PropertyCode)]
        [Category("AUT Property")]
        public void AUT_VariableItemCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (VariableItemCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="VariableItemCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_VariableItemCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _variableItemCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _variableItemCPTLBusinessModelInstance.ShouldNotBeNull();
            _variableItemCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (VariableItemCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="VariableItemCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_VariableItemCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _variableItemCPTLBusinessModelInstance.ShouldBeAssignableTo<VariableItemCPTLBusinessModel>();
            _variableItemCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<VariableItemCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<VariableItemCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (VariableItemCPTLBusinessModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_VariableItemCPTLBusinessModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            VariableItemCPTLBusinessModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (VariableItemCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyText)]
        [TestCase(PropertyCode)]
        public void AUT_VariableItemCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (VariableItemCPTLBusinessModel) => Property (Code) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_VariableItemCPTLBusinessModel_Public_Class_Code_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCode);
            var propertyInfo = this.GetPropertyInfo(PropertyCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (VariableItemCPTLBusinessModel) => Property (Text) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_VariableItemCPTLBusinessModel_Public_Class_Text_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyText);
            var propertyInfo = this.GetPropertyInfo(PropertyText);

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