using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.HelpPageSampleKey" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelpPageSampleKeyTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HelpPageSampleKey" />)
        /// </summary>
        public HelpPageSampleKeyTest() : base(typeof(HelpPageSampleKey))
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

        #region General Initializer : Class (HelpPageSampleKey) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helpPageSampleKeyInstanceType;
        private HelpPageSampleKey _helpPageSampleKeyInstance;
        private HelpPageSampleKey _helpPageSampleKeyInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HelpPageSampleKey" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helpPageSampleKeyInstanceType = typeof(HelpPageSampleKey);
            _helpPageSampleKeyInstanceFixture = this.Create<HelpPageSampleKey>(false);
            _helpPageSampleKeyInstance = _helpPageSampleKeyInstanceFixture ?? this.Create<HelpPageSampleKey>(true);
            CurrentInstance = _helpPageSampleKeyInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HelpPageSampleKey) Initializer

        #region Properties

        private const string PropertyControllerName = "ControllerName";
        private const string PropertyActionName = "ActionName";
        private const string PropertyMediaType = "MediaType";
        private const string PropertyParameterNames = "ParameterNames";
        private const string PropertyParameterType = "ParameterType";
        private const string PropertySampleDirection = "SampleDirection";

        #endregion

        #region Methods

        private const string MethodEquals = "Equals";
        private const string MethodGetHashCode = "GetHashCode";

        #endregion

        #endregion

        #region General Initializer : Class (HelpPageSampleKey) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_HelpPageSampleKey_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpPageSampleKey) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_HelpPageSampleKey_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpPageSampleKey) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_HelpPageSampleKey_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HelpPageSampleKey)

        #region General Initializer : Class (HelpPageSampleKey) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodEquals, 0)]
        [TestCase(MethodGetHashCode, 0)]
        public void AUT_HelpPageSampleKey_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HelpPageSampleKey) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyControllerName)]
        [TestCase(PropertyActionName)]
        [TestCase(PropertyMediaType)]
        [TestCase(PropertyParameterNames)]
        [TestCase(PropertyParameterType)]
        [TestCase(PropertySampleDirection)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_HelpPageSampleKey_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HelpPageSampleKey) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_HelpPageSampleKey_Is_Instance_Present_Test()
        {
            // Assert
            _helpPageSampleKeyInstanceType.ShouldNotBeNull();
            _helpPageSampleKeyInstance.ShouldNotBeNull();
            _helpPageSampleKeyInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HelpPageSampleKey) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_HelpPageSampleKey_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _helpPageSampleKeyInstance.ShouldBeAssignableTo<HelpPageSampleKey>();
            _helpPageSampleKeyInstanceFixture.ShouldBeAssignableTo<HelpPageSampleKey>();
            CurrentInstance.ShouldBeAssignableTo<HelpPageSampleKey>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HelpPageSampleKey) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleKey_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            HelpPageSampleKey instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new HelpPageSampleKey(mediaType);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _helpPageSampleKeyInstance.ShouldNotBeNull();
            _helpPageSampleKeyInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<HelpPageSampleKey>();
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleKey) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleKey_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var mediaType = this.CreateType<MediaTypeHeaderValue>();
            HelpPageSampleKey instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new HelpPageSampleKey(mediaType);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _helpPageSampleKeyInstance.ShouldNotBeNull();
            _helpPageSampleKeyInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleKey) instance created

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleKey_Is_Created_Test()
        {
            // Assert
            _helpPageSampleKeyInstance.ShouldNotBeNull();
            _helpPageSampleKeyInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleKey) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="HelpPageSampleKey" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_HelpPageSampleKey_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleKey) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="HelpPageSampleKey" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleKey_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleKey) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="HelpPageSampleKey" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleKey_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodHelpPageSampleKeyParametersTypes = new Type[] { typeof(MediaTypeHeaderValue) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodHelpPageSampleKeyParametersTypes);
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleKey) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="HelpPageSampleKey" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleKey_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodHelpPageSampleKeyParametersTypes = new Type[] { typeof(MediaTypeHeaderValue), typeof(Type) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodHelpPageSampleKeyParametersTypes);
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleKey) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="HelpPageSampleKey" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleKey_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodHelpPageSampleKeyParametersTypes = new Type[] { typeof(SampleDirection), typeof(string), typeof(string), typeof(IEnumerable<string>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodHelpPageSampleKeyParametersTypes);
        }

        #endregion

        #region General Constructor : Class (HelpPageSampleKey) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="HelpPageSampleKey" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_HelpPageSampleKey_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodHelpPageSampleKeyParametersTypes = new Type[] { typeof(MediaTypeHeaderValue), typeof(SampleDirection), typeof(string), typeof(string), typeof(IEnumerable<string>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodHelpPageSampleKeyParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HelpPageSampleKey) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyControllerName)]
        [TestCase(PropertyActionName)]
        [TestCase(PropertyMediaType)]
        [TestCase(PropertyParameterNames)]
        [TestCase(PropertyParameterType)]
        [TestCase(PropertySampleDirection)]
        public void AUT_HelpPageSampleKey_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (ActionName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_Public_Class_ActionName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionName);
            var propertyInfo = this.GetPropertyInfo(PropertyActionName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (ControllerName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_Public_Class_ControllerName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyControllerName);
            var propertyInfo = this.GetPropertyInfo(PropertyControllerName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (MediaType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_MediaType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMediaType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMediaType);
            Action currentAction = () => propertyInfo.SetValue(_helpPageSampleKeyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (MediaType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_Public_Class_MediaType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMediaType);
            var propertyInfo = this.GetPropertyInfo(PropertyMediaType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (ParameterNames) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_Public_Class_ParameterNames_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterNames);
            var propertyInfo = this.GetPropertyInfo(PropertyParameterNames);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (ParameterType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_ParameterType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyParameterType);
            Action currentAction = () => propertyInfo.SetValue(_helpPageSampleKeyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (ParameterType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_Public_Class_ParameterType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterType);
            var propertyInfo = this.GetPropertyInfo(PropertyParameterType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (SampleDirection) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_SampleDirection_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySampleDirection);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySampleDirection);
            Action currentAction = () => propertyInfo.SetValue(_helpPageSampleKeyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (HelpPageSampleKey) => Property (SampleDirection) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_HelpPageSampleKey_Public_Class_SampleDirection_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySampleDirection);
            var propertyInfo = this.GetPropertyInfo(PropertySampleDirection);

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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();

            // Act
            Action executeAction = () => _helpPageSampleKeyInstance.Equals(obj);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Equals) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_helpPageSampleKeyInstanceFixture, parametersOfEquals);
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_helpPageSampleKeyInstanceFixture, out exception1, parametersOfEquals);
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEquals);
            var obj = this.CreateType<object>();
            var methodEqualsParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfEquals = { obj };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEquals, methodEqualsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_helpPageSampleKeyInstanceFixture, parametersOfEquals);

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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_Equals_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_HelpPageSampleKey_GetHashCode_Method_Call_Internally(Type[] types)
        {
            var methodGetHashCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_GetHashCode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);

            // Act
            Action executeAction = () => _helpPageSampleKeyInstance.GetHashCode();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHashCode) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_GetHashCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_helpPageSampleKeyInstanceFixture, parametersOfGetHashCode);
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_GetHashCode_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHashCode);
            Type [] methodGetHashCodeParametersTypes = null;
            object[] parametersOfGetHashCode = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHashCode, methodGetHashCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_helpPageSampleKeyInstanceFixture, out exception1, parametersOfGetHashCode);
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_GetHashCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_GetHashCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_HelpPageSampleKey_GetHashCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #endregion

        #endregion
    }
}