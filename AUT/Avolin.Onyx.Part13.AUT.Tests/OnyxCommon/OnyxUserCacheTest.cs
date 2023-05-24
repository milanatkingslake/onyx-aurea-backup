using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxUserCache" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxUserCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxUserCache" />)
        /// </summary>
        public OnyxUserCacheTest() : base(typeof(OnyxUserCache))
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

        #region General Initializer : Class (OnyxUserCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxUserCacheInstanceType;
        private OnyxUserCache _onyxUserCacheInstance;
        private OnyxUserCache _onyxUserCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxUserCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxUserCacheInstanceType = typeof(OnyxUserCache);
            _onyxUserCacheInstanceFixture = this.Create<OnyxUserCache>(false);
            _onyxUserCacheInstance = _onyxUserCacheInstanceFixture ?? this.Create<OnyxUserCache>(true);
            CurrentInstance = _onyxUserCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxUserCache) Initializer

        #region Methods

        private const string MethodLookupUser = "LookupUser";
        private const string MethodAddUser = "AddUser";

        #endregion

        #region Fields

        private const string FieldOnyxUsersDict = "OnyxUsersDict";
        private const string FieldloadLock = "loadLock";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxUserCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxUserCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxUserCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxUserCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxUserCache)

        #region General Initializer : Class (OnyxUserCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxUserCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLookupUser, 0)]
        [TestCase(MethodAddUser, 0)]
        public void AUT_OnyxUserCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxUserCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxUserCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldOnyxUsersDict)]
        [TestCase(FieldloadLock)]
        [Category("AUT Fields")]
        public void AUT_OnyxUserCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxUserCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxUserCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxUserCache_Is_Instance_Present_Test()
        {
            // Assert
            _onyxUserCacheInstanceType.ShouldNotBeNull();
            _onyxUserCacheInstance.ShouldNotBeNull();
            _onyxUserCacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxUserCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxUserCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxUserCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxUserCacheInstance.ShouldBeAssignableTo<OnyxUserCache>();
            _onyxUserCacheInstanceFixture.ShouldBeAssignableTo<OnyxUserCache>();
            CurrentInstance.ShouldBeAssignableTo<OnyxUserCache>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxUserCache) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxUserCache_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxUserCache instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (LookupUser) (Return Type : OnyxUser) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_LookupUser_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLookupUser);
            var userId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxUserCacheInstance.LookupUser(userId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LookupUser) (Return Type : OnyxUser) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_LookupUser_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLookupUser);
            var userId = this.CreateType<string>();
            var returnedValue = default(OnyxUser);

            // Act
            Action executeAction = () => returnedValue = _onyxUserCacheInstance.LookupUser(userId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LookupUser) (Return Type : OnyxUser) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_LookupUser_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLookupUser);
            var userId = this.CreateType<string>();
            var methodLookupUserParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfLookupUser = { userId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLookupUser, methodLookupUserParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxUser>(_onyxUserCacheInstanceFixture, parametersOfLookupUser);
            var result2 = this.GetResultOfMethod<OnyxUser>(MethodLookupUser, parametersOfLookupUser, methodLookupUserParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfLookupUser.ShouldNotBeNull();
            parametersOfLookupUser.Length.ShouldBe(1);
            methodLookupUserParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (LookupUser) (Return Type : OnyxUser) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_LookupUser_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLookupUser);
            var userId = this.CreateType<string>();
            var methodLookupUserParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfLookupUser = { userId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxUser>(MethodLookupUser, parametersOfLookupUser, methodLookupUserParametersTypes);

            // Assert
            parametersOfLookupUser.ShouldNotBeNull();
            parametersOfLookupUser.Length.ShouldBe(1);
            methodLookupUserParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LookupUser) (Return Type : OnyxUser) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_LookupUser_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLookupUser);
            var methodLookupUserParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLookupUser, methodLookupUserParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodLookupUserParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (LookupUser) (Return Type : OnyxUser) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_LookupUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLookupUser);
            var methodLookupUserParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLookupUser, methodLookupUserParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLookupUserParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LookupUser) (Return Type : OnyxUser) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_LookupUser_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLookupUser);
            var currentMethodInfo = this.GetMethodInfo(MethodLookupUser, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LookupUser) (Return Type : OnyxUser) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_LookupUser_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLookupUser);
            var currentMethodInfo = this.GetMethodInfo(MethodLookupUser, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddUser) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserCache_AddUser_Method_Call_Internally(Type[] types)
        {
            var methodAddUserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddUser, methodAddUserParametersTypes);
        }

        #endregion

        #region Method Call : (AddUser) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_AddUser_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUser);
            var user = this.CreateType<OnyxUser>();

            // Act
            Action executeAction = () => _onyxUserCacheInstance.AddUser(user);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddUser) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_AddUser_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUser);
            var user = this.CreateType<OnyxUser>();
            var methodAddUserParametersTypes = new Type[] { typeof(OnyxUser) };
            object[] parametersOfAddUser = { user };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddUser, methodAddUserParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxUserCacheInstanceFixture, parametersOfAddUser);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddUser.ShouldNotBeNull();
            parametersOfAddUser.Length.ShouldBe(1);
            methodAddUserParametersTypes.Length.ShouldBe(1);
            methodAddUserParametersTypes.Length.ShouldBe(parametersOfAddUser.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddUser) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_AddUser_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUser);
            var user = this.CreateType<OnyxUser>();
            var methodAddUserParametersTypes = new Type[] { typeof(OnyxUser) };
            object[] parametersOfAddUser = { user };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddUser, parametersOfAddUser, methodAddUserParametersTypes);

            // Assert
            parametersOfAddUser.ShouldNotBeNull();
            parametersOfAddUser.Length.ShouldBe(1);
            methodAddUserParametersTypes.Length.ShouldBe(1);
            methodAddUserParametersTypes.Length.ShouldBe(parametersOfAddUser.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddUser) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_AddUser_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUser);
            var currentMethodInfo = this.GetMethodInfo(MethodAddUser, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddUser) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_AddUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUser);
            var methodAddUserParametersTypes = new Type[] { typeof(OnyxUser) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddUser, methodAddUserParametersTypes);

            // Assert
            methodAddUserParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddUser) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserCache_AddUser_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddUser);
            var currentMethodInfo = this.GetMethodInfo(MethodAddUser, 0);

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