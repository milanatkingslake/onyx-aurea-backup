using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin.OEAS_Windows;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin.OEAS_Windows
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OEAS_Windows.OEASWebService" />)
    ///     and namespace <see cref="OnyxOutlookAddin.OEAS_Windows"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OEASWebServiceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OEASWebService" />)
        /// </summary>
        public OEASWebServiceTest() : base(typeof(OEASWebService))
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

        #region General Initializer : Class (OEASWebService) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oEASWebServiceInstanceType;
        private OEASWebService _oEASWebServiceInstance;
        private OEASWebService _oEASWebServiceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OEASWebService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEASWebServiceInstanceType = typeof(OEASWebService);
            _oEASWebServiceInstanceFixture = this.Create<OEASWebService>(false);
            _oEASWebServiceInstance = _oEASWebServiceInstanceFixture ?? this.Create<OEASWebService>(true);
            CurrentInstance = _oEASWebServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEASWebService) Initializer

        #region Properties

        private const string PropertyUrl = "Url";
        private const string PropertyUseDefaultCredentials = "UseDefaultCredentials";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";
        
        private const string MethodOnExecuteOperationCompleted = "OnExecuteOperationCompleted";
        private const string MethodClearSessionItems = "ClearSessionItems";
        private const string MethodClearSessionItemsAsync = "ClearSessionItemsAsync";
        private const string MethodOnClearSessionItemsOperationCompleted = "OnClearSessionItemsOperationCompleted";
        private const string MethodEndSession = "EndSession";
        private const string MethodEndSessionAsync = "EndSessionAsync";
        private const string MethodOnEndSessionOperationCompleted = "OnEndSessionOperationCompleted";
        private const string MethodGetContextXML = "GetContextXML";
        private const string MethodGetContextXMLAsync = "GetContextXMLAsync";
        private const string MethodOnGetContextXMLOperationCompleted = "OnGetContextXMLOperationCompleted";
        private const string MethodGetSessionItem = "GetSessionItem";
        private const string MethodGetSessionItemAsync = "GetSessionItemAsync";
        private const string MethodOnGetSessionItemOperationCompleted = "OnGetSessionItemOperationCompleted";
        private const string MethodGetSessionItems = "GetSessionItems";
        private const string MethodGetSessionItemsAsync = "GetSessionItemsAsync";
        private const string MethodOnGetSessionItemsOperationCompleted = "OnGetSessionItemsOperationCompleted";
        private const string MethodHasPermission = "HasPermission";
        private const string MethodHasPermissionAsync = "HasPermissionAsync";
        private const string MethodOnHasPermissionOperationCompleted = "OnHasPermissionOperationCompleted";
        private const string MethodHasPermissions = "HasPermissions";
        private const string MethodHasPermissionsAsync = "HasPermissionsAsync";
        private const string MethodOnHasPermissionsOperationCompleted = "OnHasPermissionsOperationCompleted";
        private const string MethodRemoveSessionItem = "RemoveSessionItem";
        private const string MethodRemoveSessionItemAsync = "RemoveSessionItemAsync";
        private const string MethodOnRemoveSessionItemOperationCompleted = "OnRemoveSessionItemOperationCompleted";
        private const string MethodSetSessionItem = "SetSessionItem";
        private const string MethodSetSessionItemAsync = "SetSessionItemAsync";
        private const string MethodOnSetSessionItemOperationCompleted = "OnSetSessionItemOperationCompleted";
        private const string MethodRetrieveNatLangString = "RetrieveNatLangString";
        private const string MethodRetrieveNatLangStringAsync = "RetrieveNatLangStringAsync";
        private const string MethodOnRetrieveNatLangStringOperationCompleted = "OnRetrieveNatLangStringOperationCompleted";
        private const string MethodRetrieveNatLangStringList = "RetrieveNatLangStringList";
        private const string MethodRetrieveNatLangStringListAsync = "RetrieveNatLangStringListAsync";
        private const string MethodOnRetrieveNatLangStringListOperationCompleted = "OnRetrieveNatLangStringListOperationCompleted";
        private const string MethodGetObjectInstance = "GetObjectInstance";
        private const string MethodGetObjectInstanceAsync = "GetObjectInstanceAsync";
        private const string MethodOnGetObjectInstanceOperationCompleted = "OnGetObjectInstanceOperationCompleted";
        private const string MethodGetObjectDefinition = "GetObjectDefinition";
        private const string MethodGetObjectDefinitionAsync = "GetObjectDefinitionAsync";
        private const string MethodOnGetObjectDefinitionOperationCompleted = "OnGetObjectDefinitionOperationCompleted";
        private const string MethodGetObjectList = "GetObjectList";
        private const string MethodGetObjectListAsync = "GetObjectListAsync";
        private const string MethodOnGetObjectListOperationCompleted = "OnGetObjectListOperationCompleted";
        private const string MethodGetConfiguredProperties = "GetConfiguredProperties";
        private const string MethodGetConfiguredPropertiesAsync = "GetConfiguredPropertiesAsync";
        private const string MethodOnGetConfiguredPropertiesOperationCompleted = "OnGetConfiguredPropertiesOperationCompleted";
        private const string MethodGetPropertyConstraints = "GetPropertyConstraints";
        private const string MethodGetPropertyConstraintsAsync = "GetPropertyConstraintsAsync";
        private const string MethodOnGetPropertyConstraintsOperationCompleted = "OnGetPropertyConstraintsOperationCompleted";
        private const string MethodCancelAsync = "CancelAsync";
        private const string MethodIsLocalFileSystemWebService = "IsLocalFileSystemWebService";

        #endregion

        #region Fields

        private const string FieldExecuteOperationCompleted = "ExecuteOperationCompleted";
        private const string FieldClearSessionItemsOperationCompleted = "ClearSessionItemsOperationCompleted";
        private const string FieldEndSessionOperationCompleted = "EndSessionOperationCompleted";
        private const string FieldGetContextXMLOperationCompleted = "GetContextXMLOperationCompleted";
        private const string FieldGetSessionItemOperationCompleted = "GetSessionItemOperationCompleted";
        private const string FieldGetSessionItemsOperationCompleted = "GetSessionItemsOperationCompleted";
        private const string FieldHasPermissionOperationCompleted = "HasPermissionOperationCompleted";
        private const string FieldHasPermissionsOperationCompleted = "HasPermissionsOperationCompleted";
        private const string FieldRemoveSessionItemOperationCompleted = "RemoveSessionItemOperationCompleted";
        private const string FieldSetSessionItemOperationCompleted = "SetSessionItemOperationCompleted";
        private const string FieldRetrieveNatLangStringOperationCompleted = "RetrieveNatLangStringOperationCompleted";
        private const string FieldRetrieveNatLangStringListOperationCompleted = "RetrieveNatLangStringListOperationCompleted";
        private const string FieldGetObjectInstanceOperationCompleted = "GetObjectInstanceOperationCompleted";
        private const string FieldGetObjectDefinitionOperationCompleted = "GetObjectDefinitionOperationCompleted";
        private const string FieldGetObjectListOperationCompleted = "GetObjectListOperationCompleted";
        private const string FieldGetConfiguredPropertiesOperationCompleted = "GetConfiguredPropertiesOperationCompleted";
        private const string FieldGetPropertyConstraintsOperationCompleted = "GetPropertyConstraintsOperationCompleted";
        private const string FielduseDefaultCredentialsSetExplicitly = "useDefaultCredentialsSetExplicitly";

        #endregion

        #endregion

        #region General Initializer : Class (OEASWebService) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OEASWebService" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OEASWebService_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEASWebService) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OEASWebService" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OEASWebService_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEASWebService) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OEASWebService" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OEASWebService_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OEASWebService)

        #region General Initializer : Class (OEASWebService) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OEASWebService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodOnExecuteOperationCompleted, 0)]
        [TestCase(MethodClearSessionItems, 0)]
        [TestCase(MethodOnClearSessionItemsOperationCompleted, 0)]
        [TestCase(MethodEndSession, 0)]
        [TestCase(MethodOnEndSessionOperationCompleted, 0)]
        [TestCase(MethodGetContextXML, 0)]
        [TestCase(MethodOnGetContextXMLOperationCompleted, 0)]
        [TestCase(MethodGetSessionItem, 0)]
        [TestCase(MethodOnGetSessionItemOperationCompleted, 0)]
        [TestCase(MethodGetSessionItems, 0)]
        [TestCase(MethodOnGetSessionItemsOperationCompleted, 0)]
        [TestCase(MethodHasPermission, 0)]
        [TestCase(MethodOnHasPermissionOperationCompleted, 0)]
        [TestCase(MethodHasPermissions, 0)]
        [TestCase(MethodOnHasPermissionsOperationCompleted, 0)]
        [TestCase(MethodRemoveSessionItem, 0)]
        [TestCase(MethodOnRemoveSessionItemOperationCompleted, 0)]
        [TestCase(MethodSetSessionItem, 0)]
        [TestCase(MethodOnSetSessionItemOperationCompleted, 0)]
        [TestCase(MethodRetrieveNatLangString, 0)]
        [TestCase(MethodOnRetrieveNatLangStringOperationCompleted, 0)]
        [TestCase(MethodRetrieveNatLangStringList, 0)]
        [TestCase(MethodOnRetrieveNatLangStringListOperationCompleted, 0)]
        [TestCase(MethodGetObjectInstance, 0)]
        [TestCase(MethodOnGetObjectInstanceOperationCompleted, 0)]
        [TestCase(MethodGetObjectDefinition, 0)]
        [TestCase(MethodOnGetObjectDefinitionOperationCompleted, 0)]
        [TestCase(MethodGetObjectList, 0)]
        [TestCase(MethodOnGetObjectListOperationCompleted, 0)]
        [TestCase(MethodGetConfiguredProperties, 0)]
        [TestCase(MethodOnGetConfiguredPropertiesOperationCompleted, 0)]
        [TestCase(MethodGetPropertyConstraints, 0)]
        [TestCase(MethodOnGetPropertyConstraintsOperationCompleted, 0)]
        [TestCase(MethodIsLocalFileSystemWebService, 0)]
        public void AUT_OEASWebService_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OEASWebService) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASWebService" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyUrl)]
        [TestCase(PropertyUseDefaultCredentials)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_OEASWebService_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OEASWebService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASWebService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldExecuteOperationCompleted)]
        [TestCase(FieldClearSessionItemsOperationCompleted)]
        [TestCase(FieldEndSessionOperationCompleted)]
        [TestCase(FieldGetContextXMLOperationCompleted)]
        [TestCase(FieldGetSessionItemOperationCompleted)]
        [TestCase(FieldGetSessionItemsOperationCompleted)]
        [TestCase(FieldHasPermissionOperationCompleted)]
        [TestCase(FieldHasPermissionsOperationCompleted)]
        [TestCase(FieldRemoveSessionItemOperationCompleted)]
        [TestCase(FieldSetSessionItemOperationCompleted)]
        [TestCase(FieldRetrieveNatLangStringOperationCompleted)]
        [TestCase(FieldRetrieveNatLangStringListOperationCompleted)]
        [TestCase(FieldGetObjectInstanceOperationCompleted)]
        [TestCase(FieldGetObjectDefinitionOperationCompleted)]
        [TestCase(FieldGetObjectListOperationCompleted)]
        [TestCase(FieldGetConfiguredPropertiesOperationCompleted)]
        [TestCase(FieldGetPropertyConstraintsOperationCompleted)]
        [TestCase(FielduseDefaultCredentialsSetExplicitly)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_OEASWebService_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OEASWebService) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OEASWebService" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OEASWebService_Is_Instance_Present_Test()
        {
            // Assert
            _oEASWebServiceInstanceType.ShouldNotBeNull();
            _oEASWebServiceInstance.ShouldNotBeNull();
            _oEASWebServiceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OEASWebService) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OEASWebService" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OEASWebService_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oEASWebServiceInstance.ShouldBeAssignableTo<OEASWebService>();
            _oEASWebServiceInstanceFixture.ShouldBeAssignableTo<OEASWebService>();
            CurrentInstance.ShouldBeAssignableTo<OEASWebService>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OEASWebService) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_OEASWebService_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OEASWebService instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OEASWebService) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyUrl)]
        [TestCase(PropertyUseDefaultCredentials)]
        public void AUT_OEASWebService_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OEASWebService) => Property (Url) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OEASWebService_Public_Class_Url_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUrl);
            var propertyInfo = this.GetPropertyInfo(PropertyUrl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OEASWebService) => Property (UseDefaultCredentials) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OEASWebService_Public_Class_UseDefaultCredentials_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUseDefaultCredentials);
            var propertyInfo = this.GetPropertyInfo(PropertyUseDefaultCredentials);

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

        #region Method Call : (Execute) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_Execute_Method_Call_Internally(Type[] types)
        {
            var methodExecuteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_Execute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var LogicalMethodName = this.CreateType<string>();
            var SessionID = this.CreateType<string>();
            var ParamXML = this.CreateType<string>();
            var CustomDataXML = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.Execute(ApplicationName, LogicalObjectName, LogicalMethodName, SessionID, ParamXML, CustomDataXML);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_Execute_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var LogicalMethodName = this.CreateType<string>();
            var SessionID = this.CreateType<string>();
            var ParamXML = this.CreateType<string>();
            var CustomDataXML = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.Execute(ApplicationName, LogicalObjectName, LogicalMethodName, SessionID, ParamXML, CustomDataXML);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_Execute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var LogicalMethodName = this.CreateType<string>();
            var SessionID = this.CreateType<string>();
            var ParamXML = this.CreateType<string>();
            var CustomDataXML = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { ApplicationName, LogicalObjectName, LogicalMethodName, SessionID, ParamXML, CustomDataXML };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfExecute);
            var result2 = this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_Execute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var LogicalMethodName = this.CreateType<string>();
            var SessionID = this.CreateType<string>();
            var ParamXML = this.CreateType<string>();
            var CustomDataXML = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { ApplicationName, LogicalObjectName, LogicalMethodName, SessionID, ParamXML, CustomDataXML };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (Execute) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_Execute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnExecuteOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnExecuteOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnExecuteOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnExecuteOperationCompleted, methodOnExecuteOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnExecuteOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnExecuteOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnExecuteOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnExecuteOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnExecuteOperationCompleted, methodOnExecuteOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnExecuteOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnExecuteOperationCompleted.ShouldNotBeNull();
            parametersOfOnExecuteOperationCompleted.Length.ShouldBe(1);
            methodOnExecuteOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnExecuteOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnExecuteOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnExecuteOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnExecuteOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnExecuteOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnExecuteOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnExecuteOperationCompleted, parametersOfOnExecuteOperationCompleted, methodOnExecuteOperationCompletedParametersTypes);

            // Assert
            parametersOfOnExecuteOperationCompleted.ShouldNotBeNull();
            parametersOfOnExecuteOperationCompleted.Length.ShouldBe(1);
            methodOnExecuteOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnExecuteOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnExecuteOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnExecuteOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnExecuteOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnExecuteOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnExecuteOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnExecuteOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteOperationCompleted);
            var methodOnExecuteOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnExecuteOperationCompleted, methodOnExecuteOperationCompletedParametersTypes);

            // Assert
            methodOnExecuteOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnExecuteOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnExecuteOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnExecuteOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_ClearSessionItems_Method_Call_Internally(Type[] types)
        {
            var methodClearSessionItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearSessionItems, methodClearSessionItemsParametersTypes);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_ClearSessionItems_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.ClearSessionItems(SessionID, ApplicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_ClearSessionItems_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var methodClearSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfClearSessionItems = { SessionID, ApplicationName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearSessionItems, methodClearSessionItemsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfClearSessionItems);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearSessionItems.ShouldNotBeNull();
            parametersOfClearSessionItems.Length.ShouldBe(2);
            methodClearSessionItemsParametersTypes.Length.ShouldBe(2);
            methodClearSessionItemsParametersTypes.Length.ShouldBe(parametersOfClearSessionItems.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_ClearSessionItems_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var methodClearSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfClearSessionItems = { SessionID, ApplicationName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearSessionItems, parametersOfClearSessionItems, methodClearSessionItemsParametersTypes);

            // Assert
            parametersOfClearSessionItems.ShouldNotBeNull();
            parametersOfClearSessionItems.Length.ShouldBe(2);
            methodClearSessionItemsParametersTypes.Length.ShouldBe(2);
            methodClearSessionItemsParametersTypes.Length.ShouldBe(parametersOfClearSessionItems.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_ClearSessionItems_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var currentMethodInfo = this.GetMethodInfo(MethodClearSessionItems, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_ClearSessionItems_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var methodClearSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearSessionItems, methodClearSessionItemsParametersTypes);

            // Assert
            methodClearSessionItemsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearSessionItems) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_ClearSessionItems_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearSessionItems);
            var currentMethodInfo = this.GetMethodInfo(MethodClearSessionItems, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnClearSessionItemsOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnClearSessionItemsOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnClearSessionItemsOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnClearSessionItemsOperationCompleted, methodOnClearSessionItemsOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnClearSessionItemsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnClearSessionItemsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnClearSessionItemsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnClearSessionItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnClearSessionItemsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnClearSessionItemsOperationCompleted, methodOnClearSessionItemsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnClearSessionItemsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnClearSessionItemsOperationCompleted.ShouldNotBeNull();
            parametersOfOnClearSessionItemsOperationCompleted.Length.ShouldBe(1);
            methodOnClearSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnClearSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnClearSessionItemsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnClearSessionItemsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnClearSessionItemsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnClearSessionItemsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnClearSessionItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnClearSessionItemsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnClearSessionItemsOperationCompleted, parametersOfOnClearSessionItemsOperationCompleted, methodOnClearSessionItemsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnClearSessionItemsOperationCompleted.ShouldNotBeNull();
            parametersOfOnClearSessionItemsOperationCompleted.Length.ShouldBe(1);
            methodOnClearSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnClearSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnClearSessionItemsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnClearSessionItemsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnClearSessionItemsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnClearSessionItemsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnClearSessionItemsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnClearSessionItemsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnClearSessionItemsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnClearSessionItemsOperationCompleted);
            var methodOnClearSessionItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnClearSessionItemsOperationCompleted, methodOnClearSessionItemsOperationCompletedParametersTypes);

            // Assert
            methodOnClearSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnClearSessionItemsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnClearSessionItemsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnClearSessionItemsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnClearSessionItemsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_EndSession_Method_Call_Internally(Type[] types)
        {
            var methodEndSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEndSession, methodEndSessionParametersTypes);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_EndSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.EndSession(SessionID, ApplicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_EndSession_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var methodEndSessionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEndSession = { SessionID, ApplicationName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEndSession, methodEndSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfEndSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEndSession.ShouldNotBeNull();
            parametersOfEndSession.Length.ShouldBe(2);
            methodEndSessionParametersTypes.Length.ShouldBe(2);
            methodEndSessionParametersTypes.Length.ShouldBe(parametersOfEndSession.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_EndSession_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var methodEndSessionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEndSession = { SessionID, ApplicationName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEndSession, parametersOfEndSession, methodEndSessionParametersTypes);

            // Assert
            parametersOfEndSession.ShouldNotBeNull();
            parametersOfEndSession.Length.ShouldBe(2);
            methodEndSessionParametersTypes.Length.ShouldBe(2);
            methodEndSessionParametersTypes.Length.ShouldBe(parametersOfEndSession.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_EndSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var currentMethodInfo = this.GetMethodInfo(MethodEndSession, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_EndSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var methodEndSessionParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEndSession, methodEndSessionParametersTypes);

            // Assert
            methodEndSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EndSession) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_EndSession_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEndSession);
            var currentMethodInfo = this.GetMethodInfo(MethodEndSession, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnEndSessionOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnEndSessionOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnEndSessionOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnEndSessionOperationCompleted, methodOnEndSessionOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnEndSessionOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnEndSessionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEndSessionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnEndSessionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnEndSessionOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnEndSessionOperationCompleted, methodOnEndSessionOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnEndSessionOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnEndSessionOperationCompleted.ShouldNotBeNull();
            parametersOfOnEndSessionOperationCompleted.Length.ShouldBe(1);
            methodOnEndSessionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnEndSessionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnEndSessionOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnEndSessionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnEndSessionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEndSessionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnEndSessionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnEndSessionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnEndSessionOperationCompleted, parametersOfOnEndSessionOperationCompleted, methodOnEndSessionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnEndSessionOperationCompleted.ShouldNotBeNull();
            parametersOfOnEndSessionOperationCompleted.Length.ShouldBe(1);
            methodOnEndSessionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnEndSessionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnEndSessionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnEndSessionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnEndSessionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEndSessionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnEndSessionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnEndSessionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnEndSessionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEndSessionOperationCompleted);
            var methodOnEndSessionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnEndSessionOperationCompleted, methodOnEndSessionOperationCompletedParametersTypes);

            // Assert
            methodOnEndSessionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnEndSessionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnEndSessionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEndSessionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnEndSessionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_GetContextXML_Method_Call_Internally(Type[] types)
        {
            var methodGetContextXMLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextXML, methodGetContextXMLParametersTypes);
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetContextXML_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXML);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.GetContextXML(SessionID, ApplicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetContextXML_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXML);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.GetContextXML(SessionID, ApplicationName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetContextXML_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXML);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var methodGetContextXMLParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetContextXML = { SessionID, ApplicationName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXML, methodGetContextXMLParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfGetContextXML);
            var result2 = this.GetResultOfMethod<string>(MethodGetContextXML, parametersOfGetContextXML, methodGetContextXMLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContextXML.ShouldNotBeNull();
            parametersOfGetContextXML.Length.ShouldBe(2);
            methodGetContextXMLParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetContextXML_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXML);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var methodGetContextXMLParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetContextXML = { SessionID, ApplicationName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContextXML, parametersOfGetContextXML, methodGetContextXMLParametersTypes);

            // Assert
            parametersOfGetContextXML.ShouldNotBeNull();
            parametersOfGetContextXML.Length.ShouldBe(2);
            methodGetContextXMLParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetContextXML_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXML);
            var methodGetContextXMLParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContextXML, methodGetContextXMLParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContextXMLParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetContextXML_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXML);
            var methodGetContextXMLParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContextXML, methodGetContextXMLParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContextXMLParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetContextXML_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXML);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXML, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextXML) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetContextXML_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextXML);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextXML, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetContextXMLOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnGetContextXMLOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnGetContextXMLOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGetContextXMLOperationCompleted, methodOnGetContextXMLOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGetContextXMLOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetContextXMLOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetContextXMLOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetContextXMLOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetContextXMLOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetContextXMLOperationCompleted, methodOnGetContextXMLOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnGetContextXMLOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetContextXMLOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetContextXMLOperationCompleted.Length.ShouldBe(1);
            methodOnGetContextXMLOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetContextXMLOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetContextXMLOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetContextXMLOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetContextXMLOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetContextXMLOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetContextXMLOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetContextXMLOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetContextXMLOperationCompleted, parametersOfOnGetContextXMLOperationCompleted, methodOnGetContextXMLOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetContextXMLOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetContextXMLOperationCompleted.Length.ShouldBe(1);
            methodOnGetContextXMLOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetContextXMLOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetContextXMLOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetContextXMLOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetContextXMLOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetContextXMLOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetContextXMLOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetContextXMLOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetContextXMLOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetContextXMLOperationCompleted);
            var methodOnGetContextXMLOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetContextXMLOperationCompleted, methodOnGetContextXMLOperationCompletedParametersTypes);

            // Assert
            methodOnGetContextXMLOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetContextXMLOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetContextXMLOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetContextXMLOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetContextXMLOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_GetSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodGetSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.GetSessionItem(SessionID, ApplicationName, Key);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItem_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.GetSessionItem(SessionID, ApplicationName, Key);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItem_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetSessionItem = { SessionID, ApplicationName, Key };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, methodGetSessionItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfGetSessionItem);
            var result2 = this.GetResultOfMethod<string>(MethodGetSessionItem, parametersOfGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSessionItem.ShouldNotBeNull();
            parametersOfGetSessionItem.Length.ShouldBe(3);
            methodGetSessionItemParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItem_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetSessionItem = { SessionID, ApplicationName, Key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSessionItem, parametersOfGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            parametersOfGetSessionItem.ShouldNotBeNull();
            parametersOfGetSessionItem.Length.ShouldBe(3);
            methodGetSessionItemParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItem_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSessionItemParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSessionItemParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItem_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSessionItemOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnGetSessionItemOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnGetSessionItemOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGetSessionItemOperationCompleted, methodOnGetSessionItemOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGetSessionItemOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSessionItemOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSessionItemOperationCompleted, methodOnGetSessionItemOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnGetSessionItemOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetSessionItemOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSessionItemOperationCompleted.Length.ShouldBe(1);
            methodOnGetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSessionItemOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSessionItemOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSessionItemOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetSessionItemOperationCompleted, parametersOfOnGetSessionItemOperationCompleted, methodOnGetSessionItemOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetSessionItemOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSessionItemOperationCompleted.Length.ShouldBe(1);
            methodOnGetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSessionItemOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSessionItemOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSessionItemOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSessionItemOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemOperationCompleted);
            var methodOnGetSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetSessionItemOperationCompleted, methodOnGetSessionItemOperationCompletedParametersTypes);

            // Assert
            methodOnGetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSessionItemOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSessionItemOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_GetSessionItems_Method_Call_Internally(Type[] types)
        {
            var methodGetSessionItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSessionItems, methodGetSessionItemsParametersTypes);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItems_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.GetSessionItems(SessionID, ApplicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItems_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.GetSessionItems(SessionID, ApplicationName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItems_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var methodGetSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSessionItems = { SessionID, ApplicationName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItems, methodGetSessionItemsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfGetSessionItems);
            var result2 = this.GetResultOfMethod<string>(MethodGetSessionItems, parametersOfGetSessionItems, methodGetSessionItemsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSessionItems.ShouldNotBeNull();
            parametersOfGetSessionItems.Length.ShouldBe(2);
            methodGetSessionItemsParametersTypes.Length.ShouldBe(2);
        }

        #endregion
        
        #region Method Call : (GetSessionItems) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItems_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var methodGetSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSessionItems, methodGetSessionItemsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSessionItemsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSessionItems) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItems_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var methodGetSessionItemsParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSessionItems, methodGetSessionItemsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSessionItemsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (GetSessionItems) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetSessionItems_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItems, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSessionItemsOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnGetSessionItemsOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnGetSessionItemsOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGetSessionItemsOperationCompleted, methodOnGetSessionItemsOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGetSessionItemsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSessionItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSessionItemsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSessionItemsOperationCompleted, methodOnGetSessionItemsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnGetSessionItemsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetSessionItemsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSessionItemsOperationCompleted.Length.ShouldBe(1);
            methodOnGetSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSessionItemsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSessionItemsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSessionItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSessionItemsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetSessionItemsOperationCompleted, parametersOfOnGetSessionItemsOperationCompleted, methodOnGetSessionItemsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetSessionItemsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSessionItemsOperationCompleted.Length.ShouldBe(1);
            methodOnGetSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSessionItemsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSessionItemsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSessionItemsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSessionItemsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemsOperationCompleted);
            var methodOnGetSessionItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetSessionItemsOperationCompleted, methodOnGetSessionItemsOperationCompletedParametersTypes);

            // Assert
            methodOnGetSessionItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSessionItemsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetSessionItemsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSessionItemsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSessionItemsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_HasPermission_Method_Call_Internally(Type[] types)
        {
            var methodHasPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodHasPermission, methodHasPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermission_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Resource = this.CreateType<string>();
            var SecurityMask = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.HasPermission(SessionID, ApplicationName, Resource, SecurityMask);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Resource = this.CreateType<string>();
            var SecurityMask = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfHasPermission = { SessionID, ApplicationName, Resource, SecurityMask };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASWebServiceInstanceFixture, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(4);
            methodHasPermissionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermission_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Resource = this.CreateType<string>();
            var SecurityMask = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfHasPermission = { SessionID, ApplicationName, Resource, SecurityMask };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASWebServiceInstanceFixture, out exception1, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(4);
            methodHasPermissionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Resource = this.CreateType<string>();
            var SecurityMask = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfHasPermission = { SessionID, ApplicationName, Resource, SecurityMask };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(4);
            methodHasPermissionParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var methodHasPermissionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHasPermission, methodHasPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodHasPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnHasPermissionOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnHasPermissionOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnHasPermissionOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnHasPermissionOperationCompleted, methodOnHasPermissionOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnHasPermissionOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnHasPermissionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnHasPermissionOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnHasPermissionOperationCompleted, methodOnHasPermissionOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnHasPermissionOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnHasPermissionOperationCompleted.ShouldNotBeNull();
            parametersOfOnHasPermissionOperationCompleted.Length.ShouldBe(1);
            methodOnHasPermissionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnHasPermissionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnHasPermissionOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnHasPermissionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnHasPermissionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnHasPermissionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnHasPermissionOperationCompleted, parametersOfOnHasPermissionOperationCompleted, methodOnHasPermissionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnHasPermissionOperationCompleted.ShouldNotBeNull();
            parametersOfOnHasPermissionOperationCompleted.Length.ShouldBe(1);
            methodOnHasPermissionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnHasPermissionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnHasPermissionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnHasPermissionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnHasPermissionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnHasPermissionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionOperationCompleted);
            var methodOnHasPermissionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnHasPermissionOperationCompleted, methodOnHasPermissionOperationCompletedParametersTypes);

            // Assert
            methodOnHasPermissionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnHasPermissionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnHasPermissionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_HasPermissions_Method_Call_Internally(Type[] types)
        {
            var methodHasPermissionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodHasPermissions, methodHasPermissionsParametersTypes);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermissions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Resources = this.CreateType<string[]>();
            var SecurityMask = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.HasPermissions(SessionID, ApplicationName, Resources, SecurityMask);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermissions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Resources = this.CreateType<string[]>();
            var SecurityMask = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.HasPermissions(SessionID, ApplicationName, Resources, SecurityMask);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermissions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Resources = this.CreateType<string[]>();
            var SecurityMask = this.CreateType<string>();
            var methodHasPermissionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string[]), typeof(string) };
            object[] parametersOfHasPermissions = { SessionID, ApplicationName, Resources, SecurityMask };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermissions, methodHasPermissionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfHasPermissions);
            var result2 = this.GetResultOfMethod<string>(MethodHasPermissions, parametersOfHasPermissions, methodHasPermissionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfHasPermissions.ShouldNotBeNull();
            parametersOfHasPermissions.Length.ShouldBe(4);
            methodHasPermissionsParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermissions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Resources = this.CreateType<string[]>();
            var SecurityMask = this.CreateType<string>();
            var methodHasPermissionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string[]), typeof(string) };
            object[] parametersOfHasPermissions = { SessionID, ApplicationName, Resources, SecurityMask };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodHasPermissions, parametersOfHasPermissions, methodHasPermissionsParametersTypes);

            // Assert
            parametersOfHasPermissions.ShouldNotBeNull();
            parametersOfHasPermissions.Length.ShouldBe(4);
            methodHasPermissionsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermissions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var methodHasPermissionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string[]), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodHasPermissions, methodHasPermissionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodHasPermissionsParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermissions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var methodHasPermissionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string[]), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHasPermissions, methodHasPermissionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodHasPermissionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermissions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermissions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermissions) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_HasPermissions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermissions, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnHasPermissionsOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnHasPermissionsOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnHasPermissionsOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnHasPermissionsOperationCompleted, methodOnHasPermissionsOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnHasPermissionsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnHasPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnHasPermissionsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnHasPermissionsOperationCompleted, methodOnHasPermissionsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnHasPermissionsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnHasPermissionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnHasPermissionsOperationCompleted.Length.ShouldBe(1);
            methodOnHasPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnHasPermissionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnHasPermissionsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnHasPermissionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnHasPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnHasPermissionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnHasPermissionsOperationCompleted, parametersOfOnHasPermissionsOperationCompleted, methodOnHasPermissionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnHasPermissionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnHasPermissionsOperationCompleted.Length.ShouldBe(1);
            methodOnHasPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnHasPermissionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnHasPermissionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnHasPermissionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnHasPermissionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnHasPermissionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionsOperationCompleted);
            var methodOnHasPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnHasPermissionsOperationCompleted, methodOnHasPermissionsOperationCompletedParametersTypes);

            // Assert
            methodOnHasPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnHasPermissionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnHasPermissionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnHasPermissionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnHasPermissionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_RemoveSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodRemoveSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RemoveSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.RemoveSessionItem(SessionID, ApplicationName, Key);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RemoveSessionItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfRemoveSessionItem = { SessionID, ApplicationName, Key };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfRemoveSessionItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveSessionItem.ShouldNotBeNull();
            parametersOfRemoveSessionItem.Length.ShouldBe(3);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(3);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(parametersOfRemoveSessionItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RemoveSessionItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfRemoveSessionItem = { SessionID, ApplicationName, Key };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveSessionItem, parametersOfRemoveSessionItem, methodRemoveSessionItemParametersTypes);

            // Assert
            parametersOfRemoveSessionItem.ShouldNotBeNull();
            parametersOfRemoveSessionItem.Length.ShouldBe(3);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(3);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(parametersOfRemoveSessionItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RemoveSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RemoveSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes);

            // Assert
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RemoveSessionItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRemoveSessionItemOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnRemoveSessionItemOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnRemoveSessionItemOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnRemoveSessionItemOperationCompleted, methodOnRemoveSessionItemOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnRemoveSessionItemOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRemoveSessionItemOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveSessionItemOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRemoveSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRemoveSessionItemOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnRemoveSessionItemOperationCompleted, methodOnRemoveSessionItemOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnRemoveSessionItemOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnRemoveSessionItemOperationCompleted.ShouldNotBeNull();
            parametersOfOnRemoveSessionItemOperationCompleted.Length.ShouldBe(1);
            methodOnRemoveSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRemoveSessionItemOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRemoveSessionItemOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnRemoveSessionItemOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRemoveSessionItemOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveSessionItemOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRemoveSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRemoveSessionItemOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnRemoveSessionItemOperationCompleted, parametersOfOnRemoveSessionItemOperationCompleted, methodOnRemoveSessionItemOperationCompletedParametersTypes);

            // Assert
            parametersOfOnRemoveSessionItemOperationCompleted.ShouldNotBeNull();
            parametersOfOnRemoveSessionItemOperationCompleted.Length.ShouldBe(1);
            methodOnRemoveSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRemoveSessionItemOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRemoveSessionItemOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRemoveSessionItemOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRemoveSessionItemOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveSessionItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRemoveSessionItemOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnRemoveSessionItemOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRemoveSessionItemOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveSessionItemOperationCompleted);
            var methodOnRemoveSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnRemoveSessionItemOperationCompleted, methodOnRemoveSessionItemOperationCompletedParametersTypes);

            // Assert
            methodOnRemoveSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRemoveSessionItemOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRemoveSessionItemOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRemoveSessionItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRemoveSessionItemOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_SetSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodSetSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSessionItem, methodSetSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_SetSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var Value = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.SetSessionItem(SessionID, ApplicationName, Key, Value);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_SetSessionItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var Value = this.CreateType<string>();
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSetSessionItem = { SessionID, ApplicationName, Key, Value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSessionItem, methodSetSessionItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfSetSessionItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSessionItem.ShouldNotBeNull();
            parametersOfSetSessionItem.Length.ShouldBe(4);
            methodSetSessionItemParametersTypes.Length.ShouldBe(4);
            methodSetSessionItemParametersTypes.Length.ShouldBe(parametersOfSetSessionItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_SetSessionItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var SessionID = this.CreateType<string>();
            var ApplicationName = this.CreateType<string>();
            var Key = this.CreateType<string>();
            var Value = this.CreateType<string>();
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfSetSessionItem = { SessionID, ApplicationName, Key, Value };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSessionItem, parametersOfSetSessionItem, methodSetSessionItemParametersTypes);

            // Assert
            parametersOfSetSessionItem.ShouldNotBeNull();
            parametersOfSetSessionItem.Length.ShouldBe(4);
            methodSetSessionItemParametersTypes.Length.ShouldBe(4);
            methodSetSessionItemParametersTypes.Length.ShouldBe(parametersOfSetSessionItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_SetSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSessionItem, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_SetSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSessionItem, methodSetSessionItemParametersTypes);

            // Assert
            methodSetSessionItemParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetSessionItemOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnSetSessionItemOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnSetSessionItemOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnSetSessionItemOperationCompleted, methodOnSetSessionItemOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnSetSessionItemOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnSetSessionItemOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSessionItemOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetSessionItemOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSessionItemOperationCompleted, methodOnSetSessionItemOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnSetSessionItemOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnSetSessionItemOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetSessionItemOperationCompleted.Length.ShouldBe(1);
            methodOnSetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetSessionItemOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSessionItemOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnSetSessionItemOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSessionItemOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetSessionItemOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetSessionItemOperationCompleted, parametersOfOnSetSessionItemOperationCompleted, methodOnSetSessionItemOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetSessionItemOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetSessionItemOperationCompleted.Length.ShouldBe(1);
            methodOnSetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetSessionItemOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSessionItemOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnSetSessionItemOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSessionItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSessionItemOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetSessionItemOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnSetSessionItemOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSessionItemOperationCompleted);
            var methodOnSetSessionItemOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetSessionItemOperationCompleted, methodOnSetSessionItemOperationCompletedParametersTypes);

            // Assert
            methodOnSetSessionItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSessionItemOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnSetSessionItemOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSessionItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSessionItemOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveNatLangString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_RetrieveNatLangString_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveNatLangStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveNatLangString, methodRetrieveNatLangStringParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveNatLangString) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangString_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangString);
            var ApplicationName = this.CreateType<string>();
            var SiteID = this.CreateType<int>();
            var LanguageCode = this.CreateType<string>();
            var NatLangID = this.CreateType<int>();
            var Arguments = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.RetrieveNatLangString(ApplicationName, SiteID, LanguageCode, NatLangID, Arguments);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveNatLangString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangString);
            var ApplicationName = this.CreateType<string>();
            var SiteID = this.CreateType<int>();
            var LanguageCode = this.CreateType<string>();
            var NatLangID = this.CreateType<int>();
            var Arguments = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.RetrieveNatLangString(ApplicationName, SiteID, LanguageCode, NatLangID, Arguments);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveNatLangString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangString);
            var ApplicationName = this.CreateType<string>();
            var SiteID = this.CreateType<int>();
            var LanguageCode = this.CreateType<string>();
            var NatLangID = this.CreateType<int>();
            var Arguments = this.CreateType<string>();
            var methodRetrieveNatLangStringParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string), typeof(int), typeof(string) };
            object[] parametersOfRetrieveNatLangString = { ApplicationName, SiteID, LanguageCode, NatLangID, Arguments };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveNatLangString, methodRetrieveNatLangStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfRetrieveNatLangString);
            var result2 = this.GetResultOfMethod<string>(MethodRetrieveNatLangString, parametersOfRetrieveNatLangString, methodRetrieveNatLangStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveNatLangString.ShouldNotBeNull();
            parametersOfRetrieveNatLangString.Length.ShouldBe(5);
            methodRetrieveNatLangStringParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (RetrieveNatLangString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangString);
            var ApplicationName = this.CreateType<string>();
            var SiteID = this.CreateType<int>();
            var LanguageCode = this.CreateType<string>();
            var NatLangID = this.CreateType<int>();
            var Arguments = this.CreateType<string>();
            var methodRetrieveNatLangStringParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string), typeof(int), typeof(string) };
            object[] parametersOfRetrieveNatLangString = { ApplicationName, SiteID, LanguageCode, NatLangID, Arguments };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRetrieveNatLangString, parametersOfRetrieveNatLangString, methodRetrieveNatLangStringParametersTypes);

            // Assert
            parametersOfRetrieveNatLangString.ShouldNotBeNull();
            parametersOfRetrieveNatLangString.Length.ShouldBe(5);
            methodRetrieveNatLangStringParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveNatLangString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangString);
            var methodRetrieveNatLangStringParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string), typeof(int), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveNatLangString, methodRetrieveNatLangStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveNatLangStringParametersTypes.Length.ShouldBe(5);
        }

        #endregion
        
        #region Method Call : (RetrieveNatLangString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangString);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveNatLangString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveNatLangString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangString_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangString);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveNatLangString, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnRetrieveNatLangStringOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnRetrieveNatLangStringOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnRetrieveNatLangStringOperationCompleted, methodOnRetrieveNatLangStringOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRetrieveNatLangStringOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRetrieveNatLangStringOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnRetrieveNatLangStringOperationCompleted, methodOnRetrieveNatLangStringOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnRetrieveNatLangStringOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnRetrieveNatLangStringOperationCompleted.ShouldNotBeNull();
            parametersOfOnRetrieveNatLangStringOperationCompleted.Length.ShouldBe(1);
            methodOnRetrieveNatLangStringOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRetrieveNatLangStringOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRetrieveNatLangStringOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRetrieveNatLangStringOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRetrieveNatLangStringOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnRetrieveNatLangStringOperationCompleted, parametersOfOnRetrieveNatLangStringOperationCompleted, methodOnRetrieveNatLangStringOperationCompletedParametersTypes);

            // Assert
            parametersOfOnRetrieveNatLangStringOperationCompleted.ShouldNotBeNull();
            parametersOfOnRetrieveNatLangStringOperationCompleted.Length.ShouldBe(1);
            methodOnRetrieveNatLangStringOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRetrieveNatLangStringOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRetrieveNatLangStringOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRetrieveNatLangStringOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringOperationCompleted);
            var methodOnRetrieveNatLangStringOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnRetrieveNatLangStringOperationCompleted, methodOnRetrieveNatLangStringOperationCompletedParametersTypes);

            // Assert
            methodOnRetrieveNatLangStringOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRetrieveNatLangStringOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveNatLangStringList) (Return Type : string[][]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_RetrieveNatLangStringList_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveNatLangStringListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveNatLangStringList, methodRetrieveNatLangStringListParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveNatLangStringList) (Return Type : string[][]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangStringList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangStringList);
            var ApplicationName = this.CreateType<string>();
            var SiteID = this.CreateType<int>();
            var LanguageCode = this.CreateType<string>();
            var StartIndex = this.CreateType<int>();
            var EndIndex = this.CreateType<int>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.RetrieveNatLangStringList(ApplicationName, SiteID, LanguageCode, StartIndex, EndIndex);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveNatLangStringList) (Return Type : string[][]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangStringList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangStringList);
            var ApplicationName = this.CreateType<string>();
            var SiteID = this.CreateType<int>();
            var LanguageCode = this.CreateType<string>();
            var StartIndex = this.CreateType<int>();
            var EndIndex = this.CreateType<int>();
            var returnedValue = default(string[][]);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.RetrieveNatLangStringList(ApplicationName, SiteID, LanguageCode, StartIndex, EndIndex);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveNatLangStringList) (Return Type : string[][]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangStringList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangStringList);
            var ApplicationName = this.CreateType<string>();
            var SiteID = this.CreateType<int>();
            var LanguageCode = this.CreateType<string>();
            var StartIndex = this.CreateType<int>();
            var EndIndex = this.CreateType<int>();
            var methodRetrieveNatLangStringListParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string), typeof(int), typeof(int) };
            object[] parametersOfRetrieveNatLangStringList = { ApplicationName, SiteID, LanguageCode, StartIndex, EndIndex };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveNatLangStringList, methodRetrieveNatLangStringListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[][]>(_oEASWebServiceInstanceFixture, parametersOfRetrieveNatLangStringList);
            var result2 = this.GetResultOfMethod<string[][]>(MethodRetrieveNatLangStringList, parametersOfRetrieveNatLangStringList, methodRetrieveNatLangStringListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveNatLangStringList.ShouldNotBeNull();
            parametersOfRetrieveNatLangStringList.Length.ShouldBe(5);
            methodRetrieveNatLangStringListParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (RetrieveNatLangStringList) (Return Type : string[][]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangStringList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangStringList);
            var ApplicationName = this.CreateType<string>();
            var SiteID = this.CreateType<int>();
            var LanguageCode = this.CreateType<string>();
            var StartIndex = this.CreateType<int>();
            var EndIndex = this.CreateType<int>();
            var methodRetrieveNatLangStringListParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string), typeof(int), typeof(int) };
            object[] parametersOfRetrieveNatLangStringList = { ApplicationName, SiteID, LanguageCode, StartIndex, EndIndex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[][]>(MethodRetrieveNatLangStringList, parametersOfRetrieveNatLangStringList, methodRetrieveNatLangStringListParametersTypes);

            // Assert
            parametersOfRetrieveNatLangStringList.ShouldNotBeNull();
            parametersOfRetrieveNatLangStringList.Length.ShouldBe(5);
            methodRetrieveNatLangStringListParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (RetrieveNatLangStringList) (Return Type : string[][]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangStringList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangStringList);
            var methodRetrieveNatLangStringListParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string), typeof(int), typeof(int) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveNatLangStringList, methodRetrieveNatLangStringListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveNatLangStringListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveNatLangStringList) (Return Type : string[][]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangStringList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangStringList);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveNatLangStringList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveNatLangStringList) (Return Type : string[][]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_RetrieveNatLangStringList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveNatLangStringList);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveNatLangStringList, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringListOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnRetrieveNatLangStringListOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnRetrieveNatLangStringListOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnRetrieveNatLangStringListOperationCompleted, methodOnRetrieveNatLangStringListOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringListOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringListOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringListOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRetrieveNatLangStringListOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRetrieveNatLangStringListOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnRetrieveNatLangStringListOperationCompleted, methodOnRetrieveNatLangStringListOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnRetrieveNatLangStringListOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnRetrieveNatLangStringListOperationCompleted.ShouldNotBeNull();
            parametersOfOnRetrieveNatLangStringListOperationCompleted.Length.ShouldBe(1);
            methodOnRetrieveNatLangStringListOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRetrieveNatLangStringListOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRetrieveNatLangStringListOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringListOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringListOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringListOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnRetrieveNatLangStringListOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnRetrieveNatLangStringListOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnRetrieveNatLangStringListOperationCompleted, parametersOfOnRetrieveNatLangStringListOperationCompleted, methodOnRetrieveNatLangStringListOperationCompletedParametersTypes);

            // Assert
            parametersOfOnRetrieveNatLangStringListOperationCompleted.ShouldNotBeNull();
            parametersOfOnRetrieveNatLangStringListOperationCompleted.Length.ShouldBe(1);
            methodOnRetrieveNatLangStringListOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnRetrieveNatLangStringListOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnRetrieveNatLangStringListOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringListOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringListOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringListOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRetrieveNatLangStringListOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringListOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringListOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringListOperationCompleted);
            var methodOnRetrieveNatLangStringListOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnRetrieveNatLangStringListOperationCompleted, methodOnRetrieveNatLangStringListOperationCompletedParametersTypes);

            // Assert
            methodOnRetrieveNatLangStringListOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnRetrieveNatLangStringListOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnRetrieveNatLangStringListOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnRetrieveNatLangStringListOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnRetrieveNatLangStringListOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_GetObjectInstance_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectInstanceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectInstance, methodGetObjectInstanceParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectInstance_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.GetObjectInstance(ApplicationName, LogicalObjectName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectInstance_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.GetObjectInstance(ApplicationName, LogicalObjectName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectInstance_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var methodGetObjectInstanceParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetObjectInstance = { ApplicationName, LogicalObjectName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstance, methodGetObjectInstanceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfGetObjectInstance);
            var result2 = this.GetResultOfMethod<string>(MethodGetObjectInstance, parametersOfGetObjectInstance, methodGetObjectInstanceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetObjectInstance.ShouldNotBeNull();
            parametersOfGetObjectInstance.Length.ShouldBe(2);
            methodGetObjectInstanceParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectInstance_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var methodGetObjectInstanceParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetObjectInstance = { ApplicationName, LogicalObjectName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetObjectInstance, parametersOfGetObjectInstance, methodGetObjectInstanceParametersTypes);

            // Assert
            parametersOfGetObjectInstance.ShouldNotBeNull();
            parametersOfGetObjectInstance.Length.ShouldBe(2);
            methodGetObjectInstanceParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectInstance_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var methodGetObjectInstanceParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectInstance, methodGetObjectInstanceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetObjectInstanceParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectInstance_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var methodGetObjectInstanceParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectInstance, methodGetObjectInstanceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectInstanceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectInstance_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstance, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectInstance_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstance, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetObjectInstanceOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnGetObjectInstanceOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnGetObjectInstanceOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGetObjectInstanceOperationCompleted, methodOnGetObjectInstanceOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGetObjectInstanceOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectInstanceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectInstanceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetObjectInstanceOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetObjectInstanceOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectInstanceOperationCompleted, methodOnGetObjectInstanceOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnGetObjectInstanceOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetObjectInstanceOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetObjectInstanceOperationCompleted.Length.ShouldBe(1);
            methodOnGetObjectInstanceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetObjectInstanceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetObjectInstanceOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectInstanceOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectInstanceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectInstanceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetObjectInstanceOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetObjectInstanceOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetObjectInstanceOperationCompleted, parametersOfOnGetObjectInstanceOperationCompleted, methodOnGetObjectInstanceOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetObjectInstanceOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetObjectInstanceOperationCompleted.Length.ShouldBe(1);
            methodOnGetObjectInstanceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetObjectInstanceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetObjectInstanceOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectInstanceOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectInstanceOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectInstanceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectInstanceOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetObjectInstanceOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectInstanceOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectInstanceOperationCompleted);
            var methodOnGetObjectInstanceOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetObjectInstanceOperationCompleted, methodOnGetObjectInstanceOperationCompletedParametersTypes);

            // Assert
            methodOnGetObjectInstanceOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectInstanceOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectInstanceOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectInstanceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectInstanceOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_GetObjectDefinition_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectDefinitionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectDefinition, methodGetObjectDefinitionParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectDefinition_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefinition);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.GetObjectDefinition(ApplicationName, LogicalObjectName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectDefinition_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefinition);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.GetObjectDefinition(ApplicationName, LogicalObjectName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectDefinition_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefinition);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var methodGetObjectDefinitionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetObjectDefinition = { ApplicationName, LogicalObjectName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectDefinition, methodGetObjectDefinitionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfGetObjectDefinition);
            var result2 = this.GetResultOfMethod<string>(MethodGetObjectDefinition, parametersOfGetObjectDefinition, methodGetObjectDefinitionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetObjectDefinition.ShouldNotBeNull();
            parametersOfGetObjectDefinition.Length.ShouldBe(2);
            methodGetObjectDefinitionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectDefinition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefinition);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var methodGetObjectDefinitionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetObjectDefinition = { ApplicationName, LogicalObjectName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetObjectDefinition, parametersOfGetObjectDefinition, methodGetObjectDefinitionParametersTypes);

            // Assert
            parametersOfGetObjectDefinition.ShouldNotBeNull();
            parametersOfGetObjectDefinition.Length.ShouldBe(2);
            methodGetObjectDefinitionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectDefinition_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefinition);
            var methodGetObjectDefinitionParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectDefinition, methodGetObjectDefinitionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetObjectDefinitionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectDefinition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefinition);
            var methodGetObjectDefinitionParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectDefinition, methodGetObjectDefinitionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectDefinitionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectDefinition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectDefinition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectDefinition) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectDefinition_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectDefinition, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetObjectDefinitionOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnGetObjectDefinitionOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnGetObjectDefinitionOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGetObjectDefinitionOperationCompleted, methodOnGetObjectDefinitionOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGetObjectDefinitionOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectDefinitionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectDefinitionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetObjectDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetObjectDefinitionOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectDefinitionOperationCompleted, methodOnGetObjectDefinitionOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnGetObjectDefinitionOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetObjectDefinitionOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetObjectDefinitionOperationCompleted.Length.ShouldBe(1);
            methodOnGetObjectDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetObjectDefinitionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetObjectDefinitionOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectDefinitionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectDefinitionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectDefinitionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetObjectDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetObjectDefinitionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetObjectDefinitionOperationCompleted, parametersOfOnGetObjectDefinitionOperationCompleted, methodOnGetObjectDefinitionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetObjectDefinitionOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetObjectDefinitionOperationCompleted.Length.ShouldBe(1);
            methodOnGetObjectDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetObjectDefinitionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetObjectDefinitionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectDefinitionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectDefinitionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectDefinitionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetObjectDefinitionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectDefinitionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectDefinitionOperationCompleted);
            var methodOnGetObjectDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetObjectDefinitionOperationCompleted, methodOnGetObjectDefinitionOperationCompletedParametersTypes);

            // Assert
            methodOnGetObjectDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectDefinitionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectDefinitionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectDefinitionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_GetObjectList_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectList, methodGetObjectListParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var ApplicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.GetObjectList(ApplicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var ApplicationName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.GetObjectList(ApplicationName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var ApplicationName = this.CreateType<string>();
            var methodGetObjectListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetObjectList = { ApplicationName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectList, methodGetObjectListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_oEASWebServiceInstanceFixture, parametersOfGetObjectList);
            var result2 = this.GetResultOfMethod<string>(MethodGetObjectList, parametersOfGetObjectList, methodGetObjectListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetObjectList.ShouldNotBeNull();
            parametersOfGetObjectList.Length.ShouldBe(1);
            methodGetObjectListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var ApplicationName = this.CreateType<string>();
            var methodGetObjectListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetObjectList = { ApplicationName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetObjectList, parametersOfGetObjectList, methodGetObjectListParametersTypes);

            // Assert
            parametersOfGetObjectList.ShouldNotBeNull();
            parametersOfGetObjectList.Length.ShouldBe(1);
            methodGetObjectListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var methodGetObjectListParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectList, methodGetObjectListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetObjectListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var methodGetObjectListParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectList, methodGetObjectListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetObjectList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectList, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetObjectListOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnGetObjectListOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnGetObjectListOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGetObjectListOperationCompleted, methodOnGetObjectListOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGetObjectListOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectListOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectListOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetObjectListOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetObjectListOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectListOperationCompleted, methodOnGetObjectListOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnGetObjectListOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetObjectListOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetObjectListOperationCompleted.Length.ShouldBe(1);
            methodOnGetObjectListOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetObjectListOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetObjectListOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectListOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectListOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectListOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetObjectListOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetObjectListOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetObjectListOperationCompleted, parametersOfOnGetObjectListOperationCompleted, methodOnGetObjectListOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetObjectListOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetObjectListOperationCompleted.Length.ShouldBe(1);
            methodOnGetObjectListOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetObjectListOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetObjectListOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectListOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectListOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectListOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectListOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetObjectListOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectListOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectListOperationCompleted);
            var methodOnGetObjectListOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetObjectListOperationCompleted, methodOnGetObjectListOperationCompletedParametersTypes);

            // Assert
            methodOnGetObjectListOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetObjectListOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetObjectListOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetObjectListOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetObjectListOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_GetConfiguredProperties_Method_Call_Internally(Type[] types)
        {
            var methodGetConfiguredPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetConfiguredProperties, methodGetConfiguredPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetConfiguredProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguredProperties);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.GetConfiguredProperties(ApplicationName, LogicalObjectName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetConfiguredProperties_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguredProperties);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var returnedValue = default(string[][]);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.GetConfiguredProperties(ApplicationName, LogicalObjectName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetConfiguredProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguredProperties);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var methodGetConfiguredPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetConfiguredProperties = { ApplicationName, LogicalObjectName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguredProperties, methodGetConfiguredPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[][]>(_oEASWebServiceInstanceFixture, parametersOfGetConfiguredProperties);
            var result2 = this.GetResultOfMethod<string[][]>(MethodGetConfiguredProperties, parametersOfGetConfiguredProperties, methodGetConfiguredPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetConfiguredProperties.ShouldNotBeNull();
            parametersOfGetConfiguredProperties.Length.ShouldBe(2);
            methodGetConfiguredPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetConfiguredProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguredProperties);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var methodGetConfiguredPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetConfiguredProperties = { ApplicationName, LogicalObjectName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[][]>(MethodGetConfiguredProperties, parametersOfGetConfiguredProperties, methodGetConfiguredPropertiesParametersTypes);

            // Assert
            parametersOfGetConfiguredProperties.ShouldNotBeNull();
            parametersOfGetConfiguredProperties.Length.ShouldBe(2);
            methodGetConfiguredPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetConfiguredProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguredProperties);
            var methodGetConfiguredPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetConfiguredProperties, methodGetConfiguredPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetConfiguredPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetConfiguredProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguredProperties);
            var methodGetConfiguredPropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetConfiguredProperties, methodGetConfiguredPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetConfiguredPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetConfiguredProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguredProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguredProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfiguredProperties) (Return Type : string[][]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetConfiguredProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfiguredProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfiguredProperties, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetConfiguredPropertiesOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnGetConfiguredPropertiesOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnGetConfiguredPropertiesOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGetConfiguredPropertiesOperationCompleted, methodOnGetConfiguredPropertiesOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGetConfiguredPropertiesOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetConfiguredPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetConfiguredPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetConfiguredPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetConfiguredPropertiesOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetConfiguredPropertiesOperationCompleted, methodOnGetConfiguredPropertiesOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnGetConfiguredPropertiesOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetConfiguredPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetConfiguredPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetConfiguredPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetConfiguredPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetConfiguredPropertiesOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetConfiguredPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetConfiguredPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetConfiguredPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetConfiguredPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetConfiguredPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetConfiguredPropertiesOperationCompleted, parametersOfOnGetConfiguredPropertiesOperationCompleted, methodOnGetConfiguredPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetConfiguredPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetConfiguredPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetConfiguredPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetConfiguredPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetConfiguredPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetConfiguredPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetConfiguredPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetConfiguredPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetConfiguredPropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetConfiguredPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetConfiguredPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetConfiguredPropertiesOperationCompleted);
            var methodOnGetConfiguredPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetConfiguredPropertiesOperationCompleted, methodOnGetConfiguredPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnGetConfiguredPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetConfiguredPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetConfiguredPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetConfiguredPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetConfiguredPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_GetPropertyConstraints_Method_Call_Internally(Type[] types)
        {
            var methodGetPropertyConstraintsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetPropertyConstraints_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var PropertyName = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASWebServiceInstance.GetPropertyConstraints(ApplicationName, LogicalObjectName, PropertyName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetPropertyConstraints_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var PropertyName = this.CreateType<string>();
            var returnedValue = default(string[][]);

            // Act
            Action executeAction = () => returnedValue = _oEASWebServiceInstance.GetPropertyConstraints(ApplicationName, LogicalObjectName, PropertyName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetPropertyConstraints_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var PropertyName = this.CreateType<string>();
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetPropertyConstraints = { ApplicationName, LogicalObjectName, PropertyName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[][]>(_oEASWebServiceInstanceFixture, parametersOfGetPropertyConstraints);
            var result2 = this.GetResultOfMethod<string[][]>(MethodGetPropertyConstraints, parametersOfGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetPropertyConstraints.ShouldNotBeNull();
            parametersOfGetPropertyConstraints.Length.ShouldBe(3);
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetPropertyConstraints_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var PropertyName = this.CreateType<string>();
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetPropertyConstraints = { ApplicationName, LogicalObjectName, PropertyName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[][]>(MethodGetPropertyConstraints, parametersOfGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            parametersOfGetPropertyConstraints.ShouldNotBeNull();
            parametersOfGetPropertyConstraints.Length.ShouldBe(3);
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetPropertyConstraints_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetPropertyConstraints_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetPropertyConstraints_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyConstraints, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : string[][]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_GetPropertyConstraints_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyConstraints, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetPropertyConstraintsOperationCompleted) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_OnGetPropertyConstraintsOperationCompleted_Method_Call_Internally(Type[] types)
        {
            var methodOnGetPropertyConstraintsOperationCompletedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnGetPropertyConstraintsOperationCompleted, methodOnGetPropertyConstraintsOperationCompletedParametersTypes);
        }

        #endregion

        #region Method Call : (OnGetPropertyConstraintsOperationCompleted) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetPropertyConstraintsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertyConstraintsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetPropertyConstraintsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetPropertyConstraintsOperationCompleted = { arg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPropertyConstraintsOperationCompleted, methodOnGetPropertyConstraintsOperationCompletedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASWebServiceInstanceFixture, parametersOfOnGetPropertyConstraintsOperationCompleted);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnGetPropertyConstraintsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetPropertyConstraintsOperationCompleted.Length.ShouldBe(1);
            methodOnGetPropertyConstraintsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetPropertyConstraintsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetPropertyConstraintsOperationCompleted.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPropertyConstraintsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetPropertyConstraintsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertyConstraintsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetPropertyConstraintsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetPropertyConstraintsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetPropertyConstraintsOperationCompleted, parametersOfOnGetPropertyConstraintsOperationCompleted, methodOnGetPropertyConstraintsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetPropertyConstraintsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetPropertyConstraintsOperationCompleted.Length.ShouldBe(1);
            methodOnGetPropertyConstraintsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetPropertyConstraintsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetPropertyConstraintsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPropertyConstraintsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetPropertyConstraintsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertyConstraintsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPropertyConstraintsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetPropertyConstraintsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetPropertyConstraintsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertyConstraintsOperationCompleted);
            var methodOnGetPropertyConstraintsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetPropertyConstraintsOperationCompleted, methodOnGetPropertyConstraintsOperationCompletedParametersTypes);

            // Assert
            methodOnGetPropertyConstraintsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPropertyConstraintsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_OnGetPropertyConstraintsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertyConstraintsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPropertyConstraintsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASWebService_IsLocalFileSystemWebService_Method_Call_Internally(Type[] types)
        {
            var methodIsLocalFileSystemWebServiceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_IsLocalFileSystemWebService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var url = this.CreateType<string>();
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsLocalFileSystemWebService = { url };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASWebServiceInstanceFixture, parametersOfIsLocalFileSystemWebService);
            var result2 = this.GetResultOfMethod<bool>(MethodIsLocalFileSystemWebService, parametersOfIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.Length.ShouldBe(1);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_IsLocalFileSystemWebService_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var url = this.CreateType<string>();
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsLocalFileSystemWebService = { url };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_oEASWebServiceInstanceFixture, out exception1, parametersOfIsLocalFileSystemWebService);
            var result2 = this.GetResultOfMethod<bool>(MethodIsLocalFileSystemWebService, parametersOfIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.Length.ShouldBe(1);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_IsLocalFileSystemWebService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var url = this.CreateType<string>();
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsLocalFileSystemWebService = { url };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsLocalFileSystemWebService, parametersOfIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            parametersOfIsLocalFileSystemWebService.ShouldNotBeNull();
            parametersOfIsLocalFileSystemWebService.Length.ShouldBe(1);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_IsLocalFileSystemWebService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var methodIsLocalFileSystemWebServiceParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsLocalFileSystemWebService, methodIsLocalFileSystemWebServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsLocalFileSystemWebServiceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_IsLocalFileSystemWebService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsLocalFileSystemWebService) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OEASWebService_IsLocalFileSystemWebService_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsLocalFileSystemWebService);
            var currentMethodInfo = this.GetMethodInfo(MethodIsLocalFileSystemWebService, 0);
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