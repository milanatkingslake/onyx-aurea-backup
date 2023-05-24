using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.ServiceLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.AssemblyLoader" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AssemblyLoaderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AssemblyLoader" />)
        /// </summary>
        public AssemblyLoaderTest() : base(typeof(AssemblyLoader))
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

        #region General Initializer : Class (AssemblyLoader) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _assemblyLoaderInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="AssemblyLoader" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _assemblyLoaderInstanceType = typeof(AssemblyLoader);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AssemblyLoader) Initializer

        #region Methods

        private const string MethodLoadAssemblyFromSettingsAndGetType = "LoadAssemblyFromSettingsAndGetType";
        private const string MethodGetAssemblyIfLoaded = "GetAssemblyIfLoaded";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (AssemblyLoader) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AssemblyLoader" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AssemblyLoader_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AssemblyLoader) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AssemblyLoader" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AssemblyLoader_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AssemblyLoader)

        #region General Initializer : Class (AssemblyLoader) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AssemblyLoader" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoadAssemblyFromSettingsAndGetType, 0)]
        [TestCase(MethodGetAssemblyIfLoaded, 0)]
        public void AUT_AssemblyLoader_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (AssemblyLoader) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AssemblyLoader" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AssemblyLoader_Is_Static_Type_Present_Test()
        {
            // Assert
            _assemblyLoaderInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (LoadAssemblyFromSettingsAndGetType) (Return Type : Type) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_LoadAssemblyFromSettingsAndGetType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadAssemblyFromSettingsAndGetType);
            var loadDefault = this.CreateType<bool>();
            var methodLoadAssemblyFromSettingsAndGetTypeParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfLoadAssemblyFromSettingsAndGetType = { loadDefault };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Type>(MethodLoadAssemblyFromSettingsAndGetType, parametersOfLoadAssemblyFromSettingsAndGetType, methodLoadAssemblyFromSettingsAndGetTypeParametersTypes);

            // Assert
            parametersOfLoadAssemblyFromSettingsAndGetType.ShouldNotBeNull();
            parametersOfLoadAssemblyFromSettingsAndGetType.Length.ShouldBe(1);
            methodLoadAssemblyFromSettingsAndGetTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadAssemblyFromSettingsAndGetType) (Return Type : Type) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_LoadAssemblyFromSettingsAndGetType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadAssemblyFromSettingsAndGetType);
            var methodLoadAssemblyFromSettingsAndGetTypeParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadAssemblyFromSettingsAndGetType, methodLoadAssemblyFromSettingsAndGetTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLoadAssemblyFromSettingsAndGetTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadAssemblyFromSettingsAndGetType) (Return Type : Type) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_LoadAssemblyFromSettingsAndGetType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadAssemblyFromSettingsAndGetType);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadAssemblyFromSettingsAndGetType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetAssemblyIfLoadedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAssemblyIfLoaded, methodGetAssemblyIfLoadedParametersTypes);
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAssemblyIfLoaded);
            var assemblyFullName = this.CreateType<string>();

            // Act
            Action executeAction = () => AssemblyLoader.GetAssemblyIfLoaded(assemblyFullName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAssemblyIfLoaded);
            var assemblyFullName = this.CreateType<string>();
            var returnedValue = default(Assembly);

            // Act
            Action executeAction = () => returnedValue = AssemblyLoader.GetAssemblyIfLoaded(assemblyFullName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAssemblyIfLoaded);
            var assemblyFullName = this.CreateType<string>();
            var methodGetAssemblyIfLoadedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetAssemblyIfLoaded = { assemblyFullName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAssemblyIfLoaded, methodGetAssemblyIfLoadedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetAssemblyIfLoaded);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetAssemblyIfLoaded.ShouldNotBeNull();
            parametersOfGetAssemblyIfLoaded.Length.ShouldBe(1);
            methodGetAssemblyIfLoadedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAssemblyIfLoaded);
            var assemblyFullName = this.CreateType<string>();
            var methodGetAssemblyIfLoadedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetAssemblyIfLoaded = { assemblyFullName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Assembly>(MethodGetAssemblyIfLoaded, parametersOfGetAssemblyIfLoaded, methodGetAssemblyIfLoadedParametersTypes);

            // Assert
            parametersOfGetAssemblyIfLoaded.ShouldNotBeNull();
            parametersOfGetAssemblyIfLoaded.Length.ShouldBe(1);
            methodGetAssemblyIfLoadedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAssemblyIfLoaded);
            var methodGetAssemblyIfLoadedParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAssemblyIfLoaded, methodGetAssemblyIfLoadedParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAssemblyIfLoadedParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAssemblyIfLoaded);
            var methodGetAssemblyIfLoadedParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAssemblyIfLoaded, methodGetAssemblyIfLoadedParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAssemblyIfLoadedParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAssemblyIfLoaded);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAssemblyIfLoaded, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAssemblyIfLoaded) (Return Type : Assembly) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AssemblyLoader_GetAssemblyIfLoaded_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAssemblyIfLoaded);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAssemblyIfLoaded, 0);
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