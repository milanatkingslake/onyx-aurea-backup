using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using passencrypt;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.passencrypt
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="passencrypt.Display" />)
    ///     and namespace <see cref="passencrypt"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DisplayTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Display" />)
        /// </summary>
        public DisplayTest() : base(typeof(Display))
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

        #region General Initializer : Class (Display) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _displayInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Display" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _displayInstanceType = typeof(Display);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Display) Initializer

        #region Methods

        private const string MethodDisplayHelp = "DisplayHelp";
        private const string MethodDisplayHelpTopi = "DisplayHelpTopi";

        #endregion

        #endregion

        #region General Initializer : Class (Display) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Display" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Display_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #endregion

        #region Category : Instance

        #region General Instance : Class (Display) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Display" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Display_Is_Static_Type_Present_Test()
        {
            // Assert
            _displayInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (DisplayHelpTopi) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Display_DisplayHelpTopi_Static_Method_Call_Internally(Type[] types)
        {
            var methodDisplayHelpTopiParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDisplayHelpTopi, methodDisplayHelpTopiParametersTypes);
        }

        #endregion

        #region Method Call : (DisplayHelpTopi) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Display_DisplayHelpTopi_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisplayHelpTopi);
            var helpTopic = this.CreateType<string>();

            // Act
            Action executeAction = () => Display.DisplayHelpTopi(helpTopic);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (DisplayHelpTopi) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Display_DisplayHelpTopi_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisplayHelpTopi);
            var helpTopic = this.CreateType<string>();
            var methodDisplayHelpTopiParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDisplayHelpTopi = { helpTopic };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDisplayHelpTopi, methodDisplayHelpTopiParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfDisplayHelpTopi);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDisplayHelpTopi.ShouldNotBeNull();
            parametersOfDisplayHelpTopi.Length.ShouldBe(1);
            methodDisplayHelpTopiParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DisplayHelpTopi) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Display_DisplayHelpTopi_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisplayHelpTopi);
            var helpTopic = this.CreateType<string>();
            var methodDisplayHelpTopiParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDisplayHelpTopi = { helpTopic };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDisplayHelpTopi, parametersOfDisplayHelpTopi, methodDisplayHelpTopiParametersTypes);

            // Assert
            parametersOfDisplayHelpTopi.ShouldNotBeNull();
            parametersOfDisplayHelpTopi.Length.ShouldBe(1);
            methodDisplayHelpTopiParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DisplayHelpTopi) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Display_DisplayHelpTopi_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisplayHelpTopi);
            var currentMethodInfo = this.GetMethodInfo(MethodDisplayHelpTopi, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DisplayHelpTopi) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Display_DisplayHelpTopi_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisplayHelpTopi);
            var methodDisplayHelpTopiParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDisplayHelpTopi, methodDisplayHelpTopiParametersTypes);

            // Assert
            methodDisplayHelpTopiParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DisplayHelpTopi) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Display_DisplayHelpTopi_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisplayHelpTopi);
            var currentMethodInfo = this.GetMethodInfo(MethodDisplayHelpTopi, 0);

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