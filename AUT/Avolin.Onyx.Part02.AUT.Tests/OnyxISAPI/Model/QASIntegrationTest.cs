using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.QASIntegration" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class QASIntegrationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QASIntegration" />)
        /// </summary>
        public QASIntegrationTest() : base(typeof(QASIntegration))
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

        #region General Initializer : Class (QASIntegration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _qASIntegrationInstanceType;
        private QASIntegration _qASIntegrationInstance;
        private QASIntegration _qASIntegrationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="QASIntegration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _qASIntegrationInstanceType = typeof(QASIntegration);
            _qASIntegrationInstanceFixture = this.Create<QASIntegration>(false);
            _qASIntegrationInstance = _qASIntegrationInstanceFixture ?? this.Create<QASIntegration>(true);
            CurrentInstance = _qASIntegrationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QASIntegration) Initializer

        #region Methods

        private const string MethodGetAddressResponses = "GetAddressResponses";
        private const string MethodGetEmailAddressResponses = "GetEmailAddressResponses";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (QASIntegration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QASIntegration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QASIntegration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QASIntegration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QASIntegration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QASIntegration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QASIntegration)

        #region General Initializer : Class (QASIntegration) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="QASIntegration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetAddressResponses, 0)]
        [TestCase(MethodGetEmailAddressResponses, 0)]
        public void AUT_QASIntegration_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (QASIntegration) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="QASIntegration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_QASIntegration_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (QASIntegration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="QASIntegration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QASIntegration_Is_Instance_Present_Test()
        {
            // Assert
            _qASIntegrationInstanceType.ShouldNotBeNull();
            _qASIntegrationInstance.ShouldNotBeNull();
            _qASIntegrationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (QASIntegration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QASIntegration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QASIntegration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _qASIntegrationInstance.ShouldBeAssignableTo<QASIntegration>();
            _qASIntegrationInstanceFixture.ShouldBeAssignableTo<QASIntegration>();
            CurrentInstance.ShouldBeAssignableTo<QASIntegration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (QASIntegration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QASIntegration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            QASIntegration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (QASIntegration) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QASIntegration_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            QASIntegration instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new QASIntegration(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _qASIntegrationInstance.ShouldNotBeNull();
            _qASIntegrationInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<QASIntegration>();
        }

        #endregion

        #region General Constructor : Class (QASIntegration) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QASIntegration_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            QASIntegration instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new QASIntegration(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _qASIntegrationInstance.ShouldNotBeNull();
            _qASIntegrationInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (QASIntegration) instance created

        /// <summary>
        ///     Class (<see cref="QASIntegration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QASIntegration_Is_Created_Test()
        {
            // Assert
            _qASIntegrationInstance.ShouldNotBeNull();
            _qASIntegrationInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (QASIntegration) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="QASIntegration" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_QASIntegration_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (QASIntegration) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="QASIntegration" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QASIntegration_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (QASIntegration) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="QASIntegration" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QASIntegration_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodQASIntegrationParametersTypes = new Type[] { typeof(Hashtable) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodQASIntegrationParametersTypes);
        }

        #endregion

        #region General Constructor : Class (QASIntegration) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="QASIntegration" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QASIntegration_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodQASIntegrationParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodQASIntegrationParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetAddressResponses) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetAddressResponses_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAddressResponses);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _qASIntegrationInstance.GetAddressResponses(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAddressResponses) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetAddressResponses_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAddressResponses);
            var message = this.CreateType<Message>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _qASIntegrationInstance.GetAddressResponses(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAddressResponses) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetAddressResponses_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAddressResponses);
            var message = this.CreateType<Message>();
            var methodGetAddressResponsesParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetAddressResponses = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAddressResponses, methodGetAddressResponsesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_qASIntegrationInstanceFixture, parametersOfGetAddressResponses);
            var result2 = this.GetResultOfMethod<string>(MethodGetAddressResponses, parametersOfGetAddressResponses, methodGetAddressResponsesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAddressResponses.ShouldNotBeNull();
            parametersOfGetAddressResponses.Length.ShouldBe(1);
            methodGetAddressResponsesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAddressResponses) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetAddressResponses_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAddressResponses);
            var message = this.CreateType<Message>();
            var methodGetAddressResponsesParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetAddressResponses = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetAddressResponses, parametersOfGetAddressResponses, methodGetAddressResponsesParametersTypes);

            // Assert
            parametersOfGetAddressResponses.ShouldNotBeNull();
            parametersOfGetAddressResponses.Length.ShouldBe(1);
            methodGetAddressResponsesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAddressResponses) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetAddressResponses_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAddressResponses);
            var methodGetAddressResponsesParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAddressResponses, methodGetAddressResponsesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAddressResponsesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAddressResponses) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetAddressResponses_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAddressResponses);
            var methodGetAddressResponsesParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAddressResponses, methodGetAddressResponsesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAddressResponsesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAddressResponses) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetAddressResponses_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAddressResponses);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAddressResponses, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAddressResponses) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetAddressResponses_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAddressResponses);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAddressResponses, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QASIntegration_GetEmailAddressResponses_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailAddressResponsesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailAddressResponses, methodGetEmailAddressResponsesParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetEmailAddressResponses_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressResponses);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _qASIntegrationInstance.GetEmailAddressResponses(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetEmailAddressResponses_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressResponses);
            var message = this.CreateType<Message>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _qASIntegrationInstance.GetEmailAddressResponses(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetEmailAddressResponses_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressResponses);
            var message = this.CreateType<Message>();
            var methodGetEmailAddressResponsesParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetEmailAddressResponses = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailAddressResponses, methodGetEmailAddressResponsesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_qASIntegrationInstanceFixture, parametersOfGetEmailAddressResponses);
            var result2 = this.GetResultOfMethod<string>(MethodGetEmailAddressResponses, parametersOfGetEmailAddressResponses, methodGetEmailAddressResponsesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEmailAddressResponses.ShouldNotBeNull();
            parametersOfGetEmailAddressResponses.Length.ShouldBe(1);
            methodGetEmailAddressResponsesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetEmailAddressResponses_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressResponses);
            var message = this.CreateType<Message>();
            var methodGetEmailAddressResponsesParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetEmailAddressResponses = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEmailAddressResponses, parametersOfGetEmailAddressResponses, methodGetEmailAddressResponsesParametersTypes);

            // Assert
            parametersOfGetEmailAddressResponses.ShouldNotBeNull();
            parametersOfGetEmailAddressResponses.Length.ShouldBe(1);
            methodGetEmailAddressResponsesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetEmailAddressResponses_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressResponses);
            var methodGetEmailAddressResponsesParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailAddressResponses, methodGetEmailAddressResponsesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEmailAddressResponsesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetEmailAddressResponses_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressResponses);
            var methodGetEmailAddressResponsesParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailAddressResponses, methodGetEmailAddressResponsesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailAddressResponsesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetEmailAddressResponses_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressResponses);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailAddressResponses, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailAddressResponses) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QASIntegration_GetEmailAddressResponses_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailAddressResponses);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailAddressResponses, 0);
            const int parametersCount = 1;

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