using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OGS.EMFExtension.Base;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OGS.EMFExtension.Base
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OGS.EMFExtension.Base.TaskEmailDataProfile" />)
    ///     and namespace <see cref="Onyx.OGS.EMFExtension.Base"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TaskEmailDataProfileTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TaskEmailDataProfile" />)
        /// </summary>
        public TaskEmailDataProfileTest() : base(typeof(TaskEmailDataProfile))
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

        #region General Initializer : Class (TaskEmailDataProfile) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _taskEmailDataProfileInstanceType;
        private TaskEmailDataProfile _taskEmailDataProfileInstance;
        private TaskEmailDataProfile _taskEmailDataProfileInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TaskEmailDataProfile" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _taskEmailDataProfileInstanceType = typeof(TaskEmailDataProfile);
            _taskEmailDataProfileInstanceFixture = this.Create<TaskEmailDataProfile>(false);
            _taskEmailDataProfileInstance = _taskEmailDataProfileInstanceFixture ?? this.Create<TaskEmailDataProfile>(true);
            CurrentInstance = _taskEmailDataProfileInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TaskEmailDataProfile) Initializer

        #region Properties

        private const string PropertyConfig = "Config";

        #endregion

        #region Methods

        private const string MethodGetEmailProfileData = "GetEmailProfileData";
        private const string MethodFillReferenceParameters = "FillReferenceParameters";
        private const string MethodFillUserName = "FillUserName";

        #endregion

        #endregion

        #region General Initializer : Class (TaskEmailDataProfile) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TaskEmailDataProfile_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TaskEmailDataProfile) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TaskEmailDataProfile_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TaskEmailDataProfile) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TaskEmailDataProfile_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TaskEmailDataProfile)

        #region General Initializer : Class (TaskEmailDataProfile) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetEmailProfileData, 0)]
        [TestCase(MethodFillReferenceParameters, 0)]
        [TestCase(MethodFillUserName, 0)]
        public void AUT_TaskEmailDataProfile_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TaskEmailDataProfile) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyConfig)]
        [Category("AUT Property")]
        public void AUT_TaskEmailDataProfile_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (TaskEmailDataProfile) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TaskEmailDataProfile_Is_Instance_Present_Test()
        {
            // Assert
            _taskEmailDataProfileInstanceType.ShouldNotBeNull();
            _taskEmailDataProfileInstance.ShouldNotBeNull();
            _taskEmailDataProfileInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TaskEmailDataProfile) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TaskEmailDataProfile_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _taskEmailDataProfileInstance.ShouldBeAssignableTo<TaskEmailDataProfile>();
            _taskEmailDataProfileInstanceFixture.ShouldBeAssignableTo<TaskEmailDataProfile>();
            CurrentInstance.ShouldBeAssignableTo<TaskEmailDataProfile>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TaskEmailDataProfile) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskEmailDataProfile_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var config = this.CreateType<XElement>();
            TaskEmailDataProfile instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TaskEmailDataProfile(config);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _taskEmailDataProfileInstance.ShouldNotBeNull();
            _taskEmailDataProfileInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<TaskEmailDataProfile>();
        }

        #endregion

        #region General Constructor : Class (TaskEmailDataProfile) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskEmailDataProfile_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var config = this.CreateType<XElement>();
            TaskEmailDataProfile instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TaskEmailDataProfile(config);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _taskEmailDataProfileInstance.ShouldNotBeNull();
            _taskEmailDataProfileInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (TaskEmailDataProfile) instance created

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskEmailDataProfile_Is_Created_Test()
        {
            // Assert
            _taskEmailDataProfileInstance.ShouldNotBeNull();
            _taskEmailDataProfileInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (TaskEmailDataProfile) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfile" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_TaskEmailDataProfile_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (TaskEmailDataProfile) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="TaskEmailDataProfile" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskEmailDataProfile_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TaskEmailDataProfile) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TaskEmailDataProfile" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskEmailDataProfile_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTaskEmailDataProfileParametersTypes = new Type[] { typeof(XElement) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTaskEmailDataProfileParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TaskEmailDataProfile) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyConfig)]
        public void AUT_TaskEmailDataProfile_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TaskEmailDataProfile) => Property (Config) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TaskEmailDataProfile_Config_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfig);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyConfig);
            Action currentAction = () => propertyInfo.SetValue(_taskEmailDataProfileInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TaskEmailDataProfile) => Property (Config) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TaskEmailDataProfile_Public_Class_Config_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfig);
            var propertyInfo = this.GetPropertyInfo(PropertyConfig);

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

        #region Method Call : (GetEmailProfileData) (Return Type : XElement) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_GetEmailProfileData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailProfileData);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _taskEmailDataProfileInstance.GetEmailProfileData(parameterCollection, inputXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEmailProfileData) (Return Type : XElement) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_GetEmailProfileData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailProfileData);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _taskEmailDataProfileInstance.GetEmailProfileData(parameterCollection, inputXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailProfileData) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_GetEmailProfileData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailProfileData);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var methodGetEmailProfileDataParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfGetEmailProfileData = { parameterCollection, inputXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailProfileData, methodGetEmailProfileDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_taskEmailDataProfileInstanceFixture, parametersOfGetEmailProfileData);
            var result2 = this.GetResultOfMethod<XElement>(MethodGetEmailProfileData, parametersOfGetEmailProfileData, methodGetEmailProfileDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEmailProfileData.ShouldNotBeNull();
            parametersOfGetEmailProfileData.Length.ShouldBe(2);
            methodGetEmailProfileDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetEmailProfileData) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_GetEmailProfileData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailProfileData);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var methodGetEmailProfileDataParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfGetEmailProfileData = { parameterCollection, inputXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodGetEmailProfileData, parametersOfGetEmailProfileData, methodGetEmailProfileDataParametersTypes);

            // Assert
            parametersOfGetEmailProfileData.ShouldNotBeNull();
            parametersOfGetEmailProfileData.Length.ShouldBe(2);
            methodGetEmailProfileDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailProfileData) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_GetEmailProfileData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailProfileData);
            var methodGetEmailProfileDataParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailProfileData, methodGetEmailProfileDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEmailProfileDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetEmailProfileData) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_GetEmailProfileData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailProfileData);
            var methodGetEmailProfileDataParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailProfileData, methodGetEmailProfileDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailProfileDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEmailProfileData) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_GetEmailProfileData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailProfileData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailProfileData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailProfileData) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_GetEmailProfileData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailProfileData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailProfileData, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TaskEmailDataProfile_FillReferenceParameters_Method_Call_Internally(Type[] types)
        {
            var methodFillReferenceParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFillReferenceParameters, methodFillReferenceParametersParametersTypes);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillReferenceParameters_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _taskEmailDataProfileInstance.FillReferenceParameters(siteId, languageCode, inputXml, actionElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillReferenceParameters_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodFillReferenceParametersParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement), typeof(XElement) };
            object[] parametersOfFillReferenceParameters = { siteId, languageCode, inputXml, actionElement };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFillReferenceParameters, methodFillReferenceParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_taskEmailDataProfileInstanceFixture, parametersOfFillReferenceParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFillReferenceParameters.ShouldNotBeNull();
            parametersOfFillReferenceParameters.Length.ShouldBe(4);
            methodFillReferenceParametersParametersTypes.Length.ShouldBe(4);
            methodFillReferenceParametersParametersTypes.Length.ShouldBe(parametersOfFillReferenceParameters.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillReferenceParameters_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodFillReferenceParametersParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement), typeof(XElement) };
            object[] parametersOfFillReferenceParameters = { siteId, languageCode, inputXml, actionElement };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFillReferenceParameters, parametersOfFillReferenceParameters, methodFillReferenceParametersParametersTypes);

            // Assert
            parametersOfFillReferenceParameters.ShouldNotBeNull();
            parametersOfFillReferenceParameters.Length.ShouldBe(4);
            methodFillReferenceParametersParametersTypes.Length.ShouldBe(4);
            methodFillReferenceParametersParametersTypes.Length.ShouldBe(parametersOfFillReferenceParameters.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillReferenceParameters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodFillReferenceParameters, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillReferenceParameters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var methodFillReferenceParametersParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFillReferenceParameters, methodFillReferenceParametersParametersTypes);

            // Assert
            methodFillReferenceParametersParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillReferenceParameters_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodFillReferenceParameters, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TaskEmailDataProfile_FillUserName_Method_Call_Internally(Type[] types)
        {
            var methodFillUserNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFillUserName, methodFillUserNameParametersTypes);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillUserName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _taskEmailDataProfileInstance.FillUserName(siteId, languageCode, inputXml, actionElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillUserName_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodFillUserNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement), typeof(XElement) };
            object[] parametersOfFillUserName = { siteId, languageCode, inputXml, actionElement };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFillUserName, methodFillUserNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_taskEmailDataProfileInstanceFixture, parametersOfFillUserName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFillUserName.ShouldNotBeNull();
            parametersOfFillUserName.Length.ShouldBe(4);
            methodFillUserNameParametersTypes.Length.ShouldBe(4);
            methodFillUserNameParametersTypes.Length.ShouldBe(parametersOfFillUserName.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillUserName_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodFillUserNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement), typeof(XElement) };
            object[] parametersOfFillUserName = { siteId, languageCode, inputXml, actionElement };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFillUserName, parametersOfFillUserName, methodFillUserNameParametersTypes);

            // Assert
            parametersOfFillUserName.ShouldNotBeNull();
            parametersOfFillUserName.Length.ShouldBe(4);
            methodFillUserNameParametersTypes.Length.ShouldBe(4);
            methodFillUserNameParametersTypes.Length.ShouldBe(parametersOfFillUserName.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillUserName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var currentMethodInfo = this.GetMethodInfo(MethodFillUserName, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillUserName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var methodFillUserNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFillUserName, methodFillUserNameParametersTypes);

            // Assert
            methodFillUserNameParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskEmailDataProfile_FillUserName_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var currentMethodInfo = this.GetMethodInfo(MethodFillUserName, 0);

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