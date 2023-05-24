using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.DomainData" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DomainDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DomainData" />)
        /// </summary>
        public DomainDataTest() : base(typeof(DomainData))
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

        #region General Initializer : Class (DomainData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _domainDataInstanceType;
        private DomainData _domainDataInstance;
        private DomainData _domainDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DomainData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _domainDataInstanceType = typeof(DomainData);
            _domainDataInstanceFixture = this.Create<DomainData>(false);
            _domainDataInstance = _domainDataInstanceFixture ?? this.Create<DomainData>(true);
            CurrentInstance = _domainDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DomainData) Initializer

        #region Methods

        private const string MethodGetCountryDomainData = "GetCountryDomainData";
        private const string MethodGetCountryMaskDetails = "GetCountryMaskDetails";
        private const string MethodGetStateDomainData = "GetStateDomainData";
        private const string MethodGetResolveUsers = "GetResolveUsers";
        private const string MethodGetIndividualTypeDomainData = "GetIndividualTypeDomainData";
        private const string MethodGetIndividualSubTypeDomainData = "GetIndividualSubTypeDomainData";
        private const string MethodGetCompanyTypeDomainData = "GetCompanyTypeDomainData";
        private const string MethodGetCompanySubTypeDomainData = "GetCompanySubTypeDomainData";
        private const string MethodGetCompanySourceDomainData = "GetCompanySourceDomainData";
        private const string MethodGetCompanyStatusDomainData = "GetCompanyStatusDomainData";
        private const string MethodGetCompanySICCodeDomainData = "GetCompanySICCodeDomainData";
        private const string MethodGetCompanyMarketSectorDomainData = "GetCompanyMarketSectorDomainData";
        private const string MethodGetIndividualTitleCodeDomainData = "GetIndividualTitleCodeDomainData";
        private const string MethodGetIndividualDepartmentCodeDomainData = "GetIndividualDepartmentCodeDomainData";
        private const string MethodGetIndividualSourceDomainData = "GetIndividualSourceDomainData";
        private const string MethodGetIndividualStatusDomainData = "GetIndividualStatusDomainData";
        private const string MethodGetIncidentTypeDomainData = "GetIncidentTypeDomainData";
        private const string MethodGetIncidentProductDomainData = "GetIncidentProductDomainData";
        private const string MethodGetIncidentStatusDomainData = "GetIncidentStatusDomainData";
        private const string MethodGetIncidentPriorityDomainData = "GetIncidentPriorityDomainData";
        private const string MethodGetIncidentSourceDomainData = "GetIncidentSourceDomainData";
        private const string MethodGetIncidentCategoryDomainData = "GetIncidentCategoryDomainData";
        private const string MethodGetIncidentResolutionCode1DomainData = "GetIncidentResolutionCode1DomainData";
        private const string MethodGetIncidentResolutionCode2DomainData = "GetIncidentResolutionCode2DomainData";
        private const string MethodGetIncidentResolutionCode3DomainData = "GetIncidentResolutionCode3DomainData";
        private const string MethodGetIncidentResolutionCode4DomainData = "GetIncidentResolutionCode4DomainData";
        private const string MethodGetWorkticketTypeDomainData = "GetWorkticketTypeDomainData";
        private const string MethodGetWorkticketStatusDomainData = "GetWorkticketStatusDomainData";
        private const string MethodGetWorkticketPriorityDomainData = "GetWorkticketPriorityDomainData";
        private const string MethodGetWorkticketSeverityDomainData = "GetWorkticketSeverityDomainData";
        private const string MethodGetWorkticketSourceDomainData = "GetWorkticketSourceDomainData";
        private const string MethodGetWorkticketResolutionCode1DomainData = "GetWorkticketResolutionCode1DomainData";
        private const string MethodGetWorkticketResolutionCode2DomainData = "GetWorkticketResolutionCode2DomainData";
        private const string MethodGetWorkticketResolutionCode3DomainData = "GetWorkticketResolutionCode3DomainData";
        private const string MethodGetWorkticketResolutionCode4DomainData = "GetWorkticketResolutionCode4DomainData";
        private const string MethodGetEmailSentDomainData = "GetEmailSentDomainData";
        private const string MethodGetTaskTypeDomainData = "GetTaskTypeDomainData";
        private const string MethodGetTaskStatusDomainData = "GetTaskStatusDomainData";
        private const string MethodGetTaskPriorityDomainData = "GetTaskPriorityDomainData";
        private const string MethodGetTaskCategoryDomainData = "GetTaskCategoryDomainData";
        private const string MethodGetForecastStatusDomainData = "GetForecastStatusDomainData";
        private const string MethodGetForecastProbabilityDomainData = "GetForecastProbabilityDomainData";
        private const string MethodGetProductStatusDomainData = "GetProductStatusDomainData";
        private const string MethodGetDateOperatorDomainData = "GetDateOperatorDomainData";
        private const string MethodGetOperatorDomainData = "GetOperatorDomainData";
        private const string MethodGetXml = "GetXml";
        private const string MethodGetReferenceDomainData = "GetReferenceDomainData";
        private const string MethodGetRegion = "GetRegion";
        private const string MethodGetReferenceLookUp = "GetReferenceLookUp";
        private const string MethodGetReferenceParameter = "GetReferenceParameter";
        private const string MethodGetReferenceField = "GetReferenceField";
        private const string MethodGetCampaigns = "GetCampaigns";
        private const string MethodGetGroups = "GetGroups";
        private const string MethodGetUsers = "GetUsers";
        private const string MethodGetUserTreeForMobile = "GetUserTreeForMobile";
        private const string MethodGetUsersAndGroups = "GetUsersAndGroups";
        private const string MethodGetKeywords = "GetKeywords";
        private const string MethodGetProductGroups = "GetProductGroups";
        private const string MethodGetProducts = "GetProducts";
        private const string MethodGetScripts = "GetScripts";
        private const string MethodGetTrackingCodes = "GetTrackingCodes";
        private const string MethodGetTrackingCodeTypes = "GetTrackingCodeTypes";
        private const string MethodGetResourcePermission = "GetResourcePermission";
        private const string MethodGetCountries = "GetCountries";
        private const string MethodGetCompanyFamily = "GetCompanyFamily";
        private const string MethodGetRecentKeywords = "GetRecentKeywords";
        private const string MethodGetCustomCache = "GetCustomCache";
        private const string MethodGetResultActionGroup = "GetResultActionGroup";
        private const string MethodGetResultActionItem = "GetResultActionItem";
        private const string MethodconvertGroupNodesToAttribute = "convertGroupNodesToAttribute";
        private const string MethodconvertUserNodesToAttribute = "convertUserNodesToAttribute";
        private const string MethodResolveUsers = "ResolveUsers";
        private const string MethodUpdateGroupName = "UpdateGroupName";
        private const string MethodConvertNodesToAttribute = "ConvertNodesToAttribute";
        private const string MethodGetCountryDesc = "GetCountryDesc";
        private const string MethodGetRegionName = "GetRegionName";
        private const string MethodGetParameterDesc = "GetParameterDesc";
        private const string MethodGetDescriptionById = "GetDescriptionById";
        private const string MethodGetUserById = "GetUserById";
        private const string MethodGetContactTypeById = "GetContactTypeById";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";
        private const string FieldoedbEntities = "oedbEntities";

        #endregion

        #endregion

        #region General Initializer : Class (DomainData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DomainData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DomainData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DomainData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DomainData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DomainData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DomainData)

        #region General Initializer : Class (DomainData) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DomainData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCountryDomainData, 0)]
        [TestCase(MethodGetCountryMaskDetails, 0)]
        [TestCase(MethodGetStateDomainData, 0)]
        [TestCase(MethodGetResolveUsers, 0)]
        [TestCase(MethodGetIndividualTypeDomainData, 0)]
        [TestCase(MethodGetIndividualSubTypeDomainData, 0)]
        [TestCase(MethodGetCompanyTypeDomainData, 0)]
        [TestCase(MethodGetCompanySubTypeDomainData, 0)]
        [TestCase(MethodGetCompanySourceDomainData, 0)]
        [TestCase(MethodGetCompanyStatusDomainData, 0)]
        [TestCase(MethodGetCompanySICCodeDomainData, 0)]
        [TestCase(MethodGetCompanyMarketSectorDomainData, 0)]
        [TestCase(MethodGetIndividualTitleCodeDomainData, 0)]
        [TestCase(MethodGetIndividualDepartmentCodeDomainData, 0)]
        [TestCase(MethodGetIndividualSourceDomainData, 0)]
        [TestCase(MethodGetIndividualStatusDomainData, 0)]
        [TestCase(MethodGetIncidentTypeDomainData, 0)]
        [TestCase(MethodGetIncidentProductDomainData, 0)]
        [TestCase(MethodGetIncidentStatusDomainData, 0)]
        [TestCase(MethodGetIncidentPriorityDomainData, 0)]
        [TestCase(MethodGetIncidentSourceDomainData, 0)]
        [TestCase(MethodGetIncidentCategoryDomainData, 0)]
        [TestCase(MethodGetIncidentResolutionCode1DomainData, 0)]
        [TestCase(MethodGetIncidentResolutionCode2DomainData, 0)]
        [TestCase(MethodGetIncidentResolutionCode3DomainData, 0)]
        [TestCase(MethodGetIncidentResolutionCode4DomainData, 0)]
        [TestCase(MethodGetWorkticketTypeDomainData, 0)]
        [TestCase(MethodGetWorkticketStatusDomainData, 0)]
        [TestCase(MethodGetWorkticketPriorityDomainData, 0)]
        [TestCase(MethodGetWorkticketSeverityDomainData, 0)]
        [TestCase(MethodGetWorkticketSourceDomainData, 0)]
        [TestCase(MethodGetWorkticketResolutionCode1DomainData, 0)]
        [TestCase(MethodGetWorkticketResolutionCode2DomainData, 0)]
        [TestCase(MethodGetWorkticketResolutionCode3DomainData, 0)]
        [TestCase(MethodGetWorkticketResolutionCode4DomainData, 0)]
        [TestCase(MethodGetEmailSentDomainData, 0)]
        [TestCase(MethodGetTaskTypeDomainData, 0)]
        [TestCase(MethodGetTaskStatusDomainData, 0)]
        [TestCase(MethodGetTaskPriorityDomainData, 0)]
        [TestCase(MethodGetTaskCategoryDomainData, 0)]
        [TestCase(MethodGetForecastStatusDomainData, 0)]
        [TestCase(MethodGetForecastProbabilityDomainData, 0)]
        [TestCase(MethodGetProductStatusDomainData, 0)]
        [TestCase(MethodGetDateOperatorDomainData, 0)]
        [TestCase(MethodGetOperatorDomainData, 0)]
        [TestCase(MethodGetXml, 0)]
        [TestCase(MethodGetXml, 1)]
        [TestCase(MethodGetXml, 2)]
        [TestCase(MethodGetReferenceDomainData, 0)]
        [TestCase(MethodGetXml, 3)]
        [TestCase(MethodGetRegion, 0)]
        [TestCase(MethodGetReferenceLookUp, 0)]
        [TestCase(MethodGetReferenceParameter, 0)]
        [TestCase(MethodGetReferenceField, 0)]
        [TestCase(MethodGetCampaigns, 0)]
        [TestCase(MethodGetGroups, 0)]
        [TestCase(MethodGetUsers, 0)]
        [TestCase(MethodGetUserTreeForMobile, 0)]
        [TestCase(MethodGetUsersAndGroups, 0)]
        [TestCase(MethodGetKeywords, 0)]
        [TestCase(MethodGetProductGroups, 0)]
        [TestCase(MethodGetProducts, 0)]
        [TestCase(MethodGetScripts, 0)]
        [TestCase(MethodGetTrackingCodes, 0)]
        [TestCase(MethodGetTrackingCodeTypes, 0)]
        [TestCase(MethodGetResourcePermission, 0)]
        [TestCase(MethodGetCountries, 0)]
        [TestCase(MethodGetCompanyFamily, 0)]
        [TestCase(MethodGetRecentKeywords, 0)]
        [TestCase(MethodGetCustomCache, 0)]
        [TestCase(MethodGetResultActionGroup, 0)]
        [TestCase(MethodGetResultActionItem, 0)]
        [TestCase(MethodconvertGroupNodesToAttribute, 0)]
        [TestCase(MethodconvertUserNodesToAttribute, 0)]
        [TestCase(MethodGetGroups, 1)]
        [TestCase(MethodGetUsers, 1)]
        [TestCase(MethodResolveUsers, 0)]
        [TestCase(MethodUpdateGroupName, 0)]
        [TestCase(MethodConvertNodesToAttribute, 0)]
        [TestCase(MethodGetCountryDesc, 0)]
        [TestCase(MethodGetRegionName, 0)]
        [TestCase(MethodGetParameterDesc, 0)]
        [TestCase(MethodGetDescriptionById, 0)]
        [TestCase(MethodGetUserById, 0)]
        [TestCase(MethodGetContactTypeById, 0)]
        public void AUT_DomainData_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DomainData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DomainData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [TestCase(FieldoedbEntities)]
        [Category("AUT Fields")]
        public void AUT_DomainData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DomainData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DomainData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DomainData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _domainDataInstance.ShouldBeAssignableTo<DomainData>();
            _domainDataInstanceFixture.ShouldBeAssignableTo<DomainData>();
            CurrentInstance.ShouldBeAssignableTo<DomainData>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetCountryDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetCountryDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCountryDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCountryDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountryDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDomainData);
            Type [] methodGetCountryDomainDataParametersTypes = null;
            object[] parametersOfGetCountryDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryDomainData, methodGetCountryDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCountryDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetCountryDomainData, parametersOfGetCountryDomainData, methodGetCountryDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCountryDomainData.ShouldBeNull();
            methodGetCountryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountryDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDomainData);
            Type [] methodGetCountryDomainDataParametersTypes = null;
            object[] parametersOfGetCountryDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCountryDomainData, parametersOfGetCountryDomainData, methodGetCountryDomainDataParametersTypes);

            // Assert
            parametersOfGetCountryDomainData.ShouldBeNull();
            methodGetCountryDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountryDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDomainData);
            Type [] methodGetCountryDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountryDomainData, methodGetCountryDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCountryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountryDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDomainData);
            Type [] methodGetCountryDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCountryDomainData, methodGetCountryDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCountryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountryDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCountryMaskDetails_Method_Call_Internally(Type[] types)
        {
            var methodGetCountryMaskDetailsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCountryMaskDetails, methodGetCountryMaskDetailsParametersTypes);
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryMaskDetails_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryMaskDetails);
            var countryCode = this.CreateType<string>();

            // Act
            Action executeAction = () => _domainDataInstance.GetCountryMaskDetails(countryCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryMaskDetails_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryMaskDetails);
            var countryCode = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCountryMaskDetails(countryCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryMaskDetails_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryMaskDetails);
            var countryCode = this.CreateType<string>();
            var methodGetCountryMaskDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCountryMaskDetails = { countryCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryMaskDetails, methodGetCountryMaskDetailsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCountryMaskDetails);
            var result2 = this.GetResultOfMethod<string>(MethodGetCountryMaskDetails, parametersOfGetCountryMaskDetails, methodGetCountryMaskDetailsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCountryMaskDetails.ShouldNotBeNull();
            parametersOfGetCountryMaskDetails.Length.ShouldBe(1);
            methodGetCountryMaskDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryMaskDetails_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryMaskDetails);
            var countryCode = this.CreateType<string>();
            var methodGetCountryMaskDetailsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCountryMaskDetails = { countryCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCountryMaskDetails, parametersOfGetCountryMaskDetails, methodGetCountryMaskDetailsParametersTypes);

            // Assert
            parametersOfGetCountryMaskDetails.ShouldNotBeNull();
            parametersOfGetCountryMaskDetails.Length.ShouldBe(1);
            methodGetCountryMaskDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryMaskDetails_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryMaskDetails);
            var methodGetCountryMaskDetailsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountryMaskDetails, methodGetCountryMaskDetailsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCountryMaskDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryMaskDetails_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryMaskDetails);
            var methodGetCountryMaskDetailsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCountryMaskDetails, methodGetCountryMaskDetailsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCountryMaskDetailsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryMaskDetails_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryMaskDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryMaskDetails, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountryMaskDetails) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryMaskDetails_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryMaskDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryMaskDetails, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetStateDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetStateDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetStateDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetStateDomainData, methodGetStateDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetStateDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetStateDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStateDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetStateDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetStateDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetStateDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStateDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetStateDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetStateDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetStateDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStateDomainData);
            Type [] methodGetStateDomainDataParametersTypes = null;
            object[] parametersOfGetStateDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetStateDomainData, methodGetStateDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetStateDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetStateDomainData, parametersOfGetStateDomainData, methodGetStateDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetStateDomainData.ShouldBeNull();
            methodGetStateDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetStateDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetStateDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStateDomainData);
            Type [] methodGetStateDomainDataParametersTypes = null;
            object[] parametersOfGetStateDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetStateDomainData, parametersOfGetStateDomainData, methodGetStateDomainDataParametersTypes);

            // Assert
            parametersOfGetStateDomainData.ShouldBeNull();
            methodGetStateDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetStateDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetStateDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStateDomainData);
            Type [] methodGetStateDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetStateDomainData, methodGetStateDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetStateDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetStateDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetStateDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStateDomainData);
            Type [] methodGetStateDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetStateDomainData, methodGetStateDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetStateDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetStateDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetStateDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStateDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetStateDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResolveUsers) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetResolveUsers_Method_Call_Internally(Type[] types)
        {
            var methodGetResolveUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResolveUsers, methodGetResolveUsersParametersTypes);
        }

        #endregion

        #region Method Call : (GetResolveUsers) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResolveUsers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolveUsers);

            // Act
            Action executeAction = () => _domainDataInstance.GetResolveUsers();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResolveUsers) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResolveUsers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolveUsers);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetResolveUsers();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResolveUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResolveUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolveUsers);
            Type [] methodGetResolveUsersParametersTypes = null;
            object[] parametersOfGetResolveUsers = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResolveUsers, methodGetResolveUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetResolveUsers);
            var result2 = this.GetResultOfMethod<string>(MethodGetResolveUsers, parametersOfGetResolveUsers, methodGetResolveUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResolveUsers.ShouldBeNull();
            methodGetResolveUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResolveUsers) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResolveUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolveUsers);
            Type [] methodGetResolveUsersParametersTypes = null;
            object[] parametersOfGetResolveUsers = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetResolveUsers, parametersOfGetResolveUsers, methodGetResolveUsersParametersTypes);

            // Assert
            parametersOfGetResolveUsers.ShouldBeNull();
            methodGetResolveUsersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResolveUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResolveUsers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolveUsers);
            Type [] methodGetResolveUsersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResolveUsers, methodGetResolveUsersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResolveUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResolveUsers) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResolveUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolveUsers);
            Type [] methodGetResolveUsersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResolveUsers, methodGetResolveUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResolveUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResolveUsers) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResolveUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolveUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResolveUsers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTypeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIndividualTypeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualTypeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualTypeDomainData, methodGetIndividualTypeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualTypeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTypeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTypeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIndividualTypeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualTypeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTypeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTypeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIndividualTypeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTypeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTypeDomainData);
            Type [] methodGetIndividualTypeDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualTypeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualTypeDomainData, methodGetIndividualTypeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIndividualTypeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualTypeDomainData, parametersOfGetIndividualTypeDomainData, methodGetIndividualTypeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualTypeDomainData.ShouldBeNull();
            methodGetIndividualTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTypeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTypeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTypeDomainData);
            Type [] methodGetIndividualTypeDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualTypeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualTypeDomainData, parametersOfGetIndividualTypeDomainData, methodGetIndividualTypeDomainDataParametersTypes);

            // Assert
            parametersOfGetIndividualTypeDomainData.ShouldBeNull();
            methodGetIndividualTypeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTypeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTypeDomainData);
            Type [] methodGetIndividualTypeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualTypeDomainData, methodGetIndividualTypeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTypeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTypeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTypeDomainData);
            Type [] methodGetIndividualTypeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualTypeDomainData, methodGetIndividualTypeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTypeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTypeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTypeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualTypeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSubTypeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIndividualSubTypeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualSubTypeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualSubTypeDomainData, methodGetIndividualSubTypeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualSubTypeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSubTypeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSubTypeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIndividualSubTypeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualSubTypeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSubTypeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSubTypeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIndividualSubTypeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSubTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSubTypeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSubTypeDomainData);
            Type [] methodGetIndividualSubTypeDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualSubTypeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualSubTypeDomainData, methodGetIndividualSubTypeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIndividualSubTypeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualSubTypeDomainData, parametersOfGetIndividualSubTypeDomainData, methodGetIndividualSubTypeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualSubTypeDomainData.ShouldBeNull();
            methodGetIndividualSubTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSubTypeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSubTypeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSubTypeDomainData);
            Type [] methodGetIndividualSubTypeDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualSubTypeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualSubTypeDomainData, parametersOfGetIndividualSubTypeDomainData, methodGetIndividualSubTypeDomainDataParametersTypes);

            // Assert
            parametersOfGetIndividualSubTypeDomainData.ShouldBeNull();
            methodGetIndividualSubTypeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualSubTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSubTypeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSubTypeDomainData);
            Type [] methodGetIndividualSubTypeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualSubTypeDomainData, methodGetIndividualSubTypeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualSubTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSubTypeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSubTypeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSubTypeDomainData);
            Type [] methodGetIndividualSubTypeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualSubTypeDomainData, methodGetIndividualSubTypeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualSubTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSubTypeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSubTypeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSubTypeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualSubTypeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyTypeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCompanyTypeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetCompanyTypeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCompanyTypeDomainData, methodGetCompanyTypeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetCompanyTypeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyTypeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyTypeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetCompanyTypeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCompanyTypeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyTypeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyTypeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCompanyTypeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyTypeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyTypeDomainData);
            Type [] methodGetCompanyTypeDomainDataParametersTypes = null;
            object[] parametersOfGetCompanyTypeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanyTypeDomainData, methodGetCompanyTypeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCompanyTypeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetCompanyTypeDomainData, parametersOfGetCompanyTypeDomainData, methodGetCompanyTypeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCompanyTypeDomainData.ShouldBeNull();
            methodGetCompanyTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyTypeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyTypeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyTypeDomainData);
            Type [] methodGetCompanyTypeDomainDataParametersTypes = null;
            object[] parametersOfGetCompanyTypeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCompanyTypeDomainData, parametersOfGetCompanyTypeDomainData, methodGetCompanyTypeDomainDataParametersTypes);

            // Assert
            parametersOfGetCompanyTypeDomainData.ShouldBeNull();
            methodGetCompanyTypeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCompanyTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyTypeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyTypeDomainData);
            Type [] methodGetCompanyTypeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCompanyTypeDomainData, methodGetCompanyTypeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCompanyTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyTypeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyTypeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyTypeDomainData);
            Type [] methodGetCompanyTypeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCompanyTypeDomainData, methodGetCompanyTypeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCompanyTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyTypeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyTypeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyTypeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanyTypeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySubTypeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCompanySubTypeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetCompanySubTypeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCompanySubTypeDomainData, methodGetCompanySubTypeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetCompanySubTypeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySubTypeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySubTypeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetCompanySubTypeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCompanySubTypeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySubTypeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySubTypeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCompanySubTypeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySubTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySubTypeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySubTypeDomainData);
            Type [] methodGetCompanySubTypeDomainDataParametersTypes = null;
            object[] parametersOfGetCompanySubTypeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanySubTypeDomainData, methodGetCompanySubTypeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCompanySubTypeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetCompanySubTypeDomainData, parametersOfGetCompanySubTypeDomainData, methodGetCompanySubTypeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCompanySubTypeDomainData.ShouldBeNull();
            methodGetCompanySubTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySubTypeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySubTypeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySubTypeDomainData);
            Type [] methodGetCompanySubTypeDomainDataParametersTypes = null;
            object[] parametersOfGetCompanySubTypeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCompanySubTypeDomainData, parametersOfGetCompanySubTypeDomainData, methodGetCompanySubTypeDomainDataParametersTypes);

            // Assert
            parametersOfGetCompanySubTypeDomainData.ShouldBeNull();
            methodGetCompanySubTypeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCompanySubTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySubTypeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySubTypeDomainData);
            Type [] methodGetCompanySubTypeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCompanySubTypeDomainData, methodGetCompanySubTypeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCompanySubTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySubTypeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySubTypeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySubTypeDomainData);
            Type [] methodGetCompanySubTypeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCompanySubTypeDomainData, methodGetCompanySubTypeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCompanySubTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySubTypeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySubTypeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySubTypeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanySubTypeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySourceDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCompanySourceDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetCompanySourceDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCompanySourceDomainData, methodGetCompanySourceDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetCompanySourceDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySourceDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySourceDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetCompanySourceDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCompanySourceDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySourceDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySourceDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCompanySourceDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySourceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySourceDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySourceDomainData);
            Type [] methodGetCompanySourceDomainDataParametersTypes = null;
            object[] parametersOfGetCompanySourceDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanySourceDomainData, methodGetCompanySourceDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCompanySourceDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetCompanySourceDomainData, parametersOfGetCompanySourceDomainData, methodGetCompanySourceDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCompanySourceDomainData.ShouldBeNull();
            methodGetCompanySourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySourceDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySourceDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySourceDomainData);
            Type [] methodGetCompanySourceDomainDataParametersTypes = null;
            object[] parametersOfGetCompanySourceDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCompanySourceDomainData, parametersOfGetCompanySourceDomainData, methodGetCompanySourceDomainDataParametersTypes);

            // Assert
            parametersOfGetCompanySourceDomainData.ShouldBeNull();
            methodGetCompanySourceDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCompanySourceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySourceDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySourceDomainData);
            Type [] methodGetCompanySourceDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCompanySourceDomainData, methodGetCompanySourceDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCompanySourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySourceDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySourceDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySourceDomainData);
            Type [] methodGetCompanySourceDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCompanySourceDomainData, methodGetCompanySourceDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCompanySourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySourceDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySourceDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySourceDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanySourceDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyStatusDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCompanyStatusDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetCompanyStatusDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCompanyStatusDomainData, methodGetCompanyStatusDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetCompanyStatusDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyStatusDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyStatusDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetCompanyStatusDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCompanyStatusDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyStatusDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyStatusDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCompanyStatusDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyStatusDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyStatusDomainData);
            Type [] methodGetCompanyStatusDomainDataParametersTypes = null;
            object[] parametersOfGetCompanyStatusDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanyStatusDomainData, methodGetCompanyStatusDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCompanyStatusDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetCompanyStatusDomainData, parametersOfGetCompanyStatusDomainData, methodGetCompanyStatusDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCompanyStatusDomainData.ShouldBeNull();
            methodGetCompanyStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyStatusDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyStatusDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyStatusDomainData);
            Type [] methodGetCompanyStatusDomainDataParametersTypes = null;
            object[] parametersOfGetCompanyStatusDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCompanyStatusDomainData, parametersOfGetCompanyStatusDomainData, methodGetCompanyStatusDomainDataParametersTypes);

            // Assert
            parametersOfGetCompanyStatusDomainData.ShouldBeNull();
            methodGetCompanyStatusDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCompanyStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyStatusDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyStatusDomainData);
            Type [] methodGetCompanyStatusDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCompanyStatusDomainData, methodGetCompanyStatusDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCompanyStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyStatusDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyStatusDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyStatusDomainData);
            Type [] methodGetCompanyStatusDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCompanyStatusDomainData, methodGetCompanyStatusDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCompanyStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyStatusDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyStatusDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyStatusDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanyStatusDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySICCodeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCompanySICCodeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetCompanySICCodeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCompanySICCodeDomainData, methodGetCompanySICCodeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetCompanySICCodeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySICCodeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySICCodeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetCompanySICCodeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCompanySICCodeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySICCodeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySICCodeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCompanySICCodeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySICCodeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySICCodeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySICCodeDomainData);
            Type [] methodGetCompanySICCodeDomainDataParametersTypes = null;
            object[] parametersOfGetCompanySICCodeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanySICCodeDomainData, methodGetCompanySICCodeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCompanySICCodeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetCompanySICCodeDomainData, parametersOfGetCompanySICCodeDomainData, methodGetCompanySICCodeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCompanySICCodeDomainData.ShouldBeNull();
            methodGetCompanySICCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySICCodeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySICCodeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySICCodeDomainData);
            Type [] methodGetCompanySICCodeDomainDataParametersTypes = null;
            object[] parametersOfGetCompanySICCodeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCompanySICCodeDomainData, parametersOfGetCompanySICCodeDomainData, methodGetCompanySICCodeDomainDataParametersTypes);

            // Assert
            parametersOfGetCompanySICCodeDomainData.ShouldBeNull();
            methodGetCompanySICCodeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCompanySICCodeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySICCodeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySICCodeDomainData);
            Type [] methodGetCompanySICCodeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCompanySICCodeDomainData, methodGetCompanySICCodeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCompanySICCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySICCodeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySICCodeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySICCodeDomainData);
            Type [] methodGetCompanySICCodeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCompanySICCodeDomainData, methodGetCompanySICCodeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCompanySICCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanySICCodeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanySICCodeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanySICCodeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanySICCodeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyMarketSectorDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCompanyMarketSectorDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetCompanyMarketSectorDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCompanyMarketSectorDomainData, methodGetCompanyMarketSectorDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetCompanyMarketSectorDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyMarketSectorDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyMarketSectorDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetCompanyMarketSectorDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCompanyMarketSectorDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyMarketSectorDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyMarketSectorDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCompanyMarketSectorDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyMarketSectorDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyMarketSectorDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyMarketSectorDomainData);
            Type [] methodGetCompanyMarketSectorDomainDataParametersTypes = null;
            object[] parametersOfGetCompanyMarketSectorDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanyMarketSectorDomainData, methodGetCompanyMarketSectorDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCompanyMarketSectorDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetCompanyMarketSectorDomainData, parametersOfGetCompanyMarketSectorDomainData, methodGetCompanyMarketSectorDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCompanyMarketSectorDomainData.ShouldBeNull();
            methodGetCompanyMarketSectorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyMarketSectorDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyMarketSectorDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyMarketSectorDomainData);
            Type [] methodGetCompanyMarketSectorDomainDataParametersTypes = null;
            object[] parametersOfGetCompanyMarketSectorDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCompanyMarketSectorDomainData, parametersOfGetCompanyMarketSectorDomainData, methodGetCompanyMarketSectorDomainDataParametersTypes);

            // Assert
            parametersOfGetCompanyMarketSectorDomainData.ShouldBeNull();
            methodGetCompanyMarketSectorDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCompanyMarketSectorDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyMarketSectorDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyMarketSectorDomainData);
            Type [] methodGetCompanyMarketSectorDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCompanyMarketSectorDomainData, methodGetCompanyMarketSectorDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCompanyMarketSectorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyMarketSectorDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyMarketSectorDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyMarketSectorDomainData);
            Type [] methodGetCompanyMarketSectorDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCompanyMarketSectorDomainData, methodGetCompanyMarketSectorDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCompanyMarketSectorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyMarketSectorDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyMarketSectorDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyMarketSectorDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanyMarketSectorDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTitleCodeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIndividualTitleCodeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualTitleCodeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualTitleCodeDomainData, methodGetIndividualTitleCodeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualTitleCodeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTitleCodeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTitleCodeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIndividualTitleCodeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualTitleCodeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTitleCodeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTitleCodeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIndividualTitleCodeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTitleCodeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTitleCodeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTitleCodeDomainData);
            Type [] methodGetIndividualTitleCodeDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualTitleCodeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualTitleCodeDomainData, methodGetIndividualTitleCodeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIndividualTitleCodeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualTitleCodeDomainData, parametersOfGetIndividualTitleCodeDomainData, methodGetIndividualTitleCodeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualTitleCodeDomainData.ShouldBeNull();
            methodGetIndividualTitleCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTitleCodeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTitleCodeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTitleCodeDomainData);
            Type [] methodGetIndividualTitleCodeDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualTitleCodeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualTitleCodeDomainData, parametersOfGetIndividualTitleCodeDomainData, methodGetIndividualTitleCodeDomainDataParametersTypes);

            // Assert
            parametersOfGetIndividualTitleCodeDomainData.ShouldBeNull();
            methodGetIndividualTitleCodeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualTitleCodeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTitleCodeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTitleCodeDomainData);
            Type [] methodGetIndividualTitleCodeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualTitleCodeDomainData, methodGetIndividualTitleCodeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualTitleCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTitleCodeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTitleCodeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTitleCodeDomainData);
            Type [] methodGetIndividualTitleCodeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualTitleCodeDomainData, methodGetIndividualTitleCodeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualTitleCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualTitleCodeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualTitleCodeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualTitleCodeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualTitleCodeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualDepartmentCodeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIndividualDepartmentCodeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualDepartmentCodeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualDepartmentCodeDomainData, methodGetIndividualDepartmentCodeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualDepartmentCodeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualDepartmentCodeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualDepartmentCodeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIndividualDepartmentCodeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualDepartmentCodeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualDepartmentCodeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualDepartmentCodeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIndividualDepartmentCodeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualDepartmentCodeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualDepartmentCodeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualDepartmentCodeDomainData);
            Type [] methodGetIndividualDepartmentCodeDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualDepartmentCodeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualDepartmentCodeDomainData, methodGetIndividualDepartmentCodeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIndividualDepartmentCodeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualDepartmentCodeDomainData, parametersOfGetIndividualDepartmentCodeDomainData, methodGetIndividualDepartmentCodeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualDepartmentCodeDomainData.ShouldBeNull();
            methodGetIndividualDepartmentCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualDepartmentCodeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualDepartmentCodeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualDepartmentCodeDomainData);
            Type [] methodGetIndividualDepartmentCodeDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualDepartmentCodeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualDepartmentCodeDomainData, parametersOfGetIndividualDepartmentCodeDomainData, methodGetIndividualDepartmentCodeDomainDataParametersTypes);

            // Assert
            parametersOfGetIndividualDepartmentCodeDomainData.ShouldBeNull();
            methodGetIndividualDepartmentCodeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualDepartmentCodeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualDepartmentCodeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualDepartmentCodeDomainData);
            Type [] methodGetIndividualDepartmentCodeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualDepartmentCodeDomainData, methodGetIndividualDepartmentCodeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualDepartmentCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualDepartmentCodeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualDepartmentCodeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualDepartmentCodeDomainData);
            Type [] methodGetIndividualDepartmentCodeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualDepartmentCodeDomainData, methodGetIndividualDepartmentCodeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualDepartmentCodeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualDepartmentCodeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualDepartmentCodeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualDepartmentCodeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualDepartmentCodeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSourceDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIndividualSourceDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualSourceDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualSourceDomainData, methodGetIndividualSourceDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualSourceDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSourceDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSourceDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIndividualSourceDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualSourceDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSourceDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSourceDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIndividualSourceDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSourceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSourceDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSourceDomainData);
            Type [] methodGetIndividualSourceDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualSourceDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualSourceDomainData, methodGetIndividualSourceDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIndividualSourceDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualSourceDomainData, parametersOfGetIndividualSourceDomainData, methodGetIndividualSourceDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualSourceDomainData.ShouldBeNull();
            methodGetIndividualSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSourceDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSourceDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSourceDomainData);
            Type [] methodGetIndividualSourceDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualSourceDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualSourceDomainData, parametersOfGetIndividualSourceDomainData, methodGetIndividualSourceDomainDataParametersTypes);

            // Assert
            parametersOfGetIndividualSourceDomainData.ShouldBeNull();
            methodGetIndividualSourceDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualSourceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSourceDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSourceDomainData);
            Type [] methodGetIndividualSourceDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualSourceDomainData, methodGetIndividualSourceDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSourceDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSourceDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSourceDomainData);
            Type [] methodGetIndividualSourceDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualSourceDomainData, methodGetIndividualSourceDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualSourceDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualSourceDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualSourceDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualSourceDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualStatusDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIndividualStatusDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIndividualStatusDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIndividualStatusDomainData, methodGetIndividualStatusDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIndividualStatusDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualStatusDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualStatusDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIndividualStatusDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIndividualStatusDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualStatusDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualStatusDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIndividualStatusDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualStatusDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualStatusDomainData);
            Type [] methodGetIndividualStatusDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualStatusDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualStatusDomainData, methodGetIndividualStatusDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIndividualStatusDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIndividualStatusDomainData, parametersOfGetIndividualStatusDomainData, methodGetIndividualStatusDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIndividualStatusDomainData.ShouldBeNull();
            methodGetIndividualStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualStatusDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualStatusDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualStatusDomainData);
            Type [] methodGetIndividualStatusDomainDataParametersTypes = null;
            object[] parametersOfGetIndividualStatusDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIndividualStatusDomainData, parametersOfGetIndividualStatusDomainData, methodGetIndividualStatusDomainDataParametersTypes);

            // Assert
            parametersOfGetIndividualStatusDomainData.ShouldBeNull();
            methodGetIndividualStatusDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIndividualStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualStatusDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualStatusDomainData);
            Type [] methodGetIndividualStatusDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIndividualStatusDomainData, methodGetIndividualStatusDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIndividualStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualStatusDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualStatusDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualStatusDomainData);
            Type [] methodGetIndividualStatusDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIndividualStatusDomainData, methodGetIndividualStatusDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIndividualStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIndividualStatusDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIndividualStatusDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIndividualStatusDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIndividualStatusDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentTypeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentTypeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentTypeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentTypeDomainData, methodGetIncidentTypeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentTypeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentTypeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentTypeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentTypeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentTypeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentTypeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentTypeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentTypeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentTypeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentTypeDomainData);
            Type [] methodGetIncidentTypeDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentTypeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentTypeDomainData, methodGetIncidentTypeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentTypeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentTypeDomainData, parametersOfGetIncidentTypeDomainData, methodGetIncidentTypeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentTypeDomainData.ShouldBeNull();
            methodGetIncidentTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentTypeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentTypeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentTypeDomainData);
            Type [] methodGetIncidentTypeDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentTypeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentTypeDomainData, parametersOfGetIncidentTypeDomainData, methodGetIncidentTypeDomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentTypeDomainData.ShouldBeNull();
            methodGetIncidentTypeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentTypeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentTypeDomainData);
            Type [] methodGetIncidentTypeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentTypeDomainData, methodGetIncidentTypeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentTypeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentTypeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentTypeDomainData);
            Type [] methodGetIncidentTypeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentTypeDomainData, methodGetIncidentTypeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentTypeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentTypeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentTypeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentTypeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentProductDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentProductDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductDomainData, methodGetIncidentProductDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentProductDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentProductDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentProductDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentProductDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentProductDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentProductDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentProductDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDomainData);
            Type [] methodGetIncidentProductDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentProductDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProductDomainData, methodGetIncidentProductDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentProductDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentProductDomainData, parametersOfGetIncidentProductDomainData, methodGetIncidentProductDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentProductDomainData.ShouldBeNull();
            methodGetIncidentProductDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentProductDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDomainData);
            Type [] methodGetIncidentProductDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentProductDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentProductDomainData, parametersOfGetIncidentProductDomainData, methodGetIncidentProductDomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentProductDomainData.ShouldBeNull();
            methodGetIncidentProductDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentProductDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentProductDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDomainData);
            Type [] methodGetIncidentProductDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductDomainData, methodGetIncidentProductDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentProductDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentProductDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDomainData);
            Type [] methodGetIncidentProductDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductDomainData, methodGetIncidentProductDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentProductDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentProductDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProductDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentStatusDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentStatusDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentStatusDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentStatusDomainData, methodGetIncidentStatusDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentStatusDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentStatusDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentStatusDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentStatusDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentStatusDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentStatusDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentStatusDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentStatusDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentStatusDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentStatusDomainData);
            Type [] methodGetIncidentStatusDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentStatusDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentStatusDomainData, methodGetIncidentStatusDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentStatusDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentStatusDomainData, parametersOfGetIncidentStatusDomainData, methodGetIncidentStatusDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentStatusDomainData.ShouldBeNull();
            methodGetIncidentStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentStatusDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentStatusDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentStatusDomainData);
            Type [] methodGetIncidentStatusDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentStatusDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentStatusDomainData, parametersOfGetIncidentStatusDomainData, methodGetIncidentStatusDomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentStatusDomainData.ShouldBeNull();
            methodGetIncidentStatusDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentStatusDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentStatusDomainData);
            Type [] methodGetIncidentStatusDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentStatusDomainData, methodGetIncidentStatusDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentStatusDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentStatusDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentStatusDomainData);
            Type [] methodGetIncidentStatusDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentStatusDomainData, methodGetIncidentStatusDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentStatusDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentStatusDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentStatusDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentStatusDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentPriorityDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentPriorityDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentPriorityDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentPriorityDomainData, methodGetIncidentPriorityDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentPriorityDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentPriorityDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPriorityDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentPriorityDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentPriorityDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentPriorityDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPriorityDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentPriorityDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentPriorityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentPriorityDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPriorityDomainData);
            Type [] methodGetIncidentPriorityDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentPriorityDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentPriorityDomainData, methodGetIncidentPriorityDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentPriorityDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentPriorityDomainData, parametersOfGetIncidentPriorityDomainData, methodGetIncidentPriorityDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentPriorityDomainData.ShouldBeNull();
            methodGetIncidentPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentPriorityDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentPriorityDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPriorityDomainData);
            Type [] methodGetIncidentPriorityDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentPriorityDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentPriorityDomainData, parametersOfGetIncidentPriorityDomainData, methodGetIncidentPriorityDomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentPriorityDomainData.ShouldBeNull();
            methodGetIncidentPriorityDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentPriorityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentPriorityDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPriorityDomainData);
            Type [] methodGetIncidentPriorityDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentPriorityDomainData, methodGetIncidentPriorityDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentPriorityDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentPriorityDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPriorityDomainData);
            Type [] methodGetIncidentPriorityDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentPriorityDomainData, methodGetIncidentPriorityDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentPriorityDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentPriorityDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentPriorityDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentPriorityDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentSourceDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentSourceDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentSourceDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentSourceDomainData, methodGetIncidentSourceDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentSourceDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentSourceDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentSourceDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentSourceDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentSourceDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentSourceDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentSourceDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentSourceDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentSourceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentSourceDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentSourceDomainData);
            Type [] methodGetIncidentSourceDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentSourceDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentSourceDomainData, methodGetIncidentSourceDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentSourceDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentSourceDomainData, parametersOfGetIncidentSourceDomainData, methodGetIncidentSourceDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentSourceDomainData.ShouldBeNull();
            methodGetIncidentSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentSourceDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentSourceDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentSourceDomainData);
            Type [] methodGetIncidentSourceDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentSourceDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentSourceDomainData, parametersOfGetIncidentSourceDomainData, methodGetIncidentSourceDomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentSourceDomainData.ShouldBeNull();
            methodGetIncidentSourceDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentSourceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentSourceDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentSourceDomainData);
            Type [] methodGetIncidentSourceDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentSourceDomainData, methodGetIncidentSourceDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentSourceDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentSourceDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentSourceDomainData);
            Type [] methodGetIncidentSourceDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentSourceDomainData, methodGetIncidentSourceDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentSourceDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentSourceDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentSourceDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentSourceDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentCategoryDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentCategoryDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentCategoryDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentCategoryDomainData, methodGetIncidentCategoryDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentCategoryDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentCategoryDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentCategoryDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentCategoryDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentCategoryDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentCategoryDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentCategoryDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentCategoryDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentCategoryDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentCategoryDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentCategoryDomainData);
            Type [] methodGetIncidentCategoryDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentCategoryDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentCategoryDomainData, methodGetIncidentCategoryDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentCategoryDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentCategoryDomainData, parametersOfGetIncidentCategoryDomainData, methodGetIncidentCategoryDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentCategoryDomainData.ShouldBeNull();
            methodGetIncidentCategoryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentCategoryDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentCategoryDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentCategoryDomainData);
            Type [] methodGetIncidentCategoryDomainDataParametersTypes = null;
            object[] parametersOfGetIncidentCategoryDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentCategoryDomainData, parametersOfGetIncidentCategoryDomainData, methodGetIncidentCategoryDomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentCategoryDomainData.ShouldBeNull();
            methodGetIncidentCategoryDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentCategoryDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentCategoryDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentCategoryDomainData);
            Type [] methodGetIncidentCategoryDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentCategoryDomainData, methodGetIncidentCategoryDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentCategoryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentCategoryDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentCategoryDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentCategoryDomainData);
            Type [] methodGetIncidentCategoryDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentCategoryDomainData, methodGetIncidentCategoryDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentCategoryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentCategoryDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentCategoryDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentCategoryDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentCategoryDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode1DomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentResolutionCode1DomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentResolutionCode1DomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode1DomainData, methodGetIncidentResolutionCode1DomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode1DomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode1DomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode1DomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentResolutionCode1DomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode1DomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode1DomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode1DomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentResolutionCode1DomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode1DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode1DomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode1DomainData);
            Type [] methodGetIncidentResolutionCode1DomainDataParametersTypes = null;
            object[] parametersOfGetIncidentResolutionCode1DomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentResolutionCode1DomainData, methodGetIncidentResolutionCode1DomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentResolutionCode1DomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentResolutionCode1DomainData, parametersOfGetIncidentResolutionCode1DomainData, methodGetIncidentResolutionCode1DomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentResolutionCode1DomainData.ShouldBeNull();
            methodGetIncidentResolutionCode1DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode1DomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode1DomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode1DomainData);
            Type [] methodGetIncidentResolutionCode1DomainDataParametersTypes = null;
            object[] parametersOfGetIncidentResolutionCode1DomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentResolutionCode1DomainData, parametersOfGetIncidentResolutionCode1DomainData, methodGetIncidentResolutionCode1DomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentResolutionCode1DomainData.ShouldBeNull();
            methodGetIncidentResolutionCode1DomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode1DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode1DomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode1DomainData);
            Type [] methodGetIncidentResolutionCode1DomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode1DomainData, methodGetIncidentResolutionCode1DomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentResolutionCode1DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode1DomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode1DomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode1DomainData);
            Type [] methodGetIncidentResolutionCode1DomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode1DomainData, methodGetIncidentResolutionCode1DomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentResolutionCode1DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode1DomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode1DomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode1DomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentResolutionCode1DomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode2DomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentResolutionCode2DomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentResolutionCode2DomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode2DomainData, methodGetIncidentResolutionCode2DomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode2DomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode2DomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode2DomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentResolutionCode2DomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode2DomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode2DomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode2DomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentResolutionCode2DomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode2DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode2DomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode2DomainData);
            Type [] methodGetIncidentResolutionCode2DomainDataParametersTypes = null;
            object[] parametersOfGetIncidentResolutionCode2DomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentResolutionCode2DomainData, methodGetIncidentResolutionCode2DomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentResolutionCode2DomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentResolutionCode2DomainData, parametersOfGetIncidentResolutionCode2DomainData, methodGetIncidentResolutionCode2DomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentResolutionCode2DomainData.ShouldBeNull();
            methodGetIncidentResolutionCode2DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode2DomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode2DomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode2DomainData);
            Type [] methodGetIncidentResolutionCode2DomainDataParametersTypes = null;
            object[] parametersOfGetIncidentResolutionCode2DomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentResolutionCode2DomainData, parametersOfGetIncidentResolutionCode2DomainData, methodGetIncidentResolutionCode2DomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentResolutionCode2DomainData.ShouldBeNull();
            methodGetIncidentResolutionCode2DomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode2DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode2DomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode2DomainData);
            Type [] methodGetIncidentResolutionCode2DomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode2DomainData, methodGetIncidentResolutionCode2DomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentResolutionCode2DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode2DomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode2DomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode2DomainData);
            Type [] methodGetIncidentResolutionCode2DomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode2DomainData, methodGetIncidentResolutionCode2DomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentResolutionCode2DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode2DomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode2DomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode2DomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentResolutionCode2DomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode3DomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentResolutionCode3DomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentResolutionCode3DomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode3DomainData, methodGetIncidentResolutionCode3DomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode3DomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode3DomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode3DomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentResolutionCode3DomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode3DomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode3DomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode3DomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentResolutionCode3DomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode3DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode3DomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode3DomainData);
            Type [] methodGetIncidentResolutionCode3DomainDataParametersTypes = null;
            object[] parametersOfGetIncidentResolutionCode3DomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentResolutionCode3DomainData, methodGetIncidentResolutionCode3DomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentResolutionCode3DomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentResolutionCode3DomainData, parametersOfGetIncidentResolutionCode3DomainData, methodGetIncidentResolutionCode3DomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentResolutionCode3DomainData.ShouldBeNull();
            methodGetIncidentResolutionCode3DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode3DomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode3DomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode3DomainData);
            Type [] methodGetIncidentResolutionCode3DomainDataParametersTypes = null;
            object[] parametersOfGetIncidentResolutionCode3DomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentResolutionCode3DomainData, parametersOfGetIncidentResolutionCode3DomainData, methodGetIncidentResolutionCode3DomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentResolutionCode3DomainData.ShouldBeNull();
            methodGetIncidentResolutionCode3DomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode3DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode3DomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode3DomainData);
            Type [] methodGetIncidentResolutionCode3DomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode3DomainData, methodGetIncidentResolutionCode3DomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentResolutionCode3DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode3DomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode3DomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode3DomainData);
            Type [] methodGetIncidentResolutionCode3DomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode3DomainData, methodGetIncidentResolutionCode3DomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentResolutionCode3DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode3DomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode3DomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode3DomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentResolutionCode3DomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode4DomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetIncidentResolutionCode4DomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentResolutionCode4DomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode4DomainData, methodGetIncidentResolutionCode4DomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode4DomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode4DomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode4DomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetIncidentResolutionCode4DomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode4DomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode4DomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode4DomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetIncidentResolutionCode4DomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode4DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode4DomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode4DomainData);
            Type [] methodGetIncidentResolutionCode4DomainDataParametersTypes = null;
            object[] parametersOfGetIncidentResolutionCode4DomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentResolutionCode4DomainData, methodGetIncidentResolutionCode4DomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetIncidentResolutionCode4DomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetIncidentResolutionCode4DomainData, parametersOfGetIncidentResolutionCode4DomainData, methodGetIncidentResolutionCode4DomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentResolutionCode4DomainData.ShouldBeNull();
            methodGetIncidentResolutionCode4DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode4DomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode4DomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode4DomainData);
            Type [] methodGetIncidentResolutionCode4DomainDataParametersTypes = null;
            object[] parametersOfGetIncidentResolutionCode4DomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetIncidentResolutionCode4DomainData, parametersOfGetIncidentResolutionCode4DomainData, methodGetIncidentResolutionCode4DomainDataParametersTypes);

            // Assert
            parametersOfGetIncidentResolutionCode4DomainData.ShouldBeNull();
            methodGetIncidentResolutionCode4DomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode4DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode4DomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode4DomainData);
            Type [] methodGetIncidentResolutionCode4DomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode4DomainData, methodGetIncidentResolutionCode4DomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentResolutionCode4DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode4DomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode4DomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode4DomainData);
            Type [] methodGetIncidentResolutionCode4DomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentResolutionCode4DomainData, methodGetIncidentResolutionCode4DomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentResolutionCode4DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentResolutionCode4DomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetIncidentResolutionCode4DomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentResolutionCode4DomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentResolutionCode4DomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketTypeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketTypeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketTypeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketTypeDomainData, methodGetWorkticketTypeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketTypeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketTypeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketTypeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketTypeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketTypeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketTypeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketTypeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketTypeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketTypeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketTypeDomainData);
            Type [] methodGetWorkticketTypeDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketTypeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketTypeDomainData, methodGetWorkticketTypeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketTypeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketTypeDomainData, parametersOfGetWorkticketTypeDomainData, methodGetWorkticketTypeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketTypeDomainData.ShouldBeNull();
            methodGetWorkticketTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketTypeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketTypeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketTypeDomainData);
            Type [] methodGetWorkticketTypeDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketTypeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketTypeDomainData, parametersOfGetWorkticketTypeDomainData, methodGetWorkticketTypeDomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketTypeDomainData.ShouldBeNull();
            methodGetWorkticketTypeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketTypeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketTypeDomainData);
            Type [] methodGetWorkticketTypeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketTypeDomainData, methodGetWorkticketTypeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketTypeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketTypeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketTypeDomainData);
            Type [] methodGetWorkticketTypeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketTypeDomainData, methodGetWorkticketTypeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketTypeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketTypeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketTypeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketTypeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketStatusDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketStatusDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketStatusDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketStatusDomainData, methodGetWorkticketStatusDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketStatusDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketStatusDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketStatusDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketStatusDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketStatusDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketStatusDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketStatusDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketStatusDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketStatusDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketStatusDomainData);
            Type [] methodGetWorkticketStatusDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketStatusDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketStatusDomainData, methodGetWorkticketStatusDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketStatusDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketStatusDomainData, parametersOfGetWorkticketStatusDomainData, methodGetWorkticketStatusDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketStatusDomainData.ShouldBeNull();
            methodGetWorkticketStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketStatusDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketStatusDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketStatusDomainData);
            Type [] methodGetWorkticketStatusDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketStatusDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketStatusDomainData, parametersOfGetWorkticketStatusDomainData, methodGetWorkticketStatusDomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketStatusDomainData.ShouldBeNull();
            methodGetWorkticketStatusDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketStatusDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketStatusDomainData);
            Type [] methodGetWorkticketStatusDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketStatusDomainData, methodGetWorkticketStatusDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketStatusDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketStatusDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketStatusDomainData);
            Type [] methodGetWorkticketStatusDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketStatusDomainData, methodGetWorkticketStatusDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketStatusDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketStatusDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketStatusDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketStatusDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketPriorityDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketPriorityDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketPriorityDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketPriorityDomainData, methodGetWorkticketPriorityDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketPriorityDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketPriorityDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketPriorityDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketPriorityDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketPriorityDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketPriorityDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketPriorityDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketPriorityDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketPriorityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketPriorityDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketPriorityDomainData);
            Type [] methodGetWorkticketPriorityDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketPriorityDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketPriorityDomainData, methodGetWorkticketPriorityDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketPriorityDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketPriorityDomainData, parametersOfGetWorkticketPriorityDomainData, methodGetWorkticketPriorityDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketPriorityDomainData.ShouldBeNull();
            methodGetWorkticketPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketPriorityDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketPriorityDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketPriorityDomainData);
            Type [] methodGetWorkticketPriorityDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketPriorityDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketPriorityDomainData, parametersOfGetWorkticketPriorityDomainData, methodGetWorkticketPriorityDomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketPriorityDomainData.ShouldBeNull();
            methodGetWorkticketPriorityDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketPriorityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketPriorityDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketPriorityDomainData);
            Type [] methodGetWorkticketPriorityDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketPriorityDomainData, methodGetWorkticketPriorityDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketPriorityDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketPriorityDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketPriorityDomainData);
            Type [] methodGetWorkticketPriorityDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketPriorityDomainData, methodGetWorkticketPriorityDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketPriorityDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketPriorityDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketPriorityDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketPriorityDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSeverityDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketSeverityDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketSeverityDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketSeverityDomainData, methodGetWorkticketSeverityDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketSeverityDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSeverityDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSeverityDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketSeverityDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketSeverityDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSeverityDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSeverityDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketSeverityDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSeverityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSeverityDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSeverityDomainData);
            Type [] methodGetWorkticketSeverityDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketSeverityDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketSeverityDomainData, methodGetWorkticketSeverityDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketSeverityDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketSeverityDomainData, parametersOfGetWorkticketSeverityDomainData, methodGetWorkticketSeverityDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketSeverityDomainData.ShouldBeNull();
            methodGetWorkticketSeverityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSeverityDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSeverityDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSeverityDomainData);
            Type [] methodGetWorkticketSeverityDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketSeverityDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketSeverityDomainData, parametersOfGetWorkticketSeverityDomainData, methodGetWorkticketSeverityDomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketSeverityDomainData.ShouldBeNull();
            methodGetWorkticketSeverityDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketSeverityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSeverityDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSeverityDomainData);
            Type [] methodGetWorkticketSeverityDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketSeverityDomainData, methodGetWorkticketSeverityDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketSeverityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSeverityDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSeverityDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSeverityDomainData);
            Type [] methodGetWorkticketSeverityDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketSeverityDomainData, methodGetWorkticketSeverityDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketSeverityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSeverityDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSeverityDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSeverityDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketSeverityDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSourceDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketSourceDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketSourceDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketSourceDomainData, methodGetWorkticketSourceDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketSourceDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSourceDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSourceDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketSourceDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketSourceDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSourceDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSourceDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketSourceDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSourceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSourceDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSourceDomainData);
            Type [] methodGetWorkticketSourceDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketSourceDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketSourceDomainData, methodGetWorkticketSourceDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketSourceDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketSourceDomainData, parametersOfGetWorkticketSourceDomainData, methodGetWorkticketSourceDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketSourceDomainData.ShouldBeNull();
            methodGetWorkticketSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSourceDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSourceDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSourceDomainData);
            Type [] methodGetWorkticketSourceDomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketSourceDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketSourceDomainData, parametersOfGetWorkticketSourceDomainData, methodGetWorkticketSourceDomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketSourceDomainData.ShouldBeNull();
            methodGetWorkticketSourceDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketSourceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSourceDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSourceDomainData);
            Type [] methodGetWorkticketSourceDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketSourceDomainData, methodGetWorkticketSourceDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSourceDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSourceDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSourceDomainData);
            Type [] methodGetWorkticketSourceDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketSourceDomainData, methodGetWorkticketSourceDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketSourceDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketSourceDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketSourceDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketSourceDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketSourceDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode1DomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketResolutionCode1DomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketResolutionCode1DomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode1DomainData, methodGetWorkticketResolutionCode1DomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode1DomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode1DomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode1DomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketResolutionCode1DomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode1DomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode1DomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode1DomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketResolutionCode1DomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode1DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode1DomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode1DomainData);
            Type [] methodGetWorkticketResolutionCode1DomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketResolutionCode1DomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketResolutionCode1DomainData, methodGetWorkticketResolutionCode1DomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketResolutionCode1DomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketResolutionCode1DomainData, parametersOfGetWorkticketResolutionCode1DomainData, methodGetWorkticketResolutionCode1DomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketResolutionCode1DomainData.ShouldBeNull();
            methodGetWorkticketResolutionCode1DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode1DomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode1DomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode1DomainData);
            Type [] methodGetWorkticketResolutionCode1DomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketResolutionCode1DomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketResolutionCode1DomainData, parametersOfGetWorkticketResolutionCode1DomainData, methodGetWorkticketResolutionCode1DomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketResolutionCode1DomainData.ShouldBeNull();
            methodGetWorkticketResolutionCode1DomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode1DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode1DomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode1DomainData);
            Type [] methodGetWorkticketResolutionCode1DomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode1DomainData, methodGetWorkticketResolutionCode1DomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketResolutionCode1DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode1DomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode1DomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode1DomainData);
            Type [] methodGetWorkticketResolutionCode1DomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode1DomainData, methodGetWorkticketResolutionCode1DomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketResolutionCode1DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode1DomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode1DomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode1DomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketResolutionCode1DomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode2DomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketResolutionCode2DomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketResolutionCode2DomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode2DomainData, methodGetWorkticketResolutionCode2DomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode2DomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode2DomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode2DomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketResolutionCode2DomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode2DomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode2DomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode2DomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketResolutionCode2DomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode2DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode2DomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode2DomainData);
            Type [] methodGetWorkticketResolutionCode2DomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketResolutionCode2DomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketResolutionCode2DomainData, methodGetWorkticketResolutionCode2DomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketResolutionCode2DomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketResolutionCode2DomainData, parametersOfGetWorkticketResolutionCode2DomainData, methodGetWorkticketResolutionCode2DomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketResolutionCode2DomainData.ShouldBeNull();
            methodGetWorkticketResolutionCode2DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode2DomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode2DomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode2DomainData);
            Type [] methodGetWorkticketResolutionCode2DomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketResolutionCode2DomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketResolutionCode2DomainData, parametersOfGetWorkticketResolutionCode2DomainData, methodGetWorkticketResolutionCode2DomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketResolutionCode2DomainData.ShouldBeNull();
            methodGetWorkticketResolutionCode2DomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode2DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode2DomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode2DomainData);
            Type [] methodGetWorkticketResolutionCode2DomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode2DomainData, methodGetWorkticketResolutionCode2DomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketResolutionCode2DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode2DomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode2DomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode2DomainData);
            Type [] methodGetWorkticketResolutionCode2DomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode2DomainData, methodGetWorkticketResolutionCode2DomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketResolutionCode2DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode2DomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode2DomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode2DomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketResolutionCode2DomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode3DomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketResolutionCode3DomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketResolutionCode3DomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode3DomainData, methodGetWorkticketResolutionCode3DomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode3DomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode3DomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode3DomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketResolutionCode3DomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode3DomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode3DomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode3DomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketResolutionCode3DomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode3DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode3DomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode3DomainData);
            Type [] methodGetWorkticketResolutionCode3DomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketResolutionCode3DomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketResolutionCode3DomainData, methodGetWorkticketResolutionCode3DomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketResolutionCode3DomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketResolutionCode3DomainData, parametersOfGetWorkticketResolutionCode3DomainData, methodGetWorkticketResolutionCode3DomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketResolutionCode3DomainData.ShouldBeNull();
            methodGetWorkticketResolutionCode3DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode3DomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode3DomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode3DomainData);
            Type [] methodGetWorkticketResolutionCode3DomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketResolutionCode3DomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketResolutionCode3DomainData, parametersOfGetWorkticketResolutionCode3DomainData, methodGetWorkticketResolutionCode3DomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketResolutionCode3DomainData.ShouldBeNull();
            methodGetWorkticketResolutionCode3DomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode3DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode3DomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode3DomainData);
            Type [] methodGetWorkticketResolutionCode3DomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode3DomainData, methodGetWorkticketResolutionCode3DomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketResolutionCode3DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode3DomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode3DomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode3DomainData);
            Type [] methodGetWorkticketResolutionCode3DomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode3DomainData, methodGetWorkticketResolutionCode3DomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketResolutionCode3DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode3DomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode3DomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode3DomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketResolutionCode3DomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode4DomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetWorkticketResolutionCode4DomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetWorkticketResolutionCode4DomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode4DomainData, methodGetWorkticketResolutionCode4DomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode4DomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode4DomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode4DomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetWorkticketResolutionCode4DomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode4DomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode4DomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode4DomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetWorkticketResolutionCode4DomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode4DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode4DomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode4DomainData);
            Type [] methodGetWorkticketResolutionCode4DomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketResolutionCode4DomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketResolutionCode4DomainData, methodGetWorkticketResolutionCode4DomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetWorkticketResolutionCode4DomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetWorkticketResolutionCode4DomainData, parametersOfGetWorkticketResolutionCode4DomainData, methodGetWorkticketResolutionCode4DomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWorkticketResolutionCode4DomainData.ShouldBeNull();
            methodGetWorkticketResolutionCode4DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode4DomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode4DomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode4DomainData);
            Type [] methodGetWorkticketResolutionCode4DomainDataParametersTypes = null;
            object[] parametersOfGetWorkticketResolutionCode4DomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWorkticketResolutionCode4DomainData, parametersOfGetWorkticketResolutionCode4DomainData, methodGetWorkticketResolutionCode4DomainDataParametersTypes);

            // Assert
            parametersOfGetWorkticketResolutionCode4DomainData.ShouldBeNull();
            methodGetWorkticketResolutionCode4DomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode4DomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode4DomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode4DomainData);
            Type [] methodGetWorkticketResolutionCode4DomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode4DomainData, methodGetWorkticketResolutionCode4DomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWorkticketResolutionCode4DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode4DomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode4DomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode4DomainData);
            Type [] methodGetWorkticketResolutionCode4DomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWorkticketResolutionCode4DomainData, methodGetWorkticketResolutionCode4DomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWorkticketResolutionCode4DomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWorkticketResolutionCode4DomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetWorkticketResolutionCode4DomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWorkticketResolutionCode4DomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWorkticketResolutionCode4DomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailSentDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetEmailSentDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailSentDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailSentDomainData, methodGetEmailSentDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailSentDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetEmailSentDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSentDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetEmailSentDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEmailSentDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetEmailSentDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSentDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetEmailSentDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailSentDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetEmailSentDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSentDomainData);
            Type [] methodGetEmailSentDomainDataParametersTypes = null;
            object[] parametersOfGetEmailSentDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailSentDomainData, methodGetEmailSentDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetEmailSentDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetEmailSentDomainData, parametersOfGetEmailSentDomainData, methodGetEmailSentDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEmailSentDomainData.ShouldBeNull();
            methodGetEmailSentDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailSentDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetEmailSentDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSentDomainData);
            Type [] methodGetEmailSentDomainDataParametersTypes = null;
            object[] parametersOfGetEmailSentDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEmailSentDomainData, parametersOfGetEmailSentDomainData, methodGetEmailSentDomainDataParametersTypes);

            // Assert
            parametersOfGetEmailSentDomainData.ShouldBeNull();
            methodGetEmailSentDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailSentDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetEmailSentDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSentDomainData);
            Type [] methodGetEmailSentDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailSentDomainData, methodGetEmailSentDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEmailSentDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailSentDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetEmailSentDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSentDomainData);
            Type [] methodGetEmailSentDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailSentDomainData, methodGetEmailSentDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailSentDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailSentDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetEmailSentDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSentDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailSentDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskTypeDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetTaskTypeDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetTaskTypeDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTaskTypeDomainData, methodGetTaskTypeDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetTaskTypeDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskTypeDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskTypeDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetTaskTypeDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTaskTypeDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskTypeDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskTypeDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetTaskTypeDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskTypeDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskTypeDomainData);
            Type [] methodGetTaskTypeDomainDataParametersTypes = null;
            object[] parametersOfGetTaskTypeDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskTypeDomainData, methodGetTaskTypeDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetTaskTypeDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetTaskTypeDomainData, parametersOfGetTaskTypeDomainData, methodGetTaskTypeDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTaskTypeDomainData.ShouldBeNull();
            methodGetTaskTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskTypeDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskTypeDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskTypeDomainData);
            Type [] methodGetTaskTypeDomainDataParametersTypes = null;
            object[] parametersOfGetTaskTypeDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTaskTypeDomainData, parametersOfGetTaskTypeDomainData, methodGetTaskTypeDomainDataParametersTypes);

            // Assert
            parametersOfGetTaskTypeDomainData.ShouldBeNull();
            methodGetTaskTypeDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTaskTypeDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskTypeDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskTypeDomainData);
            Type [] methodGetTaskTypeDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTaskTypeDomainData, methodGetTaskTypeDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTaskTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskTypeDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskTypeDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskTypeDomainData);
            Type [] methodGetTaskTypeDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTaskTypeDomainData, methodGetTaskTypeDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTaskTypeDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskTypeDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskTypeDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskTypeDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskTypeDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskStatusDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetTaskStatusDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetTaskStatusDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTaskStatusDomainData, methodGetTaskStatusDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetTaskStatusDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskStatusDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskStatusDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetTaskStatusDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTaskStatusDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskStatusDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskStatusDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetTaskStatusDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskStatusDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskStatusDomainData);
            Type [] methodGetTaskStatusDomainDataParametersTypes = null;
            object[] parametersOfGetTaskStatusDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskStatusDomainData, methodGetTaskStatusDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetTaskStatusDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetTaskStatusDomainData, parametersOfGetTaskStatusDomainData, methodGetTaskStatusDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTaskStatusDomainData.ShouldBeNull();
            methodGetTaskStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskStatusDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskStatusDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskStatusDomainData);
            Type [] methodGetTaskStatusDomainDataParametersTypes = null;
            object[] parametersOfGetTaskStatusDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTaskStatusDomainData, parametersOfGetTaskStatusDomainData, methodGetTaskStatusDomainDataParametersTypes);

            // Assert
            parametersOfGetTaskStatusDomainData.ShouldBeNull();
            methodGetTaskStatusDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTaskStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskStatusDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskStatusDomainData);
            Type [] methodGetTaskStatusDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTaskStatusDomainData, methodGetTaskStatusDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTaskStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskStatusDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskStatusDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskStatusDomainData);
            Type [] methodGetTaskStatusDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTaskStatusDomainData, methodGetTaskStatusDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTaskStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskStatusDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskStatusDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskStatusDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskStatusDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskPriorityDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetTaskPriorityDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetTaskPriorityDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTaskPriorityDomainData, methodGetTaskPriorityDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetTaskPriorityDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskPriorityDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskPriorityDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetTaskPriorityDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTaskPriorityDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskPriorityDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskPriorityDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetTaskPriorityDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskPriorityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskPriorityDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskPriorityDomainData);
            Type [] methodGetTaskPriorityDomainDataParametersTypes = null;
            object[] parametersOfGetTaskPriorityDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskPriorityDomainData, methodGetTaskPriorityDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetTaskPriorityDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetTaskPriorityDomainData, parametersOfGetTaskPriorityDomainData, methodGetTaskPriorityDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTaskPriorityDomainData.ShouldBeNull();
            methodGetTaskPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskPriorityDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskPriorityDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskPriorityDomainData);
            Type [] methodGetTaskPriorityDomainDataParametersTypes = null;
            object[] parametersOfGetTaskPriorityDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTaskPriorityDomainData, parametersOfGetTaskPriorityDomainData, methodGetTaskPriorityDomainDataParametersTypes);

            // Assert
            parametersOfGetTaskPriorityDomainData.ShouldBeNull();
            methodGetTaskPriorityDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTaskPriorityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskPriorityDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskPriorityDomainData);
            Type [] methodGetTaskPriorityDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTaskPriorityDomainData, methodGetTaskPriorityDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTaskPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskPriorityDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskPriorityDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskPriorityDomainData);
            Type [] methodGetTaskPriorityDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTaskPriorityDomainData, methodGetTaskPriorityDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTaskPriorityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskPriorityDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskPriorityDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskPriorityDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskPriorityDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskCategoryDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetTaskCategoryDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetTaskCategoryDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTaskCategoryDomainData, methodGetTaskCategoryDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetTaskCategoryDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskCategoryDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategoryDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetTaskCategoryDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTaskCategoryDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskCategoryDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategoryDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetTaskCategoryDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskCategoryDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskCategoryDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategoryDomainData);
            Type [] methodGetTaskCategoryDomainDataParametersTypes = null;
            object[] parametersOfGetTaskCategoryDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskCategoryDomainData, methodGetTaskCategoryDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetTaskCategoryDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetTaskCategoryDomainData, parametersOfGetTaskCategoryDomainData, methodGetTaskCategoryDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTaskCategoryDomainData.ShouldBeNull();
            methodGetTaskCategoryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskCategoryDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskCategoryDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategoryDomainData);
            Type [] methodGetTaskCategoryDomainDataParametersTypes = null;
            object[] parametersOfGetTaskCategoryDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTaskCategoryDomainData, parametersOfGetTaskCategoryDomainData, methodGetTaskCategoryDomainDataParametersTypes);

            // Assert
            parametersOfGetTaskCategoryDomainData.ShouldBeNull();
            methodGetTaskCategoryDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTaskCategoryDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskCategoryDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategoryDomainData);
            Type [] methodGetTaskCategoryDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTaskCategoryDomainData, methodGetTaskCategoryDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTaskCategoryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskCategoryDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskCategoryDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategoryDomainData);
            Type [] methodGetTaskCategoryDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTaskCategoryDomainData, methodGetTaskCategoryDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTaskCategoryDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTaskCategoryDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTaskCategoryDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTaskCategoryDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTaskCategoryDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastStatusDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetForecastStatusDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetForecastStatusDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetForecastStatusDomainData, methodGetForecastStatusDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetForecastStatusDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastStatusDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastStatusDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetForecastStatusDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetForecastStatusDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastStatusDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastStatusDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetForecastStatusDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastStatusDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastStatusDomainData);
            Type [] methodGetForecastStatusDomainDataParametersTypes = null;
            object[] parametersOfGetForecastStatusDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetForecastStatusDomainData, methodGetForecastStatusDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetForecastStatusDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetForecastStatusDomainData, parametersOfGetForecastStatusDomainData, methodGetForecastStatusDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetForecastStatusDomainData.ShouldBeNull();
            methodGetForecastStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastStatusDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastStatusDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastStatusDomainData);
            Type [] methodGetForecastStatusDomainDataParametersTypes = null;
            object[] parametersOfGetForecastStatusDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetForecastStatusDomainData, parametersOfGetForecastStatusDomainData, methodGetForecastStatusDomainDataParametersTypes);

            // Assert
            parametersOfGetForecastStatusDomainData.ShouldBeNull();
            methodGetForecastStatusDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetForecastStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastStatusDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastStatusDomainData);
            Type [] methodGetForecastStatusDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetForecastStatusDomainData, methodGetForecastStatusDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetForecastStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastStatusDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastStatusDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastStatusDomainData);
            Type [] methodGetForecastStatusDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetForecastStatusDomainData, methodGetForecastStatusDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetForecastStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastStatusDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastStatusDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastStatusDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetForecastStatusDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastProbabilityDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetForecastProbabilityDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetForecastProbabilityDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetForecastProbabilityDomainData, methodGetForecastProbabilityDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetForecastProbabilityDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastProbabilityDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastProbabilityDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetForecastProbabilityDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetForecastProbabilityDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastProbabilityDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastProbabilityDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetForecastProbabilityDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastProbabilityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastProbabilityDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastProbabilityDomainData);
            Type [] methodGetForecastProbabilityDomainDataParametersTypes = null;
            object[] parametersOfGetForecastProbabilityDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetForecastProbabilityDomainData, methodGetForecastProbabilityDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetForecastProbabilityDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetForecastProbabilityDomainData, parametersOfGetForecastProbabilityDomainData, methodGetForecastProbabilityDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetForecastProbabilityDomainData.ShouldBeNull();
            methodGetForecastProbabilityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastProbabilityDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastProbabilityDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastProbabilityDomainData);
            Type [] methodGetForecastProbabilityDomainDataParametersTypes = null;
            object[] parametersOfGetForecastProbabilityDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetForecastProbabilityDomainData, parametersOfGetForecastProbabilityDomainData, methodGetForecastProbabilityDomainDataParametersTypes);

            // Assert
            parametersOfGetForecastProbabilityDomainData.ShouldBeNull();
            methodGetForecastProbabilityDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetForecastProbabilityDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastProbabilityDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastProbabilityDomainData);
            Type [] methodGetForecastProbabilityDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetForecastProbabilityDomainData, methodGetForecastProbabilityDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetForecastProbabilityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastProbabilityDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastProbabilityDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastProbabilityDomainData);
            Type [] methodGetForecastProbabilityDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetForecastProbabilityDomainData, methodGetForecastProbabilityDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetForecastProbabilityDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForecastProbabilityDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetForecastProbabilityDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForecastProbabilityDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetForecastProbabilityDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductStatusDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetProductStatusDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetProductStatusDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductStatusDomainData, methodGetProductStatusDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductStatusDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductStatusDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductStatusDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetProductStatusDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProductStatusDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductStatusDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductStatusDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetProductStatusDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductStatusDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductStatusDomainData);
            Type [] methodGetProductStatusDomainDataParametersTypes = null;
            object[] parametersOfGetProductStatusDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductStatusDomainData, methodGetProductStatusDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetProductStatusDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetProductStatusDomainData, parametersOfGetProductStatusDomainData, methodGetProductStatusDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProductStatusDomainData.ShouldBeNull();
            methodGetProductStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductStatusDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductStatusDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductStatusDomainData);
            Type [] methodGetProductStatusDomainDataParametersTypes = null;
            object[] parametersOfGetProductStatusDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetProductStatusDomainData, parametersOfGetProductStatusDomainData, methodGetProductStatusDomainDataParametersTypes);

            // Assert
            parametersOfGetProductStatusDomainData.ShouldBeNull();
            methodGetProductStatusDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductStatusDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductStatusDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductStatusDomainData);
            Type [] methodGetProductStatusDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProductStatusDomainData, methodGetProductStatusDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductStatusDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductStatusDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductStatusDomainData);
            Type [] methodGetProductStatusDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductStatusDomainData, methodGetProductStatusDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductStatusDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductStatusDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductStatusDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductStatusDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductStatusDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperatorDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetDateOperatorDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetDateOperatorDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDateOperatorDomainData, methodGetDateOperatorDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetDateOperatorDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDateOperatorDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperatorDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetDateOperatorDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDateOperatorDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDateOperatorDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperatorDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetDateOperatorDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperatorDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDateOperatorDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperatorDomainData);
            Type [] methodGetDateOperatorDomainDataParametersTypes = null;
            object[] parametersOfGetDateOperatorDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateOperatorDomainData, methodGetDateOperatorDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetDateOperatorDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetDateOperatorDomainData, parametersOfGetDateOperatorDomainData, methodGetDateOperatorDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDateOperatorDomainData.ShouldBeNull();
            methodGetDateOperatorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperatorDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDateOperatorDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperatorDomainData);
            Type [] methodGetDateOperatorDomainDataParametersTypes = null;
            object[] parametersOfGetDateOperatorDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDateOperatorDomainData, parametersOfGetDateOperatorDomainData, methodGetDateOperatorDomainDataParametersTypes);

            // Assert
            parametersOfGetDateOperatorDomainData.ShouldBeNull();
            methodGetDateOperatorDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDateOperatorDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDateOperatorDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperatorDomainData);
            Type [] methodGetDateOperatorDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDateOperatorDomainData, methodGetDateOperatorDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDateOperatorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperatorDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDateOperatorDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperatorDomainData);
            Type [] methodGetDateOperatorDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDateOperatorDomainData, methodGetDateOperatorDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDateOperatorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperatorDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDateOperatorDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperatorDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateOperatorDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetOperatorDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetOperatorDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOperatorDomainData, methodGetOperatorDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetOperatorDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetOperatorDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorDomainData);

            // Act
            Action executeAction = () => _domainDataInstance.GetOperatorDomainData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOperatorDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetOperatorDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorDomainData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetOperatorDomainData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetOperatorDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorDomainData);
            Type [] methodGetOperatorDomainDataParametersTypes = null;
            object[] parametersOfGetOperatorDomainData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorDomainData, methodGetOperatorDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetOperatorDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetOperatorDomainData, parametersOfGetOperatorDomainData, methodGetOperatorDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOperatorDomainData.ShouldBeNull();
            methodGetOperatorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetOperatorDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorDomainData);
            Type [] methodGetOperatorDomainDataParametersTypes = null;
            object[] parametersOfGetOperatorDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetOperatorDomainData, parametersOfGetOperatorDomainData, methodGetOperatorDomainDataParametersTypes);

            // Assert
            parametersOfGetOperatorDomainData.ShouldBeNull();
            methodGetOperatorDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOperatorDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetOperatorDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorDomainData);
            Type [] methodGetOperatorDomainDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOperatorDomainData, methodGetOperatorDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOperatorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetOperatorDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorDomainData);
            Type [] methodGetOperatorDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOperatorDomainData, methodGetOperatorDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOperatorDomainDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetOperatorDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetXml_Method_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<IntDomainData>>();

            // Act
            Action executeAction = () => _domainDataInstance.GetXml(list);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<IntDomainData>>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetXml(list);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<IntDomainData>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<IntDomainData>) };
            object[] parametersOfGetXml = { list };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<IntDomainData>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<IntDomainData>) };
            object[] parametersOfGetXml = { list };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<IntDomainData>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<IntDomainData>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetXml_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<StrDomainData>>();

            // Act
            Action executeAction = () => _domainDataInstance.GetXml(list);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<StrDomainData>>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetXml(list);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<StrDomainData>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<StrDomainData>) };
            object[] parametersOfGetXml = { list };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<StrDomainData>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<StrDomainData>) };
            object[] parametersOfGetXml = { list };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<StrDomainData>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<StrDomainData>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetXml_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<ReferenceLookup>>();

            // Act
            Action executeAction = () => _domainDataInstance.GetXml(list);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_DirectCall_Overloading_Of_2_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<ReferenceLookup>>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetXml(list);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_2_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<ReferenceLookup>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<ReferenceLookup>) };
            object[] parametersOfGetXml = { list };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<IEnumerable<ReferenceLookup>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<ReferenceLookup>) };
            object[] parametersOfGetXml = { list };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<ReferenceLookup>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(IEnumerable<ReferenceLookup>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 2);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetReferenceDomainData_Method_Call_Internally(Type[] types)
        {
            var methodGetReferenceDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetReferenceDomainData, methodGetReferenceDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceDomainData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceDomainData);
            var fieldName = this.CreateType<string>();
            var bParentId = this.CreateType<bool>();

            // Act
            Action executeAction = () => _domainDataInstance.GetReferenceDomainData(fieldName, bParentId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceDomainData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceDomainData);
            var fieldName = this.CreateType<string>();
            var bParentId = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetReferenceDomainData(fieldName, bParentId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceDomainData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceDomainData);
            var fieldName = this.CreateType<string>();
            var bParentId = this.CreateType<bool>();
            var methodGetReferenceDomainDataParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfGetReferenceDomainData = { fieldName, bParentId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceDomainData, methodGetReferenceDomainDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetReferenceDomainData);
            var result2 = this.GetResultOfMethod<string>(MethodGetReferenceDomainData, parametersOfGetReferenceDomainData, methodGetReferenceDomainDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReferenceDomainData.ShouldNotBeNull();
            parametersOfGetReferenceDomainData.Length.ShouldBe(2);
            methodGetReferenceDomainDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceDomainData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceDomainData);
            var fieldName = this.CreateType<string>();
            var bParentId = this.CreateType<bool>();
            var methodGetReferenceDomainDataParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfGetReferenceDomainData = { fieldName, bParentId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetReferenceDomainData, parametersOfGetReferenceDomainData, methodGetReferenceDomainDataParametersTypes);

            // Assert
            parametersOfGetReferenceDomainData.ShouldNotBeNull();
            parametersOfGetReferenceDomainData.Length.ShouldBe(2);
            methodGetReferenceDomainDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceDomainData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceDomainData);
            var methodGetReferenceDomainDataParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReferenceDomainData, methodGetReferenceDomainDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReferenceDomainDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceDomainData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceDomainData);
            var methodGetReferenceDomainDataParametersTypes = new Type[] { typeof(string), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReferenceDomainData, methodGetReferenceDomainDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReferenceDomainDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceDomainData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceDomainData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceDomainData) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceDomainData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceDomainData, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetXml_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_DirectCall_Overloading_Of_3_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var lboResult = this.CreateType<string>();
            var list = this.CreateType<CustomReferenceLookup>();
            var domainDataXml = this.CreateType<XDocument>();

            // Act
            Action executeAction = () => _domainDataInstance.GetXml(lboResult, list, domainDataXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_DirectCall_Overloading_Of_3_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var lboResult = this.CreateType<string>();
            var list = this.CreateType<CustomReferenceLookup>();
            var domainDataXml = this.CreateType<XDocument>();
            var returnedValue = default(XDocument);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetXml(lboResult, list, domainDataXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_3_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var lboResult = this.CreateType<string>();
            var list = this.CreateType<CustomReferenceLookup>();
            var domainDataXml = this.CreateType<XDocument>();
            var methodGetXmlParametersTypes = new Type[] { typeof(string), typeof(CustomReferenceLookup), typeof(XDocument) };
            object[] parametersOfGetXml = { lboResult, list, domainDataXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XDocument>(_domainDataInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<XDocument>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(3);
            methodGetXmlParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_3_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var lboResult = this.CreateType<string>();
            var list = this.CreateType<CustomReferenceLookup>();
            var domainDataXml = this.CreateType<XDocument>();
            var methodGetXmlParametersTypes = new Type[] { typeof(string), typeof(CustomReferenceLookup), typeof(XDocument) };
            object[] parametersOfGetXml = { lboResult, list, domainDataXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XDocument>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(3);
            methodGetXmlParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(string), typeof(CustomReferenceLookup), typeof(XDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_3_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(string), typeof(CustomReferenceLookup), typeof(XDocument) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 3);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : XDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetXml_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 3);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetRegion_Method_Call_Internally(Type[] types)
        {
            var methodGetRegionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegion_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);

            // Act
            Action executeAction = () => _domainDataInstance.GetRegion();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegion_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetRegion();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegion_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            Type [] methodGetRegionParametersTypes = null;
            object[] parametersOfGetRegion = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegion, methodGetRegionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetRegion);
            var result2 = this.GetResultOfMethod<string>(MethodGetRegion, parametersOfGetRegion, methodGetRegionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRegion.ShouldBeNull();
            methodGetRegionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegion_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            Type [] methodGetRegionParametersTypes = null;
            object[] parametersOfGetRegion = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRegion, parametersOfGetRegion, methodGetRegionParametersTypes);

            // Assert
            parametersOfGetRegion.ShouldBeNull();
            methodGetRegionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegion_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            Type [] methodGetRegionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRegionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegion_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            Type [] methodGetRegionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRegionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegion_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetReferenceLookUp) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetReferenceLookUp_Method_Call_Internally(Type[] types)
        {
            var methodGetReferenceLookUpParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUp, methodGetReferenceLookUpParametersTypes);
        }

        #endregion

        #region Method Call : (GetReferenceLookUp) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceLookUp_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUp);

            // Act
            Action executeAction = () => _domainDataInstance.GetReferenceLookUp();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookUp) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceLookUp_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUp);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetReferenceLookUp();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUp) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceLookUp_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUp);
            Type [] methodGetReferenceLookUpParametersTypes = null;
            object[] parametersOfGetReferenceLookUp = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookUp, methodGetReferenceLookUpParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetReferenceLookUp);
            var result2 = this.GetResultOfMethod<string>(MethodGetReferenceLookUp, parametersOfGetReferenceLookUp, methodGetReferenceLookUpParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReferenceLookUp.ShouldBeNull();
            methodGetReferenceLookUpParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUp) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceLookUp_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUp);
            Type [] methodGetReferenceLookUpParametersTypes = null;
            object[] parametersOfGetReferenceLookUp = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetReferenceLookUp, parametersOfGetReferenceLookUp, methodGetReferenceLookUpParametersTypes);

            // Assert
            parametersOfGetReferenceLookUp.ShouldBeNull();
            methodGetReferenceLookUpParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookUp) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceLookUp_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUp);
            Type [] methodGetReferenceLookUpParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUp, methodGetReferenceLookUpParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReferenceLookUpParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUp) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceLookUp_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUp);
            Type [] methodGetReferenceLookUpParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUp, methodGetReferenceLookUpParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReferenceLookUpParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUp) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceLookUp_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUp);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookUp, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetReferenceParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetReferenceParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetReferenceParameter, methodGetReferenceParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetReferenceParameter) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceParameter_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceParameter);

            // Act
            Action executeAction = () => _domainDataInstance.GetReferenceParameter();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReferenceParameter) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceParameter_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceParameter);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetReferenceParameter();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceParameter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceParameter);
            Type [] methodGetReferenceParameterParametersTypes = null;
            object[] parametersOfGetReferenceParameter = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceParameter, methodGetReferenceParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetReferenceParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetReferenceParameter, parametersOfGetReferenceParameter, methodGetReferenceParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReferenceParameter.ShouldBeNull();
            methodGetReferenceParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceParameter);
            Type [] methodGetReferenceParameterParametersTypes = null;
            object[] parametersOfGetReferenceParameter = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetReferenceParameter, parametersOfGetReferenceParameter, methodGetReferenceParameterParametersTypes);

            // Assert
            parametersOfGetReferenceParameter.ShouldBeNull();
            methodGetReferenceParameterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceParameter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceParameter);
            Type [] methodGetReferenceParameterParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReferenceParameter, methodGetReferenceParameterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReferenceParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceParameter);
            Type [] methodGetReferenceParameterParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReferenceParameter, methodGetReferenceParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReferenceParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceParameter) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceParameter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceField) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetReferenceField_Method_Call_Internally(Type[] types)
        {
            var methodGetReferenceFieldParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetReferenceField, methodGetReferenceFieldParametersTypes);
        }

        #endregion

        #region Method Call : (GetReferenceField) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceField_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceField);

            // Act
            Action executeAction = () => _domainDataInstance.GetReferenceField();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReferenceField) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceField_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceField);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetReferenceField();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceField) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceField_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceField);
            Type [] methodGetReferenceFieldParametersTypes = null;
            object[] parametersOfGetReferenceField = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceField, methodGetReferenceFieldParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetReferenceField);
            var result2 = this.GetResultOfMethod<string>(MethodGetReferenceField, parametersOfGetReferenceField, methodGetReferenceFieldParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReferenceField.ShouldBeNull();
            methodGetReferenceFieldParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceField) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceField_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceField);
            Type [] methodGetReferenceFieldParametersTypes = null;
            object[] parametersOfGetReferenceField = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetReferenceField, parametersOfGetReferenceField, methodGetReferenceFieldParametersTypes);

            // Assert
            parametersOfGetReferenceField.ShouldBeNull();
            methodGetReferenceFieldParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceField) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceField_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceField);
            Type [] methodGetReferenceFieldParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReferenceField, methodGetReferenceFieldParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReferenceFieldParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceField) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceField_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceField);
            Type [] methodGetReferenceFieldParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReferenceField, methodGetReferenceFieldParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReferenceFieldParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceField) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetReferenceField_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceField);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceField, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaigns) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCampaigns_Method_Call_Internally(Type[] types)
        {
            var methodGetCampaignsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCampaigns, methodGetCampaignsParametersTypes);
        }

        #endregion

        #region Method Call : (GetCampaigns) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCampaigns_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaigns);

            // Act
            Action executeAction = () => _domainDataInstance.GetCampaigns();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCampaigns) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCampaigns_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaigns);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCampaigns();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaigns) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCampaigns_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaigns);
            Type [] methodGetCampaignsParametersTypes = null;
            object[] parametersOfGetCampaigns = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaigns, methodGetCampaignsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCampaigns);
            var result2 = this.GetResultOfMethod<string>(MethodGetCampaigns, parametersOfGetCampaigns, methodGetCampaignsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCampaigns.ShouldBeNull();
            methodGetCampaignsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaigns) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCampaigns_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaigns);
            Type [] methodGetCampaignsParametersTypes = null;
            object[] parametersOfGetCampaigns = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCampaigns, parametersOfGetCampaigns, methodGetCampaignsParametersTypes);

            // Assert
            parametersOfGetCampaigns.ShouldBeNull();
            methodGetCampaignsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaigns) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCampaigns_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaigns);
            Type [] methodGetCampaignsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCampaigns, methodGetCampaignsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCampaignsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaigns) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCampaigns_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaigns);
            Type [] methodGetCampaignsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCampaigns, methodGetCampaignsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCampaignsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaigns) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCampaigns_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaigns);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaigns, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetGroups_Method_Call_Internally(Type[] types)
        {
            var methodGetGroupsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetGroups, methodGetGroupsParametersTypes);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);

            // Act
            Action executeAction = () => _domainDataInstance.GetGroups();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetGroups();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            Type [] methodGetGroupsParametersTypes = null;
            object[] parametersOfGetGroups = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGroups, methodGetGroupsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetGroups);
            var result2 = this.GetResultOfMethod<string>(MethodGetGroups, parametersOfGetGroups, methodGetGroupsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetGroups.ShouldBeNull();
            methodGetGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            Type [] methodGetGroupsParametersTypes = null;
            object[] parametersOfGetGroups = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetGroups, parametersOfGetGroups, methodGetGroupsParametersTypes);

            // Assert
            parametersOfGetGroups.ShouldBeNull();
            methodGetGroupsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            Type [] methodGetGroupsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGroups, methodGetGroupsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            Type [] methodGetGroupsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGroups, methodGetGroupsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGroups, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetUsers_Method_Call_Internally(Type[] types)
        {
            var methodGetUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);

            // Act
            Action executeAction = () => _domainDataInstance.GetUsers();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetUsers();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            Type [] methodGetUsersParametersTypes = null;
            object[] parametersOfGetUsers = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, methodGetUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetUsers);
            var result2 = this.GetResultOfMethod<string>(MethodGetUsers, parametersOfGetUsers, methodGetUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUsers.ShouldBeNull();
            methodGetUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            Type [] methodGetUsersParametersTypes = null;
            object[] parametersOfGetUsers = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUsers, parametersOfGetUsers, methodGetUsersParametersTypes);

            // Assert
            parametersOfGetUsers.ShouldBeNull();
            methodGetUsersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            Type [] methodGetUsersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            Type [] methodGetUsersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTreeForMobile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetUserTreeForMobile_Method_Call_Internally(Type[] types)
        {
            var methodGetUserTreeForMobileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserTreeForMobile, methodGetUserTreeForMobileParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserTreeForMobile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserTreeForMobile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeForMobile);

            // Act
            Action executeAction = () => _domainDataInstance.GetUserTreeForMobile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserTreeForMobile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserTreeForMobile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeForMobile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetUserTreeForMobile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTreeForMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserTreeForMobile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeForMobile);
            Type [] methodGetUserTreeForMobileParametersTypes = null;
            object[] parametersOfGetUserTreeForMobile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTreeForMobile, methodGetUserTreeForMobileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetUserTreeForMobile);
            var result2 = this.GetResultOfMethod<string>(MethodGetUserTreeForMobile, parametersOfGetUserTreeForMobile, methodGetUserTreeForMobileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserTreeForMobile.ShouldBeNull();
            methodGetUserTreeForMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTreeForMobile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserTreeForMobile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeForMobile);
            Type [] methodGetUserTreeForMobileParametersTypes = null;
            object[] parametersOfGetUserTreeForMobile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUserTreeForMobile, parametersOfGetUserTreeForMobile, methodGetUserTreeForMobileParametersTypes);

            // Assert
            parametersOfGetUserTreeForMobile.ShouldBeNull();
            methodGetUserTreeForMobileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserTreeForMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserTreeForMobile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeForMobile);
            Type [] methodGetUserTreeForMobileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserTreeForMobile, methodGetUserTreeForMobileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserTreeForMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTreeForMobile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserTreeForMobile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeForMobile);
            Type [] methodGetUserTreeForMobileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserTreeForMobile, methodGetUserTreeForMobileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserTreeForMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTreeForMobile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserTreeForMobile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTreeForMobile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetUsersAndGroups_Method_Call_Internally(Type[] types)
        {
            var methodGetUsersAndGroupsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsersAndGroups_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);

            // Act
            Action executeAction = () => _domainDataInstance.GetUsersAndGroups();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsersAndGroups_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetUsersAndGroups();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsersAndGroups_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            Type [] methodGetUsersAndGroupsParametersTypes = null;
            object[] parametersOfGetUsersAndGroups = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetUsersAndGroups);
            var result2 = this.GetResultOfMethod<string>(MethodGetUsersAndGroups, parametersOfGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUsersAndGroups.ShouldBeNull();
            methodGetUsersAndGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsersAndGroups_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            Type [] methodGetUsersAndGroupsParametersTypes = null;
            object[] parametersOfGetUsersAndGroups = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUsersAndGroups, parametersOfGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            parametersOfGetUsersAndGroups.ShouldBeNull();
            methodGetUsersAndGroupsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            Type [] methodGetUsersAndGroupsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUsersAndGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            Type [] methodGetUsersAndGroupsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUsersAndGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsersAndGroups, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetKeywords) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetKeywords_Method_Call_Internally(Type[] types)
        {
            var methodGetKeywordsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetKeywords, methodGetKeywordsParametersTypes);
        }

        #endregion

        #region Method Call : (GetKeywords) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetKeywords_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetKeywords);

            // Act
            Action executeAction = () => _domainDataInstance.GetKeywords();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetKeywords) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetKeywords_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetKeywords);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetKeywords();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetKeywords) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetKeywords_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetKeywords);
            Type [] methodGetKeywordsParametersTypes = null;
            object[] parametersOfGetKeywords = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetKeywords, methodGetKeywordsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetKeywords);
            var result2 = this.GetResultOfMethod<string>(MethodGetKeywords, parametersOfGetKeywords, methodGetKeywordsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetKeywords.ShouldBeNull();
            methodGetKeywordsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetKeywords) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetKeywords_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetKeywords);
            Type [] methodGetKeywordsParametersTypes = null;
            object[] parametersOfGetKeywords = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetKeywords, parametersOfGetKeywords, methodGetKeywordsParametersTypes);

            // Assert
            parametersOfGetKeywords.ShouldBeNull();
            methodGetKeywordsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetKeywords) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetKeywords_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetKeywords);
            Type [] methodGetKeywordsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetKeywords, methodGetKeywordsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetKeywordsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetKeywords) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetKeywords_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetKeywords);
            Type [] methodGetKeywordsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetKeywords, methodGetKeywordsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetKeywordsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetKeywords) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetKeywords_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetKeywords);
            var currentMethodInfo = this.GetMethodInfo(MethodGetKeywords, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductGroups) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetProductGroups_Method_Call_Internally(Type[] types)
        {
            var methodGetProductGroupsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductGroups, methodGetProductGroupsParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductGroups) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductGroups_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductGroups);

            // Act
            Action executeAction = () => _domainDataInstance.GetProductGroups();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProductGroups) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductGroups_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductGroups);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetProductGroups();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductGroups_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductGroups);
            Type [] methodGetProductGroupsParametersTypes = null;
            object[] parametersOfGetProductGroups = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductGroups, methodGetProductGroupsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetProductGroups);
            var result2 = this.GetResultOfMethod<string>(MethodGetProductGroups, parametersOfGetProductGroups, methodGetProductGroupsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProductGroups.ShouldBeNull();
            methodGetProductGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductGroups) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductGroups_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductGroups);
            Type [] methodGetProductGroupsParametersTypes = null;
            object[] parametersOfGetProductGroups = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetProductGroups, parametersOfGetProductGroups, methodGetProductGroupsParametersTypes);

            // Assert
            parametersOfGetProductGroups.ShouldBeNull();
            methodGetProductGroupsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductGroups_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductGroups);
            Type [] methodGetProductGroupsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProductGroups, methodGetProductGroupsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductGroups) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductGroups_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductGroups);
            Type [] methodGetProductGroupsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductGroups, methodGetProductGroupsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductGroups) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProductGroups_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductGroups, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetProducts_Method_Call_Internally(Type[] types)
        {
            var methodGetProductsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProducts, methodGetProductsParametersTypes);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProducts_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);

            // Act
            Action executeAction = () => _domainDataInstance.GetProducts();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProducts_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetProducts();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProducts_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            Type [] methodGetProductsParametersTypes = null;
            object[] parametersOfGetProducts = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProducts, methodGetProductsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetProducts);
            var result2 = this.GetResultOfMethod<string>(MethodGetProducts, parametersOfGetProducts, methodGetProductsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProducts.ShouldBeNull();
            methodGetProductsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProducts_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            Type [] methodGetProductsParametersTypes = null;
            object[] parametersOfGetProducts = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetProducts, parametersOfGetProducts, methodGetProductsParametersTypes);

            // Assert
            parametersOfGetProducts.ShouldBeNull();
            methodGetProductsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProducts_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            Type [] methodGetProductsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProducts, methodGetProductsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProducts_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            Type [] methodGetProductsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProducts, methodGetProductsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetProducts_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProducts, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScripts) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetScripts_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScripts, methodGetScriptsParametersTypes);
        }

        #endregion

        #region Method Call : (GetScripts) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetScripts_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScripts);

            // Act
            Action executeAction = () => _domainDataInstance.GetScripts();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScripts) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetScripts_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScripts);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetScripts();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScripts) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetScripts_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScripts);
            Type [] methodGetScriptsParametersTypes = null;
            object[] parametersOfGetScripts = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScripts, methodGetScriptsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetScripts);
            var result2 = this.GetResultOfMethod<string>(MethodGetScripts, parametersOfGetScripts, methodGetScriptsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScripts.ShouldBeNull();
            methodGetScriptsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScripts) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetScripts_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScripts);
            Type [] methodGetScriptsParametersTypes = null;
            object[] parametersOfGetScripts = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetScripts, parametersOfGetScripts, methodGetScriptsParametersTypes);

            // Assert
            parametersOfGetScripts.ShouldBeNull();
            methodGetScriptsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScripts) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetScripts_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScripts);
            Type [] methodGetScriptsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScripts, methodGetScriptsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScripts) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetScripts_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScripts);
            Type [] methodGetScriptsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScripts, methodGetScriptsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScripts) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetScripts_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScripts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScripts, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodes) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetTrackingCodes_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCodesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCodes, methodGetTrackingCodesParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCodes) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodes_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodes);

            // Act
            Action executeAction = () => _domainDataInstance.GetTrackingCodes();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCodes) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodes_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodes);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetTrackingCodes();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodes) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodes_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodes);
            Type [] methodGetTrackingCodesParametersTypes = null;
            object[] parametersOfGetTrackingCodes = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCodes, methodGetTrackingCodesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetTrackingCodes);
            var result2 = this.GetResultOfMethod<string>(MethodGetTrackingCodes, parametersOfGetTrackingCodes, methodGetTrackingCodesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingCodes.ShouldBeNull();
            methodGetTrackingCodesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodes) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodes_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodes);
            Type [] methodGetTrackingCodesParametersTypes = null;
            object[] parametersOfGetTrackingCodes = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTrackingCodes, parametersOfGetTrackingCodes, methodGetTrackingCodesParametersTypes);

            // Assert
            parametersOfGetTrackingCodes.ShouldBeNull();
            methodGetTrackingCodesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCodes) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodes_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodes);
            Type [] methodGetTrackingCodesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCodes, methodGetTrackingCodesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingCodesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodes) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodes_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodes);
            Type [] methodGetTrackingCodesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCodes, methodGetTrackingCodesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCodesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodes) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodes_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodes);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCodes, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodeTypes) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetTrackingCodeTypes_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCodeTypesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCodeTypes, methodGetTrackingCodeTypesParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCodeTypes) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodeTypes_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodeTypes);

            // Act
            Action executeAction = () => _domainDataInstance.GetTrackingCodeTypes();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCodeTypes) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodeTypes_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodeTypes);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetTrackingCodeTypes();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodeTypes) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodeTypes_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodeTypes);
            Type [] methodGetTrackingCodeTypesParametersTypes = null;
            object[] parametersOfGetTrackingCodeTypes = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCodeTypes, methodGetTrackingCodeTypesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetTrackingCodeTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetTrackingCodeTypes, parametersOfGetTrackingCodeTypes, methodGetTrackingCodeTypesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingCodeTypes.ShouldBeNull();
            methodGetTrackingCodeTypesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodeTypes) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodeTypes_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodeTypes);
            Type [] methodGetTrackingCodeTypesParametersTypes = null;
            object[] parametersOfGetTrackingCodeTypes = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTrackingCodeTypes, parametersOfGetTrackingCodeTypes, methodGetTrackingCodeTypesParametersTypes);

            // Assert
            parametersOfGetTrackingCodeTypes.ShouldBeNull();
            methodGetTrackingCodeTypesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCodeTypes) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodeTypes_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodeTypes);
            Type [] methodGetTrackingCodeTypesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCodeTypes, methodGetTrackingCodeTypesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingCodeTypesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodeTypes) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodeTypes_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodeTypes);
            Type [] methodGetTrackingCodeTypesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCodeTypes, methodGetTrackingCodeTypesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCodeTypesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCodeTypes) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetTrackingCodeTypes_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCodeTypes);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCodeTypes, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResourcePermission) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetResourcePermission_Method_Call_Internally(Type[] types)
        {
            var methodGetResourcePermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResourcePermission, methodGetResourcePermissionParametersTypes);
        }

        #endregion

        #region Method Call : (GetResourcePermission) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResourcePermission_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourcePermission);

            // Act
            Action executeAction = () => _domainDataInstance.GetResourcePermission();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResourcePermission) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResourcePermission_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourcePermission);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetResourcePermission();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResourcePermission) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResourcePermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourcePermission);
            Type [] methodGetResourcePermissionParametersTypes = null;
            object[] parametersOfGetResourcePermission = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResourcePermission, methodGetResourcePermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetResourcePermission);
            var result2 = this.GetResultOfMethod<string>(MethodGetResourcePermission, parametersOfGetResourcePermission, methodGetResourcePermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResourcePermission.ShouldBeNull();
            methodGetResourcePermissionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResourcePermission) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResourcePermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourcePermission);
            Type [] methodGetResourcePermissionParametersTypes = null;
            object[] parametersOfGetResourcePermission = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetResourcePermission, parametersOfGetResourcePermission, methodGetResourcePermissionParametersTypes);

            // Assert
            parametersOfGetResourcePermission.ShouldBeNull();
            methodGetResourcePermissionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResourcePermission) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResourcePermission_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourcePermission);
            Type [] methodGetResourcePermissionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResourcePermission, methodGetResourcePermissionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResourcePermissionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResourcePermission) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResourcePermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourcePermission);
            Type [] methodGetResourcePermissionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResourcePermission, methodGetResourcePermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResourcePermissionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResourcePermission) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResourcePermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourcePermission);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResourcePermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountries) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCountries_Method_Call_Internally(Type[] types)
        {
            var methodGetCountriesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCountries, methodGetCountriesParametersTypes);
        }

        #endregion

        #region Method Call : (GetCountries) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountries_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountries);

            // Act
            Action executeAction = () => _domainDataInstance.GetCountries();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCountries) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountries_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountries);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCountries();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountries) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountries_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountries);
            Type [] methodGetCountriesParametersTypes = null;
            object[] parametersOfGetCountries = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountries, methodGetCountriesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCountries);
            var result2 = this.GetResultOfMethod<string>(MethodGetCountries, parametersOfGetCountries, methodGetCountriesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCountries.ShouldBeNull();
            methodGetCountriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountries) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountries_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountries);
            Type [] methodGetCountriesParametersTypes = null;
            object[] parametersOfGetCountries = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCountries, parametersOfGetCountries, methodGetCountriesParametersTypes);

            // Assert
            parametersOfGetCountries.ShouldBeNull();
            methodGetCountriesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountries) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountries_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountries);
            Type [] methodGetCountriesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountries, methodGetCountriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCountriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountries) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountries);
            Type [] methodGetCountriesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCountries, methodGetCountriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCountriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountries) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountries_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountries);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountries, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyFamily) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCompanyFamily_Method_Call_Internally(Type[] types)
        {
            var methodGetCompanyFamilyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCompanyFamily, methodGetCompanyFamilyParametersTypes);
        }

        #endregion

        #region Method Call : (GetCompanyFamily) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyFamily_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyFamily);

            // Act
            Action executeAction = () => _domainDataInstance.GetCompanyFamily();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCompanyFamily) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyFamily_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyFamily);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCompanyFamily();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyFamily) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyFamily_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyFamily);
            Type [] methodGetCompanyFamilyParametersTypes = null;
            object[] parametersOfGetCompanyFamily = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanyFamily, methodGetCompanyFamilyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCompanyFamily);
            var result2 = this.GetResultOfMethod<string>(MethodGetCompanyFamily, parametersOfGetCompanyFamily, methodGetCompanyFamilyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCompanyFamily.ShouldBeNull();
            methodGetCompanyFamilyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyFamily) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyFamily_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyFamily);
            Type [] methodGetCompanyFamilyParametersTypes = null;
            object[] parametersOfGetCompanyFamily = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCompanyFamily, parametersOfGetCompanyFamily, methodGetCompanyFamilyParametersTypes);

            // Assert
            parametersOfGetCompanyFamily.ShouldBeNull();
            methodGetCompanyFamilyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCompanyFamily) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyFamily_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyFamily);
            Type [] methodGetCompanyFamilyParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCompanyFamily, methodGetCompanyFamilyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCompanyFamilyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyFamily) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyFamily_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyFamily);
            Type [] methodGetCompanyFamilyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCompanyFamily, methodGetCompanyFamilyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCompanyFamilyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCompanyFamily) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCompanyFamily_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCompanyFamily);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCompanyFamily, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeywords) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetRecentKeywords_Method_Call_Internally(Type[] types)
        {
            var methodGetRecentKeywordsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRecentKeywords, methodGetRecentKeywordsParametersTypes);
        }

        #endregion

        #region Method Call : (GetRecentKeywords) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRecentKeywords_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeywords);

            // Act
            Action executeAction = () => _domainDataInstance.GetRecentKeywords();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRecentKeywords) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRecentKeywords_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeywords);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetRecentKeywords();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeywords) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRecentKeywords_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeywords);
            Type [] methodGetRecentKeywordsParametersTypes = null;
            object[] parametersOfGetRecentKeywords = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecentKeywords, methodGetRecentKeywordsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetRecentKeywords);
            var result2 = this.GetResultOfMethod<string>(MethodGetRecentKeywords, parametersOfGetRecentKeywords, methodGetRecentKeywordsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRecentKeywords.ShouldBeNull();
            methodGetRecentKeywordsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeywords) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRecentKeywords_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeywords);
            Type [] methodGetRecentKeywordsParametersTypes = null;
            object[] parametersOfGetRecentKeywords = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRecentKeywords, parametersOfGetRecentKeywords, methodGetRecentKeywordsParametersTypes);

            // Assert
            parametersOfGetRecentKeywords.ShouldBeNull();
            methodGetRecentKeywordsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRecentKeywords) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRecentKeywords_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeywords);
            Type [] methodGetRecentKeywordsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRecentKeywords, methodGetRecentKeywordsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRecentKeywordsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeywords) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRecentKeywords_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeywords);
            Type [] methodGetRecentKeywordsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRecentKeywords, methodGetRecentKeywordsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRecentKeywordsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeywords) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRecentKeywords_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeywords);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecentKeywords, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomCache) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCustomCache_Method_Call_Internally(Type[] types)
        {
            var methodGetCustomCacheParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCustomCache, methodGetCustomCacheParametersTypes);
        }

        #endregion

        #region Method Call : (GetCustomCache) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCustomCache_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomCache);

            // Act
            Action executeAction = () => _domainDataInstance.GetCustomCache();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCustomCache) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCustomCache_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomCache);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetCustomCache();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomCache) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCustomCache_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomCache);
            Type [] methodGetCustomCacheParametersTypes = null;
            object[] parametersOfGetCustomCache = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomCache, methodGetCustomCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCustomCache);
            var result2 = this.GetResultOfMethod<string>(MethodGetCustomCache, parametersOfGetCustomCache, methodGetCustomCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCustomCache.ShouldBeNull();
            methodGetCustomCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomCache) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCustomCache_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomCache);
            Type [] methodGetCustomCacheParametersTypes = null;
            object[] parametersOfGetCustomCache = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCustomCache, parametersOfGetCustomCache, methodGetCustomCacheParametersTypes);

            // Assert
            parametersOfGetCustomCache.ShouldBeNull();
            methodGetCustomCacheParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCustomCache) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCustomCache_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomCache);
            Type [] methodGetCustomCacheParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCustomCache, methodGetCustomCacheParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCustomCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomCache) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCustomCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomCache);
            Type [] methodGetCustomCacheParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCustomCache, methodGetCustomCacheParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCustomCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomCache) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCustomCache_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomCache, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionGroup) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetResultActionGroup_Method_Call_Internally(Type[] types)
        {
            var methodGetResultActionGroupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultActionGroup, methodGetResultActionGroupParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultActionGroup) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroup);

            // Act
            Action executeAction = () => _domainDataInstance.GetResultActionGroup();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResultActionGroup) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroup);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetResultActionGroup();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroup);
            Type [] methodGetResultActionGroupParametersTypes = null;
            object[] parametersOfGetResultActionGroup = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionGroup, methodGetResultActionGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetResultActionGroup);
            var result2 = this.GetResultOfMethod<string>(MethodGetResultActionGroup, parametersOfGetResultActionGroup, methodGetResultActionGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResultActionGroup.ShouldBeNull();
            methodGetResultActionGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionGroup) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroup);
            Type [] methodGetResultActionGroupParametersTypes = null;
            object[] parametersOfGetResultActionGroup = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetResultActionGroup, parametersOfGetResultActionGroup, methodGetResultActionGroupParametersTypes);

            // Assert
            parametersOfGetResultActionGroup.ShouldBeNull();
            methodGetResultActionGroupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultActionGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroup);
            Type [] methodGetResultActionGroupParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultActionGroup, methodGetResultActionGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultActionGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionGroup) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroup);
            Type [] methodGetResultActionGroupParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultActionGroup, methodGetResultActionGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultActionGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionGroup) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionGroup_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionGroup, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionItem) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetResultActionItem_Method_Call_Internally(Type[] types)
        {
            var methodGetResultActionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultActionItem, methodGetResultActionItemParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultActionItem) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItem);

            // Act
            Action executeAction = () => _domainDataInstance.GetResultActionItem();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResultActionItem) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionItem_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItem);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetResultActionItem();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionItem) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionItem_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItem);
            Type [] methodGetResultActionItemParametersTypes = null;
            object[] parametersOfGetResultActionItem = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionItem, methodGetResultActionItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetResultActionItem);
            var result2 = this.GetResultOfMethod<string>(MethodGetResultActionItem, parametersOfGetResultActionItem, methodGetResultActionItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResultActionItem.ShouldBeNull();
            methodGetResultActionItemParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionItem) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionItem_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItem);
            Type [] methodGetResultActionItemParametersTypes = null;
            object[] parametersOfGetResultActionItem = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetResultActionItem, parametersOfGetResultActionItem, methodGetResultActionItemParametersTypes);

            // Assert
            parametersOfGetResultActionItem.ShouldBeNull();
            methodGetResultActionItemParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultActionItem) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionItem_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItem);
            Type [] methodGetResultActionItemParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultActionItem, methodGetResultActionItemParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultActionItemParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionItem) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItem);
            Type [] methodGetResultActionItemParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultActionItem, methodGetResultActionItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultActionItemParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionItem) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetResultActionItem_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertGroupNodesToAttribute) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_convertGroupNodesToAttribute_Method_Call_Internally(Type[] types)
        {
            var methodconvertGroupNodesToAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconvertGroupNodesToAttribute, methodconvertGroupNodesToAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (convertGroupNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertGroupNodesToAttribute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertGroupNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodconvertGroupNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertGroupNodesToAttribute = { xmlString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodconvertGroupNodesToAttribute, methodconvertGroupNodesToAttributeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_domainDataInstanceFixture, parametersOfconvertGroupNodesToAttribute);
            var result2 = this.GetResultOfMethod<XElement>(MethodconvertGroupNodesToAttribute, parametersOfconvertGroupNodesToAttribute, methodconvertGroupNodesToAttributeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfconvertGroupNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertGroupNodesToAttribute.Length.ShouldBe(1);
            methodconvertGroupNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertGroupNodesToAttribute) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertGroupNodesToAttribute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertGroupNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodconvertGroupNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertGroupNodesToAttribute = { xmlString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodconvertGroupNodesToAttribute, parametersOfconvertGroupNodesToAttribute, methodconvertGroupNodesToAttributeParametersTypes);

            // Assert
            parametersOfconvertGroupNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertGroupNodesToAttribute.Length.ShouldBe(1);
            methodconvertGroupNodesToAttributeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (convertGroupNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertGroupNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertGroupNodesToAttribute);
            var methodconvertGroupNodesToAttributeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconvertGroupNodesToAttribute, methodconvertGroupNodesToAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodconvertGroupNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertGroupNodesToAttribute) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertGroupNodesToAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertGroupNodesToAttribute);
            var methodconvertGroupNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconvertGroupNodesToAttribute, methodconvertGroupNodesToAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconvertGroupNodesToAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertGroupNodesToAttribute) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertGroupNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertGroupNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertGroupNodesToAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertGroupNodesToAttribute) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertGroupNodesToAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertGroupNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertGroupNodesToAttribute, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertUserNodesToAttribute) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_convertUserNodesToAttribute_Method_Call_Internally(Type[] types)
        {
            var methodconvertUserNodesToAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconvertUserNodesToAttribute, methodconvertUserNodesToAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (convertUserNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertUserNodesToAttribute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertUserNodesToAttribute);
            var usersXmlString = this.CreateType<string>();
            var methodconvertUserNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertUserNodesToAttribute = { usersXmlString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodconvertUserNodesToAttribute, methodconvertUserNodesToAttributeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_domainDataInstanceFixture, parametersOfconvertUserNodesToAttribute);
            var result2 = this.GetResultOfMethod<XElement>(MethodconvertUserNodesToAttribute, parametersOfconvertUserNodesToAttribute, methodconvertUserNodesToAttributeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfconvertUserNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertUserNodesToAttribute.Length.ShouldBe(1);
            methodconvertUserNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertUserNodesToAttribute) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertUserNodesToAttribute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertUserNodesToAttribute);
            var usersXmlString = this.CreateType<string>();
            var methodconvertUserNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertUserNodesToAttribute = { usersXmlString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodconvertUserNodesToAttribute, parametersOfconvertUserNodesToAttribute, methodconvertUserNodesToAttributeParametersTypes);

            // Assert
            parametersOfconvertUserNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertUserNodesToAttribute.Length.ShouldBe(1);
            methodconvertUserNodesToAttributeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (convertUserNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertUserNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertUserNodesToAttribute);
            var methodconvertUserNodesToAttributeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconvertUserNodesToAttribute, methodconvertUserNodesToAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodconvertUserNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertUserNodesToAttribute) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertUserNodesToAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertUserNodesToAttribute);
            var methodconvertUserNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconvertUserNodesToAttribute, methodconvertUserNodesToAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconvertUserNodesToAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertUserNodesToAttribute) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertUserNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertUserNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertUserNodesToAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertUserNodesToAttribute) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_convertUserNodesToAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertUserNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertUserNodesToAttribute, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetGroups_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetGroupsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetGroups, methodGetGroupsParametersTypes);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            var parentGroupId = this.CreateType<string>();
            var methodGetGroupsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetGroups = { parentGroupId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGroups, methodGetGroupsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetGroups);
            var result2 = this.GetResultOfMethod<string>(MethodGetGroups, parametersOfGetGroups, methodGetGroupsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetGroups.ShouldNotBeNull();
            parametersOfGetGroups.Length.ShouldBe(1);
            methodGetGroupsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            var parentGroupId = this.CreateType<string>();
            var methodGetGroupsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetGroups = { parentGroupId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetGroups, parametersOfGetGroups, methodGetGroupsParametersTypes);

            // Assert
            parametersOfGetGroups.ShouldNotBeNull();
            parametersOfGetGroups.Length.ShouldBe(1);
            methodGetGroupsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            var methodGetGroupsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGroups, methodGetGroupsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetGroupsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            var methodGetGroupsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGroups, methodGetGroupsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGroupsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGroups, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroups) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetGroups_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGroups, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetUsers_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var parentGroupId = this.CreateType<string>();
            var methodGetUsersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUsers = { parentGroupId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, methodGetUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetUsers);
            var result2 = this.GetResultOfMethod<string>(MethodGetUsers, parametersOfGetUsers, methodGetUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUsers.ShouldNotBeNull();
            parametersOfGetUsers.Length.ShouldBe(1);
            methodGetUsersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var parentGroupId = this.CreateType<string>();
            var methodGetUsersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUsers = { parentGroupId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUsers, parametersOfGetUsers, methodGetUsersParametersTypes);

            // Assert
            parametersOfGetUsers.ShouldNotBeNull();
            parametersOfGetUsers.Length.ShouldBe(1);
            methodGetUsersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var methodGetUsersParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUsersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var methodGetUsersParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUsersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUsers_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveUsers) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_ResolveUsers_Method_Call_Internally(Type[] types)
        {
            var methodResolveUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolveUsers, methodResolveUsersParametersTypes);
        }

        #endregion

        #region Method Call : (ResolveUsers) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ResolveUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveUsers);
            var result = this.CreateType<XmlDocument>();
            var searchString = this.CreateType<string>();
            var methodResolveUsersParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfResolveUsers = { result, searchString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodResolveUsers, methodResolveUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlDocument>(_domainDataInstanceFixture, parametersOfResolveUsers);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodResolveUsers, parametersOfResolveUsers, methodResolveUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResolveUsers.ShouldNotBeNull();
            parametersOfResolveUsers.Length.ShouldBe(2);
            methodResolveUsersParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ResolveUsers) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ResolveUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveUsers);
            var result = this.CreateType<XmlDocument>();
            var searchString = this.CreateType<string>();
            var methodResolveUsersParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfResolveUsers = { result, searchString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodResolveUsers, parametersOfResolveUsers, methodResolveUsersParametersTypes);

            // Assert
            parametersOfResolveUsers.ShouldNotBeNull();
            parametersOfResolveUsers.Length.ShouldBe(2);
            methodResolveUsersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolveUsers) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ResolveUsers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveUsers);
            var methodResolveUsersParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolveUsers, methodResolveUsersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResolveUsersParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ResolveUsers) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ResolveUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveUsers);
            var methodResolveUsersParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolveUsers, methodResolveUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolveUsersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResolveUsers) (Return Type : XmlDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ResolveUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveUsers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolveUsers) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ResolveUsers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolveUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodResolveUsers, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateGroupName) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_UpdateGroupName_Method_Call_Internally(Type[] types)
        {
            var methodUpdateGroupNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateGroupName, methodUpdateGroupNameParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateGroupName) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_UpdateGroupName_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGroupName);
            var resolvedUsersDocument = this.CreateType<XmlDocument>();
            var methodUpdateGroupNameParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfUpdateGroupName = { resolvedUsersDocument };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateGroupName, methodUpdateGroupNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_domainDataInstanceFixture, parametersOfUpdateGroupName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateGroupName.ShouldNotBeNull();
            parametersOfUpdateGroupName.Length.ShouldBe(1);
            methodUpdateGroupNameParametersTypes.Length.ShouldBe(1);
            methodUpdateGroupNameParametersTypes.Length.ShouldBe(parametersOfUpdateGroupName.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGroupName) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_UpdateGroupName_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGroupName);
            var resolvedUsersDocument = this.CreateType<XmlDocument>();
            var methodUpdateGroupNameParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfUpdateGroupName = { resolvedUsersDocument };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateGroupName, parametersOfUpdateGroupName, methodUpdateGroupNameParametersTypes);

            // Assert
            parametersOfUpdateGroupName.ShouldNotBeNull();
            parametersOfUpdateGroupName.Length.ShouldBe(1);
            methodUpdateGroupNameParametersTypes.Length.ShouldBe(1);
            methodUpdateGroupNameParametersTypes.Length.ShouldBe(parametersOfUpdateGroupName.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGroupName) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_UpdateGroupName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGroupName);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateGroupName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateGroupName) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_UpdateGroupName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGroupName);
            var methodUpdateGroupNameParametersTypes = new Type[] { typeof(XmlDocument) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateGroupName, methodUpdateGroupNameParametersTypes);

            // Assert
            methodUpdateGroupNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateGroupName) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_UpdateGroupName_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateGroupName);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateGroupName, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertNodesToAttribute) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_ConvertNodesToAttribute_Method_Call_Internally(Type[] types)
        {
            var methodConvertNodesToAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertNodesToAttribute, methodConvertNodesToAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertNodesToAttribute) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ConvertNodesToAttribute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodConvertNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConvertNodesToAttribute = { xmlString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertNodesToAttribute, methodConvertNodesToAttributeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlDocument>(_domainDataInstanceFixture, parametersOfConvertNodesToAttribute);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodConvertNodesToAttribute, parametersOfConvertNodesToAttribute, methodConvertNodesToAttributeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConvertNodesToAttribute.ShouldNotBeNull();
            parametersOfConvertNodesToAttribute.Length.ShouldBe(1);
            methodConvertNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertNodesToAttribute) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ConvertNodesToAttribute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodConvertNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConvertNodesToAttribute = { xmlString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodConvertNodesToAttribute, parametersOfConvertNodesToAttribute, methodConvertNodesToAttributeParametersTypes);

            // Assert
            parametersOfConvertNodesToAttribute.ShouldNotBeNull();
            parametersOfConvertNodesToAttribute.Length.ShouldBe(1);
            methodConvertNodesToAttributeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertNodesToAttribute) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ConvertNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertNodesToAttribute);
            var methodConvertNodesToAttributeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertNodesToAttribute, methodConvertNodesToAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConvertNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertNodesToAttribute) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ConvertNodesToAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertNodesToAttribute);
            var methodConvertNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertNodesToAttribute, methodConvertNodesToAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertNodesToAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertNodesToAttribute) (Return Type : XmlDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ConvertNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertNodesToAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertNodesToAttribute) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_ConvertNodesToAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertNodesToAttribute, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountryDesc) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetCountryDesc_Method_Call_Internally(Type[] types)
        {
            var methodGetCountryDescParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCountryDesc, methodGetCountryDescParametersTypes);
        }

        #endregion

        #region Method Call : (GetCountryDesc) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDesc_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDesc);
            var countryCode = this.CreateType<string>();
            var methodGetCountryDescParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetCountryDesc = { countryCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryDesc, methodGetCountryDescParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetCountryDesc);
            var result2 = this.GetResultOfMethod<string>(MethodGetCountryDesc, parametersOfGetCountryDesc, methodGetCountryDescParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCountryDesc.ShouldNotBeNull();
            parametersOfGetCountryDesc.Length.ShouldBe(1);
            methodGetCountryDescParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountryDesc) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDesc_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDesc);
            var countryCode = this.CreateType<string>();
            var methodGetCountryDescParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetCountryDesc = { countryCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCountryDesc, parametersOfGetCountryDesc, methodGetCountryDescParametersTypes);

            // Assert
            parametersOfGetCountryDesc.ShouldNotBeNull();
            parametersOfGetCountryDesc.Length.ShouldBe(1);
            methodGetCountryDescParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountryDesc) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDesc_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDesc);
            var methodGetCountryDescParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountryDesc, methodGetCountryDescParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCountryDescParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountryDesc) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDesc_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDesc);
            var methodGetCountryDescParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCountryDesc, methodGetCountryDescParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCountryDescParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountryDesc) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDesc_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDesc);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryDesc, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountryDesc) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetCountryDesc_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryDesc);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryDesc, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegionName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetRegionName_Method_Call_Internally(Type[] types)
        {
            var methodGetRegionNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRegionName, methodGetRegionNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetRegionName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegionName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionName);
            var regionCode = this.CreateType<string>();
            var countryCode = this.CreateType<string>();
            var methodGetRegionNameParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetRegionName = { regionCode, countryCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionName, methodGetRegionNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetRegionName);
            var result2 = this.GetResultOfMethod<string>(MethodGetRegionName, parametersOfGetRegionName, methodGetRegionNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRegionName.ShouldNotBeNull();
            parametersOfGetRegionName.Length.ShouldBe(2);
            methodGetRegionNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetRegionName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegionName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionName);
            var regionCode = this.CreateType<string>();
            var countryCode = this.CreateType<string>();
            var methodGetRegionNameParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetRegionName = { regionCode, countryCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRegionName, parametersOfGetRegionName, methodGetRegionNameParametersTypes);

            // Assert
            parametersOfGetRegionName.ShouldNotBeNull();
            parametersOfGetRegionName.Length.ShouldBe(2);
            methodGetRegionNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegionName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegionName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionName);
            var methodGetRegionNameParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRegionName, methodGetRegionNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRegionNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetRegionName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegionName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionName);
            var methodGetRegionNameParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRegionName, methodGetRegionNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRegionNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegionName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegionName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegionName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetRegionName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionName, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameterDesc) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetParameterDesc_Method_Call_Internally(Type[] types)
        {
            var methodGetParameterDescParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParameterDesc, methodGetParameterDescParametersTypes);
        }

        #endregion

        #region Method Call : (GetParameterDesc) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetParameterDesc_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDesc);
            var referenceParameterdid = this.CreateType<int>();
            var methodGetParameterDescParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetParameterDesc = { referenceParameterdid };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDesc, methodGetParameterDescParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetParameterDesc);
            var result2 = this.GetResultOfMethod<string>(MethodGetParameterDesc, parametersOfGetParameterDesc, methodGetParameterDescParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetParameterDesc.ShouldNotBeNull();
            parametersOfGetParameterDesc.Length.ShouldBe(1);
            methodGetParameterDescParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameterDesc) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetParameterDesc_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDesc);
            var referenceParameterdid = this.CreateType<int>();
            var methodGetParameterDescParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetParameterDesc = { referenceParameterdid };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetParameterDesc, parametersOfGetParameterDesc, methodGetParameterDescParametersTypes);

            // Assert
            parametersOfGetParameterDesc.ShouldNotBeNull();
            parametersOfGetParameterDesc.Length.ShouldBe(1);
            methodGetParameterDescParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameterDesc) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetParameterDesc_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDesc);
            var methodGetParameterDescParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParameterDesc, methodGetParameterDescParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParameterDescParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameterDesc) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetParameterDesc_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDesc);
            var methodGetParameterDescParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParameterDesc, methodGetParameterDescParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParameterDescParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameterDesc) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetParameterDesc_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDesc);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDesc, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParameterDesc) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetParameterDesc_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDesc);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDesc, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetDescriptionById_Method_Call_Internally(Type[] types)
        {
            var methodGetDescriptionByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDescriptionById, methodGetDescriptionByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDescriptionById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionById);
            var id = this.CreateType<string>();
            var domainName = this.CreateType<string>();
            var parentId = this.CreateType<string>();

            // Act
            Action executeAction = () => _domainDataInstance.GetDescriptionById(id, domainName, parentId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDescriptionById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionById);
            var id = this.CreateType<string>();
            var domainName = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetDescriptionById(id, domainName, parentId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDescriptionById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionById);
            var id = this.CreateType<string>();
            var domainName = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var methodGetDescriptionByIdParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetDescriptionById = { id, domainName, parentId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionById, methodGetDescriptionByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetDescriptionById);
            var result2 = this.GetResultOfMethod<string>(MethodGetDescriptionById, parametersOfGetDescriptionById, methodGetDescriptionByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDescriptionById.ShouldNotBeNull();
            parametersOfGetDescriptionById.Length.ShouldBe(3);
            methodGetDescriptionByIdParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDescriptionById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionById);
            var id = this.CreateType<string>();
            var domainName = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var methodGetDescriptionByIdParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetDescriptionById = { id, domainName, parentId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDescriptionById, parametersOfGetDescriptionById, methodGetDescriptionByIdParametersTypes);

            // Assert
            parametersOfGetDescriptionById.ShouldNotBeNull();
            parametersOfGetDescriptionById.Length.ShouldBe(3);
            methodGetDescriptionByIdParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDescriptionById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionById);
            var methodGetDescriptionByIdParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDescriptionById, methodGetDescriptionByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDescriptionByIdParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDescriptionById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionById);
            var methodGetDescriptionByIdParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDescriptionById, methodGetDescriptionByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDescriptionByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDescriptionById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDescriptionById) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetDescriptionById_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionById, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetUserById_Method_Call_Internally(Type[] types)
        {
            var methodGetUserByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserById, methodGetUserByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var id = this.CreateType<string>();

            // Act
            Action executeAction = () => _domainDataInstance.GetUserById(id);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var id = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetUserById(id);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var id = this.CreateType<string>();
            var methodGetUserByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUserById = { id };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserById, methodGetUserByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetUserById);
            var result2 = this.GetResultOfMethod<string>(MethodGetUserById, parametersOfGetUserById, methodGetUserByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserById.ShouldNotBeNull();
            parametersOfGetUserById.Length.ShouldBe(1);
            methodGetUserByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var id = this.CreateType<string>();
            var methodGetUserByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUserById = { id };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUserById, parametersOfGetUserById, methodGetUserByIdParametersTypes);

            // Assert
            parametersOfGetUserById.ShouldNotBeNull();
            parametersOfGetUserById.Length.ShouldBe(1);
            methodGetUserByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var methodGetUserByIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserById, methodGetUserByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var methodGetUserByIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserById, methodGetUserByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserById) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetUserById_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserById, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DomainData_GetContactTypeById_Method_Call_Internally(Type[] types)
        {
            var methodGetContactTypeByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContactTypeById, methodGetContactTypeByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetContactTypeById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeById);
            var id = this.CreateType<string>();

            // Act
            Action executeAction = () => _domainDataInstance.GetContactTypeById(id);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetContactTypeById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeById);
            var id = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _domainDataInstance.GetContactTypeById(id);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetContactTypeById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeById);
            var id = this.CreateType<string>();
            var methodGetContactTypeByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContactTypeById = { id };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContactTypeById, methodGetContactTypeByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_domainDataInstanceFixture, parametersOfGetContactTypeById);
            var result2 = this.GetResultOfMethod<string>(MethodGetContactTypeById, parametersOfGetContactTypeById, methodGetContactTypeByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContactTypeById.ShouldNotBeNull();
            parametersOfGetContactTypeById.Length.ShouldBe(1);
            methodGetContactTypeByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetContactTypeById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeById);
            var id = this.CreateType<string>();
            var methodGetContactTypeByIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContactTypeById = { id };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContactTypeById, parametersOfGetContactTypeById, methodGetContactTypeByIdParametersTypes);

            // Assert
            parametersOfGetContactTypeById.ShouldNotBeNull();
            parametersOfGetContactTypeById.Length.ShouldBe(1);
            methodGetContactTypeByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetContactTypeById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeById);
            var methodGetContactTypeByIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContactTypeById, methodGetContactTypeByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContactTypeByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetContactTypeById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeById);
            var methodGetContactTypeByIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContactTypeById, methodGetContactTypeByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContactTypeByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetContactTypeById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContactTypeById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContactTypeById) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DomainData_GetContactTypeById_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContactTypeById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContactTypeById, 0);
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