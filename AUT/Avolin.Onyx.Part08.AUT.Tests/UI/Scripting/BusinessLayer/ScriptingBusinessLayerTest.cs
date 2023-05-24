using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.BusinessLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.ScriptingBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScriptingBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptingBusinessLayer" />)
        /// </summary>
        public ScriptingBusinessLayerTest() : base(typeof(ScriptingBusinessLayer))
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

        #region General Initializer : Class (ScriptingBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptingBusinessLayerInstanceType;
        private ScriptingBusinessLayer _scriptingBusinessLayerInstance;
        private ScriptingBusinessLayer _scriptingBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptingBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptingBusinessLayerInstanceType = typeof(ScriptingBusinessLayer);
            _scriptingBusinessLayerInstanceFixture = this.Create<ScriptingBusinessLayer>(false);
            _scriptingBusinessLayerInstance = _scriptingBusinessLayerInstanceFixture ?? this.Create<ScriptingBusinessLayer>(true);
            CurrentInstance = _scriptingBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptingBusinessLayer) Initializer

        #region Methods

        private const string MethodGetSecurityResources = "GetSecurityResources";
        private const string MethodGetMessageLocalizationResources = "GetMessageLocalizationResources";
        private const string MethodGetSystemLocalizationResources = "GetSystemLocalizationResources";
        private const string MethodGetApplicationResources = "GetApplicationResources";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptingBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptingBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptingBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptingBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptingBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptingBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptingBusinessLayer)

        #region General Initializer : Class (ScriptingBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptingBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSecurityResources, 0)]
        [TestCase(MethodGetMessageLocalizationResources, 0)]
        [TestCase(MethodGetSystemLocalizationResources, 0)]
        [TestCase(MethodGetApplicationResources, 0)]
        public void AUT_ScriptingBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ScriptingBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptingBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _scriptingBusinessLayerInstanceType.ShouldNotBeNull();
            _scriptingBusinessLayerInstance.ShouldNotBeNull();
            _scriptingBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptingBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptingBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptingBusinessLayerInstance.ShouldBeAssignableTo<ScriptingBusinessLayer>();
            _scriptingBusinessLayerInstanceFixture.ShouldBeAssignableTo<ScriptingBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<ScriptingBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptingBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptingBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSecurityResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptingBusinessLayerInstance.GetSecurityResources(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSecurityResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IDictionary<string, string>);

            // Act
            Action executeAction = () => returnedValue = _scriptingBusinessLayerInstance.GetSecurityResources(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSecurityResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetSecurityResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetSecurityResources = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IDictionary<string, string>>(_scriptingBusinessLayerInstanceFixture, parametersOfGetSecurityResources);
            var result2 = this.GetResultOfMethod<IDictionary<string, string>>(MethodGetSecurityResources, parametersOfGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSecurityResources.ShouldNotBeNull();
            parametersOfGetSecurityResources.Length.ShouldBe(1);
            methodGetSecurityResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSecurityResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetSecurityResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetSecurityResources = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IDictionary<string, string>>(MethodGetSecurityResources, parametersOfGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            parametersOfGetSecurityResources.ShouldNotBeNull();
            parametersOfGetSecurityResources.Length.ShouldBe(1);
            methodGetSecurityResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSecurityResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var methodGetSecurityResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSecurityResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSecurityResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var methodGetSecurityResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSecurityResourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSecurityResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSecurityResources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_Call_Internally(Type[] types)
        {
            var methodGetMessageLocalizationResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptingBusinessLayerInstance.GetMessageLocalizationResources(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IDictionary<string, string>);

            // Act
            Action executeAction = () => returnedValue = _scriptingBusinessLayerInstance.GetMessageLocalizationResources(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetMessageLocalizationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetMessageLocalizationResources = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IDictionary<string, string>>(_scriptingBusinessLayerInstanceFixture, parametersOfGetMessageLocalizationResources);
            var result2 = this.GetResultOfMethod<IDictionary<string, string>>(MethodGetMessageLocalizationResources, parametersOfGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMessageLocalizationResources.ShouldNotBeNull();
            parametersOfGetMessageLocalizationResources.Length.ShouldBe(1);
            methodGetMessageLocalizationResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetMessageLocalizationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetMessageLocalizationResources = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IDictionary<string, string>>(MethodGetMessageLocalizationResources, parametersOfGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);

            // Assert
            parametersOfGetMessageLocalizationResources.ShouldNotBeNull();
            parametersOfGetMessageLocalizationResources.Length.ShouldBe(1);
            methodGetMessageLocalizationResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var methodGetMessageLocalizationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMessageLocalizationResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var methodGetMessageLocalizationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMessageLocalizationResourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageLocalizationResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IDictionary<string, string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetMessageLocalizationResources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageLocalizationResources, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_Call_Internally(Type[] types)
        {
            var methodGetSystemLocalizationResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptingBusinessLayerInstance.GetSystemLocalizationResources(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IDictionary<string, string>);

            // Act
            Action executeAction = () => returnedValue = _scriptingBusinessLayerInstance.GetSystemLocalizationResources(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetSystemLocalizationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetSystemLocalizationResources = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IDictionary<string, string>>(_scriptingBusinessLayerInstanceFixture, parametersOfGetSystemLocalizationResources);
            var result2 = this.GetResultOfMethod<IDictionary<string, string>>(MethodGetSystemLocalizationResources, parametersOfGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSystemLocalizationResources.ShouldNotBeNull();
            parametersOfGetSystemLocalizationResources.Length.ShouldBe(1);
            methodGetSystemLocalizationResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetSystemLocalizationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetSystemLocalizationResources = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IDictionary<string, string>>(MethodGetSystemLocalizationResources, parametersOfGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);

            // Assert
            parametersOfGetSystemLocalizationResources.ShouldNotBeNull();
            parametersOfGetSystemLocalizationResources.Length.ShouldBe(1);
            methodGetSystemLocalizationResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var methodGetSystemLocalizationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSystemLocalizationResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var methodGetSystemLocalizationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSystemLocalizationResourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemLocalizationResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IDictionary<string, string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetSystemLocalizationResources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemLocalizationResources, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_Call_Internally(Type[] types)
        {
            var methodGetApplicationResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetApplicationResources, methodGetApplicationResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptingBusinessLayerInstance.GetApplicationResources(messageModels);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IDictionary<string, string>);

            // Act
            Action executeAction = () => returnedValue = _scriptingBusinessLayerInstance.GetApplicationResources(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetApplicationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetApplicationResources = { messageModels };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationResources, methodGetApplicationResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IDictionary<string, string>>(_scriptingBusinessLayerInstanceFixture, out exception1, parametersOfGetApplicationResources);
            var result2 = this.GetResultOfMethod<IDictionary<string, string>>(MethodGetApplicationResources, parametersOfGetApplicationResources, methodGetApplicationResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetApplicationResources.ShouldNotBeNull();
            parametersOfGetApplicationResources.Length.ShouldBe(1);
            methodGetApplicationResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetApplicationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetApplicationResources = { messageModels };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationResources, methodGetApplicationResourcesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptingBusinessLayerInstanceFixture, parametersOfGetApplicationResources);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetApplicationResources.ShouldNotBeNull();
            parametersOfGetApplicationResources.Length.ShouldBe(1);
            methodGetApplicationResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetApplicationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetApplicationResources = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IDictionary<string, string>>(MethodGetApplicationResources, parametersOfGetApplicationResources, methodGetApplicationResourcesParametersTypes);

            // Assert
            parametersOfGetApplicationResources.ShouldNotBeNull();
            parametersOfGetApplicationResources.Length.ShouldBe(1);
            methodGetApplicationResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var methodGetApplicationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetApplicationResources, methodGetApplicationResourcesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetApplicationResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var methodGetApplicationResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetApplicationResources, methodGetApplicationResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetApplicationResourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IDictionary<string, string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingBusinessLayer_GetApplicationResources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationResources, 0);
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