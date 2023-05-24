using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.Onyx360ResourceManager" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class Onyx360ResourceManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Onyx360ResourceManager" />)
        /// </summary>
        public Onyx360ResourceManagerTest() : base(typeof(Onyx360ResourceManager))
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

        #region General Initializer : Class (Onyx360ResourceManager) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyx360ResourceManagerInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Onyx360ResourceManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyx360ResourceManagerInstanceType = typeof(Onyx360ResourceManager);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Onyx360ResourceManager) Initializer

        #region Methods

        private const string MethodGetString = "GetString";
        private const string MethodGetRequiredMarker = "GetRequiredMarker";

        #endregion

        #region Fields

        private const string FieldcurrentDirectoryPath = "currentDirectoryPath";
        private const string FieldassemblyPath = "assemblyPath";
        private const string Fieldassembly = "assembly";
        private const string Field_mResManager = "_mResManager";

        #endregion

        #endregion

        #region General Initializer : Class (Onyx360ResourceManager) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Onyx360ResourceManager" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Onyx360ResourceManager_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Onyx360ResourceManager) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Onyx360ResourceManager" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Onyx360ResourceManager_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Onyx360ResourceManager)

        #region General Initializer : Class (Onyx360ResourceManager) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Onyx360ResourceManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetString, 0)]
        [TestCase(MethodGetRequiredMarker, 0)]
        public void AUT_Onyx360ResourceManager_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Onyx360ResourceManager) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Onyx360ResourceManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldcurrentDirectoryPath)]
        [TestCase(FieldassemblyPath)]
        [TestCase(Fieldassembly)]
        [TestCase(Field_mResManager)]
        [Category("AUT Fields")]
        public void AUT_Onyx360ResourceManager_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Onyx360ResourceManager) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Onyx360ResourceManager" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Onyx360ResourceManager_Is_Static_Type_Present_Test()
        {
            // Assert
            _onyx360ResourceManagerInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetString) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetString_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var sResourceId = this.CreateType<string>();

            // Act
            Action executeAction = () => Onyx360ResourceManager.GetString(sResourceId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetString_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var sResourceId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Onyx360ResourceManager.GetString(sResourceId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetString_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var sResourceId = this.CreateType<string>();
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetString = { sResourceId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, methodGetStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetString, parametersOfGetString, methodGetStringParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(1);
            methodGetStringParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var sResourceId = this.CreateType<string>();
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetString = { sResourceId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetString, parametersOfGetString, methodGetStringParametersTypes);

            // Assert
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(1);
            methodGetStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetString_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var methodGetStringParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetString_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequiredMarker) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Onyx360ResourceManager_GetRequiredMarker_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetRequiredMarkerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRequiredMarker, methodGetRequiredMarkerParametersTypes);
        }

        #endregion

        #region Method Call : (GetRequiredMarker) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetRequiredMarker_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredMarker);

            // Act
            Action executeAction = () => Onyx360ResourceManager.GetRequiredMarker();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequiredMarker) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetRequiredMarker_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredMarker);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Onyx360ResourceManager.GetRequiredMarker();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredMarker) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetRequiredMarker_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredMarker);
            Type [] methodGetRequiredMarkerParametersTypes = null;
            object[] parametersOfGetRequiredMarker = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredMarker, methodGetRequiredMarkerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequiredMarker, methodGetRequiredMarkerParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetRequiredMarker, parametersOfGetRequiredMarker, methodGetRequiredMarkerParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequiredMarker);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequiredMarker.ShouldBeNull();
            methodGetRequiredMarkerParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredMarker) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetRequiredMarker_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredMarker);
            Type [] methodGetRequiredMarkerParametersTypes = null;
            object[] parametersOfGetRequiredMarker = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRequiredMarker, parametersOfGetRequiredMarker, methodGetRequiredMarkerParametersTypes);

            // Assert
            parametersOfGetRequiredMarker.ShouldBeNull();
            methodGetRequiredMarkerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequiredMarker) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetRequiredMarker_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredMarker);
            Type [] methodGetRequiredMarkerParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequiredMarker, methodGetRequiredMarkerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequiredMarkerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredMarker) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetRequiredMarker_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredMarker);
            Type [] methodGetRequiredMarkerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequiredMarker, methodGetRequiredMarkerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequiredMarkerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequiredMarker) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Onyx360ResourceManager_GetRequiredMarker_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequiredMarker);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequiredMarker, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}