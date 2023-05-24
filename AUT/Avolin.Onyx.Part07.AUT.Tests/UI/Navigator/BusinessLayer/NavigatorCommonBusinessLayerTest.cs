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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.BusinessLayer.NavigatorCommonBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorCommonBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorCommonBusinessLayer" />)
        /// </summary>
        public NavigatorCommonBusinessLayerTest() : base(typeof(NavigatorCommonBusinessLayer))
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

        #region General Initializer : Class (NavigatorCommonBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorCommonBusinessLayerInstanceType;
        private NavigatorCommonBusinessLayer _navigatorCommonBusinessLayerInstance;
        private NavigatorCommonBusinessLayer _navigatorCommonBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorCommonBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorCommonBusinessLayerInstanceType = typeof(NavigatorCommonBusinessLayer);
            _navigatorCommonBusinessLayerInstanceFixture = this.Create<NavigatorCommonBusinessLayer>(false);
            _navigatorCommonBusinessLayerInstance = _navigatorCommonBusinessLayerInstanceFixture ?? this.Create<NavigatorCommonBusinessLayer>(true);
            CurrentInstance = _navigatorCommonBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorCommonBusinessLayer) Initializer

        #region Methods

        private const string MethodGetDockPrivilege = "GetDockPrivilege";
        private const string MethodGetAllUIResources = "GetAllUIResources";
        private const string MethodGetModulePrivilige = "GetModulePrivilige";
        private const string MethodGetRecentKeyword = "GetRecentKeyword";
        private const string MethodCheckService = "CheckService";
        private const string MethodGetAppSettings = "GetAppSettings";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorCommonBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorCommonBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCommonBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorCommonBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorCommonBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCommonBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorCommonBusinessLayer)

        #region General Initializer : Class (NavigatorCommonBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorCommonBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDockPrivilege, 0)]
        [TestCase(MethodGetAllUIResources, 0)]
        [TestCase(MethodGetModulePrivilige, 0)]
        [TestCase(MethodGetRecentKeyword, 0)]
        [TestCase(MethodCheckService, 0)]
        [TestCase(MethodGetAppSettings, 0)]
        public void AUT_NavigatorCommonBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NavigatorCommonBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorCommonBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorCommonBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorCommonBusinessLayerInstanceType.ShouldNotBeNull();
            _navigatorCommonBusinessLayerInstance.ShouldNotBeNull();
            _navigatorCommonBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorCommonBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorCommonBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorCommonBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorCommonBusinessLayerInstance.ShouldBeAssignableTo<NavigatorCommonBusinessLayer>();
            _navigatorCommonBusinessLayerInstanceFixture.ShouldBeAssignableTo<NavigatorCommonBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorCommonBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorCommonBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorCommonBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NavigatorCommonBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_Call_Internally(Type[] types)
        {
            var methodGetDockPrivilegeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDockPrivilege, methodGetDockPrivilegeParametersTypes);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCommonBusinessLayerInstance.GetDockPrivilege(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(AdministrationServiceResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonBusinessLayerInstance.GetDockPrivilege(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetDockPrivilegeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetDockPrivilege = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDockPrivilege, methodGetDockPrivilegeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<AdministrationServiceResult>(_navigatorCommonBusinessLayerInstanceFixture, parametersOfGetDockPrivilege);
            var result2 = this.GetResultOfMethod<AdministrationServiceResult>(MethodGetDockPrivilege, parametersOfGetDockPrivilege, methodGetDockPrivilegeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDockPrivilege.ShouldNotBeNull();
            parametersOfGetDockPrivilege.Length.ShouldBe(1);
            methodGetDockPrivilegeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetDockPrivilegeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetDockPrivilege = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<AdministrationServiceResult>(MethodGetDockPrivilege, parametersOfGetDockPrivilege, methodGetDockPrivilegeParametersTypes);

            // Assert
            parametersOfGetDockPrivilege.ShouldNotBeNull();
            parametersOfGetDockPrivilege.Length.ShouldBe(1);
            methodGetDockPrivilegeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var methodGetDockPrivilegeParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDockPrivilege, methodGetDockPrivilegeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDockPrivilegeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var methodGetDockPrivilegeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDockPrivilege, methodGetDockPrivilegeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDockPrivilegeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDockPrivilege, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : AdministrationServiceResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetDockPrivilege_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDockPrivilege, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_Call_Internally(Type[] types)
        {
            var methodGetAllUIResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCommonBusinessLayerInstance.GetAllUIResources(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<AccessPrivilege>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonBusinessLayerInstance.GetAllUIResources(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetAllUIResourcesParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetAllUIResources = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<AccessPrivilege>>(_navigatorCommonBusinessLayerInstanceFixture, parametersOfGetAllUIResources);
            var result2 = this.GetResultOfMethod<List<AccessPrivilege>>(MethodGetAllUIResources, parametersOfGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAllUIResources.ShouldNotBeNull();
            parametersOfGetAllUIResources.Length.ShouldBe(1);
            methodGetAllUIResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetAllUIResourcesParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetAllUIResources = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<AccessPrivilege>>(MethodGetAllUIResources, parametersOfGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            parametersOfGetAllUIResources.ShouldNotBeNull();
            parametersOfGetAllUIResources.Length.ShouldBe(1);
            methodGetAllUIResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var methodGetAllUIResourcesParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAllUIResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var methodGetAllUIResourcesParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAllUIResourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUIResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : List<AccessPrivilege>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAllUIResources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUIResources, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_Call_Internally(Type[] types)
        {
            var methodGetModulePriviligeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilige, methodGetModulePriviligeParametersTypes);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCommonBusinessLayerInstance.GetModulePrivilige(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(AccessPrivilege);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonBusinessLayerInstance.GetModulePrivilige(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetModulePriviligeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetModulePrivilige = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePrivilige, methodGetModulePriviligeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<AccessPrivilege>(_navigatorCommonBusinessLayerInstanceFixture, parametersOfGetModulePrivilige);
            var result2 = this.GetResultOfMethod<AccessPrivilege>(MethodGetModulePrivilige, parametersOfGetModulePrivilige, methodGetModulePriviligeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetModulePrivilige.ShouldNotBeNull();
            parametersOfGetModulePrivilige.Length.ShouldBe(1);
            methodGetModulePriviligeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetModulePriviligeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetModulePrivilige = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<AccessPrivilege>(MethodGetModulePrivilige, parametersOfGetModulePrivilige, methodGetModulePriviligeParametersTypes);

            // Assert
            parametersOfGetModulePrivilige.ShouldNotBeNull();
            parametersOfGetModulePrivilige.Length.ShouldBe(1);
            methodGetModulePriviligeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var methodGetModulePriviligeParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilige, methodGetModulePriviligeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModulePriviligeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var methodGetModulePriviligeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilige, methodGetModulePriviligeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModulePriviligeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePrivilige, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : AccessPrivilege) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetModulePrivilige_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePrivilige, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_Call_Internally(Type[] types)
        {
            var methodGetRecentKeywordParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRecentKeyword, methodGetRecentKeywordParametersTypes);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCommonBusinessLayerInstance.GetRecentKeyword(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<ReferenceLookup>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonBusinessLayerInstance.GetRecentKeyword(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetRecentKeywordParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetRecentKeyword = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecentKeyword, methodGetRecentKeywordParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ReferenceLookup>>(_navigatorCommonBusinessLayerInstanceFixture, parametersOfGetRecentKeyword);
            var result2 = this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetRecentKeyword, parametersOfGetRecentKeyword, methodGetRecentKeywordParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRecentKeyword.ShouldNotBeNull();
            parametersOfGetRecentKeyword.Length.ShouldBe(1);
            methodGetRecentKeywordParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetRecentKeywordParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetRecentKeyword = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetRecentKeyword, parametersOfGetRecentKeyword, methodGetRecentKeywordParametersTypes);

            // Assert
            parametersOfGetRecentKeyword.ShouldNotBeNull();
            parametersOfGetRecentKeyword.Length.ShouldBe(1);
            methodGetRecentKeywordParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var methodGetRecentKeywordParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRecentKeyword, methodGetRecentKeywordParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRecentKeywordParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var methodGetRecentKeywordParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRecentKeyword, methodGetRecentKeywordParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRecentKeywordParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecentKeyword, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : List<ReferenceLookup>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetRecentKeyword_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecentKeyword, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonBusinessLayer_CheckService_Method_Call_Internally(Type[] types)
        {
            var methodCheckServiceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckService, methodCheckServiceParametersTypes);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_CheckService_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCommonBusinessLayerInstance.CheckService(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_CheckService_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonBusinessLayerInstance.CheckService(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_CheckService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodCheckServiceParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfCheckService = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckService, methodCheckServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorCommonBusinessLayerInstanceFixture, parametersOfCheckService);
            var result2 = this.GetResultOfMethod<string>(MethodCheckService, parametersOfCheckService, methodCheckServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCheckService.ShouldNotBeNull();
            parametersOfCheckService.Length.ShouldBe(1);
            methodCheckServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_CheckService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodCheckServiceParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfCheckService = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCheckService, parametersOfCheckService, methodCheckServiceParametersTypes);

            // Assert
            parametersOfCheckService.ShouldNotBeNull();
            parametersOfCheckService.Length.ShouldBe(1);
            methodCheckServiceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_CheckService_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var methodCheckServiceParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckService, methodCheckServiceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCheckServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_CheckService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var methodCheckServiceParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckService, methodCheckServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckServiceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_CheckService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckService, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_CheckService_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckService, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_Call_Internally(Type[] types)
        {
            var methodGetAppSettingsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCommonBusinessLayerInstance.GetAppSettings(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(AppSettings);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonBusinessLayerInstance.GetAppSettings(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetAppSettings = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, methodGetAppSettingsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<AppSettings>(_navigatorCommonBusinessLayerInstanceFixture, parametersOfGetAppSettings);
            var result2 = this.GetResultOfMethod<AppSettings>(MethodGetAppSettings, parametersOfGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAppSettings.ShouldNotBeNull();
            parametersOfGetAppSettings.Length.ShouldBe(1);
            methodGetAppSettingsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : AppSettings) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetAppSettings = { mainfest };

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
        public void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(NavigatorManifest) };

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
        public void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(NavigatorManifest) };
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
        public void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NavigatorCommonBusinessLayer_GetAppSettings_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonBusinessLayer_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonBusinessLayer_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}