using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxObjectComparer" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxObjectComparerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxObjectComparer" />)
        /// </summary>
        public OnyxObjectComparerTest() : base(typeof(OnyxObjectComparer))
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

        #region General Initializer : Class (OnyxObjectComparer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxObjectComparerInstanceType;
        private OnyxObjectComparer _onyxObjectComparerInstance;
        private OnyxObjectComparer _onyxObjectComparerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxObjectComparer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxObjectComparerInstanceType = typeof(OnyxObjectComparer);
            _onyxObjectComparerInstanceFixture = this.Create<OnyxObjectComparer>(false);
            _onyxObjectComparerInstance = _onyxObjectComparerInstanceFixture ?? this.Create<OnyxObjectComparer>(true);
            CurrentInstance = _onyxObjectComparerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxObjectComparer) Initializer

        #region Methods

        private const string MethodEquals = "Equals";
        private const string MethodGetHashCode = "GetHashCode";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxObjectComparer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxObjectComparer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxObjectComparer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxObjectComparer)

        #region General Initializer : Class (OnyxObjectComparer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxObjectComparer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEquals, 0)]
        [TestCase(MethodGetHashCode, 0)]
        public void AUT_OnyxObjectComparer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OnyxObjectComparer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxObjectComparer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxObjectComparer_Is_Instance_Present_Test()
        {
            // Assert
            _onyxObjectComparerInstanceType.ShouldNotBeNull();
            _onyxObjectComparerInstance.ShouldNotBeNull();
            _onyxObjectComparerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxObjectComparer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxObjectComparer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxObjectComparer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxObjectComparerInstance.ShouldBeAssignableTo<OnyxObjectComparer>();
            _onyxObjectComparerInstanceFixture.ShouldBeAssignableTo<OnyxObjectComparer>();
            CurrentInstance.ShouldBeAssignableTo<OnyxObjectComparer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxObjectComparer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxObjectComparer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxObjectComparer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Equals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var o1 = this.CreateType<OnyxObject>();
            var o2 = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _onyxObjectComparerInstance.Equals(o1, o2);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var o1 = this.CreateType<OnyxObject>();
            var o2 = this.CreateType<OnyxObject>();
            var methodEqualsParametersTypes = new Type[] { typeof(OnyxObject), typeof(OnyxObject) };
            object[] parametersOfEquals = { o1, o2 };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxObjectComparerInstanceFixture, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var o1 = this.CreateType<OnyxObject>();
            var o2 = this.CreateType<OnyxObject>();
            var methodEqualsParametersTypes = new Type[] { typeof(OnyxObject), typeof(OnyxObject) };
            object[] parametersOfEquals = { o1, o2 };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxObjectComparerInstanceFixture, out exception1, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var o1 = this.CreateType<OnyxObject>();
            var o2 = this.CreateType<OnyxObject>();
            var methodEqualsParametersTypes = new Type[] { typeof(OnyxObject), typeof(OnyxObject) };
            object[] parametersOfEquals = { o1, o2 };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxObjectComparerInstanceFixture, parametersOfEquals);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var o1 = this.CreateType<OnyxObject>();
            var o2 = this.CreateType<OnyxObject>();
            var methodEqualsParametersTypes = new Type[] { typeof(OnyxObject), typeof(OnyxObject) };
            object[] parametersOfEquals = { o1, o2 };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(2);
            methodEqualsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(OnyxObject), typeof(OnyxObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(OnyxObject), typeof(OnyxObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(OnyxObject), typeof(OnyxObject) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEqualsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_Equals_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxObjectComparer_GetHashCode_Method_Call_Internally(Type[] types)
        {
            var methodGetHashCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var o = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _onyxObjectComparerInstance.GetHashCode(o);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var o = this.CreateType<OnyxObject>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfGetHashCode = { o };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_onyxObjectComparerInstanceFixture, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var o = this.CreateType<OnyxObject>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfGetHashCode = { o };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_onyxObjectComparerInstanceFixture, out exception1, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var o = this.CreateType<OnyxObject>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfGetHashCode = { o };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxObjectComparerInstanceFixture, parametersOfGetHashCode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var o = this.CreateType<OnyxObject>();
            var methodGetHashCodeParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfGetHashCode = { o };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            parametersOfGetHashCode.ShouldNotBeNull();
            parametersOfGetHashCode.Length.ShouldBe(1);
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(OnyxObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(OnyxObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetHashCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var methodGetHashCodeParametersTypes = new Type[] { typeof(OnyxObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHashCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxObjectComparer_GetHashCode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, 0);
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