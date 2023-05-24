using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using KBengine;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.KBengine
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.modLog" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ModLogTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="modLog" />)
        /// </summary>
        public ModLogTest() : base(typeof(modLog))
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

        #region General Initializer : Class (modLog) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _modLogInstanceType;
        private modLog _modLogInstance;
        private modLog _modLogInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="modLog" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _modLogInstanceType = typeof(modLog);
            _modLogInstanceFixture = this.Create<modLog>(false);
            _modLogInstance = _modLogInstanceFixture ?? this.Create<modLog>(true);
            CurrentInstance = _modLogInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (modLog) Initializer

        #region Properties

        private const string PropertyGBDontLog = "GBDontLog";

        #endregion

        #region Methods

        private const string MethodDebugLog = "DebugLog";
        private const string MethodInitializeLog = "InitializeLog";
        private const string Methodsetup = "setup";

        #endregion

        #region Fields

        private const string Fieldlog = "log";
        private const string FieldgbDontLog = "gbDontLog";

        #endregion

        #endregion

        #region General Initializer : Class (modLog) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="modLog" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModLog_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (modLog) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="modLog" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModLog_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (modLog) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="modLog" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModLog_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (modLog)

        #region General Initializer : Class (modLog) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="modLog" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodDebugLog, 0)]
        [TestCase(MethodInitializeLog, 0)]
        [TestCase(Methodsetup, 0)]
        public void AUT_ModLog_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (modLog) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="modLog" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyGBDontLog)]
        [Category("AUT Property")]
        public void AUT_ModLog_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (modLog) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="modLog" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldlog)]
        [TestCase(FieldgbDontLog)]
        [Category("AUT Fields")]
        public void AUT_ModLog_All_Fields_Explore_Verify_By_Name_Test(string name)
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
        
        #region General Instance : Class (modLog) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="modLog" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ModLog_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _modLogInstance.ShouldBeAssignableTo<modLog>();
            _modLogInstanceFixture.ShouldBeAssignableTo<modLog>();
            CurrentInstance.ShouldBeAssignableTo<modLog>();
        }

        #endregion

        #endregion
        
        #region Category : GetterSetter

        #region General Getters/Setters : Class (modLog) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyGBDontLog)]
        public void AUT_ModLog_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (modLog) => Property (GBDontLog) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ModLog_Public_Class_GBDontLog_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGBDontLog);
            var propertyInfo = this.GetPropertyInfo(PropertyGBDontLog);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (DebugLog) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_DebugLog_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebugLog);
            var iMode = this.CreateType<modLog.MessageTypeEnum>();
            var sMessage = this.CreateType<string>();
            var methodDebugLogParametersTypes = new Type[] { typeof(modLog.MessageTypeEnum), typeof(string) };
            object[] parametersOfDebugLog = { iMode, sMessage };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDebugLog, parametersOfDebugLog, methodDebugLogParametersTypes);

            // Assert
            parametersOfDebugLog.ShouldNotBeNull();
            parametersOfDebugLog.Length.ShouldBe(2);
            methodDebugLogParametersTypes.Length.ShouldBe(2);
            methodDebugLogParametersTypes.Length.ShouldBe(parametersOfDebugLog.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DebugLog) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_DebugLog_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebugLog);
            var currentMethodInfo = this.GetMethodInfo(MethodDebugLog, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DebugLog) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_DebugLog_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebugLog);
            var methodDebugLogParametersTypes = new Type[] { typeof(modLog.MessageTypeEnum), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDebugLog, methodDebugLogParametersTypes);

            // Assert
            methodDebugLogParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DebugLog) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_DebugLog_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebugLog);
            var currentMethodInfo = this.GetMethodInfo(MethodDebugLog, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeLog) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModLog_InitializeLog_Method_Call_Internally(Type[] types)
        {
            var methodInitializeLogParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitializeLog, methodInitializeLogParametersTypes);
        }

        #endregion
        
        #region Method Call : (InitializeLog) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_InitializeLog_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeLog);
            var slogFile = this.CreateType<string>();
            var methodInitializeLogParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfInitializeLog = { slogFile };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeLog, parametersOfInitializeLog, methodInitializeLogParametersTypes);

            // Assert
            parametersOfInitializeLog.ShouldNotBeNull();
            parametersOfInitializeLog.Length.ShouldBe(1);
            methodInitializeLogParametersTypes.Length.ShouldBe(1);
            methodInitializeLogParametersTypes.Length.ShouldBe(parametersOfInitializeLog.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeLog) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_InitializeLog_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeLog);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeLog, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InitializeLog) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_InitializeLog_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeLog);
            var methodInitializeLogParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeLog, methodInitializeLogParametersTypes);

            // Assert
            methodInitializeLogParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeLog) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_InitializeLog_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeLog);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeLog, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (setup) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModLog_setup_Static_Method_Call_Internally(Type[] types)
        {
            var methodsetupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(Methodsetup, methodsetupParametersTypes);
        }

        #endregion
        
        #region Method Call : (setup) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_setup_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsetup);
            var slogFile = this.CreateType<string>();
            var methodsetupParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfsetup = { slogFile };

            // Act
            Action currentAction = () => this.InvokeWithTypes(Methodsetup, parametersOfsetup, methodsetupParametersTypes);

            // Assert
            parametersOfsetup.ShouldNotBeNull();
            parametersOfsetup.Length.ShouldBe(1);
            methodsetupParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (setup) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_setup_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsetup);
            var currentMethodInfo = this.GetMethodInfo(Methodsetup, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (setup) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_setup_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsetup);
            var methodsetupParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(Methodsetup, methodsetupParametersTypes);

            // Assert
            methodsetupParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (setup) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModLog_setup_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Methodsetup);
            var currentMethodInfo = this.GetMethodInfo(Methodsetup, 0);

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