using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Core
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Core.UIOnyxUserContext" />)
    ///     and namespace <see cref="Onyx.UI.Core"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UIOnyxUserContextTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UIOnyxUserContext" />)
        /// </summary>
        public UIOnyxUserContextTest() : base(typeof(UIOnyxUserContext))
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

        #region General Initializer : Class (UIOnyxUserContext) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _uIOnyxUserContextInstanceType;
        private UIOnyxUserContext _uIOnyxUserContextInstance;
        private UIOnyxUserContext _uIOnyxUserContextInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UIOnyxUserContext" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _uIOnyxUserContextInstanceType = typeof(UIOnyxUserContext);
            _uIOnyxUserContextInstanceFixture = this.Create<UIOnyxUserContext>(false);
            _uIOnyxUserContextInstance = _uIOnyxUserContextInstanceFixture ?? this.Create<UIOnyxUserContext>(true);
            CurrentInstance = _uIOnyxUserContextInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UIOnyxUserContext) Initializer

        #region Properties

        private const string PropertyOnyxUserContext = "OnyxUserContext";

        #endregion

        #region Methods

        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        #endregion

        #endregion

        #region General Initializer : Class (UIOnyxUserContext) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UIOnyxUserContext" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UIOnyxUserContext_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UIOnyxUserContext) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UIOnyxUserContext" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UIOnyxUserContext_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UIOnyxUserContext) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UIOnyxUserContext" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UIOnyxUserContext_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UIOnyxUserContext)

        #region General Initializer : Class (UIOnyxUserContext) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="UIOnyxUserContext" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxUserContext)]
        [Category("AUT Property")]
        public void AUT_UIOnyxUserContext_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UIOnyxUserContext) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UIOnyxUserContext" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UIOnyxUserContext_Is_Instance_Present_Test()
        {
            // Assert
            _uIOnyxUserContextInstanceType.ShouldNotBeNull();
            _uIOnyxUserContextInstance.ShouldNotBeNull();
            _uIOnyxUserContextInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UIOnyxUserContext) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UIOnyxUserContext" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UIOnyxUserContext_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _uIOnyxUserContextInstance.ShouldBeAssignableTo<UIOnyxUserContext>();
            _uIOnyxUserContextInstanceFixture.ShouldBeAssignableTo<UIOnyxUserContext>();
            CurrentInstance.ShouldBeAssignableTo<UIOnyxUserContext>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UIOnyxUserContext) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UIOnyxUserContext_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UIOnyxUserContext instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (UIOnyxUserContext) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOnyxUserContext)]
        public void AUT_UIOnyxUserContext_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (UIOnyxUserContext) => Property (OnyxUserContext) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UIOnyxUserContext_OnyxUserContext_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxUserContext);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxUserContext);
            Action currentAction = () => propertyInfo.SetValue(_uIOnyxUserContextInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (UIOnyxUserContext) => Property (OnyxUserContext) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UIOnyxUserContext_Public_Class_OnyxUserContext_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxUserContext);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxUserContext);

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

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UIOnyxUserContext_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UIOnyxUserContext_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}