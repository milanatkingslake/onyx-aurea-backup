using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.OGSOEASService;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OGSOEASService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OGSOEASService.OnyxOGSOEASService" />)
    ///     and namespace <see cref="OnyxSDK.Public.OGSOEASService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxOGSOEASServiceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOGSOEASService" />)
        /// </summary>
        public OnyxOGSOEASServiceTest() : base(typeof(OnyxOGSOEASService))
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

        #region General Initializer : Class (OnyxOGSOEASService) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOGSOEASServiceInstanceType;
        private OnyxOGSOEASService _onyxOGSOEASServiceInstance;
        private OnyxOGSOEASService _onyxOGSOEASServiceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOGSOEASService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOGSOEASServiceInstanceType = typeof(OnyxOGSOEASService);
            _onyxOGSOEASServiceInstanceFixture = this.Create<OnyxOGSOEASService>(false);
            _onyxOGSOEASServiceInstance = _onyxOGSOEASServiceInstanceFixture ?? this.Create<OnyxOGSOEASService>(true);
            CurrentInstance = _onyxOGSOEASServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOGSOEASService) Initializer

        #region Properties

        private const string PropertyOnyxSessionManager = "OnyxSessionManager";

        #endregion

        #region Methods

        private const string MethodClearSessionItems = "ClearSessionItems";
        private const string MethodEndSession = "EndSession";
        private const string MethodEstablishSession = "EstablishSession";
        private const string MethodGetContextXml = "GetContextXml";
        private const string MethodGetContextXml2 = "GetContextXml2";
        private const string MethodGetSessionItem = "GetSessionItem";
        private const string MethodGetSessionItems = "GetSessionItems";
        private const string MethodHasPermission = "HasPermission";
        private const string MethodHasPermissions = "HasPermissions";
        private const string MethodOPMLicensesAvailable = "OPMLicensesAvailable";
        private const string MethodRemoveSessionItem = "RemoveSessionItem";
        private const string MethodSetImpersonation = "SetImpersonation";
        private const string MethodSetSessionItem = "SetSessionItem";

        #endregion

        #region Fields

        private const string Field_onyxSessionManagerLock = "_onyxSessionManagerLock";
        private const string Field_onyxSessionManager = "_onyxSessionManager";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOGSOEASService) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASService" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOGSOEASService_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOGSOEASService) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASService" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOGSOEASService_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOGSOEASService) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASService" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOGSOEASService_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOGSOEASService)

        #region General Initializer : Class (OnyxOGSOEASService) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodClearSessionItems, 0)]
        [TestCase(MethodEndSession, 0)]
        [TestCase(MethodEstablishSession, 0)]
        [TestCase(MethodGetContextXml, 0)]
        [TestCase(MethodGetContextXml2, 0)]
        [TestCase(MethodGetSessionItem, 0)]
        [TestCase(MethodGetSessionItems, 0)]
        [TestCase(MethodHasPermission, 0)]
        [TestCase(MethodHasPermissions, 0)]
        [TestCase(MethodOPMLicensesAvailable, 0)]
        [TestCase(MethodRemoveSessionItem, 0)]
        [TestCase(MethodSetImpersonation, 0)]
        [TestCase(MethodSetSessionItem, 0)]
        public void AUT_OnyxOGSOEASService_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxOGSOEASService) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASService" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxSessionManager)]
        [Category("AUT Property")]
        public void AUT_OnyxOGSOEASService_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxOGSOEASService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_onyxSessionManagerLock)]
        [TestCase(Field_onyxSessionManager)]
        [Category("AUT Fields")]
        public void AUT_OnyxOGSOEASService_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOGSOEASService) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASService" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOGSOEASService_Is_Instance_Present_Test()
        {
            // Assert
            _onyxOGSOEASServiceInstanceType.ShouldNotBeNull();
            _onyxOGSOEASServiceInstance.ShouldNotBeNull();
            _onyxOGSOEASServiceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxOGSOEASService) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASService" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOGSOEASService_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOGSOEASServiceInstance.ShouldBeAssignableTo<OnyxOGSOEASService>();
            _onyxOGSOEASServiceInstanceFixture.ShouldBeAssignableTo<OnyxOGSOEASService>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOGSOEASService>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxOGSOEASService) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxOGSOEASService_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxOGSOEASService instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOGSOEASService) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOnyxSessionManager)]
        public void AUT_OnyxOGSOEASService_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOGSOEASService) => Property (OnyxSessionManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOGSOEASService_OnyxSessionManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxSessionManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxSessionManager);
            Action currentAction = () => propertyInfo.SetValue(_onyxOGSOEASServiceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOGSOEASService) => Property (OnyxSessionManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOGSOEASService_Public_Class_OnyxSessionManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxSessionManager);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxSessionManager);

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

        #region Method Call : (ClearSessionItems) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_ClearSessionItems_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.ClearSessionItems(sessionId, applicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_ClearSessionItems_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodClearSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfClearSessionItems = { sessionId, applicationName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearSessionItems, methodClearSessionItemsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOGSOEASServiceInstanceFixture, parametersOfClearSessionItems);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearSessionItems.ShouldNotBeNull();
            parametersOfClearSessionItems.Length.ShouldBe(2);
            methodClearSessionItemsParametersTypes.Length.ShouldBe(2);
            methodClearSessionItemsParametersTypes.Length.ShouldBe(parametersOfClearSessionItems.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_ClearSessionItems_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodClearSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfClearSessionItems = { sessionId, applicationName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearSessionItems, parametersOfClearSessionItems, methodClearSessionItemsParametersTypes);

            // Assert
            parametersOfClearSessionItems.ShouldNotBeNull();
            parametersOfClearSessionItems.Length.ShouldBe(2);
            methodClearSessionItemsParametersTypes.Length.ShouldBe(2);
            methodClearSessionItemsParametersTypes.Length.ShouldBe(parametersOfClearSessionItems.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_ClearSessionItems_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var currentMethodInfo = this.GetMethodInfo(MethodClearSessionItems, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_ClearSessionItems_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var methodClearSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearSessionItems, methodClearSessionItemsParametersTypes);

            // Assert
            methodClearSessionItemsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_ClearSessionItems_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var currentMethodInfo = this.GetMethodInfo(MethodClearSessionItems, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_EndSession_Method_Call_Internally(Type[] types)
        {
            var methodEndSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEndSession, methodEndSessionParametersTypes);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EndSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.EndSession(sessionId, applicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EndSession_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodEndSessionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEndSession = { sessionId, applicationName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEndSession, methodEndSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOGSOEASServiceInstanceFixture, parametersOfEndSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEndSession.ShouldNotBeNull();
            parametersOfEndSession.Length.ShouldBe(2);
            methodEndSessionParametersTypes.Length.ShouldBe(2);
            methodEndSessionParametersTypes.Length.ShouldBe(parametersOfEndSession.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EndSession_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodEndSessionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEndSession = { sessionId, applicationName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEndSession, parametersOfEndSession, methodEndSessionParametersTypes);

            // Assert
            parametersOfEndSession.ShouldNotBeNull();
            parametersOfEndSession.Length.ShouldBe(2);
            methodEndSessionParametersTypes.Length.ShouldBe(2);
            methodEndSessionParametersTypes.Length.ShouldBe(parametersOfEndSession.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EndSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var currentMethodInfo = this.GetMethodInfo(MethodEndSession, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EndSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var methodEndSessionParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEndSession, methodEndSessionParametersTypes);

            // Assert
            methodEndSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EndSession_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var currentMethodInfo = this.GetMethodInfo(MethodEndSession, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_EstablishSession_Method_Call_Internally(Type[] types)
        {
            var methodEstablishSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEstablishSession, methodEstablishSessionParametersTypes);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EstablishSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var userId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var source = this.CreateType<string>();
            var siteId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.EstablishSession(userId, applicationName, source, siteId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EstablishSession_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var userId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var source = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASServiceInstance.EstablishSession(userId, applicationName, source, siteId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EstablishSession_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var userId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var source = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var methodEstablishSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfEstablishSession = { userId, applicationName, source, siteId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSession, methodEstablishSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASServiceInstanceFixture, parametersOfEstablishSession);
            var result2 = this.GetResultOfMethod<string>(MethodEstablishSession, parametersOfEstablishSession, methodEstablishSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfEstablishSession.ShouldNotBeNull();
            parametersOfEstablishSession.Length.ShouldBe(4);
            methodEstablishSessionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EstablishSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var userId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var source = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var methodEstablishSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfEstablishSession = { userId, applicationName, source, siteId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEstablishSession, parametersOfEstablishSession, methodEstablishSessionParametersTypes);

            // Assert
            parametersOfEstablishSession.ShouldNotBeNull();
            parametersOfEstablishSession.Length.ShouldBe(4);
            methodEstablishSessionParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EstablishSession_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var methodEstablishSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEstablishSession, methodEstablishSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodEstablishSessionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EstablishSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var methodEstablishSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEstablishSession, methodEstablishSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEstablishSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EstablishSession_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_EstablishSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSession, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_GetContextXml_Method_Call_Internally(Type[] types)
        {
            var methodGetContextXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextXml, methodGetContextXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.GetContextXml(sessionId, applicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASServiceInstance.GetContextXml(sessionId, applicationName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodGetContextXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetContextXml = { sessionId, applicationName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXml, methodGetContextXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASServiceInstanceFixture, parametersOfGetContextXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetContextXml, parametersOfGetContextXml, methodGetContextXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContextXml.ShouldNotBeNull();
            parametersOfGetContextXml.Length.ShouldBe(2);
            methodGetContextXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodGetContextXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetContextXml = { sessionId, applicationName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContextXml, parametersOfGetContextXml, methodGetContextXmlParametersTypes);

            // Assert
            parametersOfGetContextXml.ShouldNotBeNull();
            parametersOfGetContextXml.Length.ShouldBe(2);
            methodGetContextXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml);
            var methodGetContextXmlParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContextXml, methodGetContextXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContextXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml);
            var methodGetContextXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContextXml, methodGetContextXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContextXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXml, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_GetContextXml2_Method_Call_Internally(Type[] types)
        {
            var methodGetContextXml2ParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextXml2, methodGetContextXml2ParametersTypes);
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml2_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml2);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var updateSessionAccessTime = this.CreateType<bool>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.GetContextXml2(sessionId, applicationName, updateSessionAccessTime);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml2_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml2);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var updateSessionAccessTime = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASServiceInstance.GetContextXml2(sessionId, applicationName, updateSessionAccessTime);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml2_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml2);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var updateSessionAccessTime = this.CreateType<bool>();
            var methodGetContextXml2ParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetContextXml2 = { sessionId, applicationName, updateSessionAccessTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXml2, methodGetContextXml2ParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASServiceInstanceFixture, parametersOfGetContextXml2);
            var result2 = this.GetResultOfMethod<string>(MethodGetContextXml2, parametersOfGetContextXml2, methodGetContextXml2ParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContextXml2.ShouldNotBeNull();
            parametersOfGetContextXml2.Length.ShouldBe(3);
            methodGetContextXml2ParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml2_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml2);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var updateSessionAccessTime = this.CreateType<bool>();
            var methodGetContextXml2ParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetContextXml2 = { sessionId, applicationName, updateSessionAccessTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContextXml2, parametersOfGetContextXml2, methodGetContextXml2ParametersTypes);

            // Assert
            parametersOfGetContextXml2.ShouldNotBeNull();
            parametersOfGetContextXml2.Length.ShouldBe(3);
            methodGetContextXml2ParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml2_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml2);
            var methodGetContextXml2ParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContextXml2, methodGetContextXml2ParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContextXml2ParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml2_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml2);
            var methodGetContextXml2ParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContextXml2, methodGetContextXml2ParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContextXml2ParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml2_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml2);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXml2, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextXml2) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetContextXml2_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXml2);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXml2, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_GetSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodGetSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.GetSessionItem(sessionId, applicationName, key);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItem_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASServiceInstance.GetSessionItem(sessionId, applicationName, key);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItem_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetSessionItem = { sessionId, applicationName, key };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, methodGetSessionItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASServiceInstanceFixture, parametersOfGetSessionItem);
            var result2 = this.GetResultOfMethod<string>(MethodGetSessionItem, parametersOfGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSessionItem.ShouldNotBeNull();
            parametersOfGetSessionItem.Length.ShouldBe(3);
            methodGetSessionItemParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItem_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetSessionItem = { sessionId, applicationName, key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSessionItem, parametersOfGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            parametersOfGetSessionItem.ShouldNotBeNull();
            parametersOfGetSessionItem.Length.ShouldBe(3);
            methodGetSessionItemParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItem_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSessionItemParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSessionItemParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItem_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_GetSessionItems_Method_Call_Internally(Type[] types)
        {
            var methodGetSessionItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSessionItems, methodGetSessionItemsParametersTypes);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItems_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.GetSessionItems(sessionId, applicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItems_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASServiceInstance.GetSessionItems(sessionId, applicationName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItems_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodGetSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSessionItems = { sessionId, applicationName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItems, methodGetSessionItemsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASServiceInstanceFixture, parametersOfGetSessionItems);
            var result2 = this.GetResultOfMethod<string>(MethodGetSessionItems, parametersOfGetSessionItems, methodGetSessionItemsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSessionItems.ShouldNotBeNull();
            parametersOfGetSessionItems.Length.ShouldBe(2);
            methodGetSessionItemsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItems_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodGetSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSessionItems = { sessionId, applicationName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSessionItems, parametersOfGetSessionItems, methodGetSessionItemsParametersTypes);

            // Assert
            parametersOfGetSessionItems.ShouldNotBeNull();
            parametersOfGetSessionItems.Length.ShouldBe(2);
            methodGetSessionItemsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItems_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var methodGetSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSessionItems, methodGetSessionItemsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSessionItemsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItems_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var methodGetSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSessionItems, methodGetSessionItemsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSessionItemsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItems_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItems, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_GetSessionItems_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItems, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_HasPermission_Method_Call_Internally(Type[] types)
        {
            var methodHasPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodHasPermission, methodHasPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermission_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var resource = this.CreateType<string>();
            var securityMask = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.HasPermission(sessionId, applicationName, resource, securityMask);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var resource = this.CreateType<string>();
            var securityMask = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfHasPermission = { sessionId, applicationName, resource, securityMask };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOGSOEASServiceInstanceFixture, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(4);
            methodHasPermissionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermission_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var resource = this.CreateType<string>();
            var securityMask = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfHasPermission = { sessionId, applicationName, resource, securityMask };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOGSOEASServiceInstanceFixture, out exception1, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(4);
            methodHasPermissionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var resource = this.CreateType<string>();
            var securityMask = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfHasPermission = { sessionId, applicationName, resource, securityMask };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(4);
            methodHasPermissionParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var methodHasPermissionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHasPermission, methodHasPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodHasPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_HasPermissions_Method_Call_Internally(Type[] types)
        {
            var methodHasPermissionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodHasPermissions, methodHasPermissionsParametersTypes);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermissions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var resources = this.CreateType<object>();
            var securityMask = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.HasPermissions(sessionId, applicationName, resources, securityMask);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermissions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var resources = this.CreateType<object>();
            var securityMask = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASServiceInstance.HasPermissions(sessionId, applicationName, resources, securityMask);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermissions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var resources = this.CreateType<object>();
            var securityMask = this.CreateType<string>();
            var methodHasPermissionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(object), typeof(string) };
            object[] parametersOfHasPermissions = { sessionId, applicationName, resources, securityMask };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermissions, methodHasPermissionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxOGSOEASServiceInstanceFixture, parametersOfHasPermissions);
            var result2 = this.GetResultOfMethod<string>(MethodHasPermissions, parametersOfHasPermissions, methodHasPermissionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfHasPermissions.ShouldNotBeNull();
            parametersOfHasPermissions.Length.ShouldBe(4);
            methodHasPermissionsParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermissions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var resources = this.CreateType<object>();
            var securityMask = this.CreateType<string>();
            var methodHasPermissionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(object), typeof(string) };
            object[] parametersOfHasPermissions = { sessionId, applicationName, resources, securityMask };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodHasPermissions, parametersOfHasPermissions, methodHasPermissionsParametersTypes);

            // Assert
            parametersOfHasPermissions.ShouldNotBeNull();
            parametersOfHasPermissions.Length.ShouldBe(4);
            methodHasPermissionsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermissions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var methodHasPermissionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(object), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodHasPermissions, methodHasPermissionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodHasPermissionsParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermissions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var methodHasPermissionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(object), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHasPermissions, methodHasPermissionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodHasPermissionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermissions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermissions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_HasPermissions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermissions, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OPMLicensesAvailable) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_OPMLicensesAvailable_Method_Call_Internally(Type[] types)
        {
            var methodOPMLicensesAvailableParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOPMLicensesAvailable, methodOPMLicensesAvailableParametersTypes);
        }

        #endregion

        #region Method Call : (OPMLicensesAvailable) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_OPMLicensesAvailable_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOPMLicensesAvailable);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.OPMLicensesAvailable(sessionId, applicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (OPMLicensesAvailable) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_OPMLicensesAvailable_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOPMLicensesAvailable);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodOPMLicensesAvailableParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfOPMLicensesAvailable = { sessionId, applicationName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodOPMLicensesAvailable, methodOPMLicensesAvailableParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOGSOEASServiceInstanceFixture, parametersOfOPMLicensesAvailable);
            var result2 = this.GetResultOfMethod<bool>(MethodOPMLicensesAvailable, parametersOfOPMLicensesAvailable, methodOPMLicensesAvailableParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfOPMLicensesAvailable.ShouldNotBeNull();
            parametersOfOPMLicensesAvailable.Length.ShouldBe(2);
            methodOPMLicensesAvailableParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (OPMLicensesAvailable) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_OPMLicensesAvailable_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOPMLicensesAvailable);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodOPMLicensesAvailableParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfOPMLicensesAvailable = { sessionId, applicationName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodOPMLicensesAvailable, methodOPMLicensesAvailableParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxOGSOEASServiceInstanceFixture, out exception1, parametersOfOPMLicensesAvailable);
            var result2 = this.GetResultOfMethod<bool>(MethodOPMLicensesAvailable, parametersOfOPMLicensesAvailable, methodOPMLicensesAvailableParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfOPMLicensesAvailable.ShouldNotBeNull();
            parametersOfOPMLicensesAvailable.Length.ShouldBe(2);
            methodOPMLicensesAvailableParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (OPMLicensesAvailable) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_OPMLicensesAvailable_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOPMLicensesAvailable);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodOPMLicensesAvailableParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfOPMLicensesAvailable = { sessionId, applicationName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodOPMLicensesAvailable, parametersOfOPMLicensesAvailable, methodOPMLicensesAvailableParametersTypes);

            // Assert
            parametersOfOPMLicensesAvailable.ShouldNotBeNull();
            parametersOfOPMLicensesAvailable.Length.ShouldBe(2);
            methodOPMLicensesAvailableParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OPMLicensesAvailable) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_OPMLicensesAvailable_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOPMLicensesAvailable);
            var methodOPMLicensesAvailableParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOPMLicensesAvailable, methodOPMLicensesAvailableParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodOPMLicensesAvailableParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OPMLicensesAvailable) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_OPMLicensesAvailable_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOPMLicensesAvailable);
            var currentMethodInfo = this.GetMethodInfo(MethodOPMLicensesAvailable, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (OPMLicensesAvailable) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_OPMLicensesAvailable_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOPMLicensesAvailable);
            var currentMethodInfo = this.GetMethodInfo(MethodOPMLicensesAvailable, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_RemoveSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodRemoveSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_RemoveSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.RemoveSessionItem(sessionId, applicationName, key);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_RemoveSessionItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfRemoveSessionItem = { sessionId, applicationName, key };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOGSOEASServiceInstanceFixture, parametersOfRemoveSessionItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveSessionItem.ShouldNotBeNull();
            parametersOfRemoveSessionItem.Length.ShouldBe(3);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(3);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(parametersOfRemoveSessionItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_RemoveSessionItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfRemoveSessionItem = { sessionId, applicationName, key };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveSessionItem, parametersOfRemoveSessionItem, methodRemoveSessionItemParametersTypes);

            // Assert
            parametersOfRemoveSessionItem.ShouldNotBeNull();
            parametersOfRemoveSessionItem.Length.ShouldBe(3);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(3);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(parametersOfRemoveSessionItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_RemoveSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_RemoveSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes);

            // Assert
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_RemoveSessionItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetImpersonation) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_SetImpersonation_Method_Call_Internally(Type[] types)
        {
            var methodSetImpersonationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetImpersonation, methodSetImpersonationParametersTypes);
        }

        #endregion

        #region Method Call : (SetImpersonation) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetImpersonation_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetImpersonation);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var userToImpersonate = this.CreateType<string>();
            var impersonate = this.CreateType<bool>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.SetImpersonation(sessionId, applicationName, userToImpersonate, impersonate);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetImpersonation) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetImpersonation_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetImpersonation);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var userToImpersonate = this.CreateType<string>();
            var impersonate = this.CreateType<bool>();
            var methodSetImpersonationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfSetImpersonation = { sessionId, applicationName, userToImpersonate, impersonate };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetImpersonation, methodSetImpersonationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOGSOEASServiceInstanceFixture, parametersOfSetImpersonation);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetImpersonation.ShouldNotBeNull();
            parametersOfSetImpersonation.Length.ShouldBe(4);
            methodSetImpersonationParametersTypes.Length.ShouldBe(4);
            methodSetImpersonationParametersTypes.Length.ShouldBe(parametersOfSetImpersonation.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetImpersonation) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetImpersonation_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetImpersonation);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var userToImpersonate = this.CreateType<string>();
            var impersonate = this.CreateType<bool>();
            var methodSetImpersonationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfSetImpersonation = { sessionId, applicationName, userToImpersonate, impersonate };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetImpersonation, parametersOfSetImpersonation, methodSetImpersonationParametersTypes);

            // Assert
            parametersOfSetImpersonation.ShouldNotBeNull();
            parametersOfSetImpersonation.Length.ShouldBe(4);
            methodSetImpersonationParametersTypes.Length.ShouldBe(4);
            methodSetImpersonationParametersTypes.Length.ShouldBe(parametersOfSetImpersonation.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetImpersonation) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetImpersonation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetImpersonation);
            var currentMethodInfo = this.GetMethodInfo(MethodSetImpersonation, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetImpersonation) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetImpersonation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetImpersonation);
            var methodSetImpersonationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetImpersonation, methodSetImpersonationParametersTypes);

            // Assert
            methodSetImpersonationParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetImpersonation) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetImpersonation_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetImpersonation);
            var currentMethodInfo = this.GetMethodInfo(MethodSetImpersonation, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASService_SetSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodSetSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSessionItem, methodSetSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();
            var value = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceInstance.SetSessionItem(sessionId, applicationName, key, value);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetSessionItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSetSessionItem = { sessionId, applicationName, key, value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSessionItem, methodSetSessionItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxOGSOEASServiceInstanceFixture, parametersOfSetSessionItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSessionItem.ShouldNotBeNull();
            parametersOfSetSessionItem.Length.ShouldBe(4);
            methodSetSessionItemParametersTypes.Length.ShouldBe(4);
            methodSetSessionItemParametersTypes.Length.ShouldBe(parametersOfSetSessionItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetSessionItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var key = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSetSessionItem = { sessionId, applicationName, key, value };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSessionItem, parametersOfSetSessionItem, methodSetSessionItemParametersTypes);

            // Assert
            parametersOfSetSessionItem.ShouldNotBeNull();
            parametersOfSetSessionItem.Length.ShouldBe(4);
            methodSetSessionItemParametersTypes.Length.ShouldBe(4);
            methodSetSessionItemParametersTypes.Length.ShouldBe(parametersOfSetSessionItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSessionItem, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSessionItem, methodSetSessionItemParametersTypes);

            // Assert
            methodSetSessionItemParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASService_SetSessionItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSessionItem, 0);

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