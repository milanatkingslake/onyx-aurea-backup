using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Onyx.UI.Scripting.Helper.Mapper;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Helper.Mapper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Helper.Mapper.ModelMapperFromJson" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Helper.Mapper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ModelMapperFromJsonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ModelMapperFromJson" />)
        /// </summary>
        public ModelMapperFromJsonTest() : base(typeof(ModelMapperFromJson))
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

        #region General Initializer : Class (ModelMapperFromJson) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _modelMapperFromJsonInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="ModelMapperFromJson" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _modelMapperFromJsonInstanceType = typeof(ModelMapperFromJson);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ModelMapperFromJson) Initializer

        #region Methods

        private const string MethodGetUserSearchModel = "GetUserSearchModel";
        private const string MethodGetUserGroupModel = "GetUserGroupModel";
        private const string MethodGetReferenceLookupModel = "GetReferenceLookupModel";
        private const string MethodGetScriptModel = "GetScriptModel";
        private const string MethodGetUserModel = "GetUserModel";
        private const string MethodGetTrackingCampaignTypeCodeModelFromCampaign = "GetTrackingCampaignTypeCodeModelFromCampaign";
        private const string MethodGetTrackingCampaignTypeCodeModelFromTrackingType = "GetTrackingCampaignTypeCodeModelFromTrackingType";
        private const string MethodGetTrackingCampaignTypeCodeModelFromTrackingCode = "GetTrackingCampaignTypeCodeModelFromTrackingCode";
        private const string MethodGetRegionModel = "GetRegionModel";
        private const string MethodGetProductModelFromProductIndex = "GetProductModelFromProductIndex";
        private const string MethodGetIncidentProductModel = "GetIncidentProductModel";
        private const string MethodGetIncidentModel = "GetIncidentModel";
        private const string MethodGetUserPreferenceModel = "GetUserPreferenceModel";
        private const string MethodGetProductModel = "GetProductModel";
        private const string MethodGetCountryModel = "GetCountryModel";
        private const string MethodGetCustomerModel = "GetCustomerModel";
        private const string MethodGetCustomerSearchModel = "GetCustomerSearchModel";

        #endregion

        #endregion

        #region General Initializer : Class (ModelMapperFromJson) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ModelMapperFromJson" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModelMapperFromJson_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ModelMapperFromJson)

        #region General Initializer : Class (ModelMapperFromJson) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ModelMapperFromJson" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetUserSearchModel, 0)]
        [TestCase(MethodGetUserGroupModel, 0)]
        [TestCase(MethodGetReferenceLookupModel, 0)]
        [TestCase(MethodGetScriptModel, 0)]
        [TestCase(MethodGetUserModel, 0)]
        [TestCase(MethodGetTrackingCampaignTypeCodeModelFromCampaign, 0)]
        [TestCase(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, 0)]
        [TestCase(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, 0)]
        [TestCase(MethodGetRegionModel, 0)]
        [TestCase(MethodGetProductModelFromProductIndex, 0)]
        [TestCase(MethodGetIncidentProductModel, 0)]
        [TestCase(MethodGetIncidentModel, 0)]
        [TestCase(MethodGetUserPreferenceModel, 0)]
        [TestCase(MethodGetProductModel, 0)]
        [TestCase(MethodGetCountryModel, 0)]
        [TestCase(MethodGetCustomerModel, 0)]
        [TestCase(MethodGetCustomerSearchModel, 0)]
        public void AUT_ModelMapperFromJson_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ModelMapperFromJson) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ModelMapperFromJson" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ModelMapperFromJson_Is_Static_Type_Present_Test()
        {
            // Assert
            _modelMapperFromJsonInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetUserSearchModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(UserSearchModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetUserSearchModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserSearchModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserSearchModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearchModel, methodGetUserSearchModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetUserSearchModel, methodGetUserSearchModelParametersTypes);
            var result2 = this.GetResultOfMethod<UserSearchModel>(MethodGetUserSearchModel, parametersOfGetUserSearchModel, methodGetUserSearchModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUserSearchModel.ShouldNotBeNull();
            parametersOfGetUserSearchModel.Length.ShouldBe(1);
            methodGetUserSearchModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<UserSearchModel>(MethodGetUserSearchModel, parametersOfGetUserSearchModel, methodGetUserSearchModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserSearchModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserSearchModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearchModel, methodGetUserSearchModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUserSearchModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUserSearchModel.ShouldNotBeNull();
            parametersOfGetUserSearchModel.Length.ShouldBe(1);
            methodGetUserSearchModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserSearchModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserSearchModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<UserSearchModel>(MethodGetUserSearchModel, parametersOfGetUserSearchModel, methodGetUserSearchModelParametersTypes);

            // Assert
            parametersOfGetUserSearchModel.ShouldNotBeNull();
            parametersOfGetUserSearchModel.Length.ShouldBe(1);
            methodGetUserSearchModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var methodGetUserSearchModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserSearchModel, methodGetUserSearchModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUserSearchModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var methodGetUserSearchModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserSearchModel, methodGetUserSearchModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserSearchModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearchModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUserSearchModel) (Return Type : UserSearchModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserSearchModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearchModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearchModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUserGroupModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserGroupModel, methodGetUserGroupModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetUserGroupModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(UserGroupModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetUserGroupModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserGroupModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserGroupModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserGroupModel, methodGetUserGroupModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetUserGroupModel, methodGetUserGroupModelParametersTypes);
            var result2 = this.GetResultOfMethod<UserGroupModel>(MethodGetUserGroupModel, parametersOfGetUserGroupModel, methodGetUserGroupModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUserGroupModel.ShouldNotBeNull();
            parametersOfGetUserGroupModel.Length.ShouldBe(1);
            methodGetUserGroupModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<UserGroupModel>(MethodGetUserGroupModel, parametersOfGetUserGroupModel, methodGetUserGroupModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserGroupModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserGroupModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserGroupModel, methodGetUserGroupModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUserGroupModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUserGroupModel.ShouldNotBeNull();
            parametersOfGetUserGroupModel.Length.ShouldBe(1);
            methodGetUserGroupModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserGroupModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserGroupModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<UserGroupModel>(MethodGetUserGroupModel, parametersOfGetUserGroupModel, methodGetUserGroupModelParametersTypes);

            // Assert
            parametersOfGetUserGroupModel.ShouldNotBeNull();
            parametersOfGetUserGroupModel.Length.ShouldBe(1);
            methodGetUserGroupModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var methodGetUserGroupModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserGroupModel, methodGetUserGroupModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUserGroupModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var methodGetUserGroupModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserGroupModel, methodGetUserGroupModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserGroupModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserGroupModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUserGroupModel) (Return Type : UserGroupModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserGroupModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroupModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserGroupModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetReferenceLookupModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetReferenceLookupModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(ReferenceLookupModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetReferenceLookupModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetReferenceLookupModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetReferenceLookupModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes);
            var result2 = this.GetResultOfMethod<ReferenceLookupModel>(MethodGetReferenceLookupModel, parametersOfGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetReferenceLookupModel.ShouldNotBeNull();
            parametersOfGetReferenceLookupModel.Length.ShouldBe(1);
            methodGetReferenceLookupModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<ReferenceLookupModel>(MethodGetReferenceLookupModel, parametersOfGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetReferenceLookupModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetReferenceLookupModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetReferenceLookupModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetReferenceLookupModel.ShouldNotBeNull();
            parametersOfGetReferenceLookupModel.Length.ShouldBe(1);
            methodGetReferenceLookupModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetReferenceLookupModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetReferenceLookupModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ReferenceLookupModel>(MethodGetReferenceLookupModel, parametersOfGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes);

            // Assert
            parametersOfGetReferenceLookupModel.ShouldNotBeNull();
            parametersOfGetReferenceLookupModel.Length.ShouldBe(1);
            methodGetReferenceLookupModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var methodGetReferenceLookupModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetReferenceLookupModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var methodGetReferenceLookupModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookupModel, methodGetReferenceLookupModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReferenceLookupModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookupModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookupModel) (Return Type : ReferenceLookupModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetReferenceLookupModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookupModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookupModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScriptModel, methodGetScriptModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetScriptModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(ScriptMetadataModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetScriptModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetScriptModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetScriptModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptModel, methodGetScriptModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetScriptModel, methodGetScriptModelParametersTypes);
            var result2 = this.GetResultOfMethod<ScriptMetadataModel>(MethodGetScriptModel, parametersOfGetScriptModel, methodGetScriptModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetScriptModel.ShouldNotBeNull();
            parametersOfGetScriptModel.Length.ShouldBe(1);
            methodGetScriptModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<ScriptMetadataModel>(MethodGetScriptModel, parametersOfGetScriptModel, methodGetScriptModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetScriptModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetScriptModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptModel, methodGetScriptModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetScriptModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetScriptModel.ShouldNotBeNull();
            parametersOfGetScriptModel.Length.ShouldBe(1);
            methodGetScriptModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetScriptModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetScriptModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ScriptMetadataModel>(MethodGetScriptModel, parametersOfGetScriptModel, methodGetScriptModelParametersTypes);

            // Assert
            parametersOfGetScriptModel.ShouldNotBeNull();
            parametersOfGetScriptModel.Length.ShouldBe(1);
            methodGetScriptModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var methodGetScriptModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScriptModel, methodGetScriptModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetScriptModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var methodGetScriptModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptModel, methodGetScriptModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetScriptModel) (Return Type : ScriptMetadataModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetScriptModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetUserModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUserModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserModel, methodGetUserModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetUserModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(UserModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetUserModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserModel, methodGetUserModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetUserModel, methodGetUserModelParametersTypes);
            var result2 = this.GetResultOfMethod<UserModel>(MethodGetUserModel, parametersOfGetUserModel, methodGetUserModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUserModel.ShouldNotBeNull();
            parametersOfGetUserModel.Length.ShouldBe(1);
            methodGetUserModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<UserModel>(MethodGetUserModel, parametersOfGetUserModel, methodGetUserModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserModel, methodGetUserModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUserModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUserModel.ShouldNotBeNull();
            parametersOfGetUserModel.Length.ShouldBe(1);
            methodGetUserModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<UserModel>(MethodGetUserModel, parametersOfGetUserModel, methodGetUserModelParametersTypes);

            // Assert
            parametersOfGetUserModel.ShouldNotBeNull();
            parametersOfGetUserModel.Length.ShouldBe(1);
            methodGetUserModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var methodGetUserModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserModel, methodGetUserModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUserModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var methodGetUserModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserModel, methodGetUserModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUserModel) (Return Type : UserModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetTrackingCampaignTypeCodeModelFromCampaign(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(TrackingCampaignTypeCodeModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetTrackingCampaignTypeCodeModelFromCampaign(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromCampaign = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes);
            var result2 = this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromCampaign, parametersOfGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromCampaign.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromCampaign.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromCampaign, parametersOfGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes));
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromCampaign = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetTrackingCampaignTypeCodeModelFromCampaign);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromCampaign.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromCampaign.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromCampaign = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromCampaign, parametersOfGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes);

            // Assert
            parametersOfGetTrackingCampaignTypeCodeModelFromCampaign.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromCampaign.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromCampaign, methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCampaignTypeCodeModelFromCampaignParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromCampaign, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromCampaign) (Return Type : TrackingCampaignTypeCodeModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromCampaign_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromCampaign);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromCampaign, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetTrackingCampaignTypeCodeModelFromTrackingType(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(TrackingCampaignTypeCodeModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetTrackingCampaignTypeCodeModelFromTrackingType(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes);
            var result2 = this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes));
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes);

            // Assert
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingType.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCampaignTypeCodeModelFromTrackingTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingType) (Return Type : TrackingCampaignTypeCodeModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromTrackingType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetTrackingCampaignTypeCodeModelFromTrackingCode(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(TrackingCampaignTypeCodeModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetTrackingCampaignTypeCodeModelFromTrackingCode(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes);
            var result2 = this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes));
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var jsonData = this.CreateType<JObject>();
            var methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes);

            // Assert
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCodeModelFromTrackingCode.Length.ShouldBe(1);
            methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCampaignTypeCodeModelFromTrackingCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCodeModelFromTrackingCode) (Return Type : TrackingCampaignTypeCodeModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetTrackingCampaignTypeCodeModelFromTrackingCode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCodeModelFromTrackingCode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetRegionModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRegionModel, methodGetRegionModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetRegionModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(RegionModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetRegionModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetRegionModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetRegionModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionModel, methodGetRegionModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRegionModel, methodGetRegionModelParametersTypes);
            var result2 = this.GetResultOfMethod<RegionModel>(MethodGetRegionModel, parametersOfGetRegionModel, methodGetRegionModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRegionModel.ShouldNotBeNull();
            parametersOfGetRegionModel.Length.ShouldBe(1);
            methodGetRegionModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<RegionModel>(MethodGetRegionModel, parametersOfGetRegionModel, methodGetRegionModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetRegionModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetRegionModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionModel, methodGetRegionModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRegionModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRegionModel.ShouldNotBeNull();
            parametersOfGetRegionModel.Length.ShouldBe(1);
            methodGetRegionModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetRegionModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetRegionModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<RegionModel>(MethodGetRegionModel, parametersOfGetRegionModel, methodGetRegionModelParametersTypes);

            // Assert
            parametersOfGetRegionModel.ShouldNotBeNull();
            parametersOfGetRegionModel.Length.ShouldBe(1);
            methodGetRegionModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var methodGetRegionModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRegionModel, methodGetRegionModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRegionModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var methodGetRegionModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRegionModel, methodGetRegionModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRegionModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRegionModel) (Return Type : RegionModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetRegionModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetProductModelFromProductIndexParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetProductModelFromProductIndex(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(ProductModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetProductModelFromProductIndex(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var jsonData = this.CreateType<JObject>();
            var methodGetProductModelFromProductIndexParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetProductModelFromProductIndex = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes);
            var result2 = this.GetResultOfMethod<ProductModel>(MethodGetProductModelFromProductIndex, parametersOfGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetProductModelFromProductIndex.ShouldNotBeNull();
            parametersOfGetProductModelFromProductIndex.Length.ShouldBe(1);
            methodGetProductModelFromProductIndexParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<ProductModel>(MethodGetProductModelFromProductIndex, parametersOfGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes));
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var jsonData = this.CreateType<JObject>();
            var methodGetProductModelFromProductIndexParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetProductModelFromProductIndex = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetProductModelFromProductIndex);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetProductModelFromProductIndex.ShouldNotBeNull();
            parametersOfGetProductModelFromProductIndex.Length.ShouldBe(1);
            methodGetProductModelFromProductIndexParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var jsonData = this.CreateType<JObject>();
            var methodGetProductModelFromProductIndexParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetProductModelFromProductIndex = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ProductModel>(MethodGetProductModelFromProductIndex, parametersOfGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes);

            // Assert
            parametersOfGetProductModelFromProductIndex.ShouldNotBeNull();
            parametersOfGetProductModelFromProductIndex.Length.ShouldBe(1);
            methodGetProductModelFromProductIndexParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var methodGetProductModelFromProductIndexParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetProductModelFromProductIndexParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var methodGetProductModelFromProductIndexParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductModelFromProductIndex, methodGetProductModelFromProductIndexParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductModelFromProductIndexParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductModelFromProductIndex, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetProductModelFromProductIndex) (Return Type : ProductModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModelFromProductIndex_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModelFromProductIndex);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductModelFromProductIndex, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentProductModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductModel, methodGetIncidentProductModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetIncidentProductModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(IncidentProductModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetIncidentProductModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetIncidentProductModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetIncidentProductModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProductModel, methodGetIncidentProductModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductModel, methodGetIncidentProductModelParametersTypes);
            var result2 = this.GetResultOfMethod<IncidentProductModel>(MethodGetIncidentProductModel, parametersOfGetIncidentProductModel, methodGetIncidentProductModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetIncidentProductModel.ShouldNotBeNull();
            parametersOfGetIncidentProductModel.Length.ShouldBe(1);
            methodGetIncidentProductModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<IncidentProductModel>(MethodGetIncidentProductModel, parametersOfGetIncidentProductModel, methodGetIncidentProductModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetIncidentProductModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetIncidentProductModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProductModel, methodGetIncidentProductModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetIncidentProductModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetIncidentProductModel.ShouldNotBeNull();
            parametersOfGetIncidentProductModel.Length.ShouldBe(1);
            methodGetIncidentProductModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetIncidentProductModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetIncidentProductModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IncidentProductModel>(MethodGetIncidentProductModel, parametersOfGetIncidentProductModel, methodGetIncidentProductModelParametersTypes);

            // Assert
            parametersOfGetIncidentProductModel.ShouldNotBeNull();
            parametersOfGetIncidentProductModel.Length.ShouldBe(1);
            methodGetIncidentProductModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var methodGetIncidentProductModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductModel, methodGetIncidentProductModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetIncidentProductModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var methodGetIncidentProductModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentProductModel, methodGetIncidentProductModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentProductModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProductModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProductModel) (Return Type : IncidentProductModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentProductModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProductModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProductModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentModel, methodGetIncidentModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetIncidentModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(IncidentModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetIncidentModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetIncidentModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetIncidentModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentModel, methodGetIncidentModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetIncidentModel, methodGetIncidentModelParametersTypes);
            var result2 = this.GetResultOfMethod<IncidentModel>(MethodGetIncidentModel, parametersOfGetIncidentModel, methodGetIncidentModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetIncidentModel.ShouldNotBeNull();
            parametersOfGetIncidentModel.Length.ShouldBe(1);
            methodGetIncidentModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<IncidentModel>(MethodGetIncidentModel, parametersOfGetIncidentModel, methodGetIncidentModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetIncidentModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetIncidentModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentModel, methodGetIncidentModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetIncidentModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetIncidentModel.ShouldNotBeNull();
            parametersOfGetIncidentModel.Length.ShouldBe(1);
            methodGetIncidentModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetIncidentModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetIncidentModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IncidentModel>(MethodGetIncidentModel, parametersOfGetIncidentModel, methodGetIncidentModelParametersTypes);

            // Assert
            parametersOfGetIncidentModel.ShouldNotBeNull();
            parametersOfGetIncidentModel.Length.ShouldBe(1);
            methodGetIncidentModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var methodGetIncidentModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentModel, methodGetIncidentModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetIncidentModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var methodGetIncidentModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentModel, methodGetIncidentModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentModel) (Return Type : IncidentModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetIncidentModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetUserPreferenceModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetUserPreferenceModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(UserPreferenceModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetUserPreferenceModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserPreferenceModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserPreferenceModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes);
            var result2 = this.GetResultOfMethod<UserPreferenceModel>(MethodGetUserPreferenceModel, parametersOfGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUserPreferenceModel.ShouldNotBeNull();
            parametersOfGetUserPreferenceModel.Length.ShouldBe(1);
            methodGetUserPreferenceModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<UserPreferenceModel>(MethodGetUserPreferenceModel, parametersOfGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserPreferenceModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserPreferenceModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUserPreferenceModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUserPreferenceModel.ShouldNotBeNull();
            parametersOfGetUserPreferenceModel.Length.ShouldBe(1);
            methodGetUserPreferenceModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetUserPreferenceModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetUserPreferenceModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<UserPreferenceModel>(MethodGetUserPreferenceModel, parametersOfGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes);

            // Assert
            parametersOfGetUserPreferenceModel.ShouldNotBeNull();
            parametersOfGetUserPreferenceModel.Length.ShouldBe(1);
            methodGetUserPreferenceModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var methodGetUserPreferenceModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUserPreferenceModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var methodGetUserPreferenceModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceModel, methodGetUserPreferenceModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserPreferenceModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceModel) (Return Type : UserPreferenceModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetUserPreferenceModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetProductModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetProductModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductModel, methodGetProductModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetProductModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(ProductModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetProductModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetProductModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetProductModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductModel, methodGetProductModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetProductModel, methodGetProductModelParametersTypes);
            var result2 = this.GetResultOfMethod<ProductModel>(MethodGetProductModel, parametersOfGetProductModel, methodGetProductModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetProductModel.ShouldNotBeNull();
            parametersOfGetProductModel.Length.ShouldBe(1);
            methodGetProductModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<ProductModel>(MethodGetProductModel, parametersOfGetProductModel, methodGetProductModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetProductModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetProductModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductModel, methodGetProductModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetProductModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetProductModel.ShouldNotBeNull();
            parametersOfGetProductModel.Length.ShouldBe(1);
            methodGetProductModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetProductModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetProductModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ProductModel>(MethodGetProductModel, parametersOfGetProductModel, methodGetProductModelParametersTypes);

            // Assert
            parametersOfGetProductModel.ShouldNotBeNull();
            parametersOfGetProductModel.Length.ShouldBe(1);
            methodGetProductModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var methodGetProductModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProductModel, methodGetProductModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetProductModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var methodGetProductModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductModel, methodGetProductModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetProductModel) (Return Type : ProductModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetProductModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCountryModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCountryModel, methodGetCountryModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetCountryModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(CountryModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetCountryModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCountryModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCountryModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryModel, methodGetCountryModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCountryModel, methodGetCountryModelParametersTypes);
            var result2 = this.GetResultOfMethod<CountryModel>(MethodGetCountryModel, parametersOfGetCountryModel, methodGetCountryModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCountryModel.ShouldNotBeNull();
            parametersOfGetCountryModel.Length.ShouldBe(1);
            methodGetCountryModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<CountryModel>(MethodGetCountryModel, parametersOfGetCountryModel, methodGetCountryModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCountryModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCountryModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryModel, methodGetCountryModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCountryModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCountryModel.ShouldNotBeNull();
            parametersOfGetCountryModel.Length.ShouldBe(1);
            methodGetCountryModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCountryModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCountryModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CountryModel>(MethodGetCountryModel, parametersOfGetCountryModel, methodGetCountryModelParametersTypes);

            // Assert
            parametersOfGetCountryModel.ShouldNotBeNull();
            parametersOfGetCountryModel.Length.ShouldBe(1);
            methodGetCountryModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var methodGetCountryModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountryModel, methodGetCountryModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCountryModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var methodGetCountryModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCountryModel, methodGetCountryModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCountryModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCountryModel) (Return Type : CountryModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCountryModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountryModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountryModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCustomerModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCustomerModel, methodGetCustomerModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetCustomerModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(CustomerModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetCustomerModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCustomerModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCustomerModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerModel, methodGetCustomerModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCustomerModel, methodGetCustomerModelParametersTypes);
            var result2 = this.GetResultOfMethod<CustomerModel>(MethodGetCustomerModel, parametersOfGetCustomerModel, methodGetCustomerModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCustomerModel.ShouldNotBeNull();
            parametersOfGetCustomerModel.Length.ShouldBe(1);
            methodGetCustomerModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<CustomerModel>(MethodGetCustomerModel, parametersOfGetCustomerModel, methodGetCustomerModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCustomerModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCustomerModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerModel, methodGetCustomerModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCustomerModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCustomerModel.ShouldNotBeNull();
            parametersOfGetCustomerModel.Length.ShouldBe(1);
            methodGetCustomerModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCustomerModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCustomerModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CustomerModel>(MethodGetCustomerModel, parametersOfGetCustomerModel, methodGetCustomerModelParametersTypes);

            // Assert
            parametersOfGetCustomerModel.ShouldNotBeNull();
            parametersOfGetCustomerModel.Length.ShouldBe(1);
            methodGetCustomerModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var methodGetCustomerModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCustomerModel, methodGetCustomerModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCustomerModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var methodGetCustomerModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCustomerModel, methodGetCustomerModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCustomerModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCustomerModel) (Return Type : CustomerModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerModel, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCustomerSearchModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes);
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var jsonData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => ModelMapperFromJson.GetCustomerSearchModel(jsonData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var jsonData = this.CreateType<JObject>();
            var returnedValue = default(CustomerSearchModel);

            // Act
            Action executeAction = () => returnedValue = ModelMapperFromJson.GetCustomerSearchModel(jsonData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCustomerSearchModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCustomerSearchModel = { jsonData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes);
            var result2 = this.GetResultOfMethod<CustomerSearchModel>(MethodGetCustomerSearchModel, parametersOfGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCustomerSearchModel.ShouldNotBeNull();
            parametersOfGetCustomerSearchModel.Length.ShouldBe(1);
            methodGetCustomerSearchModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<CustomerSearchModel>(MethodGetCustomerSearchModel, parametersOfGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes));
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCustomerSearchModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCustomerSearchModel = { jsonData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCustomerSearchModel);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCustomerSearchModel.ShouldNotBeNull();
            parametersOfGetCustomerSearchModel.Length.ShouldBe(1);
            methodGetCustomerSearchModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var jsonData = this.CreateType<JObject>();
            var methodGetCustomerSearchModelParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfGetCustomerSearchModel = { jsonData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CustomerSearchModel>(MethodGetCustomerSearchModel, parametersOfGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes);

            // Assert
            parametersOfGetCustomerSearchModel.ShouldNotBeNull();
            parametersOfGetCustomerSearchModel.Length.ShouldBe(1);
            methodGetCustomerSearchModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var methodGetCustomerSearchModelParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCustomerSearchModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var methodGetCustomerSearchModelParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCustomerSearchModel, methodGetCustomerSearchModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCustomerSearchModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerSearchModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCustomerSearchModel) (Return Type : CustomerSearchModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelMapperFromJson_GetCustomerSearchModel_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearchModel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerSearchModel, 0);
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