using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.ONS.AdapterExtension.Core;
using Shouldly;

namespace Avolin.Onyx.Part09.AUT.Tests.ONS.AdapterExtension.Core
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.ONS.AdapterExtension.Core.ExtensionException" />)
    ///     and namespace <see cref="Onyx.ONS.AdapterExtension.Core"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ExtensionExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ExtensionException" />)
        /// </summary>
        public ExtensionExceptionTest() : base(typeof(ExtensionException))
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

        #region General Initializer : Class (ExtensionException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _extensionExceptionInstanceType;
        private ExtensionException _extensionExceptionInstance;
        private ExtensionException _extensionExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ExtensionException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _extensionExceptionInstanceType = typeof(ExtensionException);
            _extensionExceptionInstanceFixture = this.Create<ExtensionException>(false);
            _extensionExceptionInstance = _extensionExceptionInstanceFixture ?? this.Create<ExtensionException>(true);
            CurrentInstance = _extensionExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ExtensionException) Initializer

        #region Properties

        private const string PropertyCategory = "Category";

        #endregion

        #endregion

        #region General Initializer : Class (ExtensionException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ExtensionException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExtensionException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ExtensionException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ExtensionException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExtensionException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ExtensionException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ExtensionException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExtensionException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ExtensionException)

        #region General Initializer : Class (ExtensionException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ExtensionException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCategory)]
        [Category("AUT Property")]
        public void AUT_ExtensionException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ExtensionException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ExtensionException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ExtensionException_Is_Instance_Present_Test()
        {
            // Assert
            _extensionExceptionInstanceType.ShouldNotBeNull();
            _extensionExceptionInstance.ShouldNotBeNull();
            _extensionExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ExtensionException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ExtensionException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ExtensionException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _extensionExceptionInstance.ShouldBeAssignableTo<ExtensionException>();
            _extensionExceptionInstanceFixture.ShouldBeAssignableTo<ExtensionException>();
            CurrentInstance.ShouldBeAssignableTo<ExtensionException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ExtensionException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ExtensionException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var exceptionCategory = this.CreateType<ExtensionExceptions>();
            var message = this.CreateType<string>();
            var innerException = this.CreateType<Exception>();
            ExtensionException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ExtensionException(exceptionCategory, message, innerException);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _extensionExceptionInstance.ShouldNotBeNull();
            _extensionExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ExtensionException>();
        }

        #endregion

        #region General Constructor : Class (ExtensionException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ExtensionException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var exceptionCategory = this.CreateType<ExtensionExceptions>();
            var message = this.CreateType<string>();
            var innerException = this.CreateType<Exception>();
            ExtensionException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ExtensionException(exceptionCategory, message, innerException);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _extensionExceptionInstance.ShouldNotBeNull();
            _extensionExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ExtensionException) instance created

        /// <summary>
        ///     Class (<see cref="ExtensionException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ExtensionException_Is_Created_Test()
        {
            // Assert
            _extensionExceptionInstance.ShouldNotBeNull();
            _extensionExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ExtensionException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ExtensionException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ExtensionException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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
        
        #region General Constructor : Class (ExtensionException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ExtensionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ExtensionException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ExtensionException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ExtensionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ExtensionException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodExtensionExceptionParametersTypes = new Type[] { typeof(ExtensionExceptions), typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodExtensionExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ExtensionException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCategory)]
        public void AUT_ExtensionException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ExtensionException) => Property (Category) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExtensionException_Category_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCategory);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCategory);
            Action currentAction = () => propertyInfo.SetValue(_extensionExceptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionException) => Property (Category) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExtensionException_Public_Class_Category_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCategory);
            var propertyInfo = this.GetPropertyInfo(PropertyCategory);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}