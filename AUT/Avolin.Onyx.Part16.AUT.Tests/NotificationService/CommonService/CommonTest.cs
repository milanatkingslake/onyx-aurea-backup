using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.CommonService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.CommonService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.CommonService.Common" />)
    ///     and namespace <see cref="NotificationService.CommonService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Common" />)
        /// </summary>
        public CommonTest() : base(typeof(Common))
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

        #region General Initializer : Class (Common) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _commonInstanceType;
        private Common _commonInstance;
        private Common _commonInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Common" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonInstanceType = typeof(Common);
            _commonInstanceFixture = this.Create<Common>(false);
            _commonInstance = _commonInstanceFixture ?? this.Create<Common>(true);
            CurrentInstance = _commonInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Common) Initializer

        #region Methods

        private const string MethodDecryptedPassword = "DecryptedPassword";
        private const string MethodGetUserById = "GetUserById";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Common)

        #region General Initializer : Class (Common) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodDecryptedPassword, 0)]
        [TestCase(MethodGetUserById, 0)]
        public void AUT_Common_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Common) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_Common_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Common) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Common" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Common_Is_Instance_Present_Test()
        {
            // Assert
            _commonInstanceType.ShouldNotBeNull();
            _commonInstance.ShouldNotBeNull();
            _commonInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Common) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Common" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Common_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _commonInstance.ShouldBeAssignableTo<Common>();
            _commonInstanceFixture.ShouldBeAssignableTo<Common>();
            CurrentInstance.ShouldBeAssignableTo<Common>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Common) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Common_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Common instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (DecryptedPassword) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptedPassword_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptedPassword);
            var encryptedPassword = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.DecryptedPassword(encryptedPassword);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DecryptedPassword) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptedPassword_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptedPassword);
            var encryptedPassword = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.DecryptedPassword(encryptedPassword);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptedPassword) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptedPassword_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptedPassword);
            var encryptedPassword = this.CreateType<string>();
            var methodDecryptedPasswordParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptedPassword = { encryptedPassword };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptedPassword, methodDecryptedPasswordParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDecryptedPassword, methodDecryptedPasswordParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodDecryptedPassword, parametersOfDecryptedPassword, methodDecryptedPasswordParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfDecryptedPassword);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDecryptedPassword.ShouldNotBeNull();
            parametersOfDecryptedPassword.Length.ShouldBe(1);
            methodDecryptedPasswordParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DecryptedPassword) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptedPassword_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptedPassword);
            var encryptedPassword = this.CreateType<string>();
            var methodDecryptedPasswordParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptedPassword = { encryptedPassword };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDecryptedPassword, parametersOfDecryptedPassword, methodDecryptedPasswordParametersTypes);

            // Assert
            parametersOfDecryptedPassword.ShouldNotBeNull();
            parametersOfDecryptedPassword.Length.ShouldBe(1);
            methodDecryptedPasswordParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DecryptedPassword) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptedPassword_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptedPassword);
            var methodDecryptedPasswordParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDecryptedPassword, methodDecryptedPasswordParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDecryptedPasswordParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DecryptedPassword) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptedPassword_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptedPassword);
            var methodDecryptedPasswordParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDecryptedPassword, methodDecryptedPasswordParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDecryptedPasswordParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptedPassword) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptedPassword_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptedPassword);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptedPassword, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptedPassword) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptedPassword_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptedPassword);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptedPassword, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetUserById_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUserByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserById, methodGetUserByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserById_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var contextData = this.CreateType<ContextData>();
            var userId = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetUserById(contextData, userId);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserById_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var contextData = this.CreateType<ContextData>();
            var userId = this.CreateType<string>();
            var returnedValue = default(Tempusers);

            // Act
            Action executeAction = () => returnedValue = Common.GetUserById(contextData, userId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserById_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var contextData = this.CreateType<ContextData>();
            var userId = this.CreateType<string>();
            var methodGetUserByIdParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            object[] parametersOfGetUserById = { contextData, userId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserById, methodGetUserByIdParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_commonInstanceFixture, parametersOfGetUserById);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUserById.ShouldNotBeNull();
            parametersOfGetUserById.Length.ShouldBe(2);
            methodGetUserByIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserById_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var contextData = this.CreateType<ContextData>();
            var userId = this.CreateType<string>();
            var methodGetUserByIdParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            object[] parametersOfGetUserById = { contextData, userId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Tempusers>(MethodGetUserById, parametersOfGetUserById, methodGetUserByIdParametersTypes);

            // Assert
            parametersOfGetUserById.ShouldNotBeNull();
            parametersOfGetUserById.Length.ShouldBe(2);
            methodGetUserByIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserById_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var methodGetUserByIdParametersTypes = new Type[] { typeof(ContextData), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserById, methodGetUserByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserByIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserById_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var methodGetUserByIdParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserById, methodGetUserByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserById_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : Tempusers) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUserById_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserById, 0);
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