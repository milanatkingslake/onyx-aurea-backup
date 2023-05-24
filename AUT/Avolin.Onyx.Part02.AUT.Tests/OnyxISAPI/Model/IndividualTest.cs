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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Individual" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IndividualTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Individual" />)
        /// </summary>
        public IndividualTest() : base(typeof(Individual))
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

        #region General Initializer : Class (Individual) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _individualInstanceType;
        private Individual _individualInstance;
        private Individual _individualInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Individual" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _individualInstanceType = typeof(Individual);
            _individualInstanceFixture = this.Create<Individual>(false);
            _individualInstance = _individualInstanceFixture ?? this.Create<Individual>(true);
            CurrentInstance = _individualInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Individual) Initializer

        #region Methods

        private const string MethodGet = "Get";
        private const string MethodGetIndividualById = "GetIndividualById";
        private const string MethodGetDetailsViewById = "GetDetailsViewById";
        private const string MethodGetIndividualPrimaryId = "GetIndividualPrimaryId";
        private const string MethodUpdate = "Update";
        private const string MethodGetIndividualLBOParameter = "GetIndividualLBOParameter";
        private const string MethodGetIndividualFieldMetaData = "GetIndividualFieldMetaData";
        private const string MethodSave = "Save";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";
        private const string FieldconfigLBOMethodName = "configLBOMethodName";

        #endregion

        #endregion

        #region General Initializer : Class (Individual) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Individual" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Individual_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Individual) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Individual" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Individual_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Individual)

        #region General Initializer : Class (Individual) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Individual" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGet, 0)]
        [TestCase(MethodGetIndividualById, 0)]
        [TestCase(MethodGetDetailsViewById, 0)]
        [TestCase(MethodGetIndividualById, 1)]
        [TestCase(MethodGetIndividualPrimaryId, 0)]
        [TestCase(MethodUpdate, 0)]
        [TestCase(MethodGetIndividualLBOParameter, 0)]
        [TestCase(MethodGetIndividualFieldMetaData, 0)]
        [TestCase(MethodSave, 0)]
        public void AUT_Individual_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Individual) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Individual" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [TestCase(FieldconfigLBOMethodName)]
        [Category("AUT Fields")]
        public void AUT_Individual_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Individual) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Individual" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Individual_Is_Instance_Present_Test()
        {
            // Assert
            _individualInstanceType.ShouldNotBeNull();
            _individualInstance.ShouldNotBeNull();
            _individualInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Individual) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Individual" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Individual_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _individualInstance.ShouldBeAssignableTo<Individual>();
            _individualInstanceFixture.ShouldBeAssignableTo<Individual>();
            CurrentInstance.ShouldBeAssignableTo<Individual>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Individual) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Individual_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Individual instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Individual(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _individualInstance.ShouldNotBeNull();
            _individualInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Individual>();
        }

        #endregion

        #region General Constructor : Class (Individual) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Individual_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Individual instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Individual(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _individualInstance.ShouldNotBeNull();
            _individualInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Get_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGet, methodGetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfGet);
            var result2 = this.GetResultOfMethod<string>(MethodGet, parametersOfGet, methodGetParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGet.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Get_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGet, parametersOfGet, methodGetParametersTypes);

            // Assert
            parametersOfGet.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Get_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Get_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Get_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            var currentMethodInfo = this.GetMethodInfo(MethodGet, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Individual_GetIndividualById_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualById, methodGetIndividualByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);

            // Act
            Action executeAction = () => _individualInstance.GetIndividualById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _individualInstance.GetIndividualById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            Type [] methodGetIndividualByIdParametersTypes = null;
            object[] parametersOfGetIndividualById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualById, methodGetIndividualByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfGetIndividualById);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualById, parametersOfGetIndividualById, methodGetIndividualByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualById.ShouldBeNull();
            methodGetIndividualByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            Type [] methodGetIndividualByIdParametersTypes = null;
            object[] parametersOfGetIndividualById = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualById, parametersOfGetIndividualById, methodGetIndividualByIdParametersTypes);

            // Assert
            parametersOfGetIndividualById.ShouldBeNull();
            methodGetIndividualByIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            Type [] methodGetIndividualByIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualById, methodGetIndividualByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            Type [] methodGetIndividualByIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualById, methodGetIndividualByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Individual_GetDetailsViewById_Method_Call_Internally(Type[] types)
        {
            var methodGetDetailsViewByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetDetailsViewById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);

            // Act
            Action executeAction = () => _individualInstance.GetDetailsViewById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetDetailsViewById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _individualInstance.GetDetailsViewById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetDetailsViewById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            Type [] methodGetDetailsViewByIdParametersTypes = null;
            object[] parametersOfGetDetailsViewById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfGetDetailsViewById);
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
        public void AUT_Individual_GetDetailsViewById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_Individual_GetDetailsViewById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_Individual_GetDetailsViewById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_Individual_GetDetailsViewById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetIndividualById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Individual_GetIndividualById_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetIndividualByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualById, methodGetIndividualByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            var primaryId = this.CreateType<string>();
            var methodGetIndividualByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIndividualById = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualById, methodGetIndividualByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfGetIndividualById);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualById, parametersOfGetIndividualById, methodGetIndividualByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualById.ShouldNotBeNull();
            parametersOfGetIndividualById.Length.ShouldBe(1);
            methodGetIndividualByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            var primaryId = this.CreateType<string>();
            var methodGetIndividualByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIndividualById = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualById, parametersOfGetIndividualById, methodGetIndividualByIdParametersTypes);

            // Assert
            parametersOfGetIndividualById.ShouldNotBeNull();
            parametersOfGetIndividualById.Length.ShouldBe(1);
            methodGetIndividualByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            var methodGetIndividualByIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualById, methodGetIndividualByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            var methodGetIndividualByIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualById, methodGetIndividualByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualById, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualById) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualById_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualById, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIndividualPrimaryId) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Individual_GetIndividualPrimaryId_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualPrimaryIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualPrimaryId, methodGetIndividualPrimaryIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualPrimaryId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualPrimaryId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualPrimaryId);
            var lboReturnXml = this.CreateType<string>();
            var methodGetIndividualPrimaryIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIndividualPrimaryId = { lboReturnXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualPrimaryId, methodGetIndividualPrimaryIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfGetIndividualPrimaryId);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualPrimaryId, parametersOfGetIndividualPrimaryId, methodGetIndividualPrimaryIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualPrimaryId.ShouldNotBeNull();
            parametersOfGetIndividualPrimaryId.Length.ShouldBe(1);
            methodGetIndividualPrimaryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIndividualPrimaryId) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualPrimaryId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualPrimaryId);
            var lboReturnXml = this.CreateType<string>();
            var methodGetIndividualPrimaryIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIndividualPrimaryId = { lboReturnXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualPrimaryId, parametersOfGetIndividualPrimaryId, methodGetIndividualPrimaryIdParametersTypes);

            // Assert
            parametersOfGetIndividualPrimaryId.ShouldNotBeNull();
            parametersOfGetIndividualPrimaryId.Length.ShouldBe(1);
            methodGetIndividualPrimaryIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualPrimaryId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualPrimaryId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualPrimaryId);
            var methodGetIndividualPrimaryIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualPrimaryId, methodGetIndividualPrimaryIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualPrimaryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIndividualPrimaryId) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualPrimaryId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualPrimaryId);
            var methodGetIndividualPrimaryIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualPrimaryId, methodGetIndividualPrimaryIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualPrimaryIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIndividualPrimaryId) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualPrimaryId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualPrimaryId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualPrimaryId) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualPrimaryId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualPrimaryId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Individual_Update_Method_Call_Internally(Type[] types)
        {
            var methodUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Update_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);

            // Act
            Action executeAction = () => _individualInstance.Update();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Update_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _individualInstance.Update();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Update_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, methodUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfUpdate);
            var result2 = this.GetResultOfMethod<string>(MethodUpdate, parametersOfUpdate, methodUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdate.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Update_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdate, parametersOfUpdate, methodUpdateParametersTypes);

            // Assert
            parametersOfUpdate.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Update_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Update_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Update_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualLBOParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Individual_GetIndividualLBOParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualLBOParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualLBOParameter, methodGetIndividualLBOParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualLBOParameter) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualLBOParameter_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualLBOParameter);

            // Act
            Action executeAction = () => _individualInstance.GetIndividualLBOParameter();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualLBOParameter) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualLBOParameter_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualLBOParameter);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _individualInstance.GetIndividualLBOParameter();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualLBOParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualLBOParameter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualLBOParameter);
            Type [] methodGetIndividualLBOParameterParametersTypes = null;
            object[] parametersOfGetIndividualLBOParameter = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualLBOParameter, methodGetIndividualLBOParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfGetIndividualLBOParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualLBOParameter, parametersOfGetIndividualLBOParameter, methodGetIndividualLBOParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualLBOParameter.ShouldBeNull();
            methodGetIndividualLBOParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualLBOParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualLBOParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualLBOParameter);
            Type [] methodGetIndividualLBOParameterParametersTypes = null;
            object[] parametersOfGetIndividualLBOParameter = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualLBOParameter, parametersOfGetIndividualLBOParameter, methodGetIndividualLBOParameterParametersTypes);

            // Assert
            parametersOfGetIndividualLBOParameter.ShouldBeNull();
            methodGetIndividualLBOParameterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualLBOParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualLBOParameter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualLBOParameter);
            Type [] methodGetIndividualLBOParameterParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualLBOParameter, methodGetIndividualLBOParameterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualLBOParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualLBOParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualLBOParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualLBOParameter);
            Type [] methodGetIndividualLBOParameterParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualLBOParameter, methodGetIndividualLBOParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualLBOParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualLBOParameter) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualLBOParameter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualLBOParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualLBOParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualFieldMetaData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Individual_GetIndividualFieldMetaData_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualFieldMetaDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualFieldMetaData, methodGetIndividualFieldMetaDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualFieldMetaData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualFieldMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFieldMetaData);

            // Act
            Action executeAction = () => _individualInstance.GetIndividualFieldMetaData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualFieldMetaData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualFieldMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFieldMetaData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _individualInstance.GetIndividualFieldMetaData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualFieldMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualFieldMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFieldMetaData);
            Type [] methodGetIndividualFieldMetaDataParametersTypes = null;
            object[] parametersOfGetIndividualFieldMetaData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualFieldMetaData, methodGetIndividualFieldMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfGetIndividualFieldMetaData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualFieldMetaData, parametersOfGetIndividualFieldMetaData, methodGetIndividualFieldMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualFieldMetaData.ShouldBeNull();
            methodGetIndividualFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualFieldMetaData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualFieldMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFieldMetaData);
            Type [] methodGetIndividualFieldMetaDataParametersTypes = null;
            object[] parametersOfGetIndividualFieldMetaData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualFieldMetaData, parametersOfGetIndividualFieldMetaData, methodGetIndividualFieldMetaDataParametersTypes);

            // Assert
            parametersOfGetIndividualFieldMetaData.ShouldBeNull();
            methodGetIndividualFieldMetaDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualFieldMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualFieldMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFieldMetaData);
            Type [] methodGetIndividualFieldMetaDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualFieldMetaData, methodGetIndividualFieldMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualFieldMetaData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualFieldMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFieldMetaData);
            Type [] methodGetIndividualFieldMetaDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualFieldMetaData, methodGetIndividualFieldMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualFieldMetaData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_GetIndividualFieldMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualFieldMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualFieldMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Individual_Save_Method_Call_Internally(Type[] types)
        {
            var methodSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Save_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);

            // Act
            Action executeAction = () => _individualInstance.Save();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Save_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _individualInstance.Save();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Save_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;
            object[] parametersOfSave = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSave, methodSaveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_individualInstanceFixture, parametersOfSave);
            var result2 = this.GetResultOfMethod<string>(MethodSave, parametersOfSave, methodSaveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSave.ShouldBeNull();
            methodSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Save_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;
            object[] parametersOfSave = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSave, parametersOfSave, methodSaveParametersTypes);

            // Assert
            parametersOfSave.ShouldBeNull();
            methodSaveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Save_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Save_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Individual_Save_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var currentMethodInfo = this.GetMethodInfo(MethodSave, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}