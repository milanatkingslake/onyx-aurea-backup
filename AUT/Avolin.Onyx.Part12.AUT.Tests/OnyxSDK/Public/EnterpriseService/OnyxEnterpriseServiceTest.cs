using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.EnterpriseService;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.EnterpriseService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.EnterpriseService.OnyxEnterpriseService" />)
    ///     and namespace <see cref="OnyxSDK.Public.EnterpriseService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxEnterpriseServiceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxEnterpriseService" />)
        /// </summary>
        public OnyxEnterpriseServiceTest() : base(typeof(OnyxEnterpriseService))
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

        #region General Initializer : Class (OnyxEnterpriseService) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxEnterpriseServiceInstanceType;
        private OnyxEnterpriseService _onyxEnterpriseServiceInstance;
        private OnyxEnterpriseService _onyxEnterpriseServiceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxEnterpriseService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxEnterpriseServiceInstanceType = typeof(OnyxEnterpriseService);
            _onyxEnterpriseServiceInstanceFixture = this.Create<OnyxEnterpriseService>(false);
            _onyxEnterpriseServiceInstance = _onyxEnterpriseServiceInstanceFixture ?? this.Create<OnyxEnterpriseService>(true);
            CurrentInstance = _onyxEnterpriseServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxEnterpriseService) Initializer

        #region Properties

        private const string PropertyOnyxTransactionManager = "OnyxTransactionManager";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";

        #endregion

        #region Fields

        private const string Field_onyxTransactionManagerLock = "_onyxTransactionManagerLock";
        private const string Field_onyxTransactionManager = "_onyxTransactionManager";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxEnterpriseService) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxEnterpriseService" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEnterpriseService_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxEnterpriseService) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxEnterpriseService" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEnterpriseService_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxEnterpriseService) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxEnterpriseService" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEnterpriseService_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxEnterpriseService)

        #region General Initializer : Class (OnyxEnterpriseService) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxEnterpriseService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodExecute, 1)]
        public void AUT_OnyxEnterpriseService_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxEnterpriseService) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxEnterpriseService" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxTransactionManager)]
        [Category("AUT Property")]
        public void AUT_OnyxEnterpriseService_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxEnterpriseService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxEnterpriseService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_onyxTransactionManagerLock)]
        [TestCase(Field_onyxTransactionManager)]
        [Category("AUT Fields")]
        public void AUT_OnyxEnterpriseService_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxEnterpriseService) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxEnterpriseService" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxEnterpriseService_Is_Instance_Present_Test()
        {
            // Assert
            _onyxEnterpriseServiceInstanceType.ShouldNotBeNull();
            _onyxEnterpriseServiceInstance.ShouldNotBeNull();
            _onyxEnterpriseServiceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxEnterpriseService) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxEnterpriseService" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxEnterpriseService_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxEnterpriseServiceInstance.ShouldBeAssignableTo<OnyxEnterpriseService>();
            _onyxEnterpriseServiceInstanceFixture.ShouldBeAssignableTo<OnyxEnterpriseService>();
            CurrentInstance.ShouldBeAssignableTo<OnyxEnterpriseService>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxEnterpriseService) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxEnterpriseService_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxEnterpriseService instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxEnterpriseService) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOnyxTransactionManager)]
        public void AUT_OnyxEnterpriseService_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxEnterpriseService) => Property (OnyxTransactionManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEnterpriseService_OnyxTransactionManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxTransactionManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxTransactionManager);
            Action currentAction = () => propertyInfo.SetValue(_onyxEnterpriseServiceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEnterpriseService) => Property (OnyxTransactionManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEnterpriseService_Public_Class_OnyxTransactionManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxTransactionManager);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxTransactionManager);

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

        #region Method Call : (Execute) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var stepPackage = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxEnterpriseServiceInstance.Execute(applicationName, logicalObjectName, logicalMethodName, ref stepPackage);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEnterpriseService_Execute_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodExecuteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxEnterpriseServiceInstance.Execute(applicationName, logicalObjectName, logicalMethodName, sessionId, paramXml, customDataXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxEnterpriseServiceInstance.Execute(applicationName, logicalObjectName, logicalMethodName, sessionId, paramXml, customDataXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { applicationName, logicalObjectName, logicalMethodName, sessionId, paramXml, customDataXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxEnterpriseServiceInstanceFixture, parametersOfExecute);
            var result2 = this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { applicationName, logicalObjectName, logicalMethodName, sessionId, paramXml, customDataXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEnterpriseService_Execute_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 6;

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
        public void AUT_OnyxEnterpriseService_Execute_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 1);

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
        public void AUT_OnyxEnterpriseService_Execute_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 1);
            const int parametersCount = 6;

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