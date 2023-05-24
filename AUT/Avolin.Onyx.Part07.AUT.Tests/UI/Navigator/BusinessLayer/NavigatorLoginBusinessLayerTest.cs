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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.BusinessLayer.NavigatorLoginBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorLoginBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorLoginBusinessLayer" />)
        /// </summary>
        public NavigatorLoginBusinessLayerTest() : base(typeof(NavigatorLoginBusinessLayer))
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

        #region General Initializer : Class (NavigatorLoginBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorLoginBusinessLayerInstanceType;
        private NavigatorLoginBusinessLayer _navigatorLoginBusinessLayerInstance;
        private NavigatorLoginBusinessLayer _navigatorLoginBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorLoginBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorLoginBusinessLayerInstanceType = typeof(NavigatorLoginBusinessLayer);
            _navigatorLoginBusinessLayerInstanceFixture = this.Create<NavigatorLoginBusinessLayer>(false);
            _navigatorLoginBusinessLayerInstance = _navigatorLoginBusinessLayerInstanceFixture ?? this.Create<NavigatorLoginBusinessLayer>(true);
            CurrentInstance = _navigatorLoginBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorLoginBusinessLayer) Initializer

        #region Methods

        private const string MethodGetUserProfile = "GetUserProfile";
        private const string MethodGetDefaultUserProfile = "GetDefaultUserProfile";
        private const string MethodGetUserPreferenceByName = "GetUserPreferenceByName";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorLoginBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorLoginBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorLoginBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorLoginBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorLoginBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorLoginBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorLoginBusinessLayer)

        #region General Initializer : Class (NavigatorLoginBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorLoginBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetUserProfile, 0)]
        [TestCase(MethodGetDefaultUserProfile, 0)]
        [TestCase(MethodGetUserPreferenceByName, 0)]
        public void AUT_NavigatorLoginBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NavigatorLoginBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorLoginBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorLoginBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorLoginBusinessLayerInstanceType.ShouldNotBeNull();
            _navigatorLoginBusinessLayerInstance.ShouldNotBeNull();
            _navigatorLoginBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorLoginBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorLoginBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorLoginBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorLoginBusinessLayerInstance.ShouldBeAssignableTo<NavigatorLoginBusinessLayer>();
            _navigatorLoginBusinessLayerInstanceFixture.ShouldBeAssignableTo<NavigatorLoginBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorLoginBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorLoginBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorLoginBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NavigatorLoginBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetUserProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserProfile, methodGetUserProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorLoginBusinessLayerInstance.GetUserProfile(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<ListItem>);

            // Act
            Action executeAction = () => returnedValue = _navigatorLoginBusinessLayerInstance.GetUserProfile(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetUserProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetUserProfile = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserProfile, methodGetUserProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ListItem>>(_navigatorLoginBusinessLayerInstanceFixture, parametersOfGetUserProfile);
            var result2 = this.GetResultOfMethod<List<ListItem>>(MethodGetUserProfile, parametersOfGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserProfile.ShouldNotBeNull();
            parametersOfGetUserProfile.Length.ShouldBe(1);
            methodGetUserProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetUserProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetUserProfile = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ListItem>>(MethodGetUserProfile, parametersOfGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            parametersOfGetUserProfile.ShouldNotBeNull();
            parametersOfGetUserProfile.Length.ShouldBe(1);
            methodGetUserProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var methodGetUserProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var methodGetUserProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : List<ListItem>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetDefaultUserProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorLoginBusinessLayerInstance.GetDefaultUserProfile(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<ListItem>);

            // Act
            Action executeAction = () => returnedValue = _navigatorLoginBusinessLayerInstance.GetDefaultUserProfile(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetDefaultUserProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetDefaultUserProfile = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ListItem>>(_navigatorLoginBusinessLayerInstanceFixture, parametersOfGetDefaultUserProfile);
            var result2 = this.GetResultOfMethod<List<ListItem>>(MethodGetDefaultUserProfile, parametersOfGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDefaultUserProfile.ShouldNotBeNull();
            parametersOfGetDefaultUserProfile.Length.ShouldBe(1);
            methodGetDefaultUserProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetDefaultUserProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetDefaultUserProfile = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ListItem>>(MethodGetDefaultUserProfile, parametersOfGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            parametersOfGetDefaultUserProfile.ShouldNotBeNull();
            parametersOfGetDefaultUserProfile.Length.ShouldBe(1);
            methodGetDefaultUserProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var methodGetDefaultUserProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDefaultUserProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var methodGetDefaultUserProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDefaultUserProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : List<ListItem>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetDefaultUserProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_Call_Internally(Type[] types)
        {
            var methodGetUserPreferenceByNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorLoginBusinessLayerInstance.GetUserPreferenceByName(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<UserPreference>);

            // Act
            Action executeAction = () => returnedValue = _navigatorLoginBusinessLayerInstance.GetUserPreferenceByName(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetUserPreferenceByNameParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetUserPreferenceByName = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<UserPreference>>(_navigatorLoginBusinessLayerInstanceFixture, parametersOfGetUserPreferenceByName);
            var result2 = this.GetResultOfMethod<List<UserPreference>>(MethodGetUserPreferenceByName, parametersOfGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserPreferenceByName.ShouldNotBeNull();
            parametersOfGetUserPreferenceByName.Length.ShouldBe(1);
            methodGetUserPreferenceByNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : List<UserPreference>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetUserPreferenceByNameParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetUserPreferenceByName = { mainfest };

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
        public void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var methodGetUserPreferenceByNameParametersTypes = new Type[] { typeof(NavigatorManifest) };

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
        public void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var methodGetUserPreferenceByNameParametersTypes = new Type[] { typeof(NavigatorManifest) };
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
        public void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_NavigatorLoginBusinessLayer_GetUserPreferenceByName_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorLoginBusinessLayer_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorLoginBusinessLayer_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}