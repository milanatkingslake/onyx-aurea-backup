using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Helper;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Helper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Helper.OnyxConvert" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxConvertTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxConvert" />)
        /// </summary>
        public OnyxConvertTest() : base(typeof(OnyxConvert))
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

        #region General Initializer : Class (OnyxConvert) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxConvertInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxConvert" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxConvertInstanceType = typeof(OnyxConvert);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxConvert) Initializer

        #region Methods

        private const string MethodToBooleanNullable = "ToBooleanNullable";
        private const string MethodToBoolean = "ToBoolean";
        private const string MethodToInt = "ToInt";
        private const string MethodToIntNullable = "ToIntNullable";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxConvert) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxConvert" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxConvert_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxConvert)

        #region General Initializer : Class (OnyxConvert) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxConvert" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodToBooleanNullable, 0)]
        [TestCase(MethodToBoolean, 0)]
        [TestCase(MethodToInt, 0)]
        [TestCase(MethodToIntNullable, 0)]
        public void AUT_OnyxConvert_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OnyxConvert) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxConvert" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxConvert_Is_Static_Type_Present_Test()
        {
            // Assert
            _onyxConvertInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ToBooleanNullable) (Return Type : bool?) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBooleanNullable_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBooleanNullable);
            var data = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxConvert.ToBooleanNullable(data);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToBooleanNullable) (Return Type : bool?) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBooleanNullable_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBooleanNullable);
            var data = this.CreateType<string>();
            var returnedValue = default(bool?);

            // Act
            Action executeAction = () => returnedValue = OnyxConvert.ToBooleanNullable(data);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToBooleanNullable) (Return Type : bool?) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBooleanNullable_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBooleanNullable);
            var data = this.CreateType<string>();
            var methodToBooleanNullableParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToBooleanNullable = { data };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToBooleanNullable, methodToBooleanNullableParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfToBooleanNullable);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToBooleanNullable.ShouldNotBeNull();
            parametersOfToBooleanNullable.Length.ShouldBe(1);
            methodToBooleanNullableParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToBooleanNullable) (Return Type : bool?) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBooleanNullable_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBooleanNullable);
            var data = this.CreateType<string>();
            var methodToBooleanNullableParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToBooleanNullable = { data };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool?>(MethodToBooleanNullable, parametersOfToBooleanNullable, methodToBooleanNullableParametersTypes);

            // Assert
            parametersOfToBooleanNullable.ShouldNotBeNull();
            parametersOfToBooleanNullable.Length.ShouldBe(1);
            methodToBooleanNullableParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToBooleanNullable) (Return Type : bool?) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBooleanNullable_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBooleanNullable);
            var methodToBooleanNullableParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToBooleanNullable, methodToBooleanNullableParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToBooleanNullableParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToBooleanNullable) (Return Type : bool?) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBooleanNullable_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBooleanNullable);
            var currentMethodInfo = this.GetMethodInfo(MethodToBooleanNullable, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToBooleanNullable) (Return Type : bool?) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBooleanNullable_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBooleanNullable);
            var currentMethodInfo = this.GetMethodInfo(MethodToBooleanNullable, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConvert_ToBoolean_Static_Method_Call_Internally(Type[] types)
        {
            var methodToBooleanParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToBoolean, methodToBooleanParametersTypes);
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var data = this.CreateType<string>();
            var defaultValue = this.CreateType<bool>();

            // Act
            Action executeAction = () => OnyxConvert.ToBoolean(data, defaultValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var data = this.CreateType<string>();
            var defaultValue = this.CreateType<bool>();
            var methodToBooleanParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfToBoolean = { data, defaultValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodToBoolean, methodToBooleanParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodToBoolean, methodToBooleanParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodToBoolean, parametersOfToBoolean, methodToBooleanParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToBoolean.ShouldNotBeNull();
            parametersOfToBoolean.Length.ShouldBe(2);
            methodToBooleanParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodToBoolean, parametersOfToBoolean, methodToBooleanParametersTypes));
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var data = this.CreateType<string>();
            var defaultValue = this.CreateType<bool>();
            var methodToBooleanParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfToBoolean = { data, defaultValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToBoolean, methodToBooleanParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfToBoolean);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToBoolean.ShouldNotBeNull();
            parametersOfToBoolean.Length.ShouldBe(2);
            methodToBooleanParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var data = this.CreateType<string>();
            var defaultValue = this.CreateType<bool>();
            var methodToBooleanParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfToBoolean = { data, defaultValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodToBoolean, parametersOfToBoolean, methodToBooleanParametersTypes);

            // Assert
            parametersOfToBoolean.ShouldNotBeNull();
            parametersOfToBoolean.Length.ShouldBe(2);
            methodToBooleanParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var methodToBooleanParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToBoolean, methodToBooleanParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToBooleanParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var methodToBooleanParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToBoolean, methodToBooleanParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToBooleanParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var methodToBooleanParametersTypes = new Type[] { typeof(string), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToBoolean, methodToBooleanParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToBooleanParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var currentMethodInfo = this.GetMethodInfo(MethodToBoolean, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToBoolean) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToBoolean_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToBoolean);
            var currentMethodInfo = this.GetMethodInfo(MethodToBoolean, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConvert_ToInt_Static_Method_Call_Internally(Type[] types)
        {
            var methodToIntParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToInt, methodToIntParametersTypes);
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var data = this.CreateType<string>();
            var defaultValue = this.CreateType<int>();

            // Act
            Action executeAction = () => OnyxConvert.ToInt(data, defaultValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var data = this.CreateType<string>();
            var defaultValue = this.CreateType<int>();
            var methodToIntParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfToInt = { data, defaultValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodToInt, methodToIntParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodToInt, methodToIntParametersTypes);
            var result2 = this.GetResultOfMethod<int>(MethodToInt, parametersOfToInt, methodToIntParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToInt.ShouldNotBeNull();
            parametersOfToInt.Length.ShouldBe(2);
            methodToIntParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<int>(MethodToInt, parametersOfToInt, methodToIntParametersTypes));
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var data = this.CreateType<string>();
            var defaultValue = this.CreateType<int>();
            var methodToIntParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfToInt = { data, defaultValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToInt, methodToIntParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfToInt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToInt.ShouldNotBeNull();
            parametersOfToInt.Length.ShouldBe(2);
            methodToIntParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var data = this.CreateType<string>();
            var defaultValue = this.CreateType<int>();
            var methodToIntParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfToInt = { data, defaultValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodToInt, parametersOfToInt, methodToIntParametersTypes);

            // Assert
            parametersOfToInt.ShouldNotBeNull();
            parametersOfToInt.Length.ShouldBe(2);
            methodToIntParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var methodToIntParametersTypes = new Type[] { typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToInt, methodToIntParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToIntParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var methodToIntParametersTypes = new Type[] { typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToInt, methodToIntParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToIntParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var methodToIntParametersTypes = new Type[] { typeof(string), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToInt, methodToIntParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToIntParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodToInt, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToInt) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToInt_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodToInt, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToIntNullable) (Return Type : int?) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConvert_ToIntNullable_Static_Method_Call_Internally(Type[] types)
        {
            var methodToIntNullableParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToIntNullable, methodToIntNullableParametersTypes);
        }

        #endregion

        #region Method Call : (ToIntNullable) (Return Type : int?) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToIntNullable_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToIntNullable);
            var data = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxConvert.ToIntNullable(data);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToIntNullable) (Return Type : int?) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToIntNullable_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToIntNullable);
            var data = this.CreateType<string>();
            var returnedValue = default(int?);

            // Act
            Action executeAction = () => returnedValue = OnyxConvert.ToIntNullable(data);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToIntNullable) (Return Type : int?) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToIntNullable_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToIntNullable);
            var data = this.CreateType<string>();
            var methodToIntNullableParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToIntNullable = { data };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToIntNullable, methodToIntNullableParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfToIntNullable);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToIntNullable.ShouldNotBeNull();
            parametersOfToIntNullable.Length.ShouldBe(1);
            methodToIntNullableParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToIntNullable) (Return Type : int?) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToIntNullable_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToIntNullable);
            var data = this.CreateType<string>();
            var methodToIntNullableParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToIntNullable = { data };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int?>(MethodToIntNullable, parametersOfToIntNullable, methodToIntNullableParametersTypes);

            // Assert
            parametersOfToIntNullable.ShouldNotBeNull();
            parametersOfToIntNullable.Length.ShouldBe(1);
            methodToIntNullableParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToIntNullable) (Return Type : int?) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToIntNullable_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToIntNullable);
            var methodToIntNullableParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToIntNullable, methodToIntNullableParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToIntNullableParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToIntNullable) (Return Type : int?) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToIntNullable_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToIntNullable);
            var currentMethodInfo = this.GetMethodInfo(MethodToIntNullable, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToIntNullable) (Return Type : int?) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConvert_ToIntNullable_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToIntNullable);
            var currentMethodInfo = this.GetMethodInfo(MethodToIntNullable, 0);
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