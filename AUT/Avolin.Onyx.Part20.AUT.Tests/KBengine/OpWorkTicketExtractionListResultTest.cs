using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using KBengine;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.KBengine
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.opWorkTicketExtractionList_Result" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OpWorkTicketExtractionListResultTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="opWorkTicketExtractionList_Result" />)
        /// </summary>
        public OpWorkTicketExtractionListResultTest() : base(typeof(opWorkTicketExtractionList_Result))
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

        #region General Initializer : Class (opWorkTicketExtractionList_Result) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _opWorkTicketExtractionListResultInstanceType;
        private opWorkTicketExtractionList_Result _opWorkTicketExtractionListResultInstance;
        private opWorkTicketExtractionList_Result _opWorkTicketExtractionListResultInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="opWorkTicketExtractionList_Result" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _opWorkTicketExtractionListResultInstanceType = typeof(opWorkTicketExtractionList_Result);
            _opWorkTicketExtractionListResultInstanceFixture = this.Create<opWorkTicketExtractionList_Result>(false);
            _opWorkTicketExtractionListResultInstance = _opWorkTicketExtractionListResultInstanceFixture ?? this.Create<opWorkTicketExtractionList_Result>(true);
            CurrentInstance = _opWorkTicketExtractionListResultInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (opWorkTicketExtractionList_Result) Initializer

        #region Properties

        private const string PropertyRecordId = "RecordId";
        private const string PropertyFormType = "FormType";
        private const string PropertySiteId = "SiteId";
        private const string PropertyDescription = "Description";
        private const string PropertyType = "Type";
        private const string PropertyAssignedTo = "AssignedTo";
        private const string PropertyProduct = "Product";
        private const string PropertyStatus = "Status";
        private const string PropertySource = "Source";
        private const string PropertyPriority = "Priority";
        private const string PropertySeverity = "Severity";
        private const string PropertyKeywords = "Keywords";
        private const string PropertyFoundVersion = "FoundVersion";
        private const string PropertyFixedVersion = "FixedVersion";
        private const string PropertyReleaseVersion = "ReleaseVersion";
        private const string PropertyLastUpdateBy = "LastUpdateBy";
        private const string PropertyLastUpdateDate = "LastUpdateDate";
        private const string PropertyDisplayedUpdateDate = "DisplayedUpdateDate";

        #endregion

        #endregion

        #region General Initializer : Class (opWorkTicketExtractionList_Result) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="opWorkTicketExtractionList_Result" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkTicketExtractionListResult_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (opWorkTicketExtractionList_Result) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="opWorkTicketExtractionList_Result" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkTicketExtractionListResult_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (opWorkTicketExtractionList_Result) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="opWorkTicketExtractionList_Result" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OpWorkTicketExtractionListResult_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (opWorkTicketExtractionList_Result)

        #region General Initializer : Class (opWorkTicketExtractionList_Result) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="opWorkTicketExtractionList_Result" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyRecordId)]
        [TestCase(PropertyFormType)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyType)]
        [TestCase(PropertyAssignedTo)]
        [TestCase(PropertyProduct)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertySource)]
        [TestCase(PropertyPriority)]
        [TestCase(PropertySeverity)]
        [TestCase(PropertyKeywords)]
        [TestCase(PropertyFoundVersion)]
        [TestCase(PropertyFixedVersion)]
        [TestCase(PropertyReleaseVersion)]
        [TestCase(PropertyLastUpdateBy)]
        [TestCase(PropertyLastUpdateDate)]
        [TestCase(PropertyDisplayedUpdateDate)]
        [Category("AUT Property")]
        public void AUT_OpWorkTicketExtractionListResult_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (opWorkTicketExtractionList_Result) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="opWorkTicketExtractionList_Result" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OpWorkTicketExtractionListResult_Is_Instance_Present_Test()
        {
            // Assert
            _opWorkTicketExtractionListResultInstanceType.ShouldNotBeNull();
            _opWorkTicketExtractionListResultInstance.ShouldNotBeNull();
            _opWorkTicketExtractionListResultInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (opWorkTicketExtractionList_Result) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="opWorkTicketExtractionList_Result" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OpWorkTicketExtractionListResult_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _opWorkTicketExtractionListResultInstance.ShouldBeAssignableTo<opWorkTicketExtractionList_Result>();
            _opWorkTicketExtractionListResultInstanceFixture.ShouldBeAssignableTo<opWorkTicketExtractionList_Result>();
            CurrentInstance.ShouldBeAssignableTo<opWorkTicketExtractionList_Result>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (opWorkTicketExtractionList_Result) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OpWorkTicketExtractionListResult_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            opWorkTicketExtractionList_Result instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyRecordId)]
        [TestCase(PropertyFormType)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyType)]
        [TestCase(PropertyAssignedTo)]
        [TestCase(PropertyProduct)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertySource)]
        [TestCase(PropertyPriority)]
        [TestCase(PropertySeverity)]
        [TestCase(PropertyKeywords)]
        [TestCase(PropertyFoundVersion)]
        [TestCase(PropertyFixedVersion)]
        [TestCase(PropertyReleaseVersion)]
        [TestCase(PropertyLastUpdateBy)]
        [TestCase(PropertyLastUpdateDate)]
        [TestCase(PropertyDisplayedUpdateDate)]
        public void AUT_OpWorkTicketExtractionListResult_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (AssignedTo) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_AssignedTo_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAssignedTo);
            var propertyInfo = this.GetPropertyInfo(PropertyAssignedTo);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (DisplayedUpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_DisplayedUpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayedUpdateDate);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayedUpdateDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (FixedVersion) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_FixedVersion_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFixedVersion);
            var propertyInfo = this.GetPropertyInfo(PropertyFixedVersion);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (FormType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_FormType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFormType);
            var propertyInfo = this.GetPropertyInfo(PropertyFormType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (FoundVersion) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_FoundVersion_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFoundVersion);
            var propertyInfo = this.GetPropertyInfo(PropertyFoundVersion);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (Keywords) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_Keywords_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyKeywords);
            var propertyInfo = this.GetPropertyInfo(PropertyKeywords);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (LastUpdateBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_LastUpdateBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastUpdateBy);
            var propertyInfo = this.GetPropertyInfo(PropertyLastUpdateBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (LastUpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_LastUpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastUpdateDate);
            var propertyInfo = this.GetPropertyInfo(PropertyLastUpdateDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (Priority) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_Priority_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPriority);
            var propertyInfo = this.GetPropertyInfo(PropertyPriority);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (Product) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_Product_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProduct);
            var propertyInfo = this.GetPropertyInfo(PropertyProduct);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (RecordId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_RecordId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecordId);
            var propertyInfo = this.GetPropertyInfo(PropertyRecordId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (ReleaseVersion) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_ReleaseVersion_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReleaseVersion);
            var propertyInfo = this.GetPropertyInfo(PropertyReleaseVersion);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (Severity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_Severity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySeverity);
            var propertyInfo = this.GetPropertyInfo(PropertySeverity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (Source) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_Source_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySource);
            var propertyInfo = this.GetPropertyInfo(PropertySource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (Status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_Status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (opWorkTicketExtractionList_Result) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OpWorkTicketExtractionListResult_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var propertyInfo = this.GetPropertyInfo(PropertyType);

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