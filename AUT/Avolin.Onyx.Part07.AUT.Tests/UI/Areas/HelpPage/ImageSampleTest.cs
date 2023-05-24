using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ImageSample" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ImageSampleTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ImageSample" />)
        /// </summary>
        public ImageSampleTest() : base(typeof(ImageSample))
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

        #region General Initializer : Class (ImageSample) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _imageSampleInstanceType;
        private ImageSample _imageSampleInstance;
        private ImageSample _imageSampleInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ImageSample" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _imageSampleInstanceType = typeof(ImageSample);
            _imageSampleInstanceFixture = this.Create<ImageSample>(false);
            _imageSampleInstance = _imageSampleInstanceFixture ?? this.Create<ImageSample>(true);
            CurrentInstance = _imageSampleInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ImageSample) Initializer

        #region Properties

        private const string PropertySrc = "Src";

        #endregion

        #region Methods

        private const string MethodEquals = "Equals";
        private const string MethodGetHashCode = "GetHashCode";
        private const string MethodToString = "ToString";

        #endregion

        #endregion

        #region General Initializer : Class (ImageSample) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ImageSample" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ImageSample_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ImageSample) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ImageSample" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ImageSample_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ImageSample) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ImageSample" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ImageSample_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ImageSample)

        #region General Initializer : Class (ImageSample) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ImageSample" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEquals, 0)]
        [TestCase(MethodGetHashCode, 0)]
        [TestCase(MethodToString, 0)]
        public void AUT_ImageSample_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ImageSample) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ImageSample" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySrc)]
        [Category("AUT Property")]
        public void AUT_ImageSample_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ImageSample) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ImageSample" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ImageSample_Is_Instance_Present_Test()
        {
            // Assert
            _imageSampleInstanceType.ShouldNotBeNull();
            _imageSampleInstance.ShouldNotBeNull();
            _imageSampleInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ImageSample) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ImageSample" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ImageSample_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _imageSampleInstance.ShouldBeAssignableTo<ImageSample>();
            _imageSampleInstanceFixture.ShouldBeAssignableTo<ImageSample>();
            CurrentInstance.ShouldBeAssignableTo<ImageSample>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ImageSample) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ImageSample_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var src = this.CreateType<string>();
            ImageSample instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ImageSample(src);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _imageSampleInstance.ShouldNotBeNull();
            _imageSampleInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ImageSample>();
        }

        #endregion

        #region General Constructor : Class (ImageSample) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ImageSample_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var src = this.CreateType<string>();
            ImageSample instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ImageSample(src);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _imageSampleInstance.ShouldNotBeNull();
            _imageSampleInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ImageSample) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySrc)]
        public void AUT_ImageSample_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ImageSample) => Property (Src) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ImageSample_Public_Class_Src_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySrc);
            var propertyInfo = this.GetPropertyInfo(PropertySrc);

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

        #region Method Call : (Equals) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_Equals_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();

            // Act
            Action executeAction = () => _imageSampleInstance.Equals(obj);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_Equals_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_imageSampleInstanceFixture, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_Equals_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_imageSampleInstanceFixture, out exception1, parametersOfEquals);
            var result2 = this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_Equals_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_imageSampleInstanceFixture, parametersOfEquals);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_Equals_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEquals, parametersOfEquals, methodEqualsParametersTypes);

            // Assert
            parametersOfEquals.ShouldNotBeNull();
            parametersOfEquals.Length.ShouldBe(1);
            methodEqualsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_Equals_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_Equals_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEquals, methodEqualsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEqualsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_Equals_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

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
        public void AUT_ImageSample_Equals_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_ImageSample_Equals_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ImageSample_GetHashCode_Method_Call_Internally(Type[] types)
        {
            var methodGetHashCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_GetHashCode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);

            // Act
            Action executeAction = () => _imageSampleInstance.GetHashCode();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_GetHashCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_imageSampleInstanceFixture, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_GetHashCode_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_imageSampleInstanceFixture, out exception1, parametersOfGetHashCode);
            var result2 = this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_GetHashCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetHashCode, parametersOfGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            parametersOfGetHashCode.ShouldBeNull();
            methodGetHashCodeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_GetHashCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHashCodeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_GetHashCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ImageSample_ToString_Method_Call_Internally(Type[] types)
        {
            var methodToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_ToString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);

            // Act
            Action executeAction = () => _imageSampleInstance.ToString();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_ToString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _imageSampleInstance.ToString();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_ToString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_imageSampleInstanceFixture, parametersOfToString);
            var result2 = this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_ToString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_imageSampleInstanceFixture, parametersOfToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_ToString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_ToString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_ToString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ImageSample_ToString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var currentMethodInfo = this.GetMethodInfo(MethodToString, 0);

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