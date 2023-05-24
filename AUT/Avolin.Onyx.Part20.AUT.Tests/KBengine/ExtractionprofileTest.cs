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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.extraction_profile" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ExtractionprofileTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="extraction_profile" />)
        /// </summary>
        public ExtractionprofileTest() : base(typeof(extraction_profile))
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

        #region General Initializer : Class (extraction_profile) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _extractionprofileInstanceType;
        private extraction_profile _extractionprofileInstance;
        private extraction_profile _extractionprofileInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="extraction_profile" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _extractionprofileInstanceType = typeof(extraction_profile);
            _extractionprofileInstanceFixture = this.Create<extraction_profile>(false);
            _extractionprofileInstance = _extractionprofileInstanceFixture ?? this.Create<extraction_profile>(true);
            CurrentInstance = _extractionprofileInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (extraction_profile) Initializer

        #region Properties

        private const string Propertyextraction_profile_id = "extraction_profile_id";
        private const string Propertysite_id = "site_id";
        private const string Propertyextraction_profile_name = "extraction_profile_name";
        private const string Propertyextraction_sproc_name = "extraction_sproc_name";
        private const string Propertypublish_worknotes = "publish_worknotes";
        private const string Propertydelete_sproc_name = "delete_sproc_name";
        private const string Propertydestination_directory = "destination_directory";
        private const string Propertyfile_name_prefix = "file_name_prefix";
        private const string Propertyfile_name_suffix = "file_name_suffix";
        private const string Propertyfile_extension = "file_extension";
        private const string Propertytemplate_location = "template_location";
        private const string Propertylanguage_code = "language_code";
        private const string Propertydate_format_style = "date_format_style";
        private const string Propertylast_completed_date = "last_completed_date";
        private const string Propertystart_date = "start_date";
        private const string Propertyrecord_status = "record_status";

        #endregion

        #endregion

        #region General Initializer : Class (extraction_profile) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="extraction_profile" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Extractionprofile_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (extraction_profile) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="extraction_profile" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Extractionprofile_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (extraction_profile) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="extraction_profile" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Extractionprofile_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (extraction_profile)

        #region General Initializer : Class (extraction_profile) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="extraction_profile" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyextraction_profile_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertyextraction_profile_name)]
        [TestCase(Propertyextraction_sproc_name)]
        [TestCase(Propertypublish_worknotes)]
        [TestCase(Propertydelete_sproc_name)]
        [TestCase(Propertydestination_directory)]
        [TestCase(Propertyfile_name_prefix)]
        [TestCase(Propertyfile_name_suffix)]
        [TestCase(Propertyfile_extension)]
        [TestCase(Propertytemplate_location)]
        [TestCase(Propertylanguage_code)]
        [TestCase(Propertydate_format_style)]
        [TestCase(Propertylast_completed_date)]
        [TestCase(Propertystart_date)]
        [TestCase(Propertyrecord_status)]
        [Category("AUT Property")]
        public void AUT_Extractionprofile_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (extraction_profile) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="extraction_profile" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Extractionprofile_Is_Instance_Present_Test()
        {
            // Assert
            _extractionprofileInstanceType.ShouldNotBeNull();
            _extractionprofileInstance.ShouldNotBeNull();
            _extractionprofileInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (extraction_profile) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="extraction_profile" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Extractionprofile_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _extractionprofileInstance.ShouldBeAssignableTo<extraction_profile>();
            _extractionprofileInstanceFixture.ShouldBeAssignableTo<extraction_profile>();
            CurrentInstance.ShouldBeAssignableTo<extraction_profile>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (extraction_profile) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Extractionprofile_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            extraction_profile instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (extraction_profile) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyextraction_profile_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertyextraction_profile_name)]
        [TestCase(Propertyextraction_sproc_name)]
        [TestCase(Propertypublish_worknotes)]
        [TestCase(Propertydelete_sproc_name)]
        [TestCase(Propertydestination_directory)]
        [TestCase(Propertyfile_name_prefix)]
        [TestCase(Propertyfile_name_suffix)]
        [TestCase(Propertyfile_extension)]
        [TestCase(Propertytemplate_location)]
        [TestCase(Propertylanguage_code)]
        [TestCase(Propertydate_format_style)]
        [TestCase(Propertylast_completed_date)]
        [TestCase(Propertystart_date)]
        [TestCase(Propertyrecord_status)]
        public void AUT_Extractionprofile_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (extraction_profile) => Property (date_format_style) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_date_format_style_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertydate_format_style);
            var propertyInfo = this.GetPropertyInfo(Propertydate_format_style);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (delete_sproc_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_delete_sproc_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertydelete_sproc_name);
            var propertyInfo = this.GetPropertyInfo(Propertydelete_sproc_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (destination_directory) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_destination_directory_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertydestination_directory);
            var propertyInfo = this.GetPropertyInfo(Propertydestination_directory);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (extraction_profile_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_extraction_profile_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyextraction_profile_id);
            var propertyInfo = this.GetPropertyInfo(Propertyextraction_profile_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (extraction_profile_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_extraction_profile_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyextraction_profile_name);
            var propertyInfo = this.GetPropertyInfo(Propertyextraction_profile_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (extraction_sproc_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_extraction_sproc_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyextraction_sproc_name);
            var propertyInfo = this.GetPropertyInfo(Propertyextraction_sproc_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (file_extension) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_file_extension_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfile_extension);
            var propertyInfo = this.GetPropertyInfo(Propertyfile_extension);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (file_name_prefix) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_file_name_prefix_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfile_name_prefix);
            var propertyInfo = this.GetPropertyInfo(Propertyfile_name_prefix);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (file_name_suffix) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_file_name_suffix_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfile_name_suffix);
            var propertyInfo = this.GetPropertyInfo(Propertyfile_name_suffix);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (language_code) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_language_code_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylanguage_code);
            var propertyInfo = this.GetPropertyInfo(Propertylanguage_code);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (last_completed_date) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_last_completed_date_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylast_completed_date);
            var propertyInfo = this.GetPropertyInfo(Propertylast_completed_date);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (publish_worknotes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_publish_worknotes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertypublish_worknotes);
            var propertyInfo = this.GetPropertyInfo(Propertypublish_worknotes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (record_status) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_record_status_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyrecord_status);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyrecord_status);
            Action currentAction = () => propertyInfo.SetValue(_extractionprofileInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (record_status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_record_status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyrecord_status);
            var propertyInfo = this.GetPropertyInfo(Propertyrecord_status);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (site_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_site_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysite_id);
            var propertyInfo = this.GetPropertyInfo(Propertysite_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (start_date) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_start_date_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertystart_date);
            var propertyInfo = this.GetPropertyInfo(Propertystart_date);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (extraction_profile) => Property (template_location) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Extractionprofile_Public_Class_template_location_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertytemplate_location);
            var propertyInfo = this.GetPropertyInfo(Propertytemplate_location);

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