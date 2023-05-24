using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.CMNavigatorCache" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CMNavigatorCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CMNavigatorCache" />)
        /// </summary>
        public CMNavigatorCacheTest() : base(typeof(CMNavigatorCache))
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

        #region General Initializer : Class (CMNavigatorCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _cMNavigatorCacheInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="CMNavigatorCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _cMNavigatorCacheInstanceType = typeof(CMNavigatorCache);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CMNavigatorCache) Initializer

        #region Properties

        private const string PropertyQueries = "Queries";
        private const string PropertyPreSavedRows = "PreSavedRows";

        #endregion

        #region Methods

        private const string MethodIntialize = "Intialize";
        private const string MethodGetCacheByParameterId = "GetCacheByParameterId";
        private const string MethodGetCacheByName = "GetCacheByName";
        private const string MethodGetResolutionCode1 = "GetResolutionCode1";
        private const string MethodCacheUIResources = "CacheUIResources";
        private const string MethodCacheDomainData = "CacheDomainData";
        private const string MethodReadCache = "ReadCache";
        private const string MethodGetReferenceLookup = "GetReferenceLookup";
        private const string MethodGetCountry = "GetCountry";
        private const string MethodGetRegion = "GetRegion";
        private const string MethodGetEmailPriority = "GetEmailPriority";
        private const string MethodGetAttachmentOwner = "GetAttachmentOwner";
        private const string MethodGetScriptStatus = "GetScriptStatus";
        private const string MethodGetEmailFollowup = "GetEmailFollowup";
        private const string MethodGetEmailSent = "GetEmailSent";
        private const string MethodGetEmailDraft = "GetEmailDraft";
        private const string MethodGetGender = "GetGender";
        private const string MethodUserTree = "UserTree";
        private const string MethodGetUserTreeItems = "GetUserTreeItems";
        private const string MethodScriptTree = "ScriptTree";
        private const string MethodGetScriptTreeItems = "GetScriptTreeItems";
        private const string MethodProductTree = "ProductTree";
        private const string MethodGetProductTreeItems = "GetProductTreeItems";
        private const string MethodCampaignTree = "CampaignTree";
        private const string MethodGetCampaignTreeItems = "GetCampaignTreeItems";
        private const string MethodGetCampaignPickerXML = "GetCampaignPickerXML";
        private const string MethodIsChildExists = "IsChildExists";
        private const string MethodGetAllUsersByGroupID = "GetAllUsersByGroupID";
        private const string MethodDistinct = "Distinct";

        #endregion

        #region Fields

        private const string FieldCurrentEntityResult = "CurrentEntityResult";
        private const string FieldreferenceLookups = "referenceLookups";
        private const string Fieldcountry = "country";
        private const string Fieldregion = "region";
        private const string FieldemailPriorities = "emailPriorities";
        private const string FieldscriptStatus = "scriptStatus";
        private const string FielddateOperators = "dateOperators";
        private const string Fieldoperators = "operators";
        private const string FielduserGroups = "userGroups";
        private const string Fieldusers = "users";
        private const string FieldtrackingCodeCampaign = "trackingCodeCampaign";
        private const string FieldtrackingCodeGroup = "trackingCodeGroup";
        private const string FieldtrackingCodes = "trackingCodes";
        private const string Fieldcampaign = "campaign";
        private const string Fieldproduct = "product";
        private const string FieldincidentProducts = "incidentProducts";
        private const string Fieldscript = "script";
        private const string FieldpreSavedRows = "preSavedRows";
        private const string FieldattachmentOwner = "attachmentOwner";
        private const string FieldHashCodeLookups = "HashCodeLookups";
        private const string FieldbubblepopupSettings = "bubblepopupSettings";
        private const string FieldcacheIntervalSettings = "cacheIntervalSettings";
        private const string FieldsearchNavigatorEntities = "searchNavigatorEntities";
        private const string FieldgamProfile = "gamProfile";
        private const string FieldUIResources = "UIResources";
        private const string FieldcmLog = "cmLog";
        private const string FielddependentValue = "dependentValue";

        #endregion

        #endregion

        #region General Initializer : Class (CMNavigatorCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CMNavigatorCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CMNavigatorCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CMNavigatorCache)

        #region General Initializer : Class (CMNavigatorCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CMNavigatorCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodIntialize, 0)]
        [TestCase(MethodGetCacheByParameterId, 0)]
        [TestCase(MethodGetCacheByName, 0)]
        [TestCase(MethodGetResolutionCode1, 0)]
        [TestCase(MethodGetCacheByName, 1)]
        [TestCase(MethodCacheUIResources, 0)]
        [TestCase(MethodCacheDomainData, 0)]
        [TestCase(MethodReadCache, 0)]
        [TestCase(MethodGetReferenceLookup, 0)]
        [TestCase(MethodGetCountry, 0)]
        [TestCase(MethodGetRegion, 0)]
        [TestCase(MethodGetEmailPriority, 0)]
        [TestCase(MethodGetAttachmentOwner, 0)]
        [TestCase(MethodGetScriptStatus, 0)]
        [TestCase(MethodGetEmailFollowup, 0)]
        [TestCase(MethodGetEmailSent, 0)]
        [TestCase(MethodGetEmailDraft, 0)]
        [TestCase(MethodGetGender, 0)]
        [TestCase(MethodUserTree, 0)]
        [TestCase(MethodGetUserTreeItems, 0)]
        [TestCase(MethodScriptTree, 0)]
        [TestCase(MethodGetScriptTreeItems, 0)]
        [TestCase(MethodProductTree, 0)]
        [TestCase(MethodGetProductTreeItems, 0)]
        [TestCase(MethodCampaignTree, 0)]
        [TestCase(MethodGetCampaignTreeItems, 0)]
        [TestCase(MethodGetCampaignPickerXML, 0)]
        [TestCase(MethodIsChildExists, 0)]
        [TestCase(MethodGetAllUsersByGroupID, 0)]
        [TestCase(MethodDistinct, 0)]
        public void AUT_CMNavigatorCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CMNavigatorCache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CMNavigatorCache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyQueries)]
        [TestCase(PropertyPreSavedRows)]
        [Category("AUT Property")]
        public void AUT_CMNavigatorCache_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CMNavigatorCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CMNavigatorCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldCurrentEntityResult)]
        [TestCase(FieldreferenceLookups)]
        [TestCase(Fieldcountry)]
        [TestCase(Fieldregion)]
        [TestCase(FieldemailPriorities)]
        [TestCase(FieldscriptStatus)]
        [TestCase(FielddateOperators)]
        [TestCase(Fieldoperators)]
        [TestCase(FielduserGroups)]
        [TestCase(Fieldusers)]
        [TestCase(FieldtrackingCodeCampaign)]
        [TestCase(FieldtrackingCodeGroup)]
        [TestCase(FieldtrackingCodes)]
        [TestCase(Fieldcampaign)]
        [TestCase(Fieldproduct)]
        [TestCase(FieldincidentProducts)]
        [TestCase(Fieldscript)]
        [TestCase(FieldpreSavedRows)]
        [TestCase(FieldattachmentOwner)]
        [TestCase(FieldHashCodeLookups)]
        [TestCase(FieldbubblepopupSettings)]
        [TestCase(FieldcacheIntervalSettings)]
        [TestCase(FieldsearchNavigatorEntities)]
        [TestCase(FieldgamProfile)]
        [TestCase(FieldUIResources)]
        [TestCase(FieldcmLog)]
        [TestCase(FielddependentValue)]
        [Category("AUT Fields")]
        public void AUT_CMNavigatorCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CMNavigatorCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CMNavigatorCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CMNavigatorCache_Is_Static_Type_Present_Test()
        {
            // Assert
            _cMNavigatorCacheInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Intialize) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_Intialize_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIntialize);

            // Act
            Action executeAction = () => CMNavigatorCache.Intialize();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Intialize) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_Intialize_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIntialize);
            Type [] methodIntializeParametersTypes = null;
            object[] parametersOfIntialize = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIntialize, methodIntializeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfIntialize);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIntialize.ShouldBeNull();
            methodIntializeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Intialize) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_Intialize_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIntialize);
            Type [] methodIntializeParametersTypes = null;
            object[] parametersOfIntialize = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodIntialize, parametersOfIntialize, methodIntializeParametersTypes);

            // Assert
            parametersOfIntialize.ShouldBeNull();
            methodIntializeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Intialize) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_Intialize_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIntialize);
            Type [] methodIntializeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIntialize, methodIntializeParametersTypes);

            // Assert
            methodIntializeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Intialize) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_Intialize_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIntialize);
            var currentMethodInfo = this.GetMethodInfo(MethodIntialize, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCacheByParameterIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var cacheName = this.CreateType<string>();
            var referenceId = this.CreateType<string>();

            // Act
            Action executeAction = () => CMNavigatorCache.GetCacheByParameterId(cacheName, referenceId);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var cacheName = this.CreateType<string>();
            var referenceId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = CMNavigatorCache.GetCacheByParameterId(cacheName, referenceId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var cacheName = this.CreateType<string>();
            var referenceId = this.CreateType<string>();
            var methodGetCacheByParameterIdParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetCacheByParameterId = { cacheName, referenceId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetCacheByParameterId, parametersOfGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCacheByParameterId.ShouldNotBeNull();
            parametersOfGetCacheByParameterId.Length.ShouldBe(2);
            methodGetCacheByParameterIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetCacheByParameterId, parametersOfGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes));
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var cacheName = this.CreateType<string>();
            var referenceId = this.CreateType<string>();
            var methodGetCacheByParameterIdParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetCacheByParameterId = { cacheName, referenceId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCacheByParameterId);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCacheByParameterId.ShouldNotBeNull();
            parametersOfGetCacheByParameterId.Length.ShouldBe(2);
            methodGetCacheByParameterIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var cacheName = this.CreateType<string>();
            var referenceId = this.CreateType<string>();
            var methodGetCacheByParameterIdParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetCacheByParameterId = { cacheName, referenceId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCacheByParameterId, parametersOfGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes);

            // Assert
            parametersOfGetCacheByParameterId.ShouldNotBeNull();
            parametersOfGetCacheByParameterId.Length.ShouldBe(2);
            methodGetCacheByParameterIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var methodGetCacheByParameterIdParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCacheByParameterIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var methodGetCacheByParameterIdParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheByParameterId, methodGetCacheByParameterIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheByParameterIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByParameterId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheByParameterId) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByParameterId_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByParameterId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByParameterId, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCacheByNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCacheByName, methodGetCacheByNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();

            // Act
            Action executeAction = () => CMNavigatorCache.GetCacheByName(cacheName, conditionIds);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = CMNavigatorCache.GetCacheByName(cacheName, conditionIds);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetCacheByName = { cacheName, conditionIds };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByName, methodGetCacheByNameParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCacheByName, methodGetCacheByNameParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGetCacheByName, parametersOfGetCacheByName, methodGetCacheByNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCacheByName.ShouldNotBeNull();
            parametersOfGetCacheByName.Length.ShouldBe(2);
            methodGetCacheByNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<object>(MethodGetCacheByName, parametersOfGetCacheByName, methodGetCacheByNameParametersTypes));
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetCacheByName = { cacheName, conditionIds };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByName, methodGetCacheByNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCacheByName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCacheByName.ShouldNotBeNull();
            parametersOfGetCacheByName.Length.ShouldBe(2);
            methodGetCacheByNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetCacheByName = { cacheName, conditionIds };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetCacheByName, parametersOfGetCacheByName, methodGetCacheByNameParametersTypes);

            // Assert
            parametersOfGetCacheByName.ShouldNotBeNull();
            parametersOfGetCacheByName.Length.ShouldBe(2);
            methodGetCacheByNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheByName, methodGetCacheByNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCacheByNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheByName, methodGetCacheByNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheByNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByName, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResolutionCode1) (Return Type : List<ReferenceLookup>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetResolutionCode1_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResolutionCode1ParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResolutionCode1, methodGetResolutionCode1ParametersTypes);
        }

        #endregion

        #region Method Call : (GetResolutionCode1) (Return Type : List<ReferenceLookup>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetResolutionCode1_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolutionCode1);
            var referenceName = this.CreateType<string>();
            var incidentCategoryId = this.CreateType<int>();
            var parentIds = this.CreateType<string>();
            var methodGetResolutionCode1ParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string) };
            object[] parametersOfGetResolutionCode1 = { referenceName, incidentCategoryId, parentIds };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResolutionCode1, methodGetResolutionCode1ParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetResolutionCode1, methodGetResolutionCode1ParametersTypes);
            var result2 = this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetResolutionCode1, parametersOfGetResolutionCode1, methodGetResolutionCode1ParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResolutionCode1);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResolutionCode1.ShouldNotBeNull();
            parametersOfGetResolutionCode1.Length.ShouldBe(3);
            methodGetResolutionCode1ParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetResolutionCode1) (Return Type : List<ReferenceLookup>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetResolutionCode1_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolutionCode1);
            var referenceName = this.CreateType<string>();
            var incidentCategoryId = this.CreateType<int>();
            var parentIds = this.CreateType<string>();
            var methodGetResolutionCode1ParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string) };
            object[] parametersOfGetResolutionCode1 = { referenceName, incidentCategoryId, parentIds };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetResolutionCode1, parametersOfGetResolutionCode1, methodGetResolutionCode1ParametersTypes);

            // Assert
            parametersOfGetResolutionCode1.ShouldNotBeNull();
            parametersOfGetResolutionCode1.Length.ShouldBe(3);
            methodGetResolutionCode1ParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResolutionCode1) (Return Type : List<ReferenceLookup>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetResolutionCode1_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolutionCode1);
            var methodGetResolutionCode1ParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResolutionCode1, methodGetResolutionCode1ParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResolutionCode1ParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetResolutionCode1) (Return Type : List<ReferenceLookup>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetResolutionCode1_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolutionCode1);
            var methodGetResolutionCode1ParametersTypes = new Type[] { typeof(string), typeof(int), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResolutionCode1, methodGetResolutionCode1ParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResolutionCode1ParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResolutionCode1) (Return Type : List<ReferenceLookup>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetResolutionCode1_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolutionCode1);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResolutionCode1, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResolutionCode1) (Return Type : List<ReferenceLookup>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetResolutionCode1_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResolutionCode1);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResolutionCode1, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetCacheByNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCacheByName, methodGetCacheByNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var isSearchfilter = this.CreateType<bool>();

            // Act
            Action executeAction = () => CMNavigatorCache.GetCacheByName(cacheName, conditionIds, isSearchfilter);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var isSearchfilter = this.CreateType<bool>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = CMNavigatorCache.GetCacheByName(cacheName, conditionIds, isSearchfilter);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var isSearchfilter = this.CreateType<bool>();
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetCacheByName = { cacheName, conditionIds, isSearchfilter };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByName, methodGetCacheByNameParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCacheByName, methodGetCacheByNameParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGetCacheByName, parametersOfGetCacheByName, methodGetCacheByNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCacheByName.ShouldNotBeNull();
            parametersOfGetCacheByName.Length.ShouldBe(3);
            methodGetCacheByNameParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<object>(MethodGetCacheByName, parametersOfGetCacheByName, methodGetCacheByNameParametersTypes));
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var isSearchfilter = this.CreateType<bool>();
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetCacheByName = { cacheName, conditionIds, isSearchfilter };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByName, methodGetCacheByNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCacheByName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCacheByName.ShouldNotBeNull();
            parametersOfGetCacheByName.Length.ShouldBe(3);
            methodGetCacheByNameParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var cacheName = this.CreateType<string>();
            var conditionIds = this.CreateType<string>();
            var isSearchfilter = this.CreateType<bool>();
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetCacheByName = { cacheName, conditionIds, isSearchfilter };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetCacheByName, parametersOfGetCacheByName, methodGetCacheByNameParametersTypes);

            // Assert
            parametersOfGetCacheByName.ShouldNotBeNull();
            parametersOfGetCacheByName.Length.ShouldBe(3);
            methodGetCacheByNameParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheByName, methodGetCacheByNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCacheByNameParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var methodGetCacheByNameParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheByName, methodGetCacheByNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheByNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByName, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheByName) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCacheByName_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheByName, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CacheUIResources) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_CacheUIResources_Static_Method_Call_Internally(Type[] types)
        {
            var methodCacheUIResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCacheUIResources, methodCacheUIResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (CacheUIResources) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheUIResources_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheUIResources);
            var returnData = this.CreateType<List<AccessPrivilege>>();

            // Act
            Action executeAction = () => CMNavigatorCache.CacheUIResources(returnData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CacheUIResources) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheUIResources_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheUIResources);
            var returnData = this.CreateType<List<AccessPrivilege>>();
            var methodCacheUIResourcesParametersTypes = new Type[] { typeof(List<AccessPrivilege>) };
            object[] parametersOfCacheUIResources = { returnData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCacheUIResources, methodCacheUIResourcesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCacheUIResources);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCacheUIResources.ShouldNotBeNull();
            parametersOfCacheUIResources.Length.ShouldBe(1);
            methodCacheUIResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CacheUIResources) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheUIResources_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheUIResources);
            var returnData = this.CreateType<List<AccessPrivilege>>();
            var methodCacheUIResourcesParametersTypes = new Type[] { typeof(List<AccessPrivilege>) };
            object[] parametersOfCacheUIResources = { returnData };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCacheUIResources, parametersOfCacheUIResources, methodCacheUIResourcesParametersTypes);

            // Assert
            parametersOfCacheUIResources.ShouldNotBeNull();
            parametersOfCacheUIResources.Length.ShouldBe(1);
            methodCacheUIResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CacheUIResources) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheUIResources_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheUIResources);
            var currentMethodInfo = this.GetMethodInfo(MethodCacheUIResources, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CacheUIResources) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheUIResources_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheUIResources);
            var methodCacheUIResourcesParametersTypes = new Type[] { typeof(List<AccessPrivilege>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCacheUIResources, methodCacheUIResourcesParametersTypes);

            // Assert
            methodCacheUIResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CacheUIResources) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheUIResources_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheUIResources);
            var currentMethodInfo = this.GetMethodInfo(MethodCacheUIResources, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CacheDomainData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_CacheDomainData_Static_Method_Call_Internally(Type[] types)
        {
            var methodCacheDomainDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCacheDomainData, methodCacheDomainDataParametersTypes);
        }

        #endregion

        #region Method Call : (CacheDomainData) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheDomainData_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheDomainData);

            // Act
            Action executeAction = () => CMNavigatorCache.CacheDomainData();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CacheDomainData) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheDomainData_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheDomainData);
            Type [] methodCacheDomainDataParametersTypes = null;
            object[] parametersOfCacheDomainData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCacheDomainData, methodCacheDomainDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCacheDomainData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCacheDomainData.ShouldBeNull();
            methodCacheDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CacheDomainData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheDomainData_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheDomainData);
            Type [] methodCacheDomainDataParametersTypes = null;
            object[] parametersOfCacheDomainData = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCacheDomainData, parametersOfCacheDomainData, methodCacheDomainDataParametersTypes);

            // Assert
            parametersOfCacheDomainData.ShouldBeNull();
            methodCacheDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CacheDomainData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheDomainData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheDomainData);
            Type [] methodCacheDomainDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCacheDomainData, methodCacheDomainDataParametersTypes);

            // Assert
            methodCacheDomainDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CacheDomainData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CacheDomainData_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCacheDomainData);
            var currentMethodInfo = this.GetMethodInfo(MethodCacheDomainData, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReadCache) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_ReadCache_Static_Method_Call_Internally(Type[] types)
        {
            var methodReadCacheParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReadCache, methodReadCacheParametersTypes);
        }

        #endregion

        #region Method Call : (ReadCache) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ReadCache_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadCache);
            Type [] methodReadCacheParametersTypes = null;
            object[] parametersOfReadCache = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodReadCache, methodReadCacheParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfReadCache);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfReadCache.ShouldBeNull();
            methodReadCacheParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ReadCache) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ReadCache_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadCache);
            Type [] methodReadCacheParametersTypes = null;
            object[] parametersOfReadCache = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodReadCache, parametersOfReadCache, methodReadCacheParametersTypes);

            // Assert
            parametersOfReadCache.ShouldBeNull();
            methodReadCacheParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReadCache) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ReadCache_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadCache);
            Type [] methodReadCacheParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReadCache, methodReadCacheParametersTypes);

            // Assert
            methodReadCacheParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReadCache) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ReadCache_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadCache);
            var currentMethodInfo = this.GetMethodInfo(MethodReadCache, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookup) (Return Type : List<ReferenceLookup>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetReferenceLookup_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetReferenceLookupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookup, methodGetReferenceLookupParametersTypes);
        }

        #endregion

        #region Method Call : (GetReferenceLookup) (Return Type : List<ReferenceLookup>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetReferenceLookup_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookup);
            var referenceName = this.CreateType<string>();
            var parentIds = this.CreateType<string>();
            var methodGetReferenceLookupParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetReferenceLookup = { referenceName, parentIds };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookup, methodGetReferenceLookupParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookup, methodGetReferenceLookupParametersTypes);
            var result2 = this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetReferenceLookup, parametersOfGetReferenceLookup, methodGetReferenceLookupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetReferenceLookup.ShouldNotBeNull();
            parametersOfGetReferenceLookup.Length.ShouldBe(2);
            methodGetReferenceLookupParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetReferenceLookup, parametersOfGetReferenceLookup, methodGetReferenceLookupParametersTypes));
        }

        #endregion

        #region Method Call : (GetReferenceLookup) (Return Type : List<ReferenceLookup>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetReferenceLookup_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookup);
            var referenceName = this.CreateType<string>();
            var parentIds = this.CreateType<string>();
            var methodGetReferenceLookupParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetReferenceLookup = { referenceName, parentIds };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookup, methodGetReferenceLookupParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetReferenceLookup);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetReferenceLookup.ShouldNotBeNull();
            parametersOfGetReferenceLookup.Length.ShouldBe(2);
            methodGetReferenceLookupParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookup) (Return Type : List<ReferenceLookup>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetReferenceLookup_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookup);
            var referenceName = this.CreateType<string>();
            var parentIds = this.CreateType<string>();
            var methodGetReferenceLookupParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetReferenceLookup = { referenceName, parentIds };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetReferenceLookup, parametersOfGetReferenceLookup, methodGetReferenceLookupParametersTypes);

            // Assert
            parametersOfGetReferenceLookup.ShouldNotBeNull();
            parametersOfGetReferenceLookup.Length.ShouldBe(2);
            methodGetReferenceLookupParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookup) (Return Type : List<ReferenceLookup>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetReferenceLookup_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookup);
            var methodGetReferenceLookupParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookup, methodGetReferenceLookupParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetReferenceLookupParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetReferenceLookup) (Return Type : List<ReferenceLookup>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetReferenceLookup_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookup);
            var methodGetReferenceLookupParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookup, methodGetReferenceLookupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReferenceLookupParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReferenceLookup) (Return Type : List<ReferenceLookup>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetReferenceLookup_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookup);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookup, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookup) (Return Type : List<ReferenceLookup>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetReferenceLookup_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookup);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookup, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetCountry_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCountryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCountry, methodGetCountryParametersTypes);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCountry_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var countryIds = this.CreateType<string>();
            var methodGetCountryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCountry = { countryIds };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountry, methodGetCountryParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCountry, methodGetCountryParametersTypes);
            var result2 = this.GetResultOfMethod<List<Country>>(MethodGetCountry, parametersOfGetCountry, methodGetCountryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCountry.ShouldNotBeNull();
            parametersOfGetCountry.Length.ShouldBe(1);
            methodGetCountryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<List<Country>>(MethodGetCountry, parametersOfGetCountry, methodGetCountryParametersTypes));
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCountry_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var countryIds = this.CreateType<string>();
            var methodGetCountryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCountry = { countryIds };
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
        public void AUT_CMNavigatorCache_GetCountry_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var countryIds = this.CreateType<string>();
            var methodGetCountryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCountry = { countryIds };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<Country>>(MethodGetCountry, parametersOfGetCountry, methodGetCountryParametersTypes);

            // Assert
            parametersOfGetCountry.ShouldNotBeNull();
            parametersOfGetCountry.Length.ShouldBe(1);
            methodGetCountryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCountry_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var methodGetCountryParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountry, methodGetCountryParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCountryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCountry_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (GetCountry) (Return Type : List<Country>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCountry_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountry);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountry, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCountry) (Return Type : List<Country>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCountry_Static_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_CMNavigatorCache_GetRegion_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetRegionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetRegion_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var countryIds = this.CreateType<string>();
            var methodGetRegionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRegion = { countryIds };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegion, methodGetRegionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);
            var result2 = this.GetResultOfMethod<List<Region>>(MethodGetRegion, parametersOfGetRegion, methodGetRegionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRegion.ShouldNotBeNull();
            parametersOfGetRegion.Length.ShouldBe(1);
            methodGetRegionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<List<Region>>(MethodGetRegion, parametersOfGetRegion, methodGetRegionParametersTypes));
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetRegion_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var countryIds = this.CreateType<string>();
            var methodGetRegionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRegion = { countryIds };
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
        public void AUT_CMNavigatorCache_GetRegion_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var countryIds = this.CreateType<string>();
            var methodGetRegionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRegion = { countryIds };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<Region>>(MethodGetRegion, parametersOfGetRegion, methodGetRegionParametersTypes);

            // Assert
            parametersOfGetRegion.ShouldNotBeNull();
            parametersOfGetRegion.Length.ShouldBe(1);
            methodGetRegionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetRegion_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var methodGetRegionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRegion, methodGetRegionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRegionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetRegion_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (GetRegion) (Return Type : List<Region>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetRegion_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegion);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegion, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRegion) (Return Type : List<Region>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetRegion_Static_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetEmailPriority_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailPriorityParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailPriority_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;
            object[] parametersOfGetEmailPriority = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetEmailPriority, parametersOfGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEmailPriority.ShouldBeNull();
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailPriority, parametersOfGetEmailPriority, methodGetEmailPriorityParametersTypes));
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailPriority_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;
            object[] parametersOfGetEmailPriority = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetEmailPriority);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEmailPriority.ShouldBeNull();
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailPriority_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;
            object[] parametersOfGetEmailPriority = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailPriority, parametersOfGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            parametersOfGetEmailPriority.ShouldBeNull();
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailPriority_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailPriority_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailPriority_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailPriority, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetAttachmentOwner) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetAttachmentOwner_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetAttachmentOwnerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes);
        }

        #endregion

        #region Method Call : (GetAttachmentOwner) (Return Type : List<DomainData>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAttachmentOwner_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttachmentOwner);
            Type [] methodGetAttachmentOwnerParametersTypes = null;
            object[] parametersOfGetAttachmentOwner = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetAttachmentOwner, parametersOfGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetAttachmentOwner.ShouldBeNull();
            methodGetAttachmentOwnerParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<List<DomainData>>(MethodGetAttachmentOwner, parametersOfGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes));
        }

        #endregion

        #region Method Call : (GetAttachmentOwner) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAttachmentOwner_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttachmentOwner);
            Type [] methodGetAttachmentOwnerParametersTypes = null;
            object[] parametersOfGetAttachmentOwner = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetAttachmentOwner);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetAttachmentOwner.ShouldBeNull();
            methodGetAttachmentOwnerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAttachmentOwner) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAttachmentOwner_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttachmentOwner);
            Type [] methodGetAttachmentOwnerParametersTypes = null;
            object[] parametersOfGetAttachmentOwner = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetAttachmentOwner, parametersOfGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes);

            // Assert
            parametersOfGetAttachmentOwner.ShouldBeNull();
            methodGetAttachmentOwnerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAttachmentOwner) (Return Type : List<DomainData>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAttachmentOwner_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttachmentOwner);
            Type [] methodGetAttachmentOwnerParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetAttachmentOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAttachmentOwner) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAttachmentOwner_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttachmentOwner);
            Type [] methodGetAttachmentOwnerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAttachmentOwner, methodGetAttachmentOwnerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAttachmentOwnerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAttachmentOwner) (Return Type : List<DomainData>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAttachmentOwner_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAttachmentOwner);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAttachmentOwner, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetScriptStatus_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScriptStatus, methodGetScriptStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptStatus_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            Type [] methodGetScriptStatusParametersTypes = null;
            object[] parametersOfGetScriptStatus = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptStatus, methodGetScriptStatusParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetScriptStatus, methodGetScriptStatusParametersTypes);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetScriptStatus, parametersOfGetScriptStatus, methodGetScriptStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetScriptStatus.ShouldBeNull();
            methodGetScriptStatusParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<List<DomainData>>(MethodGetScriptStatus, parametersOfGetScriptStatus, methodGetScriptStatusParametersTypes));
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptStatus_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            Type [] methodGetScriptStatusParametersTypes = null;
            object[] parametersOfGetScriptStatus = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptStatus, methodGetScriptStatusParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetScriptStatus);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetScriptStatus.ShouldBeNull();
            methodGetScriptStatusParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptStatus_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            Type [] methodGetScriptStatusParametersTypes = null;
            object[] parametersOfGetScriptStatus = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetScriptStatus, parametersOfGetScriptStatus, methodGetScriptStatusParametersTypes);

            // Assert
            parametersOfGetScriptStatus.ShouldBeNull();
            methodGetScriptStatusParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptStatus_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            Type [] methodGetScriptStatusParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScriptStatus, methodGetScriptStatusParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetScriptStatusParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptStatus_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            Type [] methodGetScriptStatusParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptStatus, methodGetScriptStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptStatusParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptStatus_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEmailFollowup) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetEmailFollowup_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailFollowupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailFollowup, methodGetEmailFollowupParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailFollowup) (Return Type : List<DomainData>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailFollowup_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailFollowup);
            Type [] methodGetEmailFollowupParametersTypes = null;
            object[] parametersOfGetEmailFollowup = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailFollowup, methodGetEmailFollowupParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetEmailFollowup, methodGetEmailFollowupParametersTypes);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetEmailFollowup, parametersOfGetEmailFollowup, methodGetEmailFollowupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEmailFollowup.ShouldBeNull();
            methodGetEmailFollowupParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailFollowup, parametersOfGetEmailFollowup, methodGetEmailFollowupParametersTypes));
        }

        #endregion

        #region Method Call : (GetEmailFollowup) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailFollowup_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailFollowup);
            Type [] methodGetEmailFollowupParametersTypes = null;
            object[] parametersOfGetEmailFollowup = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailFollowup, methodGetEmailFollowupParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetEmailFollowup);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEmailFollowup.ShouldBeNull();
            methodGetEmailFollowupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailFollowup) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailFollowup_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailFollowup);
            Type [] methodGetEmailFollowupParametersTypes = null;
            object[] parametersOfGetEmailFollowup = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailFollowup, parametersOfGetEmailFollowup, methodGetEmailFollowupParametersTypes);

            // Assert
            parametersOfGetEmailFollowup.ShouldBeNull();
            methodGetEmailFollowupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailFollowup) (Return Type : List<DomainData>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailFollowup_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailFollowup);
            Type [] methodGetEmailFollowupParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailFollowup, methodGetEmailFollowupParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEmailFollowupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailFollowup) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailFollowup_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailFollowup);
            Type [] methodGetEmailFollowupParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailFollowup, methodGetEmailFollowupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailFollowupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailFollowup) (Return Type : List<DomainData>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailFollowup_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailFollowup);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailFollowup, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEmailSent) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetEmailSent_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailSentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailSent, methodGetEmailSentParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailSent) (Return Type : List<DomainData>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailSent_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSent);
            Type [] methodGetEmailSentParametersTypes = null;
            object[] parametersOfGetEmailSent = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailSent, methodGetEmailSentParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetEmailSent, methodGetEmailSentParametersTypes);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetEmailSent, parametersOfGetEmailSent, methodGetEmailSentParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEmailSent.ShouldBeNull();
            methodGetEmailSentParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailSent, parametersOfGetEmailSent, methodGetEmailSentParametersTypes));
        }

        #endregion

        #region Method Call : (GetEmailSent) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailSent_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSent);
            Type [] methodGetEmailSentParametersTypes = null;
            object[] parametersOfGetEmailSent = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailSent, methodGetEmailSentParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetEmailSent);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEmailSent.ShouldBeNull();
            methodGetEmailSentParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailSent) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailSent_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSent);
            Type [] methodGetEmailSentParametersTypes = null;
            object[] parametersOfGetEmailSent = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailSent, parametersOfGetEmailSent, methodGetEmailSentParametersTypes);

            // Assert
            parametersOfGetEmailSent.ShouldBeNull();
            methodGetEmailSentParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailSent) (Return Type : List<DomainData>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailSent_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSent);
            Type [] methodGetEmailSentParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailSent, methodGetEmailSentParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEmailSentParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailSent) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailSent_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSent);
            Type [] methodGetEmailSentParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailSent, methodGetEmailSentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailSentParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailSent) (Return Type : List<DomainData>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailSent_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailSent);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailSent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetEmailDraft) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetEmailDraft_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailDraftParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailDraft, methodGetEmailDraftParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailDraft) (Return Type : List<DomainData>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailDraft_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailDraft);
            Type [] methodGetEmailDraftParametersTypes = null;
            object[] parametersOfGetEmailDraft = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailDraft, methodGetEmailDraftParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetEmailDraft, methodGetEmailDraftParametersTypes);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetEmailDraft, parametersOfGetEmailDraft, methodGetEmailDraftParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetEmailDraft.ShouldBeNull();
            methodGetEmailDraftParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailDraft, parametersOfGetEmailDraft, methodGetEmailDraftParametersTypes));
        }

        #endregion

        #region Method Call : (GetEmailDraft) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailDraft_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailDraft);
            Type [] methodGetEmailDraftParametersTypes = null;
            object[] parametersOfGetEmailDraft = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailDraft, methodGetEmailDraftParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetEmailDraft);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetEmailDraft.ShouldBeNull();
            methodGetEmailDraftParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailDraft) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailDraft_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailDraft);
            Type [] methodGetEmailDraftParametersTypes = null;
            object[] parametersOfGetEmailDraft = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailDraft, parametersOfGetEmailDraft, methodGetEmailDraftParametersTypes);

            // Assert
            parametersOfGetEmailDraft.ShouldBeNull();
            methodGetEmailDraftParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailDraft) (Return Type : List<DomainData>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailDraft_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailDraft);
            Type [] methodGetEmailDraftParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailDraft, methodGetEmailDraftParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetEmailDraftParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailDraft) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailDraft_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailDraft);
            Type [] methodGetEmailDraftParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailDraft, methodGetEmailDraftParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailDraftParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailDraft) (Return Type : List<DomainData>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetEmailDraft_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailDraft);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailDraft, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetGender) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetGender_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetGenderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetGender, methodGetGenderParametersTypes);
        }

        #endregion

        #region Method Call : (GetGender) (Return Type : List<DomainData>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetGender_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGender);
            Type [] methodGetGenderParametersTypes = null;
            object[] parametersOfGetGender = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGender, methodGetGenderParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetGender, methodGetGenderParametersTypes);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetGender, parametersOfGetGender, methodGetGenderParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetGender.ShouldBeNull();
            methodGetGenderParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<List<DomainData>>(MethodGetGender, parametersOfGetGender, methodGetGenderParametersTypes));
        }

        #endregion

        #region Method Call : (GetGender) (Return Type : List<DomainData>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetGender_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGender);
            Type [] methodGetGenderParametersTypes = null;
            object[] parametersOfGetGender = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGender, methodGetGenderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetGender);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetGender.ShouldBeNull();
            methodGetGenderParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGender) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetGender_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGender);
            Type [] methodGetGenderParametersTypes = null;
            object[] parametersOfGetGender = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetGender, parametersOfGetGender, methodGetGenderParametersTypes);

            // Assert
            parametersOfGetGender.ShouldBeNull();
            methodGetGenderParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGender) (Return Type : List<DomainData>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetGender_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGender);
            Type [] methodGetGenderParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGender, methodGetGenderParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetGenderParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGender) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetGender_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGender);
            Type [] methodGetGenderParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGender, methodGetGenderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGenderParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGender) (Return Type : List<DomainData>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetGender_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGender);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGender, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (UserTree) (Return Type : TreeItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_UserTree_Static_Method_Call_Internally(Type[] types)
        {
            var methodUserTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUserTree, methodUserTreeParametersTypes);
        }

        #endregion

        #region Method Call : (UserTree) (Return Type : TreeItem) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_UserTree_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUserTree);
            Type [] methodUserTreeParametersTypes = null;
            object[] parametersOfUserTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUserTree, methodUserTreeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodUserTree, methodUserTreeParametersTypes);
            var result2 = this.GetResultOfMethod<TreeItem>(MethodUserTree, parametersOfUserTree, methodUserTreeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfUserTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUserTree.ShouldBeNull();
            methodUserTreeParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UserTree) (Return Type : TreeItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_UserTree_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUserTree);
            Type [] methodUserTreeParametersTypes = null;
            object[] parametersOfUserTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<TreeItem>(MethodUserTree, parametersOfUserTree, methodUserTreeParametersTypes);

            // Assert
            parametersOfUserTree.ShouldBeNull();
            methodUserTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UserTree) (Return Type : TreeItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_UserTree_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUserTree);
            Type [] methodUserTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUserTree, methodUserTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUserTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UserTree) (Return Type : TreeItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_UserTree_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUserTree);
            Type [] methodUserTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUserTree, methodUserTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUserTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UserTree) (Return Type : TreeItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_UserTree_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUserTree);
            var currentMethodInfo = this.GetMethodInfo(MethodUserTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTreeItems) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetUserTreeItems_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUserTreeItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserTreeItems, methodGetUserTreeItemsParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserTreeItems) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetUserTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeItems);
            var itemCode = this.CreateType<string>();
            var treeItem = this.CreateType<TreeItem>();
            var parentDisplayName = this.CreateType<string>();
            var methodGetUserTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem), typeof(string) };
            object[] parametersOfGetUserTreeItems = { itemCode, treeItem, parentDisplayName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTreeItems, methodGetUserTreeItemsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUserTreeItems);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUserTreeItems.ShouldNotBeNull();
            parametersOfGetUserTreeItems.Length.ShouldBe(3);
            methodGetUserTreeItemsParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetUserTreeItems) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetUserTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeItems);
            var itemCode = this.CreateType<string>();
            var treeItem = this.CreateType<TreeItem>();
            var parentDisplayName = this.CreateType<string>();
            var methodGetUserTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem), typeof(string) };
            object[] parametersOfGetUserTreeItems = { itemCode, treeItem, parentDisplayName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetUserTreeItems, parametersOfGetUserTreeItems, methodGetUserTreeItemsParametersTypes);

            // Assert
            parametersOfGetUserTreeItems.ShouldNotBeNull();
            parametersOfGetUserTreeItems.Length.ShouldBe(3);
            methodGetUserTreeItemsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserTreeItems) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetUserTreeItems_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTreeItems, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserTreeItems) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetUserTreeItems_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeItems);
            var methodGetUserTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserTreeItems, methodGetUserTreeItemsParametersTypes);

            // Assert
            methodGetUserTreeItemsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserTreeItems) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetUserTreeItems_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTreeItems, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ScriptTree) (Return Type : TreeItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_ScriptTree_Static_Method_Call_Internally(Type[] types)
        {
            var methodScriptTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodScriptTree, methodScriptTreeParametersTypes);
        }

        #endregion

        #region Method Call : (ScriptTree) (Return Type : TreeItem)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ScriptTree_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodScriptTree);
            Type [] methodScriptTreeParametersTypes = null;
            object[] parametersOfScriptTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodScriptTree, methodScriptTreeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodScriptTree, methodScriptTreeParametersTypes);
            var result2 = this.GetResultOfMethod<TreeItem>(MethodScriptTree, parametersOfScriptTree, methodScriptTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfScriptTree.ShouldBeNull();
            methodScriptTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<TreeItem>(MethodScriptTree, parametersOfScriptTree, methodScriptTreeParametersTypes));
        }

        #endregion

        #region Method Call : (ScriptTree) (Return Type : TreeItem) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ScriptTree_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodScriptTree);
            Type [] methodScriptTreeParametersTypes = null;
            object[] parametersOfScriptTree = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodScriptTree, methodScriptTreeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfScriptTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfScriptTree.ShouldBeNull();
            methodScriptTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ScriptTree) (Return Type : TreeItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ScriptTree_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodScriptTree);
            Type [] methodScriptTreeParametersTypes = null;
            object[] parametersOfScriptTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<TreeItem>(MethodScriptTree, parametersOfScriptTree, methodScriptTreeParametersTypes);

            // Assert
            parametersOfScriptTree.ShouldBeNull();
            methodScriptTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ScriptTree) (Return Type : TreeItem) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ScriptTree_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodScriptTree);
            Type [] methodScriptTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodScriptTree, methodScriptTreeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodScriptTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ScriptTree) (Return Type : TreeItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ScriptTree_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodScriptTree);
            Type [] methodScriptTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodScriptTree, methodScriptTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodScriptTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ScriptTree) (Return Type : TreeItem) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ScriptTree_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodScriptTree);
            var currentMethodInfo = this.GetMethodInfo(MethodScriptTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetScriptTreeItems) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetScriptTreeItems_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptTreeItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScriptTreeItems, methodGetScriptTreeItemsParametersTypes);
        }

        #endregion

        #region Method Call : (GetScriptTreeItems) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptTreeItems_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTreeItems);
            var itemCode = this.CreateType<string>();
            var treeItem = this.CreateType<TreeItem>();
            var methodGetScriptTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem) };
            object[] parametersOfGetScriptTreeItems = { itemCode, treeItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptTreeItems, methodGetScriptTreeItemsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetScriptTreeItems);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetScriptTreeItems.ShouldNotBeNull();
            parametersOfGetScriptTreeItems.Length.ShouldBe(2);
            methodGetScriptTreeItemsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptTreeItems) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTreeItems);
            var itemCode = this.CreateType<string>();
            var treeItem = this.CreateType<TreeItem>();
            var methodGetScriptTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem) };
            object[] parametersOfGetScriptTreeItems = { itemCode, treeItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetScriptTreeItems, parametersOfGetScriptTreeItems, methodGetScriptTreeItemsParametersTypes);

            // Assert
            parametersOfGetScriptTreeItems.ShouldNotBeNull();
            parametersOfGetScriptTreeItems.Length.ShouldBe(2);
            methodGetScriptTreeItemsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptTreeItems) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptTreeItems_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptTreeItems, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptTreeItems) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptTreeItems_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTreeItems);
            var methodGetScriptTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptTreeItems, methodGetScriptTreeItemsParametersTypes);

            // Assert
            methodGetScriptTreeItemsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptTreeItems) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetScriptTreeItems_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptTreeItems, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ProductTree) (Return Type : TreeItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_ProductTree_Static_Method_Call_Internally(Type[] types)
        {
            var methodProductTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodProductTree, methodProductTreeParametersTypes);
        }

        #endregion

        #region Method Call : (ProductTree) (Return Type : TreeItem) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ProductTree_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProductTree);

            // Act
            Action executeAction = () => CMNavigatorCache.ProductTree();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ProductTree) (Return Type : TreeItem) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ProductTree_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProductTree);
            var returnedValue = default(TreeItem);

            // Act
            Action executeAction = () => returnedValue = CMNavigatorCache.ProductTree();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ProductTree) (Return Type : TreeItem) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ProductTree_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProductTree);
            Type [] methodProductTreeParametersTypes = null;
            object[] parametersOfProductTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodProductTree, methodProductTreeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodProductTree, methodProductTreeParametersTypes);
            var result2 = this.GetResultOfMethod<TreeItem>(MethodProductTree, parametersOfProductTree, methodProductTreeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfProductTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfProductTree.ShouldBeNull();
            methodProductTreeParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ProductTree) (Return Type : TreeItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ProductTree_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProductTree);
            Type [] methodProductTreeParametersTypes = null;
            object[] parametersOfProductTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<TreeItem>(MethodProductTree, parametersOfProductTree, methodProductTreeParametersTypes);

            // Assert
            parametersOfProductTree.ShouldBeNull();
            methodProductTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ProductTree) (Return Type : TreeItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ProductTree_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProductTree);
            Type [] methodProductTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodProductTree, methodProductTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodProductTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ProductTree) (Return Type : TreeItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ProductTree_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProductTree);
            Type [] methodProductTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProductTree, methodProductTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodProductTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ProductTree) (Return Type : TreeItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_ProductTree_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProductTree);
            var currentMethodInfo = this.GetMethodInfo(MethodProductTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductTreeItems) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetProductTreeItems_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetProductTreeItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductTreeItems, methodGetProductTreeItemsParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductTreeItems) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetProductTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductTreeItems);
            var itemCode = this.CreateType<string>();
            var treeItem = this.CreateType<TreeItem>();
            var methodGetProductTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem) };
            object[] parametersOfGetProductTreeItems = { itemCode, treeItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductTreeItems, methodGetProductTreeItemsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetProductTreeItems);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetProductTreeItems.ShouldNotBeNull();
            parametersOfGetProductTreeItems.Length.ShouldBe(2);
            methodGetProductTreeItemsParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetProductTreeItems) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetProductTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductTreeItems);
            var itemCode = this.CreateType<string>();
            var treeItem = this.CreateType<TreeItem>();
            var methodGetProductTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem) };
            object[] parametersOfGetProductTreeItems = { itemCode, treeItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetProductTreeItems, parametersOfGetProductTreeItems, methodGetProductTreeItemsParametersTypes);

            // Assert
            parametersOfGetProductTreeItems.ShouldNotBeNull();
            parametersOfGetProductTreeItems.Length.ShouldBe(2);
            methodGetProductTreeItemsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductTreeItems) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetProductTreeItems_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductTreeItems, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductTreeItems) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetProductTreeItems_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductTreeItems);
            var methodGetProductTreeItemsParametersTypes = new Type[] { typeof(string), typeof(TreeItem) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductTreeItems, methodGetProductTreeItemsParametersTypes);

            // Assert
            methodGetProductTreeItemsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductTreeItems) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetProductTreeItems_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductTreeItems, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CampaignTree) (Return Type : TreeItem) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_CampaignTree_Static_Method_Call_Internally(Type[] types)
        {
            var methodCampaignTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCampaignTree, methodCampaignTreeParametersTypes);
        }

        #endregion

        #region Method Call : (CampaignTree) (Return Type : TreeItem) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CampaignTree_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCampaignTree);
            Type [] methodCampaignTreeParametersTypes = null;
            object[] parametersOfCampaignTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCampaignTree, methodCampaignTreeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCampaignTree, methodCampaignTreeParametersTypes);
            var result2 = this.GetResultOfMethod<TreeItem>(MethodCampaignTree, parametersOfCampaignTree, methodCampaignTreeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCampaignTree);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCampaignTree.ShouldBeNull();
            methodCampaignTreeParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CampaignTree) (Return Type : TreeItem) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CampaignTree_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCampaignTree);
            Type [] methodCampaignTreeParametersTypes = null;
            object[] parametersOfCampaignTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<TreeItem>(MethodCampaignTree, parametersOfCampaignTree, methodCampaignTreeParametersTypes);

            // Assert
            parametersOfCampaignTree.ShouldBeNull();
            methodCampaignTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CampaignTree) (Return Type : TreeItem) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CampaignTree_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCampaignTree);
            Type [] methodCampaignTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCampaignTree, methodCampaignTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCampaignTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CampaignTree) (Return Type : TreeItem) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CampaignTree_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCampaignTree);
            Type [] methodCampaignTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCampaignTree, methodCampaignTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCampaignTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CampaignTree) (Return Type : TreeItem) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_CampaignTree_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCampaignTree);
            var currentMethodInfo = this.GetMethodInfo(MethodCampaignTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetCampaignTreeItems_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCampaignTreeItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCampaignTreeItems, methodGetCampaignTreeItemsParametersTypes);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var treeItem = this.CreateType<TreeItem>();
            var methodGetCampaignTreeItemsParametersTypes = new Type[] { typeof(TreeItem) };
            object[] parametersOfGetCampaignTreeItems = { treeItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTreeItems, methodGetCampaignTreeItemsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCampaignTreeItems);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCampaignTreeItems.ShouldNotBeNull();
            parametersOfGetCampaignTreeItems.Length.ShouldBe(1);
            methodGetCampaignTreeItemsParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var treeItem = this.CreateType<TreeItem>();
            var methodGetCampaignTreeItemsParametersTypes = new Type[] { typeof(TreeItem) };
            object[] parametersOfGetCampaignTreeItems = { treeItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetCampaignTreeItems, parametersOfGetCampaignTreeItems, methodGetCampaignTreeItemsParametersTypes);

            // Assert
            parametersOfGetCampaignTreeItems.ShouldNotBeNull();
            parametersOfGetCampaignTreeItems.Length.ShouldBe(1);
            methodGetCampaignTreeItemsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignTreeItems_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTreeItems, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignTreeItems_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var methodGetCampaignTreeItemsParametersTypes = new Type[] { typeof(TreeItem) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCampaignTreeItems, methodGetCampaignTreeItemsParametersTypes);

            // Assert
            methodGetCampaignTreeItemsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignTreeItems_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTreeItems, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCampaignPickerXMLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);

            // Act
            Action executeAction = () => CMNavigatorCache.GetCampaignPickerXML();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = CMNavigatorCache.GetCampaignPickerXML();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;
            object[] parametersOfGetCampaignPickerXML = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetCampaignPickerXML, parametersOfGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCampaignPickerXML.ShouldBeNull();
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetCampaignPickerXML, parametersOfGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes));
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;
            object[] parametersOfGetCampaignPickerXML = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCampaignPickerXML);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCampaignPickerXML.ShouldBeNull();
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;
            object[] parametersOfGetCampaignPickerXML = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCampaignPickerXML, parametersOfGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);

            // Assert
            parametersOfGetCampaignPickerXML.ShouldBeNull();
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetCampaignPickerXML_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignPickerXML, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsChildExistsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var pickerName = this.CreateType<string>();
            var cacheName = this.CreateType<XDocument>();
            var typeNode = this.CreateType<XName>();
            var parentIdNode = this.CreateType<XName>();
            var typeNodeValue = this.CreateType<string>();
            var parentIdNodeValue = this.CreateType<string>();
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };
            object[] parametersOfIsChildExists = { pickerName, cacheName, typeNode, parentIdNode, typeNodeValue, parentIdNodeValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsChildExists, methodIsChildExistsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsChildExists, parametersOfIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsChildExists.ShouldNotBeNull();
            parametersOfIsChildExists.Length.ShouldBe(6);
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsChildExists, parametersOfIsChildExists, methodIsChildExistsParametersTypes));
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var pickerName = this.CreateType<string>();
            var cacheName = this.CreateType<XDocument>();
            var typeNode = this.CreateType<XName>();
            var parentIdNode = this.CreateType<XName>();
            var typeNodeValue = this.CreateType<string>();
            var parentIdNodeValue = this.CreateType<string>();
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };
            object[] parametersOfIsChildExists = { pickerName, cacheName, typeNode, parentIdNode, typeNodeValue, parentIdNodeValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsChildExists, methodIsChildExistsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfIsChildExists);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsChildExists.ShouldNotBeNull();
            parametersOfIsChildExists.Length.ShouldBe(6);
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var pickerName = this.CreateType<string>();
            var cacheName = this.CreateType<XDocument>();
            var typeNode = this.CreateType<XName>();
            var parentIdNode = this.CreateType<XName>();
            var typeNodeValue = this.CreateType<string>();
            var parentIdNodeValue = this.CreateType<string>();
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };
            object[] parametersOfIsChildExists = { pickerName, cacheName, typeNode, parentIdNode, typeNodeValue, parentIdNodeValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsChildExists, parametersOfIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            parametersOfIsChildExists.ShouldNotBeNull();
            parametersOfIsChildExists.Length.ShouldBe(6);
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsChildExistsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var currentMethodInfo = this.GetMethodInfo(MethodIsChildExists, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_IsChildExists_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var currentMethodInfo = this.GetMethodInfo(MethodIsChildExists, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllUsersByGroupID) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMNavigatorCache_GetAllUsersByGroupID_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetAllUsersByGroupIDParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAllUsersByGroupID, methodGetAllUsersByGroupIDParametersTypes);
        }

        #endregion
        
        #region Method Call : (GetAllUsersByGroupID) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAllUsersByGroupID_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUsersByGroupID);
            var parentID = this.CreateType<string>();
            var matchIdTreeItems = this.CreateType<dynamic>();
            var itemSource = this.CreateType<dynamic>();
            var methodGetAllUsersByGroupIDParametersTypes = new Type[] { typeof(string), typeof(List<TreeItem>), typeof(List<TreeItem>) };
            object[] parametersOfGetAllUsersByGroupID = { parentID, matchIdTreeItems, itemSource };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUsersByGroupID, methodGetAllUsersByGroupIDParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetAllUsersByGroupID);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetAllUsersByGroupID.ShouldNotBeNull();
            parametersOfGetAllUsersByGroupID.Length.ShouldBe(3);
            methodGetAllUsersByGroupIDParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetAllUsersByGroupID) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAllUsersByGroupID_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUsersByGroupID);
            var parentID = this.CreateType<string>();
            var matchIdTreeItems = this.CreateType<dynamic>();
            var itemSource = this.CreateType<dynamic>();
            var methodGetAllUsersByGroupIDParametersTypes = new Type[] { typeof(string), typeof(List<TreeItem>), typeof(List<TreeItem>) };
            object[] parametersOfGetAllUsersByGroupID = { parentID, matchIdTreeItems, itemSource };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetAllUsersByGroupID, parametersOfGetAllUsersByGroupID, methodGetAllUsersByGroupIDParametersTypes);

            // Assert
            parametersOfGetAllUsersByGroupID.ShouldNotBeNull();
            parametersOfGetAllUsersByGroupID.Length.ShouldBe(3);
            methodGetAllUsersByGroupIDParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllUsersByGroupID) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAllUsersByGroupID_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUsersByGroupID);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUsersByGroupID, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllUsersByGroupID) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAllUsersByGroupID_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUsersByGroupID);
            var methodGetAllUsersByGroupIDParametersTypes = new Type[] { typeof(string), typeof(List<TreeItem>), typeof(List<TreeItem>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAllUsersByGroupID, methodGetAllUsersByGroupIDParametersTypes);

            // Assert
            methodGetAllUsersByGroupIDParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllUsersByGroupID) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMNavigatorCache_GetAllUsersByGroupID_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUsersByGroupID);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUsersByGroupID, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}