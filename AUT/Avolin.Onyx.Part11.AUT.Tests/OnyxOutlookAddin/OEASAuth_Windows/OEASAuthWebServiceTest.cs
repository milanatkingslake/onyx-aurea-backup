using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin.OEASAuth_Windows;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin.OEASAuth_Windows
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OEASAuth_Windows.OEASAuthWebService" />)
    ///     and namespace <see cref="OnyxOutlookAddin.OEASAuth_Windows"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OEASAuthWebServiceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OEASAuthWebService" />)
        /// </summary>
        public OEASAuthWebServiceTest() : base(typeof(OEASAuthWebService))
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

        #region General Initializer : Class (OEASAuthWebService) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oEASAuthWebServiceInstanceType;
        private OEASAuthWebService _oEASAuthWebServiceInstance;
        private OEASAuthWebService _oEASAuthWebServiceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OEASAuthWebService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEASAuthWebServiceInstanceType = typeof(OEASAuthWebService);
            _oEASAuthWebServiceInstanceFixture = this.Create<OEASAuthWebService>(false);
            _oEASAuthWebServiceInstance = _oEASAuthWebServiceInstanceFixture ?? this.Create<OEASAuthWebService>(true);
            CurrentInstance = _oEASAuthWebServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEASAuthWebService) Initializer

        #region Properties

        private const string PropertyUrl = "Url";
        private const string PropertyUseDefaultCredentials = "UseDefaultCredentials";

        #endregion

        #region Methods

        private const string MethodEstablishSessionWindows = "EstablishSessionWindows";
        
        private const string MethodOnEstablishSessionWindowsOperationCompleted = "OnEstablishSessionWindowsOperationCompleted";
        private const string MethodCancelAsync = "CancelAsync";
        private const string MethodIsLocalFileSystemWebService = "IsLocalFileSystemWebService";

        #endregion

        #region Fields

        private const string FieldEstablishSessionWindowsOperationCompleted = "EstablishSessionWindowsOperationCompleted";
        private const string FielduseDefaultCredentialsSetExplicitly = "useDefaultCredentialsSetExplicitly";

        #endregion

        #endregion

        #region General Initializer : Class (OEASAuthWebService) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OEASAuthWebService" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OEASAuthWebService_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEASAuthWebService) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OEASAuthWebService" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OEASAuthWebService_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEASAuthWebService) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OEASAuthWebService" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OEASAuthWebService_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OEASAuthWebService)

        #region General Initializer : Class (OEASAuthWebService) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OEASAuthWebService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodEstablishSessionWindows, 0)]
        [TestCase(MethodOnEstablishSessionWindowsOperationCompleted, 0)]
        [TestCase(MethodIsLocalFileSystemWebService, 0)]
        public void AUT_OEASAuthWebService_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OEASAuthWebService) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASAuthWebService" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyUrl)]
        [TestCase(PropertyUseDefaultCredentials)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_OEASAuthWebService_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OEASAuthWebService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASAuthWebService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldEstablishSessionWindowsOperationCompleted)]
        [TestCase(FielduseDefaultCredentialsSetExplicitly)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_OEASAuthWebService_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OEASAuthWebService) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OEASAuthWebService" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OEASAuthWebService_Is_Instance_Present_Test()
        {
            // Assert
            _oEASAuthWebServiceInstanceType.ShouldNotBeNull();
            _oEASAuthWebServiceInstance.ShouldNotBeNull();
            _oEASAuthWebServiceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OEASAuthWebService) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OEASAuthWebService" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OEASAuthWebService_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oEASAuthWebServiceInstance.ShouldBeAssignableTo<OEASAuthWebService>();
            _oEASAuthWebServiceInstanceFixture.ShouldBeAssignableTo<OEASAuthWebService>();
            CurrentInstance.ShouldBeAssignableTo<OEASAuthWebService>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OEASAuthWebService) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_OEASAuthWebService_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OEASAuthWebService instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OEASAuthWebService) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyUrl)]
        [TestCase(PropertyUseDefaultCredentials)]
        public void AUT_OEASAuthWebService_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OEASAuthWebService) => Property (Url) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OEASAuthWebService_Public_Class_Url_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUrl);
            var propertyInfo = this.GetPropertyInfo(PropertyUrl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OEASAuthWebService) => Property (UseDefaultCredentials) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OEASAuthWebService_Public_Class_UseDefaultCredentials_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUseDefaultCredentials);
            var propertyInfo = this.GetPropertyInfo(PropertyUseDefaultCredentials);

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

        #region Method Call : (EstablishSessionWindows) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASAuthWebService_EstablishSessionWindows_Method_Call_Internally(Type[] types)
        {
            var methodEstablishSessionWindowsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEstablishSessionWindows, methodEstablishSessionWindowsParametersTypes);
        }

        #endregion

        #region Method Call : (EstablishSessionWindows) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_EstablishSessionWindows_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSessionWindows);
            var applicationName = this.CreateType<string>();
            var sourceName = this.CreateType<string>();
            var siteID = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASAuthWebServiceInstance.EstablishSessionWindows(applicationName, sourceName, siteID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EstablishSessionWindows) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_EstablishSessionWindows_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSessionWindows);
            var applicationName = this.CreateType<string>();
            var sourceName = this.CreateType<string>();
            var siteID = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASAuthWebServiceInstance.EstablishSessionWindows(applicationName, sourceName, siteID);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EstablishSessionWindows) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_EstablishSessionWindows_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSessionWindows);
            var applicationName = this.CreateType<string>();
            var sourceName = this.CreateType<string>();
            var siteID = this.CreateType<string>();
            var methodEstablishSessionWindowsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfEstablishSessionWindows = { applicationName, sourceName, siteID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSessionWindows, methodEstablishSessionWindowsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASAuthWebServiceInstanceFixture, parametersOfEstablishSessionWindows);
            var result2 = this.GetResultOfMethod<string>(MethodEstablishSessionWindows, parametersOfEstablishSessionWindows, methodEstablishSessionWindowsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfEstablishSessionWindows.ShouldNotBeNull();
            parametersOfEstablishSessionWindows.Length.ShouldBe(3);
            methodEstablishSessionWindowsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (EstablishSessionWindows) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_EstablishSessionWindows_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSessionWindows);
            var applicationName = this.CreateType<string>();
            var sourceName = this.CreateType<string>();
            var siteID = this.CreateType<string>();
            var methodEstablishSessionWindowsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfEstablishSessionWindows = { applicationName, sourceName, siteID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEstablishSessionWindows, parametersOfEstablishSessionWindows, methodEstablishSessionWindowsParametersTypes);

            // Assert
            parametersOfEstablishSessionWindows.ShouldNotBeNull();
            parametersOfEstablishSessionWindows.Length.ShouldBe(3);
            methodEstablishSessionWindowsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EstablishSessionWindows) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_EstablishSessionWindows_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSessionWindows);
            var methodEstablishSessionWindowsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEstablishSessionWindows, methodEstablishSessionWindowsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodEstablishSessionWindowsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (EstablishSessionWindows) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_EstablishSessionWindows_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSessionWindows);
            var methodEstablishSessionWindowsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEstablishSessionWindows, methodEstablishSessionWindowsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEstablishSessionWindowsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EstablishSessionWindows) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_EstablishSessionWindows_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSessionWindows);
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSessionWindows, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EstablishSessionWindows) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_EstablishSessionWindows_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSessionWindows);
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSessionWindows, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnEstablishSessionWindowsOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASAuthWebService_OnEstablishSessionWindowsOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnEstablishSessionWindowsOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnEstablishSessionWindowsOperationCompleted, methodOnEstablishSessionWindowsOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnEstablishSessionWindowsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_OnEstablishSessionWindowsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEstablishSessionWindowsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnEstablishSessionWindowsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnEstablishSessionWindowsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnEstablishSessionWindowsOperationCompleted, methodOnEstablishSessionWindowsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASAuthWebServiceInstanceFixture, parametersOfOnEstablishSessionWindowsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnEstablishSessionWindowsOperationCompleted.ShouldNotBeNull();
            parametersOfOnEstablishSessionWindowsOperationCompleted.Length.ShouldBe(1);
            methodOnEstablishSessionWindowsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnEstablishSessionWindowsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnEstablishSessionWindowsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnEstablishSessionWindowsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_OnEstablishSessionWindowsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEstablishSessionWindowsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnEstablishSessionWindowsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnEstablishSessionWindowsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnEstablishSessionWindowsOperationCompleted, parametersOfOnEstablishSessionWindowsOperationCompleted, methodOnEstablishSessionWindowsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnEstablishSessionWindowsOperationCompleted.ShouldNotBeNull();
            parametersOfOnEstablishSessionWindowsOperationCompleted.Length.ShouldBe(1);
            methodOnEstablishSessionWindowsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnEstablishSessionWindowsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnEstablishSessionWindowsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnEstablishSessionWindowsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_OnEstablishSessionWindowsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEstablishSessionWindowsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnEstablishSessionWindowsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnEstablishSessionWindowsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_OnEstablishSessionWindowsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEstablishSessionWindowsOperationCompleted);
            var methodOnEstablishSessionWindowsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnEstablishSessionWindowsOperationCompleted, methodOnEstablishSessionWindowsOperationCompletedParametersTypes);

            // Assert
            methodOnEstablishSessionWindowsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnEstablishSessionWindowsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_OnEstablishSessionWindowsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEstablishSessionWindowsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnEstablishSessionWindowsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASAuthWebService_IsLocalFileSystemWebService_Method_Call_Internally(Type[] types)
        {
            var methodIsLocalFileSystemWebServiceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_IsLocalFileSystemWebService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var url = this.CreateType<string>();
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsLocalFileSystemWebService = { url };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASAuthWebServiceInstanceFixture, parametersOfIsLocalFileSystemWebService);
            var result2 = this.GetResultOfMethod<bool>(MethodIsLocalFileSystemWebService, parametersOfIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.Length.ShouldBe(1);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_IsLocalFileSystemWebService_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var url = this.CreateType<string>();
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsLocalFileSystemWebService = { url };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASAuthWebServiceInstanceFixture, out exception1, parametersOfIsLocalFileSystemWebService);
            var result2 = this.GetResultOfMethod<bool>(MethodIsLocalFileSystemWebService, parametersOfIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.Length.ShouldBe(1);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_IsLocalFileSystemWebService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var url = this.CreateType<string>();
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsLocalFileSystemWebService = { url };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsLocalFileSystemWebService, parametersOfIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            parametersOfIsLocalFileSystemWebService.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.Length.ShouldBe(1);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_IsLocalFileSystemWebService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_IsLocalFileSystemWebService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASAuthWebService_IsLocalFileSystemWebService_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, 0);
            const int parametersCount = 1;

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