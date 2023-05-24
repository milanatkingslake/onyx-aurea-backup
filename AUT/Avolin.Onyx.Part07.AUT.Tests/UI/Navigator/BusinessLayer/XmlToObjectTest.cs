using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.BusinessLayer;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.BusinessLayer.xmlToObject" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlToObjectTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="xmlToObject" />)
        /// </summary>
        public XmlToObjectTest() : base(typeof(xmlToObject))
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

        #region General Initializer : Class (xmlToObject) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlToObjectInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="xmlToObject" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlToObjectInstanceType = typeof(xmlToObject);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (xmlToObject) Initializer

        #region Methods

        private const string MethodGetResult = "GetResult";
        private const string MethodGetNavigatorEntities = "GetNavigatorEntities";
        private const string MethodGetDomainData = "GetDomainData";
        private const string MethodGetTaskCategory = "GetTaskCategory";
        private const string MethodGetBrowseDateFilters = "GetBrowseDateFilters";
        private const string MethodGetServiceResult = "GetServiceResult";
        private const string MethodGetDateEnumerator = "GetDateEnumerator";
        private const string MethodGetSearchFilters = "GetSearchFilters";
        private const string MethodGetOperatorEnumerator = "GetOperatorEnumerator";
        private const string MethodGetSearchFilterProfile = "GetSearchFilterProfile";
        private const string MethodGetAdministrationServiceResult = "GetAdministrationServiceResult";
        private const string MethodGetUIResources = "GetUIResources";
        private const string MethodGetResultGridProfile = "GetResultGridProfile";
        private const string MethodGetBatchUpdateFields = "GetBatchUpdateFields";
        private const string MethodGetSaveAdministrationProfileStatus = "GetSaveAdministrationProfileStatus";
        private const string MethodGetModulePriviligeCallBackHandler = "GetModulePriviligeCallBackHandler";
        private const string MethodGetDisplayProfileCallBackHandler = "GetDisplayProfileCallBackHandler";
        private const string MethodGamConfigCallBackHandler = "GamConfigCallBackHandler";
        private const string MethodGetLboMappingList = "GetLboMappingList";
        private const string MethodGetProfileList = "GetProfileList";
        private const string MethodGetCountry = "GetCountry";
        private const string MethodGetRegion = "GetRegion";
        private const string MethodGetIncidentProduct = "GetIncidentProduct";
        private const string MethodGetQueryData = "GetQueryData";
        private const string MethodGetHomePageConfigData = "GetHomePageConfigData";
        private const string MethodGetAppSettings = "GetAppSettings";
        private const string MethodGetCheckServiceStatus = "GetCheckServiceStatus";
        private const string MethodGetUserPreferenceByName = "GetUserPreferenceByName";
        private const string MethodGetResultActionGroupList = "GetResultActionGroupList";
        private const string MethodGetResultActionItemList = "GetResultActionItemList";
        private const string MethodGetClientSummaryDetails = "GetClientSummaryDetails";
        private const string MethodSetIsClickable = "SetIsClickable";
        private const string MethodGetAttributeValue = "GetAttributeValue";
        private const string MethodGetDoMoreHeader = "GetDoMoreHeader";
        private const string MethodCreateEntityDataObject = "CreateEntityDataObject";

        #endregion

        #region Fields

        private const string FieldEntityClassDictionary = "EntityClassDictionary";

        #endregion

        #endregion

        #region General Initializer : Class (xmlToObject) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="xmlToObject" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlToObject_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (xmlToObject)

        #region General Initializer : Class (xmlToObject) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="xmlToObject" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetResult, 0)]
        [TestCase(MethodGetNavigatorEntities, 0)]
        [TestCase(MethodGetDomainData, 0)]
        [TestCase(MethodGetTaskCategory, 0)]
        [TestCase(MethodGetBrowseDateFilters, 0)]
        [TestCase(MethodGetServiceResult, 0)]
        [TestCase(MethodGetDateEnumerator, 0)]
        [TestCase(MethodGetSearchFilters, 0)]
        [TestCase(MethodGetOperatorEnumerator, 0)]
        [TestCase(MethodGetSearchFilterProfile, 0)]
        [TestCase(MethodGetAdministrationServiceResult, 0)]
        [TestCase(MethodGetUIResources, 0)]
        [TestCase(MethodGetResultGridProfile, 0)]
        [TestCase(MethodGetBatchUpdateFields, 0)]
        [TestCase(MethodGetSaveAdministrationProfileStatus, 0)]
        [TestCase(MethodGetModulePriviligeCallBackHandler, 0)]
        [TestCase(MethodGetDisplayProfileCallBackHandler, 0)]
        [TestCase(MethodGamConfigCallBackHandler, 0)]
        [TestCase(MethodGetLboMappingList, 0)]
        [TestCase(MethodGetProfileList, 0)]
        [TestCase(MethodGetCountry, 0)]
        [TestCase(MethodGetRegion, 0)]
        [TestCase(MethodGetIncidentProduct, 0)]
        [TestCase(MethodGetQueryData, 0)]
        [TestCase(MethodGetHomePageConfigData, 0)]
        [TestCase(MethodGetAppSettings, 0)]
        [TestCase(MethodGetCheckServiceStatus, 0)]
        [TestCase(MethodGetUserPreferenceByName, 0)]
        [TestCase(MethodGetResultActionGroupList, 0)]
        [TestCase(MethodGetResultActionItemList, 0)]
        [TestCase(MethodGetClientSummaryDetails, 0)]
        [TestCase(MethodSetIsClickable, 0)]
        [TestCase(MethodGetAttributeValue, 0)]
        [TestCase(MethodGetDoMoreHeader, 0)]
        [TestCase(MethodCreateEntityDataObject, 0)]
        public void AUT_XmlToObject_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (xmlToObject) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="xmlToObject" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldEntityClassDictionary)]
        [Category("AUT Fields")]
        public void AUT_XmlToObject_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (xmlToObject) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="xmlToObject" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlToObject_Is_Static_Type_Present_Test()
        {
            // Assert
            _xmlToObjectInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetResult) (Return Type : ObservableCollection<object>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResult_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResult);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetResult(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetResult) (Return Type : ObservableCollection<object>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResult_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResult);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(ObservableCollection<object>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetResult(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResult) (Return Type : ObservableCollection<object>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResult_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResult);
            var sourceXml = this.CreateType<string>();
            var methodGetResultParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResult = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResult, methodGetResultParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResult);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetResult.ShouldNotBeNull();
            parametersOfGetResult.Length.ShouldBe(1);
            methodGetResultParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResult) (Return Type : ObservableCollection<object>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResult_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResult);
            var sourceXml = this.CreateType<string>();
            var methodGetResultParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResult = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ObservableCollection<object>>(MethodGetResult, parametersOfGetResult, methodGetResultParametersTypes);

            // Assert
            parametersOfGetResult.ShouldNotBeNull();
            parametersOfGetResult.Length.ShouldBe(1);
            methodGetResultParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResult) (Return Type : ObservableCollection<object>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResult_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResult);
            var methodGetResultParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResult, methodGetResultParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResult) (Return Type : ObservableCollection<object>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResult_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResult);
            var methodGetResultParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResult, methodGetResultParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResult) (Return Type : ObservableCollection<object>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResult_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResult);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResult, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResult) (Return Type : ObservableCollection<object>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResult_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResult);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResult, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetNavigatorEntities_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetNavigatorEntitiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNavigatorEntities_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetNavigatorEntities(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNavigatorEntities_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<NavigatorEntities>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetNavigatorEntities(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNavigatorEntities_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var strXml = this.CreateType<string>();
            var methodGetNavigatorEntitiesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNavigatorEntities = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetNavigatorEntities);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetNavigatorEntities.ShouldNotBeNull();
            parametersOfGetNavigatorEntities.Length.ShouldBe(1);
            methodGetNavigatorEntitiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNavigatorEntities_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var strXml = this.CreateType<string>();
            var methodGetNavigatorEntitiesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNavigatorEntities = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<NavigatorEntities>>(MethodGetNavigatorEntities, parametersOfGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);

            // Assert
            parametersOfGetNavigatorEntities.ShouldNotBeNull();
            parametersOfGetNavigatorEntities.Length.ShouldBe(1);
            methodGetNavigatorEntitiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNavigatorEntities_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var methodGetNavigatorEntitiesParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNavigatorEntitiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNavigatorEntities_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var methodGetNavigatorEntitiesParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNavigatorEntitiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNavigatorEntities_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntities, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetNavigatorEntities_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntities, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetDomainData_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDomainData, methodGetDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDomainData_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDomainData);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetDomainData(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDomainData_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDomainData);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<DomainData>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetDomainData(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDomainData_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDomainData);
            var strXml = this.CreateType<string>();
            var methodGetDomainDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDomainData = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDomainData, methodGetDomainDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetDomainData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetDomainData.ShouldNotBeNull();
            parametersOfGetDomainData.Length.ShouldBe(1);
            methodGetDomainDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDomainData_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDomainData);
            var strXml = this.CreateType<string>();
            var methodGetDomainDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDomainData = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetDomainData, parametersOfGetDomainData, methodGetDomainDataParametersTypes);

            // Assert
            parametersOfGetDomainData.ShouldNotBeNull();
            parametersOfGetDomainData.Length.ShouldBe(1);
            methodGetDomainDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDomainData_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDomainData);
            var methodGetDomainDataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDomainData, methodGetDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDomainDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDomainData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDomainData);
            var methodGetDomainDataParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDomainData, methodGetDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDomainDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDomainData_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDomainData) (Return Type : List<DomainData>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDomainData_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDomainData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetTaskCategory_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetTaskCategoryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTaskCategory, methodGetTaskCategoryParametersTypes);
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetTaskCategory_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategory);
            var resultXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetTaskCategory(resultXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetTaskCategory_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategory);
            var resultXml = this.CreateType<string>();
            var returnedValue = default(List<DomainData>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetTaskCategory(resultXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetTaskCategory_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategory);
            var resultXml = this.CreateType<string>();
            var methodGetTaskCategoryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetTaskCategory = { resultXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskCategory, methodGetTaskCategoryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetTaskCategory);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetTaskCategory.ShouldNotBeNull();
            parametersOfGetTaskCategory.Length.ShouldBe(1);
            methodGetTaskCategoryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetTaskCategory_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategory);
            var resultXml = this.CreateType<string>();
            var methodGetTaskCategoryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetTaskCategory = { resultXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetTaskCategory, parametersOfGetTaskCategory, methodGetTaskCategoryParametersTypes);

            // Assert
            parametersOfGetTaskCategory.ShouldNotBeNull();
            parametersOfGetTaskCategory.Length.ShouldBe(1);
            methodGetTaskCategoryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetTaskCategory_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategory);
            var methodGetTaskCategoryParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTaskCategory, methodGetTaskCategoryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTaskCategoryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetTaskCategory_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategory);
            var methodGetTaskCategoryParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTaskCategory, methodGetTaskCategoryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTaskCategoryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetTaskCategory_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategory);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskCategory, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskCategory) (Return Type : List<DomainData>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetTaskCategory_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategory);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskCategory, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetBrowseDateFiltersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBrowseDateFilters, methodGetBrowseDateFiltersParametersTypes);
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBrowseDateFilters);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetBrowseDateFilters(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBrowseDateFilters);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<DateFilter>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetBrowseDateFilters(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBrowseDateFilters);
            var strXml = this.CreateType<string>();
            var methodGetBrowseDateFiltersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetBrowseDateFilters = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBrowseDateFilters, methodGetBrowseDateFiltersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetBrowseDateFilters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetBrowseDateFilters.ShouldNotBeNull();
            parametersOfGetBrowseDateFilters.Length.ShouldBe(1);
            methodGetBrowseDateFiltersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBrowseDateFilters);
            var strXml = this.CreateType<string>();
            var methodGetBrowseDateFiltersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetBrowseDateFilters = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DateFilter>>(MethodGetBrowseDateFilters, parametersOfGetBrowseDateFilters, methodGetBrowseDateFiltersParametersTypes);

            // Assert
            parametersOfGetBrowseDateFilters.ShouldNotBeNull();
            parametersOfGetBrowseDateFilters.Length.ShouldBe(1);
            methodGetBrowseDateFiltersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBrowseDateFilters);
            var methodGetBrowseDateFiltersParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBrowseDateFilters, methodGetBrowseDateFiltersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBrowseDateFiltersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBrowseDateFilters);
            var methodGetBrowseDateFiltersParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBrowseDateFilters, methodGetBrowseDateFiltersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBrowseDateFiltersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBrowseDateFilters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBrowseDateFilters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBrowseDateFilters) (Return Type : List<DateFilter>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBrowseDateFilters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBrowseDateFilters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBrowseDateFilters, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetServiceResult_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetServiceResultParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetServiceResult, methodGetServiceResultParametersTypes);
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetServiceResult_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceResult);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetServiceResult(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetServiceResult_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceResult);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<ServiceResult>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetServiceResult(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetServiceResult_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceResult);
            var strXml = this.CreateType<string>();
            var methodGetServiceResultParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetServiceResult = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceResult, methodGetServiceResultParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetServiceResult);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetServiceResult.ShouldNotBeNull();
            parametersOfGetServiceResult.Length.ShouldBe(1);
            methodGetServiceResultParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetServiceResult_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceResult);
            var strXml = this.CreateType<string>();
            var methodGetServiceResultParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetServiceResult = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ServiceResult>>(MethodGetServiceResult, parametersOfGetServiceResult, methodGetServiceResultParametersTypes);

            // Assert
            parametersOfGetServiceResult.ShouldNotBeNull();
            parametersOfGetServiceResult.Length.ShouldBe(1);
            methodGetServiceResultParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetServiceResult_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceResult);
            var methodGetServiceResultParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetServiceResult, methodGetServiceResultParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetServiceResultParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetServiceResult_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceResult);
            var methodGetServiceResultParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetServiceResult, methodGetServiceResultParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetServiceResultParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetServiceResult_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceResult);
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceResult, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceResult) (Return Type : List<ServiceResult>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetServiceResult_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceResult);
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceResult, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetDateEnumerator_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetDateEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDateEnumerator, methodGetDateEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDateEnumerator_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateEnumerator);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetDateEnumerator(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDateEnumerator_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateEnumerator);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<DateEnumeration>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetDateEnumerator(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDateEnumerator_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateEnumerator);
            var strXml = this.CreateType<string>();
            var methodGetDateEnumeratorParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDateEnumerator = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateEnumerator, methodGetDateEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetDateEnumerator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetDateEnumerator.ShouldNotBeNull();
            parametersOfGetDateEnumerator.Length.ShouldBe(1);
            methodGetDateEnumeratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDateEnumerator_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateEnumerator);
            var strXml = this.CreateType<string>();
            var methodGetDateEnumeratorParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDateEnumerator = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DateEnumeration>>(MethodGetDateEnumerator, parametersOfGetDateEnumerator, methodGetDateEnumeratorParametersTypes);

            // Assert
            parametersOfGetDateEnumerator.ShouldNotBeNull();
            parametersOfGetDateEnumerator.Length.ShouldBe(1);
            methodGetDateEnumeratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDateEnumerator_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateEnumerator);
            var methodGetDateEnumeratorParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDateEnumerator, methodGetDateEnumeratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDateEnumeratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDateEnumerator_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateEnumerator);
            var methodGetDateEnumeratorParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDateEnumerator, methodGetDateEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDateEnumeratorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDateEnumerator_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateEnumerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateEnumerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateEnumerator) (Return Type : List<DateEnumeration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDateEnumerator_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateEnumerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateEnumerator, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetSearchFilters_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchFiltersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilters_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetSearchFilters(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilters_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<SearchFilter>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetSearchFilters(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilters_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var sourceXml = this.CreateType<string>();
            var methodGetSearchFiltersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSearchFilters = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSearchFilters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSearchFilters.ShouldNotBeNull();
            parametersOfGetSearchFilters.Length.ShouldBe(1);
            methodGetSearchFiltersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilters_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var sourceXml = this.CreateType<string>();
            var methodGetSearchFiltersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSearchFilters = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<SearchFilter>>(MethodGetSearchFilters, parametersOfGetSearchFilters, methodGetSearchFiltersParametersTypes);

            // Assert
            parametersOfGetSearchFilters.ShouldNotBeNull();
            parametersOfGetSearchFilters.Length.ShouldBe(1);
            methodGetSearchFiltersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilters_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var methodGetSearchFiltersParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchFiltersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var methodGetSearchFiltersParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchFiltersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilters_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilters, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOperatorEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetOperatorEnumerator(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<OperatorData>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetOperatorEnumerator(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var strXml = this.CreateType<string>();
            var methodGetOperatorEnumeratorParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetOperatorEnumerator = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOperatorEnumerator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOperatorEnumerator.ShouldNotBeNull();
            parametersOfGetOperatorEnumerator.Length.ShouldBe(1);
            methodGetOperatorEnumeratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var strXml = this.CreateType<string>();
            var methodGetOperatorEnumeratorParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetOperatorEnumerator = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<OperatorData>>(MethodGetOperatorEnumerator, parametersOfGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);

            // Assert
            parametersOfGetOperatorEnumerator.ShouldNotBeNull();
            parametersOfGetOperatorEnumerator.Length.ShouldBe(1);
            methodGetOperatorEnumeratorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var methodGetOperatorEnumeratorParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOperatorEnumeratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var methodGetOperatorEnumeratorParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOperatorEnumeratorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorEnumerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetOperatorEnumerator_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorEnumerator, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var xml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetSearchFilterProfile(xml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var xml = this.CreateType<string>();
            var returnedValue = default(SearchFilterConfiguration);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetSearchFilterProfile(xml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var xml = this.CreateType<string>();
            var methodGetSearchFilterProfileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSearchFilterProfile = { xml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);
            var result2 = this.GetResultOfMethod<SearchFilterConfiguration>(MethodGetSearchFilterProfile, parametersOfGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSearchFilterProfile);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchFilterProfile.ShouldNotBeNull();
            parametersOfGetSearchFilterProfile.Length.ShouldBe(1);
            methodGetSearchFilterProfileParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var xml = this.CreateType<string>();
            var methodGetSearchFilterProfileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSearchFilterProfile = { xml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SearchFilterConfiguration>(MethodGetSearchFilterProfile, parametersOfGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            parametersOfGetSearchFilterProfile.ShouldNotBeNull();
            parametersOfGetSearchFilterProfile.Length.ShouldBe(1);
            methodGetSearchFilterProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var methodGetSearchFilterProfileParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchFilterProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var methodGetSearchFilterProfileParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchFilterProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchFilterConfiguration) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSearchFilterProfile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilterProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetAdministrationServiceResultParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAdministrationServiceResult, methodGetAdministrationServiceResultParametersTypes);
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAdministrationServiceResult);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetAdministrationServiceResult(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAdministrationServiceResult);
            var strXml = this.CreateType<string>();
            var returnedValue = default(AdministrationServiceResult);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetAdministrationServiceResult(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAdministrationServiceResult);
            var strXml = this.CreateType<string>();
            var methodGetAdministrationServiceResultParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetAdministrationServiceResult = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAdministrationServiceResult, methodGetAdministrationServiceResultParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetAdministrationServiceResult);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetAdministrationServiceResult.ShouldNotBeNull();
            parametersOfGetAdministrationServiceResult.Length.ShouldBe(1);
            methodGetAdministrationServiceResultParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAdministrationServiceResult);
            var strXml = this.CreateType<string>();
            var methodGetAdministrationServiceResultParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetAdministrationServiceResult = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<AdministrationServiceResult>(MethodGetAdministrationServiceResult, parametersOfGetAdministrationServiceResult, methodGetAdministrationServiceResultParametersTypes);

            // Assert
            parametersOfGetAdministrationServiceResult.ShouldNotBeNull();
            parametersOfGetAdministrationServiceResult.Length.ShouldBe(1);
            methodGetAdministrationServiceResultParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAdministrationServiceResult);
            var methodGetAdministrationServiceResultParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAdministrationServiceResult, methodGetAdministrationServiceResultParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAdministrationServiceResultParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAdministrationServiceResult);
            var methodGetAdministrationServiceResultParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAdministrationServiceResult, methodGetAdministrationServiceResultParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAdministrationServiceResultParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAdministrationServiceResult);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAdministrationServiceResult, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAdministrationServiceResult) (Return Type : AdministrationServiceResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAdministrationServiceResult_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAdministrationServiceResult);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAdministrationServiceResult, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetUIResources_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUIResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUIResources, methodGetUIResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUIResources_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUIResources);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetUIResources(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUIResources_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUIResources);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<AccessPrivilege>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetUIResources(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUIResources_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUIResources);
            var sourceXml = this.CreateType<string>();
            var methodGetUIResourcesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUIResources = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUIResources, methodGetUIResourcesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUIResources);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUIResources.ShouldNotBeNull();
            parametersOfGetUIResources.Length.ShouldBe(1);
            methodGetUIResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUIResources_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUIResources);
            var sourceXml = this.CreateType<string>();
            var methodGetUIResourcesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUIResources = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<AccessPrivilege>>(MethodGetUIResources, parametersOfGetUIResources, methodGetUIResourcesParametersTypes);

            // Assert
            parametersOfGetUIResources.ShouldNotBeNull();
            parametersOfGetUIResources.Length.ShouldBe(1);
            methodGetUIResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUIResources_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUIResources);
            var methodGetUIResourcesParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUIResources, methodGetUIResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUIResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUIResources_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUIResources);
            var methodGetUIResourcesParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUIResources, methodGetUIResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUIResourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUIResources_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUIResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUIResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUIResources) (Return Type : List<AccessPrivilege>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUIResources_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUIResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUIResources, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetResultGridProfile_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResultGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultGridProfile_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetResultGridProfile(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultGridProfile_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(ResultFilterConfiguration);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetResultGridProfile(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultGridProfile_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var sourceXml = this.CreateType<string>();
            var methodGetResultGridProfileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResultGridProfile = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResultGridProfile);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetResultGridProfile.ShouldNotBeNull();
            parametersOfGetResultGridProfile.Length.ShouldBe(1);
            methodGetResultGridProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultGridProfile_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var sourceXml = this.CreateType<string>();
            var methodGetResultGridProfileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResultGridProfile = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResultFilterConfiguration>(MethodGetResultGridProfile, parametersOfGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            parametersOfGetResultGridProfile.ShouldNotBeNull();
            parametersOfGetResultGridProfile.Length.ShouldBe(1);
            methodGetResultGridProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultGridProfile_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var methodGetResultGridProfileParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultGridProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultGridProfile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var methodGetResultGridProfileParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultGridProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultGridProfile_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultGridProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultFilterConfiguration) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultGridProfile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultGridProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetBatchUpdateFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetBatchUpdateFields(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<BatchUpdateField>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetBatchUpdateFields(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var sourceXml = this.CreateType<string>();
            var methodGetBatchUpdateFieldsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetBatchUpdateFields = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetBatchUpdateFields);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetBatchUpdateFields.ShouldNotBeNull();
            parametersOfGetBatchUpdateFields.Length.ShouldBe(1);
            methodGetBatchUpdateFieldsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var sourceXml = this.CreateType<string>();
            var methodGetBatchUpdateFieldsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetBatchUpdateFields = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<BatchUpdateField>>(MethodGetBatchUpdateFields, parametersOfGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            parametersOfGetBatchUpdateFields.ShouldNotBeNull();
            parametersOfGetBatchUpdateFields.Length.ShouldBe(1);
            methodGetBatchUpdateFieldsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var methodGetBatchUpdateFieldsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBatchUpdateFieldsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var methodGetBatchUpdateFieldsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBatchUpdateFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdateFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetBatchUpdateFields_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdateFields, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSaveAdministrationProfileStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSaveAdministrationProfileStatus, methodGetSaveAdministrationProfileStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveAdministrationProfileStatus);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetSaveAdministrationProfileStatus(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveAdministrationProfileStatus);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<ServiceResult>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetSaveAdministrationProfileStatus(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveAdministrationProfileStatus);
            var strXml = this.CreateType<string>();
            var methodGetSaveAdministrationProfileStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSaveAdministrationProfileStatus = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSaveAdministrationProfileStatus, methodGetSaveAdministrationProfileStatusParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSaveAdministrationProfileStatus);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSaveAdministrationProfileStatus.ShouldNotBeNull();
            parametersOfGetSaveAdministrationProfileStatus.Length.ShouldBe(1);
            methodGetSaveAdministrationProfileStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveAdministrationProfileStatus);
            var strXml = this.CreateType<string>();
            var methodGetSaveAdministrationProfileStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSaveAdministrationProfileStatus = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ServiceResult>>(MethodGetSaveAdministrationProfileStatus, parametersOfGetSaveAdministrationProfileStatus, methodGetSaveAdministrationProfileStatusParametersTypes);

            // Assert
            parametersOfGetSaveAdministrationProfileStatus.ShouldNotBeNull();
            parametersOfGetSaveAdministrationProfileStatus.Length.ShouldBe(1);
            methodGetSaveAdministrationProfileStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveAdministrationProfileStatus);
            var methodGetSaveAdministrationProfileStatusParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSaveAdministrationProfileStatus, methodGetSaveAdministrationProfileStatusParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSaveAdministrationProfileStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveAdministrationProfileStatus);
            var methodGetSaveAdministrationProfileStatusParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSaveAdministrationProfileStatus, methodGetSaveAdministrationProfileStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSaveAdministrationProfileStatusParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveAdministrationProfileStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSaveAdministrationProfileStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSaveAdministrationProfileStatus) (Return Type : List<ServiceResult>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetSaveAdministrationProfileStatus_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveAdministrationProfileStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSaveAdministrationProfileStatus, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetModulePriviligeCallBackHandlerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetModulePriviligeCallBackHandler, methodGetModulePriviligeCallBackHandlerParametersTypes);
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePriviligeCallBackHandler);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetModulePriviligeCallBackHandler(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePriviligeCallBackHandler);
            var strXml = this.CreateType<string>();
            var returnedValue = default(AccessPrivilege);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetModulePriviligeCallBackHandler(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePriviligeCallBackHandler);
            var strXml = this.CreateType<string>();
            var methodGetModulePriviligeCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetModulePriviligeCallBackHandler = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePriviligeCallBackHandler, methodGetModulePriviligeCallBackHandlerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetModulePriviligeCallBackHandler);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetModulePriviligeCallBackHandler.ShouldNotBeNull();
            parametersOfGetModulePriviligeCallBackHandler.Length.ShouldBe(1);
            methodGetModulePriviligeCallBackHandlerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePriviligeCallBackHandler);
            var strXml = this.CreateType<string>();
            var methodGetModulePriviligeCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetModulePriviligeCallBackHandler = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<AccessPrivilege>(MethodGetModulePriviligeCallBackHandler, parametersOfGetModulePriviligeCallBackHandler, methodGetModulePriviligeCallBackHandlerParametersTypes);

            // Assert
            parametersOfGetModulePriviligeCallBackHandler.ShouldNotBeNull();
            parametersOfGetModulePriviligeCallBackHandler.Length.ShouldBe(1);
            methodGetModulePriviligeCallBackHandlerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePriviligeCallBackHandler);
            var methodGetModulePriviligeCallBackHandlerParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModulePriviligeCallBackHandler, methodGetModulePriviligeCallBackHandlerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModulePriviligeCallBackHandlerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePriviligeCallBackHandler);
            var methodGetModulePriviligeCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModulePriviligeCallBackHandler, methodGetModulePriviligeCallBackHandlerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModulePriviligeCallBackHandlerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePriviligeCallBackHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePriviligeCallBackHandler, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePriviligeCallBackHandler) (Return Type : AccessPrivilege) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetModulePriviligeCallBackHandler_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePriviligeCallBackHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePriviligeCallBackHandler, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetDisplayProfileCallBackHandlerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDisplayProfileCallBackHandler, methodGetDisplayProfileCallBackHandlerParametersTypes);
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDisplayProfileCallBackHandler);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetDisplayProfileCallBackHandler(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDisplayProfileCallBackHandler);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<AccessControlList>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetDisplayProfileCallBackHandler(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDisplayProfileCallBackHandler);
            var strXml = this.CreateType<string>();
            var methodGetDisplayProfileCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDisplayProfileCallBackHandler = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDisplayProfileCallBackHandler, methodGetDisplayProfileCallBackHandlerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetDisplayProfileCallBackHandler);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetDisplayProfileCallBackHandler.ShouldNotBeNull();
            parametersOfGetDisplayProfileCallBackHandler.Length.ShouldBe(1);
            methodGetDisplayProfileCallBackHandlerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDisplayProfileCallBackHandler);
            var strXml = this.CreateType<string>();
            var methodGetDisplayProfileCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDisplayProfileCallBackHandler = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<AccessControlList>>(MethodGetDisplayProfileCallBackHandler, parametersOfGetDisplayProfileCallBackHandler, methodGetDisplayProfileCallBackHandlerParametersTypes);

            // Assert
            parametersOfGetDisplayProfileCallBackHandler.ShouldNotBeNull();
            parametersOfGetDisplayProfileCallBackHandler.Length.ShouldBe(1);
            methodGetDisplayProfileCallBackHandlerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDisplayProfileCallBackHandler);
            var methodGetDisplayProfileCallBackHandlerParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDisplayProfileCallBackHandler, methodGetDisplayProfileCallBackHandlerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDisplayProfileCallBackHandlerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDisplayProfileCallBackHandler);
            var methodGetDisplayProfileCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDisplayProfileCallBackHandler, methodGetDisplayProfileCallBackHandlerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDisplayProfileCallBackHandlerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDisplayProfileCallBackHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDisplayProfileCallBackHandler, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDisplayProfileCallBackHandler) (Return Type : List<AccessControlList>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDisplayProfileCallBackHandler_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDisplayProfileCallBackHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDisplayProfileCallBackHandler, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_Call_Internally(Type[] types)
        {
            var methodGamConfigCallBackHandlerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGamConfigCallBackHandler, methodGamConfigCallBackHandlerParametersTypes);
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGamConfigCallBackHandler);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GamConfigCallBackHandler(strXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGamConfigCallBackHandler);
            var strXml = this.CreateType<string>();
            var returnedValue = default(GamProfile);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GamConfigCallBackHandler(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGamConfigCallBackHandler);
            var strXml = this.CreateType<string>();
            var methodGamConfigCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGamConfigCallBackHandler = { strXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGamConfigCallBackHandler, methodGamConfigCallBackHandlerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGamConfigCallBackHandler, methodGamConfigCallBackHandlerParametersTypes);
            var result2 = this.GetResultOfMethod<GamProfile>(MethodGamConfigCallBackHandler, parametersOfGamConfigCallBackHandler, methodGamConfigCallBackHandlerParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGamConfigCallBackHandler);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGamConfigCallBackHandler.ShouldNotBeNull();
            parametersOfGamConfigCallBackHandler.Length.ShouldBe(1);
            methodGamConfigCallBackHandlerParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGamConfigCallBackHandler);
            var strXml = this.CreateType<string>();
            var methodGamConfigCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGamConfigCallBackHandler = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<GamProfile>(MethodGamConfigCallBackHandler, parametersOfGamConfigCallBackHandler, methodGamConfigCallBackHandlerParametersTypes);

            // Assert
            parametersOfGamConfigCallBackHandler.ShouldNotBeNull();
            parametersOfGamConfigCallBackHandler.Length.ShouldBe(1);
            methodGamConfigCallBackHandlerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGamConfigCallBackHandler);
            var methodGamConfigCallBackHandlerParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGamConfigCallBackHandler, methodGamConfigCallBackHandlerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGamConfigCallBackHandlerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGamConfigCallBackHandler);
            var methodGamConfigCallBackHandlerParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGamConfigCallBackHandler, methodGamConfigCallBackHandlerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGamConfigCallBackHandlerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGamConfigCallBackHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodGamConfigCallBackHandler, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GamConfigCallBackHandler) (Return Type : GamProfile) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GamConfigCallBackHandler_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGamConfigCallBackHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodGamConfigCallBackHandler, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetLboMappingList_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetLboMappingListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboMappingList, methodGetLboMappingListParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetLboMappingList_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingList);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetLboMappingList(sourceXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetLboMappingList_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingList);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<MappingsModel>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetLboMappingList(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetLboMappingList_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingList);
            var sourceXml = this.CreateType<string>();
            var methodGetLboMappingListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLboMappingList = { sourceXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappingList, methodGetLboMappingListParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetLboMappingList, methodGetLboMappingListParametersTypes);
            var result2 = this.GetResultOfMethod<List<MappingsModel>>(MethodGetLboMappingList, parametersOfGetLboMappingList, methodGetLboMappingListParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetLboMappingList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboMappingList.ShouldNotBeNull();
            parametersOfGetLboMappingList.Length.ShouldBe(1);
            methodGetLboMappingListParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetLboMappingList_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingList);
            var sourceXml = this.CreateType<string>();
            var methodGetLboMappingListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLboMappingList = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<MappingsModel>>(MethodGetLboMappingList, parametersOfGetLboMappingList, methodGetLboMappingListParametersTypes);

            // Assert
            parametersOfGetLboMappingList.ShouldNotBeNull();
            parametersOfGetLboMappingList.Length.ShouldBe(1);
            methodGetLboMappingListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetLboMappingList_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingList);
            var methodGetLboMappingListParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboMappingList, methodGetLboMappingListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboMappingListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetLboMappingList_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingList);
            var methodGetLboMappingListParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboMappingList, methodGetLboMappingListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboMappingListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetLboMappingList_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappingList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingList) (Return Type : List<MappingsModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetLboMappingList_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappingList, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetProfileList_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetProfileListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProfileList, methodGetProfileListParametersTypes);
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetProfileList_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileList);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetProfileList(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetProfileList_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileList);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<ListItem>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetProfileList(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetProfileList_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileList);
            var sourceXml = this.CreateType<string>();
            var methodGetProfileListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProfileList = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileList, methodGetProfileListParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetProfileList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetProfileList.ShouldNotBeNull();
            parametersOfGetProfileList.Length.ShouldBe(1);
            methodGetProfileListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetProfileList_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileList);
            var sourceXml = this.CreateType<string>();
            var methodGetProfileListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProfileList = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ListItem>>(MethodGetProfileList, parametersOfGetProfileList, methodGetProfileListParametersTypes);

            // Assert
            parametersOfGetProfileList.ShouldNotBeNull();
            parametersOfGetProfileList.Length.ShouldBe(1);
            methodGetProfileListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetProfileList_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileList);
            var methodGetProfileListParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProfileList, methodGetProfileListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProfileListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetProfileList_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileList);
            var methodGetProfileListParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProfileList, methodGetProfileListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProfileListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetProfileList_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProfileList) (Return Type : List<ListItem>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetProfileList_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileList, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetCountry_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCountryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCountry, methodGetCountryParametersTypes);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCountry_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetCountry(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCountry_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<Country>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetCountry(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCountry_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var sourceXml = this.CreateType<string>();
            var methodGetCountryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCountry = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountry, methodGetCountryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCountry);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCountry.ShouldNotBeNull();
            parametersOfGetCountry.Length.ShouldBe(1);
            methodGetCountryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCountry_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var sourceXml = this.CreateType<string>();
            var methodGetCountryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCountry = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<Country>>(MethodGetCountry, parametersOfGetCountry, methodGetCountryParametersTypes);

            // Assert
            parametersOfGetCountry.ShouldNotBeNull();
            parametersOfGetCountry.Length.ShouldBe(1);
            methodGetCountryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCountry_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var methodGetCountryParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountry, methodGetCountryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCountryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCountry_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var methodGetCountryParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCountry, methodGetCountryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCountryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCountry_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountry, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCountry_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountry, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetRegion_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetRegionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetRegion_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetRegion(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetRegion_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<Region>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetRegion(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetRegion_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var sourceXml = this.CreateType<string>();
            var methodGetRegionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRegion = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegion, methodGetRegionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRegion);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRegion.ShouldNotBeNull();
            parametersOfGetRegion.Length.ShouldBe(1);
            methodGetRegionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetRegion_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var sourceXml = this.CreateType<string>();
            var methodGetRegionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRegion = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<Region>>(MethodGetRegion, parametersOfGetRegion, methodGetRegionParametersTypes);

            // Assert
            parametersOfGetRegion.ShouldNotBeNull();
            parametersOfGetRegion.Length.ShouldBe(1);
            methodGetRegionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetRegion_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var methodGetRegionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRegionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetRegion_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var methodGetRegionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRegionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetRegion_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegion, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetRegion_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegion, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetIncidentProduct_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentProductParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetIncidentProduct_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetIncidentProduct(sourceXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetIncidentProduct_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<IncidentProduct>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetIncidentProduct(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetIncidentProduct_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var sourceXml = this.CreateType<string>();
            var methodGetIncidentProductParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentProduct = { sourceXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetIncidentProduct);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetIncidentProduct.ShouldNotBeNull();
            parametersOfGetIncidentProduct.Length.ShouldBe(1);
            methodGetIncidentProductParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetIncidentProduct_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var sourceXml = this.CreateType<string>();
            var methodGetIncidentProductParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentProduct = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<IncidentProduct>>(MethodGetIncidentProduct, parametersOfGetIncidentProduct, methodGetIncidentProductParametersTypes);

            // Assert
            parametersOfGetIncidentProduct.ShouldNotBeNull();
            parametersOfGetIncidentProduct.Length.ShouldBe(1);
            methodGetIncidentProductParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetIncidentProduct_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var methodGetIncidentProductParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentProductParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetIncidentProduct_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var methodGetIncidentProductParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentProductParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetIncidentProduct_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProduct, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetIncidentProduct_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProduct, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetQueryData_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryData, methodGetQueryDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetQueryData_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetQueryData(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetQueryData_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var strXml = this.CreateType<string>();
            var returnedValue = default(QueryInfo);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetQueryData(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetQueryData_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var strXml = this.CreateType<string>();
            var methodGetQueryDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetQueryData = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryData, methodGetQueryDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetQueryData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetQueryData.ShouldNotBeNull();
            parametersOfGetQueryData.Length.ShouldBe(1);
            methodGetQueryDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetQueryData_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var strXml = this.CreateType<string>();
            var methodGetQueryDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetQueryData = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<QueryInfo>(MethodGetQueryData, parametersOfGetQueryData, methodGetQueryDataParametersTypes);

            // Assert
            parametersOfGetQueryData.ShouldNotBeNull();
            parametersOfGetQueryData.Length.ShouldBe(1);
            methodGetQueryDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetQueryData_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var methodGetQueryDataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryData, methodGetQueryDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetQueryData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var methodGetQueryDataParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryData, methodGetQueryDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetQueryData_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : QueryInfo) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetQueryData_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetHomePageConfigData_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetHomePageConfigDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfigData, methodGetHomePageConfigDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetHomePageConfigData_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfigData);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetHomePageConfigData(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetHomePageConfigData_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfigData);
            var strXml = this.CreateType<string>();
            var returnedValue = default(HomePageConfig);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetHomePageConfigData(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetHomePageConfigData_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfigData);
            var strXml = this.CreateType<string>();
            var methodGetHomePageConfigDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetHomePageConfigData = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfigData, methodGetHomePageConfigDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetHomePageConfigData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetHomePageConfigData.ShouldNotBeNull();
            parametersOfGetHomePageConfigData.Length.ShouldBe(1);
            methodGetHomePageConfigDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetHomePageConfigData_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfigData);
            var strXml = this.CreateType<string>();
            var methodGetHomePageConfigDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetHomePageConfigData = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<HomePageConfig>(MethodGetHomePageConfigData, parametersOfGetHomePageConfigData, methodGetHomePageConfigDataParametersTypes);

            // Assert
            parametersOfGetHomePageConfigData.ShouldNotBeNull();
            parametersOfGetHomePageConfigData.Length.ShouldBe(1);
            methodGetHomePageConfigDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetHomePageConfigData_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfigData);
            var methodGetHomePageConfigDataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfigData, methodGetHomePageConfigDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageConfigDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetHomePageConfigData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfigData);
            var methodGetHomePageConfigDataParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfigData, methodGetHomePageConfigDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageConfigDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetHomePageConfigData_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfigData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfigData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfigData) (Return Type : HomePageConfig) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetHomePageConfigData_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfigData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfigData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetAppSettings_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetAppSettingsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAppSettings_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetAppSettings(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAppSettings_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var strXml = this.CreateType<string>();
            var returnedValue = default(AppSettings);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetAppSettings(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAppSettings_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var strXml = this.CreateType<string>();
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetAppSettings = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, methodGetAppSettingsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetAppSettings);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetAppSettings.ShouldNotBeNull();
            parametersOfGetAppSettings.Length.ShouldBe(1);
            methodGetAppSettingsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAppSettings_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var strXml = this.CreateType<string>();
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetAppSettings = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<AppSettings>(MethodGetAppSettings, parametersOfGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            parametersOfGetAppSettings.ShouldNotBeNull();
            parametersOfGetAppSettings.Length.ShouldBe(1);
            methodGetAppSettingsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAppSettings_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAppSettingsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAppSettings_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAppSettingsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAppSettings_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAppSettings_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCheckServiceStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetCheckServiceStatus(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var strXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetCheckServiceStatus(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var strXml = this.CreateType<string>();
            var methodGetCheckServiceStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCheckServiceStatus = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCheckServiceStatus);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCheckServiceStatus.ShouldNotBeNull();
            parametersOfGetCheckServiceStatus.Length.ShouldBe(1);
            methodGetCheckServiceStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var strXml = this.CreateType<string>();
            var methodGetCheckServiceStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCheckServiceStatus = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCheckServiceStatus, parametersOfGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes);

            // Assert
            parametersOfGetCheckServiceStatus.ShouldNotBeNull();
            parametersOfGetCheckServiceStatus.Length.ShouldBe(1);
            methodGetCheckServiceStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var methodGetCheckServiceStatusParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCheckServiceStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var methodGetCheckServiceStatusParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCheckServiceStatus, methodGetCheckServiceStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCheckServiceStatusParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCheckServiceStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCheckServiceStatus) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetCheckServiceStatus_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCheckServiceStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCheckServiceStatus, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUserPreferenceByNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetUserPreferenceByName(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<UserPreference>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetUserPreferenceByName(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var strXml = this.CreateType<string>();
            var methodGetUserPreferenceByNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUserPreferenceByName = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUserPreferenceByName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUserPreferenceByName.ShouldNotBeNull();
            parametersOfGetUserPreferenceByName.Length.ShouldBe(1);
            methodGetUserPreferenceByNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var strXml = this.CreateType<string>();
            var methodGetUserPreferenceByNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUserPreferenceByName = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<UserPreference>>(MethodGetUserPreferenceByName, parametersOfGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            parametersOfGetUserPreferenceByName.ShouldNotBeNull();
            parametersOfGetUserPreferenceByName.Length.ShouldBe(1);
            methodGetUserPreferenceByNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var methodGetUserPreferenceByNameParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserPreferenceByNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var methodGetUserPreferenceByNameParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserPreferenceByNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceByName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetUserPreferenceByName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceByName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetResultActionGroupList_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResultActionGroupListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultActionGroupList, methodGetResultActionGroupListParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionGroupList_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroupList);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetResultActionGroupList(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionGroupList_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroupList);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<ResultGridToolActionGroup>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetResultActionGroupList(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionGroupList_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroupList);
            var strXml = this.CreateType<string>();
            var methodGetResultActionGroupListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResultActionGroupList = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionGroupList, methodGetResultActionGroupListParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResultActionGroupList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetResultActionGroupList.ShouldNotBeNull();
            parametersOfGetResultActionGroupList.Length.ShouldBe(1);
            methodGetResultActionGroupListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionGroupList_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroupList);
            var strXml = this.CreateType<string>();
            var methodGetResultActionGroupListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResultActionGroupList = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ResultGridToolActionGroup>>(MethodGetResultActionGroupList, parametersOfGetResultActionGroupList, methodGetResultActionGroupListParametersTypes);

            // Assert
            parametersOfGetResultActionGroupList.ShouldNotBeNull();
            parametersOfGetResultActionGroupList.Length.ShouldBe(1);
            methodGetResultActionGroupListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionGroupList_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroupList);
            var methodGetResultActionGroupListParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultActionGroupList, methodGetResultActionGroupListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultActionGroupListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionGroupList_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroupList);
            var methodGetResultActionGroupListParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultActionGroupList, methodGetResultActionGroupListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultActionGroupListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionGroupList_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroupList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionGroupList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionGroupList) (Return Type : List<ResultGridToolActionGroup>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionGroupList_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroupList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionGroupList, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetResultActionItemList_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResultActionItemListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultActionItemList, methodGetResultActionItemListParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionItemList_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItemList);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetResultActionItemList(strXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionItemList_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItemList);
            var strXml = this.CreateType<string>();
            var returnedValue = default(List<ResultGridToolActionItem>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetResultActionItemList(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionItemList_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItemList);
            var strXml = this.CreateType<string>();
            var methodGetResultActionItemListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResultActionItemList = { strXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionItemList, methodGetResultActionItemListParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResultActionItemList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetResultActionItemList.ShouldNotBeNull();
            parametersOfGetResultActionItemList.Length.ShouldBe(1);
            methodGetResultActionItemListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionItemList_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItemList);
            var strXml = this.CreateType<string>();
            var methodGetResultActionItemListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResultActionItemList = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ResultGridToolActionItem>>(MethodGetResultActionItemList, parametersOfGetResultActionItemList, methodGetResultActionItemListParametersTypes);

            // Assert
            parametersOfGetResultActionItemList.ShouldNotBeNull();
            parametersOfGetResultActionItemList.Length.ShouldBe(1);
            methodGetResultActionItemListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionItemList_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItemList);
            var methodGetResultActionItemListParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultActionItemList, methodGetResultActionItemListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultActionItemListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionItemList_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItemList);
            var methodGetResultActionItemListParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultActionItemList, methodGetResultActionItemListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultActionItemListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionItemList_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItemList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionItemList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionItemList) (Return Type : List<ResultGridToolActionItem>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetResultActionItemList_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItemList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionItemList, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetClientSummaryDetailsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetClientSummaryDetails, methodGetClientSummaryDetailsParametersTypes);
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetClientSummaryDetails);
            var strXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetClientSummaryDetails(strXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetClientSummaryDetails);
            var strXml = this.CreateType<string>();
            var returnedValue = default(ClientSummary);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetClientSummaryDetails(strXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetClientSummaryDetails);
            var strXml = this.CreateType<string>();
            var methodGetClientSummaryDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetClientSummaryDetails = { strXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetClientSummaryDetails, methodGetClientSummaryDetailsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetClientSummaryDetails, methodGetClientSummaryDetailsParametersTypes);
            var result2 = this.GetResultOfMethod<ClientSummary>(MethodGetClientSummaryDetails, parametersOfGetClientSummaryDetails, methodGetClientSummaryDetailsParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetClientSummaryDetails);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetClientSummaryDetails.ShouldNotBeNull();
            parametersOfGetClientSummaryDetails.Length.ShouldBe(1);
            methodGetClientSummaryDetailsParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetClientSummaryDetails);
            var strXml = this.CreateType<string>();
            var methodGetClientSummaryDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetClientSummaryDetails = { strXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ClientSummary>(MethodGetClientSummaryDetails, parametersOfGetClientSummaryDetails, methodGetClientSummaryDetailsParametersTypes);

            // Assert
            parametersOfGetClientSummaryDetails.ShouldNotBeNull();
            parametersOfGetClientSummaryDetails.Length.ShouldBe(1);
            methodGetClientSummaryDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetClientSummaryDetails);
            var methodGetClientSummaryDetailsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetClientSummaryDetails, methodGetClientSummaryDetailsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetClientSummaryDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetClientSummaryDetails);
            var methodGetClientSummaryDetailsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetClientSummaryDetails, methodGetClientSummaryDetailsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetClientSummaryDetailsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetClientSummaryDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetClientSummaryDetails, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetClientSummaryDetails) (Return Type : ClientSummary) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetClientSummaryDetails_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetClientSummaryDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetClientSummaryDetails, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_SetIsClickable_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetIsClickableParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetIsClickable, methodSetIsClickableParametersTypes);
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var HyperLink = this.CreateType<string>();
            var LinkColumnName = this.CreateType<string>();
            var EntityObject = this.CreateType<object>();

            // Act
            Action executeAction = () => xmlToObject.SetIsClickable(HyperLink, LinkColumnName, EntityObject);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var HyperLink = this.CreateType<string>();
            var LinkColumnName = this.CreateType<string>();
            var EntityObject = this.CreateType<object>();
            var methodSetIsClickableParametersTypes = new Type[] { typeof(String), typeof(String), typeof(object) };
            object[] parametersOfSetIsClickable = { HyperLink, LinkColumnName, EntityObject };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetIsClickable, methodSetIsClickableParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodSetIsClickable, methodSetIsClickableParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodSetIsClickable, parametersOfSetIsClickable, methodSetIsClickableParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetIsClickable.ShouldNotBeNull();
            parametersOfSetIsClickable.Length.ShouldBe(3);
            methodSetIsClickableParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodSetIsClickable, parametersOfSetIsClickable, methodSetIsClickableParametersTypes));
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var HyperLink = this.CreateType<string>();
            var LinkColumnName = this.CreateType<string>();
            var EntityObject = this.CreateType<object>();
            var methodSetIsClickableParametersTypes = new Type[] { typeof(String), typeof(String), typeof(object) };
            object[] parametersOfSetIsClickable = { HyperLink, LinkColumnName, EntityObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetIsClickable, methodSetIsClickableParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetIsClickable);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetIsClickable.ShouldNotBeNull();
            parametersOfSetIsClickable.Length.ShouldBe(3);
            methodSetIsClickableParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var HyperLink = this.CreateType<string>();
            var LinkColumnName = this.CreateType<string>();
            var EntityObject = this.CreateType<object>();
            var methodSetIsClickableParametersTypes = new Type[] { typeof(String), typeof(String), typeof(object) };
            object[] parametersOfSetIsClickable = { HyperLink, LinkColumnName, EntityObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetIsClickable, parametersOfSetIsClickable, methodSetIsClickableParametersTypes);

            // Assert
            parametersOfSetIsClickable.ShouldNotBeNull();
            parametersOfSetIsClickable.Length.ShouldBe(3);
            methodSetIsClickableParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var methodSetIsClickableParametersTypes = new Type[] { typeof(String), typeof(String), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetIsClickable, methodSetIsClickableParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetIsClickableParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var methodSetIsClickableParametersTypes = new Type[] { typeof(String), typeof(String), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetIsClickable, methodSetIsClickableParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetIsClickableParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var methodSetIsClickableParametersTypes = new Type[] { typeof(String), typeof(String), typeof(object) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetIsClickable, methodSetIsClickableParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetIsClickableParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var currentMethodInfo = this.GetMethodInfo(MethodSetIsClickable, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetIsClickable) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_SetIsClickable_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetIsClickable);
            var currentMethodInfo = this.GetMethodInfo(MethodSetIsClickable, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetAttributeValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetAttributeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAttributeValue, methodGetAttributeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var xAttribute = this.CreateType<XAttribute>();

            // Act
            Action executeAction = () => xmlToObject.GetAttributeValue(xAttribute);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var xAttribute = this.CreateType<XAttribute>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetAttributeValue(xAttribute);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var xAttribute = this.CreateType<XAttribute>();
            var methodGetAttributeValueParametersTypes = new Type[] { typeof(XAttribute) };
            object[] parametersOfGetAttributeValue = { xAttribute };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAttributeValue, methodGetAttributeValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetAttributeValue, methodGetAttributeValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetAttributeValue, parametersOfGetAttributeValue, methodGetAttributeValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetAttributeValue.ShouldNotBeNull();
            parametersOfGetAttributeValue.Length.ShouldBe(1);
            methodGetAttributeValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetAttributeValue, parametersOfGetAttributeValue, methodGetAttributeValueParametersTypes));
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var xAttribute = this.CreateType<XAttribute>();
            var methodGetAttributeValueParametersTypes = new Type[] { typeof(XAttribute) };
            object[] parametersOfGetAttributeValue = { xAttribute };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAttributeValue, methodGetAttributeValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetAttributeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetAttributeValue.ShouldNotBeNull();
            parametersOfGetAttributeValue.Length.ShouldBe(1);
            methodGetAttributeValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var xAttribute = this.CreateType<XAttribute>();
            var methodGetAttributeValueParametersTypes = new Type[] { typeof(XAttribute) };
            object[] parametersOfGetAttributeValue = { xAttribute };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetAttributeValue, parametersOfGetAttributeValue, methodGetAttributeValueParametersTypes);

            // Assert
            parametersOfGetAttributeValue.ShouldNotBeNull();
            parametersOfGetAttributeValue.Length.ShouldBe(1);
            methodGetAttributeValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var methodGetAttributeValueParametersTypes = new Type[] { typeof(XAttribute) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAttributeValue, methodGetAttributeValueParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetAttributeValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var methodGetAttributeValueParametersTypes = new Type[] { typeof(XAttribute) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAttributeValue, methodGetAttributeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAttributeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAttributeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetAttributeValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetAttributeValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttributeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAttributeValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_GetDoMoreHeader_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetDoMoreHeaderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDoMoreHeader, methodGetDoMoreHeaderParametersTypes);
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDoMoreHeader_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreHeader);
            var sourceXml = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.GetDoMoreHeader(sourceXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDoMoreHeader_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreHeader);
            var sourceXml = this.CreateType<string>();
            var returnedValue = default(List<More>);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.GetDoMoreHeader(sourceXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDoMoreHeader_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreHeader);
            var sourceXml = this.CreateType<string>();
            var methodGetDoMoreHeaderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDoMoreHeader = { sourceXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreHeader, methodGetDoMoreHeaderParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetDoMoreHeader, methodGetDoMoreHeaderParametersTypes);
            var result2 = this.GetResultOfMethod<List<More>>(MethodGetDoMoreHeader, parametersOfGetDoMoreHeader, methodGetDoMoreHeaderParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetDoMoreHeader);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDoMoreHeader.ShouldNotBeNull();
            parametersOfGetDoMoreHeader.Length.ShouldBe(1);
            methodGetDoMoreHeaderParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDoMoreHeader_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreHeader);
            var sourceXml = this.CreateType<string>();
            var methodGetDoMoreHeaderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDoMoreHeader = { sourceXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<More>>(MethodGetDoMoreHeader, parametersOfGetDoMoreHeader, methodGetDoMoreHeaderParametersTypes);

            // Assert
            parametersOfGetDoMoreHeader.ShouldNotBeNull();
            parametersOfGetDoMoreHeader.Length.ShouldBe(1);
            methodGetDoMoreHeaderParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDoMoreHeader_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreHeader);
            var methodGetDoMoreHeaderParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDoMoreHeader, methodGetDoMoreHeaderParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDoMoreHeaderParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDoMoreHeader_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreHeader);
            var methodGetDoMoreHeaderParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDoMoreHeader, methodGetDoMoreHeaderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDoMoreHeaderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDoMoreHeader_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreHeader, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreHeader) (Return Type : List<More>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_GetDoMoreHeader_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreHeader, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlToObject_CreateEntityDataObject_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateEntityDataObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateEntityDataObject, methodCreateEntityDataObjectParametersTypes);
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_CreateEntityDataObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityDataObject);
            var dataElement = this.CreateType<XElement>();
            var className = this.CreateType<string>();
            var entityType = this.CreateType<string>();

            // Act
            Action executeAction = () => xmlToObject.CreateEntityDataObject(dataElement, className, entityType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_CreateEntityDataObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityDataObject);
            var dataElement = this.CreateType<XElement>();
            var className = this.CreateType<string>();
            var entityType = this.CreateType<string>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = xmlToObject.CreateEntityDataObject(dataElement, className, entityType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_CreateEntityDataObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityDataObject);
            var dataElement = this.CreateType<XElement>();
            var className = this.CreateType<string>();
            var entityType = this.CreateType<string>();
            var methodCreateEntityDataObjectParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string) };
            object[] parametersOfCreateEntityDataObject = { dataElement, className, entityType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateEntityDataObject, methodCreateEntityDataObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateEntityDataObject, methodCreateEntityDataObjectParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodCreateEntityDataObject, parametersOfCreateEntityDataObject, methodCreateEntityDataObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCreateEntityDataObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateEntityDataObject.ShouldNotBeNull();
            parametersOfCreateEntityDataObject.Length.ShouldBe(3);
            methodCreateEntityDataObjectParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_CreateEntityDataObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityDataObject);
            var dataElement = this.CreateType<XElement>();
            var className = this.CreateType<string>();
            var entityType = this.CreateType<string>();
            var methodCreateEntityDataObjectParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string) };
            object[] parametersOfCreateEntityDataObject = { dataElement, className, entityType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodCreateEntityDataObject, parametersOfCreateEntityDataObject, methodCreateEntityDataObjectParametersTypes);

            // Assert
            parametersOfCreateEntityDataObject.ShouldNotBeNull();
            parametersOfCreateEntityDataObject.Length.ShouldBe(3);
            methodCreateEntityDataObjectParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_CreateEntityDataObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityDataObject);
            var methodCreateEntityDataObjectParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateEntityDataObject, methodCreateEntityDataObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateEntityDataObjectParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_CreateEntityDataObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityDataObject);
            var methodCreateEntityDataObjectParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateEntityDataObject, methodCreateEntityDataObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateEntityDataObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_CreateEntityDataObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityDataObject);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateEntityDataObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateEntityDataObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlToObject_CreateEntityDataObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateEntityDataObject);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateEntityDataObject, 0);
            const int parametersCount = 3;

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