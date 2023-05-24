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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.work_note_detail" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class WorknotedetailTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="work_note_detail" />)
        /// </summary>
        public WorknotedetailTest() : base(typeof(work_note_detail))
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

        #region General Initializer : Class (work_note_detail) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _worknotedetailInstanceType;
        private work_note_detail _worknotedetailInstance;
        private work_note_detail _worknotedetailInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="work_note_detail" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _worknotedetailInstanceType = typeof(work_note_detail);
            _worknotedetailInstanceFixture = this.Create<work_note_detail>(false);
            _worknotedetailInstance = _worknotedetailInstanceFixture ?? this.Create<work_note_detail>(true);
            CurrentInstance = _worknotedetailInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (work_note_detail) Initializer

        #region Properties

        private const string Propertywork_note_detail_id = "work_note_detail_id";
        private const string Propertywork_note_header_id = "work_note_header_id";
        private const string Propertyseq_num = "seq_num";
        private const string Propertylogmark = "logmark";
        private const string Propertylogmark_sequence = "logmark_sequence";
        private const string Propertypublish_bit_mask = "publish_bit_mask";
        private const string Propertywork_note = "work_note";
        private const string Propertysite_id = "site_id";
        private const string Propertyinsert_by = "insert_by";
        private const string Propertyinsert_date = "insert_date";
        private const string Propertyupdate_by = "update_by";
        private const string Propertyupdate_date = "update_date";
        private const string Propertyonyx_timestamp = "onyx_timestamp";
        private const string Propertydelete_status = "delete_status";

        #endregion

        #endregion

        #region General Initializer : Class (work_note_detail) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="work_note_detail" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Worknotedetail_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (work_note_detail) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="work_note_detail" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Worknotedetail_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (work_note_detail) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="work_note_detail" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Worknotedetail_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (work_note_detail)

        #region General Initializer : Class (work_note_detail) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="work_note_detail" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertywork_note_detail_id)]
        [TestCase(Propertywork_note_header_id)]
        [TestCase(Propertyseq_num)]
        [TestCase(Propertylogmark)]
        [TestCase(Propertylogmark_sequence)]
        [TestCase(Propertypublish_bit_mask)]
        [TestCase(Propertywork_note)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertyinsert_by)]
        [TestCase(Propertyinsert_date)]
        [TestCase(Propertyupdate_by)]
        [TestCase(Propertyupdate_date)]
        [TestCase(Propertyonyx_timestamp)]
        [TestCase(Propertydelete_status)]
        [Category("AUT Property")]
        public void AUT_Worknotedetail_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (work_note_detail) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="work_note_detail" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Worknotedetail_Is_Instance_Present_Test()
        {
            // Assert
            _worknotedetailInstanceType.ShouldNotBeNull();
            _worknotedetailInstance.ShouldNotBeNull();
            _worknotedetailInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (work_note_detail) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="work_note_detail" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Worknotedetail_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _worknotedetailInstance.ShouldBeAssignableTo<work_note_detail>();
            _worknotedetailInstanceFixture.ShouldBeAssignableTo<work_note_detail>();
            CurrentInstance.ShouldBeAssignableTo<work_note_detail>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (work_note_detail) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Worknotedetail_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            work_note_detail instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (work_note_detail) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertywork_note_detail_id)]
        [TestCase(Propertywork_note_header_id)]
        [TestCase(Propertyseq_num)]
        [TestCase(Propertylogmark)]
        [TestCase(Propertylogmark_sequence)]
        [TestCase(Propertypublish_bit_mask)]
        [TestCase(Propertywork_note)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertyinsert_by)]
        [TestCase(Propertyinsert_date)]
        [TestCase(Propertyupdate_by)]
        [TestCase(Propertyupdate_date)]
        [TestCase(Propertyonyx_timestamp)]
        [TestCase(Propertydelete_status)]
        public void AUT_Worknotedetail_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (work_note_detail) => Property (delete_status) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_delete_status_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertydelete_status);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertydelete_status);
            Action currentAction = () => propertyInfo.SetValue(_worknotedetailInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (delete_status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_delete_status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertydelete_status);
            var propertyInfo = this.GetPropertyInfo(Propertydelete_status);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (insert_by) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_insert_by_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyinsert_by);
            var propertyInfo = this.GetPropertyInfo(Propertyinsert_by);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (insert_date) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_insert_date_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyinsert_date);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyinsert_date);
            Action currentAction = () => propertyInfo.SetValue(_worknotedetailInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (insert_date) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_insert_date_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyinsert_date);
            var propertyInfo = this.GetPropertyInfo(Propertyinsert_date);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (logmark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_logmark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylogmark);
            var propertyInfo = this.GetPropertyInfo(Propertylogmark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (logmark_sequence) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_logmark_sequence_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylogmark_sequence);
            var propertyInfo = this.GetPropertyInfo(Propertylogmark_sequence);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (onyx_timestamp) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_onyx_timestamp_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyonyx_timestamp);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyonyx_timestamp);
            Action currentAction = () => propertyInfo.SetValue(_worknotedetailInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (onyx_timestamp) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_onyx_timestamp_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyonyx_timestamp);
            var propertyInfo = this.GetPropertyInfo(Propertyonyx_timestamp);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (publish_bit_mask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_publish_bit_mask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertypublish_bit_mask);
            var propertyInfo = this.GetPropertyInfo(Propertypublish_bit_mask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (seq_num) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_seq_num_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyseq_num);
            var propertyInfo = this.GetPropertyInfo(Propertyseq_num);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (site_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_site_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (work_note_detail) => Property (update_by) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_update_by_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyupdate_by);
            var propertyInfo = this.GetPropertyInfo(Propertyupdate_by);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (update_date) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_update_date_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyupdate_date);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyupdate_date);
            Action currentAction = () => propertyInfo.SetValue(_worknotedetailInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (update_date) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_update_date_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyupdate_date);
            var propertyInfo = this.GetPropertyInfo(Propertyupdate_date);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (work_note) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_work_note_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertywork_note);
            var propertyInfo = this.GetPropertyInfo(Propertywork_note);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (work_note_detail_id) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_work_note_detail_id_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertywork_note_detail_id);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertywork_note_detail_id);
            Action currentAction = () => propertyInfo.SetValue(_worknotedetailInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (work_note_detail_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_work_note_detail_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertywork_note_detail_id);
            var propertyInfo = this.GetPropertyInfo(Propertywork_note_detail_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (work_note_header_id) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_work_note_header_id_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertywork_note_header_id);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertywork_note_header_id);
            Action currentAction = () => propertyInfo.SetValue(_worknotedetailInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (work_note_detail) => Property (work_note_header_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknotedetail_Public_Class_work_note_header_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertywork_note_header_id);
            var propertyInfo = this.GetPropertyInfo(Propertywork_note_header_id);

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