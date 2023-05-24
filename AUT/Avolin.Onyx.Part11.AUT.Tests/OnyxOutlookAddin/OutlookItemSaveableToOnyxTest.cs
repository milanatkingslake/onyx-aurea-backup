using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OutlookItemSaveableToOnyx" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OutlookItemSaveableToOnyxTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OutlookItemSaveableToOnyx" />)
        /// </summary>
        public OutlookItemSaveableToOnyxTest() : base(typeof(OutlookItemSaveableToOnyx))
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

        #region General Initializer : Class (OutlookItemSaveableToOnyx) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _outlookItemSaveableToOnyxInstanceType;
        private OutlookItemSaveableToOnyx _outlookItemSaveableToOnyxInstance;
        private OutlookItemSaveableToOnyx _outlookItemSaveableToOnyxInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OutlookItemSaveableToOnyx" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _outlookItemSaveableToOnyxInstanceType = typeof(OutlookItemSaveableToOnyx);
            _outlookItemSaveableToOnyxInstanceFixture = this.Create<OutlookItemSaveableToOnyx>(false);
            _outlookItemSaveableToOnyxInstance = _outlookItemSaveableToOnyxInstanceFixture ?? this.Create<OutlookItemSaveableToOnyx>(true);
            CurrentInstance = _outlookItemSaveableToOnyxInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OutlookItemSaveableToOnyx) Initializer

        #region Properties

        private const string PropertySavedAttachments = "SavedAttachments";
        private const string PropertyItemExistsInOnyx = "ItemExistsInOnyx";

        #endregion

        #endregion

        #region General Initializer : Class (OutlookItemSaveableToOnyx) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OutlookItemSaveableToOnyx" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookItemSaveableToOnyx_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookItemSaveableToOnyx) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OutlookItemSaveableToOnyx" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookItemSaveableToOnyx_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OutlookItemSaveableToOnyx)

        #region General Initializer : Class (OutlookItemSaveableToOnyx) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookItemSaveableToOnyx" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySavedAttachments)]
        [TestCase(PropertyItemExistsInOnyx)]
        [Category("AUT Property")]
        public void AUT_OutlookItemSaveableToOnyx_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OutlookItemSaveableToOnyx) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OutlookItemSaveableToOnyx" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookItemSaveableToOnyx_Is_Instance_Present_Test()
        {
            // Assert
            _outlookItemSaveableToOnyxInstanceType.ShouldNotBeNull();
            _outlookItemSaveableToOnyxInstance.ShouldNotBeNull();
            _outlookItemSaveableToOnyxInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OutlookItemSaveableToOnyx) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OutlookItemSaveableToOnyx" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookItemSaveableToOnyx_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _outlookItemSaveableToOnyxInstance.ShouldBeAssignableTo<OutlookItemSaveableToOnyx>();
            _outlookItemSaveableToOnyxInstanceFixture.ShouldBeAssignableTo<OutlookItemSaveableToOnyx>();
            CurrentInstance.ShouldBeAssignableTo<OutlookItemSaveableToOnyx>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OutlookItemSaveableToOnyx) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySavedAttachments)]
        [TestCase(PropertyItemExistsInOnyx)]
        public void AUT_OutlookItemSaveableToOnyx_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OutlookItemSaveableToOnyx) => Property (ItemExistsInOnyx) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemSaveableToOnyx_Public_Class_ItemExistsInOnyx_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemExistsInOnyx);
            var propertyInfo = this.GetPropertyInfo(PropertyItemExistsInOnyx);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookItemSaveableToOnyx) => Property (SavedAttachments) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookItemSaveableToOnyx_Public_Class_SavedAttachments_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySavedAttachments);
            var propertyInfo = this.GetPropertyInfo(PropertySavedAttachments);

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