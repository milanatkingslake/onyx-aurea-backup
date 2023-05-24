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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.WorkNote" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class WorkNoteTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="WorkNote" />)
        /// </summary>
        public WorkNoteTest() : base(typeof(WorkNote))
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

        #region General Initializer : Class (WorkNote) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _workNoteInstanceType;
        private WorkNote _workNoteInstance;
        private WorkNote _workNoteInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="WorkNote" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _workNoteInstanceType = typeof(WorkNote);
            _workNoteInstanceFixture = this.Create<WorkNote>(false);
            _workNoteInstance = _workNoteInstanceFixture ?? this.Create<WorkNote>(true);
            CurrentInstance = _workNoteInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (WorkNote) Initializer

        #region Methods

        private const string MethodGetWorkNoteFieldMetaData = "GetWorkNoteFieldMetaData";
        private const string MethodSave = "Save";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (WorkNote) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="WorkNote" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WorkNote_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (WorkNote) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="WorkNote" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WorkNote_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (WorkNote)

        #region General Initializer : Class (WorkNote) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="WorkNote" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetWorkNoteFieldMetaData, 0)]
        [TestCase(MethodSave, 0)]
        public void AUT_WorkNote_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (WorkNote) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="WorkNote" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_WorkNote_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (WorkNote) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="WorkNote" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_WorkNote_Is_Instance_Present_Test()
        {
            // Assert
            _workNoteInstanceType.ShouldNotBeNull();
            _workNoteInstance.ShouldNotBeNull();
            _workNoteInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (WorkNote) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="WorkNote" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_WorkNote_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _workNoteInstance.ShouldBeAssignableTo<WorkNote>();
            _workNoteInstanceFixture.ShouldBeAssignableTo<WorkNote>();
            CurrentInstance.ShouldBeAssignableTo<WorkNote>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (WorkNote) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_WorkNote_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            WorkNote instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new WorkNote(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _workNoteInstance.ShouldNotBeNull();
            _workNoteInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<WorkNote>();
        }

        #endregion

        #region General Constructor : Class (WorkNote) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_WorkNote_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            WorkNote instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new WorkNote(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _workNoteInstance.ShouldNotBeNull();
            _workNoteInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetWorkNoteFieldMetaData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_GetWorkNoteFieldMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkNoteFieldMetaData);

            // Act
            Action executeAction = () => _workNoteInstance.GetWorkNoteFieldMetaData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkNoteFieldMetaData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_GetWorkNoteFieldMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkNoteFieldMetaData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _workNoteInstance.GetWorkNoteFieldMetaData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkNoteFieldMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_GetWorkNoteFieldMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkNoteFieldMetaData);
            Type [] methodGetWorkNoteFieldMetaDataParametersTypes = null;
            object[] parametersOfGetWorkNoteFieldMetaData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkNoteFieldMetaData, methodGetWorkNoteFieldMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_workNoteInstanceFixture, parametersOfGetWorkNoteFieldMetaData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkNoteFieldMetaData, parametersOfGetWorkNoteFieldMetaData, methodGetWorkNoteFieldMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkNoteFieldMetaData.ShouldBeNull();
            methodGetWorkNoteFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkNoteFieldMetaData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_GetWorkNoteFieldMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkNoteFieldMetaData);
            Type [] methodGetWorkNoteFieldMetaDataParametersTypes = null;
            object[] parametersOfGetWorkNoteFieldMetaData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkNoteFieldMetaData, parametersOfGetWorkNoteFieldMetaData, methodGetWorkNoteFieldMetaDataParametersTypes);

            // Assert
            parametersOfGetWorkNoteFieldMetaData.ShouldBeNull();
            methodGetWorkNoteFieldMetaDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkNoteFieldMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_GetWorkNoteFieldMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkNoteFieldMetaData);
            Type [] methodGetWorkNoteFieldMetaDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkNoteFieldMetaData, methodGetWorkNoteFieldMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkNoteFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkNoteFieldMetaData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_GetWorkNoteFieldMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkNoteFieldMetaData);
            Type [] methodGetWorkNoteFieldMetaDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkNoteFieldMetaData, methodGetWorkNoteFieldMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkNoteFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkNoteFieldMetaData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_GetWorkNoteFieldMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkNoteFieldMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkNoteFieldMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WorkNote_Save_Method_Call_Internally(Type[] types)
        {
            var methodSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_Save_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);

            // Act
            Action executeAction = () => _workNoteInstance.Save();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_Save_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _workNoteInstance.Save();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WorkNote_Save_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;
            object[] parametersOfSave = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSave, methodSaveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_workNoteInstanceFixture, parametersOfSave);
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
        public void AUT_WorkNote_Save_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_WorkNote_Save_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_WorkNote_Save_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_WorkNote_Save_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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