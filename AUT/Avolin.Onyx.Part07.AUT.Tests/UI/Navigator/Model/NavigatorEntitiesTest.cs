using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.NavigatorEntities" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorEntitiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorEntities" />)
        /// </summary>
        public NavigatorEntitiesTest() : base(typeof(NavigatorEntities))
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

        #region General Initializer : Class (NavigatorEntities) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorEntitiesInstanceType;
        private NavigatorEntities _navigatorEntitiesInstance;
        private NavigatorEntities _navigatorEntitiesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorEntities" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorEntitiesInstanceType = typeof(NavigatorEntities);
            _navigatorEntitiesInstanceFixture = this.Create<NavigatorEntities>(false);
            _navigatorEntitiesInstance = _navigatorEntitiesInstanceFixture ?? this.Create<NavigatorEntities>(true);
            CurrentInstance = _navigatorEntitiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorEntities) Initializer

        #region Properties

        private const string PropertyDisplayValue = "DisplayValue";
        private const string PropertyDisplayName = "DisplayName";
        private const string PropertyEntityId = "EntityId";
        private const string PropertySequenceIndex = "SequenceIndex";
        private const string PropertyLboObjectId = "LboObjectId";
        private const string PropertyLboObjectName = "LboObjectName";
        private const string PropertyIsMobileBookmarkEnable = "IsMobileBookmarkEnable";
        private const string PropertyIsClientSummaryEnable = "IsClientSummaryEnable";
        private const string PropertyIsBatchUpdateEnable = "IsBatchUpdateEnable";
        private const string PropertyBatchUpdateResourceName = "BatchUpdateResourceName";
        private const string PropertyDetailViewId = "DetailViewId";
        private const string PropertyListViewFormId = "ListViewFormId";
        private const string PropertyIsBatchActionEnable = "IsBatchActionEnable";
        private const string PropertyBatchActionResourceName = "BatchActionResourceName";

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorEntities) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorEntities" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorEntities_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorEntities) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NavigatorEntities" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorEntities_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorEntities) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorEntities" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorEntities_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorEntities)

        #region General Initializer : Class (NavigatorEntities) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorEntities" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDisplayValue)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyLboObjectId)]
        [TestCase(PropertyLboObjectName)]
        [TestCase(PropertyIsMobileBookmarkEnable)]
        [TestCase(PropertyIsClientSummaryEnable)]
        [TestCase(PropertyIsBatchUpdateEnable)]
        [TestCase(PropertyBatchUpdateResourceName)]
        [TestCase(PropertyDetailViewId)]
        [TestCase(PropertyListViewFormId)]
        [TestCase(PropertyIsBatchActionEnable)]
        [TestCase(PropertyBatchActionResourceName)]
        [Category("AUT Property")]
        public void AUT_NavigatorEntities_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NavigatorEntities) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorEntities" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorEntities_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorEntitiesInstanceType.ShouldNotBeNull();
            _navigatorEntitiesInstance.ShouldNotBeNull();
            _navigatorEntitiesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorEntities) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorEntities" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorEntities_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorEntitiesInstance.ShouldBeAssignableTo<NavigatorEntities>();
            _navigatorEntitiesInstanceFixture.ShouldBeAssignableTo<NavigatorEntities>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorEntities>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorEntities) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorEntities_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NavigatorEntities instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NavigatorEntities) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDisplayValue)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyLboObjectId)]
        [TestCase(PropertyLboObjectName)]
        [TestCase(PropertyIsMobileBookmarkEnable)]
        [TestCase(PropertyIsClientSummaryEnable)]
        [TestCase(PropertyIsBatchUpdateEnable)]
        [TestCase(PropertyBatchUpdateResourceName)]
        [TestCase(PropertyDetailViewId)]
        [TestCase(PropertyListViewFormId)]
        [TestCase(PropertyIsBatchActionEnable)]
        [TestCase(PropertyBatchActionResourceName)]
        public void AUT_NavigatorEntities_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NavigatorEntities) => Property (BatchActionResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_BatchActionResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBatchActionResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyBatchActionResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (BatchUpdateResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_BatchUpdateResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBatchUpdateResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyBatchUpdateResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (DetailViewId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_DetailViewId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailViewId);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailViewId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (DisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_DisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (DisplayValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_DisplayValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayValue);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (EntityId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_EntityId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NavigatorEntities) => Property (IsBatchActionEnable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_IsBatchActionEnable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsBatchActionEnable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsBatchActionEnable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (IsBatchUpdateEnable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_IsBatchUpdateEnable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsBatchUpdateEnable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsBatchUpdateEnable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (IsClientSummaryEnable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_IsClientSummaryEnable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsClientSummaryEnable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsClientSummaryEnable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (IsMobileBookmarkEnable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_IsMobileBookmarkEnable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsMobileBookmarkEnable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsMobileBookmarkEnable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (LboObjectId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_LboObjectId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLboObjectId);
            var propertyInfo = this.GetPropertyInfo(PropertyLboObjectId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (LboObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_LboObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLboObjectName);
            var propertyInfo = this.GetPropertyInfo(PropertyLboObjectName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (ListViewFormId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_ListViewFormId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyListViewFormId);
            var propertyInfo = this.GetPropertyInfo(PropertyListViewFormId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorEntities) => Property (SequenceIndex) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorEntities_Public_Class_SequenceIndex_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}