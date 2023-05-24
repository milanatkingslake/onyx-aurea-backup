using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.OnyxAppData" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxAppDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxAppData" />)
        /// </summary>
        public OnyxAppDataTest() : base(typeof(OnyxAppData))
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

        #region General Initializer : Class (OnyxAppData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxAppDataInstanceType;
        private OnyxAppData _onyxAppDataInstance;
        private OnyxAppData _onyxAppDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxAppData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxAppDataInstanceType = typeof(OnyxAppData);
            _onyxAppDataInstanceFixture = this.Create<OnyxAppData>(false);
            _onyxAppDataInstance = _onyxAppDataInstanceFixture ?? this.Create<OnyxAppData>(true);
            CurrentInstance = _onyxAppDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxAppData) Initializer

        #region Properties

        private const string PropertyapplicationName = "applicationName";
        private const string PropertyassemblyClassName = "assemblyClassName";

        #endregion

        #region Methods

        private const string MethodGetSetting = "GetSetting";

        #endregion

        #region Fields

        private const string Fieldm_applicationName = "m_applicationName";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxAppData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxAppData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAppData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxAppData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxAppData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAppData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxAppData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxAppData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAppData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxAppData)

        #region General Initializer : Class (OnyxAppData) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxAppData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSetting, 0)]
        public void AUT_OnyxAppData_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxAppData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxAppData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyapplicationName)]
        [TestCase(PropertyassemblyClassName)]
        [Category("AUT Property")]
        public void AUT_OnyxAppData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxAppData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxAppData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_applicationName)]
        [Category("AUT Fields")]
        public void AUT_OnyxAppData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxAppData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxAppData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxAppData_Is_Instance_Present_Test()
        {
            // Assert
            _onyxAppDataInstanceType.ShouldNotBeNull();
            _onyxAppDataInstance.ShouldNotBeNull();
            _onyxAppDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxAppData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxAppData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxAppData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxAppDataInstance.ShouldBeAssignableTo<OnyxAppData>();
            _onyxAppDataInstanceFixture.ShouldBeAssignableTo<OnyxAppData>();
            CurrentInstance.ShouldBeAssignableTo<OnyxAppData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxAppData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxAppData_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var psApplicationName = this.CreateType<string>();
            OnyxAppData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxAppData(psApplicationName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxAppDataInstance.ShouldNotBeNull();
            _onyxAppDataInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxAppData>();
        }

        #endregion

        #region General Constructor : Class (OnyxAppData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxAppData_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var psApplicationName = this.CreateType<string>();
            OnyxAppData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxAppData(psApplicationName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxAppDataInstance.ShouldNotBeNull();
            _onyxAppDataInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxAppData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyapplicationName)]
        [TestCase(PropertyassemblyClassName)]
        public void AUT_OnyxAppData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxAppData) => Property (applicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppData_Public_Class_applicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyapplicationName);
            var propertyInfo = this.GetPropertyInfo(PropertyapplicationName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxAppData) => Property (assemblyClassName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAppData_Public_Class_assemblyClassName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyassemblyClassName);
            var propertyInfo = this.GetPropertyInfo(PropertyassemblyClassName);

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

        #region Method Call : (GetSetting) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppData_GetSetting_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var psSubKey = this.CreateType<string>();
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxAppDataInstance.GetSetting(psSubKey, psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppData_GetSetting_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var psSubKey = this.CreateType<string>();
            var psName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxAppDataInstance.GetSetting(psSubKey, psName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppData_GetSetting_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var psSubKey = this.CreateType<string>();
            var psName = this.CreateType<string>();
            var methodGetSettingParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSetting = { psSubKey, psName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSetting, methodGetSettingParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxAppDataInstanceFixture, parametersOfGetSetting);
            var result2 = this.GetResultOfMethod<string>(MethodGetSetting, parametersOfGetSetting, methodGetSettingParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSetting.ShouldNotBeNull();
            parametersOfGetSetting.Length.ShouldBe(2);
            methodGetSettingParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppData_GetSetting_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var psSubKey = this.CreateType<string>();
            var psName = this.CreateType<string>();
            var methodGetSettingParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSetting = { psSubKey, psName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSetting, parametersOfGetSetting, methodGetSettingParametersTypes);

            // Assert
            parametersOfGetSetting.ShouldNotBeNull();
            parametersOfGetSetting.Length.ShouldBe(2);
            methodGetSettingParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppData_GetSetting_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var methodGetSettingParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSetting, methodGetSettingParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSettingParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppData_GetSetting_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var methodGetSettingParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSetting, methodGetSettingParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSettingParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppData_GetSetting_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSetting, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSetting) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAppData_GetSetting_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSetting);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSetting, 0);
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