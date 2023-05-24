using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OEASConfig;
using Shouldly;

namespace Avolin.Onyx.Part17.AUT.Tests.OEASConfig
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OEASConfig.Common" />)
    ///     and namespace <see cref="OEASConfig"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Common" />)
        /// </summary>
        public CommonTest() : base(typeof(Common))
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

        #region General Initializer : Class (Common) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _commonInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Common" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonInstanceType = typeof(Common);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Common) Initializer

        #region Methods

        private const string MethodLeft = "Left";
        private const string MethodRight = "Right";
        private const string MethodMid = "Mid";
        private const string MethodInStr = "InStr";
        private const string MethodLen = "Len";

        #endregion

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Common)

        #region General Initializer : Class (Common) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLeft, 0)]
        [TestCase(MethodRight, 0)]
        [TestCase(MethodMid, 0)]
        [TestCase(MethodMid, 1)]
        [TestCase(MethodInStr, 0)]
        [TestCase(MethodLen, 0)]
        public void AUT_Common_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (Common) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Common" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Common_Is_Static_Type_Present_Test()
        {
            // Assert
            _commonInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Left) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();

            // Act
            Action executeAction = () => Common.Left(param, length);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Left) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.Left(param, length);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Left) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();
            var methodLeftParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfLeft = { param, length };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLeft, methodLeftParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodLeft, methodLeftParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodLeft, parametersOfLeft, methodLeftParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLeft.ShouldNotBeNull();
            parametersOfLeft.Length.ShouldBe(2);
            methodLeftParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodLeft, parametersOfLeft, methodLeftParametersTypes));
        }

        #endregion

        #region Method Call : (Left) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();
            var methodLeftParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfLeft = { param, length };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLeft, methodLeftParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLeft);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLeft.ShouldNotBeNull();
            parametersOfLeft.Length.ShouldBe(2);
            methodLeftParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Left) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();
            var methodLeftParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfLeft = { param, length };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodLeft, parametersOfLeft, methodLeftParametersTypes);

            // Assert
            parametersOfLeft.ShouldNotBeNull();
            parametersOfLeft.Length.ShouldBe(2);
            methodLeftParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Left) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var methodLeftParametersTypes = new Type[] { typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLeft, methodLeftParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodLeftParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Left) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var methodLeftParametersTypes = new Type[] { typeof(string), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLeft, methodLeftParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLeftParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Left) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var currentMethodInfo = this.GetMethodInfo(MethodLeft, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Left) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Left_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLeft);
            var currentMethodInfo = this.GetMethodInfo(MethodLeft, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_Right_Static_Method_Call_Internally(Type[] types)
        {
            var methodRightParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRight, methodRightParametersTypes);
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();

            // Act
            Action executeAction = () => Common.Right(param, length);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.Right(param, length);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Right) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();
            var methodRightParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfRight = { param, length };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRight, methodRightParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodRight, methodRightParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodRight, parametersOfRight, methodRightParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRight.ShouldNotBeNull();
            parametersOfRight.Length.ShouldBe(2);
            methodRightParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodRight, parametersOfRight, methodRightParametersTypes));
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();
            var methodRightParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfRight = { param, length };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRight, methodRightParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfRight);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRight.ShouldNotBeNull();
            parametersOfRight.Length.ShouldBe(2);
            methodRightParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var param = this.CreateType<string>();
            var length = this.CreateType<int>();
            var methodRightParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfRight = { param, length };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRight, parametersOfRight, methodRightParametersTypes);

            // Assert
            parametersOfRight.ShouldNotBeNull();
            parametersOfRight.Length.ShouldBe(2);
            methodRightParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var methodRightParametersTypes = new Type[] { typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRight, methodRightParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodRightParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var methodRightParametersTypes = new Type[] { typeof(string), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRight, methodRightParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRightParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var currentMethodInfo = this.GetMethodInfo(MethodRight, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Right) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Right_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRight);
            var currentMethodInfo = this.GetMethodInfo(MethodRight, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_Mid_Static_Method_Call_Internally(Type[] types)
        {
            var methodMidParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMid, methodMidParametersTypes);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var length = this.CreateType<int>();

            // Act
            Action executeAction = () => Common.Mid(param, startIndex, length);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var length = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.Mid(param, startIndex, length);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var length = this.CreateType<int>();
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfMid = { param, startIndex, length };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMid, methodMidParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMid, methodMidParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodMid, parametersOfMid, methodMidParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfMid.ShouldNotBeNull();
            parametersOfMid.Length.ShouldBe(3);
            methodMidParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodMid, parametersOfMid, methodMidParametersTypes));
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var length = this.CreateType<int>();
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfMid = { param, startIndex, length };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMid, methodMidParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfMid);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMid.ShouldNotBeNull();
            parametersOfMid.Length.ShouldBe(3);
            methodMidParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var length = this.CreateType<int>();
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfMid = { param, startIndex, length };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMid, parametersOfMid, methodMidParametersTypes);

            // Assert
            parametersOfMid.ShouldNotBeNull();
            parametersOfMid.Length.ShouldBe(3);
            methodMidParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMid, methodMidParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodMidParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMid, methodMidParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMidParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var currentMethodInfo = this.GetMethodInfo(MethodMid, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var currentMethodInfo = this.GetMethodInfo(MethodMid, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_Mid_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodMidParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMid, methodMidParametersTypes);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();

            // Act
            Action executeAction = () => Common.Mid(param, startIndex);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.Mid(param, startIndex);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfMid = { param, startIndex };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMid, methodMidParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMid, methodMidParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodMid, parametersOfMid, methodMidParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfMid.ShouldNotBeNull();
            parametersOfMid.Length.ShouldBe(2);
            methodMidParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodMid, parametersOfMid, methodMidParametersTypes));
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfMid = { param, startIndex };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMid, methodMidParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfMid);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMid.ShouldNotBeNull();
            parametersOfMid.Length.ShouldBe(2);
            methodMidParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var param = this.CreateType<string>();
            var startIndex = this.CreateType<int>();
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfMid = { param, startIndex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMid, parametersOfMid, methodMidParametersTypes);

            // Assert
            parametersOfMid.ShouldNotBeNull();
            parametersOfMid.Length.ShouldBe(2);
            methodMidParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMid, methodMidParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodMidParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var methodMidParametersTypes = new Type[] { typeof(string), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMid, methodMidParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMidParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var currentMethodInfo = this.GetMethodInfo(MethodMid, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Mid) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Mid_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMid);
            var currentMethodInfo = this.GetMethodInfo(MethodMid, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_InStr_Static_Method_Call_Internally(Type[] types)
        {
            var methodInStrParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInStr, methodInStrParametersTypes);
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var Start = this.CreateType<int>();
            var String1 = this.CreateType<string>();
            var String2 = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.InStr(Start, String1, String2);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var Start = this.CreateType<int>();
            var String1 = this.CreateType<string>();
            var String2 = this.CreateType<string>();
            var methodInStrParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };
            object[] parametersOfInStr = { Start, String1, String2 };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInStr, methodInStrParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodInStr, methodInStrParametersTypes);
            var result2 = this.GetResultOfMethod<int>(MethodInStr, parametersOfInStr, methodInStrParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfInStr.ShouldNotBeNull();
            parametersOfInStr.Length.ShouldBe(3);
            methodInStrParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<int>(MethodInStr, parametersOfInStr, methodInStrParametersTypes));
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var Start = this.CreateType<int>();
            var String1 = this.CreateType<string>();
            var String2 = this.CreateType<string>();
            var methodInStrParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };
            object[] parametersOfInStr = { Start, String1, String2 };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInStr, methodInStrParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfInStr);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInStr.ShouldNotBeNull();
            parametersOfInStr.Length.ShouldBe(3);
            methodInStrParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var Start = this.CreateType<int>();
            var String1 = this.CreateType<string>();
            var String2 = this.CreateType<string>();
            var methodInStrParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };
            object[] parametersOfInStr = { Start, String1, String2 };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodInStr, parametersOfInStr, methodInStrParametersTypes);

            // Assert
            parametersOfInStr.ShouldNotBeNull();
            parametersOfInStr.Length.ShouldBe(3);
            methodInStrParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var methodInStrParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInStr, methodInStrParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodInStrParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var methodInStrParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInStr, methodInStrParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodInStrParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var methodInStrParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInStr, methodInStrParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInStrParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var currentMethodInfo = this.GetMethodInfo(MethodInStr, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (InStr) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InStr_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInStr);
            var currentMethodInfo = this.GetMethodInfo(MethodInStr, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_Len_Static_Method_Call_Internally(Type[] types)
        {
            var methodLenParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLen, methodLenParametersTypes);
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var String1 = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.Len(String1);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Len) (Return Type : int)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var String1 = this.CreateType<string>();
            var methodLenParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLen = { String1 };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLen, methodLenParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodLen, methodLenParametersTypes);
            var result2 = this.GetResultOfMethod<int>(MethodLen, parametersOfLen, methodLenParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLen.ShouldNotBeNull();
            parametersOfLen.Length.ShouldBe(1);
            methodLenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<int>(MethodLen, parametersOfLen, methodLenParametersTypes));
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var String1 = this.CreateType<string>();
            var methodLenParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLen = { String1 };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLen, methodLenParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLen);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLen.ShouldNotBeNull();
            parametersOfLen.Length.ShouldBe(1);
            methodLenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var String1 = this.CreateType<string>();
            var methodLenParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLen = { String1 };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodLen, parametersOfLen, methodLenParametersTypes);

            // Assert
            parametersOfLen.ShouldNotBeNull();
            parametersOfLen.Length.ShouldBe(1);
            methodLenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var methodLenParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLen, methodLenParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodLenParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var methodLenParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLen, methodLenParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodLenParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var methodLenParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLen, methodLenParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLenParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var currentMethodInfo = this.GetMethodInfo(MethodLen, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Len) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Len_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLen);
            var currentMethodInfo = this.GetMethodInfo(MethodLen, 0);
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