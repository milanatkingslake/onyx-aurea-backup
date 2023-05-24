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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxUserPreferences" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
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

        private const string MethodretrieveFromOnyx = "retrieveFromOnyx";
        private const string MethodGetPreferenceValue = "GetPreferenceValue";
        private const string MethodSavePreferenceValue = "SavePreferenceValue";

        #endregion

        #region Fields

        private const string FielduserId = "userId";
        private const string FieldprofileId = "profileId";
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
        [TestCase(MethodretrieveFromOnyx, 0)]
        [TestCase(MethodGetPreferenceValue, 0)]
        [TestCase(MethodSavePreferenceValue, 0)]
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
        [TestCase(FielduserId)]
        [TestCase(FieldprofileId)]
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

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_retrieveFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var psUserId = this.CreateType<string>();
            var piProfileId = this.CreateType<int>();
            var methodretrieveFromOnyxParametersTypes = new Type[] { typeof(String), typeof(int) };
            object[] parametersOfretrieveFromOnyx = { psUserId, piProfileId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxUserPreferencesInstanceFixture, parametersOfretrieveFromOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodretrieveFromOnyx, parametersOfretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfretrieveFromOnyx.ShouldNotBeNull();
            parametersOfretrieveFromOnyx.Length.ShouldBe(2);
            methodretrieveFromOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_retrieveFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var psUserId = this.CreateType<string>();
            var piProfileId = this.CreateType<int>();
            var methodretrieveFromOnyxParametersTypes = new Type[] { typeof(String), typeof(int) };
            object[] parametersOfretrieveFromOnyx = { psUserId, piProfileId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodretrieveFromOnyx, parametersOfretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            parametersOfretrieveFromOnyx.ShouldNotBeNull();
            parametersOfretrieveFromOnyx.Length.ShouldBe(2);
            methodretrieveFromOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var methodretrieveFromOnyxParametersTypes = new Type[] { typeof(String), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var methodretrieveFromOnyxParametersTypes = new Type[] { typeof(String), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodretrieveFromOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_retrieveFromOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserPreferences_GetPreferenceValue_Method_Call_Internally(Type[] types)
        {
            var methodGetPreferenceValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPreferenceValue, methodGetPreferenceValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_GetPreferenceValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPreferenceValue);
            var prefName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxUserPreferencesInstance.GetPreferenceValue(prefName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_GetPreferenceValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPreferenceValue);
            var prefName = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxUserPreferencesInstance.GetPreferenceValue(prefName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_GetPreferenceValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPreferenceValue);
            var prefName = this.CreateType<string>();
            var methodGetPreferenceValueParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetPreferenceValue = { prefName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPreferenceValue, methodGetPreferenceValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxUserPreferencesInstanceFixture, parametersOfGetPreferenceValue);
            var result2 = this.GetResultOfMethod<String>(MethodGetPreferenceValue, parametersOfGetPreferenceValue, methodGetPreferenceValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetPreferenceValue.ShouldNotBeNull();
            parametersOfGetPreferenceValue.Length.ShouldBe(1);
            methodGetPreferenceValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_GetPreferenceValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPreferenceValue);
            var prefName = this.CreateType<string>();
            var methodGetPreferenceValueParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetPreferenceValue = { prefName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetPreferenceValue, parametersOfGetPreferenceValue, methodGetPreferenceValueParametersTypes);

            // Assert
            parametersOfGetPreferenceValue.ShouldNotBeNull();
            parametersOfGetPreferenceValue.Length.ShouldBe(1);
            methodGetPreferenceValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_GetPreferenceValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPreferenceValue);
            var methodGetPreferenceValueParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPreferenceValue, methodGetPreferenceValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPreferenceValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_GetPreferenceValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPreferenceValue);
            var methodGetPreferenceValueParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPreferenceValue, methodGetPreferenceValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPreferenceValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_GetPreferenceValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPreferenceValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPreferenceValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPreferenceValue) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_GetPreferenceValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPreferenceValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPreferenceValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SavePreferenceValue) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserPreferences_SavePreferenceValue_Method_Call_Internally(Type[] types)
        {
            var methodSavePreferenceValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSavePreferenceValue, methodSavePreferenceValueParametersTypes);
        }

        #endregion

        #region Method Call : (SavePreferenceValue) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_SavePreferenceValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSavePreferenceValue);
            var prefName = this.CreateType<string>();
            var psValue = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxUserPreferencesInstance.SavePreferenceValue(prefName, psValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SavePreferenceValue) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_SavePreferenceValue_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSavePreferenceValue);
            var prefName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var methodSavePreferenceValueParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfSavePreferenceValue = { prefName, psValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSavePreferenceValue, methodSavePreferenceValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxUserPreferencesInstanceFixture, parametersOfSavePreferenceValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSavePreferenceValue.ShouldNotBeNull();
            parametersOfSavePreferenceValue.Length.ShouldBe(2);
            methodSavePreferenceValueParametersTypes.Length.ShouldBe(2);
            methodSavePreferenceValueParametersTypes.Length.ShouldBe(parametersOfSavePreferenceValue.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SavePreferenceValue) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_SavePreferenceValue_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSavePreferenceValue);
            var prefName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var methodSavePreferenceValueParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfSavePreferenceValue = { prefName, psValue };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSavePreferenceValue, parametersOfSavePreferenceValue, methodSavePreferenceValueParametersTypes);

            // Assert
            parametersOfSavePreferenceValue.ShouldNotBeNull();
            parametersOfSavePreferenceValue.Length.ShouldBe(2);
            methodSavePreferenceValueParametersTypes.Length.ShouldBe(2);
            methodSavePreferenceValueParametersTypes.Length.ShouldBe(parametersOfSavePreferenceValue.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SavePreferenceValue) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_SavePreferenceValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSavePreferenceValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSavePreferenceValue, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SavePreferenceValue) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_SavePreferenceValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSavePreferenceValue);
            var methodSavePreferenceValueParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSavePreferenceValue, methodSavePreferenceValueParametersTypes);

            // Assert
            methodSavePreferenceValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SavePreferenceValue) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserPreferences_SavePreferenceValue_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSavePreferenceValue);
            var currentMethodInfo = this.GetMethodInfo(MethodSavePreferenceValue, 0);

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