using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.UcfException" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UcfExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UcfException" />)
        /// </summary>
        public UcfExceptionTest() : base(typeof(UcfException))
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

        #region General Initializer : Class (UcfException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _ucfExceptionInstanceType;
        private UcfException _ucfExceptionInstance;
        private UcfException _ucfExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UcfException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _ucfExceptionInstanceType = typeof(UcfException);
            _ucfExceptionInstanceFixture = this.Create<UcfException>(false);
            _ucfExceptionInstance = _ucfExceptionInstanceFixture ?? this.Create<UcfException>(true);
            CurrentInstance = _ucfExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UcfException) Initializer

        #region Properties

        private const string PropertyErrorSource = "ErrorSource";
        private const string PropertyErrorNumber = "ErrorNumber";

        #endregion

        #region Methods

        private const string MethodLogError = "LogError";
        private const string MethodToString = "ToString";
        private const string MethodGetObjectData = "GetObjectData";

        #endregion

        #region Fields

        private const string Field_errorNumber = "_errorNumber";
        private const string Field_errorSource = "_errorSource";

        #endregion

        #endregion

        #region General Initializer : Class (UcfException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UcfException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UcfException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UcfException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UcfException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UcfException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UcfException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UcfException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UcfException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UcfException)

        #region General Initializer : Class (UcfException) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="UcfException" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLogError, 0)]
        [TestCase(MethodToString, 0)]
        [TestCase(MethodGetObjectData, 0)]
        public void AUT_UcfException_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (UcfException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="UcfException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyErrorSource)]
        [TestCase(PropertyErrorNumber)]
        [Category("AUT Property")]
        public void AUT_UcfException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (UcfException) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="UcfException" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_errorNumber)]
        [TestCase(Field_errorSource)]
        [Category("AUT Fields")]
        public void AUT_UcfException_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UcfException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UcfException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UcfException_Is_Instance_Present_Test()
        {
            // Assert
            _ucfExceptionInstanceType.ShouldNotBeNull();
            _ucfExceptionInstance.ShouldNotBeNull();
            _ucfExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UcfException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UcfException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UcfException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _ucfExceptionInstance.ShouldBeAssignableTo<UcfException>();
            _ucfExceptionInstanceFixture.ShouldBeAssignableTo<UcfException>();
            CurrentInstance.ShouldBeAssignableTo<UcfException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UcfException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            UcfException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new UcfException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _ucfExceptionInstance.ShouldNotBeNull();
            _ucfExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<UcfException>();
        }

        #endregion

        #region General Constructor : Class (UcfException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            UcfException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new UcfException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _ucfExceptionInstance.ShouldNotBeNull();
            _ucfExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (UcfException) instance created

        /// <summary>
        ///     Class (<see cref="UcfException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Is_Created_Test()
        {
            // Assert
            _ucfExceptionInstance.ShouldNotBeNull();
            _ucfExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (UcfException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="UcfException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void AUT_UcfException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (UcfException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="UcfException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (UcfException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="UcfException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodUcfExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodUcfExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (UcfException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="UcfException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodUcfExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodUcfExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (UcfException) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="UcfException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodUcfExceptionParametersTypes = new Type[] { typeof(string), typeof(ErrorNumbers) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodUcfExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (UcfException) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="UcfException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodUcfExceptionParametersTypes = new Type[] { typeof(string), typeof(ErrorNumbers), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodUcfExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (UcfException) constructors with dynamic parameters (Overloading_Of_4_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="UcfException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Constructors_Overloading_Of_4_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodUcfExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(ErrorNumbers) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodUcfExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (UcfException) constructors with dynamic parameters (Overloading_Of_5_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="UcfException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UcfException_Constructors_Overloading_Of_5_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodUcfExceptionParametersTypes = new Type[] { typeof(string), typeof(ErrorNumbers), typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodUcfExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (UcfException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyErrorSource)]
        [TestCase(PropertyErrorNumber)]
        public void AUT_UcfException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (UcfException) => Property (ErrorNumber) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UcfException_ErrorNumber_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorNumber);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyErrorNumber);
            Action currentAction = () => propertyInfo.SetValue(_ucfExceptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (UcfException) => Property (ErrorNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UcfException_Public_Class_ErrorNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorNumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UcfException) => Property (ErrorSource) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UcfException_Public_Class_ErrorSource_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorSource);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorSource);

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

        #region Method Call : (LogError) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_LogError_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            Type [] methodLogErrorParametersTypes = null;
            object[] parametersOfLogError = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, methodLogErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_ucfExceptionInstanceFixture, parametersOfLogError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogError.ShouldBeNull();
            methodLogErrorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_LogError_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            Type [] methodLogErrorParametersTypes = null;
            object[] parametersOfLogError = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogError, parametersOfLogError, methodLogErrorParametersTypes);

            // Assert
            parametersOfLogError.ShouldBeNull();
            methodLogErrorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_LogError_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            Type [] methodLogErrorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);

            // Assert
            methodLogErrorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_LogError_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UcfException_ToString_Method_Call_Internally(Type[] types)
        {
            var methodToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_ToString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);

            // Act
            Action executeAction = () => _ucfExceptionInstance.ToString();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_ToString_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _ucfExceptionInstance.ToString();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_ToString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_ucfExceptionInstanceFixture, out exception1, parametersOfToString);
            var result2 = this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_ToString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_ucfExceptionInstanceFixture, parametersOfToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_ToString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_ToString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_ToString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_ToString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var currentMethodInfo = this.GetMethodInfo(MethodToString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetObjectData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UcfException_GetObjectData_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectData, methodGetObjectDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectData) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_GetObjectData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectData);
            var info = this.CreateType<SerializationInfo>();
            var context = this.CreateType<StreamingContext>();

            // Act
            Action executeAction = () => _ucfExceptionInstance.GetObjectData(info, context);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetObjectData) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_GetObjectData_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectData);
            var info = this.CreateType<SerializationInfo>();
            var context = this.CreateType<StreamingContext>();
            var methodGetObjectDataParametersTypes = new Type[] { typeof(SerializationInfo), typeof(StreamingContext) };
            object[] parametersOfGetObjectData = { info, context };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectData, methodGetObjectDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_ucfExceptionInstanceFixture, parametersOfGetObjectData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetObjectData.ShouldNotBeNull();
            parametersOfGetObjectData.Length.ShouldBe(2);
            methodGetObjectDataParametersTypes.Length.ShouldBe(2);
            methodGetObjectDataParametersTypes.Length.ShouldBe(parametersOfGetObjectData.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_GetObjectData_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectData);
            var info = this.CreateType<SerializationInfo>();
            var context = this.CreateType<StreamingContext>();
            var methodGetObjectDataParametersTypes = new Type[] { typeof(SerializationInfo), typeof(StreamingContext) };
            object[] parametersOfGetObjectData = { info, context };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetObjectData, parametersOfGetObjectData, methodGetObjectDataParametersTypes);

            // Assert
            parametersOfGetObjectData.ShouldNotBeNull();
            parametersOfGetObjectData.Length.ShouldBe(2);
            methodGetObjectDataParametersTypes.Length.ShouldBe(2);
            methodGetObjectDataParametersTypes.Length.ShouldBe(parametersOfGetObjectData.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectData) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_GetObjectData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectData, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_GetObjectData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectData);
            var methodGetObjectDataParametersTypes = new Type[] { typeof(SerializationInfo), typeof(StreamingContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectData, methodGetObjectDataParametersTypes);

            // Assert
            methodGetObjectDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UcfException_GetObjectData_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectData, 0);

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