using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.BusinessLayer;
using Onyx.UI.Navigator.Model;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.BusinessLayer.NavigatorSearchBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorSearchBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorSearchBusinessLayer" />)
        /// </summary>
        public NavigatorSearchBusinessLayerTest() : base(typeof(NavigatorSearchBusinessLayer))
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

        #region General Initializer : Class (NavigatorSearchBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorSearchBusinessLayerInstanceType;
        private NavigatorSearchBusinessLayer _navigatorSearchBusinessLayerInstance;
        private NavigatorSearchBusinessLayer _navigatorSearchBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorSearchBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorSearchBusinessLayerInstanceType = typeof(NavigatorSearchBusinessLayer);
            _navigatorSearchBusinessLayerInstanceFixture = this.Create<NavigatorSearchBusinessLayer>(false);
            _navigatorSearchBusinessLayerInstance = _navigatorSearchBusinessLayerInstanceFixture ?? this.Create<NavigatorSearchBusinessLayer>(true);
            CurrentInstance = _navigatorSearchBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorSearchBusinessLayer) Initializer

        #region Methods

        private const string MethodGetNavigatorEntities = "GetNavigatorEntities";
        private const string MethodGetSearchFilters = "GetSearchFilters";
        private const string MethodGetSearchFilterProfile = "GetSearchFilterProfile";
        private const string MethodPutSearchFilterProfile = "PutSearchFilterProfile";
        private const string MethodPutRestoreDefaultSearchFilter = "PutRestoreDefaultSearchFilter";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorSearchBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorSearchBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorSearchBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorSearchBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorSearchBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorSearchBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorSearchBusinessLayer)

        #region General Initializer : Class (NavigatorSearchBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorSearchBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetNavigatorEntities, 0)]
        [TestCase(MethodGetSearchFilters, 0)]
        [TestCase(MethodGetSearchFilterProfile, 0)]
        [TestCase(MethodPutSearchFilterProfile, 0)]
        [TestCase(MethodPutRestoreDefaultSearchFilter, 0)]
        public void AUT_NavigatorSearchBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NavigatorSearchBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorSearchBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorSearchBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorSearchBusinessLayerInstanceType.ShouldNotBeNull();
            _navigatorSearchBusinessLayerInstance.ShouldNotBeNull();
            _navigatorSearchBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorSearchBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorSearchBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorSearchBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorSearchBusinessLayerInstance.ShouldBeAssignableTo<NavigatorSearchBusinessLayer>();
            _navigatorSearchBusinessLayerInstanceFixture.ShouldBeAssignableTo<NavigatorSearchBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorSearchBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorSearchBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorSearchBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NavigatorSearchBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_Call_Internally(Type[] types)
        {
            var methodGetNavigatorEntitiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorSearchBusinessLayerInstance.GetNavigatorEntities(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<NavigatorEntities>);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchBusinessLayerInstance.GetNavigatorEntities(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetNavigatorEntitiesParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetNavigatorEntities = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<NavigatorEntities>>(_navigatorSearchBusinessLayerInstanceFixture, parametersOfGetNavigatorEntities);
            var result2 = this.GetResultOfMethod<List<NavigatorEntities>>(MethodGetNavigatorEntities, parametersOfGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNavigatorEntities.ShouldNotBeNull();
            parametersOfGetNavigatorEntities.Length.ShouldBe(1);
            methodGetNavigatorEntitiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : List<NavigatorEntities>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetNavigatorEntitiesParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetNavigatorEntities = { mainfest };

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
        public void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var methodGetNavigatorEntitiesParametersTypes = new Type[] { typeof(NavigatorManifest) };

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
        public void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var methodGetNavigatorEntitiesParametersTypes = new Type[] { typeof(NavigatorManifest) };
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
        public void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NavigatorSearchBusinessLayer_GetNavigatorEntities_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchFiltersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorSearchBusinessLayerInstance.GetSearchFilters(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<SearchFilter>);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchBusinessLayerInstance.GetSearchFilters(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetSearchFiltersParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetSearchFilters = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<SearchFilter>>(_navigatorSearchBusinessLayerInstanceFixture, parametersOfGetSearchFilters);
            var result2 = this.GetResultOfMethod<List<SearchFilter>>(MethodGetSearchFilters, parametersOfGetSearchFilters, methodGetSearchFiltersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchFilters.ShouldNotBeNull();
            parametersOfGetSearchFilters.Length.ShouldBe(1);
            methodGetSearchFiltersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : List<SearchFilter>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetSearchFiltersParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetSearchFilters = { mainfest };

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
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var methodGetSearchFiltersParametersTypes = new Type[] { typeof(NavigatorManifest) };

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
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var methodGetSearchFiltersParametersTypes = new Type[] { typeof(NavigatorManifest) };
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
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilters_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorSearchBusinessLayerInstance.GetSearchFilterProfile(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(SearchAdminDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchBusinessLayerInstance.GetSearchFilterProfile(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetSearchFilterProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetSearchFilterProfile = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<SearchAdminDataSource>(_navigatorSearchBusinessLayerInstanceFixture, parametersOfGetSearchFilterProfile);
            var result2 = this.GetResultOfMethod<SearchAdminDataSource>(MethodGetSearchFilterProfile, parametersOfGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchFilterProfile.ShouldNotBeNull();
            parametersOfGetSearchFilterProfile.Length.ShouldBe(1);
            methodGetSearchFilterProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetSearchFilterProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetSearchFilterProfile = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SearchAdminDataSource>(MethodGetSearchFilterProfile, parametersOfGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            parametersOfGetSearchFilterProfile.ShouldNotBeNull();
            parametersOfGetSearchFilterProfile.Length.ShouldBe(1);
            methodGetSearchFilterProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var methodGetSearchFilterProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchFilterProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var methodGetSearchFilterProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchFilterProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetSearchFilterProfile) (Return Type : SearchAdminDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_GetSearchFilterProfile_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_Call_Internally(Type[] types)
        {
            var methodPutSearchFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPutSearchFilterProfile, methodPutSearchFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutSearchFilterProfile);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorSearchBusinessLayerInstance.PutSearchFilterProfile(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutSearchFilterProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<ServiceResult>);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchBusinessLayerInstance.PutSearchFilterProfile(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutSearchFilterProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodPutSearchFilterProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfPutSearchFilterProfile = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPutSearchFilterProfile, methodPutSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ServiceResult>>(_navigatorSearchBusinessLayerInstanceFixture, parametersOfPutSearchFilterProfile);
            var result2 = this.GetResultOfMethod<List<ServiceResult>>(MethodPutSearchFilterProfile, parametersOfPutSearchFilterProfile, methodPutSearchFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPutSearchFilterProfile.ShouldNotBeNull();
            parametersOfPutSearchFilterProfile.Length.ShouldBe(1);
            methodPutSearchFilterProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutSearchFilterProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodPutSearchFilterProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfPutSearchFilterProfile = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ServiceResult>>(MethodPutSearchFilterProfile, parametersOfPutSearchFilterProfile, methodPutSearchFilterProfileParametersTypes);

            // Assert
            parametersOfPutSearchFilterProfile.ShouldNotBeNull();
            parametersOfPutSearchFilterProfile.Length.ShouldBe(1);
            methodPutSearchFilterProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutSearchFilterProfile);
            var methodPutSearchFilterProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPutSearchFilterProfile, methodPutSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPutSearchFilterProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutSearchFilterProfile);
            var methodPutSearchFilterProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPutSearchFilterProfile, methodPutSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPutSearchFilterProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodPutSearchFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PutSearchFilterProfile) (Return Type : List<ServiceResult>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutSearchFilterProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodPutSearchFilterProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_Call_Internally(Type[] types)
        {
            var methodPutRestoreDefaultSearchFilterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPutRestoreDefaultSearchFilter, methodPutRestoreDefaultSearchFilterParametersTypes);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultSearchFilter);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorSearchBusinessLayerInstance.PutRestoreDefaultSearchFilter(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultSearchFilter);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(SearchAdminDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchBusinessLayerInstance.PutRestoreDefaultSearchFilter(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultSearchFilter);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodPutRestoreDefaultSearchFilterParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfPutRestoreDefaultSearchFilter = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPutRestoreDefaultSearchFilter, methodPutRestoreDefaultSearchFilterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<SearchAdminDataSource>(_navigatorSearchBusinessLayerInstanceFixture, parametersOfPutRestoreDefaultSearchFilter);
            var result2 = this.GetResultOfMethod<SearchAdminDataSource>(MethodPutRestoreDefaultSearchFilter, parametersOfPutRestoreDefaultSearchFilter, methodPutRestoreDefaultSearchFilterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPutRestoreDefaultSearchFilter.ShouldNotBeNull();
            parametersOfPutRestoreDefaultSearchFilter.Length.ShouldBe(1);
            methodPutRestoreDefaultSearchFilterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultSearchFilter);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodPutRestoreDefaultSearchFilterParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfPutRestoreDefaultSearchFilter = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SearchAdminDataSource>(MethodPutRestoreDefaultSearchFilter, parametersOfPutRestoreDefaultSearchFilter, methodPutRestoreDefaultSearchFilterParametersTypes);

            // Assert
            parametersOfPutRestoreDefaultSearchFilter.ShouldNotBeNull();
            parametersOfPutRestoreDefaultSearchFilter.Length.ShouldBe(1);
            methodPutRestoreDefaultSearchFilterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultSearchFilter);
            var methodPutRestoreDefaultSearchFilterParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPutRestoreDefaultSearchFilter, methodPutRestoreDefaultSearchFilterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPutRestoreDefaultSearchFilterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultSearchFilter);
            var methodPutRestoreDefaultSearchFilterParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPutRestoreDefaultSearchFilter, methodPutRestoreDefaultSearchFilterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPutRestoreDefaultSearchFilterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultSearchFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodPutRestoreDefaultSearchFilter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PutRestoreDefaultSearchFilter) (Return Type : SearchAdminDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchBusinessLayer_PutRestoreDefaultSearchFilter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultSearchFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodPutRestoreDefaultSearchFilter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchBusinessLayer_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchBusinessLayer_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}