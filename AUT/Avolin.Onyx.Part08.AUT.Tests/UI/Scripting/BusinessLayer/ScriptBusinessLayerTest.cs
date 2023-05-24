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
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.ScriptBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScriptBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptBusinessLayer" />)
        /// </summary>
        public ScriptBusinessLayerTest() : base(typeof(ScriptBusinessLayer))
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

        #region General Initializer : Class (ScriptBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptBusinessLayerInstanceType;
        private ScriptBusinessLayer _scriptBusinessLayerInstance;
        private ScriptBusinessLayer _scriptBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptBusinessLayerInstanceType = typeof(ScriptBusinessLayer);
            _scriptBusinessLayerInstanceFixture = this.Create<ScriptBusinessLayer>(false);
            _scriptBusinessLayerInstance = _scriptBusinessLayerInstanceFixture ?? this.Create<ScriptBusinessLayer>(true);
            CurrentInstance = _scriptBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptBusinessLayer) Initializer

        #region Methods

        private const string MethodGetScriptList = "GetScriptList";
        private const string MethodGetScriptForOegRefId = "GetScriptForOegRefId";
        private const string MethodGetScript = "GetScript";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptBusinessLayer)

        #region General Initializer : Class (ScriptBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetScriptList, 0)]
        [TestCase(MethodGetScriptForOegRefId, 0)]
        [TestCase(MethodGetScript, 0)]
        public void AUT_ScriptBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ScriptBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _scriptBusinessLayerInstanceType.ShouldNotBeNull();
            _scriptBusinessLayerInstance.ShouldNotBeNull();
            _scriptBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptBusinessLayerInstance.ShouldBeAssignableTo<ScriptBusinessLayer>();
            _scriptBusinessLayerInstanceFixture.ShouldBeAssignableTo<ScriptBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<ScriptBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetScriptList) (Return Type : List<ScriptMetadataModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptBusinessLayerInstance.GetScriptList(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : List<ScriptMetadataModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(List<ScriptMetadataModel>);

            // Act
            Action executeAction = () => returnedValue = _scriptBusinessLayerInstance.GetScriptList(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : List<ScriptMetadataModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetScriptListParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetScriptList = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptList, methodGetScriptListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ScriptMetadataModel>>(_scriptBusinessLayerInstanceFixture, parametersOfGetScriptList);
            var result2 = this.GetResultOfMethod<List<ScriptMetadataModel>>(MethodGetScriptList, parametersOfGetScriptList, methodGetScriptListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScriptList.ShouldNotBeNull();
            parametersOfGetScriptList.Length.ShouldBe(1);
            methodGetScriptListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : List<ScriptMetadataModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetScriptListParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetScriptList = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ScriptMetadataModel>>(MethodGetScriptList, parametersOfGetScriptList, methodGetScriptListParametersTypes);

            // Assert
            parametersOfGetScriptList.ShouldNotBeNull();
            parametersOfGetScriptList.Length.ShouldBe(1);
            methodGetScriptListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : List<ScriptMetadataModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var methodGetScriptListParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScriptList, methodGetScriptListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : List<ScriptMetadataModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var methodGetScriptListParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptList, methodGetScriptListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : List<ScriptMetadataModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : List<ScriptMetadataModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptList, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptForOegRefIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScriptForOegRefId, methodGetScriptForOegRefIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptForOegRefId);
            var oegRefId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptBusinessLayerInstance.GetScriptForOegRefId(oegRefId, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptForOegRefId);
            var oegRefId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(ScriptMetadataModel);

            // Act
            Action executeAction = () => returnedValue = _scriptBusinessLayerInstance.GetScriptForOegRefId(oegRefId, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptForOegRefId);
            var oegRefId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetScriptForOegRefIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetScriptForOegRefId = { oegRefId, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptForOegRefId, methodGetScriptForOegRefIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ScriptMetadataModel>(_scriptBusinessLayerInstanceFixture, parametersOfGetScriptForOegRefId);
            var result2 = this.GetResultOfMethod<ScriptMetadataModel>(MethodGetScriptForOegRefId, parametersOfGetScriptForOegRefId, methodGetScriptForOegRefIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScriptForOegRefId.ShouldNotBeNull();
            parametersOfGetScriptForOegRefId.Length.ShouldBe(2);
            methodGetScriptForOegRefIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptForOegRefId);
            var oegRefId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetScriptForOegRefIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetScriptForOegRefId = { oegRefId, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ScriptMetadataModel>(MethodGetScriptForOegRefId, parametersOfGetScriptForOegRefId, methodGetScriptForOegRefIdParametersTypes);

            // Assert
            parametersOfGetScriptForOegRefId.ShouldNotBeNull();
            parametersOfGetScriptForOegRefId.Length.ShouldBe(2);
            methodGetScriptForOegRefIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptForOegRefId);
            var methodGetScriptForOegRefIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScriptForOegRefId, methodGetScriptForOegRefIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptForOegRefIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptForOegRefId);
            var methodGetScriptForOegRefIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptForOegRefId, methodGetScriptForOegRefIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptForOegRefIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptForOegRefId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptForOegRefId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptForOegRefId) (Return Type : ScriptMetadataModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScriptForOegRefId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptForOegRefId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptForOegRefId, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptBusinessLayer_GetScript_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScript, methodGetScriptParametersTypes);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScript_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var scriptId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptBusinessLayerInstance.GetScript(scriptId, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScript_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var scriptId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(ScriptMetadataModel);

            // Act
            Action executeAction = () => returnedValue = _scriptBusinessLayerInstance.GetScript(scriptId, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScript_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var scriptId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetScriptParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetScript = { scriptId, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScript, methodGetScriptParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ScriptMetadataModel>(_scriptBusinessLayerInstanceFixture, parametersOfGetScript);
            var result2 = this.GetResultOfMethod<ScriptMetadataModel>(MethodGetScript, parametersOfGetScript, methodGetScriptParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScript.ShouldNotBeNull();
            parametersOfGetScript.Length.ShouldBe(2);
            methodGetScriptParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScript_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var scriptId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetScriptParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetScript = { scriptId, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ScriptMetadataModel>(MethodGetScript, parametersOfGetScript, methodGetScriptParametersTypes);

            // Assert
            parametersOfGetScript.ShouldNotBeNull();
            parametersOfGetScript.Length.ShouldBe(2);
            methodGetScriptParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScript_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var methodGetScriptParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScript, methodGetScriptParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScript_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var methodGetScriptParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScript, methodGetScriptParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScript_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScript, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : ScriptMetadataModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptBusinessLayer_GetScript_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScript, 0);
            const int parametersCount = 2;

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