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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.BusinessLayer.NavigatorCacheBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorCacheBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorCacheBusinessLayer" />)
        /// </summary>
        public NavigatorCacheBusinessLayerTest() : base(typeof(NavigatorCacheBusinessLayer))
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

        #region General Initializer : Class (NavigatorCacheBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorCacheBusinessLayerInstanceType;
        private NavigatorCacheBusinessLayer _navigatorCacheBusinessLayerInstance;
        private NavigatorCacheBusinessLayer _navigatorCacheBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorCacheBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorCacheBusinessLayerInstanceType = typeof(NavigatorCacheBusinessLayer);
            _navigatorCacheBusinessLayerInstanceFixture = this.Create<NavigatorCacheBusinessLayer>(false);
            _navigatorCacheBusinessLayerInstance = _navigatorCacheBusinessLayerInstanceFixture ?? this.Create<NavigatorCacheBusinessLayer>(true);
            CurrentInstance = _navigatorCacheBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorCacheBusinessLayer) Initializer

        #region Methods

        private const string MethodGetDateOperator = "GetDateOperator";
        private const string MethodGetOperatorEnumerator = "GetOperatorEnumerator";
        private const string MethodGetEmailPriority = "GetEmailPriority";
        private const string MethodGetScriptStatus = "GetScriptStatus";
        private const string MethodGetRegionsCache = "GetRegionsCache";
        private const string MethodGetCountriesCache = "GetCountriesCache";
        private const string MethodGetReferenceLookUpCache = "GetReferenceLookUpCache";
        private const string MethodGetScriptPicker = "GetScriptPicker";
        private const string MethodGetProductPicker = "GetProductPicker";
        private const string MethodGetIncidentProduct = "GetIncidentProduct";
        private const string MethodGetUserTree = "GetUserTree";
        private const string MethodGetCampaignTree = "GetCampaignTree";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorCacheBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorCacheBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCacheBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorCacheBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorCacheBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCacheBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorCacheBusinessLayer)

        #region General Initializer : Class (NavigatorCacheBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorCacheBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDateOperator, 0)]
        [TestCase(MethodGetOperatorEnumerator, 0)]
        [TestCase(MethodGetEmailPriority, 0)]
        [TestCase(MethodGetScriptStatus, 0)]
        [TestCase(MethodGetRegionsCache, 0)]
        [TestCase(MethodGetCountriesCache, 0)]
        [TestCase(MethodGetReferenceLookUpCache, 0)]
        [TestCase(MethodGetScriptPicker, 0)]
        [TestCase(MethodGetProductPicker, 0)]
        [TestCase(MethodGetIncidentProduct, 0)]
        [TestCase(MethodGetUserTree, 0)]
        [TestCase(MethodGetCampaignTree, 0)]
        public void AUT_NavigatorCacheBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NavigatorCacheBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorCacheBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorCacheBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorCacheBusinessLayerInstanceType.ShouldNotBeNull();
            _navigatorCacheBusinessLayerInstance.ShouldNotBeNull();
            _navigatorCacheBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorCacheBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorCacheBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorCacheBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorCacheBusinessLayerInstance.ShouldBeAssignableTo<NavigatorCacheBusinessLayer>();
            _navigatorCacheBusinessLayerInstanceFixture.ShouldBeAssignableTo<NavigatorCacheBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorCacheBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorCacheBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorCacheBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NavigatorCacheBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_Call_Internally(Type[] types)
        {
            var methodGetDateOperatorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDateOperator, methodGetDateOperatorParametersTypes);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetDateOperator(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<DateEnumeration>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetDateOperator(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetDateOperatorParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetDateOperator = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateOperator, methodGetDateOperatorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DateEnumeration>>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetDateOperator);
            var result2 = this.GetResultOfMethod<List<DateEnumeration>>(MethodGetDateOperator, parametersOfGetDateOperator, methodGetDateOperatorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDateOperator.ShouldNotBeNull();
            parametersOfGetDateOperator.Length.ShouldBe(1);
            methodGetDateOperatorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetDateOperatorParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetDateOperator = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DateEnumeration>>(MethodGetDateOperator, parametersOfGetDateOperator, methodGetDateOperatorParametersTypes);

            // Assert
            parametersOfGetDateOperator.ShouldNotBeNull();
            parametersOfGetDateOperator.Length.ShouldBe(1);
            methodGetDateOperatorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var methodGetDateOperatorParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDateOperator, methodGetDateOperatorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDateOperatorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var methodGetDateOperatorParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDateOperator, methodGetDateOperatorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDateOperatorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateOperator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : List<DateEnumeration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetDateOperator_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateOperator, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_Call_Internally(Type[] types)
        {
            var methodGetOperatorEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetOperatorEnumerator(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<OperatorData>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetOperatorEnumerator(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetOperatorEnumeratorParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetOperatorEnumerator = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<OperatorData>>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetOperatorEnumerator);
            var result2 = this.GetResultOfMethod<List<OperatorData>>(MethodGetOperatorEnumerator, parametersOfGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOperatorEnumerator.ShouldNotBeNull();
            parametersOfGetOperatorEnumerator.Length.ShouldBe(1);
            methodGetOperatorEnumeratorParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : List<OperatorData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetOperatorEnumeratorParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetOperatorEnumerator = { mainfest };

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
        public void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var methodGetOperatorEnumeratorParametersTypes = new Type[] { typeof(NavigatorManifest) };

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
        public void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var methodGetOperatorEnumeratorParametersTypes = new Type[] { typeof(NavigatorManifest) };
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
        public void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NavigatorCacheBusinessLayer_GetOperatorEnumerator_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailPriorityParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetEmailPriority(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<DomainData>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetEmailPriority(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetEmailPriorityParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetEmailPriority = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DomainData>>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetEmailPriority);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetEmailPriority, parametersOfGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEmailPriority.ShouldNotBeNull();
            parametersOfGetEmailPriority.Length.ShouldBe(1);
            methodGetEmailPriorityParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetEmailPriorityParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetEmailPriority = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetEmailPriority, parametersOfGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            parametersOfGetEmailPriority.ShouldNotBeNull();
            parametersOfGetEmailPriority.Length.ShouldBe(1);
            methodGetEmailPriorityParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var methodGetEmailPriorityParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEmailPriorityParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var methodGetEmailPriorityParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailPriorityParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailPriority, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : List<DomainData>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetEmailPriority_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailPriority, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScriptStatus, methodGetScriptStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetScriptStatus(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<DomainData>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetScriptStatus(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetScriptStatusParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetScriptStatus = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptStatus, methodGetScriptStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<DomainData>>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetScriptStatus);
            var result2 = this.GetResultOfMethod<List<DomainData>>(MethodGetScriptStatus, parametersOfGetScriptStatus, methodGetScriptStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScriptStatus.ShouldNotBeNull();
            parametersOfGetScriptStatus.Length.ShouldBe(1);
            methodGetScriptStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetScriptStatusParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetScriptStatus = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<DomainData>>(MethodGetScriptStatus, parametersOfGetScriptStatus, methodGetScriptStatusParametersTypes);

            // Assert
            parametersOfGetScriptStatus.ShouldNotBeNull();
            parametersOfGetScriptStatus.Length.ShouldBe(1);
            methodGetScriptStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var methodGetScriptStatusParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScriptStatus, methodGetScriptStatusParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var methodGetScriptStatusParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptStatus, methodGetScriptStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptStatusParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptStatus) (Return Type : List<DomainData>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptStatus_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptStatus, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_Call_Internally(Type[] types)
        {
            var methodGetRegionsCacheParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRegionsCache, methodGetRegionsCacheParametersTypes);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetRegionsCache(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<Region>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetRegionsCache(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetRegionsCacheParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetRegionsCache = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionsCache, methodGetRegionsCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<Region>>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetRegionsCache);
            var result2 = this.GetResultOfMethod<List<Region>>(MethodGetRegionsCache, parametersOfGetRegionsCache, methodGetRegionsCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRegionsCache.ShouldNotBeNull();
            parametersOfGetRegionsCache.Length.ShouldBe(1);
            methodGetRegionsCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetRegionsCacheParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetRegionsCache = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<Region>>(MethodGetRegionsCache, parametersOfGetRegionsCache, methodGetRegionsCacheParametersTypes);

            // Assert
            parametersOfGetRegionsCache.ShouldNotBeNull();
            parametersOfGetRegionsCache.Length.ShouldBe(1);
            methodGetRegionsCacheParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var methodGetRegionsCacheParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRegionsCache, methodGetRegionsCacheParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRegionsCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var methodGetRegionsCacheParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRegionsCache, methodGetRegionsCacheParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRegionsCacheParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionsCache, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : List<Region>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetRegionsCache_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionsCache, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_Call_Internally(Type[] types)
        {
            var methodGetCountriesCacheParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCountriesCache, methodGetCountriesCacheParametersTypes);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetCountriesCache(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<Country>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetCountriesCache(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetCountriesCacheParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetCountriesCache = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountriesCache, methodGetCountriesCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<Country>>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetCountriesCache);
            var result2 = this.GetResultOfMethod<List<Country>>(MethodGetCountriesCache, parametersOfGetCountriesCache, methodGetCountriesCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCountriesCache.ShouldNotBeNull();
            parametersOfGetCountriesCache.Length.ShouldBe(1);
            methodGetCountriesCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetCountriesCacheParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetCountriesCache = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<Country>>(MethodGetCountriesCache, parametersOfGetCountriesCache, methodGetCountriesCacheParametersTypes);

            // Assert
            parametersOfGetCountriesCache.ShouldNotBeNull();
            parametersOfGetCountriesCache.Length.ShouldBe(1);
            methodGetCountriesCacheParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var methodGetCountriesCacheParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountriesCache, methodGetCountriesCacheParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCountriesCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var methodGetCountriesCacheParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCountriesCache, methodGetCountriesCacheParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCountriesCacheParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountriesCache, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : List<Country>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCountriesCache_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountriesCache, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_Call_Internally(Type[] types)
        {
            var methodGetReferenceLookUpCacheParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var mainfest = this.CreateType<List<NavigatorManifest>>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetReferenceLookUpCache(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var returnedValue = default(List<ReferenceLookup>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetReferenceLookUpCache(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetReferenceLookUpCacheParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetReferenceLookUpCache = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ReferenceLookup>>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetReferenceLookUpCache);
            var result2 = this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetReferenceLookUpCache, parametersOfGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReferenceLookUpCache.ShouldNotBeNull();
            parametersOfGetReferenceLookUpCache.Length.ShouldBe(1);
            methodGetReferenceLookUpCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetReferenceLookUpCacheParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetReferenceLookUpCache = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ReferenceLookup>>(MethodGetReferenceLookUpCache, parametersOfGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);

            // Assert
            parametersOfGetReferenceLookUpCache.ShouldNotBeNull();
            parametersOfGetReferenceLookUpCache.Length.ShouldBe(1);
            methodGetReferenceLookUpCacheParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var methodGetReferenceLookUpCacheParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReferenceLookUpCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var methodGetReferenceLookUpCacheParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReferenceLookUpCacheParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookUpCache, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : List<ReferenceLookup>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetReferenceLookUpCache_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookUpCache, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptPickerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScriptPicker, methodGetScriptPickerParametersTypes);
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptPicker);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetScriptPicker(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptPicker);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(ScriptTreeDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetScriptPicker(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptPicker);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetScriptPickerParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetScriptPicker = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptPicker, methodGetScriptPickerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ScriptTreeDataSource>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetScriptPicker);
            var result2 = this.GetResultOfMethod<ScriptTreeDataSource>(MethodGetScriptPicker, parametersOfGetScriptPicker, methodGetScriptPickerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScriptPicker.ShouldNotBeNull();
            parametersOfGetScriptPicker.Length.ShouldBe(1);
            methodGetScriptPickerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptPicker);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetScriptPickerParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetScriptPicker = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ScriptTreeDataSource>(MethodGetScriptPicker, parametersOfGetScriptPicker, methodGetScriptPickerParametersTypes);

            // Assert
            parametersOfGetScriptPicker.ShouldNotBeNull();
            parametersOfGetScriptPicker.Length.ShouldBe(1);
            methodGetScriptPickerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptPicker);
            var methodGetScriptPickerParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScriptPicker, methodGetScriptPickerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptPickerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptPicker);
            var methodGetScriptPickerParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptPicker, methodGetScriptPickerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptPickerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptPicker);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptPicker, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptPicker) (Return Type : ScriptTreeDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetScriptPicker_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptPicker);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptPicker, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_Call_Internally(Type[] types)
        {
            var methodGetProductPickerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductPicker, methodGetProductPickerParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetProductPicker(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(ProductTreeDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetProductPicker(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetProductPickerParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetProductPicker = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductPicker, methodGetProductPickerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ProductTreeDataSource>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetProductPicker);
            var result2 = this.GetResultOfMethod<ProductTreeDataSource>(MethodGetProductPicker, parametersOfGetProductPicker, methodGetProductPickerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProductPicker.ShouldNotBeNull();
            parametersOfGetProductPicker.Length.ShouldBe(1);
            methodGetProductPickerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetProductPickerParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetProductPicker = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ProductTreeDataSource>(MethodGetProductPicker, parametersOfGetProductPicker, methodGetProductPickerParametersTypes);

            // Assert
            parametersOfGetProductPicker.ShouldNotBeNull();
            parametersOfGetProductPicker.Length.ShouldBe(1);
            methodGetProductPickerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var methodGetProductPickerParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProductPicker, methodGetProductPickerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductPickerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var methodGetProductPickerParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductPicker, methodGetProductPickerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductPickerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductPicker, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : ProductTreeDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetProductPicker_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductPicker, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentProductParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetIncidentProduct(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<IncidentProduct>);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetIncidentProduct(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetIncidentProductParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetIncidentProduct = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<IncidentProduct>>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetIncidentProduct);
            var result2 = this.GetResultOfMethod<List<IncidentProduct>>(MethodGetIncidentProduct, parametersOfGetIncidentProduct, methodGetIncidentProductParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentProduct.ShouldNotBeNull();
            parametersOfGetIncidentProduct.Length.ShouldBe(1);
            methodGetIncidentProductParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : List<IncidentProduct>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetIncidentProductParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetIncidentProduct = { mainfest };

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
        public void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var methodGetIncidentProductParametersTypes = new Type[] { typeof(NavigatorManifest) };

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
        public void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var methodGetIncidentProductParametersTypes = new Type[] { typeof(NavigatorManifest) };
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
        public void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NavigatorCacheBusinessLayer_GetIncidentProduct_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_Call_Internally(Type[] types)
        {
            var methodGetUserTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserTree, methodGetUserTreeParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var mainfest = this.CreateType<List<NavigatorManifest>>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetUserTree(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var returnedValue = default(HierarchicalDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetUserTree(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetUserTreeParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetUserTree = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTree, methodGetUserTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<HierarchicalDataSource>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetUserTree);
            var result2 = this.GetResultOfMethod<HierarchicalDataSource>(MethodGetUserTree, parametersOfGetUserTree, methodGetUserTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserTree.ShouldNotBeNull();
            parametersOfGetUserTree.Length.ShouldBe(1);
            methodGetUserTreeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetUserTreeParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetUserTree = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<HierarchicalDataSource>(MethodGetUserTree, parametersOfGetUserTree, methodGetUserTreeParametersTypes);

            // Assert
            parametersOfGetUserTree.ShouldNotBeNull();
            parametersOfGetUserTree.Length.ShouldBe(1);
            methodGetUserTreeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var methodGetUserTreeParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserTree, methodGetUserTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserTreeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var methodGetUserTreeParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserTree, methodGetUserTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserTreeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : HierarchicalDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetUserTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTree, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_Call_Internally(Type[] types)
        {
            var methodGetCampaignTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCampaignTree, methodGetCampaignTreeParametersTypes);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var mainfest = this.CreateType<List<NavigatorManifest>>();

            // Act
            Action executeAction = () => _navigatorCacheBusinessLayerInstance.GetCampaignTree(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var returnedValue = default(CampaignTreeDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheBusinessLayerInstance.GetCampaignTree(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetCampaignTreeParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetCampaignTree = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTree, methodGetCampaignTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<CampaignTreeDataSource>(_navigatorCacheBusinessLayerInstanceFixture, parametersOfGetCampaignTree);
            var result2 = this.GetResultOfMethod<CampaignTreeDataSource>(MethodGetCampaignTree, parametersOfGetCampaignTree, methodGetCampaignTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCampaignTree.ShouldNotBeNull();
            parametersOfGetCampaignTree.Length.ShouldBe(1);
            methodGetCampaignTreeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetCampaignTreeParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetCampaignTree = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CampaignTreeDataSource>(MethodGetCampaignTree, parametersOfGetCampaignTree, methodGetCampaignTreeParametersTypes);

            // Assert
            parametersOfGetCampaignTree.ShouldNotBeNull();
            parametersOfGetCampaignTree.Length.ShouldBe(1);
            methodGetCampaignTreeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var methodGetCampaignTreeParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCampaignTree, methodGetCampaignTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCampaignTreeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var methodGetCampaignTreeParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCampaignTree, methodGetCampaignTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCampaignTreeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : CampaignTreeDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheBusinessLayer_GetCampaignTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTree, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheBusinessLayer_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}