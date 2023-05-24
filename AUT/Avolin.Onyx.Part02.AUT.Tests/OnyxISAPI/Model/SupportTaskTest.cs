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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.SupportTask" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SupportTaskTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SupportTask" />)
        /// </summary>
        public SupportTaskTest() : base(typeof(SupportTask))
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

        #region General Initializer : Class (SupportTask) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _supportTaskInstanceType;
        private SupportTask _supportTaskInstance;
        private SupportTask _supportTaskInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SupportTask" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _supportTaskInstanceType = typeof(SupportTask);
            _supportTaskInstanceFixture = this.Create<SupportTask>(false);
            _supportTaskInstance = _supportTaskInstanceFixture ?? this.Create<SupportTask>(true);
            CurrentInstance = _supportTaskInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SupportTask) Initializer

        #region Methods

        private const string MethodGet = "Get";
        private const string MethodUpdate = "Update";
        private const string MethodUpdateRecallDate = "UpdateRecallDate";
        private const string MethodGetDetailsViewById = "GetDetailsViewById";
        private const string MethodGetSupportTaskById = "GetSupportTaskById";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";
        private const string FieldconfigLBOMethodName = "configLBOMethodName";

        #endregion

        #endregion

        #region General Initializer : Class (SupportTask) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SupportTask" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SupportTask_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SupportTask) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SupportTask" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SupportTask_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SupportTask)

        #region General Initializer : Class (SupportTask) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SupportTask" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGet, 0)]
        [TestCase(MethodUpdate, 0)]
        [TestCase(MethodUpdateRecallDate, 0)]
        [TestCase(MethodGetDetailsViewById, 0)]
        [TestCase(MethodGetSupportTaskById, 0)]
        [TestCase(MethodGetSupportTaskById, 1)]
        public void AUT_SupportTask_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SupportTask) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SupportTask" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [TestCase(FieldconfigLBOMethodName)]
        [Category("AUT Fields")]
        public void AUT_SupportTask_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SupportTask) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SupportTask" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SupportTask_Is_Instance_Present_Test()
        {
            // Assert
            _supportTaskInstanceType.ShouldNotBeNull();
            _supportTaskInstance.ShouldNotBeNull();
            _supportTaskInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SupportTask) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SupportTask" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SupportTask_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _supportTaskInstance.ShouldBeAssignableTo<SupportTask>();
            _supportTaskInstanceFixture.ShouldBeAssignableTo<SupportTask>();
            CurrentInstance.ShouldBeAssignableTo<SupportTask>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SupportTask) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SupportTask_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            SupportTask instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SupportTask(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _supportTaskInstance.ShouldNotBeNull();
            _supportTaskInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SupportTask>();
        }

        #endregion

        #region General Constructor : Class (SupportTask) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SupportTask_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            SupportTask instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SupportTask(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _supportTaskInstance.ShouldNotBeNull();
            _supportTaskInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_Get_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGet, methodGetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportTaskInstanceFixture, parametersOfGet);
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
        public void AUT_SupportTask_Get_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SupportTask_Get_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_SupportTask_Get_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SupportTask_Get_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (Update) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SupportTask_Update_Method_Call_Internally(Type[] types)
        {
            var methodUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_Update_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);

            // Act
            Action executeAction = () => _supportTaskInstance.Update();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_Update_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _supportTaskInstance.Update();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_Update_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, methodUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportTaskInstanceFixture, parametersOfUpdate);
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
        public void AUT_SupportTask_Update_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SupportTask_Update_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_SupportTask_Update_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SupportTask_Update_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (UpdateRecallDate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SupportTask_UpdateRecallDate_Method_Call_Internally(Type[] types)
        {
            var methodUpdateRecallDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_UpdateRecallDate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);

            // Act
            Action executeAction = () => _supportTaskInstance.UpdateRecallDate();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_UpdateRecallDate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _supportTaskInstance.UpdateRecallDate();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_UpdateRecallDate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;
            object[] parametersOfUpdateRecallDate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportTaskInstanceFixture, parametersOfUpdateRecallDate);
            var result2 = this.GetResultOfMethod<string>(MethodUpdateRecallDate, parametersOfUpdateRecallDate, methodUpdateRecallDateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateRecallDate.ShouldBeNull();
            methodUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_UpdateRecallDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;
            object[] parametersOfUpdateRecallDate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdateRecallDate, parametersOfUpdateRecallDate, methodUpdateRecallDateParametersTypes);

            // Assert
            parametersOfUpdateRecallDate.ShouldBeNull();
            methodUpdateRecallDateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_UpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_UpdateRecallDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_UpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateRecallDate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SupportTask_GetDetailsViewById_Method_Call_Internally(Type[] types)
        {
            var methodGetDetailsViewByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetDetailsViewById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);

            // Act
            Action executeAction = () => _supportTaskInstance.GetDetailsViewById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetDetailsViewById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _supportTaskInstance.GetDetailsViewById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetDetailsViewById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            Type [] methodGetDetailsViewByIdParametersTypes = null;
            object[] parametersOfGetDetailsViewById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportTaskInstanceFixture, parametersOfGetDetailsViewById);
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
        public void AUT_SupportTask_GetDetailsViewById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SupportTask_GetDetailsViewById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_SupportTask_GetDetailsViewById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SupportTask_GetDetailsViewById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetSupportTaskById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SupportTask_GetSupportTaskById_Method_Call_Internally(Type[] types)
        {
            var methodGetSupportTaskByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);

            // Act
            Action executeAction = () => _supportTaskInstance.GetSupportTaskById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _supportTaskInstance.GetSupportTaskById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            Type [] methodGetSupportTaskByIdParametersTypes = null;
            object[] parametersOfGetSupportTaskById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSupportTaskById, methodGetSupportTaskByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportTaskInstanceFixture, parametersOfGetSupportTaskById);
            var result2 = this.GetResultOfMethod<string>(MethodGetSupportTaskById, parametersOfGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSupportTaskById.ShouldBeNull();
            methodGetSupportTaskByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            Type [] methodGetSupportTaskByIdParametersTypes = null;
            object[] parametersOfGetSupportTaskById = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSupportTaskById, parametersOfGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);

            // Assert
            parametersOfGetSupportTaskById.ShouldBeNull();
            methodGetSupportTaskByIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            Type [] methodGetSupportTaskByIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSupportTaskByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            Type [] methodGetSupportTaskByIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSupportTaskByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSupportTaskById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SupportTask_GetSupportTaskById_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetSupportTaskByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            var primaryId = this.CreateType<string>();
            var methodGetSupportTaskByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSupportTaskById = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSupportTaskById, methodGetSupportTaskByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportTaskInstanceFixture, parametersOfGetSupportTaskById);
            var result2 = this.GetResultOfMethod<string>(MethodGetSupportTaskById, parametersOfGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSupportTaskById.ShouldNotBeNull();
            parametersOfGetSupportTaskById.Length.ShouldBe(1);
            methodGetSupportTaskByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            var primaryId = this.CreateType<string>();
            var methodGetSupportTaskByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSupportTaskById = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSupportTaskById, parametersOfGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);

            // Assert
            parametersOfGetSupportTaskById.ShouldNotBeNull();
            parametersOfGetSupportTaskById.Length.ShouldBe(1);
            methodGetSupportTaskByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            var methodGetSupportTaskByIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSupportTaskByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            var methodGetSupportTaskByIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSupportTaskById, methodGetSupportTaskByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSupportTaskByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSupportTaskById, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSupportTaskById) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportTask_GetSupportTaskById_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSupportTaskById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSupportTaskById, 1);
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