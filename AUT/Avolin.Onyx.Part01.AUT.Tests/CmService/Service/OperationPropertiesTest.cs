using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OperationProperties" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Common.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OperationPropertiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OperationProperties" />)
        /// </summary>
        public OperationPropertiesTest() : base(typeof(OperationProperties))
        { }

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

        #region General Initializer : Class (OperationProperties) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _operationPropertiesInstanceType;
        private OperationProperties _operationPropertiesInstance;
        private OperationProperties _operationPropertiesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OperationProperties" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _operationPropertiesInstanceType = typeof(OperationProperties);
            _operationPropertiesInstanceFixture = this.Create<OperationProperties>(false);
            _operationPropertiesInstance = _operationPropertiesInstanceFixture ?? this.Create<OperationProperties>(true);
            CurrentInstance = _operationPropertiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OperationProperties) Initializer

        #region Methods

        private const string MethodGetProperties = "GetProperties";

        #endregion

        #region Fields

        private const string FieldIsLog = "IsLog";
        private const string FieldIsWarning = "IsWarning";
        private const string FieldResourceKey = "ResourceKey";
        private const string FieldLogLevel = "LogLevel";
        private const string FieldLogSource = "LogSource";
        private const string FieldLogName = "LogName";
        private const string FieldLogPath = "LogPath";
        private const string FieldParameters = "Parameters";
        private const string FieldMessageFormat = "MessageFormat";

        #endregion

        #endregion

        #region General Initializer : Class (OperationProperties) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OperationProperties" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OperationProperties_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OperationProperties) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OperationProperties" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OperationProperties_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OperationProperties)

        #region General Initializer : Class (OperationProperties) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OperationProperties" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetProperties, 0)]
        public void AUT_OperationProperties_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OperationProperties) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OperationProperties" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldIsLog)]
        [TestCase(FieldIsWarning)]
        [TestCase(FieldResourceKey)]
        [TestCase(FieldLogLevel)]
        [TestCase(FieldLogSource)]
        [TestCase(FieldLogName)]
        [TestCase(FieldLogPath)]
        [TestCase(FieldParameters)]
        [TestCase(FieldMessageFormat)]
        [Category("AUT Fields")]
        public void AUT_OperationProperties_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OperationProperties) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OperationProperties" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OperationProperties_Is_Instance_Present_Test()
        {
            // Assert
            _operationPropertiesInstanceType.ShouldNotBeNull();
            _operationPropertiesInstance.ShouldNotBeNull();
            _operationPropertiesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OperationProperties) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OperationProperties" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OperationProperties_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _operationPropertiesInstance.ShouldBeAssignableTo<OperationProperties>();
            _operationPropertiesInstanceFixture.ShouldBeAssignableTo<OperationProperties>();
            CurrentInstance.ShouldBeAssignableTo<OperationProperties>();
        }

        #endregion

        #region General Constructor : Class (OperationProperties) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OperationProperties_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OperationProperties instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : OperationProperties) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OperationProperties_GetProperties_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var resourceKey = this.CreateType<string>();
            var methodName = this.CreateType<string>();

            // Act
            Action executeAction = () => OperationProperties.GetProperties(resourceKey, methodName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : OperationProperties) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OperationProperties_GetProperties_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var resourceKey = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var returnedValue = default(OperationProperties);

            // Act
            Action executeAction = () => returnedValue = OperationProperties.GetProperties(resourceKey, methodName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : OperationProperties) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OperationProperties_GetProperties_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var resourceKey = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var methodGetPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetProperties = { resourceKey, methodName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperties, methodGetPropertiesParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetProperties, methodGetPropertiesParametersTypes);
            var result2 = this.GetResultOfMethod<OperationProperties>(MethodGetProperties, parametersOfGetProperties, methodGetPropertiesParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_operationPropertiesInstanceFixture, parametersOfGetProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProperties.ShouldNotBeNull();
            parametersOfGetProperties.Length.ShouldBe(2);
            methodGetPropertiesParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : OperationProperties) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OperationProperties_GetProperties_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var resourceKey = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var methodGetPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetProperties = { resourceKey, methodName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OperationProperties>(MethodGetProperties, parametersOfGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            parametersOfGetProperties.ShouldNotBeNull();
            parametersOfGetProperties.Length.ShouldBe(2);
            methodGetPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : OperationProperties) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OperationProperties_GetProperties_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var methodGetPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : OperationProperties) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OperationProperties_GetProperties_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var methodGetPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : OperationProperties) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OperationProperties_GetProperties_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : OperationProperties) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OperationProperties_GetProperties_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperties, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}