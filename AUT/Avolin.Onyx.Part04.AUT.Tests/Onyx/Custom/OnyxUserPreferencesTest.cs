using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.OnyxUserPreferences" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxUserPreferencesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxUserPreferences" />)
        /// </summary>
        public OnyxUserPreferencesTest() : base(typeof(OnyxUserPreferences))
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

        #region General Initializer : Class (OnyxUserPreferences) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxUserPreferencesInstanceType;
        private OnyxUserPreferences _onyxUserPreferencesInstance;
        private OnyxUserPreferences _onyxUserPreferencesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxUserPreferences" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxUserPreferencesInstanceType = typeof(OnyxUserPreferences);
            _onyxUserPreferencesInstanceFixture = this.Create<OnyxUserPreferences>(false);
            _onyxUserPreferencesInstance = _onyxUserPreferencesInstanceFixture ?? this.Create<OnyxUserPreferences>(true);
            CurrentInstance = _onyxUserPreferencesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxUserPreferences) Initializer

        #region Properties

        private const string PropertyUserPrefDictKey = "UserPrefDictKey";

        #endregion

        #region Methods

        private const string MethodgetUserPreferences = "getUserPreferences";
        private const string MethodgetPreferenceValue = "getPreferenceValue";
        private const string MethodsavePreferenceValue = "savePreferenceValue";

        #endregion

        #region Fields

        private const string FieldOUTLOOK_SYNC_CONTACT_DIRECTION_PREFERENCE_NAME = "OUTLOOK_SYNC_CONTACT_DIRECTION_PREFERENCE_NAME";
        private const string FieldDEFAULT_OUTLOOK_SYNC_CONTACT_DIRECTION = "DEFAULT_OUTLOOK_SYNC_CONTACT_DIRECTION";
        private const string FieldDEFAULT_USER_ID = "DEFAULT_USER_ID";
        private const string FieldUserHasOutlookSyncContactDirectionPreference = "UserHasOutlookSyncContactDirectionPreference";
        private const string FieldUserId = "UserId";
        private const string FieldProfileId = "ProfileId";
        private const string FielduserPrefsDict = "userPrefsDict";
        private const string FieldloadLock = "loadLock";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxUserPreferences) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxUserPreferences" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserPreferences_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxUserPreferences) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxUserPreferences" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserPreferences_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxUserPreferences) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxUserPreferences" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserPreferences_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxUserPreferences)

        #region General Initializer : Class (OnyxUserPreferences) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxUserPreferences" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodgetUserPreferences, 0)]
        [TestCase(MethodgetPreferenceValue, 0)]
        [TestCase(MethodsavePreferenceValue, 0)]
        public void AUT_OnyxUserPreferences_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxUserPreferences) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxUserPreferences" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserPrefDictKey)]
        [Category("AUT Property")]
        public void AUT_OnyxUserPreferences_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxUserPreferences) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxUserPreferences" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldOUTLOOK_SYNC_CONTACT_DIRECTION_PREFERENCE_NAME)]
        [TestCase(FieldDEFAULT_OUTLOOK_SYNC_CONTACT_DIRECTION)]
        [TestCase(FieldDEFAULT_USER_ID)]
        [TestCase(FieldUserHasOutlookSyncContactDirectionPreference)]
        [TestCase(FieldUserId)]
        [TestCase(FieldProfileId)]
        [TestCase(FielduserPrefsDict)]
        [TestCase(FieldloadLock)]
        [Category("AUT Fields")]
        public void AUT_OnyxUserPreferences_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxUserPreferences) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxUserPreferences" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxUserPreferences_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxUserPreferencesInstance.ShouldBeAssignableTo<OnyxUserPreferences>();
            _onyxUserPreferencesInstanceFixture.ShouldBeAssignableTo<OnyxUserPreferences>();
            CurrentInstance.ShouldBeAssignableTo<OnyxUserPreferences>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxUserPreferences) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserPrefDictKey)]
        public void AUT_OnyxUserPreferences_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxUserPreferences) => Property (UserPrefDictKey) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUserPreferences_UserPrefDictKey_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserPrefDictKey);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUserPrefDictKey);
            Action currentAction = () => propertyInfo.SetValue(_onyxUserPreferencesInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxUserPreferences) => Property (UserPrefDictKey) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUserPreferences_Public_Class_UserPrefDictKey_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserPrefDictKey);
            var propertyInfo = this.GetPropertyInfo(PropertyUserPrefDictKey);

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

        #region Method Call : (getUserPreferences) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getUserPreferences_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetUserPreferences);
            var poOnyxSession = this.CreateType<OnyxSession>();
            var psUserId = this.CreateType<string>();
            var piProfileId = this.CreateType<int>();
            var methodgetUserPreferencesParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(int) };
            object[] parametersOfgetUserPreferences = { poOnyxSession, psUserId, piProfileId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetUserPreferences, methodgetUserPreferencesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxUserPreferencesInstanceFixture, parametersOfgetUserPreferences);
            var result2 = this.GetResultOfMethod<String>(MethodgetUserPreferences, parametersOfgetUserPreferences, methodgetUserPreferencesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetUserPreferences.ShouldNotBeNull();
            parametersOfgetUserPreferences.Length.ShouldBe(3);
            methodgetUserPreferencesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (getUserPreferences) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getUserPreferences_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetUserPreferences);
            var poOnyxSession = this.CreateType<OnyxSession>();
            var psUserId = this.CreateType<string>();
            var piProfileId = this.CreateType<int>();
            var methodgetUserPreferencesParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(int) };
            object[] parametersOfgetUserPreferences = { poOnyxSession, psUserId, piProfileId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodgetUserPreferences, parametersOfgetUserPreferences, methodgetUserPreferencesParametersTypes);

            // Assert
            parametersOfgetUserPreferences.ShouldNotBeNull();
            parametersOfgetUserPreferences.Length.ShouldBe(3);
            methodgetUserPreferencesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getUserPreferences) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getUserPreferences_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetUserPreferences);
            var methodgetUserPreferencesParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetUserPreferences, methodgetUserPreferencesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetUserPreferencesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (getUserPreferences) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getUserPreferences_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetUserPreferences);
            var methodgetUserPreferencesParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetUserPreferences, methodgetUserPreferencesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetUserPreferencesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getUserPreferences) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getUserPreferences_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetUserPreferences);
            var currentMethodInfo = this.GetMethodInfo(MethodgetUserPreferences, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getUserPreferences) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getUserPreferences_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetUserPreferences);
            var currentMethodInfo = this.GetMethodInfo(MethodgetUserPreferences, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserPreferences_getPreferenceValue_Method_Call_Internally(Type[] types)
        {
            var methodgetPreferenceValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetPreferenceValue, methodgetPreferenceValueParametersTypes);
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getPreferenceValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetPreferenceValue);
            var prefName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxUserPreferencesInstance.getPreferenceValue(prefName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getPreferenceValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetPreferenceValue);
            var prefName = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxUserPreferencesInstance.getPreferenceValue(prefName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getPreferenceValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetPreferenceValue);
            var prefName = this.CreateType<string>();
            var methodgetPreferenceValueParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetPreferenceValue = { prefName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetPreferenceValue, methodgetPreferenceValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxUserPreferencesInstanceFixture, parametersOfgetPreferenceValue);
            var result2 = this.GetResultOfMethod<String>(MethodgetPreferenceValue, parametersOfgetPreferenceValue, methodgetPreferenceValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetPreferenceValue.ShouldNotBeNull();
            parametersOfgetPreferenceValue.Length.ShouldBe(1);
            methodgetPreferenceValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getPreferenceValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetPreferenceValue);
            var prefName = this.CreateType<string>();
            var methodgetPreferenceValueParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfgetPreferenceValue = { prefName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodgetPreferenceValue, parametersOfgetPreferenceValue, methodgetPreferenceValueParametersTypes);

            // Assert
            parametersOfgetPreferenceValue.ShouldNotBeNull();
            parametersOfgetPreferenceValue.Length.ShouldBe(1);
            methodgetPreferenceValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getPreferenceValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetPreferenceValue);
            var methodgetPreferenceValueParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetPreferenceValue, methodgetPreferenceValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetPreferenceValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getPreferenceValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetPreferenceValue);
            var methodgetPreferenceValueParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetPreferenceValue, methodgetPreferenceValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetPreferenceValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getPreferenceValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetPreferenceValue);
            var currentMethodInfo = this.GetMethodInfo(MethodgetPreferenceValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getPreferenceValue) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_getPreferenceValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetPreferenceValue);
            var currentMethodInfo = this.GetMethodInfo(MethodgetPreferenceValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (savePreferenceValue) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserPreferences_savePreferenceValue_Method_Call_Internally(Type[] types)
        {
            var methodsavePreferenceValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodsavePreferenceValue, methodsavePreferenceValueParametersTypes);
        }

        #endregion

        #region Method Call : (savePreferenceValue) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_savePreferenceValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsavePreferenceValue);
            var poOnyxSession = this.CreateType<OnyxSession>();
            var prefName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var piProfileId = this.CreateType<int>();

            // Act
            Action executeAction = () => _onyxUserPreferencesInstance.savePreferenceValue(poOnyxSession, prefName, psValue, piProfileId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (savePreferenceValue) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_savePreferenceValue_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsavePreferenceValue);
            var poOnyxSession = this.CreateType<OnyxSession>();
            var prefName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var piProfileId = this.CreateType<int>();
            var methodsavePreferenceValueParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(String), typeof(int) };
            object[] parametersOfsavePreferenceValue = { poOnyxSession, prefName, psValue, piProfileId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodsavePreferenceValue, methodsavePreferenceValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxUserPreferencesInstanceFixture, parametersOfsavePreferenceValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfsavePreferenceValue.ShouldNotBeNull();
            parametersOfsavePreferenceValue.Length.ShouldBe(4);
            methodsavePreferenceValueParametersTypes.Length.ShouldBe(4);
            methodsavePreferenceValueParametersTypes.Length.ShouldBe(parametersOfsavePreferenceValue.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (savePreferenceValue) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_savePreferenceValue_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsavePreferenceValue);
            var poOnyxSession = this.CreateType<OnyxSession>();
            var prefName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var piProfileId = this.CreateType<int>();
            var methodsavePreferenceValueParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(String), typeof(int) };
            object[] parametersOfsavePreferenceValue = { poOnyxSession, prefName, psValue, piProfileId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodsavePreferenceValue, parametersOfsavePreferenceValue, methodsavePreferenceValueParametersTypes);

            // Assert
            parametersOfsavePreferenceValue.ShouldNotBeNull();
            parametersOfsavePreferenceValue.Length.ShouldBe(4);
            methodsavePreferenceValueParametersTypes.Length.ShouldBe(4);
            methodsavePreferenceValueParametersTypes.Length.ShouldBe(parametersOfsavePreferenceValue.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (savePreferenceValue) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_savePreferenceValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsavePreferenceValue);
            var currentMethodInfo = this.GetMethodInfo(MethodsavePreferenceValue, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (savePreferenceValue) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_savePreferenceValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsavePreferenceValue);
            var methodsavePreferenceValueParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(String), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodsavePreferenceValue, methodsavePreferenceValueParametersTypes);

            // Assert
            methodsavePreferenceValueParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (savePreferenceValue) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_savePreferenceValue_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodsavePreferenceValue);
            var currentMethodInfo = this.GetMethodInfo(MethodsavePreferenceValue, 0);

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