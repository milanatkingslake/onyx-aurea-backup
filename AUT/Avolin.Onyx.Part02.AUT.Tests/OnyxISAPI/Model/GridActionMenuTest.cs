using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.GridActionMenu" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GridActionMenuTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GridActionMenu" />)
        /// </summary>
        public GridActionMenuTest() : base(typeof(GridActionMenu))
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

        #region General Initializer : Class (GridActionMenu) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _gridActionMenuInstanceType;
        private GridActionMenu _gridActionMenuInstance;
        private GridActionMenu _gridActionMenuInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GridActionMenu" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _gridActionMenuInstanceType = typeof(GridActionMenu);
            _gridActionMenuInstanceFixture = this.Create<GridActionMenu>(false);
            _gridActionMenuInstance = _gridActionMenuInstanceFixture ?? this.Create<GridActionMenu>(true);
            CurrentInstance = _gridActionMenuInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GridActionMenu) Initializer

        #region Methods

        private const string MethodGetGamConfiguration = "GetGamConfiguration";
        private const string MethodGetGamType = "GetGamType";
        private const string MethodGetMediationProfile = "GetMediationProfile";
        private const string MethodGetEndPointProperties = "GetEndPointProperties";
        private const string MethodGetXml = "GetXml";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";

        #endregion

        #endregion

        #region General Initializer : Class (GridActionMenu) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GridActionMenu_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GridActionMenu) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GridActionMenu_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GridActionMenu)

        #region General Initializer : Class (GridActionMenu) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetGamConfiguration, 0)]
        [TestCase(MethodGetGamType, 0)]
        [TestCase(MethodGetMediationProfile, 0)]
        [TestCase(MethodGetEndPointProperties, 0)]
        [TestCase(MethodGetXml, 0)]
        public void AUT_GridActionMenu_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (GridActionMenu) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [Category("AUT Fields")]
        public void AUT_GridActionMenu_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GridActionMenu) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GridActionMenu" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GridActionMenu_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _gridActionMenuInstance.ShouldBeAssignableTo<GridActionMenu>();
            _gridActionMenuInstanceFixture.ShouldBeAssignableTo<GridActionMenu>();
            CurrentInstance.ShouldBeAssignableTo<GridActionMenu>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetGamConfiguration) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);

            // Act
            Action executeAction = () => _gridActionMenuInstance.GetGamConfiguration();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _gridActionMenuInstance.GetGamConfiguration();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            Type [] methodGetGamConfigurationParametersTypes = null;
            object[] parametersOfGetGamConfiguration = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_gridActionMenuInstanceFixture, parametersOfGetGamConfiguration);
            var result2 = this.GetResultOfMethod<string>(MethodGetGamConfiguration, parametersOfGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetGamConfiguration.ShouldBeNull();
            methodGetGamConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            Type [] methodGetGamConfigurationParametersTypes = null;
            object[] parametersOfGetGamConfiguration = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetGamConfiguration, parametersOfGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            parametersOfGetGamConfiguration.ShouldBeNull();
            methodGetGamConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            Type [] methodGetGamConfigurationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetGamConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            Type [] methodGetGamConfigurationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGamConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamType) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GridActionMenu_GetGamType_Method_Call_Internally(Type[] types)
        {
            var methodGetGamTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetGamType, methodGetGamTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetGamType) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamType_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamType);

            // Act
            Action executeAction = () => _gridActionMenuInstance.GetGamType();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetGamType) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamType_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamType);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _gridActionMenuInstance.GetGamType();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamType);
            Type [] methodGetGamTypeParametersTypes = null;
            object[] parametersOfGetGamType = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamType, methodGetGamTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_gridActionMenuInstanceFixture, parametersOfGetGamType);
            var result2 = this.GetResultOfMethod<string>(MethodGetGamType, parametersOfGetGamType, methodGetGamTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetGamType.ShouldBeNull();
            methodGetGamTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamType) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamType);
            Type [] methodGetGamTypeParametersTypes = null;
            object[] parametersOfGetGamType = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetGamType, parametersOfGetGamType, methodGetGamTypeParametersTypes);

            // Assert
            parametersOfGetGamType.ShouldBeNull();
            methodGetGamTypeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGamType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamType);
            Type [] methodGetGamTypeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGamType, methodGetGamTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetGamTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamType) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamType);
            Type [] methodGetGamTypeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGamType, methodGetGamTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGamTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamType) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetGamType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMediationProfile) (Return Type : MediationProfile) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GridActionMenu_GetMediationProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetMediationProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMediationProfile, methodGetMediationProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetMediationProfile) (Return Type : MediationProfile) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetMediationProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMediationProfile);
            var profileList = this.CreateType<List<GamNonUiView>>();
            var profileId = this.CreateType<int>();
            var methodGetMediationProfileParametersTypes = new Type[] { typeof(List<GamNonUiView>), typeof(int) };
            object[] parametersOfGetMediationProfile = { profileList, profileId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMediationProfile, methodGetMediationProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<GridActionMenu.MediationProfile>(_gridActionMenuInstanceFixture, parametersOfGetMediationProfile);
            var result2 = this.GetResultOfMethod<GridActionMenu.MediationProfile>(MethodGetMediationProfile, parametersOfGetMediationProfile, methodGetMediationProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMediationProfile.ShouldNotBeNull();
            parametersOfGetMediationProfile.Length.ShouldBe(2);
            methodGetMediationProfileParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetMediationProfile) (Return Type : MediationProfile) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetMediationProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMediationProfile);
            var profileList = this.CreateType<List<GamNonUiView>>();
            var profileId = this.CreateType<int>();
            var methodGetMediationProfileParametersTypes = new Type[] { typeof(List<GamNonUiView>), typeof(int) };
            object[] parametersOfGetMediationProfile = { profileList, profileId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<GridActionMenu.MediationProfile>(MethodGetMediationProfile, parametersOfGetMediationProfile, methodGetMediationProfileParametersTypes);

            // Assert
            parametersOfGetMediationProfile.ShouldNotBeNull();
            parametersOfGetMediationProfile.Length.ShouldBe(2);
            methodGetMediationProfileParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMediationProfile) (Return Type : MediationProfile) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetMediationProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMediationProfile);
            var methodGetMediationProfileParametersTypes = new Type[] { typeof(List<GamNonUiView>), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMediationProfile, methodGetMediationProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMediationProfileParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetMediationProfile) (Return Type : MediationProfile) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetMediationProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMediationProfile);
            var methodGetMediationProfileParametersTypes = new Type[] { typeof(List<GamNonUiView>), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMediationProfile, methodGetMediationProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMediationProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMediationProfile) (Return Type : MediationProfile) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetMediationProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMediationProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMediationProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMediationProfile) (Return Type : MediationProfile) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetMediationProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMediationProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMediationProfile, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEndPointProperties) (Return Type : List<EndPointProperty>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GridActionMenu_GetEndPointProperties_Method_Call_Internally(Type[] types)
        {
            var methodGetEndPointPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEndPointProperties, methodGetEndPointPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetEndPointProperties) (Return Type : List<EndPointProperty>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetEndPointProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndPointProperties);
            var profileList = this.CreateType<List<GamNonUiView>>();
            var endPointId = this.CreateType<int>();

            // Act
            Action executeAction = () => _gridActionMenuInstance.GetEndPointProperties(profileList, endPointId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEndPointProperties) (Return Type : List<EndPointProperty>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetEndPointProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndPointProperties);
            var profileList = this.CreateType<List<GamNonUiView>>();
            var endPointId = this.CreateType<int>();
            var methodGetEndPointPropertiesParametersTypes = new Type[] { typeof(List<GamNonUiView>), typeof(int) };
            object[] parametersOfGetEndPointProperties = { profileList, endPointId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<EndPointProperty>>(MethodGetEndPointProperties, parametersOfGetEndPointProperties, methodGetEndPointPropertiesParametersTypes);

            // Assert
            parametersOfGetEndPointProperties.ShouldNotBeNull();
            parametersOfGetEndPointProperties.Length.ShouldBe(2);
            methodGetEndPointPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEndPointProperties) (Return Type : List<EndPointProperty>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetEndPointProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndPointProperties);
            var methodGetEndPointPropertiesParametersTypes = new Type[] { typeof(List<GamNonUiView>), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEndPointProperties, methodGetEndPointPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEndPointPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEndPointProperties) (Return Type : List<EndPointProperty>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetEndPointProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndPointProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndPointProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEndPointProperties) (Return Type : List<EndPointProperty>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetEndPointProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndPointProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndPointProperties, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GridActionMenu_GetXml_Method_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GridActionMenu_GetXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var profile = this.CreateType<GridActionMenu.GamProfile>();
            var methodGetXmlParametersTypes = new Type[] { typeof(GridActionMenu.GamProfile) };
            object[] parametersOfGetXml = { profile };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_gridActionMenuInstanceFixture, parametersOfGetXml);
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
        public void AUT_GridActionMenu_GetXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var profile = this.CreateType<GridActionMenu.GamProfile>();
            var methodGetXmlParametersTypes = new Type[] { typeof(GridActionMenu.GamProfile) };
            object[] parametersOfGetXml = { profile };

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
        public void AUT_GridActionMenu_GetXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(GridActionMenu.GamProfile) };

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
        public void AUT_GridActionMenu_GetXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(GridActionMenu.GamProfile) };
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
        public void AUT_GridActionMenu_GetXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_GridActionMenu_GetXml_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}