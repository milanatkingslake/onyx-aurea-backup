using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxQASIntegration.PartnerPlatform;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxQASIntegration.PartnerPlatform
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.ValidateResponse" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ValidateResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ValidateResponse" />)
        /// </summary>
        public ValidateResponseTest() : base(typeof(ValidateResponse))
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

        #region General Initializer : Class (ValidateResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _validateResponseInstanceType;
        private ValidateResponse _validateResponseInstance;
        private ValidateResponse _validateResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ValidateResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _validateResponseInstanceType = typeof(ValidateResponse);
            _validateResponseInstanceFixture = this.Create<ValidateResponse>(false);
            _validateResponseInstance = _validateResponseInstanceFixture ?? this.Create<ValidateResponse>(true);
            CurrentInstance = _validateResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ValidateResponse) Initializer

        #region Properties

        private const string PropertyExtensionData = "ExtensionData";
        private const string PropertyFields = "Fields";
        private const string PropertyValidated = "Validated";

        #endregion

        #region Methods

        private const string MethodRaisePropertyChanged = "RaisePropertyChanged";

        #endregion

        #region Fields

        private const string FieldextensionDataField = "extensionDataField";
        private const string FieldFieldsField = "FieldsField";
        private const string FieldValidatedField = "ValidatedField";

        #endregion

        #endregion

        #region General Initializer : Class (ValidateResponse) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ValidateResponse" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ValidateResponse_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ValidateResponse) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ValidateResponse" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ValidateResponse_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ValidateResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ValidateResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ValidateResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ValidateResponse)

        #region General Initializer : Class (ValidateResponse) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ValidateResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRaisePropertyChanged, 0)]
        public void AUT_ValidateResponse_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (ValidateResponse) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ValidateResponse" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyExtensionData)]
        [TestCase(PropertyFields)]
        [TestCase(PropertyValidated)]
        [Category("AUT Property")]
        public void AUT_ValidateResponse_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ValidateResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ValidateResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldextensionDataField)]
        [TestCase(FieldFieldsField)]
        [TestCase(FieldValidatedField)]
        [Category("AUT Fields")]
        public void AUT_ValidateResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ValidateResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ValidateResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ValidateResponse_Is_Instance_Present_Test()
        {
            // Assert
            _validateResponseInstanceType.ShouldNotBeNull();
            _validateResponseInstance.ShouldNotBeNull();
            _validateResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ValidateResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ValidateResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ValidateResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _validateResponseInstance.ShouldBeAssignableTo<ValidateResponse>();
            _validateResponseInstanceFixture.ShouldBeAssignableTo<ValidateResponse>();
            CurrentInstance.ShouldBeAssignableTo<ValidateResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ValidateResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ValidateResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ValidateResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ValidateResponse) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyExtensionData)]
        [TestCase(PropertyFields)]
        [TestCase(PropertyValidated)]
        public void AUT_ValidateResponse_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ValidateResponse) => Property (ExtensionData) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ValidateResponse_ExtensionData_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtensionData);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyExtensionData);
            Action currentAction = () => propertyInfo.SetValue(_validateResponseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ValidateResponse) => Property (ExtensionData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ValidateResponse_Public_Class_ExtensionData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtensionData);
            var propertyInfo = this.GetPropertyInfo(PropertyExtensionData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ValidateResponse) => Property (Fields) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ValidateResponse_Fields_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFields);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFields);
            Action currentAction = () => propertyInfo.SetValue(_validateResponseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ValidateResponse) => Property (Fields) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ValidateResponse_Public_Class_Fields_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFields);
            var propertyInfo = this.GetPropertyInfo(PropertyFields);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ValidateResponse) => Property (Validated) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ValidateResponse_Public_Class_Validated_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValidated);
            var propertyInfo = this.GetPropertyInfo(PropertyValidated);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (RaisePropertyChanged) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ValidateResponse_RaisePropertyChanged_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var propertyName = this.CreateType<string>();
            var methodRaisePropertyChangedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRaisePropertyChanged = { propertyName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRaisePropertyChanged, methodRaisePropertyChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_validateResponseInstanceFixture, parametersOfRaisePropertyChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRaisePropertyChanged.ShouldNotBeNull();
            parametersOfRaisePropertyChanged.Length.ShouldBe(1);
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(1);
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(parametersOfRaisePropertyChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RaisePropertyChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ValidateResponse_RaisePropertyChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var propertyName = this.CreateType<string>();
            var methodRaisePropertyChangedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRaisePropertyChanged = { propertyName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRaisePropertyChanged, parametersOfRaisePropertyChanged, methodRaisePropertyChangedParametersTypes);

            // Assert
            parametersOfRaisePropertyChanged.ShouldNotBeNull();
            parametersOfRaisePropertyChanged.Length.ShouldBe(1);
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(1);
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(parametersOfRaisePropertyChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RaisePropertyChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ValidateResponse_RaisePropertyChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodRaisePropertyChanged, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RaisePropertyChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ValidateResponse_RaisePropertyChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var methodRaisePropertyChangedParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRaisePropertyChanged, methodRaisePropertyChangedParametersTypes);

            // Assert
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RaisePropertyChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ValidateResponse_RaisePropertyChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodRaisePropertyChanged, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}