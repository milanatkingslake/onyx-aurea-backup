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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.SupportIncident" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SupportIncidentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SupportIncident" />)
        /// </summary>
        public SupportIncidentTest() : base(typeof(SupportIncident))
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

        #region General Initializer : Class (SupportIncident) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _supportIncidentInstanceType;
        private SupportIncident _supportIncidentInstance;
        private SupportIncident _supportIncidentInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SupportIncident" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _supportIncidentInstanceType = typeof(SupportIncident);
            _supportIncidentInstanceFixture = this.Create<SupportIncident>(false);
            _supportIncidentInstance = _supportIncidentInstanceFixture ?? this.Create<SupportIncident>(true);
            CurrentInstance = _supportIncidentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SupportIncident) Initializer

        #region Methods

        private const string MethodGet = "Get";
        private const string MethodUpdate = "Update";
        private const string MethodUpdateRecallDate = "UpdateRecallDate";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (SupportIncident) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SupportIncident" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SupportIncident_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SupportIncident) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SupportIncident" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SupportIncident_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SupportIncident)

        #region General Initializer : Class (SupportIncident) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SupportIncident" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGet, 0)]
        [TestCase(MethodUpdate, 0)]
        [TestCase(MethodUpdateRecallDate, 0)]
        public void AUT_SupportIncident_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SupportIncident) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SupportIncident" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_SupportIncident_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SupportIncident) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SupportIncident" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SupportIncident_Is_Instance_Present_Test()
        {
            // Assert
            _supportIncidentInstanceType.ShouldNotBeNull();
            _supportIncidentInstance.ShouldNotBeNull();
            _supportIncidentInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SupportIncident) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SupportIncident" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SupportIncident_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _supportIncidentInstance.ShouldBeAssignableTo<SupportIncident>();
            _supportIncidentInstanceFixture.ShouldBeAssignableTo<SupportIncident>();
            CurrentInstance.ShouldBeAssignableTo<SupportIncident>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SupportIncident) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SupportIncident_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            SupportIncident instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SupportIncident(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _supportIncidentInstance.ShouldNotBeNull();
            _supportIncidentInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SupportIncident>();
        }

        #endregion

        #region General Constructor : Class (SupportIncident) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SupportIncident_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            SupportIncident instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SupportIncident(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _supportIncidentInstance.ShouldNotBeNull();
            _supportIncidentInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportIncident_Get_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGet, methodGetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportIncidentInstanceFixture, parametersOfGet);
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
        public void AUT_SupportIncident_Get_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SupportIncident_Get_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_SupportIncident_Get_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SupportIncident_Get_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        private void AUT_SupportIncident_Update_Method_Call_Internally(Type[] types)
        {
            var methodUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportIncident_Update_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);

            // Act
            Action executeAction = () => _supportIncidentInstance.Update();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportIncident_Update_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _supportIncidentInstance.Update();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportIncident_Update_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, methodUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportIncidentInstanceFixture, parametersOfUpdate);
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
        public void AUT_SupportIncident_Update_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SupportIncident_Update_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_SupportIncident_Update_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SupportIncident_Update_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        private void AUT_SupportIncident_UpdateRecallDate_Method_Call_Internally(Type[] types)
        {
            var methodUpdateRecallDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportIncident_UpdateRecallDate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);

            // Act
            Action executeAction = () => _supportIncidentInstance.UpdateRecallDate();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportIncident_UpdateRecallDate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _supportIncidentInstance.UpdateRecallDate();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SupportIncident_UpdateRecallDate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;
            object[] parametersOfUpdateRecallDate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_supportIncidentInstanceFixture, parametersOfUpdateRecallDate);
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
        public void AUT_SupportIncident_UpdateRecallDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_SupportIncident_UpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_SupportIncident_UpdateRecallDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_SupportIncident_UpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #endregion

        #endregion
    }
}