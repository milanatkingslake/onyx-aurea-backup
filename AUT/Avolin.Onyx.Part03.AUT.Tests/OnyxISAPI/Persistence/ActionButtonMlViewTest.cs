using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI.Persistence
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.ActionButtonMlView" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ActionButtonMlViewTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ActionButtonMlView" />)
        /// </summary>
        public ActionButtonMlViewTest() : base(typeof(ActionButtonMlView))
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

        #region General Initializer : Class (ActionButtonMlView) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _actionButtonMlViewInstanceType;
        private ActionButtonMlView _actionButtonMlViewInstance;
        private ActionButtonMlView _actionButtonMlViewInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ActionButtonMlView" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _actionButtonMlViewInstanceType = typeof(ActionButtonMlView);
            _actionButtonMlViewInstanceFixture = this.Create<ActionButtonMlView>(false);
            _actionButtonMlViewInstance = _actionButtonMlViewInstanceFixture ?? this.Create<ActionButtonMlView>(true);
            CurrentInstance = _actionButtonMlViewInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ActionButtonMlView) Initializer

        #region Properties

        private const string PropertyActionButtonId = "ActionButtonId";
        private const string PropertyProfileId = "ProfileId";
        private const string PropertyEntityId = "EntityId";
        private const string PropertyGroupId = "GroupId";
        private const string PropertySequenceIndex = "SequenceIndex";
        private const string PropertyIcon = "Icon";
        private const string PropertyResourceName = "ResourceName";
        private const string PropertySiteId = "SiteId";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertyCaption = "Caption";
        private const string PropertyInsertBy = "InsertBy";
        private const string PropertyInsertDate = "InsertDate";
        private const string PropertyUpdateBy = "UpdateBy";
        private const string PropertyUpdateDate = "UpdateDate";
        private const string PropertyRecordStatus = "RecordStatus";

        #endregion

        #endregion

        #region General Initializer : Class (ActionButtonMlView) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ActionButtonMlView" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionButtonMlView_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ActionButtonMlView) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ActionButtonMlView" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionButtonMlView_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ActionButtonMlView) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ActionButtonMlView" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionButtonMlView_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ActionButtonMlView)

        #region General Initializer : Class (ActionButtonMlView) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ActionButtonMlView" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyActionButtonId)]
        [TestCase(PropertyProfileId)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertyGroupId)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyIcon)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyCaption)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyRecordStatus)]
        [Category("AUT Property")]
        public void AUT_ActionButtonMlView_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ActionButtonMlView) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ActionButtonMlView" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ActionButtonMlView_Is_Instance_Present_Test()
        {
            // Assert
            _actionButtonMlViewInstanceType.ShouldNotBeNull();
            _actionButtonMlViewInstance.ShouldNotBeNull();
            _actionButtonMlViewInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ActionButtonMlView) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ActionButtonMlView" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ActionButtonMlView_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _actionButtonMlViewInstance.ShouldBeAssignableTo<ActionButtonMlView>();
            _actionButtonMlViewInstanceFixture.ShouldBeAssignableTo<ActionButtonMlView>();
            CurrentInstance.ShouldBeAssignableTo<ActionButtonMlView>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ActionButtonMlView) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ActionButtonMlView_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ActionButtonMlView instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ActionButtonMlView) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyActionButtonId)]
        [TestCase(PropertyProfileId)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertyGroupId)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyIcon)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyCaption)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyRecordStatus)]
        public void AUT_ActionButtonMlView_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (ActionButtonId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_ActionButtonId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionButtonId);
            var propertyInfo = this.GetPropertyInfo(PropertyActionButtonId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (Caption) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_Caption_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (EntityId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_EntityId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityId);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (GroupId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_GroupId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGroupId);
            var propertyInfo = this.GetPropertyInfo(PropertyGroupId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (Icon) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_Icon_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIcon);
            var propertyInfo = this.GetPropertyInfo(PropertyIcon);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (InsertBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_InsertBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertBy);
            var propertyInfo = this.GetPropertyInfo(PropertyInsertBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (InsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_InsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_actionButtonMlViewInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (InsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_InsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguageCode);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguageCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (ProfileId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_ProfileId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProfileId);
            var propertyInfo = this.GetPropertyInfo(PropertyProfileId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (RecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_RecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecordStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyRecordStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (ResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_ResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (SequenceIndex) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_SequenceIndex_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySequenceIndex);
            var propertyInfo = this.GetPropertyInfo(PropertySequenceIndex);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySiteId);
            var propertyInfo = this.GetPropertyInfo(PropertySiteId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (UpdateBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_UpdateBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateBy);
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (UpdateDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_UpdateDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);
            Action currentAction = () => propertyInfo.SetValue(_actionButtonMlViewInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMlView) => Property (UpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMlView_Public_Class_UpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);

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