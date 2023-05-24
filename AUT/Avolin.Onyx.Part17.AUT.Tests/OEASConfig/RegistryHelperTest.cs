using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OEASConfig;
using Shouldly;

namespace Avolin.Onyx.Part17.AUT.Tests.OEASConfig
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OEASConfig.RegistryHelper" />)
    ///     and namespace <see cref="OEASConfig"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RegistryHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RegistryHelper" />)
        /// </summary>
        public RegistryHelperTest() : base(typeof(RegistryHelper))
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

        #region General Initializer : Class (RegistryHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _registryHelperInstanceType;
        private RegistryHelper _registryHelperInstance;
        private RegistryHelper _registryHelperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="RegistryHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _registryHelperInstanceType = typeof(RegistryHelper);
            _registryHelperInstanceFixture = this.Create<RegistryHelper>(false);
            _registryHelperInstance = _registryHelperInstanceFixture ?? this.Create<RegistryHelper>(true);
            CurrentInstance = _registryHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RegistryHelper) Initializer

        #region Properties

        private const string PropertyShowError = "ShowError";
        private const string PropertySubKey = "SubKey";
        private const string PropertySubKeyApplication = "SubKeyApplication";
        private const string PropertyBaseRegistryKey = "BaseRegistryKey";

        #endregion

        #region Methods

        private const string MethodRead = "Read";
        private const string MethodGetSubKeyValueNames = "GetSubKeyValueNames";
        private const string MethodWrite = "Write";
        private const string MethodDeleteKey = "DeleteKey";
        private const string MethodShowErrorMessage = "ShowErrorMessage";
        private const string MethodSetEmailProperty = "SetEmailProperty";

        #endregion

        #region Fields

        private const string FieldshowError = "showError";
        private const string FieldsubKey = "subKey";
        private const string FieldbaseRegistryKey = "baseRegistryKey";

        #endregion

        #endregion

        #region General Initializer : Class (RegistryHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RegistryHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegistryHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RegistryHelper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RegistryHelper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegistryHelper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RegistryHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RegistryHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegistryHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RegistryHelper)
        
        #region General Initializer : Class (RegistryHelper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="RegistryHelper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyShowError)]
        [TestCase(PropertySubKey)]
        [TestCase(PropertySubKeyApplication)]
        [TestCase(PropertyBaseRegistryKey)]
        [Category("AUT Property")]
        public void AUT_RegistryHelper_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (RegistryHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="RegistryHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldshowError)]
        [TestCase(FieldsubKey)]
        [TestCase(FieldbaseRegistryKey)]
        [Category("AUT Fields")]
        public void AUT_RegistryHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RegistryHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RegistryHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RegistryHelper_Is_Instance_Present_Test()
        {
            // Assert
            _registryHelperInstanceType.ShouldNotBeNull();
            _registryHelperInstance.ShouldNotBeNull();
            _registryHelperInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RegistryHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RegistryHelper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RegistryHelper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _registryHelperInstance.ShouldBeAssignableTo<RegistryHelper>();
            _registryHelperInstanceFixture.ShouldBeAssignableTo<RegistryHelper>();
            CurrentInstance.ShouldBeAssignableTo<RegistryHelper>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RegistryHelper) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RegistryHelper_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RegistryHelper instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (RegistryHelper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyShowError)]
        [TestCase(PropertySubKey)]
        [TestCase(PropertySubKeyApplication)]
        [TestCase(PropertyBaseRegistryKey)]
        public void AUT_RegistryHelper_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (RegistryHelper) => Property (BaseRegistryKey) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RegistryHelper_BaseRegistryKey_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBaseRegistryKey);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBaseRegistryKey);
            Action currentAction = () => propertyInfo.SetValue(_registryHelperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (RegistryHelper) => Property (BaseRegistryKey) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RegistryHelper_Public_Class_BaseRegistryKey_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBaseRegistryKey);
            var propertyInfo = this.GetPropertyInfo(PropertyBaseRegistryKey);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RegistryHelper) => Property (ShowError) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RegistryHelper_Public_Class_ShowError_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyShowError);
            var propertyInfo = this.GetPropertyInfo(PropertyShowError);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RegistryHelper) => Property (SubKey) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RegistryHelper_Public_Class_SubKey_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySubKey);
            var propertyInfo = this.GetPropertyInfo(PropertySubKey);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RegistryHelper) => Property (SubKeyApplication) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RegistryHelper_Public_Class_SubKeyApplication_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySubKeyApplication);
            var propertyInfo = this.GetPropertyInfo(PropertySubKeyApplication);

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

        #region Method Call : (Read) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var KeyName = this.CreateType<string>();

            // Act
            Action executeAction = () => _registryHelperInstance.Read(KeyName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var KeyName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _registryHelperInstance.Read(KeyName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var KeyName = this.CreateType<string>();
            var methodReadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRead = { KeyName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRead, methodReadParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_registryHelperInstanceFixture, parametersOfRead);
            var result2 = this.GetResultOfMethod<string>(MethodRead, parametersOfRead, methodReadParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRead.ShouldNotBeNull();
            parametersOfRead.Length.ShouldBe(1);
            methodReadParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var KeyName = this.CreateType<string>();
            var methodReadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRead = { KeyName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRead, methodReadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_registryHelperInstanceFixture, parametersOfRead);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRead.ShouldNotBeNull();
            parametersOfRead.Length.ShouldBe(1);
            methodReadParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var KeyName = this.CreateType<string>();
            var methodReadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRead = { KeyName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRead, parametersOfRead, methodReadParametersTypes);

            // Assert
            parametersOfRead.ShouldNotBeNull();
            parametersOfRead.Length.ShouldBe(1);
            methodReadParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var methodReadParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodReadParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var methodReadParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReadParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var currentMethodInfo = this.GetMethodInfo(MethodRead, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_Read_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var currentMethodInfo = this.GetMethodInfo(MethodRead, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RegistryHelper_GetSubKeyValueNames_Method_Call_Internally(Type[] types)
        {
            var methodGetSubKeyValueNamesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSubKeyValueNames, methodGetSubKeyValueNamesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_GetSubKeyValueNames_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubKeyValueNames);

            // Act
            Action executeAction = () => _registryHelperInstance.GetSubKeyValueNames();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_GetSubKeyValueNames_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubKeyValueNames);
            var returnedValue = default(string[]);

            // Act
            Action executeAction = () => returnedValue = _registryHelperInstance.GetSubKeyValueNames();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_GetSubKeyValueNames_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubKeyValueNames);
            Type [] methodGetSubKeyValueNamesParametersTypes = null;
            object[] parametersOfGetSubKeyValueNames = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubKeyValueNames, methodGetSubKeyValueNamesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[]>(_registryHelperInstanceFixture, parametersOfGetSubKeyValueNames);
            var result2 = this.GetResultOfMethod<string[]>(MethodGetSubKeyValueNames, parametersOfGetSubKeyValueNames, methodGetSubKeyValueNamesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSubKeyValueNames.ShouldBeNull();
            methodGetSubKeyValueNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_GetSubKeyValueNames_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubKeyValueNames);
            Type [] methodGetSubKeyValueNamesParametersTypes = null;
            object[] parametersOfGetSubKeyValueNames = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubKeyValueNames, methodGetSubKeyValueNamesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_registryHelperInstanceFixture, parametersOfGetSubKeyValueNames);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSubKeyValueNames.ShouldBeNull();
            methodGetSubKeyValueNamesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_GetSubKeyValueNames_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubKeyValueNames);
            Type [] methodGetSubKeyValueNamesParametersTypes = null;
            object[] parametersOfGetSubKeyValueNames = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[]>(MethodGetSubKeyValueNames, parametersOfGetSubKeyValueNames, methodGetSubKeyValueNamesParametersTypes);

            // Assert
            parametersOfGetSubKeyValueNames.ShouldBeNull();
            methodGetSubKeyValueNamesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_GetSubKeyValueNames_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubKeyValueNames);
            Type [] methodGetSubKeyValueNamesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubKeyValueNames, methodGetSubKeyValueNamesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubKeyValueNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_GetSubKeyValueNames_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubKeyValueNames);
            Type [] methodGetSubKeyValueNamesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubKeyValueNames, methodGetSubKeyValueNamesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubKeyValueNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubKeyValueNames) (Return Type : string[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_GetSubKeyValueNames_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubKeyValueNames);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubKeyValueNames, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RegistryHelper_Write_Method_Call_Internally(Type[] types)
        {
            var methodWriteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);
        }

        #endregion
        
        #region Method Call : (DeleteKey) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RegistryHelper_DeleteKey_Method_Call_Internally(Type[] types)
        {
            var methodDeleteKeyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteKey, methodDeleteKeyParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var KeyPath = this.CreateType<string>();
            var value = this.CreateType<string>();

            // Act
            Action executeAction = () => _registryHelperInstance.DeleteKey(KeyPath, value);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var KeyPath = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodDeleteKeyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDeleteKey = { KeyPath, value };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteKey, methodDeleteKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_registryHelperInstanceFixture, parametersOfDeleteKey);
            var result2 = this.GetResultOfMethod<bool>(MethodDeleteKey, parametersOfDeleteKey, methodDeleteKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDeleteKey.ShouldNotBeNull();
            parametersOfDeleteKey.Length.ShouldBe(2);
            methodDeleteKeyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var KeyPath = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodDeleteKeyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDeleteKey = { KeyPath, value };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteKey, methodDeleteKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_registryHelperInstanceFixture, out exception1, parametersOfDeleteKey);
            var result2 = this.GetResultOfMethod<bool>(MethodDeleteKey, parametersOfDeleteKey, methodDeleteKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDeleteKey.ShouldNotBeNull();
            parametersOfDeleteKey.Length.ShouldBe(2);
            methodDeleteKeyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var KeyPath = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodDeleteKeyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDeleteKey = { KeyPath, value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteKey, methodDeleteKeyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_registryHelperInstanceFixture, parametersOfDeleteKey);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteKey.ShouldNotBeNull();
            parametersOfDeleteKey.Length.ShouldBe(2);
            methodDeleteKeyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var KeyPath = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodDeleteKeyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDeleteKey = { KeyPath, value };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDeleteKey, parametersOfDeleteKey, methodDeleteKeyParametersTypes);

            // Assert
            parametersOfDeleteKey.ShouldNotBeNull();
            parametersOfDeleteKey.Length.ShouldBe(2);
            methodDeleteKeyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var methodDeleteKeyParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteKey, methodDeleteKeyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDeleteKeyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var methodDeleteKeyParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteKey, methodDeleteKeyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDeleteKeyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var methodDeleteKeyParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteKey, methodDeleteKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteKeyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteKey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DeleteKey) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegistryHelper_DeleteKey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteKey);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteKey, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ShowErrorMessage) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RegistryHelper_ShowErrorMessage_Method_Call_Internally(Type[] types)
        {
            var methodShowErrorMessageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodShowErrorMessage, methodShowErrorMessageParametersTypes);
        }

        #endregion
        
        #region Method Call : (SetEmailProperty) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RegistryHelper_SetEmailProperty_Method_Call_Internally(Type[] types)
        {
            var methodSetEmailPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetEmailProperty, methodSetEmailPropertyParametersTypes);
        }

        #endregion
        
        #endregion

        #endregion
    }
}