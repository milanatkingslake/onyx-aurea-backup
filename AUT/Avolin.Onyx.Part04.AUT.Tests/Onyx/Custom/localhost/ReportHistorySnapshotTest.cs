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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ReportHistorySnapshot" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReportHistorySnapshotTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportHistorySnapshot" />)
        /// </summary>
        public ReportHistorySnapshotTest() : base(typeof(ReportHistorySnapshot))
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

        #region General Initializer : Class (ReportHistorySnapshot) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _reportHistorySnapshotInstanceType;
        private ReportHistorySnapshot _reportHistorySnapshotInstance;
        private ReportHistorySnapshot _reportHistorySnapshotInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReportHistorySnapshot" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _reportHistorySnapshotInstanceType = typeof(ReportHistorySnapshot);
            _reportHistorySnapshotInstanceFixture = this.Create<ReportHistorySnapshot>(false);
            _reportHistorySnapshotInstance = _reportHistorySnapshotInstanceFixture ?? this.Create<ReportHistorySnapshot>(true);
            CurrentInstance = _reportHistorySnapshotInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReportHistorySnapshot) Initializer

        #region Properties

        private const string PropertyHistoryID = "HistoryID";
        private const string PropertyCreationDate = "CreationDate";

        #endregion

        #region Fields

        private const string FieldhistoryIDField = "historyIDField";
        private const string FieldcreationDateField = "creationDateField";
        private const string FieldsizeField = "sizeField";

        #endregion

        #endregion

        #region General Initializer : Class (ReportHistorySnapshot) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ReportHistorySnapshot" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportHistorySnapshot_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReportHistorySnapshot) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ReportHistorySnapshot" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportHistorySnapshot_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReportHistorySnapshot) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ReportHistorySnapshot" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportHistorySnapshot_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ReportHistorySnapshot)

        #region General Initializer : Class (ReportHistorySnapshot) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ReportHistorySnapshot" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyHistoryID)]
        [TestCase(PropertyCreationDate)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ReportHistorySnapshot_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ReportHistorySnapshot) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ReportHistorySnapshot" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldhistoryIDField)]
        [TestCase(FieldcreationDateField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ReportHistorySnapshot_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ReportHistorySnapshot) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ReportHistorySnapshot" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ReportHistorySnapshot_Is_Instance_Present_Test()
        {
            // Assert
            _reportHistorySnapshotInstanceType.ShouldNotBeNull();
            _reportHistorySnapshotInstance.ShouldNotBeNull();
            _reportHistorySnapshotInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ReportHistorySnapshot) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ReportHistorySnapshot" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ReportHistorySnapshot_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _reportHistorySnapshotInstance.ShouldBeAssignableTo<ReportHistorySnapshot>();
            _reportHistorySnapshotInstanceFixture.ShouldBeAssignableTo<ReportHistorySnapshot>();
            CurrentInstance.ShouldBeAssignableTo<ReportHistorySnapshot>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ReportHistorySnapshot) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ReportHistorySnapshot_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ReportHistorySnapshot instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ReportHistorySnapshot) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyHistoryID)]
        [TestCase(PropertyCreationDate)]
        public void AUT_ReportHistorySnapshot_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ReportHistorySnapshot) => Property (CreationDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportHistorySnapshot_CreationDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCreationDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCreationDate);
            Action currentAction = () => propertyInfo.SetValue(_reportHistorySnapshotInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportHistorySnapshot) => Property (CreationDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportHistorySnapshot_Public_Class_CreationDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCreationDate);
            var propertyInfo = this.GetPropertyInfo(PropertyCreationDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportHistorySnapshot) => Property (HistoryID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportHistorySnapshot_Public_Class_HistoryID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHistoryID);
            var propertyInfo = this.GetPropertyInfo(PropertyHistoryID);

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