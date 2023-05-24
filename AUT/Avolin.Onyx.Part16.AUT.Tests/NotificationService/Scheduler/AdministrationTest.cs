using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Scheduler;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Scheduler
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Scheduler.Administration" />)
    ///     and namespace <see cref="NotificationService.Scheduler"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AdministrationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Administration" />)
        /// </summary>
        public AdministrationTest() : base(typeof(global::NotificationService.Scheduler.Administration))
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

        #region General Initializer : Class (Administration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _administrationInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Administration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _administrationInstanceType = typeof(global::NotificationService.Scheduler.Administration);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Administration) Initializer

        #region Methods

        private const string MethodInitilize = "Initilize";
        private const string MethodInvokeUpdateXml = "InvokeUpdateXml";
        private const string MethodClean = "Clean";

        #endregion

        #region Fields

        private const string Fieldscheduler = "scheduler";
        
        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (Administration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Administration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Administration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Administration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Administration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Administration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Administration)

        #region General Initializer : Class (Administration) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Administration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitilize, 0)]
        public void AUT_Administration_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Administration) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Administration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldscheduler)]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_Administration_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Administration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Administration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Administration_Is_Static_Type_Present_Test()
        {
            // Assert
            _administrationInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Initilize) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Administration_Initilize_Static_Method_Call_Internally(Type[] types)
        {
            var methodInitilizeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitilize, methodInitilizeParametersTypes);
        }

        #endregion

        #region Method Call : (Initilize) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Administration_Initilize_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitilize);

            // Act
            Action executeAction = () => global::NotificationService.Scheduler.Administration.Initilize();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Initilize) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Administration_Initilize_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitilize);
            Type [] methodInitilizeParametersTypes = null;
            object[] parametersOfInitilize = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitilize, methodInitilizeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfInitilize);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitilize.ShouldBeNull();
            methodInitilizeParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Initilize) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Administration_Initilize_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitilize);
            Type [] methodInitilizeParametersTypes = null;
            object[] parametersOfInitilize = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitilize, parametersOfInitilize, methodInitilizeParametersTypes);

            // Assert
            parametersOfInitilize.ShouldBeNull();
            methodInitilizeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Initilize) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Administration_Initilize_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitilize);
            Type [] methodInitilizeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitilize, methodInitilizeParametersTypes);

            // Assert
            methodInitilizeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Initilize) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Administration_Initilize_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitilize);
            var currentMethodInfo = this.GetMethodInfo(MethodInitilize, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InvokeUpdateXml) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Administration_InvokeUpdateXml_Static_Method_Call_Internally(Type[] types)
        {
            var methodInvokeUpdateXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInvokeUpdateXml, methodInvokeUpdateXmlParametersTypes);
        }

        #endregion

        #region Method Call : (Clean) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Administration_Clean_Static_Method_Call_Internally(Type[] types)
        {
            var methodCleanParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClean, methodCleanParametersTypes);
        }

        #endregion
        
        #endregion

        #endregion
    }
}