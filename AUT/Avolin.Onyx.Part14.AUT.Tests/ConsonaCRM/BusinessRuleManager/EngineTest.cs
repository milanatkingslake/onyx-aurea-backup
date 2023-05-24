using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Engine" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class EngineTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Engine" />)
        /// </summary>
        public EngineTest() : base(typeof(Engine))
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

        #region General Initializer : Class (Engine) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _engineInstanceType;
        private Engine _engineInstance;
        private Engine _engineInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Engine" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _engineInstanceType = typeof(Engine);
            _engineInstanceFixture = this.Create<Engine>(false);
            _engineInstance = _engineInstanceFixture ?? this.Create<Engine>(true);
            CurrentInstance = _engineInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Engine) Initializer

        #region Properties

        private const string PropertydataPackage = "dataPackage";
        private const string PropertymessageList = "messageList";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodHandleException = "HandleException";
        private const string MethodGetMessageText = "GetMessageText";

        #endregion

        #region Fields

        private const string FieldDEFAULT_PACKAGE_XML = "DEFAULT_PACKAGE_XML";
        private const string FieldDEFAULT_MESSAGE_XML = "DEFAULT_MESSAGE_XML";
        private const string FieldNO_MESSAGE_LIST = "NO_MESSAGE_LIST";
        private const string FieldNO_MESSAGE_ID = "NO_MESSAGE_ID";
        private const string Fieldm_dataPackage = "m_dataPackage";
        private const string Fieldm_messageList = "m_messageList";

        #endregion

        #endregion

        #region General Initializer : Class (Engine) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Engine" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Engine_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Engine) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Engine" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Engine_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Engine) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Engine" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Engine_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Engine)

        #region General Initializer : Class (Engine) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Engine" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodHandleException, 0)]
        [TestCase(MethodGetMessageText, 0)]
        public void AUT_Engine_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Engine) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Engine" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertydataPackage)]
        [TestCase(PropertymessageList)]
        [Category("AUT Property")]
        public void AUT_Engine_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Engine) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Engine" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDEFAULT_PACKAGE_XML)]
        [TestCase(FieldDEFAULT_MESSAGE_XML)]
        [TestCase(FieldNO_MESSAGE_LIST)]
        [TestCase(FieldNO_MESSAGE_ID)]
        [TestCase(Fieldm_dataPackage)]
        [TestCase(Fieldm_messageList)]
        [Category("AUT Fields")]
        public void AUT_Engine_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Engine) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Engine" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Engine_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _engineInstance.ShouldBeAssignableTo<Engine>();
            _engineInstanceFixture.ShouldBeAssignableTo<Engine>();
            CurrentInstance.ShouldBeAssignableTo<Engine>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Engine) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertydataPackage)]
        [TestCase(PropertymessageList)]
        public void AUT_Engine_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Engine) => Property (dataPackage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Engine_Public_Class_dataPackage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertydataPackage);
            var propertyInfo = this.GetPropertyInfo(PropertydataPackage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Engine) => Property (messageList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Engine_Public_Class_messageList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymessageList);
            var propertyInfo = this.GetPropertyInfo(PropertymessageList);

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

        #region Method Call : (Execute) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_Execute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psRepositoryName = this.CreateType<string>();
            var psMetadataPath = this.CreateType<string>();
            var psInputXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _engineInstance.Execute(psRepositoryName, psMetadataPath, psInputXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_Execute_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psRepositoryName = this.CreateType<string>();
            var psMetadataPath = this.CreateType<string>();
            var psInputXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _engineInstance.Execute(psRepositoryName, psMetadataPath, psInputXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_Execute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psRepositoryName = this.CreateType<string>();
            var psMetadataPath = this.CreateType<string>();
            var psInputXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { psRepositoryName, psMetadataPath, psInputXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_engineInstanceFixture, parametersOfExecute);
            var result2 = this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(3);
            methodExecuteParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_Execute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var psRepositoryName = this.CreateType<string>();
            var psMetadataPath = this.CreateType<string>();
            var psInputXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { psRepositoryName, psMetadataPath, psInputXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(3);
            methodExecuteParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_Execute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_Execute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Engine_HandleException_Method_Call_Internally(Type[] types)
        {
            var methodHandleExceptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodHandleException, methodHandleExceptionParametersTypes);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_HandleException_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var e = this.CreateType<Exception>();
            var methodHandleExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfHandleException = { e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodHandleException, methodHandleExceptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_engineInstanceFixture, parametersOfHandleException);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfHandleException.ShouldNotBeNull();
            parametersOfHandleException.Length.ShouldBe(1);
            methodHandleExceptionParametersTypes.Length.ShouldBe(1);
            methodHandleExceptionParametersTypes.Length.ShouldBe(parametersOfHandleException.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_HandleException_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var e = this.CreateType<Exception>();
            var methodHandleExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfHandleException = { e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodHandleException, parametersOfHandleException, methodHandleExceptionParametersTypes);

            // Assert
            parametersOfHandleException.ShouldNotBeNull();
            parametersOfHandleException.Length.ShouldBe(1);
            methodHandleExceptionParametersTypes.Length.ShouldBe(1);
            methodHandleExceptionParametersTypes.Length.ShouldBe(parametersOfHandleException.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_HandleException_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var currentMethodInfo = this.GetMethodInfo(MethodHandleException, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_HandleException_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var methodHandleExceptionParametersTypes = new Type[] { typeof(Exception) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHandleException, methodHandleExceptionParametersTypes);

            // Assert
            methodHandleExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HandleException) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_HandleException_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleException);
            var currentMethodInfo = this.GetMethodInfo(MethodHandleException, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Engine_GetMessageText_Method_Call_Internally(Type[] types)
        {
            var methodGetMessageTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMessageText, methodGetMessageTextParametersTypes);
        }

        #endregion

        #region Method Call : (GetMessageText) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_GetMessageText_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageText);
            var pMessageId = this.CreateType<int>();
            var psArguments = this.CreateType<string>();
            var methodGetMessageTextParametersTypes = new Type[] { typeof(int), typeof(string) };
            object[] parametersOfGetMessageText = { pMessageId, psArguments };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageText, methodGetMessageTextParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_engineInstanceFixture, parametersOfGetMessageText);
            var result2 = this.GetResultOfMethod<string>(MethodGetMessageText, parametersOfGetMessageText, methodGetMessageTextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMessageText.ShouldNotBeNull();
            parametersOfGetMessageText.Length.ShouldBe(2);
            methodGetMessageTextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetMessageText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_GetMessageText_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageText);
            var pMessageId = this.CreateType<int>();
            var psArguments = this.CreateType<string>();
            var methodGetMessageTextParametersTypes = new Type[] { typeof(int), typeof(string) };
            object[] parametersOfGetMessageText = { pMessageId, psArguments };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMessageText, parametersOfGetMessageText, methodGetMessageTextParametersTypes);

            // Assert
            parametersOfGetMessageText.ShouldNotBeNull();
            parametersOfGetMessageText.Length.ShouldBe(2);
            methodGetMessageTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageText) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_GetMessageText_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageText);
            var methodGetMessageTextParametersTypes = new Type[] { typeof(int), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMessageText, methodGetMessageTextParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMessageTextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetMessageText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_GetMessageText_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageText);
            var methodGetMessageTextParametersTypes = new Type[] { typeof(int), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMessageText, methodGetMessageTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMessageTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMessageText) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_GetMessageText_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Engine_GetMessageText_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageText, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}