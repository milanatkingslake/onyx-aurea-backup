using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;
using Exception = System.Exception;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Outlook = Microsoft.Office.Interop.Outlook;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.SessionSettings" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SessionSettingsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SessionSettings" />)
        /// </summary>
        public SessionSettingsTest() : base(typeof(SessionSettings))
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

        #region General Initializer : Class (SessionSettings) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _sessionSettingsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="SessionSettings" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _sessionSettingsInstanceType = typeof(SessionSettings);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SessionSettings) Initializer

        #region Properties

        private const string PropertyOnyxProfileId = "OnyxProfileId";
        private const string PropertyOnyx360ListsConfig = "Onyx360ListsConfig";
        private const string PropertyToolTipShowDelay = "ToolTipShowDelay";
        private const string PropertyAddinName = "AddinName";
        private const string PropertyOEP_LAUNCHER_URL = "OEP_LAUNCHER_URL";
        private const string PropertyAddinFontStyle = "AddinFontStyle";
        private const string PropertyCustomPaneInitialWidth = "CustomPaneInitialWidth";
        private const string PropertyOnyxDefaultUser = "OnyxDefaultUser";
        private const string PropertyOnyxDefaultProfileId = "OnyxDefaultProfileId";
        private const string PropertyOnyx360SyncDirDefault = "Onyx360SyncDirDefault";
        private const string PropertyCurrentOutlookVersion = "CurrentOutlookVersion";
        private const string PropertySessionErrorMessage = "SessionErrorMessage";
        private const string PropertyIsSessionExpired = "IsSessionExpired";
        private const string PropertyIsValidOnyxSession = "IsValidOnyxSession";
        private const string PropertyIsSessionParametersValid = "IsSessionParametersValid";
        private const string PropertyCurrentEmailDomain = "CurrentEmailDomain";
        private const string PropertyOnyxSession = "OnyxSession";
        private const string PropertyCurrentUserEmail = "CurrentUserEmail";
        private const string PropertyCurrentUserName = "CurrentUserName";
        private const string PropertyAddinLocalDataFolder = "AddinLocalDataFolder";
        private const string PropertyCurrentExecFolder = "CurrentExecFolder";

        #endregion

        #region Methods

        private const string MethodEncrypt = "Encrypt";
        private const string MethodIsBase64String = "IsBase64String";
        private const string MethodDecrypt = "Decrypt";
        private const string MethodInitSession = "InitSession";
        private const string MethodInitListsConfig = "InitListsConfig";
        private const string MethodGetCurrentAddressEntry = "GetCurrentAddressEntry";

        #endregion

        #region Fields

        private const string FieldonyxSession = "onyxSession";
        private const string FieldonyxProfileId = "onyxProfileId";
        private const string FieldisSessionCreationError = "isSessionCreationError";
        private const string FieldisSessionExpired = "isSessionExpired";
        private const string FieldsessionErrorMessage = "sessionErrorMessage";
        private const string FieldlistsConfig = "listsConfig";

        #endregion

        #endregion

        #region General Initializer : Class (SessionSettings) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SessionSettings" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SessionSettings_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SessionSettings) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SessionSettings" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SessionSettings_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SessionSettings) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SessionSettings" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SessionSettings_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SessionSettings)

        #region General Initializer : Class (SessionSettings) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SessionSettings" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEncrypt, 0)]
        [TestCase(MethodIsBase64String, 0)]
        [TestCase(MethodDecrypt, 0)]
        [TestCase(MethodInitSession, 0)]
        [TestCase(MethodInitListsConfig, 0)]
        [TestCase(MethodGetCurrentAddressEntry, 0)]
        public void AUT_SessionSettings_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SessionSettings) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SessionSettings" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxProfileId)]
        [TestCase(PropertyOnyx360ListsConfig)]
        [TestCase(PropertyToolTipShowDelay)]
        [TestCase(PropertyAddinName)]
        [TestCase(PropertyOEP_LAUNCHER_URL)]
        [TestCase(PropertyAddinFontStyle)]
        [TestCase(PropertyCustomPaneInitialWidth)]
        [TestCase(PropertyOnyxDefaultUser)]
        [TestCase(PropertyOnyxDefaultProfileId)]
        [TestCase(PropertyOnyx360SyncDirDefault)]
        [TestCase(PropertyCurrentOutlookVersion)]
        [TestCase(PropertySessionErrorMessage)]
        [TestCase(PropertyIsSessionExpired)]
        [TestCase(PropertyIsValidOnyxSession)]
        [TestCase(PropertyIsSessionParametersValid)]
        [TestCase(PropertyCurrentEmailDomain)]
        [TestCase(PropertyOnyxSession)]
        [TestCase(PropertyCurrentUserEmail)]
        [TestCase(PropertyCurrentUserName)]
        [TestCase(PropertyAddinLocalDataFolder)]
        [TestCase(PropertyCurrentExecFolder)]
        [Category("AUT Property")]
        public void AUT_SessionSettings_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SessionSettings) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SessionSettings" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldonyxSession)]
        [TestCase(FieldonyxProfileId)]
        [TestCase(FieldisSessionCreationError)]
        [TestCase(FieldisSessionExpired)]
        [TestCase(FieldsessionErrorMessage)]
        [TestCase(FieldlistsConfig)]
        [Category("AUT Fields")]
        public void AUT_SessionSettings_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SessionSettings) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SessionSettings" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SessionSettings_Is_Static_Type_Present_Test()
        {
            // Assert
            _sessionSettingsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Encrypt) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var plainText = this.CreateType<string>();

            // Act
            Action executeAction = () => SessionSettings.Encrypt(plainText);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var plainText = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SessionSettings.Encrypt(plainText);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var plainText = this.CreateType<string>();
            var methodEncryptParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfEncrypt = { plainText };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, methodEncryptParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodEncrypt, methodEncryptParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodEncrypt, parametersOfEncrypt, methodEncryptParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEncrypt.ShouldNotBeNull();
            parametersOfEncrypt.Length.ShouldBe(1);
            methodEncryptParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodEncrypt, parametersOfEncrypt, methodEncryptParametersTypes));
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var plainText = this.CreateType<string>();
            var methodEncryptParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfEncrypt = { plainText };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, methodEncryptParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfEncrypt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEncrypt.ShouldNotBeNull();
            parametersOfEncrypt.Length.ShouldBe(1);
            methodEncryptParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var plainText = this.CreateType<string>();
            var methodEncryptParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfEncrypt = { plainText };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEncrypt, parametersOfEncrypt, methodEncryptParametersTypes);

            // Assert
            parametersOfEncrypt.ShouldNotBeNull();
            parametersOfEncrypt.Length.ShouldBe(1);
            methodEncryptParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var methodEncryptParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEncrypt, methodEncryptParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEncryptParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var methodEncryptParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEncrypt, methodEncryptParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEncryptParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Encrypt_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SessionSettings_IsBase64String_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsBase64StringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsBase64String, methodIsBase64StringParametersTypes);
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_IsBase64String_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBase64String);
            var s = this.CreateType<string>();
            var methodIsBase64StringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsBase64String = { s };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsBase64String, methodIsBase64StringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsBase64String, methodIsBase64StringParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsBase64String, parametersOfIsBase64String, methodIsBase64StringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsBase64String.ShouldNotBeNull();
            parametersOfIsBase64String.Length.ShouldBe(1);
            methodIsBase64StringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsBase64String, parametersOfIsBase64String, methodIsBase64StringParametersTypes));
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_IsBase64String_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBase64String);
            var s = this.CreateType<string>();
            var methodIsBase64StringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsBase64String = { s };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsBase64String, methodIsBase64StringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfIsBase64String);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsBase64String.ShouldNotBeNull();
            parametersOfIsBase64String.Length.ShouldBe(1);
            methodIsBase64StringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_IsBase64String_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBase64String);
            var s = this.CreateType<string>();
            var methodIsBase64StringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsBase64String = { s };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsBase64String, parametersOfIsBase64String, methodIsBase64StringParametersTypes);

            // Assert
            parametersOfIsBase64String.ShouldNotBeNull();
            parametersOfIsBase64String.Length.ShouldBe(1);
            methodIsBase64StringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_IsBase64String_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBase64String);
            var methodIsBase64StringParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsBase64String, methodIsBase64StringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsBase64StringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_IsBase64String_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBase64String);
            var methodIsBase64StringParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsBase64String, methodIsBase64StringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsBase64StringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_IsBase64String_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBase64String);
            var methodIsBase64StringParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsBase64String, methodIsBase64StringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsBase64StringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_IsBase64String_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBase64String);
            var currentMethodInfo = this.GetMethodInfo(MethodIsBase64String, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsBase64String) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_IsBase64String_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBase64String);
            var currentMethodInfo = this.GetMethodInfo(MethodIsBase64String, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SessionSettings_Decrypt_Static_Method_Call_Internally(Type[] types)
        {
            var methodDecryptParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDecrypt, methodDecryptParametersTypes);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var cipher = this.CreateType<string>();

            // Act
            Action executeAction = () => SessionSettings.Decrypt(cipher);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var cipher = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SessionSettings.Decrypt(cipher);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var cipher = this.CreateType<string>();
            var methodDecryptParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecrypt = { cipher };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDecrypt, methodDecryptParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDecrypt, methodDecryptParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodDecrypt, parametersOfDecrypt, methodDecryptParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDecrypt.ShouldNotBeNull();
            parametersOfDecrypt.Length.ShouldBe(1);
            methodDecryptParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodDecrypt, parametersOfDecrypt, methodDecryptParametersTypes));
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var cipher = this.CreateType<string>();
            var methodDecryptParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecrypt = { cipher };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDecrypt, methodDecryptParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfDecrypt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDecrypt.ShouldNotBeNull();
            parametersOfDecrypt.Length.ShouldBe(1);
            methodDecryptParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var cipher = this.CreateType<string>();
            var methodDecryptParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecrypt = { cipher };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDecrypt, parametersOfDecrypt, methodDecryptParametersTypes);

            // Assert
            parametersOfDecrypt.ShouldNotBeNull();
            parametersOfDecrypt.Length.ShouldBe(1);
            methodDecryptParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var methodDecryptParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDecrypt, methodDecryptParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDecryptParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var methodDecryptParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDecrypt, methodDecryptParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDecryptParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var currentMethodInfo = this.GetMethodInfo(MethodDecrypt, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_Decrypt_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var currentMethodInfo = this.GetMethodInfo(MethodDecrypt, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InitSession) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SessionSettings_InitSession_Static_Method_Call_Internally(Type[] types)
        {
            var methodInitSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitSession, methodInitSessionParametersTypes);
        }

        #endregion

        #region Method Call : (InitSession) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitSession_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitSession);
            var keepSessionAlive = this.CreateType<bool>();

            // Act
            Action executeAction = () => SessionSettings.InitSession(keepSessionAlive);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InitSession) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitSession_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitSession);
            var keepSessionAlive = this.CreateType<bool>();
            var methodInitSessionParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfInitSession = { keepSessionAlive };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitSession, methodInitSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfInitSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitSession.ShouldNotBeNull();
            parametersOfInitSession.Length.ShouldBe(1);
            methodInitSessionParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitSession) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitSession_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitSession);
            var keepSessionAlive = this.CreateType<bool>();
            var methodInitSessionParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfInitSession = { keepSessionAlive };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitSession, parametersOfInitSession, methodInitSessionParametersTypes);

            // Assert
            parametersOfInitSession.ShouldNotBeNull();
            parametersOfInitSession.Length.ShouldBe(1);
            methodInitSessionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitSession) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitSession_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitSession);
            var currentMethodInfo = this.GetMethodInfo(MethodInitSession, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InitSession) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitSession_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitSession);
            var methodInitSessionParametersTypes = new Type[] { typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitSession, methodInitSessionParametersTypes);

            // Assert
            methodInitSessionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitSession) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitSession_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitSession);
            var currentMethodInfo = this.GetMethodInfo(MethodInitSession, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitListsConfig) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SessionSettings_InitListsConfig_Static_Method_Call_Internally(Type[] types)
        {
            var methodInitListsConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitListsConfig, methodInitListsConfigParametersTypes);
        }

        #endregion

        #region Method Call : (InitListsConfig) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitListsConfig_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitListsConfig);

            // Act
            Action executeAction = () => SessionSettings.InitListsConfig();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InitListsConfig) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitListsConfig_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitListsConfig);
            Type [] methodInitListsConfigParametersTypes = null;
            object[] parametersOfInitListsConfig = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitListsConfig, methodInitListsConfigParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfInitListsConfig);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitListsConfig.ShouldBeNull();
            methodInitListsConfigParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitListsConfig) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitListsConfig_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitListsConfig);
            Type [] methodInitListsConfigParametersTypes = null;
            object[] parametersOfInitListsConfig = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitListsConfig, parametersOfInitListsConfig, methodInitListsConfigParametersTypes);

            // Assert
            parametersOfInitListsConfig.ShouldBeNull();
            methodInitListsConfigParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitListsConfig) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitListsConfig_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitListsConfig);
            Type [] methodInitListsConfigParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitListsConfig, methodInitListsConfigParametersTypes);

            // Assert
            methodInitListsConfigParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitListsConfig) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_InitListsConfig_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitListsConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodInitListsConfig, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentAddressEntry) (Return Type : Outlook.AddressEntry) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SessionSettings_GetCurrentAddressEntry_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentAddressEntryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentAddressEntry, methodGetCurrentAddressEntryParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentAddressEntry) (Return Type : Outlook.AddressEntry) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_GetCurrentAddressEntry_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAddressEntry);

            // Act
            Action executeAction = () => SessionSettings.GetCurrentAddressEntry();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentAddressEntry) (Return Type : Outlook.AddressEntry) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_GetCurrentAddressEntry_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAddressEntry);
            var returnedValue = default(Outlook.AddressEntry);

            // Act
            Action executeAction = () => returnedValue = SessionSettings.GetCurrentAddressEntry();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentAddressEntry) (Return Type : Outlook.AddressEntry) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_GetCurrentAddressEntry_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAddressEntry);
            Type [] methodGetCurrentAddressEntryParametersTypes = null;
            object[] parametersOfGetCurrentAddressEntry = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentAddressEntry, methodGetCurrentAddressEntryParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCurrentAddressEntry, methodGetCurrentAddressEntryParametersTypes);
            var result2 = this.GetResultOfMethod<Outlook.AddressEntry>(MethodGetCurrentAddressEntry, parametersOfGetCurrentAddressEntry, methodGetCurrentAddressEntryParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCurrentAddressEntry);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentAddressEntry.ShouldBeNull();
            methodGetCurrentAddressEntryParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentAddressEntry) (Return Type : Outlook.AddressEntry) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_GetCurrentAddressEntry_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAddressEntry);
            Type [] methodGetCurrentAddressEntryParametersTypes = null;
            object[] parametersOfGetCurrentAddressEntry = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Outlook.AddressEntry>(MethodGetCurrentAddressEntry, parametersOfGetCurrentAddressEntry, methodGetCurrentAddressEntryParametersTypes);

            // Assert
            parametersOfGetCurrentAddressEntry.ShouldBeNull();
            methodGetCurrentAddressEntryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentAddressEntry) (Return Type : Outlook.AddressEntry) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_GetCurrentAddressEntry_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAddressEntry);
            Type [] methodGetCurrentAddressEntryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentAddressEntry, methodGetCurrentAddressEntryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentAddressEntryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentAddressEntry) (Return Type : Outlook.AddressEntry) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_GetCurrentAddressEntry_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAddressEntry);
            Type [] methodGetCurrentAddressEntryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentAddressEntry, methodGetCurrentAddressEntryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentAddressEntryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentAddressEntry) (Return Type : Outlook.AddressEntry) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SessionSettings_GetCurrentAddressEntry_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentAddressEntry);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentAddressEntry, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}