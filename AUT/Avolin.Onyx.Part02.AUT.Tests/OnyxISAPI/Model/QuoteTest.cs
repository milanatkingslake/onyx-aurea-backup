using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Quote" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class QuoteTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Quote" />)
        /// </summary>
        public QuoteTest() : base(typeof(Quote))
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

        #region General Initializer : Class (Quote) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _quoteInstanceType;
        private Quote _quoteInstance;
        private Quote _quoteInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Quote" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _quoteInstanceType = typeof(Quote);
            _quoteInstanceFixture = this.Create<Quote>(false);
            _quoteInstance = _quoteInstanceFixture ?? this.Create<Quote>(true);
            CurrentInstance = _quoteInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Quote) Initializer

        #region Methods

        private const string MethodGetDetailsViewById = "GetDetailsViewById";
        private const string MethodGetQuoteById = "GetQuoteById";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";
        private const string FieldconfigLBOMethodName = "configLBOMethodName";

        #endregion

        #endregion

        #region General Initializer : Class (Quote) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Quote" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Quote_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Quote) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Quote" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Quote_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Quote)

        #region General Initializer : Class (Quote) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Quote" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDetailsViewById, 0)]
        [TestCase(MethodGetQuoteById, 0)]
        [TestCase(MethodGetQuoteById, 1)]
        public void AUT_Quote_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Quote) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Quote" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [TestCase(FieldconfigLBOMethodName)]
        [Category("AUT Fields")]
        public void AUT_Quote_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Quote) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Quote" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Quote_Is_Instance_Present_Test()
        {
            // Assert
            _quoteInstanceType.ShouldNotBeNull();
            _quoteInstance.ShouldNotBeNull();
            _quoteInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Quote) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Quote" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Quote_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _quoteInstance.ShouldBeAssignableTo<Quote>();
            _quoteInstanceFixture.ShouldBeAssignableTo<Quote>();
            CurrentInstance.ShouldBeAssignableTo<Quote>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Quote) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Quote_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Quote instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Quote(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _quoteInstance.ShouldNotBeNull();
            _quoteInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Quote>();
        }

        #endregion

        #region General Constructor : Class (Quote) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Quote_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Quote instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Quote(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _quoteInstance.ShouldNotBeNull();
            _quoteInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetDetailsViewById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetDetailsViewById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);

            // Act
            Action executeAction = () => _quoteInstance.GetDetailsViewById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetDetailsViewById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _quoteInstance.GetDetailsViewById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetDetailsViewById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            Type [] methodGetDetailsViewByIdParametersTypes = null;
            object[] parametersOfGetDetailsViewById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_quoteInstanceFixture, parametersOfGetDetailsViewById);
            var result2 = this.GetResultOfMethod<string>(MethodGetDetailsViewById, parametersOfGetDetailsViewById, methodGetDetailsViewByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDetailsViewById.ShouldBeNull();
            methodGetDetailsViewByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetDetailsViewById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            Type [] methodGetDetailsViewByIdParametersTypes = null;
            object[] parametersOfGetDetailsViewById = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDetailsViewById, parametersOfGetDetailsViewById, methodGetDetailsViewByIdParametersTypes);

            // Assert
            parametersOfGetDetailsViewById.ShouldBeNull();
            methodGetDetailsViewByIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetDetailsViewById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            Type [] methodGetDetailsViewByIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDetailsViewByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetDetailsViewById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            Type [] methodGetDetailsViewByIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDetailsViewByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetDetailsViewById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailsViewById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Quote_GetQuoteById_Method_Call_Internally(Type[] types)
        {
            var methodGetQuoteByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQuoteById, methodGetQuoteByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);

            // Act
            Action executeAction = () => _quoteInstance.GetQuoteById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _quoteInstance.GetQuoteById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            Type [] methodGetQuoteByIdParametersTypes = null;
            object[] parametersOfGetQuoteById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQuoteById, methodGetQuoteByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_quoteInstanceFixture, parametersOfGetQuoteById);
            var result2 = this.GetResultOfMethod<string>(MethodGetQuoteById, parametersOfGetQuoteById, methodGetQuoteByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQuoteById.ShouldBeNull();
            methodGetQuoteByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            Type [] methodGetQuoteByIdParametersTypes = null;
            object[] parametersOfGetQuoteById = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQuoteById, parametersOfGetQuoteById, methodGetQuoteByIdParametersTypes);

            // Assert
            parametersOfGetQuoteById.ShouldBeNull();
            methodGetQuoteByIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            Type [] methodGetQuoteByIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQuoteById, methodGetQuoteByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQuoteByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            Type [] methodGetQuoteByIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQuoteById, methodGetQuoteByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQuoteByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQuoteById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Quote_GetQuoteById_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetQuoteByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQuoteById, methodGetQuoteByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            var primaryId = this.CreateType<string>();
            var methodGetQuoteByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetQuoteById = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQuoteById, methodGetQuoteByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_quoteInstanceFixture, parametersOfGetQuoteById);
            var result2 = this.GetResultOfMethod<string>(MethodGetQuoteById, parametersOfGetQuoteById, methodGetQuoteByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQuoteById.ShouldNotBeNull();
            parametersOfGetQuoteById.Length.ShouldBe(1);
            methodGetQuoteByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            var primaryId = this.CreateType<string>();
            var methodGetQuoteByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetQuoteById = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQuoteById, parametersOfGetQuoteById, methodGetQuoteByIdParametersTypes);

            // Assert
            parametersOfGetQuoteById.ShouldNotBeNull();
            parametersOfGetQuoteById.Length.ShouldBe(1);
            methodGetQuoteByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            var methodGetQuoteByIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQuoteById, methodGetQuoteByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQuoteByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            var methodGetQuoteByIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQuoteById, methodGetQuoteByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQuoteByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQuoteById, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQuoteById) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Quote_GetQuoteById_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQuoteById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQuoteById, 1);
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