using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ScheduleExpiration" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScheduleExpirationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScheduleExpiration" />)
        /// </summary>
        public ScheduleExpirationTest() : base(typeof(ScheduleExpiration))
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

        #region General Initializer : Class (ScheduleExpiration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scheduleExpirationInstanceType;
        private ScheduleExpiration _scheduleExpirationInstance;
        private ScheduleExpiration _scheduleExpirationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScheduleExpiration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scheduleExpirationInstanceType = typeof(ScheduleExpiration);
            _scheduleExpirationInstanceFixture = this.Create<ScheduleExpiration>(false);
            _scheduleExpirationInstance = _scheduleExpirationInstanceFixture ?? this.Create<ScheduleExpiration>(true);
            CurrentInstance = _scheduleExpirationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScheduleExpiration) Initializer

        #region Properties

        private const string PropertyItem = "Item";

        #endregion

        #region Fields

        private const string FielditemField = "itemField";

        #endregion

        #endregion

        #region General Initializer : Class (ScheduleExpiration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScheduleExpiration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ScheduleExpiration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScheduleExpiration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScheduleExpiration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ScheduleExpiration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScheduleExpiration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScheduleExpiration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ScheduleExpiration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScheduleExpiration)

        #region General Initializer : Class (ScheduleExpiration) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScheduleExpiration" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyItem)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ScheduleExpiration_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ScheduleExpiration) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScheduleExpiration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FielditemField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ScheduleExpiration_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScheduleExpiration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScheduleExpiration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ScheduleExpiration_Is_Instance_Present_Test()
        {
            // Assert
            _scheduleExpirationInstanceType.ShouldNotBeNull();
            _scheduleExpirationInstance.ShouldNotBeNull();
            _scheduleExpirationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScheduleExpiration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScheduleExpiration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ScheduleExpiration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scheduleExpirationInstance.ShouldBeAssignableTo<ScheduleExpiration>();
            _scheduleExpirationInstanceFixture.ShouldBeAssignableTo<ScheduleExpiration>();
            CurrentInstance.ShouldBeAssignableTo<ScheduleExpiration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScheduleExpiration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ScheduleExpiration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScheduleExpiration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScheduleExpiration) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyItem)]
        public void AUT_ScheduleExpiration_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScheduleExpiration) => Property (Item) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleExpiration_Item_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItem);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyItem);
            Action currentAction = () => propertyInfo.SetValue(_scheduleExpirationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScheduleExpiration) => Property (Item) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleExpiration_Public_Class_Item_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItem);
            var propertyInfo = this.GetPropertyInfo(PropertyItem);

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