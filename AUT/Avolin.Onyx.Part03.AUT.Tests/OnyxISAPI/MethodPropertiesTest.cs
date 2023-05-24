using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.MethodProperties" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MethodPropertiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MethodProperties" />)
        /// </summary>
        public MethodPropertiesTest() : base(typeof(MethodProperties))
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

        #region General Initializer : Class (MethodProperties) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _methodPropertiesInstanceType;
        private MethodProperties _methodPropertiesInstance;
        private MethodProperties _methodPropertiesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MethodProperties" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _methodPropertiesInstanceType = typeof(MethodProperties);
            _methodPropertiesInstanceFixture = this.Create<MethodProperties>(false);
            _methodPropertiesInstance = _methodPropertiesInstanceFixture ?? this.Create<MethodProperties>(true);
            CurrentInstance = _methodPropertiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MethodProperties) Initializer

        #region Methods

        private const string MethodGetMethodProperties = "GetMethodProperties";

        #endregion

        #region Fields

        private const string FieldMethodName = "MethodName";
        private const string FieldUser = "User";
        private const string FieldInput = "Input";
        private const string FieldOutput = "Output";

        #endregion

        #endregion

        #region General Initializer : Class (MethodProperties) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MethodProperties" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MethodProperties_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MethodProperties) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MethodProperties" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MethodProperties_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MethodProperties)

        #region General Initializer : Class (MethodProperties) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MethodProperties" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetMethodProperties, 0)]
        public void AUT_MethodProperties_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MethodProperties) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="MethodProperties" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldMethodName)]
        [TestCase(FieldUser)]
        [TestCase(FieldInput)]
        [TestCase(FieldOutput)]
        [Category("AUT Fields")]
        public void AUT_MethodProperties_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MethodProperties) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MethodProperties" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MethodProperties_Is_Instance_Present_Test()
        {
            // Assert
            _methodPropertiesInstanceType.ShouldNotBeNull();
            _methodPropertiesInstance.ShouldNotBeNull();
            _methodPropertiesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MethodProperties) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MethodProperties" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MethodProperties_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _methodPropertiesInstance.ShouldBeAssignableTo<MethodProperties>();
            _methodPropertiesInstanceFixture.ShouldBeAssignableTo<MethodProperties>();
            CurrentInstance.ShouldBeAssignableTo<MethodProperties>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MethodProperties) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MethodProperties_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MethodProperties instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();

            // Act
            Action executeAction = () => MethodProperties.GetMethodProperties(methodName, user);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var returnedValue = default(MethodProperties);

            // Act
            Action executeAction = () => returnedValue = MethodProperties.GetMethodProperties(methodName, user);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var methodGetMethodPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetMethodProperties = { methodName, user };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodProperties, methodGetMethodPropertiesParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetMethodProperties, methodGetMethodPropertiesParametersTypes);
            var result2 = this.GetResultOfMethod<MethodProperties>(MethodGetMethodProperties, parametersOfGetMethodProperties, methodGetMethodPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMethodProperties.ShouldNotBeNull();
            parametersOfGetMethodProperties.Length.ShouldBe(2);
            methodGetMethodPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<MethodProperties>(MethodGetMethodProperties, parametersOfGetMethodProperties, methodGetMethodPropertiesParametersTypes));
        }

        #endregion

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var methodGetMethodPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetMethodProperties = { methodName, user };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodProperties, methodGetMethodPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_methodPropertiesInstanceFixture, parametersOfGetMethodProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMethodProperties.ShouldNotBeNull();
            parametersOfGetMethodProperties.Length.ShouldBe(2);
            methodGetMethodPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var methodGetMethodPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetMethodProperties = { methodName, user };

            // Act
            Action currentAction = () => this.GetResultOfMethod<MethodProperties>(MethodGetMethodProperties, parametersOfGetMethodProperties, methodGetMethodPropertiesParametersTypes);

            // Assert
            parametersOfGetMethodProperties.ShouldNotBeNull();
            parametersOfGetMethodProperties.Length.ShouldBe(2);
            methodGetMethodPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var methodGetMethodPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMethodProperties, methodGetMethodPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetMethodPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var methodGetMethodPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMethodProperties, methodGetMethodPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMethodPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMethodProperties) (Return Type : MethodProperties) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MethodProperties_GetMethodProperties_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodProperties, 0);
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