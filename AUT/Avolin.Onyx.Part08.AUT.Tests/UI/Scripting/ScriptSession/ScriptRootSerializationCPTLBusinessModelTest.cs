using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.ScriptSession;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.ScriptSession
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptRootSerializationCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptRootSerializationCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptRootSerializationCPTLBusinessModel" />)
        /// </summary>
        public ScriptRootSerializationCPTLBusinessModelTest() : base(typeof(ScriptRootSerializationCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptRootSerializationCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptRootSerializationCPTLBusinessModelInstanceType;
        private ScriptRootSerializationCPTLBusinessModel _scriptRootSerializationCPTLBusinessModelInstance;
        private ScriptRootSerializationCPTLBusinessModel _scriptRootSerializationCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptRootSerializationCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptRootSerializationCPTLBusinessModelInstanceType = typeof(ScriptRootSerializationCPTLBusinessModel);
            _scriptRootSerializationCPTLBusinessModelInstanceFixture = this.Create<ScriptRootSerializationCPTLBusinessModel>(false);
            _scriptRootSerializationCPTLBusinessModelInstance = _scriptRootSerializationCPTLBusinessModelInstanceFixture ?? this.Create<ScriptRootSerializationCPTLBusinessModel>(true);
            CurrentInstance = _scriptRootSerializationCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptRootSerializationCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyScriptRootCPTLBusinessModel = "ScriptRootCPTLBusinessModel";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptRootSerializationCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptRootSerializationCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptRootSerializationCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptRootSerializationCPTLBusinessModel)

        #region General Initializer : Class (ScriptRootSerializationCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyScriptRootCPTLBusinessModel)]
        [Category("AUT Property")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptRootSerializationCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptRootSerializationCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptRootSerializationCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptRootSerializationCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptRootSerializationCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptRootSerializationCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptRootSerializationCPTLBusinessModel>();
            _scriptRootSerializationCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptRootSerializationCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptRootSerializationCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptRootSerializationCPTLBusinessModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var scriptRootCPTLBusinessModel = this.CreateType<ScriptRootCPTLBusinessModel>();
            ScriptRootSerializationCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptRootSerializationCPTLBusinessModel(scriptRootCPTLBusinessModel);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptRootSerializationCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptRootSerializationCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptRootSerializationCPTLBusinessModel>();
        }

        #endregion

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var scriptRootCPTLBusinessModel = this.CreateType<ScriptRootCPTLBusinessModel>();
            ScriptRootSerializationCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptRootSerializationCPTLBusinessModel(scriptRootCPTLBusinessModel);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptRootSerializationCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptRootSerializationCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) instance created

        /// <summary>
        ///     Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Is_Created_Test()
        {
            // Assert
            _scriptRootSerializationCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptRootSerializationCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodScriptRootSerializationCPTLBusinessModelParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptRootSerializationCPTLBusinessModelParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptRootSerializationCPTLBusinessModelParametersTypes = new Type[] { typeof(ScriptRootCPTLBusinessModel) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptRootSerializationCPTLBusinessModelParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ScriptRootSerializationCPTLBusinessModel) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptRootSerializationCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptRootSerializationCPTLBusinessModelParametersTypes = new Type[] { typeof(string), typeof(string), typeof(VariablesCPTLBusinessModel) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptRootSerializationCPTLBusinessModelParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptRootSerializationCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyScriptRootCPTLBusinessModel)]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptRootSerializationCPTLBusinessModel) => Property (ScriptRootCPTLBusinessModel) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_ScriptRootCPTLBusinessModel_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyScriptRootCPTLBusinessModel);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyScriptRootCPTLBusinessModel);
            Action currentAction = () => propertyInfo.SetValue(_scriptRootSerializationCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptRootSerializationCPTLBusinessModel) => Property (ScriptRootCPTLBusinessModel) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptRootSerializationCPTLBusinessModel_Public_Class_ScriptRootCPTLBusinessModel_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyScriptRootCPTLBusinessModel);
            var propertyInfo = this.GetPropertyInfo(PropertyScriptRootCPTLBusinessModel);

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