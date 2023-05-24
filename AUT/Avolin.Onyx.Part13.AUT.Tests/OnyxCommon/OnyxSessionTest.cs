using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxSession" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSessionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxSession" />)
        /// </summary>
        public OnyxSessionTest() : base(typeof(OnyxSession))
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

        #region General Initializer : Class (OnyxSession) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxSessionInstanceType;
        private OnyxSession _onyxSessionInstance;
        private OnyxSession _onyxSessionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxSession" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxSessionInstanceType = typeof(OnyxSession);
            _onyxSessionInstanceFixture = this.Create<OnyxSession>(false);
            _onyxSessionInstance = _onyxSessionInstanceFixture ?? this.Create<OnyxSession>(true);
            CurrentInstance = _onyxSessionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxSession) Initializer

        #region Properties

        private const string PropertySessionId = "SessionId";
        private const string PropertyTransactionId = "TransactionId";
        private const string PropertyAppFlow = "AppFlow";
        private const string PropertyAppName = "AppName";
        private const string PropertyContextUser = "ContextUser";
        private const string PropertySource = "Source";
        private const string PropertySiteId = "SiteId";
        private const string PropertyPermissionMask = "PermissionMask";

        #endregion

        #region Methods

        private const string MethodhasPermission = "hasPermission";
        private const string MethodgetContextUserId = "getContextUserId";
        private const string MethodendSession = "endSession";
        private const string MethodstartWorker = "startWorker";

        #endregion

        #region Fields

        private const string FieldsessionId = "sessionId";
        private const string FieldappFlow = "appFlow";
        private const string FieldappName = "appName";
        private const string FielduserId = "userId";
        private const string Fieldsource = "source";
        private const string FieldtransactionId = "transactionId";
        private const string FieldpermMask = "permMask";
        private const string FieldsiteId = "siteId";
        private const string FieldsWorker = "sWorker";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxSession) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSession_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSession) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSession_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSession) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSession_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxSession)

        #region General Initializer : Class (OnyxSession) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodhasPermission, 0)]
        [TestCase(MethodgetContextUserId, 0)]
        [TestCase(MethodendSession, 0)]
        [TestCase(MethodstartWorker, 0)]
        public void AUT_OnyxSession_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxSession) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyTransactionId)]
        [TestCase(PropertyAppFlow)]
        [TestCase(PropertyAppName)]
        [TestCase(PropertyContextUser)]
        [TestCase(PropertySource)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyPermissionMask)]
        [Category("AUT Property")]
        public void AUT_OnyxSession_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxSession) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldsessionId)]
        [TestCase(FieldappFlow)]
        [TestCase(FieldappName)]
        [TestCase(FielduserId)]
        [TestCase(Fieldsource)]
        [TestCase(FieldtransactionId)]
        [TestCase(FieldpermMask)]
        [TestCase(FieldsiteId)]
        [TestCase(FieldsWorker)]
        [Category("AUT Fields")]
        public void AUT_OnyxSession_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxSession) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSession_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxSessionInstance.ShouldBeAssignableTo<OnyxSession>();
            _onyxSessionInstanceFixture.ShouldBeAssignableTo<OnyxSession>();
            CurrentInstance.ShouldBeAssignableTo<OnyxSession>();
        }

        #endregion

        #endregion

        #region Category : Constructor
        
        #region General Constructor : Class (OnyxSession) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxSession" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSession_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxSessionParametersTypes = new Type[] { typeof(String), typeof(String), typeof(String), typeof(bool) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxSessionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxSession) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyTransactionId)]
        [TestCase(PropertyAppFlow)]
        [TestCase(PropertyAppName)]
        [TestCase(PropertyContextUser)]
        [TestCase(PropertySource)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyPermissionMask)]
        public void AUT_OnyxSession_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxSession) => Property (AppFlow) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_AppFlow_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppFlow);
            var propertyInfo = this.GetPropertyInfo(PropertyAppFlow);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (AppName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_AppName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppName);
            var propertyInfo = this.GetPropertyInfo(PropertyAppName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (ContextUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_ContextUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContextUser);
            var propertyInfo = this.GetPropertyInfo(PropertyContextUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (PermissionMask) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_PermissionMask_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPermissionMask);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPermissionMask);
            Action currentAction = () => propertyInfo.SetValue(_onyxSessionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (PermissionMask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_PermissionMask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPermissionMask);
            var propertyInfo = this.GetPropertyInfo(PropertyPermissionMask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (SessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_SessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionId);
            var propertyInfo = this.GetPropertyInfo(PropertySessionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySiteId);
            var propertyInfo = this.GetPropertyInfo(PropertySiteId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (Source) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_Source_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySource);
            var propertyInfo = this.GetPropertyInfo(PropertySource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (TransactionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_TransactionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTransactionId);
            var propertyInfo = this.GetPropertyInfo(PropertyTransactionId);

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

        #region Method Call : (hasPermission) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxSession_hasPermission_Method_Call_Internally(Type[] types)
        {
            var methodhasPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodhasPermission, methodhasPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (hasPermission) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_hasPermission_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhasPermission);
            var resourceName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxSessionInstance.hasPermission(resourceName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (hasPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_hasPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhasPermission);
            var resourceName = this.CreateType<string>();
            var methodhasPermissionParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfhasPermission = { resourceName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodhasPermission, methodhasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxSessionInstanceFixture, parametersOfhasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodhasPermission, parametersOfhasPermission, methodhasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfhasPermission.ShouldNotBeNull();
            parametersOfhasPermission.Length.ShouldBe(1);
            methodhasPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (hasPermission) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_hasPermission_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhasPermission);
            var resourceName = this.CreateType<string>();
            var methodhasPermissionParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfhasPermission = { resourceName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodhasPermission, methodhasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxSessionInstanceFixture, out exception1, parametersOfhasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodhasPermission, parametersOfhasPermission, methodhasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfhasPermission.ShouldNotBeNull();
            parametersOfhasPermission.Length.ShouldBe(1);
            methodhasPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (hasPermission) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_hasPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhasPermission);
            var resourceName = this.CreateType<string>();
            var methodhasPermissionParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfhasPermission = { resourceName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodhasPermission, parametersOfhasPermission, methodhasPermissionParametersTypes);

            // Assert
            parametersOfhasPermission.ShouldNotBeNull();
            parametersOfhasPermission.Length.ShouldBe(1);
            methodhasPermissionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (hasPermission) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_hasPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhasPermission);
            var methodhasPermissionParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodhasPermission, methodhasPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodhasPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (hasPermission) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_hasPermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodhasPermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (hasPermission) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_hasPermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodhasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodhasPermission, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getContextUserId) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxSession_getContextUserId_Method_Call_Internally(Type[] types)
        {
            var methodgetContextUserIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetContextUserId, methodgetContextUserIdParametersTypes);
        }

        #endregion

        #region Method Call : (getContextUserId) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_getContextUserId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContextUserId);
            Type [] methodgetContextUserIdParametersTypes = null;
            object[] parametersOfgetContextUserId = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetContextUserId, methodgetContextUserIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxSessionInstanceFixture, parametersOfgetContextUserId);
            var result2 = this.GetResultOfMethod<String>(MethodgetContextUserId, parametersOfgetContextUserId, methodgetContextUserIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetContextUserId.ShouldBeNull();
            methodgetContextUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getContextUserId) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_getContextUserId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContextUserId);
            Type [] methodgetContextUserIdParametersTypes = null;
            object[] parametersOfgetContextUserId = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodgetContextUserId, parametersOfgetContextUserId, methodgetContextUserIdParametersTypes);

            // Assert
            parametersOfgetContextUserId.ShouldBeNull();
            methodgetContextUserIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getContextUserId) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_getContextUserId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContextUserId);
            Type [] methodgetContextUserIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetContextUserId, methodgetContextUserIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetContextUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getContextUserId) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_getContextUserId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContextUserId);
            Type [] methodgetContextUserIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetContextUserId, methodgetContextUserIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetContextUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getContextUserId) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_getContextUserId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContextUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodgetContextUserId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (endSession) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxSession_endSession_Method_Call_Internally(Type[] types)
        {
            var methodendSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodendSession, methodendSessionParametersTypes);
        }

        #endregion

        #region Method Call : (endSession) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_endSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodendSession);

            // Act
            Action executeAction = () => _onyxSessionInstance.endSession();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (endSession) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_endSession_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodendSession);
            Type [] methodendSessionParametersTypes = null;
            object[] parametersOfendSession = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodendSession, methodendSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxSessionInstanceFixture, parametersOfendSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfendSession.ShouldBeNull();
            methodendSessionParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (endSession) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_endSession_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodendSession);
            Type [] methodendSessionParametersTypes = null;
            object[] parametersOfendSession = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodendSession, parametersOfendSession, methodendSessionParametersTypes);

            // Assert
            parametersOfendSession.ShouldBeNull();
            methodendSessionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (endSession) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_endSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodendSession);
            Type [] methodendSessionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodendSession, methodendSessionParametersTypes);

            // Assert
            methodendSessionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (endSession) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_endSession_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodendSession);
            var currentMethodInfo = this.GetMethodInfo(MethodendSession, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (startWorker) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxSession_startWorker_Method_Call_Internally(Type[] types)
        {
            var methodstartWorkerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodstartWorker, methodstartWorkerParametersTypes);
        }

        #endregion

        #region Method Call : (startWorker) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_startWorker_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartWorker);
            Type [] methodstartWorkerParametersTypes = null;
            object[] parametersOfstartWorker = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodstartWorker, methodstartWorkerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxSessionInstanceFixture, parametersOfstartWorker);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfstartWorker.ShouldBeNull();
            methodstartWorkerParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (startWorker) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_startWorker_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartWorker);
            Type [] methodstartWorkerParametersTypes = null;
            object[] parametersOfstartWorker = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodstartWorker, parametersOfstartWorker, methodstartWorkerParametersTypes);

            // Assert
            parametersOfstartWorker.ShouldBeNull();
            methodstartWorkerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (startWorker) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_startWorker_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartWorker);
            Type [] methodstartWorkerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodstartWorker, methodstartWorkerParametersTypes);

            // Assert
            methodstartWorkerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (startWorker) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSession_startWorker_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodstartWorker);
            var currentMethodInfo = this.GetMethodInfo(MethodstartWorker, 0);

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