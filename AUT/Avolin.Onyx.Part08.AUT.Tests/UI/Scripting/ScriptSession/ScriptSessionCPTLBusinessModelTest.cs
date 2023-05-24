using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Onyx.UI.Scripting.ScriptSession;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.ScriptSession
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptSessionCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptSessionCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptSessionCPTLBusinessModel" />)
        /// </summary>
        public ScriptSessionCPTLBusinessModelTest() : base(typeof(ScriptSessionCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptSessionCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptSessionCPTLBusinessModelInstanceType;
        private ScriptSessionCPTLBusinessModel _scriptSessionCPTLBusinessModelInstance;
        private ScriptSessionCPTLBusinessModel _scriptSessionCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptSessionCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptSessionCPTLBusinessModelInstanceType = typeof(ScriptSessionCPTLBusinessModel);
            _scriptSessionCPTLBusinessModelInstanceFixture = this.Create<ScriptSessionCPTLBusinessModel>(false);
            _scriptSessionCPTLBusinessModelInstance = _scriptSessionCPTLBusinessModelInstanceFixture ?? this.Create<ScriptSessionCPTLBusinessModel>(true);
            CurrentInstance = _scriptSessionCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptSessionCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyObjectType = "ObjectType";
        private const string PropertyContent = "Content";
        private const string PropertyAction = "Action";
        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyScriptId = "ScriptId";
        private const string PropertyAssignedTo = "AssignedTo";
        private const string PropertyOwnerId = "OwnerId";
        private const string PropertyOwnerSecondaryId = "OwnerSecondaryId";
        private const string PropertyOwnerType = "OwnerType";
        private const string PropertyContactId = "ContactId";
        private const string PropertyContactObjectType = "ContactObjectType";
        private const string PropertyDuration = "Duration";
        private const string PropertyStatusId = "StatusId";
        private const string PropertySessionSteps = "SessionSteps";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptSessionCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptSessionCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptSessionCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptSessionCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptSessionCPTLBusinessModel)

        #region General Initializer : Class (ScriptSessionCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptSessionCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyContent)]
        [TestCase(PropertyAction)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyScriptId)]
        [TestCase(PropertyAssignedTo)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyOwnerSecondaryId)]
        [TestCase(PropertyOwnerType)]
        [TestCase(PropertyContactId)]
        [TestCase(PropertyContactObjectType)]
        [TestCase(PropertyDuration)]
        [TestCase(PropertyStatusId)]
        [TestCase(PropertySessionSteps)]
        [Category("AUT Property")]
        public void AUT_ScriptSessionCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptSessionCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptSessionCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptSessionCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptSessionCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptSessionCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptSessionCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptSessionCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptSessionCPTLBusinessModel>();
            _scriptSessionCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptSessionCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptSessionCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptSessionCPTLBusinessModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionCPTLBusinessModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptSessionCPTLBusinessModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionCPTLBusinessModel_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptSessionCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptSessionCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptSessionCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptSessionCPTLBusinessModel>();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionCPTLBusinessModel_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptSessionCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptSessionCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptSessionCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionCPTLBusinessModel) instance created

        /// <summary>
        ///     Class (<see cref="ScriptSessionCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionCPTLBusinessModel_Is_Created_Test()
        {
            // Assert
            _scriptSessionCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionCPTLBusinessModel) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ScriptSessionCPTLBusinessModel" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ScriptSessionCPTLBusinessModel_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (ScriptSessionCPTLBusinessModel) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ScriptSessionCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionCPTLBusinessModel_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionCPTLBusinessModel) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptSessionCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionCPTLBusinessModel_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodScriptSessionCPTLBusinessModelParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptSessionCPTLBusinessModelParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionCPTLBusinessModel) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptSessionCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionCPTLBusinessModel_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptSessionCPTLBusinessModelParametersTypes = new Type[] { typeof(JObject) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptSessionCPTLBusinessModelParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyContent)]
        [TestCase(PropertyAction)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyScriptId)]
        [TestCase(PropertyAssignedTo)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyOwnerSecondaryId)]
        [TestCase(PropertyOwnerType)]
        [TestCase(PropertyContactId)]
        [TestCase(PropertyContactObjectType)]
        [TestCase(PropertyDuration)]
        [TestCase(PropertyStatusId)]
        [TestCase(PropertySessionSteps)]
        public void AUT_ScriptSessionCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (Action) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_Action_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAction);
            var propertyInfo = this.GetPropertyInfo(PropertyAction);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (AssignedTo) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_AssignedTo_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAssignedTo);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAssignedTo);
            Action currentAction = () => propertyInfo.SetValue(_scriptSessionCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (AssignedTo) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_AssignedTo_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAssignedTo);
            var propertyInfo = this.GetPropertyInfo(PropertyAssignedTo);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (ContactId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_ContactId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContactId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyContactId);
            Action currentAction = () => propertyInfo.SetValue(_scriptSessionCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (ContactId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_ContactId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContactId);
            var propertyInfo = this.GetPropertyInfo(PropertyContactId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (ContactObjectType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_ContactObjectType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContactObjectType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyContactObjectType);
            Action currentAction = () => propertyInfo.SetValue(_scriptSessionCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (ContactObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_ContactObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContactObjectType);
            var propertyInfo = this.GetPropertyInfo(PropertyContactObjectType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (Content) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_Content_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContent);
            var propertyInfo = this.GetPropertyInfo(PropertyContent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (Duration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_Duration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDuration);
            var propertyInfo = this.GetPropertyInfo(PropertyDuration);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (OwnerId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_OwnerId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerId);
            Action currentAction = () => propertyInfo.SetValue(_scriptSessionCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (OwnerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_OwnerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerId);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (OwnerSecondaryId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_OwnerSecondaryId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerSecondaryId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerSecondaryId);
            Action currentAction = () => propertyInfo.SetValue(_scriptSessionCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (OwnerSecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_OwnerSecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerSecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerSecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (OwnerType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_OwnerType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerType);
            Action currentAction = () => propertyInfo.SetValue(_scriptSessionCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (OwnerType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_OwnerType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerType);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (ScriptId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_ScriptId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyScriptId);
            var propertyInfo = this.GetPropertyInfo(PropertyScriptId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (SessionSteps) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_SessionSteps_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionSteps);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySessionSteps);
            Action currentAction = () => propertyInfo.SetValue(_scriptSessionCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (SessionSteps) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_SessionSteps_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionSteps);
            var propertyInfo = this.GetPropertyInfo(PropertySessionSteps);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionCPTLBusinessModel) => Property (StatusId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionCPTLBusinessModel_Public_Class_StatusId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatusId);
            var propertyInfo = this.GetPropertyInfo(PropertyStatusId);

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