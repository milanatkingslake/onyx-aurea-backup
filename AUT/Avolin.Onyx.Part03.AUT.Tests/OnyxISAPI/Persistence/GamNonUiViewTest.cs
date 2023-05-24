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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.GamNonUiView" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class GamNonUiViewTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GamNonUiView" />)
        /// </summary>
        public GamNonUiViewTest() : base(typeof(GamNonUiView))
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

        #region General Initializer : Class (GamNonUiView) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _gamNonUiViewInstanceType;
        private GamNonUiView _gamNonUiViewInstance;
        private GamNonUiView _gamNonUiViewInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GamNonUiView" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _gamNonUiViewInstanceType = typeof(GamNonUiView);
            _gamNonUiViewInstanceFixture = this.Create<GamNonUiView>(false);
            _gamNonUiViewInstance = _gamNonUiViewInstanceFixture ?? this.Create<GamNonUiView>(true);
            CurrentInstance = _gamNonUiViewInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GamNonUiView) Initializer

        #region Properties

        private const string PropertyProfileId = "ProfileId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertyActionName = "ActionName";
        private const string PropertyActionDisplayName = "ActionDisplayName";
        private const string PropertyRecordStatus = "RecordStatus";
        private const string PropertyIsSynchronous = "IsSynchronous";
        private const string PropertyBrokerId = "BrokerId";
        private const string PropertyBrokerPriority = "BrokerPriority";
        private const string PropertyBrokerRecordStatus = "BrokerRecordStatus";
        private const string PropertyEndPoint = "EndPoint";
        private const string PropertyEndPointId = "EndPointId";
        private const string PropertyEndPointPriority = "EndPointPriority";
        private const string PropertyEndPointRecordStatus = "EndPointRecordStatus";
        private const string PropertyEndPointPropertyId = "EndPointPropertyId";
        private const string PropertyPropertyValue = "PropertyValue";
        private const string PropertyEndPointPropertyRecordStatus = "EndPointPropertyRecordStatus";
        private const string PropertyEndPointTypeId = "EndPointTypeId";
        private const string PropertyDisplayTypeName = "DisplayTypeName";
        private const string PropertyTypeName = "TypeName";
        private const string PropertyEndPointTypeRecordStatus = "EndPointTypeRecordStatus";
        private const string PropertyPropertyName = "PropertyName";
        private const string PropertyEndPointPropertyNameRecordStatus = "EndPointPropertyNameRecordStatus";
        private const string PropertyPropertyNameId = "PropertyNameId";

        #endregion

        #endregion

        #region General Initializer : Class (GamNonUiView) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GamNonUiView" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GamNonUiView_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GamNonUiView) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GamNonUiView" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GamNonUiView_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GamNonUiView) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GamNonUiView" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GamNonUiView_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GamNonUiView)

        #region General Initializer : Class (GamNonUiView) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GamNonUiView" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyProfileId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyActionName)]
        [TestCase(PropertyActionDisplayName)]
        [TestCase(PropertyRecordStatus)]
        [TestCase(PropertyIsSynchronous)]
        [TestCase(PropertyBrokerId)]
        [TestCase(PropertyBrokerPriority)]
        [TestCase(PropertyBrokerRecordStatus)]
        [TestCase(PropertyEndPoint)]
        [TestCase(PropertyEndPointId)]
        [TestCase(PropertyEndPointPriority)]
        [TestCase(PropertyEndPointRecordStatus)]
        [TestCase(PropertyEndPointPropertyId)]
        [TestCase(PropertyPropertyValue)]
        [TestCase(PropertyEndPointPropertyRecordStatus)]
        [TestCase(PropertyEndPointTypeId)]
        [TestCase(PropertyDisplayTypeName)]
        [TestCase(PropertyTypeName)]
        [TestCase(PropertyEndPointTypeRecordStatus)]
        [TestCase(PropertyPropertyName)]
        [TestCase(PropertyEndPointPropertyNameRecordStatus)]
        [TestCase(PropertyPropertyNameId)]
        [Category("AUT Property")]
        public void AUT_GamNonUiView_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GamNonUiView) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GamNonUiView" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GamNonUiView_Is_Instance_Present_Test()
        {
            // Assert
            _gamNonUiViewInstanceType.ShouldNotBeNull();
            _gamNonUiViewInstance.ShouldNotBeNull();
            _gamNonUiViewInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GamNonUiView) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GamNonUiView" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GamNonUiView_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _gamNonUiViewInstance.ShouldBeAssignableTo<GamNonUiView>();
            _gamNonUiViewInstanceFixture.ShouldBeAssignableTo<GamNonUiView>();
            CurrentInstance.ShouldBeAssignableTo<GamNonUiView>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (GamNonUiView) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_GamNonUiView_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            GamNonUiView instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GamNonUiView) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyProfileId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyActionName)]
        [TestCase(PropertyActionDisplayName)]
        [TestCase(PropertyRecordStatus)]
        [TestCase(PropertyIsSynchronous)]
        [TestCase(PropertyBrokerId)]
        [TestCase(PropertyBrokerPriority)]
        [TestCase(PropertyBrokerRecordStatus)]
        [TestCase(PropertyEndPoint)]
        [TestCase(PropertyEndPointId)]
        [TestCase(PropertyEndPointPriority)]
        [TestCase(PropertyEndPointRecordStatus)]
        [TestCase(PropertyEndPointPropertyId)]
        [TestCase(PropertyPropertyValue)]
        [TestCase(PropertyEndPointPropertyRecordStatus)]
        [TestCase(PropertyEndPointTypeId)]
        [TestCase(PropertyDisplayTypeName)]
        [TestCase(PropertyTypeName)]
        [TestCase(PropertyEndPointTypeRecordStatus)]
        [TestCase(PropertyPropertyName)]
        [TestCase(PropertyEndPointPropertyNameRecordStatus)]
        [TestCase(PropertyPropertyNameId)]
        public void AUT_GamNonUiView_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GamNonUiView) => Property (ActionDisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_ActionDisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyActionDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (ActionName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_ActionName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (GamNonUiView) => Property (BrokerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_BrokerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBrokerId);
            var propertyInfo = this.GetPropertyInfo(PropertyBrokerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (BrokerPriority) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_BrokerPriority_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBrokerPriority);
            var propertyInfo = this.GetPropertyInfo(PropertyBrokerPriority);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (BrokerRecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_BrokerRecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBrokerRecordStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyBrokerRecordStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (DisplayTypeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_DisplayTypeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayTypeName);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayTypeName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPoint) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPoint_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPoint);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPoint);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPointId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPointId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointId);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPointPriority) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPointPriority_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointPriority);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointPriority);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPointPropertyId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPointPropertyId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointPropertyId);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointPropertyId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPointPropertyNameRecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPointPropertyNameRecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointPropertyNameRecordStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointPropertyNameRecordStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPointPropertyRecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPointPropertyRecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointPropertyRecordStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointPropertyRecordStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPointRecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPointRecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointRecordStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointRecordStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPointTypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPointTypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointTypeId);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointTypeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (EndPointTypeRecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_EndPointTypeRecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointTypeRecordStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointTypeRecordStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (IsSynchronous) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_IsSynchronous_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSynchronous);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSynchronous);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (GamNonUiView) => Property (ProfileId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_ProfileId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (GamNonUiView) => Property (PropertyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_PropertyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyPropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (PropertyNameId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_PropertyNameId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPropertyNameId);
            var propertyInfo = this.GetPropertyInfo(PropertyPropertyNameId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (PropertyValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_PropertyValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPropertyValue);
            var propertyInfo = this.GetPropertyInfo(PropertyPropertyValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GamNonUiView) => Property (RecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_RecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (GamNonUiView) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (GamNonUiView) => Property (TypeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GamNonUiView_Public_Class_TypeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTypeName);
            var propertyInfo = this.GetPropertyInfo(PropertyTypeName);

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