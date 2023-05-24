using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.CrossOriginSupport;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.CrossOriginSupport
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CrossOriginSupport.OnyxBehaviorExtensionElement" />)
    ///     and namespace <see cref="Onyx.CrossOriginSupport"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxBehaviorExtensionElementTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxBehaviorExtensionElement" />)
        /// </summary>
        public OnyxBehaviorExtensionElementTest() : base(typeof(OnyxBehaviorExtensionElement))
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

        #region General Initializer : Class (OnyxBehaviorExtensionElement) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxBehaviorExtensionElementInstanceType;
        private OnyxBehaviorExtensionElement _onyxBehaviorExtensionElementInstance;
        private OnyxBehaviorExtensionElement _onyxBehaviorExtensionElementInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxBehaviorExtensionElement" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxBehaviorExtensionElementInstanceType = typeof(OnyxBehaviorExtensionElement);
            _onyxBehaviorExtensionElementInstanceFixture = this.Create<OnyxBehaviorExtensionElement>(false);
            _onyxBehaviorExtensionElementInstance = _onyxBehaviorExtensionElementInstanceFixture ?? this.Create<OnyxBehaviorExtensionElement>(true);
            CurrentInstance = _onyxBehaviorExtensionElementInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxBehaviorExtensionElement) Initializer

        #region Properties

        private const string PropertyBehaviorType = "BehaviorType";

        #endregion

        #region Methods

        private const string MethodCreateBehavior = "CreateBehavior";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxBehaviorExtensionElement) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxBehaviorExtensionElement" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxBehaviorExtensionElement_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxBehaviorExtensionElement) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxBehaviorExtensionElement" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxBehaviorExtensionElement_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxBehaviorExtensionElement)
        
        #region General Initializer : Class (OnyxBehaviorExtensionElement) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxBehaviorExtensionElement" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyBehaviorType)]
        [Category("AUT Property")]
        public void AUT_OnyxBehaviorExtensionElement_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxBehaviorExtensionElement) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxBehaviorExtensionElement" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxBehaviorExtensionElement_Is_Instance_Present_Test()
        {
            // Assert
            _onyxBehaviorExtensionElementInstanceType.ShouldNotBeNull();
            _onyxBehaviorExtensionElementInstance.ShouldNotBeNull();
            _onyxBehaviorExtensionElementInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxBehaviorExtensionElement) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxBehaviorExtensionElement" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxBehaviorExtensionElement_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxBehaviorExtensionElementInstance.ShouldBeAssignableTo<OnyxBehaviorExtensionElement>();
            _onyxBehaviorExtensionElementInstanceFixture.ShouldBeAssignableTo<OnyxBehaviorExtensionElement>();
            CurrentInstance.ShouldBeAssignableTo<OnyxBehaviorExtensionElement>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxBehaviorExtensionElement) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBehaviorExtensionElement_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxBehaviorExtensionElement instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxBehaviorExtensionElement) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyBehaviorType)]
        public void AUT_OnyxBehaviorExtensionElement_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxBehaviorExtensionElement) => Property (BehaviorType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxBehaviorExtensionElement_BehaviorType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBehaviorType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyBehaviorType);
            Action currentAction = () => propertyInfo.SetValue(_onyxBehaviorExtensionElementInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxBehaviorExtensionElement) => Property (BehaviorType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxBehaviorExtensionElement_Public_Class_BehaviorType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBehaviorType);
            var propertyInfo = this.GetPropertyInfo(PropertyBehaviorType);

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