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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.ScriptSessionBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScriptSessionBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptSessionBusinessLayer" />)
        /// </summary>
        public ScriptSessionBusinessLayerTest() : base(typeof(ScriptSessionBusinessLayer))
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

        #region General Initializer : Class (ScriptSessionBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptSessionBusinessLayerInstanceType;
        private ScriptSessionBusinessLayer _scriptSessionBusinessLayerInstance;
        private ScriptSessionBusinessLayer _scriptSessionBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptSessionBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptSessionBusinessLayerInstanceType = typeof(ScriptSessionBusinessLayer);
            _scriptSessionBusinessLayerInstanceFixture = this.Create<ScriptSessionBusinessLayer>(false);
            _scriptSessionBusinessLayerInstance = _scriptSessionBusinessLayerInstanceFixture ?? this.Create<ScriptSessionBusinessLayer>(true);
            CurrentInstance = _scriptSessionBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptSessionBusinessLayer) Initializer

        #region Methods

        private const string MethodUpdateSession = "UpdateSession";

        #endregion

        #endregion
        
        #region General Initializer : Class (ScriptSessionBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptSessionBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptSessionBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptSessionBusinessLayer)

        #region General Initializer : Class (ScriptSessionBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptSessionBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodUpdateSession, 0)]
        public void AUT_ScriptSessionBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ScriptSessionBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptSessionBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _scriptSessionBusinessLayerInstanceType.ShouldNotBeNull();
            _scriptSessionBusinessLayerInstance.ShouldNotBeNull();
            _scriptSessionBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptSessionBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptSessionBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptSessionBusinessLayerInstance.ShouldBeAssignableTo<ScriptSessionBusinessLayer>();
            _scriptSessionBusinessLayerInstanceFixture.ShouldBeAssignableTo<ScriptSessionBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<ScriptSessionBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptSessionBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptSessionBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (UpdateSession) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionBusinessLayer_UpdateSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionBusinessLayerInstance.UpdateSession(scriptModel, messageModels, compatibility);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionBusinessLayer_UpdateSession_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var compatibility = this.CreateType<bool>();
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(List<MessageModel>), typeof(bool) };
            object[] parametersOfUpdateSession = { scriptModel, messageModels, compatibility };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSession, methodUpdateSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptSessionBusinessLayerInstanceFixture, parametersOfUpdateSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateSession.ShouldNotBeNull();
            parametersOfUpdateSession.Length.ShouldBe(3);
            methodUpdateSessionParametersTypes.Length.ShouldBe(3);
            methodUpdateSessionParametersTypes.Length.ShouldBe(parametersOfUpdateSession.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionBusinessLayer_UpdateSession_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var compatibility = this.CreateType<bool>();
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(List<MessageModel>), typeof(bool) };
            object[] parametersOfUpdateSession = { scriptModel, messageModels, compatibility };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateSession, parametersOfUpdateSession, methodUpdateSessionParametersTypes);

            // Assert
            parametersOfUpdateSession.ShouldNotBeNull();
            parametersOfUpdateSession.Length.ShouldBe(3);
            methodUpdateSessionParametersTypes.Length.ShouldBe(3);
            methodUpdateSessionParametersTypes.Length.ShouldBe(parametersOfUpdateSession.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionBusinessLayer_UpdateSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSession, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionBusinessLayer_UpdateSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(List<MessageModel>), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSession, methodUpdateSessionParametersTypes);

            // Assert
            methodUpdateSessionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionBusinessLayer_UpdateSession_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSession, 0);

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