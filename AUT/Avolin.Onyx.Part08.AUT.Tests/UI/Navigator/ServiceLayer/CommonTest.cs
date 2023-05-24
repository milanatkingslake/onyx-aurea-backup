using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.ServiceLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.Common" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Common" />)
        /// </summary>
        public CommonTest() : base(typeof(Common))
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

        #region General Initializer : Class (Common) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _commonInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Common" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonInstanceType = typeof(Common);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Common) Initializer

        #region Methods

        private const string MethodGetEndpointUrl = "GetEndpointUrl";
        private const string MethodStringToStream = "StringToStream";
        private const string MethodDecryptText = "DecryptText";
        private const string MethodGetExceptionMessage = "GetExceptionMessage";
        private const string MethodGetFile = "GetFile";
        private const string MethodGetOnyxGatewayServiceConfiguration = "GetOnyxGatewayServiceConfiguration";
        private const string MethodGetUtf16String = "GetUtf16String";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string FieldBROWSE_DATE_ENUMERATOR_SOURCE = "BROWSE_DATE_ENUMERATOR_SOURCE";
        private const string FieldNAVIGATOR_SEARCH_ENTITY_SOURCE = "NAVIGATOR_SEARCH_ENTITY_SOURCE";
        private const string FieldDOCK_SOURCE = "DOCK_SOURCE";
        private const string FieldALL_UI_RESOURCES = "ALL_UI_RESOURCES";
        private const string FieldMODULE_PRIVILEGE_SOURCE = "MODULE_PRIVILEGE_SOURCE";
        private const string FieldDISPLAY_PROFILE_SOURCE = "DISPLAY_PROFILE_SOURCE";
        private const string FieldBATCH_UPDATE_SOURCE = "BATCH_UPDATE_SOURCE";
        private const string FieldRESULT_GRID_MANAGER_SOURCE = "RESULT_GRID_MANAGER_SOURCE";
        private const string FieldRESULT_GRID_RESTORE_DEFAULT = "RESULT_GRID_RESTORE_DEFAULT";
        private const string FieldSEARCH_FILTER_SOURCE = "SEARCH_FILTER_SOURCE";
        private const string FieldSEARCH_FILTER_RESTORE_DEFAULT = "SEARCH_FILTER_RESTORE_DEFAULT";
        private const string FieldGAM_CONFIGURATION = "GAM_CONFIGURATION";
        private const string FieldQUERY_TREE = "QUERY_TREE";
        private const string FieldQUERY_TREE_SAVE = "QUERY_TREE_SAVE";
        private const string FieldLBO_MAPPING = "LBO_MAPPING";
        private const string FieldQUERY_VALIDATE = "QUERY_VALIDATE";
        private const string FieldQUERY_DATA = "QUERY_DATA";
        private const string FieldHOMEPAGE_QUERY = "HOMEPAGE_QUERY";
        private const string FieldHOMEPAGE_QUERY_POSITION = "HOMEPAGE_QUERY_POSITION";
        private const string FieldHOMEPAGE_CONFIG = "HOMEPAGE_CONFIG";
        private const string FieldHOMEPAGE_CONFIG_SAVE = "HOMEPAGE_CONFIG_SAVE";
        private const string FieldBATCH_UPDATE_SAVE = "BATCH_UPDATE_SAVE";
        private const string FieldBATCH_UPDATE_RECALLDATESAVE = "BATCH_UPDATE_RECALLDATESAVE";
        private const string FieldCACHE_COUNTRY = "CACHE_COUNTRY";
        private const string FieldCACHE_REGION = "CACHE_REGION";
        private const string FieldCACHE_EMAIL_PRIORITY = "CACHE_EMAIL_PRIORITY";
        private const string FieldCACHE_SCRIPT = "CACHE_SCRIPT";
        private const string FieldCACHE_INCIDENT_PRODUCT = "CACHE_INCIDENT_PRODUCT";
        private const string FieldCACHE_PRODUCT = "CACHE_PRODUCT";
        private const string FieldCACHE_TRACKING_CODE = "CACHE_TRACKING_CODE";
        private const string FieldCACHE_TRACKING_CODE_TYPE = "CACHE_TRACKING_CODE_TYPE";
        private const string FieldCACHE_CAMPAIGN = "CACHE_CAMPAIGN";
        private const string FieldCACHE_USERS = "CACHE_USERS";
        private const string FieldCACHE_GROUPS = "CACHE_GROUPS";
        private const string FieldCACHE_SCRIPT_STATUS = "CACHE_SCRIPT_STATUS";
        private const string FieldCACHE_KEYWORDS = "CACHE_KEYWORDS";
        private const string FieldCACHE_REFERENCE_LOOKUP = "CACHE_REFERENCE_LOOKUP";
        private const string FieldCACHE_DATE_OPERATOR = "CACHE_DATE_OPERATOR";
        private const string FieldCACHE_OPERATOR = "CACHE_OPERATOR";
        private const string FieldCACHE_ATTACHMENT_OWNER = "CACHE_ATTACHMENT_OWNER";
        private const string FieldCACHE_CUSTOM = "CACHE_CUSTOM";
        private const string FieldRESULTACTION_GROUP = "RESULTACTION_GROUP";
        private const string FieldRESULTACTION_ITEM = "RESULTACTION_ITEM";
        private const string FieldCHECK_SERVICE = "CHECK_SERVICE";
        private const string FieldCHECK_ONS_SERVICE = "CHECK_ONS_SERVICE";
        private const string FieldAPP_SETTINGS = "APP_SETTINGS";
        private const string FieldLOGIN_USER_PROFILE = "LOGIN_USER_PROFILE";
        private const string FieldLOGIN_DEFAULT_USER_PROFILE = "LOGIN_DEFAULT_USER_PROFILE";
        private const string FieldLOGIN_USER_PREFERENCE = "LOGIN_USER_PREFERENCE";
        private const string FieldHOME_PAGE_MODULE = "HOME_PAGE_MODULE";
        private const string FieldRESULT_GRID_ADMINISTRATION_MODULE = "RESULT_GRID_ADMINISTRATION_MODULE";
        private const string FieldSEARCH_CRITERIA_ADMINISTRATION_MODULE = "SEARCH_CRITERIA_ADMINISTRATION_MODULE";

        #endregion

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Common)

        #region General Initializer : Class (Common) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetEndpointUrl, 0)]
        [TestCase(MethodStringToStream, 0)]
        [TestCase(MethodDecryptText, 0)]
        [TestCase(MethodGetExceptionMessage, 0)]
        [TestCase(MethodGetFile, 0)]
        [TestCase(MethodGetOnyxGatewayServiceConfiguration, 0)]
        [TestCase(MethodGetUtf16String, 0)]
        public void AUT_Common_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Common) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [TestCase(FieldBROWSE_DATE_ENUMERATOR_SOURCE)]
        [TestCase(FieldNAVIGATOR_SEARCH_ENTITY_SOURCE)]
        [TestCase(FieldDOCK_SOURCE)]
        [TestCase(FieldALL_UI_RESOURCES)]
        [TestCase(FieldMODULE_PRIVILEGE_SOURCE)]
        [TestCase(FieldDISPLAY_PROFILE_SOURCE)]
        [TestCase(FieldBATCH_UPDATE_SOURCE)]
        [TestCase(FieldRESULT_GRID_MANAGER_SOURCE)]
        [TestCase(FieldRESULT_GRID_RESTORE_DEFAULT)]
        [TestCase(FieldSEARCH_FILTER_SOURCE)]
        [TestCase(FieldSEARCH_FILTER_RESTORE_DEFAULT)]
        [TestCase(FieldGAM_CONFIGURATION)]
        [TestCase(FieldQUERY_TREE)]
        [TestCase(FieldQUERY_TREE_SAVE)]
        [TestCase(FieldLBO_MAPPING)]
        [TestCase(FieldQUERY_VALIDATE)]
        [TestCase(FieldQUERY_DATA)]
        [TestCase(FieldHOMEPAGE_QUERY)]
        [TestCase(FieldHOMEPAGE_QUERY_POSITION)]
        [TestCase(FieldHOMEPAGE_CONFIG)]
        [TestCase(FieldHOMEPAGE_CONFIG_SAVE)]
        [TestCase(FieldBATCH_UPDATE_SAVE)]
        [TestCase(FieldBATCH_UPDATE_RECALLDATESAVE)]
        [TestCase(FieldCACHE_COUNTRY)]
        [TestCase(FieldCACHE_REGION)]
        [TestCase(FieldCACHE_EMAIL_PRIORITY)]
        [TestCase(FieldCACHE_SCRIPT)]
        [TestCase(FieldCACHE_INCIDENT_PRODUCT)]
        [TestCase(FieldCACHE_PRODUCT)]
        [TestCase(FieldCACHE_TRACKING_CODE)]
        [TestCase(FieldCACHE_TRACKING_CODE_TYPE)]
        [TestCase(FieldCACHE_CAMPAIGN)]
        [TestCase(FieldCACHE_USERS)]
        [TestCase(FieldCACHE_GROUPS)]
        [TestCase(FieldCACHE_SCRIPT_STATUS)]
        [TestCase(FieldCACHE_KEYWORDS)]
        [TestCase(FieldCACHE_REFERENCE_LOOKUP)]
        [TestCase(FieldCACHE_DATE_OPERATOR)]
        [TestCase(FieldCACHE_OPERATOR)]
        [TestCase(FieldCACHE_ATTACHMENT_OWNER)]
        [TestCase(FieldCACHE_CUSTOM)]
        [TestCase(FieldRESULTACTION_GROUP)]
        [TestCase(FieldRESULTACTION_ITEM)]
        [TestCase(FieldCHECK_SERVICE)]
        [TestCase(FieldCHECK_ONS_SERVICE)]
        [TestCase(FieldAPP_SETTINGS)]
        [TestCase(FieldLOGIN_USER_PROFILE)]
        [TestCase(FieldLOGIN_DEFAULT_USER_PROFILE)]
        [TestCase(FieldLOGIN_USER_PREFERENCE)]
        [TestCase(FieldHOME_PAGE_MODULE)]
        [TestCase(FieldRESULT_GRID_ADMINISTRATION_MODULE)]
        [TestCase(FieldSEARCH_CRITERIA_ADMINISTRATION_MODULE)]
        [Category("AUT Fields")]
        public void AUT_Common_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Common) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Common" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Common_Is_Static_Type_Present_Test()
        {
            // Assert
            _commonInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetEndpointUrl) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var pathAndQuery = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetEndpointUrl(pathAndQuery);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var pathAndQuery = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetEndpointUrl(pathAndQuery);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var pathAndQuery = this.CreateType<string>();
            var methodGetEndpointUrlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEndpointUrl = { pathAndQuery };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpointUrl, methodGetEndpointUrlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetEndpointUrl, methodGetEndpointUrlParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetEndpointUrl, parametersOfGetEndpointUrl, methodGetEndpointUrlParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetEndpointUrl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEndpointUrl.ShouldNotBeNull();
            parametersOfGetEndpointUrl.Length.ShouldBe(1);
            methodGetEndpointUrlParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var pathAndQuery = this.CreateType<string>();
            var methodGetEndpointUrlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEndpointUrl = { pathAndQuery };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEndpointUrl, parametersOfGetEndpointUrl, methodGetEndpointUrlParametersTypes);

            // Assert
            parametersOfGetEndpointUrl.ShouldNotBeNull();
            parametersOfGetEndpointUrl.Length.ShouldBe(1);
            methodGetEndpointUrlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var methodGetEndpointUrlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEndpointUrl, methodGetEndpointUrlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEndpointUrlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var methodGetEndpointUrlParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEndpointUrl, methodGetEndpointUrlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEndpointUrlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpointUrl, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpointUrl, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_StringToStream_Static_Method_Call_Internally(Type[] types)
        {
            var methodStringToStreamParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStringToStream, methodStringToStreamParametersTypes);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var result = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.StringToStream(result);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var result = this.CreateType<string>();
            var returnedValue = default(Stream);

            // Act
            Action executeAction = () => returnedValue = Common.StringToStream(result);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var result = this.CreateType<string>();
            var methodStringToStreamParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfStringToStream = { result };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodStringToStream, methodStringToStreamParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodStringToStream, methodStringToStreamParametersTypes);
            var result2 = this.GetResultOfMethod<Stream>(MethodStringToStream, parametersOfStringToStream, methodStringToStreamParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfStringToStream);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfStringToStream.ShouldNotBeNull();
            parametersOfStringToStream.Length.ShouldBe(1);
            methodStringToStreamParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var result = this.CreateType<string>();
            var methodStringToStreamParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfStringToStream = { result };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Stream>(MethodStringToStream, parametersOfStringToStream, methodStringToStreamParametersTypes);

            // Assert
            parametersOfStringToStream.ShouldNotBeNull();
            parametersOfStringToStream.Length.ShouldBe(1);
            methodStringToStreamParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var methodStringToStreamParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodStringToStream, methodStringToStreamParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodStringToStreamParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var methodStringToStreamParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStringToStream, methodStringToStreamParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodStringToStreamParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var currentMethodInfo = this.GetMethodInfo(MethodStringToStream, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var currentMethodInfo = this.GetMethodInfo(MethodStringToStream, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_DecryptText_Static_Method_Call_Internally(Type[] types)
        {
            var methodDecryptTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.DecryptText(encryptedText);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.DecryptText(encryptedText);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptText = { encryptedText };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, methodDecryptTextParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodDecryptText, parametersOfDecryptText, methodDecryptTextParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfDecryptText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDecryptText.ShouldNotBeNull();
            parametersOfDecryptText.Length.ShouldBe(1);
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptText = { encryptedText };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDecryptText, parametersOfDecryptText, methodDecryptTextParametersTypes);

            // Assert
            parametersOfDecryptText.ShouldNotBeNull();
            parametersOfDecryptText.Length.ShouldBe(1);
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDecryptTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetExceptionMessage_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetExceptionMessageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);

            // Act
            Action executeAction = () => Common.GetExceptionMessage();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetExceptionMessage();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            Type [] methodGetExceptionMessageParametersTypes = null;
            object[] parametersOfGetExceptionMessage = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetExceptionMessage, parametersOfGetExceptionMessage, methodGetExceptionMessageParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetExceptionMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetExceptionMessage.ShouldBeNull();
            methodGetExceptionMessageParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            Type [] methodGetExceptionMessageParametersTypes = null;
            object[] parametersOfGetExceptionMessage = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetExceptionMessage, parametersOfGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            parametersOfGetExceptionMessage.ShouldBeNull();
            methodGetExceptionMessageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            Type [] methodGetExceptionMessageParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetExceptionMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            Type [] methodGetExceptionMessageParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetExceptionMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExceptionMessage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetFile_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var fileName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetFile(fileName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var fileName = this.CreateType<string>();
            var returnedValue = default(Stream);

            // Act
            Action executeAction = () => returnedValue = Common.GetFile(fileName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var fileName = this.CreateType<string>();
            var methodGetFileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetFile = { fileName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFile, methodGetFileParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);
            var result2 = this.GetResultOfMethod<Stream>(MethodGetFile, parametersOfGetFile, methodGetFileParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFile);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetFile.ShouldNotBeNull();
            parametersOfGetFile.Length.ShouldBe(1);
            methodGetFileParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var fileName = this.CreateType<string>();
            var methodGetFileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetFile = { fileName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Stream>(MethodGetFile, parametersOfGetFile, methodGetFileParametersTypes);

            // Assert
            parametersOfGetFile.ShouldNotBeNull();
            parametersOfGetFile.Length.ShouldBe(1);
            methodGetFileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var methodGetFileParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetFileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var methodGetFileParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxGatewayServiceConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxGatewayServiceConfiguration_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);

            // Act
            Action executeAction = () => Common.GetOnyxGatewayServiceConfiguration();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxGatewayServiceConfiguration_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var returnedValue = default(OnyxGatewayServiceConfiguration);

            // Act
            Action executeAction = () => returnedValue = Common.GetOnyxGatewayServiceConfiguration();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxGatewayServiceConfiguration_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            Type [] methodGetOnyxGatewayServiceConfigurationParametersTypes = null;
            object[] parametersOfGetOnyxGatewayServiceConfiguration = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);
            var result2 = this.GetResultOfMethod<OnyxGatewayServiceConfiguration>(MethodGetOnyxGatewayServiceConfiguration, parametersOfGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOnyxGatewayServiceConfiguration);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOnyxGatewayServiceConfiguration.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxGatewayServiceConfiguration_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            Type [] methodGetOnyxGatewayServiceConfigurationParametersTypes = null;
            object[] parametersOfGetOnyxGatewayServiceConfiguration = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxGatewayServiceConfiguration>(MethodGetOnyxGatewayServiceConfiguration, parametersOfGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            parametersOfGetOnyxGatewayServiceConfiguration.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            Type [] methodGetOnyxGatewayServiceConfigurationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            Type [] methodGetOnyxGatewayServiceConfigurationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxGatewayServiceConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetUtf16String_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUtf16StringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUtf16String, methodGetUtf16StringParametersTypes);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var message = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetUtf16String(message);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var message = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetUtf16String(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var message = this.CreateType<string>();
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUtf16String = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUtf16String, methodGetUtf16StringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetUtf16String, methodGetUtf16StringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetUtf16String, parametersOfGetUtf16String, methodGetUtf16StringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUtf16String.ShouldNotBeNull();
            parametersOfGetUtf16String.Length.ShouldBe(1);
            methodGetUtf16StringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetUtf16String, parametersOfGetUtf16String, methodGetUtf16StringParametersTypes));
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var message = this.CreateType<string>();
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUtf16String = { message };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUtf16String, methodGetUtf16StringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUtf16String);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUtf16String.ShouldNotBeNull();
            parametersOfGetUtf16String.Length.ShouldBe(1);
            methodGetUtf16StringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var message = this.CreateType<string>();
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUtf16String = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUtf16String, parametersOfGetUtf16String, methodGetUtf16StringParametersTypes);

            // Assert
            parametersOfGetUtf16String.ShouldNotBeNull();
            parametersOfGetUtf16String.Length.ShouldBe(1);
            methodGetUtf16StringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUtf16String, methodGetUtf16StringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUtf16StringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUtf16String, methodGetUtf16StringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUtf16StringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUtf16String, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUtf16String, 0);
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