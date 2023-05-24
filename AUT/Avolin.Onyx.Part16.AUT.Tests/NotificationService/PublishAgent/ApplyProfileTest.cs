using System;
using System.Activities;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NotificationService.PublishAgent;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.PublishAgent
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.PublishAgent.ApplyProfile" />)
    ///     and namespace <see cref="NotificationService.PublishAgent"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ApplyProfileTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ApplyProfile" />)
        /// </summary>
        public ApplyProfileTest() : base(typeof(ApplyProfile))
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

        #region General Initializer : Class (ApplyProfile) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _applyProfileInstanceType;
        private ApplyProfile _applyProfileInstance;
        private ApplyProfile _applyProfileInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ApplyProfile" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _applyProfileInstanceType = typeof(ApplyProfile);
            _applyProfileInstanceFixture = this.Create<ApplyProfile>(false);
            _applyProfileInstance = _applyProfileInstanceFixture ?? this.Create<ApplyProfile>(true);
            CurrentInstance = _applyProfileInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ApplyProfile) Initializer

        #region Properties

        private const string PropertyinputEventManifest = "inputEventManifest";
        private const string Propertynotificationxml = "notificationxml";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodapplyProfile = "applyProfile";
        private const string MethodgetProfilePath = "getProfilePath";

        #endregion

        #endregion

        #region General Initializer : Class (ApplyProfile) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ApplyProfile" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ApplyProfile_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ApplyProfile) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ApplyProfile" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ApplyProfile_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ApplyProfile) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ApplyProfile" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ApplyProfile_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ApplyProfile)

        #region General Initializer : Class (ApplyProfile) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ApplyProfile" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodapplyProfile, 0)]
        [TestCase(MethodgetProfilePath, 0)]
        public void AUT_ApplyProfile_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ApplyProfile) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ApplyProfile" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyinputEventManifest)]
        [TestCase(Propertynotificationxml)]
        [Category("AUT Property")]
        public void AUT_ApplyProfile_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ApplyProfile) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ApplyProfile" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ApplyProfile_Is_Instance_Present_Test()
        {
            // Assert
            _applyProfileInstanceType.ShouldNotBeNull();
            _applyProfileInstance.ShouldNotBeNull();
            _applyProfileInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ApplyProfile) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ApplyProfile" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ApplyProfile_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _applyProfileInstance.ShouldBeAssignableTo<ApplyProfile>();
            _applyProfileInstanceFixture.ShouldBeAssignableTo<ApplyProfile>();
            CurrentInstance.ShouldBeAssignableTo<ApplyProfile>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ApplyProfile) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ApplyProfile_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ApplyProfile instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ApplyProfile) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyinputEventManifest)]
        [TestCase(Propertynotificationxml)]
        public void AUT_ApplyProfile_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ApplyProfile) => Property (inputEventManifest) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ApplyProfile_Public_Class_inputEventManifest_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyinputEventManifest);
            var propertyInfo = this.GetPropertyInfo(PropertyinputEventManifest);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ApplyProfile) => Property (notificationxml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ApplyProfile_Public_Class_notificationxml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynotificationxml);
            var propertyInfo = this.GetPropertyInfo(Propertynotificationxml);

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

        #region Method Call : (Execute) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_Execute_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var context = this.CreateType<CodeActivityContext>();
            var methodExecuteParametersTypes = new Type[] { typeof(CodeActivityContext) };
            object[] parametersOfExecute = { context };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_applyProfileInstanceFixture, parametersOfExecute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_Execute_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var context = this.CreateType<CodeActivityContext>();
            var methodExecuteParametersTypes = new Type[] { typeof(CodeActivityContext) };
            object[] parametersOfExecute = { context };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(CodeActivityContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            methodExecuteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_Execute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (applyProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ApplyProfile_applyProfile_Method_Call_Internally(Type[] types)
        {
            var methodapplyProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodapplyProfile, methodapplyProfileParametersTypes);
        }

        #endregion

        #region Method Call : (applyProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_applyProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodapplyProfile);
            var eventManifest = this.CreateType<EventManifest>();
            var methodapplyProfileParametersTypes = new Type[] { typeof(EventManifest) };
            object[] parametersOfapplyProfile = { eventManifest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodapplyProfile, methodapplyProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_applyProfileInstanceFixture, parametersOfapplyProfile);
            var result2 = this.GetResultOfMethod<string>(MethodapplyProfile, parametersOfapplyProfile, methodapplyProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfapplyProfile.ShouldNotBeNull();
            parametersOfapplyProfile.Length.ShouldBe(1);
            methodapplyProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (applyProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_applyProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodapplyProfile);
            var eventManifest = this.CreateType<EventManifest>();
            var methodapplyProfileParametersTypes = new Type[] { typeof(EventManifest) };
            object[] parametersOfapplyProfile = { eventManifest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodapplyProfile, parametersOfapplyProfile, methodapplyProfileParametersTypes);

            // Assert
            parametersOfapplyProfile.ShouldNotBeNull();
            parametersOfapplyProfile.Length.ShouldBe(1);
            methodapplyProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (applyProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_applyProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodapplyProfile);
            var methodapplyProfileParametersTypes = new Type[] { typeof(EventManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodapplyProfile, methodapplyProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodapplyProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (applyProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_applyProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodapplyProfile);
            var methodapplyProfileParametersTypes = new Type[] { typeof(EventManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodapplyProfile, methodapplyProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodapplyProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (applyProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_applyProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodapplyProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodapplyProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (applyProfile) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_applyProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodapplyProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodapplyProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getProfilePath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ApplyProfile_getProfilePath_Method_Call_Internally(Type[] types)
        {
            var methodgetProfilePathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetProfilePath, methodgetProfilePathParametersTypes);
        }

        #endregion

        #region Method Call : (getProfilePath) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_getProfilePath_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetProfilePath);
            var notificationId = this.CreateType<int>();
            var siteID = this.CreateType<int>();
            var methodgetProfilePathParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfgetProfilePath = { notificationId, siteID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetProfilePath, methodgetProfilePathParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_applyProfileInstanceFixture, parametersOfgetProfilePath);
            var result2 = this.GetResultOfMethod<string>(MethodgetProfilePath, parametersOfgetProfilePath, methodgetProfilePathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetProfilePath.ShouldNotBeNull();
            parametersOfgetProfilePath.Length.ShouldBe(2);
            methodgetProfilePathParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (getProfilePath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_getProfilePath_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetProfilePath);
            var notificationId = this.CreateType<int>();
            var siteID = this.CreateType<int>();
            var methodgetProfilePathParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfgetProfilePath = { notificationId, siteID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodgetProfilePath, parametersOfgetProfilePath, methodgetProfilePathParametersTypes);

            // Assert
            parametersOfgetProfilePath.ShouldNotBeNull();
            parametersOfgetProfilePath.Length.ShouldBe(2);
            methodgetProfilePathParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getProfilePath) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_getProfilePath_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetProfilePath);
            var methodgetProfilePathParametersTypes = new Type[] { typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetProfilePath, methodgetProfilePathParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetProfilePathParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (getProfilePath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_getProfilePath_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetProfilePath);
            var methodgetProfilePathParametersTypes = new Type[] { typeof(int), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetProfilePath, methodgetProfilePathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetProfilePathParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getProfilePath) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_getProfilePath_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetProfilePath);
            var currentMethodInfo = this.GetMethodInfo(MethodgetProfilePath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getProfilePath) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplyProfile_getProfilePath_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetProfilePath);
            var currentMethodInfo = this.GetMethodInfo(MethodgetProfilePath, 0);
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