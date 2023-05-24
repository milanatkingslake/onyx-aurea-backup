using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Incident" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class IncidentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Incident" />)
        /// </summary>
        public IncidentTest() : base(typeof(Incident))
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

        #region General Initializer : Class (Incident) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _incidentInstanceType;
        private Incident _incidentInstance;
        private Incident _incidentInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Incident" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentInstanceType = typeof(Incident);
            _incidentInstanceFixture = this.Create<Incident>(false);
            _incidentInstance = _incidentInstanceFixture ?? this.Create<Incident>(true);
            CurrentInstance = _incidentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Incident) Initializer

        #region Methods

        private const string MethodGetDetailsViewById = "GetDetailsViewById";
        private const string MethodGetIncidentById = "GetIncidentById";
        private const string MethodGetIncidentDetails = "GetIncidentDetails";
        private const string MethodGetIncidentProductDetailsById = "GetIncidentProductDetailsById";
        private const string MethodGetRetrieveByTrackingCode = "GetRetrieveByTrackingCode";
        private const string MethodGetIncidentFieldMetaData = "GetIncidentFieldMetaData";
        private const string MethodSave = "Save";
        private const string MethodGetIncidentPrimaryId = "GetIncidentPrimaryId";
        private const string MethodRecentIncidents = "RecentIncidents";
        private const string MethodconvertRecentIncidentsNodesToAttribute = "convertRecentIncidentsNodesToAttribute";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";
        private const string FieldIncident_Support = "Incident_Support";
        private const string FieldIncident_Service = "Incident_Service";
        private const string FieldIncident_Sales = "Incident_Sales";
        private const string FieldconfigLBOMethodName = "configLBOMethodName";

        #endregion

        #endregion

        #region General Initializer : Class (Incident) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Incident" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Incident_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Incident) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Incident" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Incident_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Incident)

        #region General Initializer : Class (Incident) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Incident" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDetailsViewById, 0)]
        [TestCase(MethodGetIncidentById, 0)]
        [TestCase(MethodGetIncidentById, 1)]
        [TestCase(MethodGetIncidentDetails, 0)]
        [TestCase(MethodGetIncidentProductDetailsById, 0)]
        [TestCase(MethodGetRetrieveByTrackingCode, 0)]
        [TestCase(MethodGetIncidentFieldMetaData, 0)]
        [TestCase(MethodSave, 0)]
        [TestCase(MethodGetIncidentPrimaryId, 0)]
        [TestCase(MethodRecentIncidents, 0)]
        [TestCase(MethodconvertRecentIncidentsNodesToAttribute, 0)]
        public void AUT_Incident_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Incident) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Incident" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [TestCase(FieldIncident_Support)]
        [TestCase(FieldIncident_Service)]
        [TestCase(FieldIncident_Sales)]
        [TestCase(FieldconfigLBOMethodName)]
        [Category("AUT Fields")]
        public void AUT_Incident_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Incident) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Incident" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Incident_Is_Instance_Present_Test()
        {
            // Assert
            _incidentInstanceType.ShouldNotBeNull();
            _incidentInstance.ShouldNotBeNull();
            _incidentInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Incident) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Incident" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Incident_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _incidentInstance.ShouldBeAssignableTo<Incident>();
            _incidentInstanceFixture.ShouldBeAssignableTo<Incident>();
            CurrentInstance.ShouldBeAssignableTo<Incident>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Incident) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Incident_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Incident instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Incident(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _incidentInstance.ShouldNotBeNull();
            _incidentInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Incident>();
        }

        #endregion

        #region General Constructor : Class (Incident) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Incident_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Incident instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Incident(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _incidentInstance.ShouldNotBeNull();
            _incidentInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetDetailsViewById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetDetailsViewById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);

            // Act
            Action executeAction = () => _incidentInstance.GetDetailsViewById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetDetailsViewById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _incidentInstance.GetDetailsViewById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDetailsViewById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetDetailsViewById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDetailsViewById);
            Type [] methodGetDetailsViewByIdParametersTypes = null;
            object[] parametersOfGetDetailsViewById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDetailsViewById, methodGetDetailsViewByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfGetDetailsViewById);
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
        public void AUT_Incident_GetDetailsViewById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_Incident_GetDetailsViewById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_Incident_GetDetailsViewById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_Incident_GetDetailsViewById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetIncidentById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_GetIncidentById_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentById, methodGetIncidentByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);

            // Act
            Action executeAction = () => _incidentInstance.GetIncidentById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _incidentInstance.GetIncidentById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            Type [] methodGetIncidentByIdParametersTypes = null;
            object[] parametersOfGetIncidentById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentById, methodGetIncidentByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfGetIncidentById);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentById, parametersOfGetIncidentById, methodGetIncidentByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentById.ShouldBeNull();
            methodGetIncidentByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            Type [] methodGetIncidentByIdParametersTypes = null;
            object[] parametersOfGetIncidentById = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentById, parametersOfGetIncidentById, methodGetIncidentByIdParametersTypes);

            // Assert
            parametersOfGetIncidentById.ShouldBeNull();
            methodGetIncidentByIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            Type [] methodGetIncidentByIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentById, methodGetIncidentByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            Type [] methodGetIncidentByIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentById, methodGetIncidentByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_GetIncidentById_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetIncidentByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentById, methodGetIncidentByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            var primaryId = this.CreateType<string>();
            var methodGetIncidentByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentById = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentById, methodGetIncidentByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfGetIncidentById);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentById, parametersOfGetIncidentById, methodGetIncidentByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentById.ShouldNotBeNull();
            parametersOfGetIncidentById.Length.ShouldBe(1);
            methodGetIncidentByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            var primaryId = this.CreateType<string>();
            var methodGetIncidentByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentById = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentById, parametersOfGetIncidentById, methodGetIncidentByIdParametersTypes);

            // Assert
            parametersOfGetIncidentById.ShouldNotBeNull();
            parametersOfGetIncidentById.Length.ShouldBe(1);
            methodGetIncidentByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            var methodGetIncidentByIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentById, methodGetIncidentByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            var methodGetIncidentByIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentById, methodGetIncidentByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentById, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentById) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentById_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentById, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentDetails) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_GetIncidentDetails_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentDetailsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentDetails, methodGetIncidentDetailsParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentDetails) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentDetails_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentDetails);
            var primaryId = this.CreateType<string>();
            var methodGetIncidentDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentDetails = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentDetails, methodGetIncidentDetailsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfGetIncidentDetails);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentDetails, parametersOfGetIncidentDetails, methodGetIncidentDetailsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentDetails.ShouldNotBeNull();
            parametersOfGetIncidentDetails.Length.ShouldBe(1);
            methodGetIncidentDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentDetails) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentDetails_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentDetails);
            var primaryId = this.CreateType<string>();
            var methodGetIncidentDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentDetails = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentDetails, parametersOfGetIncidentDetails, methodGetIncidentDetailsParametersTypes);

            // Assert
            parametersOfGetIncidentDetails.ShouldNotBeNull();
            parametersOfGetIncidentDetails.Length.ShouldBe(1);
            methodGetIncidentDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentDetails) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentDetails_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentDetails);
            var methodGetIncidentDetailsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentDetails, methodGetIncidentDetailsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentDetails) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentDetails_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentDetails);
            var methodGetIncidentDetailsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentDetails, methodGetIncidentDetailsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentDetailsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentDetails) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentDetails_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentDetails, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentDetails) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentDetails_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentDetails, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentProductDetailsById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_GetIncidentProductDetailsById_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentProductDetailsByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductDetailsById, methodGetIncidentProductDetailsByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentProductDetailsById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentProductDetailsById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDetailsById);

            // Act
            Action executeAction = () => _incidentInstance.GetIncidentProductDetailsById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentProductDetailsById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentProductDetailsById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDetailsById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _incidentInstance.GetIncidentProductDetailsById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDetailsById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentProductDetailsById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDetailsById);
            Type [] methodGetIncidentProductDetailsByIdParametersTypes = null;
            object[] parametersOfGetIncidentProductDetailsById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProductDetailsById, methodGetIncidentProductDetailsByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfGetIncidentProductDetailsById);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentProductDetailsById, parametersOfGetIncidentProductDetailsById, methodGetIncidentProductDetailsByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentProductDetailsById.ShouldBeNull();
            methodGetIncidentProductDetailsByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDetailsById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentProductDetailsById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDetailsById);
            Type [] methodGetIncidentProductDetailsByIdParametersTypes = null;
            object[] parametersOfGetIncidentProductDetailsById = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentProductDetailsById, parametersOfGetIncidentProductDetailsById, methodGetIncidentProductDetailsByIdParametersTypes);

            // Assert
            parametersOfGetIncidentProductDetailsById.ShouldBeNull();
            methodGetIncidentProductDetailsByIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentProductDetailsById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentProductDetailsById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDetailsById);
            Type [] methodGetIncidentProductDetailsByIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductDetailsById, methodGetIncidentProductDetailsByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentProductDetailsByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDetailsById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentProductDetailsById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDetailsById);
            Type [] methodGetIncidentProductDetailsByIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductDetailsById, methodGetIncidentProductDetailsByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentProductDetailsByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDetailsById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentProductDetailsById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDetailsById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProductDetailsById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRetrieveByTrackingCode) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_GetRetrieveByTrackingCode_Method_Call_Internally(Type[] types)
        {
            var methodGetRetrieveByTrackingCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRetrieveByTrackingCode, methodGetRetrieveByTrackingCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetRetrieveByTrackingCode) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetRetrieveByTrackingCode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRetrieveByTrackingCode);

            // Act
            Action executeAction = () => _incidentInstance.GetRetrieveByTrackingCode();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRetrieveByTrackingCode) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetRetrieveByTrackingCode_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRetrieveByTrackingCode);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _incidentInstance.GetRetrieveByTrackingCode();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRetrieveByTrackingCode) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetRetrieveByTrackingCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRetrieveByTrackingCode);
            Type [] methodGetRetrieveByTrackingCodeParametersTypes = null;
            object[] parametersOfGetRetrieveByTrackingCode = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRetrieveByTrackingCode, methodGetRetrieveByTrackingCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfGetRetrieveByTrackingCode);
            var result2 = this.GetResultOfMethod<string>(MethodGetRetrieveByTrackingCode, parametersOfGetRetrieveByTrackingCode, methodGetRetrieveByTrackingCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRetrieveByTrackingCode.ShouldBeNull();
            methodGetRetrieveByTrackingCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRetrieveByTrackingCode) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetRetrieveByTrackingCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRetrieveByTrackingCode);
            Type [] methodGetRetrieveByTrackingCodeParametersTypes = null;
            object[] parametersOfGetRetrieveByTrackingCode = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRetrieveByTrackingCode, parametersOfGetRetrieveByTrackingCode, methodGetRetrieveByTrackingCodeParametersTypes);

            // Assert
            parametersOfGetRetrieveByTrackingCode.ShouldBeNull();
            methodGetRetrieveByTrackingCodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRetrieveByTrackingCode) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetRetrieveByTrackingCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRetrieveByTrackingCode);
            Type [] methodGetRetrieveByTrackingCodeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRetrieveByTrackingCode, methodGetRetrieveByTrackingCodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRetrieveByTrackingCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRetrieveByTrackingCode) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetRetrieveByTrackingCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRetrieveByTrackingCode);
            Type [] methodGetRetrieveByTrackingCodeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRetrieveByTrackingCode, methodGetRetrieveByTrackingCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRetrieveByTrackingCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRetrieveByTrackingCode) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetRetrieveByTrackingCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRetrieveByTrackingCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRetrieveByTrackingCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentFieldMetaData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_GetIncidentFieldMetaData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentFieldMetaDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentFieldMetaData, methodGetIncidentFieldMetaDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentFieldMetaData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentFieldMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentFieldMetaData);

            // Act
            Action executeAction = () => _incidentInstance.GetIncidentFieldMetaData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentFieldMetaData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentFieldMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentFieldMetaData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _incidentInstance.GetIncidentFieldMetaData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentFieldMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentFieldMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentFieldMetaData);
            Type [] methodGetIncidentFieldMetaDataParametersTypes = null;
            object[] parametersOfGetIncidentFieldMetaData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentFieldMetaData, methodGetIncidentFieldMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfGetIncidentFieldMetaData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentFieldMetaData, parametersOfGetIncidentFieldMetaData, methodGetIncidentFieldMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentFieldMetaData.ShouldBeNull();
            methodGetIncidentFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentFieldMetaData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentFieldMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentFieldMetaData);
            Type [] methodGetIncidentFieldMetaDataParametersTypes = null;
            object[] parametersOfGetIncidentFieldMetaData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentFieldMetaData, parametersOfGetIncidentFieldMetaData, methodGetIncidentFieldMetaDataParametersTypes);

            // Assert
            parametersOfGetIncidentFieldMetaData.ShouldBeNull();
            methodGetIncidentFieldMetaDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentFieldMetaData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentFieldMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentFieldMetaData);
            Type [] methodGetIncidentFieldMetaDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentFieldMetaData, methodGetIncidentFieldMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentFieldMetaData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentFieldMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentFieldMetaData);
            Type [] methodGetIncidentFieldMetaDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentFieldMetaData, methodGetIncidentFieldMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentFieldMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentFieldMetaData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentFieldMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentFieldMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentFieldMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_Save_Method_Call_Internally(Type[] types)
        {
            var methodSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_Save_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);

            // Act
            Action executeAction = () => _incidentInstance.Save();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_Save_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _incidentInstance.Save();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_Save_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;
            object[] parametersOfSave = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSave, methodSaveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfSave);
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
        public void AUT_Incident_Save_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_Incident_Save_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_Incident_Save_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_Incident_Save_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetIncidentPrimaryId) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_GetIncidentPrimaryId_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentPrimaryIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentPrimaryId, methodGetIncidentPrimaryIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentPrimaryId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentPrimaryId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPrimaryId);
            var lboReturnXml = this.CreateType<string>();
            var methodGetIncidentPrimaryIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentPrimaryId = { lboReturnXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentPrimaryId, methodGetIncidentPrimaryIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfGetIncidentPrimaryId);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentPrimaryId, parametersOfGetIncidentPrimaryId, methodGetIncidentPrimaryIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentPrimaryId.ShouldNotBeNull();
            parametersOfGetIncidentPrimaryId.Length.ShouldBe(1);
            methodGetIncidentPrimaryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentPrimaryId) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentPrimaryId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPrimaryId);
            var lboReturnXml = this.CreateType<string>();
            var methodGetIncidentPrimaryIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentPrimaryId = { lboReturnXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentPrimaryId, parametersOfGetIncidentPrimaryId, methodGetIncidentPrimaryIdParametersTypes);

            // Assert
            parametersOfGetIncidentPrimaryId.ShouldNotBeNull();
            parametersOfGetIncidentPrimaryId.Length.ShouldBe(1);
            methodGetIncidentPrimaryIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentPrimaryId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentPrimaryId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPrimaryId);
            var methodGetIncidentPrimaryIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentPrimaryId, methodGetIncidentPrimaryIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentPrimaryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentPrimaryId) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentPrimaryId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPrimaryId);
            var methodGetIncidentPrimaryIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentPrimaryId, methodGetIncidentPrimaryIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentPrimaryIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentPrimaryId) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentPrimaryId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentPrimaryId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentPrimaryId) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_GetIncidentPrimaryId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentPrimaryId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RecentIncidents) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_RecentIncidents_Method_Call_Internally(Type[] types)
        {
            var methodRecentIncidentsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRecentIncidents, methodRecentIncidentsParametersTypes);
        }

        #endregion

        #region Method Call : (RecentIncidents) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_RecentIncidents_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentIncidents);

            // Act
            Action executeAction = () => _incidentInstance.RecentIncidents();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RecentIncidents) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_RecentIncidents_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentIncidents);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _incidentInstance.RecentIncidents();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentIncidents) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_RecentIncidents_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentIncidents);
            Type [] methodRecentIncidentsParametersTypes = null;
            object[] parametersOfRecentIncidents = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRecentIncidents, methodRecentIncidentsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_incidentInstanceFixture, parametersOfRecentIncidents);
            var result2 = this.GetResultOfMethod<string>(MethodRecentIncidents, parametersOfRecentIncidents, methodRecentIncidentsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRecentIncidents.ShouldBeNull();
            methodRecentIncidentsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentIncidents) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_RecentIncidents_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentIncidents);
            Type [] methodRecentIncidentsParametersTypes = null;
            object[] parametersOfRecentIncidents = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRecentIncidents, parametersOfRecentIncidents, methodRecentIncidentsParametersTypes);

            // Assert
            parametersOfRecentIncidents.ShouldBeNull();
            methodRecentIncidentsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RecentIncidents) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_RecentIncidents_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentIncidents);
            Type [] methodRecentIncidentsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRecentIncidents, methodRecentIncidentsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRecentIncidentsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentIncidents) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_RecentIncidents_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentIncidents);
            Type [] methodRecentIncidentsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRecentIncidents, methodRecentIncidentsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRecentIncidentsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentIncidents) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_RecentIncidents_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentIncidents);
            var currentMethodInfo = this.GetMethodInfo(MethodRecentIncidents, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertRecentIncidentsNodesToAttribute) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Incident_convertRecentIncidentsNodesToAttribute_Method_Call_Internally(Type[] types)
        {
            var methodconvertRecentIncidentsNodesToAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconvertRecentIncidentsNodesToAttribute, methodconvertRecentIncidentsNodesToAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (convertRecentIncidentsNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_convertRecentIncidentsNodesToAttribute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentIncidentsNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodconvertRecentIncidentsNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertRecentIncidentsNodesToAttribute = { xmlString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodconvertRecentIncidentsNodesToAttribute, methodconvertRecentIncidentsNodesToAttributeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_incidentInstanceFixture, parametersOfconvertRecentIncidentsNodesToAttribute);
            var result2 = this.GetResultOfMethod<XElement>(MethodconvertRecentIncidentsNodesToAttribute, parametersOfconvertRecentIncidentsNodesToAttribute, methodconvertRecentIncidentsNodesToAttributeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfconvertRecentIncidentsNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertRecentIncidentsNodesToAttribute.Length.ShouldBe(1);
            methodconvertRecentIncidentsNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertRecentIncidentsNodesToAttribute) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_convertRecentIncidentsNodesToAttribute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentIncidentsNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodconvertRecentIncidentsNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertRecentIncidentsNodesToAttribute = { xmlString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodconvertRecentIncidentsNodesToAttribute, parametersOfconvertRecentIncidentsNodesToAttribute, methodconvertRecentIncidentsNodesToAttributeParametersTypes);

            // Assert
            parametersOfconvertRecentIncidentsNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertRecentIncidentsNodesToAttribute.Length.ShouldBe(1);
            methodconvertRecentIncidentsNodesToAttributeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (convertRecentIncidentsNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_convertRecentIncidentsNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentIncidentsNodesToAttribute);
            var methodconvertRecentIncidentsNodesToAttributeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconvertRecentIncidentsNodesToAttribute, methodconvertRecentIncidentsNodesToAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodconvertRecentIncidentsNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertRecentIncidentsNodesToAttribute) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_convertRecentIncidentsNodesToAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentIncidentsNodesToAttribute);
            var methodconvertRecentIncidentsNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconvertRecentIncidentsNodesToAttribute, methodconvertRecentIncidentsNodesToAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconvertRecentIncidentsNodesToAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertRecentIncidentsNodesToAttribute) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_convertRecentIncidentsNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentIncidentsNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertRecentIncidentsNodesToAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertRecentIncidentsNodesToAttribute) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Incident_convertRecentIncidentsNodesToAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentIncidentsNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertRecentIncidentsNodesToAttribute, 0);
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