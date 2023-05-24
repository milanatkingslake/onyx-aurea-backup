using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.UserPreferences" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class UserPreferencesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserPreferences" />)
        /// </summary>
        public UserPreferencesTest() : base(typeof(UserPreferences))
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

        #region General Initializer : Class (UserPreferences) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userPreferencesInstanceType;
        private UserPreferences _userPreferencesInstance;
        private UserPreferences _userPreferencesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserPreferences" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userPreferencesInstanceType = typeof(UserPreferences);
            _userPreferencesInstanceFixture = this.Create<UserPreferences>(false);
            _userPreferencesInstance = _userPreferencesInstanceFixture ?? this.Create<UserPreferences>(true);
            CurrentInstance = _userPreferencesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserPreferences) Initializer

        #region Methods

        private const string MethodpopulateControl = "populateControl";
        private const string MethodpopulateUserIdPwd = "populateUserIdPwd";
        private const string MethodpopulateProfile = "populateProfile";
        private const string MethodpopulateAddinPreferences = "populateAddinPreferences";
        private const string MethodpopulateSyncDirectionUserPreference = "populateSyncDirectionUserPreference";
        private const string MethodbtnUserOptionsSave_Click = "btnUserOptionsSave_Click";
        private const string MethodbtnUserOptionCancel_Click = "btnUserOptionCancel_Click";
        private const string MethodValidateForm = "ValidateForm";
        private const string MethodreportIssueLink_LinkClicked = "reportIssueLink_LinkClicked";
        private const string MethodopenLogLabel_LinkClicked = "openLogLabel_LinkClicked";
        private const string MethoduserPreferences_Load = "userPreferences_Load";

        #endregion

        #region Fields

        private const string FieldmsOutlookContactSyncDirectionPreviousValue = "msOutlookContactSyncDirectionPreviousValue";
        private const string FieldprevDisplayEmployeeVal = "prevDisplayEmployeeVal";

        #endregion

        #endregion

        #region General Initializer : Class (UserPreferences) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserPreferences_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserPreferences) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserPreferences_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserPreferences)

        #region General Initializer : Class (UserPreferences) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodpopulateControl, 0)]
        [TestCase(MethodpopulateUserIdPwd, 0)]
        [TestCase(MethodpopulateProfile, 0)]
        [TestCase(MethodpopulateAddinPreferences, 0)]
        [TestCase(MethodpopulateSyncDirectionUserPreference, 0)]
        [TestCase(MethodbtnUserOptionsSave_Click, 0)]
        [TestCase(MethodbtnUserOptionCancel_Click, 0)]
        [TestCase(MethodValidateForm, 0)]
        [TestCase(MethodreportIssueLink_LinkClicked, 0)]
        [TestCase(MethodopenLogLabel_LinkClicked, 0)]
        [TestCase(MethoduserPreferences_Load, 0)]
        public void AUT_UserPreferences_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (UserPreferences) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldmsOutlookContactSyncDirectionPreviousValue)]
        [TestCase(FieldprevDisplayEmployeeVal)]
        [Category("AUT Fields")]
        public void AUT_UserPreferences_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UserPreferences) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserPreferences" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserPreferences_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userPreferencesInstance.ShouldBeAssignableTo<UserPreferences>();
            _userPreferencesInstanceFixture.ShouldBeAssignableTo<UserPreferences>();
            CurrentInstance.ShouldBeAssignableTo<UserPreferences>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (populateControl) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateControl_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControl);
            Type [] methodpopulateControlParametersTypes = null;
            object[] parametersOfpopulateControl = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateControl, methodpopulateControlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfpopulateControl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateControl.ShouldBeNull();
            methodpopulateControlParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateControl) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateControl_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControl);
            Type [] methodpopulateControlParametersTypes = null;
            object[] parametersOfpopulateControl = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateControl, parametersOfpopulateControl, methodpopulateControlParametersTypes);

            // Assert
            parametersOfpopulateControl.ShouldBeNull();
            methodpopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateControl) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateControl_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControl);
            Type [] methodpopulateControlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateControl, methodpopulateControlParametersTypes);

            // Assert
            methodpopulateControlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateControl) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateControl_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateControl);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateControl, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateUserIdPwd) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_populateUserIdPwd_Method_Call_Internally(Type[] types)
        {
            var methodpopulateUserIdPwdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpopulateUserIdPwd, methodpopulateUserIdPwdParametersTypes);
        }

        #endregion

        #region Method Call : (populateUserIdPwd) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateUserIdPwd_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateUserIdPwd);
            Type [] methodpopulateUserIdPwdParametersTypes = null;
            object[] parametersOfpopulateUserIdPwd = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateUserIdPwd, methodpopulateUserIdPwdParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfpopulateUserIdPwd);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateUserIdPwd.ShouldBeNull();
            methodpopulateUserIdPwdParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateUserIdPwd) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateUserIdPwd_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateUserIdPwd);
            Type [] methodpopulateUserIdPwdParametersTypes = null;
            object[] parametersOfpopulateUserIdPwd = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateUserIdPwd, parametersOfpopulateUserIdPwd, methodpopulateUserIdPwdParametersTypes);

            // Assert
            parametersOfpopulateUserIdPwd.ShouldBeNull();
            methodpopulateUserIdPwdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateUserIdPwd) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateUserIdPwd_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateUserIdPwd);
            Type [] methodpopulateUserIdPwdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateUserIdPwd, methodpopulateUserIdPwdParametersTypes);

            // Assert
            methodpopulateUserIdPwdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateUserIdPwd) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateUserIdPwd_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateUserIdPwd);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateUserIdPwd, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateProfile) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_populateProfile_Method_Call_Internally(Type[] types)
        {
            var methodpopulateProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpopulateProfile, methodpopulateProfileParametersTypes);
        }

        #endregion

        #region Method Call : (populateProfile) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateProfile);
            Type [] methodpopulateProfileParametersTypes = null;
            object[] parametersOfpopulateProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateProfile, methodpopulateProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_userPreferencesInstanceFixture, parametersOfpopulateProfile);
            var result2 = this.GetResultOfMethod<int>(MethodpopulateProfile, parametersOfpopulateProfile, methodpopulateProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfpopulateProfile.ShouldBeNull();
            methodpopulateProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (populateProfile) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateProfile_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateProfile);
            Type [] methodpopulateProfileParametersTypes = null;
            object[] parametersOfpopulateProfile = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateProfile, methodpopulateProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_userPreferencesInstanceFixture, out exception1, parametersOfpopulateProfile);
            var result2 = this.GetResultOfMethod<int>(MethodpopulateProfile, parametersOfpopulateProfile, methodpopulateProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfpopulateProfile.ShouldBeNull();
            methodpopulateProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (populateProfile) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateProfile);
            Type [] methodpopulateProfileParametersTypes = null;
            object[] parametersOfpopulateProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodpopulateProfile, parametersOfpopulateProfile, methodpopulateProfileParametersTypes);

            // Assert
            parametersOfpopulateProfile.ShouldBeNull();
            methodpopulateProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateProfile) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateProfile);
            Type [] methodpopulateProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateProfile, methodpopulateProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodpopulateProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (populateProfile) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (populateAddinPreferences) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_populateAddinPreferences_Method_Call_Internally(Type[] types)
        {
            var methodpopulateAddinPreferencesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpopulateAddinPreferences, methodpopulateAddinPreferencesParametersTypes);
        }

        #endregion

        #region Method Call : (populateAddinPreferences) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateAddinPreferences_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateAddinPreferences);
            Type [] methodpopulateAddinPreferencesParametersTypes = null;
            object[] parametersOfpopulateAddinPreferences = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateAddinPreferences, methodpopulateAddinPreferencesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfpopulateAddinPreferences);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateAddinPreferences.ShouldBeNull();
            methodpopulateAddinPreferencesParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateAddinPreferences) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateAddinPreferences_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateAddinPreferences);
            Type [] methodpopulateAddinPreferencesParametersTypes = null;
            object[] parametersOfpopulateAddinPreferences = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateAddinPreferences, parametersOfpopulateAddinPreferences, methodpopulateAddinPreferencesParametersTypes);

            // Assert
            parametersOfpopulateAddinPreferences.ShouldBeNull();
            methodpopulateAddinPreferencesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateAddinPreferences) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateAddinPreferences_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateAddinPreferences);
            Type [] methodpopulateAddinPreferencesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateAddinPreferences, methodpopulateAddinPreferencesParametersTypes);

            // Assert
            methodpopulateAddinPreferencesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateAddinPreferences) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateAddinPreferences_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateAddinPreferences);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateAddinPreferences, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateSyncDirectionUserPreference) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_populateSyncDirectionUserPreference_Method_Call_Internally(Type[] types)
        {
            var methodpopulateSyncDirectionUserPreferenceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpopulateSyncDirectionUserPreference, methodpopulateSyncDirectionUserPreferenceParametersTypes);
        }

        #endregion

        #region Method Call : (populateSyncDirectionUserPreference) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateSyncDirectionUserPreference_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateSyncDirectionUserPreference);
            Type [] methodpopulateSyncDirectionUserPreferenceParametersTypes = null;
            object[] parametersOfpopulateSyncDirectionUserPreference = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateSyncDirectionUserPreference, methodpopulateSyncDirectionUserPreferenceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfpopulateSyncDirectionUserPreference);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpopulateSyncDirectionUserPreference.ShouldBeNull();
            methodpopulateSyncDirectionUserPreferenceParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (populateSyncDirectionUserPreference) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateSyncDirectionUserPreference_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateSyncDirectionUserPreference);
            Type [] methodpopulateSyncDirectionUserPreferenceParametersTypes = null;
            object[] parametersOfpopulateSyncDirectionUserPreference = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodpopulateSyncDirectionUserPreference, parametersOfpopulateSyncDirectionUserPreference, methodpopulateSyncDirectionUserPreferenceParametersTypes);

            // Assert
            parametersOfpopulateSyncDirectionUserPreference.ShouldBeNull();
            methodpopulateSyncDirectionUserPreferenceParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateSyncDirectionUserPreference) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateSyncDirectionUserPreference_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateSyncDirectionUserPreference);
            Type [] methodpopulateSyncDirectionUserPreferenceParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpopulateSyncDirectionUserPreference, methodpopulateSyncDirectionUserPreferenceParametersTypes);

            // Assert
            methodpopulateSyncDirectionUserPreferenceParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (populateSyncDirectionUserPreference) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_populateSyncDirectionUserPreference_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpopulateSyncDirectionUserPreference);
            var currentMethodInfo = this.GetMethodInfo(MethodpopulateSyncDirectionUserPreference, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (btnUserOptionsSave_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_btnUserOptionsSave_Click_Method_Call_Internally(Type[] types)
        {
            var methodbtnUserOptionsSave_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbtnUserOptionsSave_Click, methodbtnUserOptionsSave_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (btnUserOptionsSave_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionsSave_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionsSave_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbtnUserOptionsSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbtnUserOptionsSave_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbtnUserOptionsSave_Click, methodbtnUserOptionsSave_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfbtnUserOptionsSave_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbtnUserOptionsSave_Click.ShouldNotBeNull();
            parametersOfbtnUserOptionsSave_Click.Length.ShouldBe(2);
            methodbtnUserOptionsSave_ClickParametersTypes.Length.ShouldBe(2);
            methodbtnUserOptionsSave_ClickParametersTypes.Length.ShouldBe(parametersOfbtnUserOptionsSave_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (btnUserOptionsSave_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionsSave_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionsSave_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbtnUserOptionsSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbtnUserOptionsSave_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbtnUserOptionsSave_Click, parametersOfbtnUserOptionsSave_Click, methodbtnUserOptionsSave_ClickParametersTypes);

            // Assert
            parametersOfbtnUserOptionsSave_Click.ShouldNotBeNull();
            parametersOfbtnUserOptionsSave_Click.Length.ShouldBe(2);
            methodbtnUserOptionsSave_ClickParametersTypes.Length.ShouldBe(2);
            methodbtnUserOptionsSave_ClickParametersTypes.Length.ShouldBe(parametersOfbtnUserOptionsSave_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (btnUserOptionsSave_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionsSave_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionsSave_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbtnUserOptionsSave_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (btnUserOptionsSave_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionsSave_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionsSave_Click);
            var methodbtnUserOptionsSave_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbtnUserOptionsSave_Click, methodbtnUserOptionsSave_ClickParametersTypes);

            // Assert
            methodbtnUserOptionsSave_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (btnUserOptionsSave_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionsSave_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionsSave_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbtnUserOptionsSave_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (btnUserOptionCancel_Click) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_btnUserOptionCancel_Click_Method_Call_Internally(Type[] types)
        {
            var methodbtnUserOptionCancel_ClickParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodbtnUserOptionCancel_Click, methodbtnUserOptionCancel_ClickParametersTypes);
        }

        #endregion

        #region Method Call : (btnUserOptionCancel_Click) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionCancel_Click_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionCancel_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbtnUserOptionCancel_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbtnUserOptionCancel_Click = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodbtnUserOptionCancel_Click, methodbtnUserOptionCancel_ClickParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfbtnUserOptionCancel_Click);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfbtnUserOptionCancel_Click.ShouldNotBeNull();
            parametersOfbtnUserOptionCancel_Click.Length.ShouldBe(2);
            methodbtnUserOptionCancel_ClickParametersTypes.Length.ShouldBe(2);
            methodbtnUserOptionCancel_ClickParametersTypes.Length.ShouldBe(parametersOfbtnUserOptionCancel_Click.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (btnUserOptionCancel_Click) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionCancel_Click_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionCancel_Click);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methodbtnUserOptionCancel_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfbtnUserOptionCancel_Click = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodbtnUserOptionCancel_Click, parametersOfbtnUserOptionCancel_Click, methodbtnUserOptionCancel_ClickParametersTypes);

            // Assert
            parametersOfbtnUserOptionCancel_Click.ShouldNotBeNull();
            parametersOfbtnUserOptionCancel_Click.Length.ShouldBe(2);
            methodbtnUserOptionCancel_ClickParametersTypes.Length.ShouldBe(2);
            methodbtnUserOptionCancel_ClickParametersTypes.Length.ShouldBe(parametersOfbtnUserOptionCancel_Click.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (btnUserOptionCancel_Click) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionCancel_Click_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionCancel_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbtnUserOptionCancel_Click, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (btnUserOptionCancel_Click) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionCancel_Click_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionCancel_Click);
            var methodbtnUserOptionCancel_ClickParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodbtnUserOptionCancel_Click, methodbtnUserOptionCancel_ClickParametersTypes);

            // Assert
            methodbtnUserOptionCancel_ClickParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (btnUserOptionCancel_Click) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_btnUserOptionCancel_Click_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodbtnUserOptionCancel_Click);
            var currentMethodInfo = this.GetMethodInfo(MethodbtnUserOptionCancel_Click, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateForm) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_ValidateForm_Method_Call_Internally(Type[] types)
        {
            var methodValidateFormParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateForm, methodValidateFormParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateForm) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_ValidateForm_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForm);

            // Act
            Action executeAction = () => _userPreferencesInstance.ValidateForm();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ValidateForm) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_ValidateForm_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForm);
            Type [] methodValidateFormParametersTypes = null;
            object[] parametersOfValidateForm = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateForm, methodValidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_userPreferencesInstanceFixture, parametersOfValidateForm);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateForm, parametersOfValidateForm, methodValidateFormParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateForm.ShouldBeNull();
            methodValidateFormParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateForm) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_ValidateForm_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForm);
            Type [] methodValidateFormParametersTypes = null;
            object[] parametersOfValidateForm = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateForm, methodValidateFormParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_userPreferencesInstanceFixture, out exception1, parametersOfValidateForm);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateForm, parametersOfValidateForm, methodValidateFormParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateForm.ShouldBeNull();
            methodValidateFormParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateForm) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_ValidateForm_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForm);
            Type [] methodValidateFormParametersTypes = null;
            object[] parametersOfValidateForm = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodValidateForm, parametersOfValidateForm, methodValidateFormParametersTypes);

            // Assert
            parametersOfValidateForm.ShouldBeNull();
            methodValidateFormParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateForm) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_ValidateForm_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForm);
            Type [] methodValidateFormParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateForm, methodValidateFormParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateFormParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateForm) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_ValidateForm_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForm);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateForm, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (reportIssueLink_LinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_reportIssueLink_LinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodreportIssueLink_LinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodreportIssueLink_LinkClicked, methodreportIssueLink_LinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (reportIssueLink_LinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_reportIssueLink_LinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreportIssueLink_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodreportIssueLink_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfreportIssueLink_LinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodreportIssueLink_LinkClicked, methodreportIssueLink_LinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfreportIssueLink_LinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfreportIssueLink_LinkClicked.ShouldNotBeNull();
            parametersOfreportIssueLink_LinkClicked.Length.ShouldBe(2);
            methodreportIssueLink_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodreportIssueLink_LinkClickedParametersTypes.Length.ShouldBe(parametersOfreportIssueLink_LinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (reportIssueLink_LinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_reportIssueLink_LinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreportIssueLink_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodreportIssueLink_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfreportIssueLink_LinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodreportIssueLink_LinkClicked, parametersOfreportIssueLink_LinkClicked, methodreportIssueLink_LinkClickedParametersTypes);

            // Assert
            parametersOfreportIssueLink_LinkClicked.ShouldNotBeNull();
            parametersOfreportIssueLink_LinkClicked.Length.ShouldBe(2);
            methodreportIssueLink_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodreportIssueLink_LinkClickedParametersTypes.Length.ShouldBe(parametersOfreportIssueLink_LinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (reportIssueLink_LinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_reportIssueLink_LinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreportIssueLink_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodreportIssueLink_LinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (reportIssueLink_LinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_reportIssueLink_LinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreportIssueLink_LinkClicked);
            var methodreportIssueLink_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodreportIssueLink_LinkClicked, methodreportIssueLink_LinkClickedParametersTypes);

            // Assert
            methodreportIssueLink_LinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (reportIssueLink_LinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_reportIssueLink_LinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodreportIssueLink_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodreportIssueLink_LinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (openLogLabel_LinkClicked) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_openLogLabel_LinkClicked_Method_Call_Internally(Type[] types)
        {
            var methodopenLogLabel_LinkClickedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodopenLogLabel_LinkClicked, methodopenLogLabel_LinkClickedParametersTypes);
        }

        #endregion

        #region Method Call : (openLogLabel_LinkClicked) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_openLogLabel_LinkClicked_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodopenLogLabel_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodopenLogLabel_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfopenLogLabel_LinkClicked = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodopenLogLabel_LinkClicked, methodopenLogLabel_LinkClickedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfopenLogLabel_LinkClicked);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfopenLogLabel_LinkClicked.ShouldNotBeNull();
            parametersOfopenLogLabel_LinkClicked.Length.ShouldBe(2);
            methodopenLogLabel_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodopenLogLabel_LinkClickedParametersTypes.Length.ShouldBe(parametersOfopenLogLabel_LinkClicked.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (openLogLabel_LinkClicked) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_openLogLabel_LinkClicked_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodopenLogLabel_LinkClicked);
            var sender = this.CreateType<object>();
            var e = this.CreateType<LinkLabelLinkClickedEventArgs>();
            var methodopenLogLabel_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };
            object[] parametersOfopenLogLabel_LinkClicked = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodopenLogLabel_LinkClicked, parametersOfopenLogLabel_LinkClicked, methodopenLogLabel_LinkClickedParametersTypes);

            // Assert
            parametersOfopenLogLabel_LinkClicked.ShouldNotBeNull();
            parametersOfopenLogLabel_LinkClicked.Length.ShouldBe(2);
            methodopenLogLabel_LinkClickedParametersTypes.Length.ShouldBe(2);
            methodopenLogLabel_LinkClickedParametersTypes.Length.ShouldBe(parametersOfopenLogLabel_LinkClicked.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (openLogLabel_LinkClicked) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_openLogLabel_LinkClicked_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodopenLogLabel_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodopenLogLabel_LinkClicked, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (openLogLabel_LinkClicked) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_openLogLabel_LinkClicked_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodopenLogLabel_LinkClicked);
            var methodopenLogLabel_LinkClickedParametersTypes = new Type[] { typeof(object), typeof(LinkLabelLinkClickedEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodopenLogLabel_LinkClicked, methodopenLogLabel_LinkClickedParametersTypes);

            // Assert
            methodopenLogLabel_LinkClickedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (openLogLabel_LinkClicked) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_openLogLabel_LinkClicked_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodopenLogLabel_LinkClicked);
            var currentMethodInfo = this.GetMethodInfo(MethodopenLogLabel_LinkClicked, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (userPreferences_Load) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserPreferences_userPreferences_Load_Method_Call_Internally(Type[] types)
        {
            var methoduserPreferences_LoadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethoduserPreferences_Load, methoduserPreferences_LoadParametersTypes);
        }

        #endregion

        #region Method Call : (userPreferences_Load) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_userPreferences_Load_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoduserPreferences_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methoduserPreferences_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfuserPreferences_Load = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethoduserPreferences_Load, methoduserPreferences_LoadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userPreferencesInstanceFixture, parametersOfuserPreferences_Load);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfuserPreferences_Load.ShouldNotBeNull();
            parametersOfuserPreferences_Load.Length.ShouldBe(2);
            methoduserPreferences_LoadParametersTypes.Length.ShouldBe(2);
            methoduserPreferences_LoadParametersTypes.Length.ShouldBe(parametersOfuserPreferences_Load.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (userPreferences_Load) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_userPreferences_Load_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoduserPreferences_Load);
            var sender = this.CreateType<object>();
            var e = this.CreateType<EventArgs>();
            var methoduserPreferences_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };
            object[] parametersOfuserPreferences_Load = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethoduserPreferences_Load, parametersOfuserPreferences_Load, methoduserPreferences_LoadParametersTypes);

            // Assert
            parametersOfuserPreferences_Load.ShouldNotBeNull();
            parametersOfuserPreferences_Load.Length.ShouldBe(2);
            methoduserPreferences_LoadParametersTypes.Length.ShouldBe(2);
            methoduserPreferences_LoadParametersTypes.Length.ShouldBe(parametersOfuserPreferences_Load.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (userPreferences_Load) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_userPreferences_Load_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoduserPreferences_Load);
            var currentMethodInfo = this.GetMethodInfo(MethoduserPreferences_Load, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (userPreferences_Load) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_userPreferences_Load_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoduserPreferences_Load);
            var methoduserPreferences_LoadParametersTypes = new Type[] { typeof(object), typeof(EventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethoduserPreferences_Load, methoduserPreferences_LoadParametersTypes);

            // Assert
            methoduserPreferences_LoadParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (userPreferences_Load) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserPreferences_userPreferences_Load_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoduserPreferences_Load);
            var currentMethodInfo = this.GetMethodInfo(MethoduserPreferences_Load, 0);

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