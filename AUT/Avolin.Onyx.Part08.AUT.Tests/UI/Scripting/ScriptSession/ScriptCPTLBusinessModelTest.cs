using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.ScriptSession;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.ScriptSession
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScriptCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptCPTLBusinessModel" />)
        /// </summary>
        public ScriptCPTLBusinessModelTest() : base(typeof(ScriptCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptCPTLBusinessModelInstanceType;
        private ScriptCPTLBusinessModel _scriptCPTLBusinessModelInstance;
        private ScriptCPTLBusinessModel _scriptCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptCPTLBusinessModelInstanceType = typeof(ScriptCPTLBusinessModel);
            _scriptCPTLBusinessModelInstanceFixture = this.Create<ScriptCPTLBusinessModel>(false);
            _scriptCPTLBusinessModelInstance = _scriptCPTLBusinessModelInstanceFixture ?? this.Create<ScriptCPTLBusinessModel>(true);
            CurrentInstance = _scriptCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptCPTLBusinessModel) Initializer

        #region Methods

        private const string MethodUpdateSession = "UpdateSession";
        private const string MethodUpdateSessionWithVariable = "UpdateSessionWithVariable";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptCPTLBusinessModel)

        #region General Initializer : Class (ScriptCPTLBusinessModel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptCPTLBusinessModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodUpdateSession, 0)]
        [TestCase(MethodUpdateSessionWithVariable, 0)]
        public void AUT_ScriptCPTLBusinessModel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ScriptCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptCPTLBusinessModel>();
            _scriptCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (UpdateSession) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptSessionCPTLBusinessModel = this.CreateType<ScriptSessionCPTLBusinessModel>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptCPTLBusinessModelInstance.UpdateSession(scriptSessionCPTLBusinessModel, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSession_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptSessionCPTLBusinessModel = this.CreateType<ScriptSessionCPTLBusinessModel>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptSessionCPTLBusinessModel), typeof(List<MessageModel>) };
            object[] parametersOfUpdateSession = { scriptSessionCPTLBusinessModel, messageModels };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSession, methodUpdateSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCPTLBusinessModelInstanceFixture, parametersOfUpdateSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateSession.ShouldNotBeNull();
            parametersOfUpdateSession.Length.ShouldBe(2);
            methodUpdateSessionParametersTypes.Length.ShouldBe(2);
            methodUpdateSessionParametersTypes.Length.ShouldBe(parametersOfUpdateSession.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSession_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptSessionCPTLBusinessModel = this.CreateType<ScriptSessionCPTLBusinessModel>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptSessionCPTLBusinessModel), typeof(List<MessageModel>) };
            object[] parametersOfUpdateSession = { scriptSessionCPTLBusinessModel, messageModels };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateSession, parametersOfUpdateSession, methodUpdateSessionParametersTypes);

            // Assert
            parametersOfUpdateSession.ShouldNotBeNull();
            parametersOfUpdateSession.Length.ShouldBe(2);
            methodUpdateSessionParametersTypes.Length.ShouldBe(2);
            methodUpdateSessionParametersTypes.Length.ShouldBe(parametersOfUpdateSession.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSession, 0);
            const int parametersCount = 2;

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
        public void AUT_ScriptCPTLBusinessModel_UpdateSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptSessionCPTLBusinessModel), typeof(List<MessageModel>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSession, methodUpdateSessionParametersTypes);

            // Assert
            methodUpdateSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSession_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (UpdateSessionWithVariable) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCPTLBusinessModel_UpdateSessionWithVariable_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSessionWithVariableParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSessionWithVariable, methodUpdateSessionWithVariableParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSessionWithVariable) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSessionWithVariable_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionWithVariable);
            var scriptSessionCPTLBusinessModel = this.CreateType<ScriptSessionCPTLBusinessModel>();
            var variablesCPTLBusinessModel = this.CreateType<VariablesCPTLBusinessModel>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _scriptCPTLBusinessModelInstance.UpdateSessionWithVariable(scriptSessionCPTLBusinessModel, variablesCPTLBusinessModel, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSessionWithVariable) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSessionWithVariable_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionWithVariable);
            var scriptSessionCPTLBusinessModel = this.CreateType<ScriptSessionCPTLBusinessModel>();
            var variablesCPTLBusinessModel = this.CreateType<VariablesCPTLBusinessModel>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodUpdateSessionWithVariableParametersTypes = new Type[] { typeof(ScriptSessionCPTLBusinessModel), typeof(VariablesCPTLBusinessModel), typeof(List<MessageModel>) };
            object[] parametersOfUpdateSessionWithVariable = { scriptSessionCPTLBusinessModel, variablesCPTLBusinessModel, messageModels };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSessionWithVariable, methodUpdateSessionWithVariableParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCPTLBusinessModelInstanceFixture, parametersOfUpdateSessionWithVariable);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateSessionWithVariable.ShouldNotBeNull();
            parametersOfUpdateSessionWithVariable.Length.ShouldBe(3);
            methodUpdateSessionWithVariableParametersTypes.Length.ShouldBe(3);
            methodUpdateSessionWithVariableParametersTypes.Length.ShouldBe(parametersOfUpdateSessionWithVariable.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSessionWithVariable) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSessionWithVariable_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionWithVariable);
            var scriptSessionCPTLBusinessModel = this.CreateType<ScriptSessionCPTLBusinessModel>();
            var variablesCPTLBusinessModel = this.CreateType<VariablesCPTLBusinessModel>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodUpdateSessionWithVariableParametersTypes = new Type[] { typeof(ScriptSessionCPTLBusinessModel), typeof(VariablesCPTLBusinessModel), typeof(List<MessageModel>) };
            object[] parametersOfUpdateSessionWithVariable = { scriptSessionCPTLBusinessModel, variablesCPTLBusinessModel, messageModels };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateSessionWithVariable, parametersOfUpdateSessionWithVariable, methodUpdateSessionWithVariableParametersTypes);

            // Assert
            parametersOfUpdateSessionWithVariable.ShouldNotBeNull();
            parametersOfUpdateSessionWithVariable.Length.ShouldBe(3);
            methodUpdateSessionWithVariableParametersTypes.Length.ShouldBe(3);
            methodUpdateSessionWithVariableParametersTypes.Length.ShouldBe(parametersOfUpdateSessionWithVariable.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSessionWithVariable) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSessionWithVariable_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionWithVariable);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSessionWithVariable, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSessionWithVariable) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSessionWithVariable_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionWithVariable);
            var methodUpdateSessionWithVariableParametersTypes = new Type[] { typeof(ScriptSessionCPTLBusinessModel), typeof(VariablesCPTLBusinessModel), typeof(List<MessageModel>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSessionWithVariable, methodUpdateSessionWithVariableParametersTypes);

            // Assert
            methodUpdateSessionWithVariableParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSessionWithVariable) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCPTLBusinessModel_UpdateSessionWithVariable_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionWithVariable);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSessionWithVariable, 0);

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